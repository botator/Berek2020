using berek;
using System.Text;

List<Dolgozok> list = new();

StreamReader sr = new(path: "C:\\Users\\bastyai.botond\\Desktop\\berek\\berek\\bin\\Debug\\net8.0\\berek2020.txt",encoding: Encoding.UTF8);
while (!sr.EndOfStream)
{
    list.Add(new Dolgozok(sr.ReadLine()));
}
sr.Close();

Console.WriteLine($"3.Feladat: Dolgozók száma {list.Count} fő");
var atlagber = list.Average(r => r.Ber);
Console.WriteLine($"4.Feladat: Bérek átlaga {(atlagber/1000):0.0} eFt");
Console.WriteLine("4.Feladat: Kérem a részleg nevét: ");
string reszleg = Console.ReadLine()!;
var vaneReszleg = list.Where(x => x.Reszleg == reszleg.ToLower());
if(vaneReszleg.Count() < 1)
{
    Console.WriteLine("6.feladat: A megadott részleg nem létezik a cégnél!");
}
else
{
    Console.WriteLine("6.feladat: A legtöbbet kereső dolgozó a megadott részlegen");
    var gazdagProli = vaneReszleg.MaxBy(x => x.Ber);
    Console.WriteLine(gazdagProli.ToString());
}
Console.WriteLine("7.Feladat: Statisztika");
var stat = list.GroupBy(x => x.Reszleg);
foreach(var x in stat)
{
    Console.WriteLine("\t"+x.Key+" - "+x.Count());
}
