using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Business.Crud_PurchasingBill.Command;

namespace Pharmacy.WebAPI.Endpoint.Crud_PurchasingBill
{
    public class CreatePurchasingBillMapper : Profile
    {
        public CreatePurchasingBillMapper()
        {
            CreateMap<CreatePurchasingBillEndPointRequest, CreatePurchasingBillHandlerInput>()
                .ConstructUsing(src => new CreatePurchasingBillHandlerInput(src.CorrelationId()));
            CreateMap<CreatePurchasingBillHandlerOutput, CreatePurchasingBillEndPointResponse>()
               .ConstructUsing(src => new CreatePurchasingBillEndPointResponse(src.CorrelationId()));
        }

    }
}
