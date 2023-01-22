﻿using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_DisCompany
{
    public class UpdateDistributedCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/UpdateDistributedCompany/";
        public int Id { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public int? TheManufacturerId { get; set; }
    }
}
