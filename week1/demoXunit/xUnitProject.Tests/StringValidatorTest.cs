namespace xUnitProject.Tests;

public class StringValidatorTest
{
    [Fact] // fixed set of inputs
    public void TestIsStringEmpty()
    {
        StringValidator validator = new StringValidator(); //create a new instance
        //Act
        bool isStringEmpty = validator.isEmpty("foo"); 
        //Asset
        Assert.False(isStringEmpty); // assert that result is false
    }

    [Theory] // variable set of inputs
    [InlineData("", true)]
    [InlineData("MyString", false)]
    [InlineData("MyString and me", false)]

    public void TestIsStringWhitespace(string input, bool expected)
    {
         StringValidator validator = new StringValidator(); 
         Assert.Equal(expected, validator.isEmpty(input));
    }
}