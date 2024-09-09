// See https://aka.ms/new-console-template for more information
using InterfaceExamples;


//List of animals?
List<object> list = new();
list.Add(new Dog());
list.Add(new Chicken());

foreach(object o in list)
{
    Console.WriteLine(o.Sound());
}