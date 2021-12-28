// See https://aka.ms/new-console-template for more information
//Programm küsib kasutajal sisestada oma lemmikvärv
//Kui Kasutaja sisestab "Punane" Konsool kuvab: "oled romantiline";
//kui kasutaja sisestab "sinine" konsool kuvab: "oled töökas";
//kui kasutaja sisestab "roheline" konsool kuvab: "oled looduse sõber";
//Kui kasutaja sisestab midagi muud, konsool kuvab "oled {usercolor} ükssarvik";
Console.WriteLine("Sisesta oma lemmikvärv");
string userColor = Console.ReadLine().ToLower ();
//Punane, Sinine, Roheline
switch (userColor)
{ case "punane": Console.WriteLine("oled romantiline"); break;
    case "sinine":
        Console.WriteLine("oled töökas"); break;
    case "roheline":
        Console.WriteLine("oled looduse sõber"); break;
    default: Console.WriteLine($"oled {userColor} ükssarvik"); break;
}
Console.WriteLine("Kena päeva!");


