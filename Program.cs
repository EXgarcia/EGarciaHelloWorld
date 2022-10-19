//Elizar Garcia
///10/17/22
//MiniChallenge #1 "what is your name?"
//This program will prompt the user to enter their name.

Console.Clear();

bool input = true;
int i = 0;
string digits = "1234567890";
string specialChar = "~!@#$%^&*()-_',./<>";
string myName ="";

string talkAgain = "YES";

while(talkAgain == "YES")
{
    Console.WriteLine("...You..what is your name??");
     myName = Console.ReadLine();
    input =Int32.TryParse(myName, out i);
    if(myName.IndexOfAny(digits.ToCharArray()) != -1 || myName.IndexOfAny(specialChar.ToCharArray()) != -1)
    {Console.WriteLine("Please try again.");

    }else{Console.WriteLine($"Im not sure if I know you {myName}...wait..");

    }

    Console.WriteLine("Converse again?");
    Console.WriteLine("Type YES to continue or NO to stop.");

     talkAgain = Console.ReadLine().ToUpper();

if(talkAgain == "NO")
    {
        Console.WriteLine("Very well then...");
    }
}
