using ngApp.Web.Controllers;
using ngApp.Web.DesignPatterns.Singleton;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ngApp.Tests.ngAppWeb.DesignPatterns
{
    public class SingletonTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetInstance_CallSingletonObjectsInDifferentThreads_ShouldNotReturnSameObject()
        {
            Singleton singleton1 = Singleton.GetInstance;
            Singleton singleton2 = Singleton.GetInstance;            

            Assert.AreEqual(Singleton.GetInstance, singleton1);
            Assert.AreEqual(Singleton.GetInstance, singleton2);
        }


        [Test]
        public void GetInstance_SimpleCallOnThreadSafe_ShouldReturnSameObject()
        {
            var singleton1 = Singleton2.GetInstance;
            var singleton2 = Singleton2.GetInstance;

            Assert.AreEqual(Singleton2.GetInstance, singleton1);
            Assert.AreEqual(Singleton2.GetInstance, singleton2);
            Assert.AreEqual(singleton1, singleton2);
        }

        [Test]
        public void GetInstance_SimpleCallOnThreadSafe2_ShouldReturnSameObject()
        {
            var singleton1 = Singleton3.GetInstance;
            var singleton2 = Singleton3.GetInstance;

            Assert.AreEqual(Singleton3.GetInstance, singleton1);
            Assert.AreEqual(Singleton3.GetInstance, singleton2);
            Assert.AreEqual(singleton1, singleton2);
        }

    }
}
