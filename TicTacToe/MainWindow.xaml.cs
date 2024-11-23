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
        private async void Button1A_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
              
                Button1A.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button1A");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void Button1B_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button1B.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button1B");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void Button1C_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button1C.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button1C");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        //Row 2
        private async void Button2A_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button2A.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button2A");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void Button2B_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button2B.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button2B");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void Button2C_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button2C.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button2C");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        //Row 3
        private async void Button3A_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button3A.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button3A");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void Button3B_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button3B.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button3B");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void Button3C_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Button3C.Content = CreateCrossImage();
                CheckForWin();
                await OpponentsMove("Button3C");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void CheckForWin()
        {


            //check for three in a row
            //if statement?

        }

        private async Task OpponentsMove(string cell)
        {

            await Task.Delay(1000);
            //remove from available cells list to ensure cell is not already taken 

            AvailableCells.Remove(cell);
            //pick a random available cell 
            if (AvailableCells.Count > 0)
            {
                var randomMove = new Random();
                var randomMoveIndex = randomMove.Next(AvailableCells.Count);
                var opponentsMove = AvailableCells[randomMoveIndex];

                //-- switch case?
                switch (opponentsMove)
                {
                    case "Button1A":
                        AvailableCells.Remove("Button1A");
                        Button1A.Content = CreateCircleImage();
                        break;
                    case "Button1B":
                        AvailableCells.Remove("Button1B");
                        Button1B.Content = CreateCircleImage();
                        break;
                    case "Button1C":
                        AvailableCells.Remove("Button1C");
                        Button1C.Content = CreateCircleImage();
                        break;
                    case "Button2A":
                        AvailableCells.Remove("Button2A");
                        Button2A.Content = CreateCircleImage();
                        break;
                    case "Button2B":
                        AvailableCells.Remove("Button2B");
                        Button2B.Content = CreateCircleImage();
                        break;
                    case "Button2C":
                        AvailableCells.Remove("Button2C");
                        Button2C.Content = CreateCircleImage();
                        break;
                    case "Button3A":
                        AvailableCells.Remove("Button3A");
                        Button3A.Content = CreateCircleImage();
                        break;
                    case "Button3B":
                        AvailableCells.Remove("Button3B");
                        Button3B.Content = CreateCircleImage();
                        break;
                    case "Button3C":
                        AvailableCells.Remove("Button3C");
                        Button3C.Content = CreateCircleImage();
                        break;

                    default:
                        break;
                }
            }
    
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