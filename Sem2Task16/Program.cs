// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.



//bool res1 = (num1/num2 == num2);
//bool res2 = (num2/num1 == num1);
//if (res1) Console.WriteLine("А квадрат Б");
//if (res2) Console.WriteLine("Б квадрат А");
//all(!res2&&!res1) Console.WriteLine("Ни первое, ни второе не является квадратом");


void TestS(int i, int j)
{
    bool res = (i/j ==j);
    if(res==true)Console.WriteLine(" Число "+i+" является квадратом числа "+j);
    else Console.WriteLine(" Число "+i+" не является квадратом числа "+j);
}

int num1 = int.Parse(Console.ReadLine()??"0");  // ??"0" - проверка на 0
int num2 = int.Parse(Console.ReadLine()??"0"); 

TestS(num1,num2);
TestS(num2,num1);
