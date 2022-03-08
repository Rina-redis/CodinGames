using System;

namespace Study
{
    class Program
    {
        enum CellState
        {
            NotSet,
            NotIluminated,
            Iluminated
        }

        public static int CurrentNumber;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            CurrentNumber = N;

            CellState[,] cellStates = FillArrayFromInput(N);
            FindIluminated();

            foreach (CellState state in cellStates)
            {
                Console.WriteLine(state);
            }
        }

        private static void FindIluminated(CellState[,] cellStates)
        {
            for (int i = 0; i < cellStates.GetLength(0); i++)
            {
                for (int j = 0; j < cellStates.GetLength(1); j++)
                {
                    CellState cell = cellStates[i,j];
                    if(cell == CellState.Iluminated)
                    {
                        
                    }
                }
            }
        }

        private static CellState[,] FillArrayFromInput(int N)
        {
            CellState[,] cellStates = new CellState[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    string cell = inputs[j];
                    if (cell == "C")
                    {
                        cellStates[i, j] = CellState.Iluminated;
                    }
                    else
                    {
                        cellStates[i, j] = CellState.NotSet;
                    }
                }
            }
            return cellStates;
        }
    }
}
