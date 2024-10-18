// Sort() and Reverse()

//Create an array of pallets, then sort them


string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("-----------");
Console.WriteLine("-----------");

Console.WriteLine("--Reverse--");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine("---" + pallet);
}

Console.WriteLine("-----------");
Console.WriteLine("-----------");


Console.WriteLine("--CLear--");
//Array.Clear(pallets,0,2);
Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine("----" + pallet);
}

Console.WriteLine("-----------");
Console.WriteLine("-----------");

//Call a string helper method on a cleared element
/*Console.WriteLine("--Call a string helper method on a cleared element--");
string[] pallett = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Console.WriteLine($"Before: {pallett[1].ToLower()}");
Array.Clear(pallett, 0, 2);
//Console.WriteLine($"After: {pallett[0].ToLower()}");
if (pallets[1] != null)
    Console.WriteLine($"After: {pallets[1].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallett.Length}");
foreach (var pallete in pallett)
{
    Console.WriteLine($"-- {pallete}");
}*/

Console.WriteLine("resize");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "Col1";
pallets[5] = "Col2";

foreach (var pallet in pallets)
{

    Console.WriteLine($"-- {pallet}");
}

//Resize the array to remove elements

Console.WriteLine("Resize the array to remove elements");

Array.Resize(ref pallets, 3);
Console.WriteLine("Resising 3 -- count:"+ pallets.Length);

foreach(var pallet in pallets){
    Console.WriteLine("--" + pallet);
}


////////String data type's Array methods
///
Console.WriteLine("Use the ToCharArray() to reverse a string");

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// Combine all of the chars into a new comma-separated-value string using Join()
Console.WriteLine("Combine all of the chars into a new comma-separated-value string using Join()");
string input = "abc123";
char[] givenValue = input.ToCharArray();
Array.Reverse(givenValue);
//string output = new string(givenValue);
//string output = string.Join(",", givenValue);
string output = string.Join("-", givenValue);
Console.WriteLine(output);

//Split() the comma-separated-value string into an array of strings
string[] items =output.Split('-');
foreach (string item in items)
{
    Console.WriteLine(item);
}


//Complete a challenge to reverse words in a sentence

string pangram = "The quick brown fox jumps over the lazy dog";
//Write code to reverse each word in a message


// Split the sentence into words
string[] msg = pangram.Split(' ');

// Create a new array to store the reversed words
string[] newMessage = new string[msg.Length];

// Iterate through each word
for (int i = 0; i < msg.Length; i++)
{
    // Convert each word to a char array
    char[] letter = msg[i].ToCharArray();
    
    // Reverse the char array
    Array.Reverse(letter);
    
    // Convert the reversed char array back to a string and store it in newMessage
    newMessage[i] = new string(letter);
}

// Join the reversed words into a single sentence
string res = String.Join(" ", newMessage);

// Output the result
Console.WriteLine(res);
