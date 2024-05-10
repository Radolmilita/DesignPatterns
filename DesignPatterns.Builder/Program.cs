using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Directors;
using DesignPatterns.Builder.Interfaces;

IBuilder builder = new BilliardsTableBuilder();
var director = new Director(builder);

director.ConstructTable();

var table = builder.GetResult();
Console.WriteLine(table.Display());

Console.WriteLine("Press any key to exit...");
Console.ReadKey();