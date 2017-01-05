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
using WpfApplication1.Object;
using System.IO;
using WpfApplication1.Code;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            
            Function.AutoMerge(file, number);
            //Thread.Sleep(2000);
            SetTextForLabel("Xong");
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            int sum = number.file_1 + number.file_2 + number.file_3;
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
