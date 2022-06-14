namespace Junior.CSharp.Task
{
	public class FirstTask
	{
		public int RemoveDuplicates(int[] nums)
		{
			int count = 1;
			int i = 0;
			if (1 <= nums.Length && nums.Length <= 30000 && -100 <= nums[i] && nums[i] <= 100)
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