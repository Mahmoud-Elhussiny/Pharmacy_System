﻿using Pharmacy.Application.Masseges;

namespace Pharmacy.Application.Business.Crud_representer.Command
{
    public class DeleteRepresenterHandlerOutput : BaseRessponse
    {
        public DeleteRepresenterHandlerOutput() { }
        public DeleteRepresenterHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? Message { get; set; }

    }
}
