using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronDeTracNghiem.Class
{
    public class ResultList
    {
        public List<ResultListitem> result_List_Items { get; set; }
        //public string[] result_List_2 { get; set; }
        //public string[] result_List_3 { get; set; }
        //public string[] result_List_4 { get; set; }
        //public string[] result_List_5 { get; set; }
        //public string[] result_List_6 { get; set; }
        //public string[] result_List_7 { get; set; }
        //public string[] result_List_8 { get; set; }
        //public string[] result_List_9 { get; set; }
        //public string[] result_List_10 { get; set; }
        //public string[] result_List_11 { get; set; }
        //public string[] result_List_12 { get; set; }
        //public string[] result_List_13 { get; set; }
        //public string[] result_List_14 { get; set; }
        //public string[] result_List_15 { get; set; }
        //public string[] result_List_16 { get; set; }
        //public string[] result_List_17 { get; set; }
        //public string[] result_List_18 { get; set; }
        //public string[] result_List_19 { get; set; }
        //public string[] result_List_20 { get; set; }
    }
    public class ResultListitem
    {
        public ResultListitem(string[] _result_List, int _index)
        {
            this.result_List = _result_List;
            this.index = _index;
        }

        public string[] result_List { get; set; }
        public int index { get; set; }
    }
}
