﻿// Use the string's IndexOf() and Substring() helper methods


//Write code to find parenthesis pairs embedded in a string
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf("(");
int closingPosition = message.IndexOf(")");

Console.WriteLine($"{openingPosition} \n {closingPosition}");

// Add code to retrieve the value between parenthesis
string msg = "Find what is (inside the parentheses)";

int openingPos = msg.IndexOf('(');
int closingPos = msg.IndexOf(')');

//int length = closingPos - openingPos;
//Console.WriteLine(message.Substring(openingPos, length));

//Modify the starting position of the sub string
openingPos = openingPos + 1;

int length = closingPos - openingPos;
Console.WriteLine(message.Substring(openingPos, length));

///////////////

string msage = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openPosition = msage.IndexOf("<span>");
int closPosition = msage.IndexOf("</span>");

//openPosition += 6;
openPosition += openSpan.Length;
int lngth = closPosition - openPosition;
Console.WriteLine(msage.Substring(openPosition, lngth));

// Use the string's IndexOf() and LastIndexOf() helper methods

string messageVal = "hello there!";

int first_h = messageVal.IndexOf('h');
int last_h = messageVal.LastIndexOf('h');

Console.WriteLine($"For the message: '{messageVal}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
Console.WriteLine("-----------------------------");

string val = "Big Dog";
val = val.Replace("B", "D");
Console.WriteLine(val);