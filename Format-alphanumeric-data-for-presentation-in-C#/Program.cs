// Composite Formatting
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}", first, second);
Console.WriteLine("{0} {1} {0}", first, second);


// string interpolation
/*string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");*/


// Formatting currency
decimal pricee = 123.45m;
int discount = 50;
Console.WriteLine($"price: {pricee:C} save({discount:C})");


// Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N}");
Console.WriteLine($"Measurement: {measurement:N4} units");


// Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


// Combining formatting approaches
decimal price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
Console.WriteLine(yourDiscount);


Console.WriteLine("---------------");
Console.WriteLine("---------------");
// Display the invoice number using string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Display the product shares with one thousandth of a share (0.001) precision
Console.WriteLine($"   Shares: {productShares:N3} Product");

// Display the subtotal that you charge the customer formatted as currency
Console.WriteLine($"     Sub Total: {subtotal:C}");

// Display the tax charged on the sale formatted as a percentage
Console.WriteLine($"           Tax: {taxPercentage:P2}");

// Finalize the receipt with the total amount due formatted as currency
Console.WriteLine($"     Total Billed: {total:C}");

Console.WriteLine("--------------");

// Formatting strings by adding whitespace before or after
string input = "Pad this";
Console.WriteLine($"output for Left is: {input.PadLeft(12)} this");

Console.WriteLine($"output for Right is: {input.PadRight(12)} this");

Console.WriteLine("--------------");

// overloaded method
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

Console.WriteLine("--------------");
//// Working with padded strings

//  Add the Payment ID to the output
string paymentId = "769C";
var formattedLine = paymentId.PadRight(6);
Console.WriteLine(formattedLine);

// Add the payee name to the output
string payeeName = "Mr. Stephen Ortega";
formattedLine += payeeName.PadRight(24);
// or  formattedLine =  formattedLine + payeeName.PadRight(24);
Console.WriteLine(formattedLine);

// Add the payment amount to the output
string paymentAmount = "5,000.00";
formattedLine += paymentAmount.PadLeft(10);
// or  var formattedLine = paymentId.PadRight(6) + payeeName.PadRight(24) +paymentAmount.PadLeft(10);
Console.WriteLine(formattedLine);


Console.WriteLine("--------------"); Console.WriteLine("--------------");

// Complete a challenge to apply string interpolation to a form letter
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);


// Your logic here

Console.WriteLine(comparisonMessage);