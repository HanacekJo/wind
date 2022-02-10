// See https://aka.ms/new-console-template for more information
using Logic;

Console.WriteLine("Hello, World!");

// komentar
double number = 15;
number += 5;
number++;
string text = "Mira";
Console.WriteLine("Nubber:" + number + " mm");
Console.WriteLine($"Nubber: {number}");
FileProcesor fileProcesor = new FileProcesor();
// Vytvořím instanci (objekt) třídy FileProcessor s názvem fileProcessor
// new FileProcesor() = kontruktor
fileProcesor.Path = @"C:\Users\josef.hanacek\source\repos\Wind.UI\Wind.UI\files";
fileProcesor.LoadFile();
Console.ReadLine();