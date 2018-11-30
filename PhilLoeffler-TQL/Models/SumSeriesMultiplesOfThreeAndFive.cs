using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhilLoeffler_TQL.Models {

    public class SumSeriesMultiplesOfThreeAndFive {

        public static int FilterAndSum(int nbr) {
            var total = 0;
            for(var idx = 1; idx < nbr; idx++) {
                if(idx % 3 == 0 || idx % 5 == 0) {
                    total += idx;
                }
            }
            return total;
        }
    }
}