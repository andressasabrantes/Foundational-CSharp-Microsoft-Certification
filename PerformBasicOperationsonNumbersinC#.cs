int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
//OUTPUT:19


string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
//OUTPUT: Bob sold 7 widgets.


string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
//OUTPUT: Bob sold 77 widgets.


string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
//OUTPUT: Bob sold 14 widgets.


int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
//OUTPUT:
/* 
Sum: 12
Difference: 2
Product: 35
Quotient: 1 
*/


decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
//OUTPUT: Decimal quotient: 1.4


int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
//OUTPUT: 1.4


Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
//OUTPUT: 
/* 
Modulus of 200 / 5 : 0
Modulus of 7 / 5 : 2 
*/


int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
//OUTPUT:
/* 
23
35 
*/


int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.



int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
//OUTPUT:
/* 
First increment: 2
Second increment: 3
Third increment: 4
First decrement: 3
Second decrement: 2
Third decrement: 1
 */


 //DESAFIO: TRANSFORMAR EM CELSIUS A TEMPERATURA QUE ESTÁ EM FAHRENHEIT
int fahrenheit = 94;

decimal celsius = (fahrenheit - 32m) * 5/9m;

Console.WriteLine($"The temperature is {celsius} Celsius.");
//OUTPUT: The temperature is 34.444444444444444444444444444 Celsius.
