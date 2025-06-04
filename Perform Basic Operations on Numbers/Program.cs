// ----- Perform addition with implicit data conversion -----
Console.WriteLine("----- Perform addition with implicit data conversion -----");

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber); //19

string firstName = "bob";
int number = 7;

Console.WriteLine(firstName + " sold " + number + " widgets"); //bob sold 7 widgets
Console.WriteLine(firstName + " sold " + number + 7 + " widgets"); //bob sold 77 widgets
Console.WriteLine(firstName + " sold " + (number + 7) + " widgets"); //bob sold 14 widgets

// ----- Perform math operations -----
Console.WriteLine("\n----- Perform math operations -----");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient); // 1

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"1. Decimal quotient: {decimalQuotient}"); //1.4

decimalQuotient = 7 / 5.0m;
Console.WriteLine($"2. Decimal quotient: {decimalQuotient}"); //1.4

decimalQuotient = 7.0m / 5.0m;
Console.WriteLine($"3. Decimal quotient: {decimalQuotient}"); //1.4

int first = 7;
int second = 5;
decimal quotient_two = (decimal)first / (decimal)second;
Console.WriteLine($"4. Decimal quotient: {quotient_two}"); // 1.4

// Module
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // 0
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}"); // 2

// ----- Increment and decrement values -----
Console.WriteLine("\n----- Increment and decrement values -----");

int value = 0;
value += 5;

value = 0;
value++;
value--;

// ----- Complete the challenge to convert Fahrenheit to Celsius -----
Console.WriteLine("Complete the challenge to convert Fahrenheit to Celsius");

// Fahrenheit -> Celsius, first subtract 32, then multiply by five ninths (5 / 9).

int fahrenheit = 94;

decimal celsius = Math.Round((fahrenheit - 32) * (5.0m/9.0m), 1);

Console.WriteLine($"The remperature is {celsius} Celsius");
