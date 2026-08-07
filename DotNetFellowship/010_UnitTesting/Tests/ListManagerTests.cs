using System;
using System.Collections.Generic;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class ListManagerTests
{
    private ListManager _listManager;
    private List<int> _list;
    [SetUp]
    public void SetUp() { _listManager = new ListManager(); _list = new List<int>(); }
    [Test]
    public void AddElement_AddsToList() { _listManager.AddElement(_list, 5); CollectionAssert.Contains(_list, 5); }
    [Test]
    public void RemoveElement_RemovesFromList() { _list.Add(5); _listManager.RemoveElement(_list, 5); CollectionAssert.DoesNotContain(_list, 5); }
    [Test]
    public void GetSize_ReturnsCorrectSize() { _list.Add(1); _list.Add(2); Assert.AreEqual(2, _listManager.GetSize(_list)); }
}
