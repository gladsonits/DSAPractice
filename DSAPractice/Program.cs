// See https://aka.ms/new-console-template for more information
using DSAPractice;

Console.WriteLine("Hello, World!");

int[] array = new int[3];
array[0] = 1;
array[1] = 2;
array[2] = 3;


Array.ForEach(array, Console.WriteLine);


//LinkedList linkedList = new LinkedList();

//Console.WriteLine($"is it empty?{linkedList.Empty}");
//Console.WriteLine($"Count- ${linkedList.Count}");

DefaultLinkedList defaultLinkedList = new DefaultLinkedList();
defaultLinkedList.DoOperations();

Console.ReadKey();




