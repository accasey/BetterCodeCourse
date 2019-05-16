﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    class Painters
    {
        private IEnumerable<IPainter> ContainedPainters { get; }
        public Painters(IEnumerable<IPainter> painters)
        {
            this.ContainedPainters = painters.ToList();
        }

        // allows for method chaining by returning a new Painters
        public Painters GetAvailable() =>
            new Painters(this.ContainedPainters.Where(painter => painter.IsAvailable));

        public IPainter GetCheapestOne(double sqMeters) =>
            this.ContainedPainters.WithMinimum(painter => painter.EstimateCompensation(sqMeters));

        public IPainter GetFastestOne(double sqMeters) =>
            this.ContainedPainters.WithMinimum(painter => painter.EstimateTimeToPaint(sqMeters));
    }
}
