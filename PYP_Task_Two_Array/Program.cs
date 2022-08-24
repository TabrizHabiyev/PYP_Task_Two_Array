
#region Task 1 
//string[] arr = {"a","b"};
//Console.WriteLine(Array.Exists(arr, x => arr.Count(y => y == x) > 1));
#endregion

#region Task 2 
//int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,10};
//int n = arr2.Length;
//int x = int.Parse(Console.ReadLine());
//int result = Array.BinarySearch(arr2, x);
//if (result < 0)
//{
//    Console.WriteLine("Element not found");
//}
//else
//{
//    Console.WriteLine("Element found");
//}
#endregion

#region Task 3 
//int[] arr3 = {1,2,3,4,};
//void WriteArray(int[] arr, int i = 0)
//{

//    if (arr.Length != i)
//    {
//        Console.WriteLine(arr3[i]);
//        i++;
//        WriteArray(arr, i);
//    }
//}
//WriteArray(arr3);
#endregion

#region Task 4
//string[] arr4 = { "example1", "example2", "example3", "example4" , "no" , "output"};
//string find = Console.ReadLine();
//Array.FindAll(arr4, e => e.StartsWith(find)).ToList().ForEach(n => Console.WriteLine(n));
#endregion

#region Task 5
int[] array_1 = { 1, 2, 3, 4, 6, 8, 11, 12 };
int[] array_2= { 1, 2, 3, 5, 6, 7, 8, 9 };
array_1.ToList().ForEach(x => Console.WriteLine(x));
array_2.ToList().ForEach(x => Console.WriteLine(x));
#endregion

#region Task 6
int[] array1 = {1,2,3,4,6,8,11,12};
int[] array2 = {1,2,3,5,6,7,8,9};

int[] same = Array.FindAll(array2, x => Array.Exists(array1,y => y == x));

int[] different = Array.FindAll(array2, x => !Array.Exists(array1, y => y == x));

same.ToList().ForEach(x => Console.WriteLine($"Same element {x}"));
different.ToList().ForEach(x => Console.WriteLine($"Diffrent element {x}"));
#endregion

