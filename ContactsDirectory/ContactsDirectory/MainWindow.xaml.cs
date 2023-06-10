using ContactsDirectory.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.LinkLabel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ContactsDirectory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                var institution = DirectoryEntities.GetContext().EducationalInstitution.ToList();
                LViewInstitution.ItemsSource = institution;
                DataContext = this;

                UpdateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Ошибка!");
            }
        }

        private void UpdateData()
        {
            var result = DirectoryEntities.GetContext().EducationalInstitution.ToList();

            if (cmbSorting.SelectedIndex == 0)
                result = result.OrderBy(p => p.Name).ToList();
            if (cmbSorting.SelectedIndex == 1)
                result = result.OrderBy(p => p.Address).ToList();
            if (cmbSorting.SelectedIndex == 2)
                result = result.OrderBy(p => p.Email).ToList();
            if (cmbSorting.SelectedIndex == 3)
                result = result.OrderBy(p => p.Website).ToList();
            if (cmbSorting.SelectedIndex == 4)
                result = result.OrderBy(p => p.Phone).ToList();

            result = result.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            LViewInstitution.ItemsSource = result;
        }

        private void txtSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        private void cmbSorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        public string[] SortingList { get; set; } =
        {
            "Название",
            "Адрес",
            "Email",
            "Сайт",
            "Телефон"
        };

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<string> Lines = new List<string>();
                string filePath = string.Empty;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
                StreamReader sr = new StreamReader(filePath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Lines.Add(line);
                }
                //
                MessageBox.Show(Lines[0], "Дата");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Ошибка!");
            }
        }
    }
}
