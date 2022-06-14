using Junior.CSharp.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Junior.CSharp.Test
{
	[TestClass]
	public class FourthTaskTest
	{
		[TestMethod]
		public void ThreeSumClosestTest()
		{
			FourthTask task = new FourthTask();
			//Assert.AreEqual(2, task.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1));
			Assert.AreEqual(0, task.ThreeSumClosest(new int[] { 0,0,0 }, 1));
		}
	}
}
