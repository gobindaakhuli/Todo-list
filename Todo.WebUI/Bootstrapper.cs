using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using Todo.Repositories;
using Todo.Repositories.Interfaces;

namespace Todo.WebUI
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            //string connectionString = ;
            //container.RegisterType<ITaskRepository.SqlTaskRepository>(
            //                                                            new InjectionConstructor(connectionString)
            //                                                        );

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ITaskRepository, FakeTaskRepository>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
    
        }
    }
}