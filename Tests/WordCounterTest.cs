using Xunit;
namespace WordCountApp
{
  public class WordCountAppTest
  {
    [Fact]
    public void RepeatCounter_ReturnWord_wordr()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal("cat", testRepeatCounter.GetWord("cat"));
    }
  }
}
