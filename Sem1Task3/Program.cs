//Необходимо по введенному числу выдать день  недели

string? inputLine = Console.ReadLine(); //считываем данные с консоли. Вопрос значит, что мы проверим на null, но ниже.

if(inputLine!=null) //создаем массив
{
string[] dayWeek = new string[7];
dayWeek[0] = "Понедельник";
dayWeek[1] = "Вторник";
dayWeek[2] = "Среда";
dayWeek[3] = "Четверг";
dayWeek[4] = "Пятница";
dayWeek[5] = "Суббота";
dayWeek[6] = "Воскресенье";

int inputNumber = int.Parse(inputLine); //получаем действительное значение числа

string outDayOfWeek = dayWeek[inputNumber-1]; //находим название дня недели по введенному номеру

Console.WriteLine(outDayOfWeek); //Выводим данные в консоль

}

