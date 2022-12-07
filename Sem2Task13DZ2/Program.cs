// // Напишите программу, которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет.
// через логарифм:

// вводим число
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");

// делаем цикл, если в числе минимум три цифры

if(number> 99)
{
    //Находим количество цифр в числе (или можно сделать циклом while,делить number/10. считчик в цикле ++)
    int lenght = (int)Math.Log10(number) + 1;

    int index = 0;
    int thirdDigit = number;

    //делаем деление числа на 10 (length-3)раз, чтобы осталось три цифры в числе
    while(index < lenght-3)
    {
        thirdDigit = thirdDigit/ 10;
        index++;
    }
    // Находим третью цифру остатком от деления на 10
    thirdDigit = thirdDigit % 10;
    //выводим третье число
    Console.WriteLine(thirdDigit + " Является третьей цифрой числа " + number);

}
else
{

}
