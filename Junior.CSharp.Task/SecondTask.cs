using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.CSharp.Task
{
	public class SecondTask
	{
		public bool IsHappy(int n)
		{
			if (n <= 1 && n >= int.MaxValue)
			{
				throw new Exception("The number n is not in the range");
			}
			List<int> listOfResults = new List<int>();

			while (n != 1)
			{
				List<int> listOfInsts = new List<int>();

				while (n > 0)
				{
					listOfInsts.Add(n % 10);
					n = n / 10;
				}
				listOfInsts.Reverse();
				var tab = listOfInsts.ToArray();

				for (int i = 0; i < tab.Length; i++)
				{
					n += (int)Math.Pow(tab[i], 2);
				}

				if (listOfResults.Contains(n))
				{
					return false;
				}
				listOfResults.Add(n);
			}
			return true;
		}
	}
}
