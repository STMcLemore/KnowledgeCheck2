
using KnowledgeCheck2;

Console.WriteLine("How many guitars do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());



var recordList = new List<Guitar>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var guitar = new Guitar();

    Console.WriteLine("Enter the brand of guitar ");
    guitar.Brand = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("What color is the guitar?");
    guitar.GuitarColor = Console.ReadLine();
    Console.WriteLine();

    recordList.Add(guitar);
}

// Print out the list of records using Console.WriteLine()
foreach(var guitar in recordList)
{
    Console.WriteLine(guitar.ToString());
}
