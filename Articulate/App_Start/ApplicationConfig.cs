using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Articulate.App_Start
{
    public static class ApplicationConfig
    {
        public static string VCAP_App;
        public static string ApplicationName;
        public static string InstanceIndex;
        public static string ContainerAddress;
        public static string CellAddress;
        public static string InstanceGUID;
        public static string DotNetVersion;

        public static void GetEnvVars()
        {
            parseVCAP_JSON();
            InstanceIndex = Environment.GetEnvironmentVariable("INSTANCE_INDEX");
            ContainerAddress = Environment.GetEnvironmentVariable("CF_INSTANCE_ADDR");
            CellAddress = Environment.GetEnvironmentVariable("PORT");
            InstanceGUID = Environment.GetEnvironmentVariable("INSTANCE_GUID");
            DotNetVersion = Environment.Version.ToString();
        }
        public static void parseVCAP_JSON()
        {
            try
            {
                VCAP_App = Environment.GetEnvironmentVariable("VCAP_APPLICATION");
                if (VCAP_App != null)
                {
                    JObject json = JObject.Parse(VCAP_App);
                    ApplicationName = json.SelectToken("name").ToString();
                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("*** Error parsing VCAP JSON ***");
                throw;
            }
        }
    }
}