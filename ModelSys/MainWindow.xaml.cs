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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModelSys
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields

        public static bool close;
        public static MainWindow mainWindow;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            myweb.Source = new Uri(Environment.CurrentDirectory + "/lib.html");
            if (mainWindow == null)
            {
                mainWindow = this;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Launcher.Launch();
        }

        private void checkBox_Close_Checked(object sender, RoutedEventArgs e)
        {
            close = true;
        }

        private void checkBox_Close_UnChecked(object sender, RoutedEventArgs e)
        {
            close = false;
        }
    }
}
