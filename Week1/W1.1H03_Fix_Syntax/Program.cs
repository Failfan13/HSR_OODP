/*
int discount = 0.1;
int price = 55;
int discountPrice = price * discount;

var message;
message = $"The discount price is {discountPrice}";
Console.WriteLine(discountPrice)
*/


double discount = 0.1;
int price = 55;
double discountPrice = price - price * discount;

var message = "";
message = $"The discount price is {discountPrice}";
Console.WriteLine(message);
