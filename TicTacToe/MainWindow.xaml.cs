using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {

        public List<string> AvailableCells { get; set; } = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            AvailableCells = InitializeAvailableCellsList();

        }

        //Row 1
        private void Button1A_Clicked(object sender, RoutedEventArgs e)
        {
            Button1A.Content = CreateCrossImage();
            CheckForWin(); 
            OpponentsMove("Button1A");
        }

        private void Button1B_Clicked(object sender, RoutedEventArgs e)
        {
            Button1B.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button1B");
        }

        private void Button1C_Clicked(object sender, RoutedEventArgs e)
        {
            Button1C.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button1C");
        }

        //Row 2
        private void Button2A_Clicked(object sender, RoutedEventArgs e)
        {
            Button2A.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button2A");
        }

        private void Button2B_Clicked(object sender, RoutedEventArgs e)
        {
            Button2B.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button2B");
        }

        private void Button2C_Clicked(object sender, RoutedEventArgs e)
        {
            Button2C.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button2C");
        }

        //Row 3
        private void Button3A_Clicked(object sender, RoutedEventArgs e)
        {
            Button3A.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button3A");
        }

        private void Button3B_Clicked(object sender, RoutedEventArgs e)
        {
            Button3B.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button3B");
        }

        private void Button3C_Clicked(object sender, RoutedEventArgs e)
        {
            Button3C.Content = CreateCrossImage();
            CheckForWin();
            OpponentsMove("Button3C");
        }

        private void CheckForWin()
        {
            

            //check for three in a row
            //if statement?
            
        }

        private void OpponentsMove(string cell)
        {
            var availableCells = new List<string> { "Button1A", "Button1B", "Button1C", "Button2A", "Button2B", "Button2C", "Button3A", "Button3B", "Button3C", };
            AvailableCells.Remove(cell);
            //pick a random cell (random 1A, 1B and so on?)
            //ensure cell is not already taken (if content == null? button.content != Image)
            //display circle in that cell
            //add delay?
        }

        private List<string> InitializeAvailableCellsList()
        {
            var availableCellsList = new List<string> { "Button1A", "Button1B", "Button1C", "Button2A", "Button2B", "Button2C", "Button3A", "Button3B", "Button3C", };
            return availableCellsList;
        }

        //method for resetting the game

        private Image CreateCrossImage()
        {
            var crossImage = new Image
            {
                Source = new BitmapImage(new Uri("Images/Cross.jpg", UriKind.Relative)),
                Stretch = Stretch.Uniform
            };

            return crossImage;
        }

        private Image CreateCircleImage()
        {
            var circleImage = new Image
            {
                Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative)),
                Stretch = Stretch.Uniform
            };

            return circleImage;
        }


    }
}