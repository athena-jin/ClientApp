using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorApp.Controller
{
    public class HttpController
    {
        HttpClient? _client;
        public async void Init() 
        {
            //_client ??= new HttpClient("http://localhost:5275/");
            //await _client.PostAsync("api/actor");
        }
    }
}
