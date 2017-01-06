using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDeTracNghiem.Class;

namespace TronDeTracNghiem.Object
{
    public class ResultFileData : FileData
    {
        public string[] Get_Selected_Result(int[] random_List)
        {
            if (random_List != null)
            {
                var number = random_List.Length;
                string[] seperate_result = Split_all_result();
                string[] selected_str = new string[number];
                var i = 0;
                for (i = 0; i < number; i++)
                {
                    var n = random_List[i];
                    selected_str[i] = seperate_result[n - 1];
                }
                return selected_str;
            }
            else
            {
                string[] emptyStr = new string[0];
                return emptyStr;
            }
            
        }

        public string[] Split_all_result()
        {
            content = File.ReadAllText(path);
            string[] seperate_result = content.Split(new string[] { "." }, StringSplitOptions.None);

            //System.Diagnostics.Debug.WriteLine(content);
            // console show
            var t = 0;
            for (t = 0; t < seperate_result.Length; t++)
            {
                seperate_result[t] = seperate_result[t].Substring(seperate_result[t].Length - 1, 1);
                //System.Diagnostics.Debug.WriteLine((t + 1) + "-" + seperate_result[t]);
            } // end console
            return seperate_result;
        }


        // function write down the random list - just for check!
        public int[] Write_random_list(int[] list)
        {
            var i = 0;
            for (i = 0; i< list.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(list[i]);
            }
            System.Diagnostics.Debug.WriteLine("----");
            return list;
        }
    }
}
