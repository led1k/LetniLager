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
    /// Логика взаимодействия для PageAddGroup.xaml
    /// </summary>
    public partial class PageAddGroup : Page
    {
        public PageAddGroup()
        {
            InitializeComponent();

            CmbSpecial.SelectedValuePath = "Id";
            CmbSpecial.DisplayMemberPath = "Name";
            CmbSpecial.ItemsSource = App.context.specialty.ToList();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(TxbGroup.Text))
                mes += "Введите группу\n";

            if (string.IsNullOrEmpty(CmbSpecial.Text))
                mes += "Выберите специальность\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            group groupLL = new group()
            {
                Name = TxbGroup.Text,
                specialty = CmbSpecial.SelectedItem as specialty
            };
               App.context.group.Add(groupLL);
               App.context.SaveChanges();
               MessageBox.Show("Группа добавлена");

            TxbGroup.Text = "";
            CmbSpecial.Text = "";
        }

        private void CmbSpecial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
