using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using parsaspace.netcore.Models;
using parsaspace.netcore.Exceptions;

namespace parsaspace.netcore
{
    public class v1
    {
        private const string _BaseUrl = "https://api.parsaspace.com/";
        private readonly string _token;
        /// <summary>
        /// The HTTP client
        /// </summary>
        private HttpClient _httpClient;
        public v1(string token)
        {
            _token = token;
            _httpClient = new HttpClient();
        }
        public async Task<Models.Results.FileListResult> GetFileList(string domain, string path)
        {
            var url = "api/v1/account/info";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "path",path}
               };
            var res = await PostRequest(url, param);
            return JsonConvert.DeserializeObject<Models.Results.FileListResult>(res);
        }

        private async Task<string> PostRequest(string url, Dictionary<string, object> parameters, string method = "POST", string contentType = "application/x-www-form-urlencoded")
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Authorization", _token);
            var resp = await _httpClient.PostAsync(string.Format("{0}{1}", _BaseUrl, url), GetBodyData(parameters));
            var content = await resp.Content.ReadAsStringAsync();
            try
            {
                var result = JsonConvert.DeserializeObject<Results.ApitResult>(content);
                if (result.Result.StatusCode != 200)
                    throw new ApiException(result.Result.StatusCode, result.Result.Message);
                return content;
            }
            catch (Exception ex)
            {
                throw new ConnectionException(ex.Message);
            }
        }
        private FormUrlEncodedContent GetBodyData(Dictionary<string, object> parameters)
        {
            return new FormUrlEncodedContent(parameters.Select(x => new KeyValuePair<string, string>(x.Key, x.Value.ToString())));
        }
    }
}
