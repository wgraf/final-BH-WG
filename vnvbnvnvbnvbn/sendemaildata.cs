using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vnvbnvnvbnvbn
{

    //enable migration
    //add migration
    //update database

    public class sendemaildata : senddata
    {
       // private object parser;



        public override string ToString()
        {
            string aa = "Wykonaj: " + name + " ze strony " + url + " i wyslij na " + address; 
            return aa;
        }

        public override void SendMsg()
        {
            getinfo info = new getinfo(url, text);
            string imgurl = info.PrintPageNodes();
            if (imgurl != ":(")
            {
                getimg img = new getimg();
                send sendmsg = new send();
                sendmsg.SendEmail(address, img.Downloadimg(imgurl));
            }

        }

        public override void ShowInfo()
        {
            getimg img = new getimg();
            send sendmsg = new send();
            getinfo info = new getinfo(url, text);
            string imgurl = info.PrintPageNodes();
            if (imgurl != ":(")
            {
                Form sf = new Form();
                PictureBox pb = new PictureBox();
                pb.Image = new Bitmap(img.Downloadimg(imgurl));
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                sf.Controls.Add(pb);
                sf.AutoSize = true;
                sf.Show();
            }
                     
        }
    }


}
