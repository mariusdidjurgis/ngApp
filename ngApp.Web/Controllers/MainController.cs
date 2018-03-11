using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ngApp.Web.Interfaces.Base;
using ngApp.Web.Interfaces.Repositories;
using ngApp.Web.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.Controllers
{
    public class MainController<Entity, ViewModel> : Controller
        where Entity: class, IEntityId, new()
        where ViewModel: class
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IRepository<Entity> repository;

        public MainController(IUnitOfWork _unitOfWork, IMapper _mapper, IRepository<Entity> _repository)
        {
            mapper = _mapper;
            unitOfWork = _unitOfWork;
            repository = _repository;
        }

        public IEnumerable<ViewModel> GetList()
        {
            return mapper.Map<List<Entity>, List<ViewModel>>(repository.GetAll().ToList());
        }

        [HttpGet]
        [Route("{Id:long}")]
        public ViewModel GetById(long Id)
        {
            var model = Id > 0 ? repository.Get(Id) : new Entity();

            return mapper.Map<Entity, ViewModel>(model);
        }

        [HttpPost]
        public IActionResult Post([FromBody]ViewModel viewModel)
        {
            var model = mapper.Map<ViewModel, Entity>(viewModel);
            repository.Add(model);
            unitOfWork.Complete();

            return Ok(model.Id);
        }

        [HttpPut]
        public IActionResult Put([FromBody]ViewModel viewModel)
        {
            var model = mapper.Map<ViewModel, Entity>(viewModel);
            repository.Update(model);
            unitOfWork.Complete();

            return Ok(model.Id);
        }

        [HttpDelete("{Id:long}")]
        public IActionResult Delete(long Id)
        {
            repository.Remove(repository.Get(Id));
            unitOfWork.Complete();

            return Ok();
        }

    }
}
