using System;
class program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        Swap(ref num1, ref num2);
        Console.WriteLine("num 1:{0}, and num 2 :{2}",num1,num2);
          }
    static void Swap(ref int x, ref int y) {
        int temp = x;
        x = y;
            y = temp;
    }
}