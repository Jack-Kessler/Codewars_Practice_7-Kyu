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

//return xs.OrderBy(x => x).TakeLast(n).ToList();

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

