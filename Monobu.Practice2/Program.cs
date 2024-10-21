// See https://aka.ms/new-console-template for more information
using Monobu.Practice2;
/*
 * クラスとメソッドとコンストラクタ
 */

Console.WriteLine("Generate satoyama");
Human satoyama = new Human();
satoyama.BirthDate = DateOnly.Parse("1995-07-10");
satoyama.Weight = 60;
satoyama.Height = 170;
satoyama.Walk();
satoyama.Eat();
satoyama.Sleep();
Console.WriteLine(satoyama.BirthDate);
Console.WriteLine(satoyama.Fullname);
Console.WriteLine(satoyama.Height);
Console.WriteLine(satoyama.Weight);
Console.WriteLine();

Console.WriteLine("Generate sato");
KanzenHuman sato = new KanzenHuman(DateOnly.Parse("1999-01-30"), "Fuki Sato", 174, 60);
sato.Walk();
sato.Eat();
sato.Sleep();
Console.WriteLine(sato.BirthDate);
Console.WriteLine(sato.Fullname);
Console.WriteLine(sato.Height);
Console.WriteLine(sato.Weight);
Console.WriteLine();

/*
 * 抽象クラスとインターフェース
 */
Console.WriteLine("Generate kobayashi");
AbstractHuman kobayashi = new Kobayashi();
kobayashi.Walk();
kobayashi.Eat();
kobayashi.Sleep();
Console.WriteLine(kobayashi.BirthDate);
Console.WriteLine(kobayashi.Fullname);
Console.WriteLine(kobayashi.Height);
Console.WriteLine(kobayashi.Weight);