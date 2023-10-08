using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace PowerLearn
{
    public class FileServer
    {
        public static FileServer Instance { get; set; }

        private readonly string address;
        private readonly string port;

        public FileServer(string address, string port)
        {
            this.address = address;
            this.port = port;
        }

        public async Task<byte[]> Download(string id, string fullName)
        {
            using (var content = new StringContent($"verb=download&id={id}&fullName={fullName}", Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                var client = new HttpClient();

                var response = await client.PostAsync($"http://{address}:{port}", content);
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException ex)
                {
                    throw new HttpRequestException($"{ex.Message}\nServer cannot load test! Please, check code or write" +
                        $"an email to operationsoftstudio@gmail.com");
                }
                catch (Exception)
                {
                    throw;
                }
                return await response.Content.ReadAsByteArrayAsync();
            }
        }
        //var result = new string[keyValues.Length / 2];
        //for (int i = 0; i < result.Length; i++)
        //{
        //    var name = keyValues[2 * i];
        //    var value = keyValues[2 * i + 1];
        //    result[i] = $"{name}={value}";
        //}
        //var r = string.Join("&", result);

        public async Task<string> Upload(string path, params string[] keyValues)
        {
            var bytes = File.ReadAllBytes(path);

            using (var mfdc = new MultipartFormDataContent())
            using (var fileContent = new ByteArrayContent(bytes))
            {
                mfdc.Add(fileContent, "file", Path.GetFileName(path));
                for (int i = 0; i < keyValues.Length; i += 2)
                {
                    var sc = new StringContent(keyValues[i + 1]);
                    mfdc.Add(sc, keyValues[i]);
                }
                var client = new HttpClient();

                var response = await client.PostAsync($"http://{address}:{port}", mfdc);
                response.EnsureSuccessStatusCode();
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(responseStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public async Task<byte[]> Download(params string[] keyValues)
        {
            var kv = new List<string>();
            for (int i = 0; i < keyValues.Length / 2; i++)
            {
                var j = i * 2 % keyValues.Length;
                kv.Add($"{keyValues[j]}={keyValues[j + 1]}");
            }
            using (var content = new StringContent(string.Join("&", kv),
                Encoding.UTF8,
                "application/x-www-form-urlencoded"))
            {
                var client = new HttpClient();
                var response = await client.PostAsync($"http://{address}:{port}", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsByteArrayAsync();
            }
        }

        public async Task<string> SendVerb(params string[] keyValues)
        {
            var kv = new List<string>();
            for (int i = 0; i < keyValues.Length / 2; i++)
            {
                var j = i * 2 % keyValues.Length;
                kv.Add($"{keyValues[j]}={keyValues[j + 1]}");
            }
            using (var content = new StringContent(string.Join("&", kv),
                Encoding.UTF8,
                "application/x-www-form-urlencoded"))
            {
                var client = new HttpClient();
                var response = await client.PostAsync($"http://{address}:{port}", content).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}