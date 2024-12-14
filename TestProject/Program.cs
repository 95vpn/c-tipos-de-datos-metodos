﻿using System.Globalization;
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
