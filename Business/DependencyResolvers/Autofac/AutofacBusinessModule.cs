using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Services
            builder.RegisterType<BrandMenager>().As<IBrandService>();
            builder.RegisterType<CarMenager>().As<ICarService>();
            builder.RegisterType<ColourMenager>().As<IColourService>();
            builder.RegisterType<CustomerMenager>().As<ICustomerService>();
            builder.RegisterType<RentalMenager>().As<IRentalService>();
            builder.RegisterType<UserMenager>().As<IUserService>();
            //DALs
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();
            builder.RegisterType<EfColourDal>().As<IColourDal>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();
            builder.RegisterType<EfRentalDal>().As<IRentalDal>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

        }
    }
}
