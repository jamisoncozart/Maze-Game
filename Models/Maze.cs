using System;

namespace Maze
{
  public class Game
  {
    public string PlayerOne {get; set;}
    string[][] maze = new string[10][];
    public Game(string player)
    {
      PlayerOne = player;
      maze[0] = new string[]{" ","|"," "," ","|"," "," "," "," "," "," ","-","-","-","-","-"};
      maze[1] = new string[]{" ","|","_","_","|"," ","|","-","|"," "," ","-","-","-","-","-"};
      maze[2] = new string[]{" "," "," "," "," "," ","|"," ","|"," "," ","-","-","-","-","-"};
      maze[3] = new string[]{"-","-","-","-"," "," ","-","-","-","-","-","-","-","-","-","-"};
      maze[4] = new string[]{"-","-","-","-"," "," ","-","-","-","-","-","-","-","-","-","-"};
      maze[5] = new string[]{"|"," "," "," "," "," ","-","-","-","-","-","-","-","-","-","-"};
      maze[6] = new string[]{"|"," ","-","-","-","-","-","-","-","-","-","-","-","-","-","-"};
      maze[7] = new string[]{"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"};
      maze[8] = new string[]{"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"};
      maze[9] = new string[]{"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"};
    }
    public void PrintMaze()
    {

      for(int i = 0; i < maze.Length; i++)
      {
        Console.WriteLine(String.Join("", maze[i]));
      }

    }

    public bool Search(int x, int y)
    {
      if(maze[y][x] == " ")
      {
        return true;
      }
      else
      {
        return false;
      }
    }


  }
}