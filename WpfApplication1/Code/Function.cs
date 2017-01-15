using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDeTracNghiem.Class;
using TronDeTracNghiem.Object;

namespace TronDeTracNghiem.Code
{
    public class Function
    {
        static int count = 1;

        public static void AutoMerge(DataToMerge obj, NumberToMerge number)
        {
            var d = 1;
            for (d = 1; d <= number.destination_number; d++)
            {
                count = 1;
                ResultList result = new ResultList();
                ContentList data = new ContentList();
            
                data.content_after_random_1 = obj.file_1.Process(number.file_1, count);
                //var randomList_1 = obj.result_1.Write_random_list(obj.file_1.get_RandomList());
                var randomList_1 = obj.file_1.get_RandomList();
                count += number.file_1; // begin count file 2
                //string[] seperate_result_1 = obj.result_1.Split_all_result();

                data.content_after_random_2 = obj.file_2.Process(number.file_2, count);
                var randomList_2 = obj.file_2.get_RandomList();
                count += number.file_2; // begin count file 3

                data.content_after_random_3 = obj.file_3.Process(number.file_3, count);
                var randomList_3 = obj.file_3.get_RandomList();
                count += number.file_3; // begin count file 4

                data.content_after_random_4 = obj.file_4.Process(number.file_4, count);
                var randomList_4 = obj.file_4.get_RandomList();
                count += number.file_4; // begin count file 5

                data.content_after_random_5 = obj.file_5.Process(number.file_5, count);
                var randomList_5 = obj.file_5.get_RandomList();
                count += number.file_5; // begin count file 6

                data.content_after_random_6 = obj.file_6.Process(number.file_6, count);
                var randomList_6 = obj.file_6.get_RandomList();
                count += number.file_6; // begin count file 7

                data.content_after_random_7 = obj.file_7.Process(number.file_7, count);
                var randomList_7 = obj.file_7.get_RandomList();
                count += number.file_7; // begin count file 8

                data.content_after_random_8 = obj.file_8.Process(number.file_8, count);
                var randomList_8 = obj.file_8.get_RandomList();
                count += number.file_8; // begin count file 9

                data.content_after_random_9 = obj.file_9.Process(number.file_9, count);
                var randomList_9 = obj.file_9.get_RandomList();
                count += number.file_9; // begin count file 10

                data.content_after_random_10 = obj.file_10.Process(number.file_10, count);
                var randomList_10 = obj.file_10.get_RandomList();
                
                // combine result
                result.result_List_1 = obj.result_1.Get_Selected_Result(randomList_1);
                result.result_List_2 = obj.result_2.Get_Selected_Result(randomList_2);
                result.result_List_3 = obj.result_3.Get_Selected_Result(randomList_3);
                result.result_List_4 = obj.result_4.Get_Selected_Result(randomList_4);
                result.result_List_5 = obj.result_5.Get_Selected_Result(randomList_5);
                result.result_List_6 = obj.result_6.Get_Selected_Result(randomList_6);
                result.result_List_7 = obj.result_7.Get_Selected_Result(randomList_7);
                result.result_List_8 = obj.result_8.Get_Selected_Result(randomList_8);
                result.result_List_9 = obj.result_9.Get_Selected_Result(randomList_9);
                result.result_List_10 = obj.result_10.Get_Selected_Result(randomList_10);

                Write_content_to_file(obj, data, d);
                Write_result_to_file(obj, result, d);
            }
            // end combine
        }
         // begin group of function to check data_file & result_file names
        public static int? check_File_Name(DataToMerge obj)
        {
            int index = 0;
            
            List<string> list_file_name = add_fileName_to_list(obj);
            List<string> list_result_name = add_resultName_to_list(obj);
            List<CompareObject> list = get_list(list_file_name, list_result_name);
            int nullCount = 0;

            string des_path = obj.file_final.path;
            if (des_path == null)
            {
                index = -1;
                return index;
            }

            foreach (var item in list)
            {
                if (item.file_name != item.result_name)
                {
                    index = list.IndexOf(item) + 1;
                    return index;
                }
                if (item.file_name == "")
                {
                    nullCount++;
                }
            }
            if (nullCount == list.Count)
            {
                return null;
            }
            return index;
            
        }
        private static List<string> add_fileName_to_list(DataToMerge obj)
        {
            List<string> list = new List<string>();
            list.Add(get_File_Name(obj.file_1.path));
            list.Add(get_File_Name(obj.file_2.path));
            list.Add(get_File_Name(obj.file_3.path));
            list.Add(get_File_Name(obj.file_4.path));
            list.Add(get_File_Name(obj.file_5.path));
            list.Add(get_File_Name(obj.file_6.path));
            list.Add(get_File_Name(obj.file_7.path));
            list.Add(get_File_Name(obj.file_8.path));
            list.Add(get_File_Name(obj.file_9.path));
            list.Add(get_File_Name(obj.file_10.path));

            return list;
        }
        private static List<string> add_resultName_to_list(DataToMerge obj)
        {
            List<string> list = new List<string>();
            list.Add(get_File_Name(obj.result_1.path));
            list.Add(get_File_Name(obj.result_2.path));
            list.Add(get_File_Name(obj.result_3.path));
            list.Add(get_File_Name(obj.result_4.path));
            list.Add(get_File_Name(obj.result_5.path));
            list.Add(get_File_Name(obj.result_6.path));
            list.Add(get_File_Name(obj.result_7.path));
            list.Add(get_File_Name(obj.result_8.path));
            list.Add(get_File_Name(obj.result_9.path));
            list.Add(get_File_Name(obj.result_10.path));

            return list;
        }

        private static List<CompareObject> get_list(List<string> file_list, List<string> result_list)
        {
            List<CompareObject> list = new List<CompareObject>();
            for (var i = 0; i < file_list.Count; i++)
            {
                CompareObject obj = new CompareObject();
                obj.file_name = file_list[i];
                obj.result_name = result_list[i];
                list.Add(obj);
            }
            return list;
        }

        private static string get_File_Name(string path)
        {
            if (path == null)
            {
                return "";
            }
            var split = path.Split('\\');
            int index = split.Length - 1;
            var file_name_with_extenstion = split[index].Split('.');
            var file_name = file_name_with_extenstion[0];
            System.Diagnostics.Debug.WriteLine(file_name);
            return file_name;
        } // end check file name

        private static void Write_content_to_file(DataToMerge obj, ContentList data, int d)
        {
            var i = 0;
            var j = 0;

            var file_final_path = obj.file_final.path + "\\Data\\";
            var file_final_path_backup = obj.file_final.path + "\\Backup\\";
            var file_final_path_word = obj.file_final.path + "\\Data\\Word\\";

            string file_final_name = obj.Type.value + "_" + d + ".cshtml";
            string file_final_name_backup = obj.Type.value + "_" + d + ".html";
            string file_final_name_word = obj.Type.value + "_" + d + ".doc";

            var file_final = file_final_path + file_final_name;
            var file_final_backup = file_final_path_backup + file_final_name_backup;
            var file_final_word = file_final_path_word + file_final_name_word;

            // check if folder exist
            if (!Directory.Exists(file_final_path))
            {
                Directory.CreateDirectory(file_final_path);
            }
            if (!Directory.Exists(file_final_path_backup))
            {
                Directory.CreateDirectory(file_final_path_backup);
            }
            if (!Directory.Exists(file_final_path_word))
            {
                Directory.CreateDirectory(file_final_path_word);
            }

            if (File.Exists(file_final))
            {
                File.Delete(file_final);
            }
            else
            {
                //System.IO.File.Create(new_file_path);
            }
            if (File.Exists(file_final_backup))
            {
                File.Delete(file_final_backup);
            }
            try
            {
                string[][] combine = new string[10][];
                combine[0] = data.content_after_random_1;
                combine[1] = data.content_after_random_2;
                combine[2] = data.content_after_random_3;
                combine[3] = data.content_after_random_4;
                combine[4] = data.content_after_random_5;
                combine[5] = data.content_after_random_6;
                combine[6] = data.content_after_random_7;
                combine[7] = data.content_after_random_8;
                combine[8] = data.content_after_random_9;
                combine[9] = data.content_after_random_10;

                //the number of array is from 0-100 (0 is the content before the first <div>, the needed contents is from 1 to 100)
                string combineStr = "";
                string finalStr = "@{\nViewBag.Title = \"" + obj.Type.text + " - " + d + "\";\n" + 
                    "Layout = \"~/Views/Shared/_LayoutClient.cshtml\";\n}\n" +
                    "<h2 class=\"title\">Đối tượng " + obj.Type.text + " - " + d +"</h2>\n";
                string finalStr_backup = "";
                string finalStr_word = "";

                for (i = 0; i < 10; i++) // i max = number of source file
                {
                    for (j = 0; j < combine[i].Length; j++)
                    {
                        // combine all question after random each file
                        combineStr += combine[i][j];
                    }
                } // end combine

                using (StreamWriter file = new StreamWriter(file_final, false, Encoding.UTF8))
                {
                    finalStr += combineStr;
                    file.WriteLine(finalStr);
                }
                using (StreamWriter file = new StreamWriter(file_final_backup, false, Encoding.UTF8))
                {
                    finalStr_backup += combineStr;
                    finalStr_backup = ReadTemplate.Replace_HTML(finalStr_backup);
                    string jsName = obj.Type.value + "_" + d + ".js";
                    finalStr_backup = finalStr_backup.Replace("daBS.js", jsName);
                    file.WriteLine(finalStr_backup);
                }
                using (StreamWriter file = new StreamWriter(file_final_word, false, Encoding.UTF8))
                {
                    finalStr_word = ReadTemplate.Split_for_word(combine);
                    file.WriteLine(finalStr_word);
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }
        }
        private static void Write_result_to_file (DataToMerge obj, ResultList result, int d)
        {
            var result_final_path = obj.file_final.path + "\\Result\\";
            string result_final_name = obj.Type.value + "_" + d + ".txt";
            var result_final = result_final_path + result_final_name;

            var result_final_backup_path = obj.file_final.path + "\\Backup\\js\\";
            string result_final_backup_name = obj.Type.value + "_" + d + ".js";
            var result_final_backup = result_final_backup_path + result_final_backup_name;

            if (!Directory.Exists(result_final_path))
            {
                Directory.CreateDirectory(result_final_path);
            }
            if (!Directory.Exists(result_final_backup_path))
            {
                Directory.CreateDirectory(result_final_backup_path);
            }

            if (File.Exists(result_final))
            {
                File.Delete(result_final);
            }
            if (File.Exists(result_final_backup))
            {
                File.Delete(result_final_backup);
            }
            try
            {
                string[][] combine = new string[10][];
                combine[0] = result.result_List_1;
                combine[1] = result.result_List_2;
                combine[2] = result.result_List_3;
                combine[3] = result.result_List_4;
                combine[4] = result.result_List_5;
                combine[5] = result.result_List_6;
                combine[6] = result.result_List_7;
                combine[7] = result.result_List_8;
                combine[8] = result.result_List_9;
                combine[9] = result.result_List_10;

                string finalStr = "";
                int count = 1;
                var i = 0;
                var j = 0;
                for (i = 0; i < 10; i++) // i max = number of source file
                {
                    for (j = 0; j < combine[i].Length; j++)
                    {
                        // combine all question after random each file

                        finalStr += count + combine[i][j] + ".";
                        count++;
                    }
                }
                finalStr = finalStr.Remove(finalStr.Length - 1);

                using (StreamWriter file = new StreamWriter(result_final, false, Encoding.UTF8))
                {                    
                    file.WriteLine(finalStr);
                }

                string finalStr_backup = "";
                finalStr_backup = ReadTemplate.Replace_JS(combine);
                using (StreamWriter file = new StreamWriter(result_final_backup, false, Encoding.UTF8))
                {
                    file.WriteLine(finalStr_backup);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }
        }

        private static int Get_number_of_question(SourceFileData file)
        {
            int number = 1;

            file.content = File.ReadAllText(file.path);
            string[] seperate_file = file.content.Split(new string[] { "<div class=\"question\">" }, StringSplitOptions.None);

            number = seperate_file.Length -1;

            return number;
        }
        public static ObservableCollection<int> Add_item_combobox (SourceFileData file)
        {
            int number = Get_number_of_question(file);
            ObservableCollection<int> list = new ObservableCollection<int>();
            var i = 1;
            for (i = 1; i <= number; i++)
            {
                list.Add(i);
            }
            return list;
        }
        public static ObservableCollection<int> Add_item_comboBox_destination_number()
        {
            int number = 20;
            ObservableCollection<int> list = new ObservableCollection<int>();
            var i = 1;
            for (i = 1; i <= number; i++)
            {
                list.Add(i);
            }
            return list;
        }
        public static ObservableCollection<TypeItem> Add_item_comboBox_type()
        {
            
            ObservableCollection<TypeItem> list = new ObservableCollection<TypeItem>();
            
            list.Add(new TypeItem("Sỹ quan","SQ"));
            list.Add(new TypeItem("Quân nhân chuyên nghiệp", "QNCN"));
            list.Add(new TypeItem("Hạ sỹ quan", "HSQ"));
            list.Add(new TypeItem("Đề riêng", "Individual"));
            return list;
        }
    }
}
