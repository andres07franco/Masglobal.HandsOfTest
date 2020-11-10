using AutoMapper;

namespace MasGlobal.HandsOnTest.Api.Helpers.AutoMapper
{
    using MasGlobal.HandsOnTest.Api.Models;
    using MasGlobal.HandsOnTest.Domain.Entities;
    using MasGlobal.HandsOnTest.Domain.Shared.Enums;
    using System;
    using System.Globalization;

    public class MapperConfigurationBuilder
    {
        public static MapperConfiguration Build()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee, EmployeeViewModel>();
                cfg.CreateMap<Role, RoleViewModel>();

                cfg.CreateMap<double, string>().ConvertUsing(value  => value.ToString("C", CultureInfo.CurrentCulture));
                cfg.CreateMap<ContractTypeEnum, string>().ConvertUsing(value => Enum.GetName(typeof(ContractTypeEnum), value) );

                cfg.CreateMap<Contract, ContractViewModel>();
            });

            return config;
        }
    }
} 