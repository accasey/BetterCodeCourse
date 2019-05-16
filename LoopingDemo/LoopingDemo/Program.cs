using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingDemo
{
    class Program
    {
        private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            return
                painters
                    //.ThoseAvailable()
                    //.WithMinimum(painter.EstimateCompensation(sqMeters));
                    .Where(painter => painter.IsAvailable)
                    //.OrderBy(painter => painter.EstimateCompensation(sqMeters))
                    //.FirstOrDefault();
                    //.Aggregate((best, cur) =>
                    //    best.EstimateCompensation(sqMeters) < cur.EstimateCompensation(sqMeters) ?
                    //    best : cur );
                    //.Aggregate((IPainter)null, (best, cur) =>
                    //    best == null ||
                    //    cur.EstimateCompensation(sqMeters) < best.EstimateCompensation(sqMeters) ?
                    //    cur : best);
                    .WithMinimum(painter => painter.EstimateCompensation(sqMeters));


        }

        static void Main(string[] args)
        {
        }
    }
}


//double bestPrice = 0;
//IPainter cheapest = null;

//foreach (IPainter painter in painters)
//{
//    if (painter.IsAvailable)
//    {
//        double price = painter.EstimateCompensation(sqMeters);
//        if (cheapest == null || price < bestPrice)
//        {
//            cheapest = painter;
//        }
//    }
//}

//return cheapest;