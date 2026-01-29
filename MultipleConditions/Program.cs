Console.WriteLine("PLease enter membership type - Gold, Silver, or Guest:")

    if (membership == "Gold")
{
    Console.WriteLine("Welcome, Gold Member!")
}
    else if (membership == "Silver")
{
    Console.WriteLine("Welcome, Silver Member!")
}
else (membership == "Guest")
        {
    Console.WriteLine("Welcome, Guest!")
}

string message = membership = "Gold" ? "Welcome, Gold Member!":
                membership = "silver" ? "Welxome, Silver memeber":
                membership = "guest" ? "welcome, guest!";

double discount == membership == "Gold" ? 0.20 :
                    membership =="Silver" ? 0.10 :
                    0.0;
Console.WriteLine($"Your discount rate: {discount:P2}");

double pre_discount_rate = 100.0
double_final_price = pre_discount_rate* (1-discount);
Console.WriteLine($"The final price is : {final_price:F2}")