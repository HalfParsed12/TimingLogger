using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setup_Advisor
{
    public class LapTime : IComparable<LapTime>
    {
        // TODO: refactor to array of floats? enumerate indices: total, s1, s2, s3 ---- what's the benefit?
        public float sector1 { get; } = 0;
        public float sector2 { get; } = 0;
        public float sector3 { get; } = 0;
        public bool valid { get; } = true;
        public float total { get; }

        public int CompareTo(LapTime other)
        {
            return total.CompareTo(other.total);
        }

        public LapTime()
        {
            total = sector1 + sector2 + sector3;
        }

        public LapTime(float sector2, float sector3, float total, bool valid)
        {
            sector1 = (float)Math.Round(total - sector2 - sector3, 3);
            this.sector2 = (float)Math.Round(sector2, 3);
            this.sector3 = (float)Math.Round(sector3, 3);
            this.total = (float)Math.Round(total, 3);
            this.valid = valid;
        }
        
        // overload operators to allow averaging
        public static LapTime operator +(LapTime a, LapTime b)
        {
            float s2 = a.sector2 + b.sector2;
            float s3 = a.sector3 + b.sector3;
            float total = a.total + b.total;
            LapTime lap = new LapTime(s2, s3, total, true);
            return lap;
        }
        
        public static LapTime operator /(LapTime a, int b)
        {
            float s2 = a.sector2 / b;
            float s3 = a.sector3 / b;
            float total = a.total / b;
            LapTime lap = new LapTime(s2, s3, total, true);
            return lap;
        }
    }
}
