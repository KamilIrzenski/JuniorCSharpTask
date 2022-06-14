using Microsoft.VisualStudio.TestTools.UnitTesting;
using Junior.CSharp.Task;
namespace Junior.CSharp.Test
{
	[TestClass]
	public class ThirdTaskTest
	{
		[TestMethod]
		public void IsHappyTest()
		{
			ThirdTask task = new ThirdTask();	
			Assert.AreEqual(3, task.Divide(10,3));
			Assert.AreEqual(-2, task.Divide(7,-3));
		}

	}
}
