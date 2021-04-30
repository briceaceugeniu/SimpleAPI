using System;
using Xunit;

using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
       

        [Fact]
        public void Test1()
        {
            var returnValue = "ABC";
            Assert.Equal("ABC", returnValue);
        }
    }
}
