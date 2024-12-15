using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

/*
Console.WriteLine("Signed Integral Types");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int  : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long  : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("Unsigned integral types");

Console.WriteLine($"byte  : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint  : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine();
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precition)");
*/
/*
int data;
data = new int[3];
int[] data = new int[3];
string shortenedString = "Hello World";

Console.WriteLine(shortenedString);

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");
*/

/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
*/

/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/

/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
*/

/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)(myDecimal);

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float : {myFloat}");
*/

/*
int first = 5;
int second = 10;
string message = first.ToString() + " " + second.ToString();
Console.WriteLine(message);
*/

/*

string first = "5";
string second = "10";
int sum = int.Parse(first)  + int.Parse(second);
Console.WriteLine(sum);
*/

/*
string value1 = "5";
string value2 = "7";

int result = Convert.ToInt32(value1) + Convert.ToInt32(value2);
Console.WriteLine(result);
*/

/*
int value = (int)1.999m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.599m);
Console.WriteLine(value2);
*/

//metodo TryParse
/*
string name = "Bob";
Console.WriteLine(int.Parse(name));
*/

/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement");
}
if (result > 0)
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/


/*
string[] values = {"12.3", "45", "ABC", "11", "DEF"};
decimal suma = 0m; 
string mensaje = "";
for (int i = 0; i < values.Length; i++)
{
    string valor = values[i];
    decimal numeros = 0m;
    
    // Console.WriteLine(valor);
    
    if (decimal.TryParse(valor, out numeros))
    {
        suma += numeros;
    }
    else
    {
        mensaje += valor;
    }
    
}
Console.WriteLine(suma);
Console.WriteLine(mensaje);
*/

/*
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

//Your code here to set result
//Hint: you need to round the result to nearest integer (don't just truncate)
decimal division1 = value1 / value2;
int result1 = Convert.ToInt32(division1);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//Your code here to set result2
decimal result2 = value2 / (decimal)value3;


Console.WriteLine($"Divide value2 by value1, display the result as a decimal: {result2}");

//Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float {result3}");
*/

/*
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Clear(pallets, 0, 1);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine();
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/


/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Console.WriteLine(valueArray.Length);
Array.Reverse(valueArray);
string result = String.Join(",",valueArray);
Console.WriteLine(result);
string[] items = result.Split(',');
Console.WriteLine(items);
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog";


string[] items = pangram.Split(" ");
string[] mensaje = new string[items.Length];
// string result = String.Join(" ", items);
// Console.WriteLine(result);
for (int i = 0; i < items.Length; i++)
{
    char[] letters = items[i].ToCharArray();
    Array.Reverse(letters);
    mensaje[i] = new string(letters) ;
    Console.WriteLine(letters);
}

string result = String.Join(" ", mensaje);
Console.WriteLine(result);
*/

/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] id = orderStream.Split(",");
Array.Sort(id);

for (int i = 0; i < id.Length; i++)
{
    // Console.Write(id[i]);
    if (id[i].Length == 4)
    {
        Console.WriteLine(id[i]);
    }
    else
    {
        Console.WriteLine(id[i] + "\t - Error" );
    }
    
}
*/

/*
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
Console.WriteLine($"{first} {second}");
Console.WriteLine($"{second} {first}");
Console.WriteLine($"{first} {first} {first}");
*/

/*
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C2} (Save {discount:C2})");
*/

/*
decimal measuremet = 123456.78912m;
Console.WriteLine($"Measurement: {measuremet:N} units" );

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price );
Console.WriteLine(yourDiscount);

yourDiscount += $"A discount of {((price - salePrice) / price):P1}!";  //inserted
Console.WriteLine(yourDiscount);
*/


int invoiceNumber = 1201;
decimal productShares = 25.456m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .1582m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Share: {productShares:N3} Product");
Console.WriteLine($"        Sub Total: {subtotal:C}");
Console.WriteLine($"            Tax: {taxPercentage:P2}");
Console.WriteLine($"        Total Billed: {total:C}");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymethod = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formatedLine = paymethod.PadRight(6);
formatedLine += payeeName.PadRight(24);
formatedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formatedLine);
