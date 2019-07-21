using Microsoft.AspNetCore.Http;

namespace CityGuide.Helpers
{
    public static class JWTExtension
    {
        public static void AddApplicaitonError(this HttpResponse response,string message){
            response.Headers.Add("Application-Error",message);
            response.Headers.Add("Access-Control-Allow-Origin","*");
            response.Headers.Add("Access-Control-Expose-Header","Application-Error");
        }
    }
}