using Parse;
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

namespace Chat_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

             ParseClient.Initialize("clvkXSjdhataOFi5fkFEwsyQzR7lA9Fh1RhdTj7g", "7ah1lB82ttqpqHIi9g16CQE2HDtJa16HpXOxBcj2");

             // By convention, the empty string is considered a "Broadcast" channel
             // Note that we had to add "async" to the definition to use the await keyword
              ParsePush.SubscribeAsync("");
            
        
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ParseObject gameScore = new ParseObject("GameScore");
            gameScore["score"] = 1337;
            gameScore["playerName"] = "Sean Plott";
            await gameScore.SaveAsync();
        }
    }
}
