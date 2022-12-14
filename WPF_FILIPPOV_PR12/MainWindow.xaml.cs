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
using WPF_FILIPPOV_PR12.NewFolder1;
using WPF_FILIPPOV_PR12.PageMain;

namespace WPF_FILIPPOV_PR12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model1 = new FILIPPOV_PR12Entities();
            AppFrame.frameMain = FrmMain;

            FrmMain.Navigate( new PageLogin());
        }
    }
}
