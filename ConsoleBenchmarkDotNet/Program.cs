using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using ConsoleBenchmarkDotNet;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<Benchy>();

Console.ReadLine();

//const string ClearValue = "Password123!";

//var firstChars = ClearValue.Substring(0, 3);
//var length = ClearValue.Length - 3;

//for (var i = 0; i < length; i++)
//{
//    firstChars += '*';
//}

//Console.WriteLine(firstChars);