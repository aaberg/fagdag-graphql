using System;
using HotChocolate;
using NUnit.Framework;
using Timereg.Api.Resolvers;

namespace Timereg.Api.Tests
{
    public class SchemaTest
    {
        [Test]
        public void TestGenerateSchema()
        {
            var schema = SchemaBuilder.New()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .Create();
            
            Console.WriteLine(schema.ToString());
        }
    }
}