using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebCqrs.Api.Contracts.UserProfile.Requests;
using WebCqrs.Api.Contracts.UserProfile.Responses;
using WebCqrs.Application.UserProfiles.Commands;
using WebCqrs.Application.UserProfiles.Queries;

namespace WebCqrs.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController: Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public UserProfilesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProfiles()
        {
            var query = new GetAllUserProfiles();
            var response = await _mediator.Send(query);
            var profiles = _mapper.Map<List<UserProfileResponse>>(response);
            return Ok(profiles);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody]UserProfileCreateUpdate profileCreate) {
           var command = _mapper.Map<CreateUserCommand>(profileCreate);

            var response = await _mediator.Send(command);
            var userProfile = _mapper.Map< UserProfileResponse>(response);

            return Ok(userProfile);
           // return CreatedAtAction(nameof(GetUserProfileById), new { id = response.UserProfileId }, userProfile);
        }

        [Route(ApiRoutes.UserProfiles.IdRoute)]
        [HttpGet]
        public async Task<IActionResult> GetUserProfileById(string id) {
            var query = new GetUserProfileById { UserProfileId = Guid.Parse(id) };
            var response = _mediator.Send(query);
            var userProfile = _mapper.Map<UserProfileResponse>(response);

            return Ok(userProfile);
        }

        [HttpPatch]
        [Route(ApiRoutes.UserProfiles.IdRoute)]
        public async Task<IActionResult> UpdateUserProfile(string id, ) { 
        }
    }
}
