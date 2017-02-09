using Autofac;
using DomainLogic.Serivce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
   public class IoC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RestaurentService>().As<IRestaurentService>();
        }
    }
}
