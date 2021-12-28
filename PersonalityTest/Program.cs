// See https://aka.ms/new-console-template for more information

//Programm küsib kasutajal sisestada oma lemmikvärv
//Kui Kasutaja sisestab "Punane" Konsool kuvab: "oled romantiline";
//kui kasutaja sisestab "sinine" konsool kuvab: "oled töökas";
//kui kasutaja sisestab "roheline" konsool kuvab: "oled looduse sõber";
//Kui kasutaja sisestab midagi muud, konsool kuvab "oled {usercolor} ükssarvik";
Console.WriteLine("Sisesta oma lemmikvärv");
string userColor = Console.ReadLine();
if (userColor == "punane")
    Console.WriteLine("oled romantiline");
else if (userColor == "sinine")
    Console.WriteLine("oled töökas");
else if (userColor == "roheline")
    Console.WriteLine("oled looduse sõber");
else Console.WriteLine($"oled {userColor} ükssarvik");
Console.WriteLine("kena päeva!");