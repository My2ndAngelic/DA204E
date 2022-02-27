using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeDNC;
using RecipeLibrary;

namespace RecipeMSTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        RecipeDNC.Program.Main(Array.Empty<string>());
        Form f = FormMain.ActiveForm;
    }
}