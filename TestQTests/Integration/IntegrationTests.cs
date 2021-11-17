using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestQTests.Integration
{
    public class IntegrationTests
    {
        [Fact, Trait("Category", "Integration")]
        public void Even_number_passing_test()
        {
            Assert.True(1 == 1);

        }
    }
}
