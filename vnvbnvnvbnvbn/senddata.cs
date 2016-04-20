using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace vnvbnvnvbnvbn
{
    abstract public class senddata
    {
        [Key]
        public long id { get; set; }
        public String url { get; set; }
        public String address { get; set; }
        public String text { get; set; }
        public String name { get; set; }
        public String temp { get; set; }
        public String city { get; set; }
        public String option { get; set; } //img


        abstract public void SendMsg();
        abstract public void ShowInfo();

        public void Check()
        {
            if (option == "email")
            {
                SendMsg();
            }
            else
            {
                ShowInfo();
            }

        }
       

       

    }
}
