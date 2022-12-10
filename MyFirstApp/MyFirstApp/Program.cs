using System;
public class Nazib
{
    
    public static void Main()
    {
        int[] nums = { 2, 7, 11, 9 };
        int targetNumber = 9;

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] + nums[i+1] == targetNumber)
            {
                Console.WriteLine("[" + i + "," + (i+1) + "]");
                break;
            }
        }
    }

    
}

