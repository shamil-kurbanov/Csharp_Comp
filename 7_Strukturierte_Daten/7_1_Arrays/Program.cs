using System;
using static System.Console;

int[] zahlen = new int[6];

WriteLine("Bitte geben Sie 6 Zahlen ein:");
for (int i = 0; i < zahlen.Length; i++)
{
    Write($"Zahl {i + 1}: ");
    zahlen[i] = Convert.ToInt32(ReadLine());
}

WriteLine("Sie haben folgende Zahlen eingegeben:");
for (int i = 0; i < zahlen.Length; i++)
{
    WriteLine($"Zahl {i + 1}: {zahlen[i]}");
}

// Ausgabe als String
WriteLine("Zahlen in einem String:");
WriteLine(string.Join(", ", zahlen));

WriteLine("3. Element ist: " + zahlen[2]); // 3. Element

Array.Resize(ref zahlen, 12); // Array vergrößern
WriteLine("Länge des Arrays: " + zahlen.Length);
WriteLine(string.Join(", ", zahlen));
