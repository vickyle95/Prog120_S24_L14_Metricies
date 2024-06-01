namespace Prog120_S24_L14_Metricies
{
  
    internal class Program
    {
        // 2d Array - Matrix
        // 1 2 3 4 5 
        // 6 7 8 9 10
        // datatype [,] name = new datatype [sizeY,sizeX];
        //In trials X represents different trials, y represents out fields

        static int[,] intMatrix = new int[3, 3];
        static int[,] randomMatrix;

        static void Main(string[] args)
        {
           // Name: Vicky Le
           // Assignment: Lecture 14 - Metricies
           // Date: 5/30/24

            //intMatrix[0, 0] = 1;
            //intMatrix[0, 0] = 2;
            //intMatrix[0, 0] = 3;
            //intMatrix[0, 0] = 4;

            //DisplayMatrix(intMatrix);


        } // Main

       

        // You will create a program, method, than when you pass in a 2d array of char
        // char[3,3]

        // You will check to see if the 2d array is a winning game of tic tac toe

        public static void MatrixExample2()
        {

            randomMatrix = PopulateIntMatrix(5, 5);
            DisplayMatrix(randomMatrix);
            Console.WriteLine();

            Console.Write("Diangonal: ");
            for (int x = 0; x < randomMatrix.GetLength(0); x++)
            {
                Console.Write(randomMatrix[x, x] + " ");
            }

        }
        public static int[,] PopulateIntMatrix(int xSize, int ySize)
        {
            int[,] temp = new int[xSize, ySize];
            Random rand = new Random();

            for (int x = 0; x < temp.GetLength(0); x++)
            {
                for (int y = 0; y < temp.GetLength(1); y++)
                {
                    temp[x, y] = rand.Next(1, 100);
                }
            }
            return temp;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            Console.WriteLine(intMatrix.GetLongLength(0));

            int xAxisLength = matrix.GetLength(0);
            int yAxisLength = matrix.GetLength(1);

            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.Write(matrix[x, y]);
                }
            }
        }
        public static void FirstMatrixExample()
        {
            // Array.GetLength(dimension)
            Console.WriteLine(intMatrix.GetLongLength(0));

            int xAxisLength = intMatrix.GetLength(0);
            int yAxisLength = intMatrix.GetLength(1);

            intMatrix[0, 0] = 876;
            intMatrix[1, 0] = 123;

            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.WriteLine(intMatrix[x, y]);
                }
            }

        }
        public static void NestedLoopsExample()
        {
            // Nested Loops

            for (int i = 0; i < 7; i++)
            {
                Console.Write(i + ": ");
                //Console.WriteLine(i);
                // Place another loop InSIDE of our first loop
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();

            }
        }
        // ------------------------------------
     
    } // Class
} // Namespace
