
using Common.Common;

namespace GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication.Responses
{
    public abstract record FailureActiveDirectoryAuthenticationResponse(string Message) : ActiveDirectoryAuthenticationResponse, IFailure;

}
