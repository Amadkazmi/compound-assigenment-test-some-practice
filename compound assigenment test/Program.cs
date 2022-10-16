// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("practice!");
const float PI = 3.142f;
Console.WriteLine(PI);
//Constant vcalue cannot be change in programme
int a = 0;  
Console.WriteLine(a);
//here the value of vaiable can ne change anytime a 0
a = 10;
Console.WriteLine(a);
//its change  value of a 10
//a = a + 10;
Console.WriteLine(a);
// answer is 20 

a += 10; // is 20 compound method
Console.WriteLine($"Addition compund method :{a}");
//dollar$  compiler that the string following it is to be interpreted as an Interpolated String followed by {} key
a -= 10;
Console.WriteLine(a);
a *= 10;
Console.WriteLine(a);
a /= 10;
Console.WriteLine(a);
a %= 3;
Console.WriteLine(a);

//add some other details also
int myVar = 6;
myVar = myVar + 1;
Console.WriteLine($"Using a compund method with dollar key : {myVar}");

//now we can see some increment opertator and it can increase a number only 1 and decrement for use -1 value
int b = 2;
//b = b + 1;
Console.WriteLine(b); //normal way off adding values

/*b += 1;
Console.WriteLine(b + 1); //compound assigenment*/

b++;
Console.WriteLine($"increment : {b}");

b--;
Console.WriteLine($"decrement : {b}");

Console.WriteLine("\n---------------------\n");

Console.WriteLine("RELATIONAL OPERTAORS\n");


int Amad = 35;
int Arshad = 42;

bool ? older  = Amad > Arshad;
Console.WriteLine($"whos is older {older}");
// boolean is a true/flase data type
 myVar = 18;
string userage;
Console.WriteLine("Pls verify your age for log in");
userage = Console.ReadLine();
bool  Enteronly = myVar >18;
<<<<<<< HEAD
Console.WriteLine($"only access if you are over 18 year old :{myVar > 18}");
=======
Console.WriteLine($"only access over 18 year old :{myVar} ");
>>>>>>> 14d32926021375cda3a012414640f89c75b22b5f












