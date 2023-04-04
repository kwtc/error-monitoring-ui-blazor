namespace Kwtc.ErrorMonitoring.Ui.Application.Models;

public class Event
{
    public Guid? Id { get; set; }

    public Severity Severity { get; set; }

    public bool IsHandled { get; set; }

    public IEnumerable<Exception> Exceptions { get; set; } = default!;
}
