using AutoMapper;
using Infrastructure.CrossCutting.Exception;
using MyCleanArchitecture.Application.Interfaces.ViewModels;
using MyCleanArchitecture.Domain.DomainModel.entities.User;
using MyCleanArchitecture.Domain.DomainModel.Entities.Agents;
using MyCleanArchitecture.Domain.DomainModel.Entities.Orders;
using MyCleanArchitecture.Domain.DomainModel.Entities.Payments;
using MyCleanArchitecture.Domain.DomainModel.Entities.Products;

namespace MyCleanArchitecture.Application.Common.AutoMapper
{
    public class MappingProfile : Profile
    {
        private static Error MapExceptionToError(System.Exception e)
        {
            var errorDictionary = new Dictionary<Type, Error>()
            {
                {
                    typeof(ExpiredAccessTokenException), new Error
                    {
                        Code = $"{Error.Auth}-001",
                        Description = "Your session has expired, please re-authenticate to continue"
                    }
                },
                {
                    typeof(ArgumentException), new Error
                    {
                        Code = $"{Error.Request}-001",
                        Description = "Bad request, please review the parameters"
                    }
                }
            };
            var exceptionType = e.GetType();
            if (!errorDictionary.ContainsKey(exceptionType))
                return new Error
                {
                    Code = $"{Error.System}-001",
                    Description = $"Unknown error (exception type: {exceptionType})"
                };
            return errorDictionary[exceptionType];
        }
        public MappingProfile()
        {
            #region Errors

            CreateMap<System.Exception, ErrorResponse>()
                .ForMember(er => er.Message, options => options.MapFrom(e => e.Message))
                .ForMember(er => er.Error, options => options.MapFrom(e => MapExceptionToError(e)));
            #endregion
            #region DomainToViewModel
            CreateMap<UserEntity, UserViewModel>();
            CreateMap<ProductEntity, ProductViewModel>();
            CreateMap<AgentEntity, AgentViewModel>();
            CreateMap<ProductLineEntity, ProductLineViewModel>();
            // CreateMap<OrderEntity, OrderViewModel>();
            // CreateMap<OrderDetailEntity, OrderDetailViewModel>();
            // CreateMap<PaymentEntity, PaymentViewModel>();
            #endregion
        }
    }
}