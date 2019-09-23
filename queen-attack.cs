using System;
class QueenAttack
{
    static void Main()
    {
     Console.WriteLine("Enter the column that the Queen is in. A-H");
     string queenColumn = Console.ReadLine();
     Console.WriteLine("Enter the row that the Queen is in. 1-8");
     int queenRow = int.Parse(Console.ReadLine());

     Console.WriteLine("Enter the column that the pawn is in. A-H");
     string pawnColumn = Console.ReadLine();
     Console.WriteLine("Enter the row that the pawn is in. 1-8");
     int pawnRow = int.Parse(Console.ReadLine());

     string[] columns = { "A", "B", "C", "D", "E", "F", "G", "H"};
     int[] rows = {1, 2, 3, 4, 5, 6, 7, 8};
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
     bool queenColValid = false;
     bool queenRowValid = false;
     bool pawnColValid = false;
     bool pawnRowValid = false;
     foreach (int x in rows)
     {
        if (x == queenColInt)
        {
            queenColValid = true;
        }
        if (x == queenRow)
        {
            queenRowValid = true;
        }
        if (x == pawnColInt)
        {
            pawnColValid = true;
        }
        if (x == pawnRow)
        {
            pawnRowValid = true;
        }
     }

     if (queenColInt == pawnColInt && queenRow == pawnRow) 
     {
         Console.WriteLine("The Queen and pawn must be in different places. Please try again.");
         Main();
     }
     else if (!queenColValid || !queenRowValid || !pawnColValid || !pawnRowValid)
     {
         Console.WriteLine("Invalid coordinates. Please try again.");
         Main();
     }
     else if (queenColInt == pawnColInt || queenRow == pawnRow || Math.Abs((queenColInt - pawnColInt) / (queenRow - pawnRow)) == 1)
     {
         Console.WriteLine("Your pawn is in danger of capture!!!");
     }
     else
     {
        Console.WriteLine("Your pawn is not in danger of capture by the Queen...yet.");
     }
    }  
}
