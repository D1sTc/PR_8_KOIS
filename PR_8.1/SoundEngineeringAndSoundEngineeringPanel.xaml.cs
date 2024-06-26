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
    /// Логика взаимодействия для SoundEngineeringAndSoundEngineeringPanel.xaml
    /// </summary>
    public partial class SoundEngineeringAndSoundEngineeringPanel : Window
    {
        public SoundEngineeringAndSoundEngineeringPanel()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Файл был успешно добавлен.", "событие");
        }

        private void addEffect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Эффект был успешно добавлен.", "событие");
        }

        private void exportFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Экспорт был успешно произведён.", "событие");
        }
    }
}
