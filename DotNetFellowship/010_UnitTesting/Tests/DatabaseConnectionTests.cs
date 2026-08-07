using System;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection _dbConnection;
    [SetUp]
    public void SetUp() { _dbConnection = new DatabaseConnection(); }
    [TearDown]
    public void TearDown() { if (_dbConnection.IsConnected) _dbConnection.Disconnect(); }
    [Test]
    public void Connect_SetsIsConnectedToTrue() { _dbConnection.Connect(); Assert.IsTrue(_dbConnection.IsConnected); }
    [Test]
    public void Disconnect_SetsIsConnectedToFalse() { _dbConnection.Connect(); _dbConnection.Disconnect(); Assert.IsFalse(_dbConnection.IsConnected); }
}
