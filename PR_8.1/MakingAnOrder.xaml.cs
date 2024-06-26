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
    /// Логика взаимодействия для MakingAnOrder.xaml
    /// </summary>
    public partial class MakingAnOrder : Window
    {
        public MakingAnOrder()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MakeOrder_Click(object sender, RoutedEventArgs e)
        {
            // Отчёт о выбранных данных идёт в папку "Заказы"

                if (GenderBox.Text != "" & forWhomBox.Text != "" & eventBox.Text != "" & dataPicker.Text != "" & trafic.Text != "")
                {
                MessageBox.Show("Заказ на исполнение альбома отправлен. Ожидайте сообщения от администрации.", "Оформление заказа", MessageBoxButton.OK, MessageBoxImage.Question); // Question - знак с вопросом, необходимо подделать личный знак.
                }
                else{MessageBox.Show("Некоторые поля пустые, пожалуйста, заполните их для оформления заказа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);}
        }

        private void GenderBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GenderBox is null)
            {
                MessageBox.Show("Это поле должно быть заполненным.", "ошибка");
            }
        }
    }
}
