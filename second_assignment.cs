using System;

namespace CSharp_SecondAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix;
            // a loop to recieve size of array from user and make sure it's not a null array of zero
            do
            {
                Console.WriteLine("please enter a number to determine the size of your squared matrix");
                sizeOfMatrix = Convert.ToInt32(Console.ReadLine());
            } while (sizeOfMatrix == 0);
            squaredMatrix(sizeOfMatrix); // sending the size if the squared matrix to the function
        }

        public static void squaredMatrix(int m)
        {
            string[][] newMatrix = new string[m][]; // the creation of our matrix
            for (int row = 0; row<m; row++) // outside loop - responssible for rows
            {
                newMatrix[row] = new string[m]; // initialliztion of each row in the array
                for (int col = 0; col<m; col++) // inside loop for column - to put values in the array
                {
                    if (m % 2 != 0 && m / 2 == row && m / 2 == col) // checks if the cell we're on is in the middle of the matrix
                        newMatrix[row][col] = "center "; 
                    else if (row < col && row + col != m - 1) // checks for cells above the main diagonal
                        newMatrix[row][col] = "up     ";
                    else if (row > col && row + col != m - 1) // checks for cells below the main diagonal
                        newMatrix[row][col] = "down   ";
                    else if (row == col)
                        newMatrix[row][col] = "main   "; // checks for cells of the main diagonal
                    else if (row + col == m - 1)
                        newMatrix[row][col] = "sub    "; // checks for cells of the secondary diagonal
                }
            }

            // a print loop for the array
            foreach (string[] s in newMatrix)
            {
                foreach (string s1 in s)
                {
                    Console.Write(s1 + " ");
                }
                Console.WriteLine();
                Console.WriteLine(); //wanted double space between lines for the square shape to really be clear
            }
        }
    }
}
