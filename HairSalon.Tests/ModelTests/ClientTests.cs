using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
      Client.ClearAll();
      Specialty.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=pavel_zanchuk_test;";
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Pavel";
      Client newClient = new Client(name, 1);
      string result = newClient.GetName();
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ClientList()
    {
      List<Client> newList = new List<Client> {};
      List<Client> result = Client.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsClients_ClientList()
    {
      string name01 = "Name";
      string name02 = "Name2";
      Client newClient1 = new Client(name01, 1);
      newClient1.Save();
      Client newClient2 = new Client(name02, 1);
      newClient2.Save();
      List<Client> newList = new List<Client> { newClient1, newClient2 };
      List<Client> result = Client.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectClientFromDatabase_Client()
    {
      Client testClient = new Client("Name", 1);
      testClient.Save();
      Client foundClient = Client.Find(testClient.GetId());
      Assert.AreEqual(testClient, foundClient);
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfNamesAreTheSame_Client()
    {
      Client firstClient = new Client("Name2", 1);
      Client secondClient = new Client("Name2", 1);
      Assert.AreEqual(firstClient, secondClient);
    }

    [TestMethod]
    public void Save_SavesToDatabase_ClientList()
    {
      Client testClient = new Client("Name2", 1);
      testClient.Save();
      List<Client> result = Client.GetAll();
      List<Client> testList = new List<Client>{testClient};
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void Save_AssignsIdToObject_Id()
    {
      Client testClient = new Client("Name2", 1);
      testClient.Save();
      Client savedClient = Client.GetAll()[0];
      int result = savedClient.GetId();
      int testId = testClient.GetId();
      Assert.AreEqual(testId, result);
    }

    [TestMethod]
    public void Delete_DeletesClientsWithMatchedId_True()
    {
      Client testClient = new Client("test", 1);
      testClient.Save();
      testClient.Delete();
      List<Client> allClients = Client.GetAll();
      List<Client> testClients = new List<Client>{};
      CollectionAssert.AreEqual(allClients, testClients);
    }

    [TestMethod]
    public void Edit_EditsMatchedClient_True()
    {
      Client testClient = new Client("test", 1);
      Client testClient2 = new Client("newTest", 1);
      testClient.Edit("newTest");
      Assert.AreEqual(testClient, testClient2);
    }

  }
}
