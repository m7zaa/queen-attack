using System;
class QueenAttack
{
    static void Main()
    {

      Console.WriteLine("Enter the column that the Queen is in. A-H");
      string queenColumn = Console.ReadLine();
      Console.WriteLine("Enter the row that the Queen is in. 1-8");
      int queenRow = int.Parse(Console.ReadLine());

     Console.WriteLine("Enter the column that the Pawn is in. A-H");
     string pawnColumn = Console.ReadLine();
     Console.WriteLine("Enter the row that the Pawn is in. 1-8");
     int pawnRow = int.Parse(Console.ReadLine());

     string[] columns = { "A", "B", "C", "D", "E", "F", "G", "H"};
     int queenColInt = 0;
     int pawnColInt = 0;
     for (int i = 0; i < columns.Length; i++)
     {
        if (queenColumn.ToUpper() == columns[i])
        {
            queenColInt = i + 1;
        }
        if (pawnColumn.ToUpper() == columns[i])
        {
            pawnColInt = i + 1;
        }
     }
     Console.WriteLine("Queen's column: " + queenColInt + " Pawn's column: " + pawnColInt);
    }
}
