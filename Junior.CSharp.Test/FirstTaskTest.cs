using Junior.CSharp.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Junior.CSharp.Test
{
	[TestClass]
	public class FirstTaskTest
	{
		[TestMethod]
		public void RemoveDuplicatesTest()
		{
			FirstTask firstTask = new FirstTask();

			Assert.AreEqual(2, firstTask.RemoveDuplicates(new int[] { 1, 1, 2 }));
			Assert.AreEqual(5, firstTask.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));

		}
	}
}