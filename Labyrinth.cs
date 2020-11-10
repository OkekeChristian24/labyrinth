using System;

class Labyrinth
{

  static char[,] lab =
  {
    {' ', ' ', ' ', '*', ' ', ' ', ' '},
    {'*', '*', ' ', '*', ' ', '*', ' '},
    {' ', ' ', ' ', ' ', ' ', ' ', ' '},
    {' ', '*', '*', '*', '*', '*', ' '},
    {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
  };


  static void FindPath(int row, int col)
  {
    if((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
    {
      // We are out of the Labyrinth
      return;
    }

    // Check if we have found the exit
    if(lab[row, col] == 'e')
    {
      Console.WriteLine("Found the exit!");
    }

    if(lab[row, col] != ' ')
    {
      // The current cell is not free
      return;
    }

    // Mark the current cell as visited
    lab[row, col] = 's';

    // Invoke recursion to explore all possible directions
    FindPath(row, col-1); // left
    FindPath(row-1, col); // up
    FindPath(row, col+1); // right
    FindPath(row+1, col); //down

    // Mark back the current cell as free
    lab[row, col] = ' ';

  }

  static void Main()
  {
    FindPath(0, 0);
  }

}
