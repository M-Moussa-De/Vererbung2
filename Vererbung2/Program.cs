using Vererbung2;

// Selbstverständnis gilt die Regeln der Polymorphie hier.
// Dies heißt, man kann alle abgeleitete Klassen mit hilfe von der abgestammten Klasse initialisiert

Einwohner einwohner = new Einwohner(2500);
Console.WriteLine(einwohner);

Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();

Koenig koenig = new Koenig(37000);
Console.WriteLine(koenig);

Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();

Adel adel = new Adel(23000);
Console.WriteLine(adel);


Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();

Bauer leibeigener = new Bauer(1200);
Console.WriteLine(leibeigener);


