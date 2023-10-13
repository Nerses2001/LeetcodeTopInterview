
namespace LeetcodeTopInterview
{
    internal class ArrayString
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] merged = new int[m + n];
            int i = 0, j = 0, k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    merged[k++] = nums1[i++];
                }
                else
                {
                    merged[k++] = nums2[j++];
                }
            }
            while (i < m)
            {
                merged[k++] = nums1[i++];
            }
            while (j < n)
            {
                merged[k++] = nums2[j++];
            }

            for (int p = 0; p < m + n; ++p)
            {
                nums1[p] = merged[p];
            }

        }
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != val)
                    nums[k++] = nums[i];
            }
            return k;

        }
        public int RemoveDuplicates(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            int k = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (!seen.Contains(nums[i]))
                {
                    nums[k++] = nums[i];
                    seen.Add(nums[i]);
                }
            }
            return k;
        }
        public int RemoveDuplicatesII(int[] nums)
        {

            if (nums.Length <= 2)
                return nums.Length;
            int k = 2;
            for (int i = 2; i < nums.Length; ++i)
            {
                if (nums[i] != nums[k - 2])
                    nums[k++] = nums[i];
            }

            return k;
        }

        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int majority = (nums.Length / 2) + 1;
            foreach (int n in nums)
            {
                if (counts.ContainsKey(n))
                {
                    ++counts[n];
                    if (counts[n] == majority)
                    {
                        return n;
                    }
                }
                else
                {
                    counts[n] = 1;
                }

            }
            return -1;

        }

    }
}
