using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using parsaspace.netcore.Models;
using parsaspace.netcore.Exceptions;
using System.IO;
using RestSharp;
using RestSharp.Deserializers;
using System.Net;

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
            var url = "v1/files/list";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "path",path}
               };
            return JsonConvert.DeserializeObject<Models.Results.FileListResult>(await PostRequest(url, param));
        }

        public async Task<Models.Results.ApitResult> Delete(string domain, string path)
        {
            var url = "v1/files/remove";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "path",path}
               };
            return JsonConvert.DeserializeObject<Models.Results.ApitResult>(await PostRequest(url, param));
        }

        public async Task<Models.Results.ApitResult> Rename(string domain, string source, string destination)
        {
            var url = "v1/files/rename";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "source",source},
                  {"destination",destination }
               };
            return JsonConvert.DeserializeObject<Models.Results.ApitResult>(await PostRequest(url, param));
        }

        public async Task<Models.Results.ApitResult> Move(string domain, string source, string destination)
        {
            var url = "v1/files/move";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "source",source},
                  {"destination",destination }
               };
            return JsonConvert.DeserializeObject<Models.Results.ApitResult>(await PostRequest(url, param));
        }

        public async Task<Models.Results.ApitResult> Copy(string domain, string source, string destination)
        {
            var url = "v1/files/copy";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "source",source},
                  {"destination",destination }
               };
            return JsonConvert.DeserializeObject<Models.Results.ApitResult>(await PostRequest(url, param));
        }
        public async Task<Models.Results.ApitResult> CreateFolder(string domain, string path)
        {
            var url = "v1/files/Createfolder";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "path",path}
               };
            return JsonConvert.DeserializeObject<Models.Results.ApitResult>(await PostRequest(url, param));
        }
        public async Task<Models.Results.ApitResult> RemoteUpload(string domain, string urls, string path = "", string filenames = "", string checkids = "")
        {
            var url = "v1/remote/new";
            var param = new Dictionary<string, object>
              {
                  {"domain", domain},
                  { "path",path},
                  {"filename",filenames },
                  {"url",urls },
                  {"checkid",checkids }
               };
            return JsonConvert.DeserializeObject<Models.Results.ApitResult>(await PostRequest(url, param));
        }

        public Models.Results.UploadResult UploadFile(string domain, string uploadpath, string filepath)
        {
            var client = new RestClient(_BaseUrl);
            var request = new RestRequest("v1/files/upload", Method.POST);
            if (_token.ToLower().StartsWith("bearer"))
            {
                throw new ApiException("400", new Exception("Please remove Bearer from token"));
            }
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("domain", domain);
            request.AddParameter("path", uploadpath);
            request.AddFile("file", filepath);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return new Results.UploadResult() { DownloadLink = "", Result = "error" };
            }
            JsonDeserializer deserial = new JsonDeserializer();
            return deserial.Deserialize<Models.Results.UploadResult>(response);
        }

        public async Task<Models.Results.ApitResult> RemoteUploadStatus(int checkid)
        {
            var url = "v1/remote/status";
            var param = new Dictionary<string, object>
              {
                  {"checkid", checkid},
               };
            return JsonConvert.DeserializeObject<Models.Results.ApitResult>(await PostRequest(url, param));
        }

        private async Task<string> PostRequest(string url, Dictionary<string, object> parameters, string method = "POST", string contentType = "application/x-www-form-urlencoded")
        {
            if (_token.ToLower().StartsWith("bearer"))
            {
                throw new ApiException("400", new Exception("Please remove Bearer from token"));
            }
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);
            var resp = await _httpClient.PostAsync(string.Format("{0}{1}", _BaseUrl, url), GetBodyData(parameters));
            var content = await resp.Content.ReadAsStringAsync();
            try
            {
                if (resp.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApiException("400", new Exception(resp.Content.ToString()));
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
