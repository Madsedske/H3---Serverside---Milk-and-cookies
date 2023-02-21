using Newtonsoft.Json;

namespace H3___Serverside___Milk_and_cookies.Controllers.Helper
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T? GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key); 
            
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
