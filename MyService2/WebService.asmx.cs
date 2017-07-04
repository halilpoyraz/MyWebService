using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyService2
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Durum> GetDurums()
        {
            SozlukEntities db = new SozlukEntities();
            return db.Durum.ToList();
        }

        [WebMethod]
        public bool AddDurum(string ad)
        {
            Durum durum = new Durum();
            durum.DurumAdi = ad;

            bool result = false;

            try
            {
                SozlukEntities db = new SozlukEntities();
                db.Durum.Add(durum);
                db.SaveChanges();

                result = true;
            }
            catch (Exception)
            {

                return result;
            }
            return result;
        }
    }
}
