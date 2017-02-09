using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class IoC:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RestaurentdbContext>().As<RestaurentdbContext>();
            builder.RegisterType<RestaurantRepo >().As<RestaurantRepo>();
        }
    }
}
