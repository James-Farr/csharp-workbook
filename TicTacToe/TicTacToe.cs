using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static int turnNum = 0;
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                PlayerChange();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            //PlayAgain();
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Turn Number: " + turnNum);
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
                // Check row to see if valid 
                if ((row == 0) || (row == 1) || (row == 2)){
                    Console.WriteLine("You picked " + row +".");
                    }
                // Invalid Row Error
                else{
                    Console.WriteLine("Invalid Row choice. Pick another Row");
                    GetInput();
                    }

            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
                // Check Column For Valid Input
                if ((column == 0) || (column == 1) || (column == 2)){
                    Console.WriteLine("You picked " + column +".");
                    }  
                // Else invaid option is thrown
                else{
                    Console.WriteLine("Invalid Column choice. Pick another Column");
                    GetInput();
                    }
                // Use the PlaceMark function
                if (board[row][column] == " "){
                    PlaceMark(row,column);
                }
                // Error Message for taking a taken space
                else{
                    Console.WriteLine("That space is Taken, Please pick a space that isnt Taken.");
                    GetInput();
                }
        }

        public static void PlaceMark(int row, int column)
        {
        board[row][column] = playerTurn;
        turnNum ++;
        }

        public static bool CheckForWin()
        {
            bool winGame = false;
                if (HorizontalWin() || VerticalWin() || DiagonalWin()){
                    winGame = true;
                    // Win Statement
                    Console.WriteLine("Player " + playerTurn + " Won in " + turnNum + " Turns. ");
                    // Reset turns for next game
                    turnNum = 0;
                }

            return winGame;
        }

        public static bool CheckForTie()
        {
            bool tie = false;
            if (turnNum >= 9){
                tie = true;
                Console.WriteLine("Game ended in a tie. Play again.");
                // Reset 
                turnNum = 0;
            }

            return tie;
        }
        
        public static bool HorizontalWin()
        {
            // Check all row Combinations for horizontal win
            if (board[0][0] == board[0][1] && board[0][1] == board[0][2] ){
                return true;
            }  
            else if (board[1][0] == board[1][1] && board[1][1] == board[1][2] ){
                return true;
            }  
            else if (board[2][0] == board[2][1] && board[2][1] == board[2][2] ){
                return true;
            }

        return false;
        }

        public static bool VerticalWin()
        {
            // Check all row Combinations for Vertical win
            if (board[0][0] == board[1][0] && board[1][0] == board[2][0] ){
                return true;
            }  
            else if (board[0][1] == board[1][1] && board[1][1] == board[2][1] ){
                return true;
            }  
            else if (board[0][2] == board[1][2] && board[1][2] == board[2][2] ){
                return true;
            }
            return false;
        }

        public static bool DiagonalWin()
        {
            // Check all row Combinations for Diagonal win
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2] ){
                return true;
            }  
            else if (board[0][2] == board[1][1] && board[1][1] == board[2][0] ){
                return true;
            }  

            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
        public static void PlayerChange(){
            if(playerTurn == "X"){
                playerTurn = "O";
            }
            else{
                playerTurn = "X";
            }
        }

        
    }
}
