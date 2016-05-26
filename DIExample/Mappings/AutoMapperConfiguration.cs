using AutoMapper;
using DIExample.Library.Models;
using DIExample.ViewModels;

namespace DIExample
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            // Set up our maps in a new configuration
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductViewModel>().ReverseMap(); // Need to be able to use view model to create new as well
                cfg.CreateMap<Product, ProductDetailedViewModel>();
            });
        }
    }
}