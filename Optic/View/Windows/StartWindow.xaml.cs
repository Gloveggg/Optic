using System;
using System.Collections.Generic;
using System.IO;
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

namespace Optic.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            foreach (var item in AppData.Content.opticEntities.Glasses.Where(i => i.Id == 6))
            {
                item.Image = File.ReadAllBytes(@"C:\Users\chern\OneDrive\Изображения\Optic\Круггг.PNG");
            }
            AppData.Content.opticEntities.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(LoginTB.Text) && !string.IsNullOrWhiteSpace(PasswordTB.Password))
            {
                IQueryable<Models.Users> user = AppData.Content.opticEntities.Users.Where(p => p.Email == LoginTB.Text && p.Password == PasswordTB.Password);
                if (user.ToList().Any())
                {
                    MainWindow mainWindow  = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    _ = MessageBox.Show("Неправильный логин или пароль");
                }
            }
            else
            {
                _ = MessageBox.Show("⚙️ Enter Data");
            }

        }
    }
}
