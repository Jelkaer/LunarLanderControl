Console.WriteLine("Please enter userId in numbers");

uint userId =uint.Parse(Console.ReadLine());
bool userIsAdmin;
if (userId < 65536)
    userIsAdmin = false;
else userIsAdmin = true;
Console.WriteLine($"Admin: {userIsAdmin}");

Console.WriteLine("Please enter username");


var username = Console.ReadLine();
while (username.Length < 3)
{
    Console.WriteLine("Username is too short. Try again");
     username = Console.ReadLine();
}

List<string> sl =["@", "$", "|"];
Console.WriteLine("Please enter password");
var password = Console.ReadLine();
while (!sl.Any(s => password.Contains(s)))
{
    Console.WriteLine("Password needs to contain @, $ or |. Try again");
    password=Console.ReadLine();
}

int rl = userIsAdmin ? 20 : 16;

while (password.Length!<=rl)
{
    Console.WriteLine($"Password needs to be at least {rl} characters long");
    password = Console.ReadLine();
}


    Console.WriteLine("Access granted");
var welcome = $"Welcome user {username}, userid {userId} ";
Console.WriteLine(welcome);
return;
