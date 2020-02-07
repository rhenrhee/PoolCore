using Newtonsoft.Json;

namespace CorePool.Blockchain.Cryptonote.DaemonResponses
{
    public class GetBlockTemplateResponse
    {
        [JsonProperty("blocktemplate_blob")]
        public string Blob { get; set; }

        public long Difficulty { get; set; }
        public uint Height { get; set; }

        [JsonProperty("prev_hash")]
        public string PreviousBlockhash { get; set; }

        [JsonProperty("reserved_offset")]
        public int ReservedOffset { get; set; }

        public string Status { get; set; }
    }
}
