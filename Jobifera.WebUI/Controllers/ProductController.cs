﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jobifera.Domain.Abstract;
using Jobifera.Domain.Entities;
namespace Jobifera.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }
        // GET: Product
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}