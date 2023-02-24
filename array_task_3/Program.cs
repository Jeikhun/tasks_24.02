
////task2
//Console.Write("Eded daxil edin: ");
//int number = int.Parse((Console.ReadLine()));
//if (number >= 91 && number <= 100)
//{
//    Console.WriteLine("A");
//}
//else if (number >= 81 && number < 91)
//{
//    Console.WriteLine("B");
//}
//else if (number >= 71 && number < 81)
//{
//    Console.WriteLine("C");
//}
//else if (number >= 61 && number < 71)
//{
//    Console.WriteLine("D");
//}
//else if (number >= 51 && number < 61)
//{
//    Console.WriteLine("E");
//}
//else if (number < 51)
//{
//    Console.WriteLine("Get, 25%-de gelersen ))");
//}
//else
//{
//    Console.WriteLine("Yanlish daxil etmisiniz");
//}



//int[] arr1 = { 3, 5, -9, -17, 67 };
//int positivecount = 0;
//int negativecount = 0;
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] > 0)
//    {
//        positivecount++;
//    }
//    else if (arr1[i] < 0)
//    {
//        negativecount++;
//    }
//}
//Console.WriteLine( "Musbet ededler " + positivecount + "denedir");
//Console.WriteLine("Menfi ededler " + negativecount + "denedir");



int[] arr1 = { 4, 67, 34, 1, 4 };
int maxnum = arr1[0]; 
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] > maxnum)
    {
        maxnum = arr1[i];
    }
}
Console.WriteLine("En boyuk eded "+ maxnum + "dir");
