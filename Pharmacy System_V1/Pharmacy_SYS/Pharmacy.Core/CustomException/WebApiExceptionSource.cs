using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Pharmacy.Core.CustomException
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebApiExceptionSource
    {
        FromTranslation,
        DynamicMessage,
        FromDataBase,
        GeneralException
    }
}
