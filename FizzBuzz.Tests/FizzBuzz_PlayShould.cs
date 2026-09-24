using FizzBuzz.Library;
namespace FizzBuzz.Tests;

[TestClass]
public sealed class FizzBuzz_PlayShould
{
    [TestMethod]
    public void Play_Input1_Return1()
    {
        FizzBuzzGame game = new FizzBuzzGame();

        string result = game.Play(1);

        Assert.AreEqual("1", result);
    }
}
