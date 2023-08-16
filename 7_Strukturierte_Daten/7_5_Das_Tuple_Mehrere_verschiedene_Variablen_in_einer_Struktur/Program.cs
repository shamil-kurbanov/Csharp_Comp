using System;

using static System.Console;

//Das Tuple: Mehrere verschiedene Variablen in einer Struktur

WriteLine("----------------------------------------");
var person = ("Hans", "Muster", 42, 1.78, true);

WriteLine("Name: " + person.Item1);
WriteLine("Nachname: " + person.Item2);
WriteLine("Alter: " + person.Item3);
WriteLine("Groesse in m: " + person.Item4);
WriteLine("Verheiratet: " + person.Item5);

WriteLine("----------------------------------------");

// Deklaration eines Tuples
(string, string, int, double, bool) person2 = ("Hans", "Muster", 42, 1.78, true);

// Deklaration eines Tuples mit Namen
(string Vorname, string Nachname, int Alter, double Groesse, bool Verheiratet) person3 = ("Hans", "Muster", 42, 1.78, true);

WriteLine("Name: " + person3.Vorname);
WriteLine("Nachname: " + person3.Nachname);
WriteLine("Alter: " + person3.Alter);
WriteLine("Groesse in m: " + person3.Groesse);
WriteLine("Verheiratet: " + person3.Verheiratet);

WriteLine("----------------------------------------");

//Funktionen mit Tuple als Rückgabewert
(string Name, string, int, double, bool) GetPerson()
{
    return ("Hans", "Muster", 42, 1.78, true);
}

var person4 = GetPerson();
WriteLine("Name: " + person4.Name);


WriteLine("----------------------------------------");

// Welche möglichkeiten bietet das Tuple?
// 1. Möglichkeit: Deklaration mit var
var person5 = ("Hans", "Muster", 42, 1.78, true);

// 2. Möglichkeit: Deklaration mit Tuple
Tuple<string, string, int, double, bool> person6 = ("Hans", "Muster", 42, 1.78, true);

// 3. Möglichkeit: Deklaration mit Tuple und Namen
Tuple<string, string, int, double, bool> person7 = Tuple.Create("Hans", "Muster", 42, 1.78, true);

// 4. Möglichkeit: Deklaration mit Tuple und Namen
var person8 = Tuple.Create("Hans", "Muster", 42, 1.78, true);

WriteLine("----------------------------------------");

//wie kann ich auf die einzelnen Elemente zugreifen?
// 1. Möglichkeit: Zugriff über Item1, Item2, Item3, ...
WriteLine("Name: " + person8.Item1);

// 2. Möglichkeit: Zugriff über Namen
WriteLine("Name: " + person8.Item1);

//wie kann ich die einzelnen Elemente ändern?
// 1. Möglichkeit: Zugriff über Item1, Item2, Item3, ...
person8.Item1 = "Peter";

// 2. Möglichkeit: Zugriff über Namen
person8.Item1 = "Peter";

WriteLine("----------------------------------------");


//Wie kann ich ein Tuple in ein anderes Tuple kopieren?
// 1. Möglichkeit: Kopieren über Item1, Item2, Item3, ...
var person9 = person8;

// 2. Möglichkeit: Kopieren über Namen
var person10 = person8;


WriteLine("----------------------------------------");


//wie kann ich alle Elemente eines Tuples ausgeben?
// 1. Möglichkeit: Ausgabe über Item1, Item2, Item3, ...
WriteLine("Name: " + person8.Item1);
WriteLine("Nachname: " + person8.Item2);
WriteLine("Alter: " + person8.Item3);
WriteLine("Groesse in m: " + person8.Item4);
WriteLine("Verheiratet: " + person8.Item5);

//wie kann ich ein Element eines Tuples löchen?
// 1. Möglichkeit: Löschen über Item1, Item2, Item3, ...
person8.Item1 = null;
