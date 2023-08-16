// 7.6 Übungsaufgaben:
// Arbeiten mit Arrays, Listen, Dictionaries und Tuples


//Deklarieren Sie eine zusammengesetzte Struktur zur Speicherung von
//Festnetznummer. Mobilnummer und E-Mail-Adresse für mehrere Personen.
//Für eine Person speichern Sie dabei nur den Vornamen.
//Befüllen Sie diese Struktur beim Start des Programms mit ein paar Beispieldaten

using System;
using System.Collections.Generic;

using static System.Console;

namespace _7_6_Uebungsaufgaben_Arbeiten_mit_Arrays_Listen_Dictionaries_und_Tuples;
    class Program
    {
        static void Main(string[] args)
        {
            var telefonVerzeichnis =
                new Dictionary<string, (string Festnetznummer, string Mobilnummer, string Email)>()
                {
                    { "Hans", ("123456789", "987654321", "hans@email.de") },
                    { "Peter", ("987654321", "123456789", "peter@email.de") },
                    { "Maria", ("456789123", "789456123", "maria@email.de") }

                };

            var name = "";

            while (name != "Fertig!")
            {
                WriteLine("Wessen Nummer suchen Sie? Geben Sie bitte den Vornamen ein:");
                WriteLine("Oder geben Sie 'Fertig!' ein, um das Programm zu beenden.");
                
                name = ReadLine();
                WriteLine("-------------------------");
                if (name != "Fertig!" && telefonVerzeichnis.ContainsKey(name)) // Key vorhanden?
                {
                    WriteLine($"Die Nummer von {name} ist: {telefonVerzeichnis[name].Festnetznummer}");
                    WriteLine($"Die Mobilnummer von {name} ist: {telefonVerzeichnis[name].Mobilnummer}");
                    WriteLine($"Die E-Mail-Adresse von {name} ist: {telefonVerzeichnis[name].Email}");
                }
                else if (name != "Fertig!")
                {
                    WriteLine($"Es gibt keinen Eintrag für {name}.");
                }
                else
                {
                    WriteLine("Das Programm wird beendet.");
                    WriteLine("-------------------------");
                }
            }
        }

    }
    