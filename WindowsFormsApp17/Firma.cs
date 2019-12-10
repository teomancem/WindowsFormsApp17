using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17
{
   public class Firma
    {
        public List<Kullanici> Kullanicilar { get; set; }
        public string CalisanEkle(Kullanici kullanici)
        {
            string tmp = " ";
            foreach (Kullanici kul in Kullanicilar)
            {
                tmp = kul.İsim;

            }
            return tmp;
        }
        
    }
}
