using Common.Common.CleanArch;
using GT.Trace.System.ControlPanel.App.UseCases.ActiveDirectoryAuthentication;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GT.Trace.System.ControlPanel.WebApi.EndPoints.ActiveDirectoryAuthentication
{
    [ApiController]
    [Route("[controller]")]
    public class ActiveDirectoryAuthenticationController : ControllerBase
    {
        private readonly ILogger<ActiveDirectoryAuthenticationController> _logger;
        private readonly IMediator _mediator;
        private readonly GenericViewModel<ActiveDirectoryAuthenticationController> _viewModel;

        public ActiveDirectoryAuthenticationController(ILogger<ActiveDirectoryAuthenticationController> logger, IMediator mediator, GenericViewModel<ActiveDirectoryAuthenticationController> viewModel)
        {
            _logger = logger;
            _mediator = mediator;
            _viewModel = viewModel;
        }

        [HttpGet]
        [Route("/api/login/")]
        public async Task<IActionResult> Get([FromBody] ActiveDirectoryAuthenticationRequestBody requestBody)
        {
            var request = new ActiveDirectoryAuthenticationRequest(requestBody.User, requestBody.Password);
            try
            {
                _ = await _mediator.Send(request).ConfigureAwait(false);
                return _viewModel.IsSuccess ? Ok(_viewModel) : StatusCode(500, _viewModel);
            }
            catch (Exception ex)
            {
                var innerEx = ex;
                while (innerEx.InnerException != null) innerEx = innerEx.InnerException!;
                return StatusCode(500, _viewModel.Fail(innerEx.Message));
            }
        }
    }
}
