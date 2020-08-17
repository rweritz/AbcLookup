using Xunit;

namespace AbcLookup.Test
{
    public class AlphabetTest
    {
        [Fact]
        public void GetNext_HappyCases()
        {
            Assert.Equal('B', Alphabet.GetNext('A'));
            Assert.Equal('D', Alphabet.GetNext('C'));
        }
        
        [Fact]
        public void GetPrevious_HappyCases()
        {
            Assert.Equal('A', Alphabet.GetPrevious('B'));
            Assert.Equal('Y', Alphabet.GetPrevious('Z'));
        }
    }
}