using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ammunition_Shop.Classes
{
    class Administrator
    {
        [Key]
        public int ID_Admin { get; set; }
        private string loginAdmin, passAdmin;

        public string LoginAdmin
        {
            get { return loginAdmin; }
            set { loginAdmin = value; }
        }
        public string PassAdmin
        {
            get { return passAdmin; }
            set { passAdmin = value; }
        }

        public Administrator() { }

        public Administrator(string loginAdmin, string passAdmin)
        {
            this.loginAdmin = loginAdmin;
            this.passAdmin = passAdmin;
        }
    }
}
