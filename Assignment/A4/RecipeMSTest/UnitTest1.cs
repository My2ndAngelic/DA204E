using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeDNC;

namespace RecipeMSTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Program.Main(Array.Empty<string>());
        Form f = Form.ActiveForm;
    }
}
