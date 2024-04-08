using Lab5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab5;

[TestClass]
public class Variant14Test
{
    [TestMethod]
    public void GetCountNegativeValues_Return9()
    {
        var array = new double[,]
        {
            { 3, -5, 87, -6, -9 },
            { -8, -9, -5, -4, -2 },
            { 3, 23, 45, -7, 9 }
        };

        var expected = 9;
        var actual = Variant14.GetCountNegativeValues(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetCountNegativeValues_Return3()
    {
        var array = new double[,]
        {
            { 3, -5, 87, -6, -9 },
            { 3, 23, 45, 77, 9 }
        };

        var expected = 3;
        var actual = Variant14.GetCountNegativeValues(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetCountNegativeValues_Return4()
    {
        var array = new double[,]
        {
            { 3, -5, 87, -6, -9 },
            { 3, 23, 45, -77, 9 }
        };

        var expected = 4;
        var actual = Variant14.GetCountNegativeValues(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetCountNegativeValues_Return5()
    {
        var array = new double[,]
        {
            { 3, -5, 87, -6, -9 },
            { 3, 23, -45, -77, 9 }
        };

        var expected = 5;
        var actual = Variant14.GetCountNegativeValues(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetCountNegativeValues_Return2()
    {
        var array = new double[,]
        {
            { 3, 5, 87, -6, -9 },
            { 3, 23, 45, 77, 9 }
        };

        var expected = 2;
        var actual = Variant14.GetCountNegativeValues(array);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetResultMultiply_Return175()
    {
        var array = new double[,]
        {
            { 3, -5, 7, -6, -9 },
            { 3, 2, 5, 7, 9 },
            { 3, 2, 5, 7, 9 }
        };

        var expected = 175;
        var actual = Variant14.GetResultMultiply(array);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetResultMultiply_Return448()
    {
        var array = new double[,]
        {
            { 3, 5, 7 },
            { 3, 2, 8 },
            { 3, 2, 8 }
        };

        var expected = 448;
        var actual = Variant14.GetResultMultiply(array);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetResultMultiply_ReturnMinus35()
    {
        var array = new double[,]
        {
            { 3, -5, 7, -6, -9 },
            { 3, 2, -5, -7, 9 },
            { 3, 2, 5, -7, 9 }
        };

        var expected = 35;
        var actual = Variant14.GetResultMultiply(array);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetResultMultiply_ReturnMinus25()
    {
        var array = new double[,]
        {
            { 3, -5, -7, -6, -9 },
            { 3, -2, 5, -7, 9 },
            { 3, -2, 5, -7, 9 }
        };

        var expected = 25;
        var actual = Variant14.GetResultMultiply(array);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetResultMultiply_Return200()
    {
        var array = new double[,]
        {
            { -3, -5, 8, -6, -9 },
            { 3, 2, 5, 7, 9 },
            { 3, 2, 5, 7, 9 }
        };

        var expected = 200;
        var actual = Variant14.GetResultMultiply(array);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetArrayMinElements_Return_Minus9_2_Minus5()
    {
        var array = new double[,]
        {
            { -9, 5, 7 },
            { 3, 2, 5,},
            { 9, -5, 5,}
        };

        double[] expected = [-9, 2, -5];
        var actual = Variant14.GetArrayMinElements(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetArrayMinElements_Return_5_3_0()
    {
        var array = new double[,]
        {
            { 9, 5, 7 },
            { 3, 9, 5,},
            { 9, 0, 5,}
        };

        double[] expected = [5, 3, 0];
        var actual = Variant14.GetArrayMinElements(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetArrayMinElements_Return_Minus15_Minus34_Minus5()
    {
        var array = new double[,]
        {
            { -9, -15, 7 },
            { 3, -34, 5,},
            { 9, -5, 155,}
        };

        double[] expected = [-15, -34, -5];
        var actual = Variant14.GetArrayMinElements(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetArrayMinElements_Return_Minus9_3_Minus5()
    {
        var array = new double[,]
        {
            { -9, 5, 7 },
            { 3, 24, 5,},
            { 9, -5, 5,}
        };

        double[] expected = [-9, 3, -5];
        var actual = Variant14.GetArrayMinElements(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetArrayMinElements_Return_Minus9_2_Minus25()
    {
        var array = new double[,]
        {
            { -9, 5, 7 },
            { 3, 2, 5,},
            { 9, -25, 5,}
        };

        double[] expected = [-9, 2, -25];
        var actual = Variant14.GetArrayMinElements(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeValues_Return1()
    {
        var array = new double[,]
        {
            { 4, -5, 6, 7, 4 },
            { -4, -5, 6, -7, 4 },
        };

        double[] expected = [-5, -4, -5, -7];
        var actual = Variant14.GetNegativeValues(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeValues_Return2()
    {
        var array = new double[,]
        {
            { 4, -5, 6, 7, 4 },
            { 4, 5, 6, -7, 4 },
        };

        double[] expected = [-5, -7];
        var actual = Variant14.GetNegativeValues(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeValues_Return3()
    {
        var array = new double[,]
        {
            { 4, -5, -6, -7, 4 },
            { -4, -5, 6, -7, 4 },
        };

        double[] expected = [-5, -6, -7, -4, -5, -7];
        var actual = Variant14.GetNegativeValues(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeValues_Return4()
    {
        var array = new double[,]
        {
            { 4, -5, 6, 7, -4 },
            { -4, -5, 6, -7, 4 },
        };

        double[] expected = [-5, -4, -4, -5, -7];
        var actual = Variant14.GetNegativeValues(array);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetNegativeValues_Return5()
    {
        var array = new double[,]
        {
            { 4, -5, 6, -7, 4 },
            { -4, -5, 6, -7, -4 },
        };

        double[] expected = [-5, -7, -4, -5, -7, -4];
        var actual = Variant14.GetNegativeValues(array);

        CollectionAssert.AreEqual(expected, actual);
    }
}