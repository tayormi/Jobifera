﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;
using Moq;
using Jobifera.Domain.Abstract;
using Jobifera.Domain.Entities;
using Jobifera.Domain.Concrete;

namespace Jobifera.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
            {
            //put bindings here
            //Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //    new Product { Name = "Football", Price = 25 },
            //    new Product { Name = "Soft Ball", Price = 179 },
            //    new Product { Name = "Fix Air Conditione", Price = 200000 }

            //});
            kernel.Bind<IProductsRepository>().To<EFProductRepository>();
        }
    }
}