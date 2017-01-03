using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Class;
using WpfApplication1.Object;

namespace WpfApplication1.Code
{
    public class Function
    {
        static int count = 1;

        public static void AutoMerge(DataToMerge obj, NumberToMerge number)
        {
            //var Content_file_1 = File.ReadAllText(obj.file_1.path);
            //var Content_file_2 = File.ReadAllText(obj.file_2.path);
            //var Content_file_3 = File.ReadAllText(obj.file_3.path);

            // process result file




            //end process result file

            //string[] seperate_file_1 = Content_file_1.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);
            //string[] seperate_file_2 = Content_file_2.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);
            //string[] seperate_file_3 = Content_file_3.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);

            ResultList result = new ResultList();
            
            string[] after_Random_file_1 = obj.file_1.Process(number.file_1, count);
            //var randomList_1 = obj.result_1.Write_random_list(obj.file_1.get_RandomList());
            var randomList_1 = obj.file_1.get_RandomList();
            count += number.file_1; // begin count file 2
            string[] seperate_result_1 = obj.result_1.Split_all_result();

            string[] after_Random_file_2 = obj.file_2.Process(number.file_2, count);
            //var randomList_2 = obj.result_2.Write_random_list(obj.file_2.get_RandomList());
            var randomList_2 = obj.file_2.get_RandomList();
            count += number.file_2; // begin count file 3
            string[] seperate_result_2 = obj.result_2.Split_all_result();

            string[] after_Random_file_3 = obj.file_3.Process(number.file_3, count);
            //var randomList_3 = obj.result_3.Write_random_list(obj.file_3.get_RandomList());
            var randomList_3 = obj.file_3.get_RandomList();
            string[] seperate_result_3 = obj.result_3.Split_all_result();

            // combine result
            result.result_List_1 = obj.result_1.Get_Selected_Result(randomList_1);
            result.result_List_2 = obj.result_2.Get_Selected_Result(randomList_2);
            result.result_List_3 = obj.result_3.Get_Selected_Result(randomList_3);

            Write_result_to_file(obj, result);
            // end combine

            var i = 0;
            var j = 0;
             

            var file_final_path = obj.file_final.path + "\\";

            string file_final_name = "final" + ".cshtml";

            var file_final = file_final_path + file_final_name;

            if (File.Exists(file_final))
            {
                File.Delete(file_final);
            }
            else
            {
                //System.IO.File.Create(new_file_path);
            }

            try
            {
                using (StreamWriter file = new StreamWriter(file_final, false, Encoding.UTF8))
                {
                    

                    string[][] combine = new string[10][];
                    combine[0] = after_Random_file_1;
                    combine[1] = after_Random_file_2;
                    combine[2] = after_Random_file_3;
                    
                    
                    //the number of array is from 0-100 (0 is the content before the first <div>, the needed contents is from 1 to 100)
                    string finalStr = "";

                    for (i = 0; i < 3; i++) // i max = number of source file
                    {
                        for (j = 0; j < combine[i].Length; j++)
                        {
                            // combine all question after random each file

                            finalStr += combine[i][j];

                        }
                    }
                    
                    file.WriteLine(finalStr);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }
        }
        
        private static void Write_result_to_file (DataToMerge obj, ResultList result)
        {
            var result_final_path = obj.file_final.path + "\\";

            string result_final_name = "result" + ".txt";

            var result_final = result_final_path + result_final_name;

            if (File.Exists(result_final))
            {
                File.Delete(result_final);
            }
            else
            {
                //System.IO.File.Create(new_file_path);
            }
            try
            {
                using (StreamWriter file = new StreamWriter(result_final, false, Encoding.UTF8))
                {


                    string[][] combine = new string[10][];
                    combine[0] = result.result_List_1;
                    combine[1] = result.result_List_2;
                    combine[2] = result.result_List_3;


                    //the number of array is from 0-100 (0 is the content before the first <div>, the needed contents is from 1 to 100)
                    string finalStr = "";
                    int count = 1;
                    var i = 0;
                    var j = 0;
                    for (i = 0; i < 3; i++) // i max = number of source file
                    {
                        for (j = 0; j < combine[i].Length; j++)
                        {
                            // combine all question after random each file

                            finalStr += count + combine[i][j] + ".";
                            count++;
                        }
                    }
                    finalStr = finalStr.Remove(finalStr.Length-1);
                    file.WriteLine(finalStr);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }
        }
    }
}
