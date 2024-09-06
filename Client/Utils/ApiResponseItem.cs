using Client.Apis;
using Newtonsoft.Json;
using System.Data;


namespace Client.Utils
{
    public class ApiResponseItem
    {
        [JsonProperty("varvalue")]
        public string VarValue { get; set; }
    }
}
