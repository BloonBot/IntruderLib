namespace IntruderLib.Tests.Models
{
    using System;
    using IntruderLib.Models;
    using Xunit;

    public class APIExceptionTests
    {
        [Fact]
        public void ParameterlessCtor()
        {
            APIException exception = new APIException();
            Assert.NotNull(exception);
            Assert.Contains("Exception of type 'IntruderLib.Models.APIException' was thrown.", exception.Message);
        }

        [Fact]
        public void MessageCtor()
        {
            APIException exception = new APIException("Exception Message");
            Assert.NotNull(exception);
            Assert.Equal("Exception Message", exception.Message);
        }

        [Fact]
        public void InnerExceptionCtor()
        {
            Exception inner = new Exception("My Inner Exception");
            APIException exception = new APIException("My Outer Exception", inner);
            Assert.NotNull(exception);
            Assert.NotNull(exception.InnerException);
            Assert.Equal("My Outer Exception", exception.Message);
            Assert.Equal(inner, exception.InnerException);
        }
    }
}
