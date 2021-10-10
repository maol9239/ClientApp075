using De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper;
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
using System.ComponentModel;

namespace De.HsFlensburg.ClientApp075.Ui.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var collection = this.myDataGrid.ItemsSource as ClientCollectionViewModel;
            var first = collection.FirstOrDefault();
            first.Model.Name = "Rename in the model";
        }

        private void DebugMainWindow(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
