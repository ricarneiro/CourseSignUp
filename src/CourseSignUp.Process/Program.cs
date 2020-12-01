﻿using CourseSignUp.Domain.Contracts;
using CourseSignUp.Domain.Events.Course;
using CourseSignUp.Domain.Services.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CourseSignUp.Process
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var provider = services.BuildServiceProvider();

            var eventBus = provider.GetService<IEventBus>();

            eventBus.Subscribe<SignUpEvent, SignUpHandler>();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<IEventBus, ...>()
        }
    }
}
