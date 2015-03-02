using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC5AppVeyorTestApp.Controllers;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using System.Text;

namespace MVC5AppVeyorUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HomeControllerIndex()
        {
            
            var hc = new HomeController();
           
            ViewResult vr = hc.About() as ViewResult;

            Assert.AreEqual("Your application description page.", vr.ViewBag.Message);
            
            //Assert.IsInstanceOfType(vr, typeof(ViewResult));
            

        }
    }
}
