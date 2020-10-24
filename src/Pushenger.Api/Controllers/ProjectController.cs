﻿using AutoMapper;
using Microsoft.Extensions.Localization;
using Pushenger.Core.Interfaces;

namespace Pushenger.Api.Controllers
{
    public class ProjectController : BaseController
    {
        public ProjectController(
            IUnitOfWork _unitOfWork, 
            IMapper _mapper, 
            IStringLocalizer<BaseResource> _baseLocalizer) 
            : base(_unitOfWork, _mapper, _baseLocalizer)
        {
        }
    }
}
