using Slopjekt.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace Slopjekt
{
    /// <summary>
    /// Interaction logic for SignUpScreen.xaml
    /// </summary>
    public partial class SignUpScreen : Window
    {
        public SignUpScreen()
        {
            InitializeComponent();
            CollectUserInput();
            CollectUserInput();
            CollectUserInput();
        }
        public SignupData CollectUserInput()
        {
            try
            {
                string UserName = UserNameInputBox.Text;
                SecureString Password = UserPasswordInputBox.SecurePassword;
                string promocode = PromoCodeInputBox.Text;
                return new SignupData(UserName, Password, promocode);
            }
            catch (Exception e)
            {
                DebugLogger.WriteDebug(e.Message, DebugType.Error);
            }
            return null;
        }


    }
}
