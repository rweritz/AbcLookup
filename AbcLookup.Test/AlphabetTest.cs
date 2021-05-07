using TestStack.BDDfy;
using Xunit;

namespace AbcLookup.Test
{
    public class AlphabetTest
    {
        private char _choosenLetter;

        private void GivenTheChoosenLetterIs(char c)
        {
            _choosenLetter = c;
        }

        private void TheNextLetterInTheAlphabetIs(char c)
        {
            Assert.Equal(c, Alphabet.GetNext(_choosenLetter));
        }
        
        [Fact]
        public void GetPrevious_HappyCases()
        {
            Assert.Equal('A', Alphabet.GetPrevious('B'));
            Assert.Equal('Y', Alphabet.GetPrevious('Z'));
        }
        
        [Theory]
        [InlineData('A', 'B')]
        [InlineData('D', 'E')]
        [InlineData('X', 'Y')]
        public void GetNext_HappyCases(char value, char next)
        {
            Assert.Equal(next, Alphabet.GetNext(value));
        }
        
        [Theory]
        [InlineData('A', 'B')]
        [InlineData('D', 'E')]
        [InlineData('X', 'Y')]
        public void GetNext_HappyCases_WithBDD(char value, char next)
        {
            this.Given(s => s.GivenTheChoosenLetterIs('A'))
                .Then(s => s.TheNextLetterInTheAlphabetIs('B'))
                .BDDfy("Test");
        }
    }
}