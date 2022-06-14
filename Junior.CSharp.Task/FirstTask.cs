namespace Junior.CSharp.Task
{
	public class FirstTask
	{
		public int RemoveDuplicates(int[] nums)
		{
			if (1 > nums.Length || nums.Length > 30000)
			{
				throw new Exception("Array range is not between 1 and 30000");
			}
			foreach (var item in nums)
			{
				if (item < -100 || item > 100)
				{
					throw new Exception("There are items in array hwo are smaller tjan -100 or greater than 100");
				}
			}

			int count = 1;
			int i = 0;
			if (1 <= nums.Length && nums.Length <= 30000)
			{
				for (int j = 1; j < nums.Length; j++)
				{
					if (nums[j] != nums[i])
					{
						count++;
						i++;
						nums[i] = nums[j];
					}
				}
			}
			return count;
		}

	}
}