using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Slot
    {
        [JsonProperty("SlotID")]
        public int SlotID { get; set; }

        [JsonProperty("SlotTime")]
        public string SlotTime { get; set; }

        [JsonProperty("ResultNumber")]
        public int ResultNumber { get; set; }

        [JsonProperty("Tickets")]
        public int Tickets { get; set; }

        [JsonProperty("Wins")]
        public int Wins { get; set; }

        [JsonProperty("RowNum")]
        public int RowNum { get; set; }
    }
}
