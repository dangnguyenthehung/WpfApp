using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronDeTracNghiem.Object
{
    public class DataToMerge
    {
        // source file
        public SourceFileData file_1 = new SourceFileData();
        public SourceFileData file_2 = new SourceFileData();
        public SourceFileData file_3 = new SourceFileData();
        public SourceFileData file_4 = new SourceFileData();
        public SourceFileData file_5 = new SourceFileData();
        public SourceFileData file_6 = new SourceFileData();
        public SourceFileData file_7 = new SourceFileData();
        public SourceFileData file_8 = new SourceFileData();
        public SourceFileData file_9 = new SourceFileData();
        public SourceFileData file_10 = new SourceFileData();

        public SourceFileData file_final = new SourceFileData();
       

        // result file
        public ResultFileData result_1 = new ResultFileData();
        public ResultFileData result_2 = new ResultFileData();
        public ResultFileData result_3 = new ResultFileData();
        public ResultFileData result_4 = new ResultFileData();
        public ResultFileData result_5 = new ResultFileData();
        public ResultFileData result_6 = new ResultFileData();
        public ResultFileData result_7 = new ResultFileData();
        public ResultFileData result_8 = new ResultFileData();
        public ResultFileData result_9 = new ResultFileData();
        public ResultFileData result_10 = new ResultFileData();

        public SourceFileData result_final = new SourceFileData();

        public string Type { get; set; }
    }
}
