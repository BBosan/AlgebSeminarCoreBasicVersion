using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Extra
{
    public static class GlobalFunctions
    {
        public static string StatusDaNe(bool? status, bool statusText = false, string kontroler = "")
        {
            string output = "";

            if (statusText)
            {
                if (kontroler != "")
                {
                    output = (status == false ? "Odbijen" : !status.HasValue ? "Neobradjen" : "Odobren");
                }
                else
                {
                    output = (status == false ? "Otvoren" : "Zatvoren");
                }
            }
            else
            {
                if (kontroler != "")
                {
                    output = (status == false ? "color:crimson" : !status.HasValue ? "color:seagreen" : "color:royalblue");
                }
                else
                {
                    output = (status == false ? "color:royalblue" : "color:crimson");
                }
            }
            return output;
        }

        //public static string StatusDaNe_Lambda(bool? status, bool statusText = false, string output = "") => (statusText) ?
        //    output = (status == false ? "Odbijen" : !status.HasValue ? "Neobradjen" : "Odobren") :
        //    output = (status == false ? "color:crimson" : !status.HasValue ? "color:seagreen" : "color:royalblue");
    }
}
