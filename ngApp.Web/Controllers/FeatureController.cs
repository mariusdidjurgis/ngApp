using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Interfaces.Repositories;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Controllers
{
    [Route("api/Feature/[action]")]
    public class FeatureController : MainController<Feature, FeatureViewModel>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public FeatureController(IUnitOfWork _unitOfWork, IMapper mapper): base(_unitOfWork, mapper, _unitOfWork.Features)
        {
            this.mapper = mapper;
            unitOfWork = _unitOfWork;
        }

    }
}