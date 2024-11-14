int num1;
int num2;
int result;
string function;
bool keep = true;


//===============================================================================================//

Console.WriteLine("welcome to my calculator....., how can i help you.....");
Console.WriteLine("'a' for addition, 's' for subtration, 'm' for multipation, 'd' for divsion");
function = Console.ReadLine();

//===============================================================================================//

Console.WriteLine("Enter you num1");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter you num2");
num2 = int.Parse(Console.ReadLine());

//===============================================================================================//
while(keep){
if (function =="A"){
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

else {
    Console.WriteLine("please enter the valid finction");
}
Console.WriteLine("want to continue y/n");
string choice = Console.ReadLine();
if (choice.ToLower() != "y"){
    keep = false;
}

}




