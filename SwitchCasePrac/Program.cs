//*Exercise2*\\

Console.Write("Hi! What's your favorite subject? ");
var favSubject = Console.ReadLine();

switch (favSubject)
{
    case "PE":
        Console.WriteLine("I love PE!");
        break ;
    case "Psychology":
        Console.WriteLine("I love Psychology!");
        break ;
    case "Math":
        Console.WriteLine("I didnt think anyone liked math. Weirdo.");
        break;
    case "Biology":
        Console.WriteLine("Biology is fantastic!");
        break;
    case "Computer lab":
        Console.WriteLine("That is my Favorite subject too!");
        break; 
        default:
        Console.WriteLine("Never heard of that");
        break;
        

}
