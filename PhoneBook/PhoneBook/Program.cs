using System;
using Microsoft.Extensions.DependencyInjection;

namespace PhoneBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IPhoneCollectionService, PhoneCollectionService>()
                .AddTransient<ContactBase>()
                .AddTransient<AlphabetSet>()
                .AddTransient<Starter>()
                .AddTransient<ApplicationService>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Start(serviceProvider);
        }
    }
}
