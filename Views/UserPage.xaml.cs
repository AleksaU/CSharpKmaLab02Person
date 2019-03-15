using Lab02Utkina.ViewModels;
using System.Windows.Controls;


namespace Lab02Utkina.Views
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            DataContext = new UserPageViewModel();
        }
    }
}
