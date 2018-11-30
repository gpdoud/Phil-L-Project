using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhilLoeffler_TQL.Models {

    public class Result {

        public int Id { get; set; }
        public int Input { get; set; }
        public int Sum { get; set; }
        public DateTime DateCreated { get; set; }

        public Result() { }
    }
}