using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace PhoneBook
{
    public class Starter
    {
        public void Start(ServiceProvider serviceProvider)
        {
            var application = serviceProvider.GetService<ApplicationService>();
            application.Run();
        }
    }
}
