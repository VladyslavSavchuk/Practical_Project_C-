using Practical_Project_C_;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
[TestClass]
public class FruitTests
{
    [TestMethod]
    public void TestFruitToString()
    {
        var f = new Fruit("Apple", "Red");
        Assert.AreEqual("Name: Apple \nColor: Red", f.ToString());
    }
}