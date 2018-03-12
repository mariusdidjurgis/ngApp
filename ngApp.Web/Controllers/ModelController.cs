using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ModelController : MainController<Model, ModelViewModel>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ModelController(IUnitOfWork _unitOfWork, IMapper _mapper): base(_unitOfWork, _mapper, _unitOfWork.Model)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }
        
    }
}