using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using Todo.Repositories;
using Todo.Repositories.Interfaces;
using Todo.WebUI.Code.Managers.Interfaces;
using Todo.WebUI.Code.Managers;

namespace Todo.WebUI
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            container.RegisterType<ITaskRepository, FakeTaskRepository>();
            container.RegisterType<ISecurityManager, FormsSecurityManager>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ITaskRepository, FakeTaskRepository>();
            container.RegisterType<IFakeUserRepository, FakeUserRepository>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
    
        }
    }
}