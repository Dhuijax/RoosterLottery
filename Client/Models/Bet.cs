using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Bet
    {
        [JsonProperty("BetID")]
        public int BetID { get; set; }

        [JsonProperty("Wol")]
        public string Wol { get; set; }

        [JsonProperty("SlotID")]
        public int SlotID { get; set; }

        [JsonProperty("BetNumber")]
        public int BetNumber { get; set; }

        [JsonProperty("BetTime")]
        public DateTime BetTime { get; set; }
    }
}
