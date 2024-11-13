using LetniLager.Class;
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

namespace LetniLager.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageCompetitions.xaml
    /// </summary>
    public partial class PageCompetitions : Page
    {
        public PageCompetitions()
        {
            InitializeComponent();

            CmbVidCompetitions.SelectedValuePath = "Id";
            CmbVidCompetitions.DisplayMemberPath = "Name";
            CmbVidCompetitions.ItemsSource = App.context.Ddirection.ToList();

        }

        private void AddCompetitions_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(TxbCompetitions.Text))
                mes += "Введите соревнование\n";

            if (string.IsNullOrEmpty(CmbVidCompetitions.Text))
                mes += "Выберите его вид\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            TtypeCompetition typeCompetition = new TtypeCompetition()
            {
                Name = TxbCompetitions.Text,
               Ddirection = CmbVidCompetitions.SelectedItem as Ddirection
            };
            App.context.TtypeCompetition.Add(typeCompetition);
            App.context.SaveChanges();
            MessageBox.Show("Соревнование добавлена");

            TxbCompetitions.Text = "";
            CmbVidCompetitions.Text = "";
        }

        private void CmbVidCompetitions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxbCompetitions_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
