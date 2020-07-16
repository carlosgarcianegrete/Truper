using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace ExamenFrontEndMVC
{
    public static class JWTVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        static JWTVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:27964/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}