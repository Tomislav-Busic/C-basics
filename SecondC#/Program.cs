// See https://aka.ms/new-console-template for more information

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
if(int.TryParse(value, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure.");
}

Console.WriteLine(newLine);

//////////////////////////////////////////////////////////////////////////



