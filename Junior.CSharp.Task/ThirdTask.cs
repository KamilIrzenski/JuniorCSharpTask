using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.CSharp.Task
{
	public class ThirdTask
	{
		public int Divide(int divident, int divisior)
		{

			int sing = 1;
			if (divident * divisior < 0)
			{
				sing = -1;
			}

			int quotient = 0;

			divident = Math.Abs(divident);
			divisior = Math.Abs(divisior);
			if (divisior != 0 && int.MinValue <= divident && divisior <= int.MaxValue)
			{
				while (divident >= divisior)
				{
					divident = divident - divisior;
					quotient++;
				}
				if (quotient > int.MaxValue)
				{
					return int.MaxValue;
				}
				else if (quotient < int.MinValue)
				{
					return int.MinValue;
				}
			}
			return sing * quotient;
		}
	}
}
