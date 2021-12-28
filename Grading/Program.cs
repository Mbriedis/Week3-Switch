// See https://aka.ms/new-console-template for more information
//programm küsib, mis hinde kasutaja sai?
//kui kasutaja sai "A", Konsool kuvab "Suurepärane",
//kui "B", konsool kuvab "väga hea!",
//kui "C", konsool kuvab "Hea!",
//kui "D", konsool kuvab "Rahuldav!",
//kui "E", konsool kuvab "kasin!"
//kui "F", konsool kuvab "puudulik" 
//kasutame IF 
Console.WriteLine("sisesta oma tulemus");
//char-  character
char userresult = Convert.ToChar(Console.ReadLine().ToUpper());
if (userresult == 'A')   
    Console.WriteLine("Väga hea! Super, Tubli töö!");
else if (userresult == 'B')
    Console.WriteLine("Väga hea! võid enda üle uhke olla");
else if (userresult == 'C')
    Console.WriteLine("Hea! aga võib veel paremini!");
else if (userresult == 'D')
    Console.WriteLine("Rahuldatav");
else if (userresult == 'E')
    Console.WriteLine("Kas see on su parim tulemus mida sa suudad teha????");
else Console.WriteLine("Kuule, mine õpi uuesti ja proovi veel, see on täiesti absurdne, uskumatu et nii palju aega veedad arvutit mängides ja ei saa tunnikest loovutada õppimise peale, häbi sul olgu :)");
Console.WriteLine("Häid pühi!");