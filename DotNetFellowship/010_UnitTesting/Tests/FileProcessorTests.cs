using System;
using System.IO;
using NUnit.Framework;
using _010_UnitTesting;
namespace _010_UnitTesting;
[TestFixture]
public class FileProcessorTests
{
    private FileProcessor _processor;
    private string _testFile = "testfile.txt";
    [SetUp]
    public void SetUp() { _processor = new FileProcessor(); }
    [TearDown]
    public void TearDown() { if (File.Exists(_testFile)) File.Delete(_testFile); }
    [Test]
    public void WriteToFile_FileWrittenSuccessfully() { _processor.WriteToFile(_testFile, "Hello World"); Assert.IsTrue(File.Exists(_testFile)); }
    [Test]
    public void ReadFromFile_ReadContentCorrectly() { File.WriteAllText(_testFile, "Test Content"); string content = _processor.ReadFromFile(_testFile); Assert.AreEqual("Test Content", content); }
    [Test]
    public void ReadFromFile_FileNotFound_ThrowsFileNotFoundException() { Assert.Throws<FileNotFoundException>(() => _processor.ReadFromFile("missingfile.txt")); }
}
