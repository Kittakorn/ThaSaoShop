using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThaSaoShop.Models;

namespace ThaSaoShop.Helpers
{
    public static class Profile
    {
        public static string Username { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }

        //public static string Username => "kittakorn";

        //public static string Name = "กฤตกร ใคร่ครวญ";
        //public static string Role = "เจ้าหน้าที่";

        public static void SetProfile(User user)
        {
            Username = user.Username;
            Name = user.Firstname + " " + user.Lastname;
            Role = user.Role ? "เจ้าหน้าที่" : "พนักงาน";
        }
    }
}