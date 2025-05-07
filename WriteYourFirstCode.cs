// Hay un salto de linea al final
Console.WriteLine("Hello, World!");

// Se imprime en una sola línea
Console.Write("Congratualtions!");
Console.Write(" ");
Console.Write("You crote your first lines of code");

string firstName;
firstName = "John";
Console.WriteLine(firstName);

// var: usado para declarar variables de forma implícita, el compilador infiere el tipo de la variable, no se puede cambiar el tipo de la variable después de la declaración
var message = "Hello World!";
Console.WriteLine(message);

string name = "Bob";
int n = 3;
float f = 34.4F;

Console.WriteLine("Hello " + name + "! You have " + n + "messages in your inbox. The temperature is " + f + " celsius");

// ************ PERFORM BASIC STRING FORMATTING IN C# ************

Console.WriteLine("Hello\nWorld");
Console.WriteLine("Hello\tWorld");

// \ para imprimir caracteres especiales
Console.WriteLine("Hello \"World\""); 

// Si se usa para direcciones de archivos, se debe usar \\
Console.WriteLine("C:\\sourse\\repos");

// Format output using character escape sequences: example
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Cadena literal textual
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)"); 
// El prefijo @ indica que la cadena es una cadena literal, se puede ignorar el uso de \\ y se convervan los saltos de línea y los espacios en blanco

// Concatenate a literal string and a variable
string firstName = "John";
string message = "Hello " + firstName + "!";
Console.WriteLine(message);

// Combine strings using string interpolation
string greeting = "Hello";

string message2 = $"{greeting} {firstName}!";
Console.WriteLine(message2);

int version = 11;
string updateText = "Update to Windows";
string updateMessage = $"{updateText} {version}";
Console.WriteLine(updateMessage);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
