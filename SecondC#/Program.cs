// See https://aka.ms/new-console-template for more information

using SecondC_;

string newLine = "//////////////////////////////////////////////////////////////////////////////";
Console.WriteLine(newLine);

///////////////////////////

DataTypes dataTypes = new();

Console.WriteLine(dataTypes);

Console.WriteLine(newLine);

///////////////////////////

Tests tests = new();

Console.WriteLine(tests);

Console.WriteLine(newLine);

///////////////////////////

TypeCasting typeC = new();

Console.WriteLine(typeC);

Console.WriteLine(newLine);

///////////////////////////

Console.WriteLine("Stack vs Heap");

// Stack is for value type and a Heap is for reference types

// Stack has very small types of data
// Heap is usually reserved for large pices of data (objects)

int testValue = 4;
string stringValue = "reference type";

Console.WriteLine(stringValue);

FirstHeap stackHeap = new();

var calculator = stackHeap.AddFive(testValue);

Console.WriteLine(calculator);

Console.WriteLine(newLine);

///////////////////////////

Arrays arraysExm = new();

Console.WriteLine(arraysExm);

Console.WriteLine(newLine);

///////////////////////////

StringsInDepth stringsInD = new();

Console.WriteLine(stringsInD);

Console.WriteLine(newLine);

///////////////////////////

// Lists in C#

List<ListsPart> myList = new()
{
    new ListsPart { PartName = "Tomislav", PartId = 1 },
    new ListsPart { PartName = "Tajana", PartId = 2 },
    new ListsPart { PartName = "Dora", PartId= 3}
};

foreach(ListsPart part in myList)
{
    Console.WriteLine($"name: {part.PartName}, id: {part.PartId}");
}


Console.WriteLine(newLine);

///////////////////////////

IfElseStatements ifElse = new();

Console.WriteLine(ifElse);

Console.WriteLine(newLine);

///////////////////////////

Loops loops = new();

Console.WriteLine(loops);

string word = "sssddd";

LoopsAlgorithm forAlg = new();  // Javascript exercises with a small correction

string code = forAlg.CountRepeatingLetters(word);
string encode = forAlg.ReverseCode(code);

if (word == encode)
{
    Console.WriteLine("Both functions work!");
}

Console.WriteLine(newLine);

///////////////////////////




