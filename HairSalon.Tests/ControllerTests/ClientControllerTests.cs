using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientControllerTest : IDisposable
  {

    public ClientControllerTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=pavel_zanchuk_test;";
    }

    public void Dispose()
    {
      Stylist.ClearAll();
      Client.ClearAll();
      Specialty.ClearAll();
    }

    [TestMethod]
    public void Show_ReturnsCorrectType_ActionResult()
    {
      ClientController controller = new ClientController();
      IActionResult view = controller.Show(1, 1);
      Assert.IsInstanceOfType(view, typeof(ViewResult));
    }

    [TestMethod]
    public void New_ReturnsCorrectType_True()
    {
      ClientController controller = new ClientController();
      IActionResult view = controller.New(1);
      Assert.IsInstanceOfType(view, typeof(ViewResult));
    }

    [TestMethod]
    public void Show_HasCorrectModelType_Dictionary()
    {
      ViewResult showView = new ClientController().Show(1, 1) as ViewResult;
      var result = showView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
    }

    [TestMethod]
    public void Delete_ReturnsCorrectType_ActionResult()
    {
      ClientController controller = new ClientController();
      IActionResult view = controller.Delete(1, 1);
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Edit_ReturnsCorrectType_ActionResult()
    {
      ClientController controller = new ClientController();
      IActionResult view = controller.Edit(1, 2);
      Assert.IsInstanceOfType(view, typeof(ViewResult));
    }

    [TestMethod]
    public void Edit_HasCorrectModelType_Dictionary()
    {
      ViewResult view = new ClientController().Edit(2, 2) as ViewResult;
      var result = view.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
    }

  }
}
