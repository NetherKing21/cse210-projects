using System;
class Result
{

    /*
     * Complete the 'compute_jumps' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int compute_jumps(int n)
    {
        // Implement code here
        
        int[] allInputs = allPossibleInputs(n);
        int[] numJumps = {};
        foreach(int input in allInputs)
        {
            int jumpNum = 0;
            int distance = input;
            while(distance > 1)
            {
               if(isEven(n))
               {
                   jumpNum++;
                   distance = input/2;
               }
                else
                {
                    jumpNum++;
                    distance = (input*3)+1;
                }
            }
            numJumps.Append(jumpNum);
        }
        int maxJumps = numJumps.Max();
        return maxJumps;
    }
    
    public static bool isEven(int n)
    {
        int num = n % 2;
        if (num == 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    public static int[] allPossibleInputs(int n)
    {
        int[] all = {};
        while(n > 1)
        {
            all.Append(n);
            n--;
        }
        return all;
    }

//    public static void Main()
//    {
//        Console.WriteLine(compute_jumps(10));
//    }

}