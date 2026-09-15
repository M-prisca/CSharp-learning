string firstFriend= "Prisca";
string secondFriend= "Jean";
//Console.WriteLine($"My friends are {firstFriend} and {secondFriend} and {firstFriend} has {firstFriend.Length} characters.");


// remove whitespace from a string
string greeting= "             Hello world!             ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");