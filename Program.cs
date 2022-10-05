using MyLibrary;

void Task41(){
    /*Задача 41: Пользователь вводит с клавиатуры M чисел. 
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3*/
    int M = new Random().Next(1,10);
    int count = 0;
    int[] array = new int[M];
    Console.WriteLine(M);
    for (int i = 0; i < M; i++)
    {
        int x = library.MyReadCons();//Выводит в консоль фразу "введи число" считывает введеное и сохр в перемен.
        if (x > 0) count++;
        array[i] = x;
    }
    Console.WriteLine("кол-во введенных цифр больше нуля " + count);

    library.MyLookArray(array);// выводим в консоль поочередно каждый элемент массива

}
//Task41();
void Task43(){
/*
    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) не правильный пример(-2,1)
    y =5x+2 & y = 9x+4 */
   
    double k1 = library.MyReadCons("введи k1");
    double b1 = library.MyReadCons("введи b1");

    double k2 = library.MyReadCons("введи k2");
    double b2 = library.MyReadCons("введи b2");

    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"точка А пересечения 2 прямых имеет координаты А({x},{y})");
}
//Task43();

