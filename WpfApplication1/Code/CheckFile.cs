using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDeTracNghiem.Object;

namespace TronDeTracNghiem.Code
{
    public class CheckFile
    {
        public static string Process(List<string> content)
        {
            string final = "";
            if (content != null)
            {
                string[] data = Split_data(content);
                for (var i = 0; i < data.Length; i++)
                {
                    final += data[i];
                }
            }
            
            return final;
        }
        private static string[] Split_data(List<string> content)
        {
            int number = content.Count;
            string[] finalStr = new string[number];
            var i = 0;
            foreach (var item in content)
            {
                string afterStr = Check(item);
                finalStr[i] += afterStr;
                i++;
            }

            return finalStr;
        }

        private static string Check(string data) // data = <div class="question"> .... </div>
        {
            var oldStr_doubleNewLine = Environment.NewLine + Environment.NewLine;
            var newStr_newLine = Environment.NewLine;
            
            string finalStr = "";
            string start_content = "</span>";
            string end_content = "</b>";

            string start_result = "'\">";
            string end_result = "</p>";

            int start_index = 0;
            int end_index = 0;
            //string content = "";
            
            start_index = data.IndexOf(start_content) + 7;
            end_index = data.IndexOf(end_content);
            if (end_index == -1) // -1 mean not exist
            {
                var oldStr = "</h3>";
                var newStr = "</b>"+ Environment.NewLine + "</h3>";
                data = data.Replace(oldStr, newStr);
            }
            
            // split result a..., b.., c..
            var result_group_split = data.Split(new string[] { "<p>" }, StringSplitOptions.None);
            // [0] is the content of question
            finalStr += result_group_split[0];

            for (var t = 1; t < result_group_split.Length; t++)
            {          
                start_index = result_group_split[t].IndexOf(start_result) + 3;
                end_index = result_group_split[t].IndexOf(end_result);
                
                if (end_index == -1 && (t != (result_group_split.Length - 1)))
                {
                    result_group_split[t] = result_group_split[t] + end_result; // end_result = "</p>"
                }
                if (t == (result_group_split.Length - 1))
                {
                    var oldStr = "<div id=";
                    var newStr = "</p>"+ Environment.NewLine + "<div id=";
                    result_group_split[t] = result_group_split[t].Replace(oldStr, newStr);
                }
                result_group_split[t] = result_group_split[t].Replace(oldStr_doubleNewLine, newStr_newLine) + Environment.NewLine;
                string Str = "<p>" + result_group_split[t];
                
                finalStr += Str;
            }

            return finalStr;
        }
    }
}
