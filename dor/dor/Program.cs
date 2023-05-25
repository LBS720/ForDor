using System.Collections;

//loops:
//for 
//foreach
//while

//array
//list
//dict


string[] array1 = new string[5]; // 5 is the amount
// 0, 1, 2, 3, 4 - index
//insert value to array:
array1[0] = "dor";
array1[1] = "linoy";
// ...

//[0, 1, 2, 3, 4]
//[4, 3, 2, 1, 0]
int[] sarray = new int[5];

for (int index = 4; index <= 0; index--)
{
    sarray[index] = index;
}

//10*10

//x*y
// [i, j] - [0,0], [0,1], [1,0]

for (int i = 1; i <= 10; i++) //x
{
    Console.WriteLine(" * ");
    for (int J = 1; J <= 10; J++) // y
    {
        Console.Write(" * ");
    }
}

Console.ReadLine();







































