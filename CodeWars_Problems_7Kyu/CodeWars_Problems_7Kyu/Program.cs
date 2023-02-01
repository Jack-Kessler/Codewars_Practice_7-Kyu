//Sum of Integers in String
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

