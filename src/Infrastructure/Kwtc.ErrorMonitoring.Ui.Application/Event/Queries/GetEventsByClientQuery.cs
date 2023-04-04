namespace Kwtc.ErrorMonitoring.Ui.Application.Event.Queries;

using Abstractions.Api;
using MediatR;
using Models;

public record GetEventsByClientQuery(Guid ClientId) : IRequest<IEnumerable<Event>>;

internal sealed class GetEventsByClientQueryHandler : IRequestHandler<GetEventsByClientQuery, IEnumerable<Event>>
{
    public GetEventsByClientQueryHandler(IApiClient apiClient)
    {
    }

    public Task<IEnumerable<Event>> Handle(GetEventsByClientQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
