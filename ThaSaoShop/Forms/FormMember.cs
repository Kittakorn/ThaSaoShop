using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class FormMember : MetroForm
    {
        StoreEntities db;
        private Member member = new Member();
        private List<District> districts;
        private readonly List<Province> provinces;
        private List<SubDistrict> subDistricts;
        private readonly List<Village> villages;

        public FormMember(UserControlMember uc, int id = 0)
        {
            InitializeComponent();
            db = uc.db;
            provinces = db.Provinces.OrderBy(x => x.Name).ToList();
            districts = db.Districts.ToList();
            subDistricts = db.SubDistricts.ToList();
            villages = db.Villages.ToList();
            LoadData();
            if (id != 0)
            {
                Text = "แก้ไขข้อมูล";
                member = db.Members.Find(id);
                txtId.Text = member.MemberId.ToString();
                txtFirstname.Text = member.Firstname;
                txtLastname.Text = member.Lastname;
                txtAddress.Text = member.Address;
                numShare.Minimum = 0;
                numShare.Value = Convert.ToDecimal(member.Share);
                numShare.Enabled = false;
                radioButtonTypeTrue.Checked = member.IsGroup;
                radioButtonMemberTrue.Checked = member.IsMember;
                comVillage.DataSource = villages.ToList();
                comVillage.DisplayMember = "Name";
                comVillage.ValueMember = "VillageId";
                comVillage.SelectedValue = member.VillageId;
                var subDistrict = db.SubDistricts.Include(x => x.District).ToList().FirstOrDefault(x => x.SubDistrictId.Equals(member.SubDistrictId));
                comProvince.SelectedValue = subDistrict.District.ProvinceId;
                comDIstrict.DataSource = districts.Where(x => x.ProvinceId.Equals(subDistrict.District.ProvinceId)).ToList();
                comDIstrict.SelectedValue = subDistrict.DistrictId;
                comSub.DataSource = subDistricts.Where(x => x.DistrictId.Equals(subDistrict.DistrictId)).ToList();
                comSub.SelectedValue = subDistrict.SubDistrictId;
            }
        }

        private void LoadData()
        {
            comVillage.DataSource = villages;
            comVillage.DisplayMember = "Name";
            comVillage.ValueMember = "VillageId";

            comProvince.DataSource = provinces;
            comProvince.DisplayMember = "Name";
            comProvince.ValueMember = "ProvinceId";
            comProvince.SelectedIndex = 2;

            var provinceId = Convert.ToInt32(comProvince.SelectedValue);
            comDIstrict.DataSource = districts.Where(x => x.ProvinceId.Equals(provinceId)).ToList();
            comDIstrict.DisplayMember = "Name";
            comDIstrict.ValueMember = "DistrictId";

            var districtId = Convert.ToInt32(comDIstrict.SelectedValue);
            comSub.DataSource = subDistricts.Where(x => x.DistrictId.Equals(districtId)).ToList(); ;
            comSub.DisplayMember = "Name";
            comSub.ValueMember = "SubDistrictId";
        }

        private void CheckType(bool isType = true)
        {
            if (!radioButtonTypeTrue.Checked) return;
            if (!radioButtonMemberTrue.Checked) return;
            MessageBox.Show("ประเภทกลุุ่มไม่สามารถเป็นสมาชิก อ.บ.ต. ได้", "แจ้งเตือน", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            if (isType)
                radioButtonTypeFalse.Checked = true;
            else
                radioButtonMemberFalse.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                txtFirstname.WithError = true;
                return;
            }
            member.Firstname = txtFirstname.Text.Trim();
            member.Lastname = txtLastname.Text.Trim();
            member.Address = txtAddress.Text.Trim();
            member.SubDistrictId = Convert.ToInt32(comSub.SelectedValue);
            member.VillageId = Convert.ToInt32(comVillage.SelectedValue);
            member.IsGroup = radioButtonTypeTrue.Checked;
            member.IsMember = radioButtonMemberTrue.Checked;
            member.Share = Convert.ToInt32(numShare.Value);

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                db.Members.Add(member);
            }
            else
            {
                db.Entry(member).State = EntityState.Modified;
            }

            try
            {
                db.SaveChanges();
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    db.Shares.Add(new Share()
                    {
                        Amount = member.Share,
                        Date = DateTime.Now,
                        MemberId = member.MemberId,
                        Type = true,
                        Username = Profile.Username
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("ทำรายการสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numPrice_Enter(object sender, EventArgs e)
        {
            numShare.Select(0, numShare.Text.Length);
        }

        private void FormExpensesAdd_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonTypeTrue_CheckedChanged(object sender, EventArgs e)
        {

            CheckType();
        }

        private void radioButtonMemberTrue_CheckedChanged(object sender, EventArgs e)
        {
            CheckType(false);
        }

        private void comboBoxProvince_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var provinceId = Convert.ToInt32(comProvince.SelectedValue);
            comDIstrict.DataSource = districts.Where(x => x.ProvinceId.Equals(provinceId)).ToList();
            var districtId = Convert.ToInt32(comDIstrict.SelectedValue);
            comSub.DataSource = subDistricts.Where(x => x.DistrictId.Equals(districtId)).ToList();
        }

        private void comboBoxDistrict_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var districtId = Convert.ToInt32(comDIstrict.SelectedValue);
            comSub.DataSource = subDistricts.Where(x => x.DistrictId.Equals(districtId)).ToList();
        }
    }
}
