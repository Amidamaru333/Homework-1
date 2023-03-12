//Первая задача 
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Write(" Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a>b){
//     Console.WriteLine("max = " + Convert.ToString(a));
// }else{
//     Console.WriteLine("max = " + Convert.ToString(b));
// }

//Вторая задача
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// int max=0;
// for (int i = 0; i < 3; i++){
//     int user = Convert.ToInt32(Console.ReadLine());
//     if (i == 0 || user > max){
//         max = user;
//     }
// } 
// Console.WriteLine(Convert.ToString(max));

//Третья задача
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).
// Console.Write(" Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number%2 == 0){
//     Console.WriteLine("Да");
// }else{
//     Console.WriteLine("Нет");
// }

//Четвёртая задача
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string output = "";
if (number >= 0){
    for (int i = 0; i <= number; i+=2){
        output += i + ", ";
    }
}else{
    for (int i = 0; i >= number; i-=2){
        output += i + ", ";
    }
}
if (number>-2 && number<2){
    Console.WriteLine(" ");
}else{
    Console.WriteLine((output.Remove(output.Length - 2)).Remove(0,3));
}