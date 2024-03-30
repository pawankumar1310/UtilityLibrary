using System.Net.Http.Json;

namespace Middleware
{
    public class ApiHandler
    {
        public async Task<TResponse?> GetRequest<TResponse>(string api)
        {
            HttpClient _httpClient = new HttpClient();
            try
            {
                var response = await _httpClient.GetAsync(api);

                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<TResponse>();
                    if (model != null)
                    {
                        return model;
                    }
                    else
                    {
                        return default;
                    }
                }
                else
                {
                    return default;
                }
            }
            catch (Exception ex)
            {
                // Do not rethrow exception to preserve stack trace
                return default;
            }
            finally
            {

                _httpClient.Dispose();
            }
        }

        public async Task<TResponse?> GetRequest<TResponse>(string api, Dictionary<string, string>? parameters = null)
        {
            HttpClient _httpClient = new HttpClient();
            try
            {
                var query = "";

                if (parameters != null && parameters.Count > 0)
                {
                    query = "?" + string.Join("&", parameters.Select(p => $"{Uri.EscapeDataString(p.Key)}={Uri.EscapeDataString(p.Value)}"));
                }

                var response = await _httpClient.GetAsync(api + query);

                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<TResponse>();
                    if (model != null)
                    {
                        return model;
                    }
                    else
                    {
                        return default(TResponse);
                    }
                }
                else
                {
                    return default(TResponse);
                }
            }
            catch (Exception ex)
            {
                // Do not rethrow exception to preserve stack trace
                return default(TResponse);
            }
            finally
            {
                _httpClient.Dispose();
            }
        }

        public async Task<TResponse?> PostRequest<TRequest, TResponse>(string api, TRequest? request)
        {
            HttpClient _httpClient = new HttpClient();
            try
            {
                var response =  await _httpClient.PostAsJsonAsync(api, request);

                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<TResponse>();
                    if (model != null)
                    {
                        return model;
                    }
                    else
                    {
                        return default(TResponse);
                    }
                }
                else
                {
                    return default(TResponse);
                }
            }
            catch (Exception ex)
            {
                // Do not rethrow exception to preserve stack trace
                // return default(TResponse);
                throw ex;
            }
            finally
            {
                _httpClient.Dispose();
            }
        }

        public async Task<TResponse?> PutRequest<TRequest, TResponse>(string api, TRequest? request)
        {
            HttpClient _httpClient = new HttpClient();
            try
            {
                var response = await _httpClient.PutAsJsonAsync(api, request);

                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<TResponse>();
                    if (model != null)
                    {
                        return model;
                    }
                    else
                    {
                        return default(TResponse);
                    }
                }
                else
                {
                    return default(TResponse);
                }
            }
            catch (Exception ex)
            {
                // Do not rethrow exception to preserve stack trace
                return default(TResponse);
            }
            finally
            {
                _httpClient.Dispose();
            }
        }

        public async Task<TResponse?> DeleteRequest<TResponse>(string api)
        {
            HttpClient _httpClient = new HttpClient();
            try
            {
                var response = await _httpClient.DeleteAsync(api);
                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadFromJsonAsync<TResponse>();
                    if (model != null)
                    {
                        return model;
                    }
                    else
                    {
                        return default(TResponse);
                    }
                }
                else
                {
                    return default(TResponse);
                }
            }
            catch (Exception ex)
            {
                // Do not rethrow exception to preserve stack trace
                return default(TResponse);
            }
            finally
            {
                _httpClient.Dispose();
            }
        }


    }
}
