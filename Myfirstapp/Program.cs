// This is a comment to my code

//rakendus küsib kasutajalt sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name"); //outpu
//string - sõne
string userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output

//string interpolation
Console.WriteLine($"Hello, {userName} !"); //Output

firstName = "Harry";
lastname = "Potter";
Console.WriteLine($"Hello, {firstName} lastName!")