using System.Diagnostics;
using System.Text;
using BackendLibrary;
using Timer = System.Timers.Timer;

Console.WriteLine("Hello, World!");
TicTacToe ttt = new TicTacToe("Player, Computer, x ,o | 1651323438, 1651323441 | 3 | x-1-1, o-1-0, x-2-0, o-0-2, x-2-1, o-0-1, x-2-2");
foreach (string[,] board in ttt.BoardArray)
{
    Console.WriteLine(ttt.BoardDisplay(board));
    Console.WriteLine();
}
// Console.WriteLine(Utilities.Arrays.DeepToString(ttt.Board));
// Console.WriteLine(ttt.GetWinner());
// Console.WriteLine(ttt.BoardDisplay());
// Console.WriteLine(ttt.ToString());
// TicTacToe ttt2 = new TicTacToe(ttt.ToString());
// Console.WriteLine(ttt2.ToString());
// TicTacToe ttt2 = new TicTacToe(3);
// ttt2.SetSymbolToBoard("x-0-0");
// Console.WriteLine(ttt2.BoardDisplay());
// Console.WriteLine(ttt2.ToString());
Console.WriteLine("Goodbye, World!");
Console.ReadLine();
// Stopwatch stopwatch = new Stopwatch();
// string stringTest = string.Empty;
// StringBuilder sb = new StringBuilder();
// const long numberOfTests = 999999999;
//
// stopwatch.Restart();
// for (long i = 0; i < numberOfTests; i++)
// {
//     sb.Append("a");
// }
//
// sb.ToString();
// stopwatch.Stop();
// Console.WriteLine(stopwatch.ElapsedMilliseconds/1000.0);
//
// stopwatch.Restart();
// for (long i = 0; i < numberOfTests; i++)
// {
//     stringTest.Concat("a");
// }
//
// stringTest.ToString();
// stopwatch.Stop();
// Console.WriteLine(stopwatch.ElapsedMilliseconds/1000.0);