namespace LeetCode.array_and_string;

public class MergeSortedArray_88
{
    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var p1 = m - 1;
        var p2 = n - 1;
        var p = m + n - 1;

        // While there are still elements to compare
        while ((p1 >= 0) && (p2 >= 0)) {
            // Compare two elements from nums1 and nums2 
            // and add the largest one in nums1 
            nums1[p--] = (nums1[p1] < nums2[p2]) ? nums2[p2--] : nums1[p1--];
        }

        // Add remaining elements from nums2 into nums1
        Array.Copy(nums2, 0, nums1, 0, p2 + 1);
    }
    
    [Theory]
    //                            
    [InlineData( new int []{1,2,3,0,0,0}, 3,new int []{2,5,6},3, new int []{1,2,2,3,5,6})]
    [InlineData( new int []{1}, 1,new int []{},0, new int []{1})]
    [InlineData( new int []{0}, 0,new int []{1},1, new int []{1})]
    [InlineData( new int []{2,0}, 1,new int []{1},1, new int []{1,2})]
    [InlineData( new int []{4,5,6,0,0,0}, 3,new int []{1,2,3},3, new int []{1,2,3,4,5,6})]
    private void Test_OK(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
    {
        Merge(nums1,m,nums2,n);
        Assert.Equal(expectedResult, nums1);
    }
}