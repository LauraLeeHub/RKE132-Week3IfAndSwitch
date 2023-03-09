

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris voi paaritu

int result = userNum % 2;

Console.WriteLine(result);

if (result != 0) //!+ - ei ole v]rdne
{
    Console.WriteLine("Users number is odd.");
}
else 
{
    Console.WriteLine("Users number is even.");
}
