using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;
using TronDeTracNghiem.Object;
using System.IO;
using TronDeTracNghiem.Code;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Threading;
using System.Diagnostics;

namespace TronDeTracNghiem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppName.Content = "TronDeTracNghiem";
            Copyright.Content = "TronDeTracNghiem-v2.0 - Đ.N.T.H";
            label_choose_source.Content = "Chọn các file đề muốn trộn";
            label_choose_result.Content = "Chọn file đáp án tương ứng";
            label_choose_number.Content = "Số câu";

            label_choose_source_Copy.Content = "Chọn các file đề muốn trộn";
            label_choose_result_Copy.Content = "Chọn file đáp án tương ứng";
            label_choose_number_Copy.Content = "Số câu";

            label_type.Content = "Đối tượng:";
            label_choose_destination_folder.Content = "Chọn thư mục để lưu đề sau khi tạo";

            button_Copy.Content = "Kiểm tra";
            count.Content = "Đếm";
            label_number.Content = "Số đề muốn tạo: ";
            button_open_destination_folder.Content = "Mở thư mục lưu đề";
            ObservableCollection<int> list = Function.Add_item_comboBox_destination_number();
            ObservableCollection<TypeItem> list_type = Function.Add_item_comboBox_type();
            comboBox_destination_number.ItemsSource = list;
            comboBox_type.ItemsSource = list_type;
        }
        // declare variable
        private DataToMerge file = new DataToMerge();

        //private Object.File destination_file = new Object.File();

        private NumberToMerge number = new NumberToMerge();

        private void button_1_path_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_1_path.Content = filename;
                file.file_1.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_1);
                comboBox_1_number.ItemsSource = list;
            }
        }
        private void button_2_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_2_path.Content = filename;
                file.file_2.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_2);
                comboBox_2_number.ItemsSource = list;
            }

        }
        private void button_3_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_3_path.Content = filename;
                file.file_3.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_3);
                comboBox_3_number.ItemsSource = list;
            }
        }
        private void button_4_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_4_path.Content = filename;
                file.file_4.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_4);
                comboBox_4_number.ItemsSource = list;
            }
        }
        private void button_5_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_5_path.Content = filename;
                file.file_5.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_5);
                comboBox_5_number.ItemsSource = list;
            }

        }
        private void button_6_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_6_path.Content = filename;
                file.file_6.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_6);
                comboBox_6_number.ItemsSource = list;
            }
        }
        private void button_7_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_7_path.Content = filename;
                file.file_7.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_7);
                comboBox_7_number.ItemsSource = list;
            }
        }
        private void button_8_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_8_path.Content = filename;
                file.file_8.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_8);
                comboBox_8_number.ItemsSource = list;
            }
        }
        private void button_9_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_9_path.Content = filename;
                file.file_9.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_9);
                comboBox_9_number.ItemsSource = list;
            }

        }
        private void button_10_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_10_path.Content = filename;
                file.file_10.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_10);
                comboBox_10_number.ItemsSource = list;
            }
        }
        // update_to 20
        private void button_11_path_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_11_path.Content = filename;
                file.file_11.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_11);
                comboBox_11_number.ItemsSource = list;
            }
        }
        private void button_12_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_12_path.Content = filename;
                file.file_12.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_12);
                comboBox_12_number.ItemsSource = list;
            }

        }
        private void button_13_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_13_path.Content = filename;
                file.file_13.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_13);
                comboBox_13_number.ItemsSource = list;
            }
        }
        private void button_14_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_14_path.Content = filename;
                file.file_14.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_14);
                comboBox_14_number.ItemsSource = list;
            }
        }
        private void button_15_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_15_path.Content = filename;
                file.file_15.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_15);
                comboBox_15_number.ItemsSource = list;
            }

        }
        private void button_16_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_16_path.Content = filename;
                file.file_16.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_16);
                comboBox_16_number.ItemsSource = list;
            }
        }
        private void button_17_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_17_path.Content = filename;
                file.file_17.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_17);
                comboBox_17_number.ItemsSource = list;
            }
        }
        private void button_18_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_18_path.Content = filename;
                file.file_18.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_18);
                comboBox_18_number.ItemsSource = list;
            }
        }
        private void button_19_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_19_path.Content = filename;
                file.file_19.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_19);
                comboBox_19_number.ItemsSource = list;
            }

        }
        private void button_20_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "html files (*.html)|*.html";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_20_path.Content = filename;
                file.file_20.path = filename;
                ObservableCollection<int> list = Function.Add_item_combobox(file.file_20);
                comboBox_20_number.ItemsSource = list;
            }
        }
        //

        private void button_destination_path_Click(object sender, RoutedEventArgs e)
        {
           // var dialog = new System.Windows.Forms.FolderBrowserDialog();
            var dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = true;
            CommonFileDialogResult result = dlg.ShowDialog();

            // Display OpenFileDialog by calling ShowDialog method 
            // Get the selected folder and display in a TextBox 
            if (result == CommonFileDialogResult.Ok)
            {
                // get selected folder
                string filename = dlg.FileName;
                label_destination_path.Content = filename;
                file.file_final.path = filename;
            }
        }


        private bool isFalse = true;
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            int? index = Function.check_File_Name(file);
            
            if (index != 0)
            {
                isFalse = true;
            }
            else if (index == 0)
            {
                isFalse = false;
            }
            if (isFalse)
            {
                done.Foreground = new SolidColorBrush(Color.FromRgb(158, 0, 0));
                done.FontWeight = FontWeights.Normal;
                if (index == -1)
                {
                    button_Copy.Content = "Kiểm tra";
                    SetTextForLabel("Chưa chọn nơi lưu đề!");
                }  
                else if (index == null)
                {
                    button_Copy.Content = "Kiểm tra";
                    SetTextForLabel("Chưa chọn dữ liệu!");
                }              
                else
                {
                    button_Copy.Content = "Kiểm tra";
                    SetTextForLabel("Không đúng File đáp án \n Hàng: " + (index));
                }
            }
            else
            {
                string content = button_Copy.Content.ToString();
                if ( content == "Tạo đề")
                {
                    string targetPath = file.file_final.path + "\\Backup\\";
                    int total = total_number();

                    ReadTemplate.Copy_Folder(targetPath, total);
                    Function.AutoMerge(file, number);

                    SetTextForLabel("Xong");
                    button_Copy.Content = "Kiểm tra";
                    isFalse = true;
                }
                else
                {
                    button_Copy.Content = "Tạo đề";
                    done.Foreground = new SolidColorBrush(Color.FromRgb(0, 95, 215));
                    done.FontWeight = FontWeights.Bold;
                    SetTextForLabel("Sẵn sàng!");
                }

            }
            
            
            //Thread.Sleep(2000);
            
        }
        private int total_number()
        {
            int sum = number.file_1 + number.file_2 + number.file_3 + number.file_4 + number.file_5 + 
                      number.file_6 + number.file_7 + number.file_8 + number.file_9 + number.file_10 + 
                      number.file_11 + number.file_12 + number.file_13 + number.file_14 + number.file_15 + 
                      number.file_16 + number.file_17 + number.file_18 + number.file_19 + number.file_20;
            return sum;
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            //var test = ReadTemplate.Replace_HTML();
            int sum = total_number();
            label_sum.Content = sum + " câu";
        }
        
        private void button_result_1_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_1_path.Content = filename;
                file.result_1.path = filename;
            }
        }
        private void button_result_2_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_2_path.Content = filename;
                file.result_2.path = filename;
            }
        }
        private void button_result_3_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_3_path.Content = filename;
                file.result_3.path = filename;
            }
        }
        private void button_result_4_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_4_path.Content = filename;
                file.result_4.path = filename;
            }
        }
        private void button_result_5_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_5_path.Content = filename;
                file.result_5.path = filename;
            }
        }
        private void button_result_6_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_6_path.Content = filename;
                file.result_6.path = filename;
            }
        }
        private void button_result_7_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_7_path.Content = filename;
                file.result_7.path = filename;
            }
        }
        private void button_result_8_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_8_path.Content = filename;
                file.result_8.path = filename;
            }
        }
        private void button_result_9_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_9_path.Content = filename;
                file.result_9.path = filename;
            }
        }
        private void button_result_10_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_10_path.Content = filename;
                file.result_10.path = filename;
            }
        }
        // additional - to 20
        private void button_result_11_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_11_path.Content = filename;
                file.result_11.path = filename;
            }
        }
        private void button_result_12_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_12_path.Content = filename;
                file.result_12.path = filename;
            }
        }
        private void button_result_13_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_13_path.Content = filename;
                file.result_13.path = filename;
            }
        }
        private void button_result_14_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_14_path.Content = filename;
                file.result_14.path = filename;
            }
        }
        private void button_result_15_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_15_path.Content = filename;
                file.result_15.path = filename;
            }
        }
        private void button_result_16_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_16_path.Content = filename;
                file.result_16.path = filename;
            }
        }
        private void button_result_17_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_17_path.Content = filename;
                file.result_17.path = filename;
            }
        }
        private void button_result_18_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_18_path.Content = filename;
                file.result_18.path = filename;
            }
        }
        private void button_result_19_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_19_path.Content = filename;
                file.result_19.path = filename;
            }
        }
        private void button_result_20_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                label_result_20_path.Content = filename;
                file.result_20.path = filename;
            }
        }
        //

        private void comboBox_1_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_1 = (int)comboBox_1_number.SelectedValue;
        }
        private void comboBox_2_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_2 = (int)comboBox_2_number.SelectedValue;
        }
        private void comboBox_3_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_3 = (int)comboBox_3_number.SelectedValue;
        }
        private void comboBox_4_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_4 = (int)comboBox_4_number.SelectedValue;
        }
        private void comboBox_5_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_5 = (int)comboBox_5_number.SelectedValue;
        }
        private void comboBox_6_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_6 = (int)comboBox_6_number.SelectedValue;
        }
        private void comboBox_7_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_7 = (int)comboBox_7_number.SelectedValue;
        }
        private void comboBox_8_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_8 = (int)comboBox_8_number.SelectedValue;
        }
        private void comboBox_9_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_9 = (int)comboBox_9_number.SelectedValue;
        }
        private void comboBox_10_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_10 = (int)comboBox_10_number.SelectedValue;
        }
        // to - 20
        private void comboBox_11_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_11 = (int)comboBox_11_number.SelectedValue;
        }
        private void comboBox_12_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_12 = (int)comboBox_12_number.SelectedValue;
        }
        private void comboBox_13_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_13 = (int)comboBox_13_number.SelectedValue;
        }
        private void comboBox_14_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_14 = (int)comboBox_14_number.SelectedValue;
        }
        private void comboBox_15_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_15 = (int)comboBox_15_number.SelectedValue;
        }
        private void comboBox_16_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_16 = (int)comboBox_16_number.SelectedValue;
        }
        private void comboBox_17_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_17 = (int)comboBox_17_number.SelectedValue;
        }
        private void comboBox_18_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_18 = (int)comboBox_18_number.SelectedValue;
        }
        private void comboBox_19_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_19 = (int)comboBox_19_number.SelectedValue;
        }
        private void comboBox_20_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.file_20 = (int)comboBox_20_number.SelectedValue;
        }
        //

        private void comboBox_destination_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.destination_number = (int)comboBox_destination_number.SelectedValue;
        }

        public void SetTextForLabel(string Text)
        {
            done.Content = Text;
        }

        private void button_open_destination_folder_Click(object sender, RoutedEventArgs e)
        {
            string path = file.file_final.path;
            if (path == null)
            {
                path = "D:\\";
            }
            Process.Start(new ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void comboBox_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = comboBox_type.SelectedItem as TypeItem;
            file.Type = item;            
        }
    }
}
