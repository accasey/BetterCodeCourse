using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    class ProportionalPainter : IPainter
    {
        // Objects of this class my represent real people, but it might also represent
        // something else, like a group of people who are dividing work amongst themselves.
        // An object of this class can be a single object or a facade hiding a group of 
        // objects.
        // This is the 'composite pattern'.


        public TimeSpan TimePerSqMeter { get; set; }
        public double DollarsPerHour { get; set; }

        public bool IsAvailable => true;

        public double EstimateCompensation(double sqMeters) =>
            this.EstimateTimeToPaint(sqMeters).TotalHours * this.DollarsPerHour;

        public TimeSpan EstimateTimeToPaint(double sqMeters) =>
            TimeSpan.FromHours(this.TimePerSqMeter.TotalHours * sqMeters);
    }
}
