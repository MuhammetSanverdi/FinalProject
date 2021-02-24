using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Microsoft.IdentityModel.Tokens;

namespace ConsolUI
{
    //SOLID
    //OPEN CLOSED Principle
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            ProductTest();
            //IoC
            //CategoryTest();

            


        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductdetails();

            if (result.Success==true)
            {
                foreach (var product in productManager.GetProductdetails().Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
