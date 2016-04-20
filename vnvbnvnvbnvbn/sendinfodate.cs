using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace vnvbnvnvbnvbn
{
    public class sendinfodate : senddata
    {

        public override string ToString()
        {
            string aa = "Wykonaj: " + name + " dla miasta " + city + " i wyslij na " + address; 
            return aa;
        }


        public override void ShowInfo()
        {
            WebClient pageInfo = new WebClient();
            string adres = "http://api.openweathermap.org/data/2.5/weather?q=" + city + ",pl&APPID=94358ce2861d71ffadb4a10a4fae8d28";
            var dzejson = pageInfo.DownloadString(adres);
            var a = JsonConvert.DeserializeObject<RootObject>(dzejson);
            double stopnie = a.main.temp - 273.15;
            double cisnienie = a.main.pressure;
            string opis_ang = a.weather[0].description;
            string opis_pogody = "Dzisiejsza pogoda dla miasta " + city + " - mamy " + stopnie + " stopni Celsjusza. Ciśnienie wynosi  " + cisnienie + " hPa. A jak niebo? " + opis_ang;
            if (stopnie > Convert.ToDouble(temp))
            {
                Form sf = new Form();
                Label pb = new Label();
                pb.Text = opis_pogody;
                pb.AutoSize = true;
                sf.Controls.Add(pb);
                sf.AutoSize = true;
                sf.Show();
            }
        }

        public override void SendMsg()
        {
            WebClient pageInfo = new WebClient();
            string adres = "http://api.openweathermap.org/data/2.5/weather?q=" + city + ",pl&APPID=94358ce2861d71ffadb4a10a4fae8d28";
            var dzejson = pageInfo.DownloadString(adres);
            var a = JsonConvert.DeserializeObject<RootObject>(dzejson);
            double stopnie = a.main.temp - 273.15;
            double cisnienie = a.main.pressure;
            string opis_ang = a.weather[0].description;
            string opis_pogody = "Dzisiejsza pogoda dla miasta " + city + " - mamy " + stopnie + " stopni Celsjusza. Ciśnienie wynosi  " + cisnienie + " hPa. A jak niebo? " + opis_ang;
            if (stopnie > Convert.ToDouble(temp))
            {
                sendinfoinemail send = new sendinfoinemail();
                send.SendEmail(address, opis_pogody);
            }
        }



    }
}
