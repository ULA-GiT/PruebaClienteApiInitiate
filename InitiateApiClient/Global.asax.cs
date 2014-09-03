using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace InitiateApiClient
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
           // RunAsync().Wait();
        }

        //async Task RunAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://192.168.110.10/InitiateApi/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // New code:
        //        string response = await client.GetStringAsync("api/Initiates/soce.int/alfresco");
        //      //  var sss = response.Content.ReadAsAsync<Initiate>();
        //        //if (response.IsSuccessStatusCode)
        //        //{
        //           // var obj = JsonConvert.DeserializeObject<Initiate>(response.Content.ToString());
        //            List<Initiate> objs = JsonConvert.DeserializeObject<List<Initiate>>(response);
        //            //Initiate obj = await response.Content.ReadAsAsync<Initiate>();
        //            foreach (var obj in objs)
        //            {
        //                 Response.Write(String.Format("{0}\t{1}\t{2}\t{3}", obj.InitiateId,
        //                obj.NombreProceso, obj.VersionProceso,
        //                obj.NombreTarea));
        //            }
                   
        //        //}
        //    }
        //}

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}