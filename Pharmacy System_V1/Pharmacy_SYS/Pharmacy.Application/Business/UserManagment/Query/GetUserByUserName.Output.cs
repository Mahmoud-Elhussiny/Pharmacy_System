using Pharmacy.Application.Masseges;
namespace Pharmacy.Application.Business.UserManagment.Query
{
    public class GetUserByUserNameHandlerOutput : BaseResponse
    {
        public GetUserByUserNameHandlerOutput() { }
        public GetUserByUserNameHandlerOutput(Guid correlationId) : base(correlationId) { }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Address { get; set; }
        public int? isAdmin { get; set; }
        public DateTime? lastloginDate { get; set; }
        public DateTime? timeCreated { get; set; }
        public bool isActive { get; set; }
        public byte[]? Picture { get; set; }

    }
}
