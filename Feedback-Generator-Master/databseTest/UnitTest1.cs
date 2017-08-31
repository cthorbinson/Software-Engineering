using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template_Designer;

namespace databseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testing_Template()
        {
            Template_Designer.Program.Main();

            string[] names = { "kim", "Kim", "KIM", "a", "123", "%", "qwertyuiopasdfghjklzxcvbnm", "NULL", "" };

            CreateNewTemplate test = new CreateNewTemplate();

            for (int i = 0; i < names.Length; i++)
            {
                test.addTemplateName(names[i]);
                test.addTemplatePosition(names[i]);
                test.addTemplateReviewer(names[i]);
                test.writeTemplateDetailsToDB();
            }
        }
    }
}
