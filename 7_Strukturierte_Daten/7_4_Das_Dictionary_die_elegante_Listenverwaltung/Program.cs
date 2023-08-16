using System;

using static System.Console;

// leeres Dictionary
var wochentage = new Dictionary<int, string>();

wochentage.Add(1, "Montag");  // Elemente hinzufügen
wochentage.Add(2, "Dienstag");
wochentage.Add(3, "Mittwoch");
wochentage.Add(4, "Donnerstag");
wochentage.Add(5, "Freitag");
wochentage.Add(6, "Samstag");
wochentage.Add(7, "Sonntag");

WriteLine("Anzahl der Wochentagen: " + wochentage.Count);

WriteLine("Der erste Tag der Woche ist : " + wochentage[1]);

WriteLine("----------------------------------------");


//Dictionary<string,string> telefonVerzeichnis = new Dictionary<string, string>(); // leeres Dictionary

var telefonVerzeichnis = new Dictionary<string, string>()
{
    {"Hans", "123456789"},
    {"Peter", "987654321"},
    {"Maria", "456789123"}
};

var hansNummer = telefonVerzeichnis["Hans"];
WriteLine("Hans Nummer ist: " + hansNummer);

WriteLine("----------------------------------------");

telefonVerzeichnis.Add("Thea", "456123789"); // Elemente hinzufügen
telefonVerzeichnis.Add("Klaus", "789456123");

WriteLine("Anzahl der Einträge: " + telefonVerzeichnis.Count);

WriteLine("----------------------------------------");

WriteLine("Telefonverzeichnis:");
foreach (var eintrag in telefonVerzeichnis)
{
    WriteLine("Name: <" + eintrag.Key + ">, Nummer: <" + eintrag.Value + ">");
}

WriteLine("----------------------------------------");

WriteLine("Wessen Nummer suchen Sie?");
var name = ReadLine();
if (telefonVerzeichnis.ContainsKey(name)) // Key vorhanden?
{
    WriteLine($"Die Nummer von {name} ist: {telefonVerzeichnis[name]}");
}
else // Key nicht vorhanden
{
    WriteLine($"Es gibt keinen Eintrag für {name}.");
}

WriteLine("----------------------------------------");

WriteLine("Entfernen wir Klaus aus dem Telefonverzeichnis:");
telefonVerzeichnis.Remove("Klaus"); // Element entfernen
WriteLine("Telefonverzeichnis:");
foreach (var eintrag in telefonVerzeichnis)
{
    WriteLine("Name: <" + eintrag.Key + ">, Nummer: <" + eintrag.Value + ">");
}

WriteLine("----------------------------------------");

