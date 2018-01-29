using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TronDeTracNghiem.Code
{
    public class ReadTemplate
    {
        private static string folder_path =  Directory.GetCurrentDirectory() + "/Template_OnLuyen/";

        private static string Read_HTML()
        {
            var finalStr = "";
            string path = folder_path + "index.html";
            var data = File.ReadAllText(path);

            finalStr = data;
            //System.Diagnostics.Debug.WriteLine(finalStr);
            return finalStr;
        }
        public static void Copy_Folder(string targetPath, int total_number_of_question)
        {
            string sourcePath = folder_path;
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            if (Directory.Exists(sourcePath))
            {
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
                
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Source path does not exist!");
            }

            //string js_path = targetPath + "js\\test.js";
            //var content = File.ReadAllText(js_path);
            ////string oldStr = "numberOfQuestion = 100;";
            ////string newStr = "numberOfQuestion = " + total_number_of_question + ";";
            ////content = content.Replace(oldStr,newStr);
            //File.WriteAllText(js_path,content);
        }
        
        public static string Replace_HTML(string data)
        {
            string original = Read_HTML();
            string oldStr = "<!-- data -->";
            string final = original.Replace(oldStr, data);

            return final;
        }
        public static string Replace_JS(string[][] data)
        {
            string finalStr = "var dapan=new Array()\n";
            int count = 1;
            var i = 0;
            var j = 0;
            for (i = 0; i < 20; i++) // i max = number of source file
            {
                for (j = 0; j < data[i].Length; j++)
                {
                    // combine all question after random each file dapan[1]='B'

                    finalStr += "dapan[" + count + "]='" + data[i][j] + "';\n";
                    count++;
                }
            }
            return finalStr;
        }
        public static string Split_for_word(string[][] data)
        {
            string finalStr = "";
            int count = 1;
            string start_content = "</span>";
            string end_content = "</b>";

            string start_result = "'\">";
            string end_result = "</p>";

            //string[][] result_combine = new string[10][];

            var i = 0;
            var j = 0;
            for (i = 0; i < 20; i++) // i max = number of source file
            {
                for (j = 0; j < data[i].Length; j++)
                {
                    int start_index = data[i][j].IndexOf(start_content) + 7;
                    int end_index = data[i][j].IndexOf(end_content);
                    var content = data[i][j].Substring(start_index, end_index-start_index);

                    var oldStr = Environment.NewLine;
                    var newStr = "";
                    
                    string str = count + ". " + content;

                    str = Regex.Replace(str, @"\s+", " ");
                    str = str.Replace(oldStr, newStr) + Environment.NewLine;
                    //result_combine[i][j] = str;
                    finalStr += str;

                    // split result a..., b.., c..
                    var result_group_split = data[i][j].Split(new string[] { "<p>" }, StringSplitOptions.None);

                    // [0] is the content of question
                    for (var t = 1; t < result_group_split.Length; t++)
                    {
                        var result = "";
                        try
                        {
                            start_index = result_group_split[t].IndexOf(start_result) + 3;
                            end_index = result_group_split[t].IndexOf(end_result);
                            result = result_group_split[t].Substring(start_index, end_index - start_index);

                            // result_combine[i][j] += result + "\n";
                            result = Regex.Replace(result, @"\s+", " ");
                            result = result.Replace(oldStr, newStr) + Environment.NewLine;
                            
                            finalStr += result;
                        }
                        catch
                        {
                            System.Diagnostics.Debug.WriteLine(str);
                            System.Diagnostics.Debug.WriteLine(result_group_split[t]);
                        }
                    }
                    count++;
                }
            }
            

            return finalStr;
        }

    }
}
