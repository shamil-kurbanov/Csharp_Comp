using System;
using System.Collections.Generic;

using static System.Console;

List<string> wochentage = new List<string>(); // leere Liste

wochentage.Add("Montag");  // Elemente hinzufügen
wochentage.Add("Dienstag");
wochentage.Add("Mittwoch");
wochentage.Add("Donnerstag");
wochentage.Add("Freitag");
wochentage.Add("Samstag");
wochentage.Add("Sonntag");

WriteLine("Anzahl der Wochenenden: " + wochentage.Count);

WriteLine("Der erste Tah der Woche ist " + wochentage[0]);

WriteLine();

// Elemente ausgeben
/*
foreach(var tag in wochentage){
    WriteLine(tag);
}
*/

WriteLine();
// Elemente ausgeben
WriteLine(string.Join(", ", wochentage)); // Ausgabe als String

var arbeitsWoche = wochentage.GetRange(0, 5); // Teil-Liste
WriteLine("Arbeitswoche: " + string.Join(", ", arbeitsWoche));

var vollerWoche = new List<string>();
vollerWoche.AddRange(wochentage); // Liste kopieren

vollerWoche.Remove("Montag"); // Element entfernen
WriteLine("Volle Woche ohne Montag: \n" + string.Join(", ", vollerWoche));

WriteLine("Entfernen wir noch Sontag mit RemoveAt(5):");
vollerWoche.RemoveAt(5); // Element Sontag entfernen

WriteLine("Volle Woche ohne Montag und Sonntag: \n" + 
          string.Join(", ", vollerWoche));

WriteLine("Entfernen wir noch Dienstag mit RemoveAt(1):");
vollerWoche.RemoveAt(1); // Element Dienstag entfernen

WriteLine("Volle Woche ohne Montag, Dienstag und Sonntag: \n" + 
          string.Join(", ", vollerWoche));





