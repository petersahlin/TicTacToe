using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {

        public List<string> AvailableCells { get; set; } = new List<string>();
        public List<string> Moves { get; set; } = new List<string>();

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
                var checkWin = CheckForWin("1AX");                                  //send button here?
                if (!checkWin)
                {
                    await OpponentsMove("Button1A");

                }

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
                var checkWin = CheckForWin("1BX");
                if (!checkWin)
                {
                    await OpponentsMove("Button1B");
                }

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
                var checkWin = CheckForWin("1CX");
                if (!checkWin)
                {
                    await OpponentsMove("Button1C");
                }

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
                var checkWin = CheckForWin("2AX");
                if (!checkWin)
                {

                    await OpponentsMove("Button2A");
                }

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
                var checkWin = CheckForWin("2BX");
                if (!checkWin)
                {
                    await OpponentsMove("Button2B");
                }

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
                var checkWin = CheckForWin("2CX");
                if (!checkWin)
                {
                    await OpponentsMove("Button2C");
                }

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
                var checkWin = CheckForWin("3AX");
                if (!checkWin)
                {
                    await OpponentsMove("Button3A");
                }

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
                var checkWin = CheckForWin("3BX");
                if (!checkWin)
                {
                    await OpponentsMove("Button3B");
                }

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
                var checkWin = CheckForWin("3CX");
                {
                    await OpponentsMove("Button3C");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private bool CheckForWin(string move)
        {
            Moves.Add(move);

            if (Moves.Count > 2)
            {
                if (Moves.Contains("1AX") && Moves.Contains("1BX") && Moves.Contains("1CX")
                    || Moves.Contains("2AX") && Moves.Contains("2BX") && Moves.Contains("2CX")
                    || Moves.Contains("3AX") && Moves.Contains("3BX") && Moves.Contains("3CX")

                    || Moves.Contains("1AX") && Moves.Contains("2AX") && Moves.Contains("3AX")
                    || Moves.Contains("1BX") && Moves.Contains("2BX") && Moves.Contains("3BX")
                    || Moves.Contains("1CX") && Moves.Contains("2CX") && Moves.Contains("3CX")

                    || Moves.Contains("1AX") && Moves.Contains("2BX") && Moves.Contains("3CX")
                    || Moves.Contains("3AX") && Moves.Contains("2BX") && Moves.Contains("1CX")
                    )
                {
                    MessageBox.Show("You won!");
                    return true;
                }

                else if (Moves.Contains("1AC") && Moves.Contains("1BC") && Moves.Contains("1CC")
                    || Moves.Contains("2AC") && Moves.Contains("2BC") && Moves.Contains("2CC")
                    || Moves.Contains("3AC") && Moves.Contains("3BC") && Moves.Contains("3CC")

                    || Moves.Contains("1AC") && Moves.Contains("2AC") && Moves.Contains("3AC")
                    || Moves.Contains("1BC") && Moves.Contains("2BC") && Moves.Contains("3BC")
                    || Moves.Contains("1CC") && Moves.Contains("2CC") && Moves.Contains("3CC")

                    || Moves.Contains("1AC") && Moves.Contains("2BC") && Moves.Contains("3CC")
                    || Moves.Contains("3AC") && Moves.Contains("2BC") && Moves.Contains("1CC")
                    )
                {
                    MessageBox.Show("The opponent won, how unfortunate!");
                    return true;
                }
            }
            return false;
            //check for three in a row


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
                        CheckForWin("1AC");
                        break;
                    case "Button1B":
                        AvailableCells.Remove("Button1B");
                        Button1B.Content = CreateCircleImage();
                        CheckForWin("1BC");
                        break;
                    case "Button1C":
                        AvailableCells.Remove("Button1C");
                        Button1C.Content = CreateCircleImage();
                        CheckForWin("1CC");
                        break;
                    case "Button2A":
                        AvailableCells.Remove("Button2A");
                        Button2A.Content = CreateCircleImage();
                        CheckForWin("2AC");
                        break;
                    case "Button2B":
                        AvailableCells.Remove("Button2B");
                        Button2B.Content = CreateCircleImage();
                        CheckForWin("2BC");
                        break;
                    case "Button2C":
                        AvailableCells.Remove("Button2C");
                        Button2C.Content = CreateCircleImage();
                        CheckForWin("2CC");
                        break;
                    case "Button3A":
                        AvailableCells.Remove("Button3A");
                        Button3A.Content = CreateCircleImage();
                        CheckForWin("3AC");
                        break;
                    case "Button3B":
                        AvailableCells.Remove("Button3B");
                        Button3B.Content = CreateCircleImage();
                        CheckForWin("3BC");
                        break;
                    case "Button3C":
                        AvailableCells.Remove("Button3C");
                        Button3C.Content = CreateCircleImage();
                        CheckForWin("3CC");
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

        private void RestartGame(object sender, RoutedEventArgs e)
        {
            Moves = new List<string>();
            AvailableCells = InitializeAvailableCellsList();
            Button1A.Content = "";
            Button1B.Content = "";
            Button1C.Content = "";
            Button2A.Content = "";
            Button2B.Content = "";
            Button2C.Content = "";
            Button3A.Content = "";
            Button3B.Content = "";
            Button3C.Content = "";
        }

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