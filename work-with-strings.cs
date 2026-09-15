string firstFriend= "Prisca";
string secondFriend= "Jean";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend} and {firstFriend} has {firstFriend.Length} characters.");


// remove whitespace from a string
string greeting= "             Hello world!             ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// replace a substring in a string
string sayHello= "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
Console.WriteLine(sayHello.Contains("Greetings"));
Console.WriteLine(string.Join(", ", sayHello.Split(" ")));


string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.EndsWith("goodbye"));
Console.WriteLine(songLyrics.StartsWith("You"));