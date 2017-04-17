using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void InputList_Pisitive_Test()
        {
            InputList list = new InputList();
            Assert.AreEqual( "zzz : 0,31,dfdf : 0,15,xxxx : 0,15,dfsdfs : 0,08,dddd : 0,08,fgfghfg : 0,08,vvv : 0,08,fdf : 0,08,", list.Calculate(@"C:\Users\User\Documents\visual studio 2017\Projects\Net.S.2017.01.Ramanovskiy.11\Task3.Test\1.txt"));
        }
    }
}
