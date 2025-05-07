// Float
Console.WriteLine(0.25F);
// Imprime 0.25

// Decimal
Console.WriteLine(12.39816m);
// Imprime 12.39816

Console.WriteLine(2.625);
// Imprime 2.625

// Booleanos
Console.WriteLine(true);
// Imprime True

Console.WriteLine(false);
// Imrpime False

// Declaracion de variables
string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;


firstName = "John";
Console.WriteLine(firstName);

// var: usado para declarar variables de forma implícita, el compilador infiere el tipo de la variable, no se puede cambiar el tipo de la variable después de la declaración
var message = "Hello World!";
Console.WriteLine(message);

// Ejercicio
string name = "Bob";
int n = 3;
float f = 34.4F;

Console.WriteLine("Hello " + name + "! You have " + n + "messages in your inbox. The temperature is " + f + " celsius");
