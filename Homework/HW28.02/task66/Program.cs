// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// ----------------------
Console.Write("M =  ");
int M = int.Parse(Console.ReadLine());
Console.Write("N =  ");
int N = int.Parse(Console.ReadLine());
Console.Write($"сумма от {M} до {N} -> {SumNaturalNums(M, N)}");

// ----------------
int SumNaturalNums(int M, int N)
{
    if (M == N) return M - N;
    else if (M < N)
    {
        return M + SumNaturalNums(M + 1, N) + N;
    }

    else if (M > N)
    {
        return N + SumNaturalNums(M, N + 1) + M;
    }
    return SumNaturalNums(M, N);

}

// -------------------
// int SumNaturalNums(int M, int N)
// {
//     if (M == N)
//     {
//         return M - N;
//     }
//     else
//     {
//         int siz = M - N + 1;
// 
//             int[] arr = new int[siz];
//             arr[0] = M;
//             int sum = 0;
//             for (int i = 1; i < siz ; i++)
//             {
//                 arr[i] = M + 1;
//                 sum = sum + arr[i];
//             }
//             Console.WriteLine(sum+M);


//   

//     }
//     return SumNaturalNums(M, N);
// }
// //             while (M <= N)
// //             {
// //                 int  = 0;
// //                 int[] arr = new int[];
// //                 for (int i = 0; i < arr.Length; i++)
// //                 {

// //                 }
// //             }
// //         }
// //     }
// // }