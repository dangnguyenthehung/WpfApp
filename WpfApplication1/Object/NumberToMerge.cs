using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronDeTracNghiem.Object
{
    public class NumberToMerge
    {
        public List<NumberToMergeItem> files { get; set; }

        public int destination_number { get; set; }
    }
    public class NumberToMergeItem
    {
        public int file_number { get; set; }

        //public int index { get; set; }
    }
}
