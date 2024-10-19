// Composite Formatting
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}",first, second);
Console.WriteLine("{0} {1} {0}",first, second);


// string interpolation
/*string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");*/


// Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"price: {price:C} save({discount:C})");


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

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
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

