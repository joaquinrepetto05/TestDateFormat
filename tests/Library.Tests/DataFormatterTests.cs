using NUnit.Framework;
namespace TestDateFormat;

[TestFixture]
public class DataFormatterTests
{
    [SetUp]
    public void Setup ()
    {
    }

    [Test]
    public void CorrectFormat ()
    {
        string expected = "1997-11-10";
        string input = "10/11/1997";

        string output = DateFormatter.ChangeFormat (input);

        Assert.AreEqual (expected, output);
    }

    [Test]
    public void WrongFormat ()
    {
        string expected = "1997-11-10";
        string input = "10.11.1997";

        string output = DateFormatter.ChangeFormat (input);

        Assert.AreEqual (expected , output);
    }

    [Test]
    public void BlankDate ()
    {
        string expected = "";
        string input = "";

        string output = DateFormatter.ChangeFormat (input);

        Assert.AreEqual (expected , output);
    }
}
