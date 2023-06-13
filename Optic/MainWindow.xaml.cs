using System;
using System.Collections.Generic;
using System.Linq;
using Optic.Models;
using Optic.View.Windows;
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

using System.IO;

namespace Optic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BrandCmb.ItemsSource = AppData.Content.opticEntities.Brand.ToList();
            FormCmb.ItemsSource = AppData.Content.opticEntities.ShapeOfGlasses.ToList(); 
            GenderCmb.ItemsSource = AppData.Content.opticEntities.Gender.ToList();
            RightDiopCmb.ItemsSource = AppData.Content.opticEntities.DiopterRightEyes.ToList();
            LeftDiopCmb.ItemsSource = AppData.Content.opticEntities.DiopterLeftEyes.ToList();
            this.PicturesBox.ItemsSource = AppData.Content.opticEntities.Glasses.ToList();
        }

        private void Exitbtn_Click(object sender, RoutedEventArgs e)
        {
            StartWindow start  = new StartWindow();
            start.Show();
            this.Close();
        }

        

        private void FindBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        void Find()
        {
            AppData.Content.opticEntities = new OpticEntities();

            var source = AppData.Content.opticEntities.Glasses.ToList();

            if (BrandCmb.SelectedIndex > -1)
            {
                source = source.Where(i => i.IdBrand == ((Brand)BrandCmb.SelectedItem).Id).ToList();
            }

            if (FormCmb.SelectedIndex > -1)
            {
                source = source.Where(i => i.IdShapeOfGlasses == ((ShapeOfGlasses)FormCmb.SelectedItem).Id).ToList();
            }

            if (GenderCmb.SelectedIndex > -1)
            {
                source = source.Where(i => i.IdGender == ((Gender)GenderCmb.SelectedItem).Id).ToList();
            }

           
        }

        private void BrandCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Find();
            
        }

        private void FormCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Find();
        }

        private void GenderCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Find();
        }

       
    }
}
