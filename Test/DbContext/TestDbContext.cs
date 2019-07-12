using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test.DbContext
{
    public class TestDbContext
    {
        [Fact]
        public void TestDb()
        {
            var address = new Address("1", "2", "3", "4");

            var address2 = new Address("1", "2", "3", "4");

            Assert.Equal(address, address2);
        }

    }
}
