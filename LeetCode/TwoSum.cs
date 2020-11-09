using System.Collections.Generic;

public class TwoSum
{
    // int[] nums = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
    // var target = 542;

    public int[] OnePassHash(int[] nums, int target)
    {
        var hashNums = new Dictionary<int, int>(nums.Length);
        var differenceOf = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            differenceOf = target - nums[i];

            if (hashNums.ContainsKey(differenceOf))
                return new int[] { hashNums[differenceOf], i };

            // if (!hashNums.ContainsKey(nums[i]))
            //     hashNums.Add(nums[i], i);
            hashNums[nums[i]] = i;
        }

        return new int[] { };
    }

    public int[] TwoPassHash(int[] nums, int target)
    {
        var hashNums = new Dictionary<int, int>(nums.Length);

        for (var i = 0; i < nums.Length; i++)
        {
            if (!hashNums.ContainsKey(nums[i]))
                hashNums.Add(nums[i], i);
        }

        var differenceOf = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            differenceOf = target - nums[i];

            if (hashNums.ContainsKey(differenceOf) && i < hashNums[differenceOf])
                return new int[] { i, hashNums[differenceOf] };
        }

        return new int[] { };
    }

    public int[] DifferenceOf(int[] nums, int target)
    {
        var differenceOf = 0;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            differenceOf = target - nums[i];

            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == differenceOf)
                    return new int[] { i, j };
            }
        }

        return new int[] { };
    }
    
    public int[] BruteForce(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }

        return new int[] { };
    }
}
