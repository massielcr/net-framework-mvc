using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;
using System.Web.Mvc;

namespace LifeCycle.Extensions
{
    public class JsonNetResult : ActionResult
    {
        public object Data { get; set; }
        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;

            JsonSerializer serializer = new JsonSerializer();           

            response.ContentType = "application/json";

            response.Write(JsonConvert.SerializeObject(Data, new JsonSerializerSettings { ContractResolver = new PrefixContractResolver() }));
        }

        public class PrefixContractResolver : DefaultContractResolver
        {
            public static readonly PrefixContractResolver Instance = new PrefixContractResolver();

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                JsonProperty property = base.CreateProperty(member, memberSerialization);

                property.PropertyName = $"mcr_{property.PropertyName}";

                return property;
            }
        }
    }
}