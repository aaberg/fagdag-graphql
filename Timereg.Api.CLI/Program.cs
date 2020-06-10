using System;
using HotChocolate;
using Timereg.Api.Resolvers;

namespace Timereg.Api.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = SchemaBuilder.New()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .Create();
            
            Console.WriteLine(schema.ToString());

            // var executor = schema.MakeExecutable();
            //
            //
            //
            // var result = executor.Execute("{ allEmployees { name title } }").ToJson();
            //
            // Console.WriteLine(result);
        }
    }
}