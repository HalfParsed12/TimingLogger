using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setup_Advisor
{
    class Run
    {
        public int id { get; set; }
        public string title { get; set; } = "New Run";
        public string description { get; set; } = "Description";
        public List<LapTime> times { get; set; } = new List<LapTime>();
        public string trackLocation { get; set; } = null;
        public string trackVariant { get; set; } = null;
        public string car { get; set; } = null;
        public enum Sector { ALL_SECTORS, SECTOR_ONE, SECTOR_TWO, SECTOR_THREE };

        public LapTime Average()
        {
            return times.Aggregate((a, b) => a + b) / times.Count();
        }


        public double CalculateStdDeviation(Sector sector)
        {
            LapTime avg = Average();
            switch ((int)sector)
            {
                case 0: return Math.Sqrt(times.Average(v => Math.Pow(v.total - avg.total, 2)));
                case 1: return Math.Sqrt(times.Average(v => Math.Pow(v.sector1 - avg.sector1, 2)));
                case 2: return Math.Sqrt(times.Average(v => Math.Pow(v.sector2 - avg.sector2, 2)));
                case 3: return Math.Sqrt(times.Average(v => Math.Pow(v.sector3 - avg.sector3, 2)));
            }
            return -1;
        }

        public LapTime GetBestValid()
        {
            return times.Where(item => item.valid).Min();
        }
    }
}
