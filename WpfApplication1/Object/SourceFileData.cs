using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDeTracNghiem.Class;
using TronDeTracNghiem.Code;

namespace TronDeTracNghiem.Object
{
    public class SourceFileData : FileData
    {
        static int count = 0;
        public static int[] random_List = new int[] { };


        public string[] Process (int number, int begin_count)
        {
            if (path != null )
            {
                count = begin_count;

                //content = File.ReadAllText(path); // old Func

                content = CheckFile.Process(ReadAll()); // new Func

                string[] seperate_file = content.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);

                string[] after_Random = Random_and_Select(seperate_file, number);

                return after_Random;
            }
            else
            {
                random_List = null;
                string[] emptyStr = new string[0];
                return emptyStr;
            }
            
        }
        public List<string> ReadAll()
        {
            if (path != null)
            {
                content = File.ReadAllText(path);
                if (content == "")
                {
                    return null;
                }
                List<string> seperate_file = content.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None).ToList();
                seperate_file.RemoveAt(0);
                List<string> after_split = new List<string>();
                foreach (var item in seperate_file)
                {
                    string Str = "<div class=\"question\">" + item;
                    after_split.Add(Str);
                }

                return after_split;
            }
            else
            {
                random_List = null;
                //string[] emptyStr = new string[0];
                return null;
            }

        }
        private static string[] Random_and_Select(string[] content, int number)
        {
            
            string[] afterRdm = new string[number];
            //Random rdm = new Random();

            var i = 0;
            var j = 0;
            int[] randomList = new int[number];
            int sourceLength = content.Length;
            bool isExist = false;


            // add random numder list
            for (i = 0; i < number; i++)
            {
                int num = StaticRandom.Instance.Next(1, sourceLength);
                // check if random number exist in array
                for (j = 0; j < number; j++)
                {
                    if (num == randomList[j])
                    {
                        isExist = true;
                        //System.Diagnostics.Debug.WriteLine("-----"+ num);
                        i--;
                        break;
                    }
                    else
                    {
                        isExist = false;
                    }
                }
                if (!isExist)
                {
                    randomList[i] = num;
                }
            } // finish adding random numder list

            random_List = randomList;

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
        private static string replace_number(string content, int count, int n)
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
        public int[] get_RandomList ()
        {
            return random_List;
        }
    }
}
