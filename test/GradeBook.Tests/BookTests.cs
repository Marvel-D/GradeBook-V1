namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //* arrange section
            // e.g: var x = 5
           var book = new Book()

            //* act section
            //e.g: var actual = x * y;

            book.ShowStatistics();
            //* assert section
            Assert.Equal(expected, actual);
        }
    }
}
