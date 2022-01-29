using Business.Abstract;
using Business.Concrete;
using Business.Validations.FluentValidations;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection MyService(this IServiceCollection ServiceCollection)
        {
            ServiceCollection.AddDbContext<ProjectContext>();
            ServiceCollection.AddScoped<IProductService, ProductManager>();
            ServiceCollection.AddScoped<ICategoryService, CategoryManager>();
           




            // Validation Dependency Tanımlamaları
            ServiceCollection.AddSingleton<IValidator<Categories>, CategoriesValidation>();
            ServiceCollection.AddSingleton<IValidator<Products>, ProductValidation>();
            ServiceCollection.AddSingleton<IValidator<Administrators>, AdministratorsValidation>();

            return ServiceCollection;
        }
    }
}
