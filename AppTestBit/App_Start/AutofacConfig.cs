using Autofac;
using Autofac.Integration.WebApi;
using DataAccess;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace AppTestBit.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();//creating container instance                                 
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());// register Web API controllers.  

            //register new type matching
            builder.RegisterType<AccountRepository>().As<IAccountRepository>().InstancePerRequest();
            builder.RegisterType<AppTestContext>().InstancePerRequest();

            var container = builder.Build(); //creation of a new container
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);// set the dependency resolver to be Autofac.
        }
    }
}