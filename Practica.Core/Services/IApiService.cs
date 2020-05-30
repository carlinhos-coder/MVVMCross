using Practica.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Core.Services
{
    public interface IApiService
    {
        Task<Response> SendProblemAsync(string urlBase, UserResponse userResponse);
        Task<Response> GetProblemAsync(string urlBase, string controller, UserRequest1 userRequest1);
    }
}
