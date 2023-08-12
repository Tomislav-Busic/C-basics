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

Console.WriteLine("Test");

int LADSJFLKDJASF =  1/1;
Console.WriteLine(LADSJFLKDJASF);

int modulesExample = 11 % 4;
Console.WriteLine(modulesExample);

double testDouble2 = 11 / 4;
Console.WriteLine(testDouble2);

double testDouble3 = 11.00 / 4;
Console.WriteLine(testDouble3);

int testInteger = 1;
testInteger = testInteger + 1;
Console.WriteLine(testInteger);

int testInteger2 = 1;
testInteger2 += 1;
Console.WriteLine(testInteger2);

// +=
// -=
// +=

// ++
// --

int learnVariables = 0;
learnVariables++;
learnVariables--;
Console.WriteLine(learnVariables);

Console.WriteLine(newLine);

//////////////////////////////////////////////////////////

Console.WriteLine("Type Casting");

// Type Casting in C#

// Converting data after it has been assigned at compilation
// Implicit and Explicit

double x = 2345.43;
int a;
// Cast double to int. EXPLICIT CONVERSATION
a = (int)x;
Console.WriteLine(a);

// String to int;

string value = "2345234";
int result;
if (int.TryParse(value, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure.");
}

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

// Array - collection of fixed set of values. Arrays are used to store multiple values in a single variable;

Console.WriteLine("Arrays");

// Fixed

int[] firstArr = new int[2];

string[] stringArr = new string[2];

object[] objectsArr = new object[4];

firstArr[0] = 1;

Console.WriteLine(firstArr);
Console.WriteLine(stringArr);
Console.WriteLine(objectsArr);

// Dynamic

int[] staticArrays = new int[] { 1, 2, 3, 4 };

Console.WriteLine(staticArrays[0]);

foreach (int num in staticArrays)
{
    Console.WriteLine(num);
}

var avargeValue = staticArrays.Average();

Console.WriteLine(avargeValue);

// Array - right click -> go to definition

Console.WriteLine(newLine);

///////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Strings In-Depth");

// Strings - an object whose value is text.

// reference type

// double
string word = "task";

// single
char[] letters = new char[] {'t', 'a', 's', 'k', 's' };

Console.WriteLine(word);
Console.WriteLine(letters);

// VALUE TYPES CANNOT BE NULL
string message = null;

// Literal vs Verbatim
string filePath = "c:\\ProgramFiles";

string filePathVerbatim = @"c:\\ProgramFiles";

// Strings immutability (Read only)

string s1 = "Hello ";
string s2 = s1;
s2 += "World";

Console.WriteLine(s2);







