using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();

        }

        private void Autorization_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text != "")
            {
                if (passwordBox.Text != "")
                {
                    // Панель для оформления заказа (для новых пользователей/заказчиков)
                    Close();
                    MakingAnOrder winm = new MakingAnOrder();
                    winm.Show();

                    // Панель для управления учётными записями (для администратора/директора):

                    Close();
                    MainMenu mm = new MainMenu();
                    mm.Show();

                    // Панель для добавления аудиоэффектов к файлам (для звукоинженера/звукорежесёра):

                    Close();
                    SoundEngineeringAndSoundEngineeringPanel sesep = new SoundEngineeringAndSoundEngineeringPanel();
                    sesep.Show();
                }
                else {MessageBox.Show("Поле 'password' не может быть пустым.", "Ошибка");}
            }
            else{MessageBox.Show("Поле 'login' не может быть пустым.", "Ошибка");}
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}