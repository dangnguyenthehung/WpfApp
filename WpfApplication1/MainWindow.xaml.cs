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
            button_Copy.Content = "Kiểm tra";
            count.Content = "Đếm";
            label_number.Content = "Số đề muốn tạo: ";
            ObservableCollection<int> list = Function.Add_item_comboBox_destination_number();
            comboBox_destination_number.ItemsSource = list;
        }
        // declare variable
        private DataToMerge file = new DataToMerge();

        //private Object.File destination_file = new Object.File();

        private NumberToMerge number = new NumberToMerge();

        private void button_1_path_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

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
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

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
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

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
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

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
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

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
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

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

        private void button_destination_path_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = true;
            CommonFileDialogResult result = dlg.ShowDialog();

            // Display OpenFileDialog by calling ShowDialog method 
            // Get the selected folder and display in a TextBox 
            if (result == CommonFileDialogResult.Ok)
            {
                // get selected folder
                string filename = dlg.FileName;
                textBox_destination_path.Text = filename;
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
                    SetTextForLabel("Không đúng File đáp án - Hàng: " + (index));
                }
            }
            else
            {
                string content = button_Copy.Content.ToString();
                if ( content == "Tạo đề")
                {
                    Function.AutoMerge(file, number);
                    SetTextForLabel("Xong");
                    button_Copy.Content = "Kiểm tra";
                    isFalse = true;
                }
                else
                {
                    button_Copy.Content = "Tạo đề";
                    SetTextForLabel("Sẵn sàng!");
                }

            }
            
            
            //Thread.Sleep(2000);
            
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            int sum = number.file_1 + number.file_2 + number.file_3 +
                      number.file_4 + number.file_5 + number.file_6 +
                      number.file_7 + number.file_8 + number.file_9 + number.file_10;
            label_sum.Content = "Tổng: " + sum.ToString() + " câu";
        }

        private void textBox_desination_path_TextChanged(object sender, TextChangedEventArgs e)
        {
            //
        }

        private void button_result_1_path_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
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

        private void comboBox_destination_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            number.destination_number = (int)comboBox_destination_number.SelectedValue;
        }

        public void SetTextForLabel(string Text)
        {
            done.Content = Text;
        }
    }
}
