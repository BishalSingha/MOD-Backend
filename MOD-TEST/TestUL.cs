using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD_DAL;
using MOD_BAL;
using NUnit;
using NUnit.Framework;
namespace MOD_TEST
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetAll()
        {
            UL uL = new UL();
            IList<UserDtl> user = uL.GetAll();
            Assert.IsNotNull(user);

        }
    }
}
