using Newtonsoft.Json;

namespace searchtactics.Web.Helpers
{
    public static class JsonHelper
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}