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
using System.Windows.Shapes;

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cancelingLastAction_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Последнее действие было успешно отменено.", "событие");
        }

        private void saveRoleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Роли успешно обновлены.", "событие");
        }
    }
}
