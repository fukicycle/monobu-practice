using Monobu.Practice3;

var akira = new Human(DateOnly.Parse("1999-01-01"), "akira", 170, 60);
akira.LoveHuman = new Human(DateOnly.Parse("1999-01-01"), "suzu", 170, 60);
Console.WriteLine(akira.LoveHuman.Fullname);

var gojo = new PrivateHuman(DateOnly.Parse("1999-01-01"), "gojo", 170, 60);
gojo.SetLoveHuman(new Human(DateOnly.Parse("1999-01-01"), "suzu", 170, 60));
//Console.WriteLine(gojo.LoveHuman.Fullname);

//gojo.LoveHuman = new Human(DateOnly.Parse("1999-01-01"), "suzu", 170, 60);
//Console.WriteLine(gojo.LoveHuman.Fullname);