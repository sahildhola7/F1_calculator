int num1;
int num2;
string function;
bool keep = true;


//===============================================================================================//

Console.WriteLine("welcome to my calculator....., how can i help you.....");
Console.WriteLine("'a' for addition, 's' for subtration, 'm' for multipation, 'd' for divsion, 'q' for exit");
function = Console.ReadLine();

//===============================================================================================//

// This is my first ever project in c# it is just a simple calculator......

//===============================================================================================//
while(keep){

Console.WriteLine("Enter you num1");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter you num2");
num2 = int.Parse(Console.ReadLine());


if (function =="a"){
    Console.WriteLine(num1 + num2);
}

else if (function == "s"){
    Console.WriteLine(num1 - num2);
}

else if (function == "m"){
        Console.WriteLine(num1 * num2);
}

else if (function == "d"){
    if (num2 == 0 ){
        Console.WriteLine("invalid operation");
    }
        Console.WriteLine(num1 / num2);
}

else{
    Console.WriteLine("please enter the valid finction");
}

Console.WriteLine("do you want to continue... y/n");
string choice = Console.ReadLine();
if (choice != "y") {
    break;
}
else{
    continue;
}
}
//================================================END OF MY FIRST PROJECT========================================================//








