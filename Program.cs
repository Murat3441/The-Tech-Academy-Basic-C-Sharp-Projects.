// Welcome Message
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
Console.WriteLine("Please enter the weight of the package.");
// weight input from user
int weight = Convert.ToInt32(Console.ReadLine());
// show weight
Console.WriteLine(" Package weight: " + weight);
// is weight smaller than 50?
if (weight < 50)
{
    // ask for input
    Console.WriteLine("Please enter the width of the package.");
    // width input from user
    int width = Convert.ToInt32(Console.ReadLine());
    // show input
    Console.WriteLine(" Package width: " + width);

    // ask for input
    Console.WriteLine("Please enter the height of the package.");
    // height input from user
    int height = Convert.ToInt32(Console.ReadLine());
    // show input
    Console.WriteLine(" Package height: " + height);

    // ask for input
    Console.WriteLine("Please enter the length of the package.");
    // length input from user
    int length = Convert.ToInt32(Console.ReadLine());
    // show input
    Console.WriteLine(" Package length: " + length);
    // is width + height + length smaller than 50? 
    if ((width + height + length) < 50)
    {
        //calculate price
        float total = ((height * width * length) * weight) / 100;
        //show price 
        Console.WriteLine("Your estimated total for shipping this package is: $" +  total);
        Console.WriteLine("Thank you!");
    }
    // if width + height + length greater than 50 
    Console.WriteLine("Package too big to be shipped via Package Express.");
}
else
{
    // if weight greater than 50

    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
}
