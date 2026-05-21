using Slopjekt.Classes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Slopjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DebugLogger.WriteDebug("Application loaded into MainWindow.", DebugType.Info);
            SwitchToSignUpScreen();
        }

        public void SwitchToInventoryWindow()
        {
            InventoryWindow screen = new();
            screen.Show();
            this.Close();
        }

        public void SwitchToProfileWindow()
        {
            Profile screen = new();
            screen.Show();
            this.Close();
        }

        public void SwitchToSignUpScreen()
        {
            SignUpScreen screen = new();
            screen.Show();
            this.Close();
        }

        
    }
}