namespace Kwtc.ErrorMonitoring.Ui.Application.Event.Queries;

using Abstractions.Api;
using MediatR;
using Models;

public record GetReportsQuery : IRequest<IEnumerable<Report>>;

internal sealed class GetReportsQueryHandler : IRequestHandler<GetReportsQuery, IEnumerable<Report>>
{
    private readonly IApiClient apiClient;

    public GetReportsQueryHandler(IApiClient apiClient)
    {
        this.apiClient = apiClient;
    }

    public async Task<IEnumerable<Report>> Handle(GetReportsQuery request, CancellationToken cancellationToken)
    {
        return await this.apiClient.GetAsync<IEnumerable<Report>>("/reports", cancellationToken);
    }
}
