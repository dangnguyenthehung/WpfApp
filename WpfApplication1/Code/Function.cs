using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Object;

namespace WpfApplication1.Code
{
    public class Function
    {
        static int count = 1;

        public static void AutoMerge(DataToMerge obj, NumberToMerge number)
        {
            var Content_file_1 = File.ReadAllText(obj.file_1.path);
            var Content_file_2 = File.ReadAllText(obj.file_2.path);
            var Content_file_3 = File.ReadAllText(obj.file_3.path);

            string[] seperate_file_1 = Content_file_1.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);
            string[] seperate_file_2 = Content_file_2.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);
            string[] seperate_file_3 = Content_file_3.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);

            string[] after_Random_file_1 = Random_and_Select(seperate_file_1, number.file_1);
            string[] after_Random_file_2 = Random_and_Select(seperate_file_2, number.file_2);
            string[] after_Random_file_3 = Random_and_Select(seperate_file_3, number.file_3);

            // demo get & show text from file
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

        public static string[] Random_and_Select (string[] content, int number)
        {
            string[] afterRdm = new string[number];
            Random rdm = new Random();
            var i = 0;
            int[] randomList = new int[number];
            int sourceLength = content.Length;
            bool isExist = false;
            

            // add random numder list
            for (i = 0; i < number; i++)
            {
                int num = rdm.Next(1, sourceLength);
                // check if random number exist in array
                foreach (var item in randomList)
                {
                    if (num == item)
                    {
                        isExist = true;
                        i--;
                        break;
                    }
                }
                if (!isExist)
                {
                    randomList[i] = num;
                }
            } // finish adding random numder list

            for (i = 0; i < number; i++)
            {
                var n = randomList[i];

                //replace number in content[n]
                content[n] = replace_number(content[n], count, n);
                count++;

                afterRdm[i] = "<div class=\"question\">" + content[n];
            }

                return afterRdm;
        }

        public static string replace_number(string content, int count, int n)
        {
            string newContent = "";
            
            string p1 = "id=\"" + n;
            string p2 = "<span>" + n + ". </span>";
            string p3 = "name=\"q" + n + "\"";
            string p4 = "onclick=\"traloi[" + n + "]=";
            string p5 = "DapAn" + n;

            string p1_replaced = "id=\"" + count;
            string p2_replaced = "<span>" + count + ". </span>";
            string p3_replaced = "name=\"q" + count + "\"";
            string p4_replaced = "onclick=\"traloi[" + count + "]=";
            string p5_replaced = "DapAn" + count;

            content = content.Replace(p1, p1_replaced);
            content = content.Replace(p2, p2_replaced);
            content = content.Replace(p3, p3_replaced);
            content = content.Replace(p4, p4_replaced);
            content = content.Replace(p5, p5_replaced);

            newContent = content;

            return newContent;
        }
    }
}
