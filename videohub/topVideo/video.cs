using System;
using System.ComponentModel.DataAnnotations;

namespace videohub.topVideo
{
    public class video
    {
        public int ID { get; set; }
        public string title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Length{ get; set; }
        public decimal Rating { get; set; }
    }
}
