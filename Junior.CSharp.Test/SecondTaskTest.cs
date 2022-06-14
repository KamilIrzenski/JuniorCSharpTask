using Junior.CSharp.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Junior.CSharp.Test
{
	[TestClass]
	public class SecondTaskTest
	{
		[TestMethod]
		public void IsHappyTest()
		{
			SecondTask secondTask = new SecondTask();
			Assert.AreEqual(true, secondTask.IsHappy(19));
			//Assert.AreEqual(false, secondTask.IsHappy(2));
		}
	}
}
