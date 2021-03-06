﻿using System;
using HotChocolate;
using Timereg.Api.Resolvers;

namespace Timereg.Api.CLI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var schema = SchemaBuilder.New()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .Create();
            
            Console.WriteLine(schema.ToString());
            
        }
    }
}