using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Object
{
    public class DataToMerge
    {
        // source file
        public SourceFileData file_1 = new SourceFileData();
        public SourceFileData file_2 = new SourceFileData();
        public SourceFileData file_3 = new SourceFileData();
        //public FileData file_4 { get; set; }
        //public FileData file_5 { get; set; }
        //public FileData file_6 { get; set; }
        //public FileData file_7 { get; set; }
        //public FileData file_8 { get; set; }
        //public FileData file_9 { get; set; }
        //public FileData file_10 { get; set; }

        public SourceFileData file_final = new SourceFileData();
       

        // result file
        public ResultFileData result_1 = new ResultFileData();
        public ResultFileData result_2 = new ResultFileData();
        public ResultFileData result_3 = new ResultFileData();

        public SourceFileData result_final = new SourceFileData();
    }
}
