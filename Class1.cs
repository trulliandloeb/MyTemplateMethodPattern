using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MyTemplateMethodPattern
{
    public interface ITemplateMethod
    { }

    public static class TemplateMethodExtension
    {
        public static void TemplateMethod(this ITemplateMethod iTemplate, Action actionOne, Action actionTwo)
        {
            actionOne();
            actionTwo();
        }
    }

    namespace Test
    {
        public class TemplateMethod : ITemplateMethod
        {

        }

        [TestFixture]
        public class Test
        {
            [Test]
            public void TestExample()
            {
                var t = new TemplateMethod();
                t.TemplateMethod(() => Console.WriteLine("hello"), () => Console.WriteLine("world"));
            }
        }
    }
}
