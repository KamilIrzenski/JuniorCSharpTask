using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.CSharp.Task
{
	public class FourthTask
	{
		public int ThreeSumClosest(int[] nums, int target)
		{
			int result = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == target)
				{
					result = nums[i] + nums[--i];
				}
			}
			return result;
		}
	}
}
