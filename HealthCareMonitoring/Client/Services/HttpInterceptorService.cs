using Microsoft.AspNetCore.Components;
using System.Net;
using System.Runtime.CompilerServices;
using Toolbelt.Blazor;

<<<<<<< HEAD
namespace CarRentalManagement1.Client.Services
=======
namespace HealthCareMonitoring.Client.Services
>>>>>>> 5eb0dad489109e8062baaa3f6fb89913533d6b0d
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor interceptor;
        private readonly NavigationManager navManager;

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
        {
            this.interceptor = interceptor;
            this.navManager = navManager;
        }
        public void MonitorEvent() => interceptor.AfterSend += InterceptResponse;
        public void DisposeEvent() => interceptor.AfterSend -= InterceptResponse;

        private void InterceptResponse(object? sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;

                switch (responseCode)
                {
                    case HttpStatusCode.NotFound:
                        navManager.NavigateTo("/404");
                        message = "The requested resource was not found.";
                        break;
                    case HttpStatusCode.Unauthorized:
                    case HttpStatusCode.Forbidden:
                        navManager.NavigateTo("/unauthorized");
                        message = "You are not authorized to access this resource. ";
                        break;
                    default:
                        navManager.NavigateTo("/500");
                        message = "Something went wrong, please contact Administrator";
                        break;
                }
            }
        }
    }
}

