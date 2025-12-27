//-------------------------------------STRING FORMATTING----------------------------------------------

//Suppose you want to display the output of a command-line application you're writing.
//You want to display values including
//literal text, text in variables, numeric data, and textual data in other languages.
//How would you format it correctly so that the user can understand
//what your application is communicating to them?


//--------------------------------CHARACTER ESCAPE SEQUENCES------------------------------------------
//an escape character sequence is an instruciton to the runtime to insert a special character
// the escape character sequence begins with a backslash followed by the character you're escaping
//for example
//  \n will add a new line.
//  \t will add a tab space
//  \" will add a quotation mark
//  \\ will add a single backslash
//EXAMPLES OF CHARACTER ESCAPE
//Console.WriteLine("Hello\nWorld!");
//Console.WriteLine("Hello\tWorld!");
//Console.WriteLine("Hello \"World\"!");
//Console.WriteLine("c:\\source\\repos");

//USAGE OF CHARACTER ESCAPE SEQUENCES

//this line uses \" twice to encapsulate contoso corp in quotation marks
//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");

//this line uses \t twice to add two tab spaces
//Console.WriteLine("Invoice: 1021\t\tComplete!");

//this line uses \t twice to add two tab spaces
//Console.WriteLine("Invoice: 1022\t\tComplete!");

//this line uses \n to add a new line and \t to add a tab space
//Console.Write("\nOutput Directory:\t");

//----------------------------------VERBATIM STRING LITERAL-------------------------------------------
//a verbatim string literal will keep all whitespace and characters without
//the need to escape the backslash
//to create a verbatim string, use the @ directive before the literal string
//Console.WriteLine(@"    c:\source\repos
//      (this is where your code goes)");
//Console.Write(@"c:\invoices");


//UNICODE ESCAPE CHARACTERS
//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");


//----------------------------------STRING CONCATENATION----------------------------------------------
//used to combine two or more string values into a new string value
//string concatenation operator is +

//example of string concatenation, here we use + firstName to combine "Hello " + firstName
//string firstName = "Bob";
//string message = "Hello " + firstName;
//Console.WriteLine(message);

//example of several string concatenation operations in the same line of code
//string firstName = "Bob";
//string greeting = "Hello";
//string message = greeting + " " + firstName + "!";
//Console.WriteLine(message);
//you should avoid using intermediate variables by performing the concatenation operation as you need it

//example of avoiding use of intermediate variables, notice there is no message variable
//string firstName = "Bob";
//string greeting = "Hello";
//Console.WriteLine(greeting + " " + firstName + "!");

//--------------------------COMBINE STRINGS USING STRING INTERPOLATION--------------------------------
//string interpolation combines multiple values into a single literal string by using
//a template and one or more interpolation expressions,
//an interpolation expression is indicated by an opening and closing curly brace symbol {}
//the literal string becomes a template when it's prefixed by the $ character

//instead of writing this code
//string message = greeting + " " + firstName + "!";
//write this instead
//string message = $"{greeting} {firstName}";

//USE STRING INTERPOLATION TO COMBINE A LITERAL STRING AND A VARIABLE VALUE
//string firstName = "Bob";
//string message = $"Hello {firstName}!";
//Console.WriteLine(message);

//USE STRING INTERPOLATION WITH MULTIPLE VARIABLES AND LITERAL STRINGS
//int version = 11;
//string updateText = "Update to Windows";
//string message = $"{updateText} {version}";
//Console.WriteLine(message);

//COMBINE VERBATIM LITERALS AND STRING INTERPOLATION
//string projectName = "First-Project";
//Console.WriteLine($@"C:\Output\{projectName}\Data");

