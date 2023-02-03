//Cats and Shelves (7-Kyu)

//int start = 2;
//int finish = 5;
//int diffStartFinish = finish - start;
//int bigJump = 3;
//int remainder = 0;
//int quot = Math.DivRem(diffStartFinish, bigJump, out remainder);
//int totalJumps = quot + remainder;

//Console.WriteLine(totalJumps);

//return totalJumps;

//-----------------------------------------------------------------------------------------------------------------------------
//Sudoku board validator (6-Kyu)
//using System.Collections.Concurrent;
//using System.Reflection.Metadata.Ecma335;

//int[][] board = {
//            new[]{8,4,7,2,6,5,1,0,3},
//            new[]{1,3,6,7,0,8,2,4,5},
//            new[]{0,5,2,1,4,3,8,6,7},
//            new[]{4,2,0,6,7,1,5,3,8},
//            new[]{6,7,8,5,3,2,0,1,4},
//            new[]{3,1,5,4,8,0,7,2,6},
//            new[]{5,6,4,0,1,7,3,8,2},
//            new[]{7,8,1,3,2,4,6,5,0},
//            new[]{2,0,3,8,5,6,4,7,1}
//                };

//int x = 9; //full row / column length
//int y = 3; // length of sub-cube

//int g = 0;
//int h = 0;
//int i = 0;
//int j = 0;

//bool finalResult = true;

//for (g = 0; g < x; g++) // Check for zeros
//{
//    for (h = 0; h < x; h++)
//    {
//        finalResult = (board[g][h] == 0) ? false : true;
//        if (finalResult == false)
//        {
//            Console.WriteLine(finalResult);
//            return finalResult;
//        }
//    }
//}

        // Checks all horizontal
        //for (g = 0; g < x; g++) // h tells us which array we are in (vertical)
        //{
        //    for (h = 0; h < x; h++) // i tells us which position in array #h we are looking at
        //    {
        //        for (i = h + 1; i < x; i++) // j is used for comparison purposes
        //        {
        //            if (board[g][h] == board[g][i])
        //            {
        //                Console.WriteLine("Duplicate");
        //                finalResult = false;
        //            }
        //        }

        //    }
        //}

        //// checks all vertical
        //for (g = 0; g < x; g++) // h tells us which array we are in (vertical)
        //{
        //    for (h = 0; h < x; h++) // i tells us which position in array #h we are looking at
        //    {
        //        for (i = h + 1; i < x; i++) // j is used for comparison purposes
        //        {
        //            if (board[h][g] == board[i][g])
        //            {
        //                Console.WriteLine("Duplicate");
        //                finalResult = false;
        //            }
        //        }
        //    }
        //}

// check's each sub-cube of 9

//for (int f = 0; f < y; f++)
//{
//    for (g = 0; g < y; g++) // h tells us which array we are in (vertical)
//    {
//        for (h = 0; h < y; h++)
//        {
//            for (i = 0; i < y; i++) // i tells us which position in array #h we are looking at
//            {
//                for (j = i + 1; j < y; j++) // j is used for comparison purposes
//                {
//                    if (g == i && h == j)
//                    {
//                        continue;
//                    }
//                    else if (board[g + (3*f)][h + (3*f)] == board[i + (3*f)][j + (3*f)])
//                    {
//                          Console.WriteLine("Duplicate");
//                        finalResult = false;
//                    }
//                }
//            }
//        }
//    }
//}
//Console.WriteLine(finalResult);
//return finalResult;

//-----------------------------------------------------------------------------------------------------------------------------

//Covfefe (7-Kyu)
//string tweet = "Hello World";
//string checkWord = "coverage";
//string replace = "covfefe";

//Boolean result = tweet.Contains(checkWord);

//string finalResult = (result == true) ? tweet.Replace(checkWord, replace) : tweet + " " + replace; // short-hand

//if (result == true) // Long hand if/else statements
//{
//    finalResult = tweet.Replace(checkWord, replace);
//}
//else
//{
//    finalResult = tweet + " " + replace;
//}

//Console.WriteLine(finalResult);

//return finalResult;

//---------------------------------
//int x = 49;
//int y = 10;
//var z = x / y;
//Console.WriteLine(z);
//if (z.GetType() == typeof(int))
//{
//    Console.WriteLine("z has int type");
//}




//-----------------------------------------------------------------------------------------------------------------------------

//Largest Elements (7-Kyu)

//using System.Collections.Generic;

//int n = 2;

//List<int> xs = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }; // Fast Method

//List<int> exampleNumbers = new List<int>(); // Slow Method
//xs.Add(10);
//xs.Add(9);
//xs.Add(8);
//xs.Add(7);
//xs.Add(6);
//xs.Add(5);
//xs.Add(4);
//xs.Add(3);
//xs.Add(2);
//xs.Add(1);

//List<int> finalList = new List<int>();

//for (int w = 1; w <= n; w++)
//{
//    int s = xs.Max();
//    finalList.Add(s);
//    xs.Remove(s);
//}
//finalList.Reverse();

//foreach (int i in finalList) // for VS
//{
//    Console.WriteLine(i);
//}

//return List; for codewars

//return xs.OrderBy(x => x).TakeLast(n).ToList(); // Sample solution on codewars

//-----------------------------------------------------------------------------------------------------------------------------

//Sum of Integers in String (7-Kyu)
//using System.Linq.Expressions;

//string s = "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog";
//bool[] myBoolArray = new bool[s.Length + 1];
//int[] arrayForSum = new int[s.Length]; //Declare integer array of length equal to the length of string s

//int r = 0;

//foreach (bool i in myBoolArray)
//{
//    myBoolArray[r] = false;
//    r++;
//}

//r = 0;              //Used as a counter for each element through the whole array
//foreach (char i in s)   //Remember: i is a char type
//{
//    if (char.IsNumber(i) == true) //Checking to see if each element in the string is a number or not
//    {
//        myBoolArray[r] = true;
//    }
//    r++;
//}

//r = 0; //reset r to 0.
//string masterTempStr = "";      //Declare and initialize string
//foreach (bool i in myBoolArray)
//{
//    if (i == true && r < myBoolArray.Length && myBoolArray[r+1] == true)
//    {
//        masterTempStr = masterTempStr + s[r];
//    }
//    else if (i == true && r == myBoolArray.Length) //last element case
//    {
//        masterTempStr = masterTempStr + s[r];
//        int fullNumber = Convert.ToInt32(masterTempStr);
//        arrayForSum[r] = fullNumber;
//        masterTempStr = "";
//    }
//    else if (i == true)
//    {
//        masterTempStr = masterTempStr + s[r];
//        int fullNumber = Convert.ToInt32(masterTempStr);
//        arrayForSum[r] = fullNumber;
//        masterTempStr = "";
//    }
//    r++;
//}


//int sumTotal = 0;
//foreach (int i in arrayForSum)
//{
//    sumTotal = sumTotal + i;
//}

//Console.WriteLine(sumTotal);
//return sumTotal;

//-----------------------------------------------------------------------------------------------------------------------------

