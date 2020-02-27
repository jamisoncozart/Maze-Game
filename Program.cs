using System;
using Maze;

namespace Program
{
  public class MainClass{
    public static void Main()
    {
      Game newGame = new Game("Geoff");
      newGame.PrintMaze();
      if(newGame.Search(0,0))
      {
        Console.WriteLine("possible move");
      }
      else{
        Console.WriteLine("not possible move");
      }
    }
  }
}