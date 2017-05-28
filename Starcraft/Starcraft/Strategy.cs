using System;
using SQLite.Net.Attributes;

namespace Starcraft
{
    public class Strategy
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string matchup { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string body { get; set; }
        public DateTime CreatedOn { get; set; }

        public Strategy()
        {
        }
    }
}
