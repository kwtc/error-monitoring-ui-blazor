namespace Kwtc.ErrorMonitoring.Ui.Application.Abstractions.Api;

public interface IApiClient
{
    Task<HttpResponseMessage> PostAsync<T>(string url, T body, CancellationToken cancellationToken);
    
    Task<T> GetAsync<T>(string url, CancellationToken cancellationToken = default);
}
