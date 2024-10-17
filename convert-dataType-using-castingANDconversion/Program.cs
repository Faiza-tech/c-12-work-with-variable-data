//Write code that attempts to add an 'int' and a 'string' and save the result in an 'int'
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

Console.WriteLine("**********");
Console.WriteLine("**********");

int myInt = 3;
Console.WriteLine($"int: {myInt}");
decimal myDecimal = myInt ;
Console.WriteLine($"decimal: {myDecimal}");

Console.WriteLine("**********");
Console.WriteLine("**********");

//Perform a cast
decimal myDecimal2 = 3.14m ;
Console.WriteLine($"decimal: {myDecimal2}");
int myInt2 = (int)myDecimal2 ;
Console.WriteLine($"int: {myInt2}");


Console.WriteLine("**********");
Console.WriteLine("**********");

string value = "102";
int resultFinal = 0;
if (int.TryParse(value, out resultFinal))
{
   Console.WriteLine($"Measurement: {resultFinal}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + resultFinal}");


Console.WriteLine("**********");
Console.WriteLine("**********");

//Complete a challenge to combine string array values as strings and as integers

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string message = "";
foreach (string item in values){
   // Console.WriteLine("The values are:" + item);
   decimal number;
   if(decimal.TryParse(item, out number)){
    total += number;
   }else{
    message += item;
   }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

Console.WriteLine("**********");
Console.WriteLine("**********");

//Complete a challenge to output math operations as specific number types

int valuee1 = 11;
decimal valuee2 = 6.2m;
float valuee3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32 (valuee1) /Convert.ToInt32 (valuee2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: { result1}");

// Your code here to set result2
decimal result2 = Convert.ToDecimal (valuee2)/Convert.ToDecimal (valuee3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = Convert.ToSingle (valuee3) / Convert.ToSingle (valuee1);
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");