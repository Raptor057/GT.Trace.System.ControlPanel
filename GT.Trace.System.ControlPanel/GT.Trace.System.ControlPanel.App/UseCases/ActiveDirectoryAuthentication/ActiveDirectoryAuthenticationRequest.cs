using Common.Common.CleanArch;

namespace GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication
{
    public record ActiveDirectoryAuthenticationRequest(string User, string Passwd) : IRequest<ActiveDirectoryAuthenticationResponse>
    { }
}
