using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfEX.Model;

namespace WpfEX
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {




        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            MedList = Globals.dataProvider.GetMeds();

            MedDiagnozList = Globals.dataProvider.GetMedDiagnoz().ToList();
            MedDiagnozList.Insert(0, new MedDiagnoz { Title = "Все Диагнозы" });


        }



        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        public event PropertyChangedEventHandler PropertyChanged;


        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("MedList"));
        }



        public List<MedDiagnoz> MedDiagnozList { get; set; }

        public string SelectedBreed { get; set; } = "Все Диагнозы";



        private IEnumerable<Med> _MedList = null;
        public IEnumerable<Med> MedList
        {
            get
            {
                var res = _MedList
                    .Where(c => (SelectedBreed == "Все Диагнозы" || c.Diagnosis == SelectedBreed));
                if (SearchFilter != "")
                    res = res.Where(c => c.Diagnosis.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);


                if (SortAsc) res = res.OrderBy(c => c.Diagnosis);
                else res = res.OrderByDescending(c => c.Diagnosis);
                return res;
            }
            set
            {
                _MedList = value;
            }
        }
        private void NameFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedBreed = (NameFilterComboBox.SelectedItem as MedDiagnoz).Title;
            Invalidate();
        }


        private string SearchFilter = "";

        private void SearchFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();

        }

        private void SearchFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }
    }
}



