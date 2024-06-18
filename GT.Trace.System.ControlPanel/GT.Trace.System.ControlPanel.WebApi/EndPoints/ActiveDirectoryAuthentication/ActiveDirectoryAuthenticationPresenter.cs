using Common.Common.CleanArch;
using GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication;
using GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication.Responses;

namespace GT.Trace.System.ControlPanel.WebApi.EndPoints.ActiveDirectoryAuthentication
{
    public sealed class ActiveDirectoryAuthenticationPresenter<T> : IPresenter<FailureActiveDirectoryAuthenticationResponse>, IPresenter<SuccessActiveDirectoryAuthenticationResponse>
        where T : ActiveDirectoryAuthenticationResponse
    {
        private readonly GenericViewModel<ActiveDirectoryAuthenticationController> _viewModel;

        public ActiveDirectoryAuthenticationPresenter(GenericViewModel<ActiveDirectoryAuthenticationController> viewModel)
        {
            _viewModel = viewModel;
        }
        public Task Handle(SuccessActiveDirectoryAuthenticationResponse notification, CancellationToken cancellationToken)
        {
            _viewModel.OK(notification.UserData);
            return Task.CompletedTask;
        }

        public Task Handle(FailureActiveDirectoryAuthenticationResponse notification, CancellationToken cancellationToken)
        {
            _viewModel.Fail(notification.Message);
            return Task.CompletedTask;
        }


    }
}
