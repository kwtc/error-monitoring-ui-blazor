namespace Kwtc.ErrorMonitoring.Ui.Application.Api;

using Flurl.Http;

public static class FlurlRequestExtensions
{
    public static IFlurlRequest AddAuthToken(this string url, string token)
    {
        return new FlurlRequest(url).WithHeader("Bearer", token);
    }
}
