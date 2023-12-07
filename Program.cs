string[] UserWant(string message)
{
    Console.Write(message);
    int N = Convert.ToInt32(Console.ReadLine());

    string [] array = new string [N];
    Console.Write($"Введите {N} элементов массива:");
    for(int i=0; i < N; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void Print_Array(string[] array)
{
    Console.Write("Исходный массив:");

        for(int i=0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

         Console.WriteLine();
}

string[] New_Array(string[] array)
{
    //string [] new_array = new string [] {};
    List<string> new_arr = new List<string>  {};
   // int count = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            //new_array[count] = array[i];
            //count =+ 1;
            new_arr.Add(array[i]);
        }
    }
    string [] new_array = new_arr.ToArray<string>();
    return new_array;
}

void Print_newArray(string[] array)
{
    Console.Write("Новый массив:");

    if (array.Length == 0)
    {
        Console.Write("новый массив пуст");
    }
    else{
        for(int i=0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}

 string[] UserWrite = UserWant("Введите длину массива:");
 Print_Array(UserWrite);
 string[] Array_forPrint =  New_Array(UserWrite);
Print_newArray(Array_forPrint);



