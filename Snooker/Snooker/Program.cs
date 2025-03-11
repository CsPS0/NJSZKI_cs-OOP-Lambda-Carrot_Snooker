#region 1.fel
using Snooker;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("1. Feladat");
Console.ResetColor();

List<Versenyzok> lista = new List<Versenyzok>();

StreamReader r = new StreamReader("snooker.txt");
int sorok = 1; //TODO: első sort kihagyni
while (!r.EndOfStream)
{
    string[] tomb = r.ReadLine().Split(";");
    int helyezes = int.Parse(tomb[0]);
    string nev = tomb[1];
    string orszag = tomb[2];
    int nyeremeny = int.Parse(tomb[3]);

    lista.Add(new Versenyzok(helyezes, nev, orszag, nyeremeny));
    sorok++;
}
Console.WriteLine("A fájlok beolvasása sikeres!");
#endregion

#region 2.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2. Feladat");
Console.ResetColor();

Console.WriteLine($"A világranglistán {lista.Count} versenyző szerepel");
#endregion

#region 3.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3. Feladat");
Console.ResetColor();

var nyertes = lista.OrderBy(x => x.Helyezes).ToList();
Console.WriteLine($"Az első helyen áll:\n\tNév: {nyertes[0].Nev}\n\tOrszág: {nyertes[0].Orszag}\n\tNyeremény: {nyertes[0].Nyeremeny} font");
#endregion

//#region 4.fel
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("4. Feladat");
//Console.ResetColor();
//#endregion

#region 5.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("5. Feladat");
Console.ResetColor();

var nemAnglia = lista.Where(x => x.Orszag != "Anglia").ToList();
Console.WriteLine($"{nemAnglia.Count} versenyző nem Anglia színeiben indul");
#endregion

#region 6.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("6. Feladat");
Console.ResetColor();
#endregion

#region 7.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("7. Feladat");
Console.ResetColor();
#endregion

#region 8.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("8. Feladat");
Console.ResetColor();
#endregion

#region 9.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("9. Feladat");
Console.ResetColor();
#endregion

#region 10.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("10. Feladat");
Console.ResetColor();
#endregion