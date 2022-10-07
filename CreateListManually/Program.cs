// See https://aka.ms/new-console-template for more information

using CreateListManually;

MyList<string> values = new MyList<string>();
values.Add("Phyton");
values.Add("C#");
values.Add("Java");

foreach (var item in values.Items)
{
    Console.WriteLine(item);
}

Console.WriteLine();

Console.WriteLine("Count: " + values.Count);