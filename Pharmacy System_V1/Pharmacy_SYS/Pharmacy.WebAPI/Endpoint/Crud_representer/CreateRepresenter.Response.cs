﻿using Pharmacy.Application.Masseges;

namespace Pharmacy.WebAPI.Endpoint.Crud_representer
{
    public class CreateRepresenterEndPointResponse : BaseRessponse
    {
        public CreateRepresenterEndPointResponse() { }
        public CreateRepresenterEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
