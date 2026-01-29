Console.WriteLine("Please enter yourn membership type - gold, silver, or guest:");
string membership = Console.ReadLine();

if (membership == "Gold")
{
    Console.WriteLine("Welcome, Gold Member !");
}
else if (membership == "Silver")
{
    Console.WriteLine("Welcome, Silver Member !");
}

else
{
    Console.WriteLine("Welcome, Guest !");
}

//using terney operatior to handle mutiple conditons
string message = membership == "Gold" ? "Welcome, Gold Member !" :
                 membership == "Silver" ? "Welcome, Silver Member !" :
                 "Welcome Guest!";

Console.WriteLine(message);

double dicount = membership == "Gold" ? 0.20 :
                  membership == "Silver" ? 0.10 :
                  0.0;

Console.WriteLine($"Your discount rate : {dicount:P2}");

double pre_discount_price = 100.0;
double final_price = pre_discount_price * (1 - dicount);
Console.WriteLine($"Your final price is: {final_price:F2}");

