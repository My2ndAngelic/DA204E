using BackendLibrary;

Console.WriteLine("Hello, World!");
TicTacToe ttt = new TicTacToe();
Console.WriteLine(TicTacToe.CheckBoard("aaaaaaaaa")); // true
Console.WriteLine(ttt.ToStringFile());