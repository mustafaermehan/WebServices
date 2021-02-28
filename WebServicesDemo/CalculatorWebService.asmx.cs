using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://yazilimciningunlugu.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(MessageName ="Adet2RakamTopla")]
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        [WebMethod]
        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        [WebMethod(EnableSession =true)]
        public List<string> GetCalculations()
        {
            if(Session["CALCULATIONS"]== null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("Herhangi bir hesaplama yapmadınız");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }

             
        }
    }
}
