using Common.Common;
using Common.Common.CleanArch;
using GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication.Responses;
using System.DirectoryServices.AccountManagement;

namespace GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication
{
    internal sealed class ActiveDirectoryAuthenticationHandler : IInteractor<ActiveDirectoryAuthenticationRequest, ActiveDirectoryAuthenticationResponse>
    {
        public async Task<ActiveDirectoryAuthenticationResponse> Handle(ActiveDirectoryAuthenticationRequest request, CancellationToken cancellationToken)
        {
            string Fullname;
            string Email;
            string Position;
            string UserName;

            bool isValid = ValidateExternalUser(request.User, request.Passwd, out Fullname, out Email, out Position, out UserName);

            if (!isValid)
            {
                return new NoFountUserActiveDirectoryAuthenticationResponse("Contraseña incorrecta o Usuario no encontrado");
            }
            return new SuccessActiveDirectoryAuthenticationResponse(new Dtos.ActiveDirectoryAuthenticationDto(UserName, Fullname, Email, Position));
        }

        private bool ValidateExternalUser(string username, string password, out string Fullname, out string Email, out string Position,out string UserName)
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "gt.local"))
            {
                if (context.ValidateCredentials(username, password, ContextOptions.Negotiate))
                {
                    // Get the user principal
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                    if (user != null)
                    {
                        // Retrieve the Fullname, Email, and Position
                        Fullname = user.DisplayName;
                        Email = user.EmailAddress;
                        Position = user.Description;
                        UserName = user.SamAccountName;
                        return true;
                    }
                }

                // Invalid credentials or user not found
                Fullname = null;
                Email = null;
                Position = null;
                UserName = null;
                return false;
            }
        }
    }
}
