// See https://aka.ms/new-console-template for more information
//programm küsib, mis hinde kasutaja sai?
//kui kasutaja sai "A", Konsool kuvab "Suurepärane",
//kui "B", konsool kuvab "väga hea!",
//kui "C", konsool kuvab "Hea!",
//kui "D", konsool kuvab "Rahuldav!",
//kui "E", konsool kuvab "kasin!"
//kui "F", konsool kuvab "puudulik" 
//kasutame Switch  
Console.WriteLine("sisesta oma tulemus");
//char-  character
char userresult = Convert.ToChar(Console.ReadLine().ToUpper());
switch (userresult)
{
case 'A': Console.WriteLine("Väga hea, ülejäänud klass peaks sinult eeskuju võtma"); break;
case 'B': Console.WriteLine("Väga Hea! Võid enda üle uhke olla"); break;
case 'C': Console.WriteLine("Hea, võis paremini aga hea"); break;
case 'D': Console.WriteLine("Rahuldav, ma teeks uuesti aga mis seal ikka"); break;
case 'E':Console.WriteLine("Kas see on parim da sa suudad??"); break;
default: Console.WriteLine("Sul on veel 2 võimalust tõestada et oled vääriline siin ülikoolis eksisteerimast, pane ennast luku taga ja õpi asjad selgeks!"); break;
}
Console.WriteLine("Head uut aastat!");

