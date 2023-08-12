// See https://aka.ms/new-console-template for more information

using SecondC_;

var name = "Tomislav";
Console.WriteLine(name);

string newLine = "//////////////////////////////////////////////////////////////////////////////";
Console.WriteLine(newLine);

//////////////////////////////////////////////////

// DATA TYPES


int integerExe = 7 + 5;
string b = "34524" + "83457";
byte c = 255; // 0-255 max
double testDouble = 14.45;
float testFloat = 23.2323f; // f to the end
decimal testDecimal = .1212356m; // m to the end


/////////////////////////////////////////////////////////////



Console.WriteLine(newLine);

//////////////////////////////////////////////////////////

TypeCasting typeC = new();

Console.WriteLine(typeC);

Console.WriteLine(newLine);

////////////////////////////////////////////////////////////////////

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

////////////////////////////////////////////////////////////////////

Arrays arraysExm = new();

Console.WriteLine(arraysExm);

Console.WriteLine(newLine);


///////////////////////////////////////////////////////////////////////////////

StringsInDepth stringsInD = new();

Console.WriteLine(stringsInD);







