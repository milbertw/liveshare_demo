﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Supercon.Model;
using Supercon.Service;

namespace Supercon.Controllers
{

    public class ProductController : Controller
    {
        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService; 
        }

        [HttpGet("v1/products")]
        public List<string> GetProducts()
        {
            return productService.GetProductCodes();
        }

        [HttpGet("v1/products/{code}")]
        public IActionResult GetProducts(string code)
        {
            Product product = productService.GetProduct(code);
            return StatusCode(StatusCodes.Status200OK, product);
        }

        private string MilberMethod()
        {
            return "I am Milber again. For testing" ;
        }

        private string EduMethods()
        {
            var msg = "Edu is doing something. New things";
            return msg;
        }

        private void VSCodeIsTheHostNow()
        {
            var msg = "no new code for now";
        }

    }
}
