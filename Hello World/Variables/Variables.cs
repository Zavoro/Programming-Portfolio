

//to create a new variable, you must first declare the data type and then give it a name

//VARIABLE NAME RULES
//variable names must begin with a letter or an underscore, not a number
//variable names are case-sensitive - string Value; and string value; are two different variables
//variable names must not be a C# keyword - such as int, string, class, public, etc.


//CAMEL CASE
//camel case is a style of writing where
//the first letter of the first word is lowercase
//and the first letter of each subsequent word is uppercase

//VARIABLE CODING CONVENTIONS
//camel case
//names should be descriptive and meaningful
//names should be one or more entire words

//EXAMPLES OF VARIABLE DECLARATIONS
//string firstName;
//char userOption;
//int gameScore;
//decimal particlesPerMillion;
//bool processedCustomer;

//RECAP
//variables are temporary values stored in the computer's memory while a program is running
//before you can use a variable you must declare it
//to declare a variable, select the data type and name it


//SETTING AND GETTING VALUES FROM VARIABLES

//EXAMPLE VARIABLE DECLARATION AND VALUE ASSIGNMENT
//string firstName;
//firstName = "Bob";

//RETRIEVE A VALUE STORED IN VARIABLE/ get operation
//Console.WriteLine(firstName);

//REASSIGNING THE VALUE OF A VARIABLE
//the value of a variable can be reassigned as many times as you need
//EXAMPLE OF REASSIGNING THE VALUE OF A VARIABLE
//string firstName;
//firstName = "Bob";
//Console.WriteLine(firstName);
//firstName = "Liem";
//Console.WriteLine(firstName);
//firstName = "Isabella";
//Console.WriteLine(firstName);
//firstName = "Yasmin";
//Console.WriteLine(firstName);


//INITIALIZING THE VARIABLE
//here we declare the variable and assign a value in one line of code
//string firstName = "bob";


//IMPLICITLY TYPED VARIABLES
//a variable created using the var keyword
//the var keyword tells the C# compiler that the data type is implied by the assigned value
//after the type is implied the variable acts as if the data type was declared
//the var keyword is used to save on keystrokes when types are lengthy or when the type is obvious
//var must be intialized, if you try to use var without initializing, you'll receive an error
//EXAMPLE IMPLICITLY TYPED VARIABLE
//var message = "Hello World!";

//FIRST ATTEMPT
//string firstName = "Bob";
//decimal number1 = 3;
//double number2 = 34.4;
//Console.WriteLine("Hello,", firstName, "! You have ", number1, " messages in your inbox. The temperature is", number2, " celsius.");

//SOLUTION
//string name = "Bob";
//int messages = 3;
//decimal temperature = 34.4m;

//Console.Write("Hello, ");
//Console.Write(name);
//Console.Write("! You have ");
//Console.Write(messages);
//Console.Write(" messages in your inbox. The temperature is ");
//Console.Write(temperature);
//Console.Write(" celsius.");




