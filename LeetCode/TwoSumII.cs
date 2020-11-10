public class TwoSumII
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var startIndex = 0;
        var endIndex = numbers.Length - 1;
        var sum = 0;
        
        while (startIndex < endIndex)
        {
            sum = numbers[startIndex] + numbers[endIndex];
            
            if (sum == target)
                return new int[] {startIndex + 1, endIndex + 1};
            
            if (sum > target)
                endIndex--;
            else
                startIndex++;    // if (sum < target)
        }

        return new int[] { };
    }
}
