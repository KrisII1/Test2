using Data_Layer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace TestLayer
{
    [SetUpFixture]
    public static class SetupFixture
    {
        public static KrisDbContext dbContext;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            dbContext = new KrisDbContext(builder.Options);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {

            dbContext.Dispose();
        }
    }
}
