using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

            string js_path = targetPath + "js\\test.js";
            var content = File.ReadAllText(js_path);
            string oldStr = "numberOfQuestion = 100;";
            string newStr = "numberOfQuestion = " + total_number_of_question + ";";
            content = content.Replace(oldStr,newStr);
            File.WriteAllText(js_path,content);
        }

        //static void WalkDirectoryTree(DirectoryInfo root, string targetPath)
        //{
        //    FileInfo[] files = null;
        //    DirectoryInfo[] subDirs = null;

        //    // First, process all the files directly under this folder
        //    try
        //    {
        //        files = root.GetFiles("*.*");
        //    }
        //    // This is thrown if even one of the files requires permissions greater
        //    // than the application provides.
        //    catch (UnauthorizedAccessException e)
        //    {
        //        // This code just writes out the message and continues to recurse.
        //        // You may decide to do something different here. For example, you
        //        // can try to elevate your privileges and access the file again.
        //        System.Diagnostics.Debug.WriteLine(e.Message);
        //    }

        //    catch (DirectoryNotFoundException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    if (files != null)
        //    {
        //        foreach (FileInfo fi in files)
        //        {
        //            // In this example, we only access the existing FileInfo object. If we
        //            // want to open, delete or modify the file, then
        //            // a try-catch block is required here to handle the case
        //            // where the file has been deleted since the call to TraverseTree().
        //            Console.WriteLine(fi.FullName);
        //        }

        //        // Now find all the subdirectories under this directory.
        //        subDirs = root.GetDirectories();

        //        foreach (DirectoryInfo dirInfo in subDirs)
        //        {
        //            // Resursive call for each subdirectory.
        //            WalkDirectoryTree(dirInfo);
        //        }
        //    }
        //}

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
            for (i = 0; i < 10; i++) // i max = number of source file
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
    }
}
