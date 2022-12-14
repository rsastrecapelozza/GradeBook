using System;
using Xunit;

namespace GradeBook.tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            //arrange
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;
            log += ReturnMessage;

            //act
            var result = log("Hello!");
            
            //assert
            Assert.Equal(4, count);
            Assert.Equal("hello!", result);
        }

        string ReturnMessage(string message)
        {
            count++;
            return message.ToLower();
        }

        string IncrementCount(string message)
        {
            count++;
            return message;
        }


        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void StringBehavesLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUppercase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new InMemoryBook(name);
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
            
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        [Fact]
        public void VarCopyThePointer()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;
            book1 = GetBook("Book 2");

            Assert.False(Object.ReferenceEquals(book1, book2));
            Assert.Equal("Book 2", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.NotSame(book1, book2);
        }

        private Book GetBook(string name)
        {
            return new InMemoryBook(name);
        }

        [Fact]
        public void CreatingMethodWithOut()
        {
            int testNumber;
            var book1 = GetBook("Book 1", out testNumber);

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal(3, testNumber);

        }

        private Book GetBook(string name, out int number)
        {
            number = 3;
            return new InMemoryBook(name);
        }
    }
}
