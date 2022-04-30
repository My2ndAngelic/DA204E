// See https://aka.ms/new-console-template for more information

using BackendLibrary;

Console.WriteLine("Hello, World!");
TicTacToe ttt = new TicTacToe("PP|aaxoxaaaa");
Console.WriteLine(Utilities.Arrays.DeepToString(ttt.Board));
Console.WriteLine("Goodbye, World!");
