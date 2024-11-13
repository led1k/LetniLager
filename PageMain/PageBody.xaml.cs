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
    /// Логика взаимодействия для PageBody.xaml
    /// </summary>
    public partial class PageBody : Page
    {
        public PageBody()
        {
            InitializeComponent();

        }

        private void CompetitionHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogoMain.Navigate(new PageMain.PageCompetitions());
        }

        private void AccountingHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogoMain.Navigate(new PageMain.PageAccounting());
        }

        private void GroupHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogoMain.Navigate(new PageMain.PageAddGroup());
        }
    }
}
