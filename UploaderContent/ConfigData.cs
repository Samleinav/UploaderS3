using Newtonsoft.Json;
using System.IO;

namespace UploaderContent
{
    public class ConfigData
    {
        public static configdata getCondigData()
        {
            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                
               return JsonConvert.DeserializeObject<configdata>(json);
            }
        }

        
    }
    public class configdata
    {
        public void Add(string a1, string a2, string a3)
        {
            this.S3KeyAccessID = a1;
            this.S3SecretKeyAccess = a2;
            this.region = a3;
        }
        public string S3KeyAccessID { get; set; }
        public string S3SecretKeyAccess { get; set; }
        public string region { get; set; }

        public void SaveChanges()
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            File.WriteAllText("config.json", output);
        }
    }
}
