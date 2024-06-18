namespace GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication.Responses
{
    public sealed record NoFountUserActiveDirectoryAuthenticationResponse(string Message)
        :FailureActiveDirectoryAuthenticationResponse($"{Message}");
}
