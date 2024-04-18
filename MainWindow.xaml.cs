using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bread
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ravnoButton_Click(object sender, RoutedEventArgs e)
        {
            BreadWClass blackBread = new BreadWClass { name = "Черный хлеб", weight = 400, cost = 29.99};
            BreadWClass whiteBread = new BreadWClass { name = "Белый хлеб", weight = 350, cost = 32.99 };
            BreadWClass batonBread = new BreadWClass { name = "Батон", weight = 220, cost = 36.99 };

            costTextBox.Text = $"Имя:{blackBread.name} Вес:  {blackBread.weight} Цена: {blackBread.cost}";
            secondTextBox.Text = $"Имя:{whiteBread.name} Вес:  {whiteBread.weight} Цена: {whiteBread.cost}";
            thirdTextBox.Text = $"Имя:{batonBread.name} Вес:  {batonBread.weight} Цена: {batonBread.cost}";

            List<SkladClass> sklad = new List<SkladClass>()
            {
                new SkladClass { bread = whiteBread, available = 6 },
                new SkladClass { bread = blackBread, available = 2 },
                new SkladClass { bread = batonBread, available = 2 }
            };
            

            
        }
    }
}
