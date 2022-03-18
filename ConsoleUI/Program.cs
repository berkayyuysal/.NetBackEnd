using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new(new EfProductDal());

            foreach (var prodcut in productManager.GetAll())
            {
                Console.WriteLine(prodcut.ProductId);
            }
        }
    }
}
