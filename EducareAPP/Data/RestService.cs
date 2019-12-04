﻿using EducareAPP.Modles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EducareAPP.Data
{
    class RestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-fotm-urlencoded"));
        }

        public async Task<Token> Login(User user)
        {

            var postData = new List<KeyValuePair<string, string>();
            postData.Add(new KeyValuePair<string, string>("grant_type", grant_type));
            postData.Add(new KeyValuePair<string, string>("username", user.Username));
            postData.Add(new KeyValuePair<string, string>("password", user.Password));
            var content = new FormUrlEncodedContent(postData);
            var weburl = "www.test.com";
            var response = await PostResponse<Token>(weburl, content);
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            response.expire_date = dt.AddSeconds(response.expire_in);
            return response;
        }
        public async Task<T>PostResponseLogin<T>(FormUrlEncodedContent content)
        {
            var weburl = "www.test.com";
            var response = await client.PostAsync(weburl, content);
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            var responseObject = JsonConvert.DeserializeObject<T>(jsonResult);
            return responseObject;
        }
        public async Task<T> PostResponse<T>(string weburl, string jsonstring) where T : class
        { 
            var token
        
        }
    }
}


