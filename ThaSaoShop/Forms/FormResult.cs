using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaSaoShop.Forms
{
    public partial class FormResult : MetroForm
    {
        public FormResult(FormMain form)
        {
            InitializeComponent();
            if (form.member.MemberId != 0)
            {
                labelMember.Text = form.txtMember.Text;
            }
            else
            {
                labelMember.Text = "สมาชิกทั่วไป";
            }

            labelChange.Text = (Convert.ToInt32(form.numMoney.Value) - Convert.ToInt32(form.lbTotal.Text)).ToString("N0");
            labelProduct.Text = form.sells.Count.ToString();
            labelMoney.Text = form.numMoney.Value.ToString("N0");
            labelTotal.Text = form.lbTotal.Text;
        }

        private void FormResult_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Close();
                    break;
                default: return;
            }
        }
    }
}
