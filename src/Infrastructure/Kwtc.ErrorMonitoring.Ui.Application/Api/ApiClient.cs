namespace Kwtc.ErrorMonitoring.Ui.Application.Api;

using System.Text.Json;
using Abstractions.Api;
using Abstractions.Auth;
using Flurl.Http;
using Microsoft.Extensions.Configuration;

public class ApiClient : IApiClient
{
    private readonly IAuthenticationService authenticationService;
    private readonly string endpoint;

    public ApiClient(IConfiguration configuration, IAuthenticationService authenticationService)
    {
        this.authenticationService = authenticationService;
        this.endpoint = configuration["Api:Endpoint"]
                        ?? throw new InvalidOperationException("Api endpoint not set in configuration.");
    }

    public async Task<HttpResponseMessage> PostAsync<T>(string url, T? body, CancellationToken cancellationToken)
    {
        var request = $"{this.endpoint}{url}"
            .AddAuthToken(this.authenticationService.GetToken());

        if (body == null)
        {
            return (await request.PostAsync(cancellationToken: cancellationToken))
                .ResponseMessage;
        }

        var payload = JsonSerializer.Serialize(body);
        return (await request.PostJsonAsync(payload, cancellationToken)).ResponseMessage;
    }

    public async Task<T> GetAsync<T>(string url, CancellationToken cancellationToken = default)
    {
        return await $"{this.endpoint}{url}"
                     .AddAuthToken(this.authenticationService.GetToken())
                     .GetJsonAsync<T>(cancellationToken);
    }
}
