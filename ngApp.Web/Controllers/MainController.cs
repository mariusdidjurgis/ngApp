using Microsoft.AspNetCore.Mvc;
using ngApp.Web.Interfaces.Base;
using ngApp.Web.Interfaces.Repositories;
using ngApp.Web.Models.Base;
using ngApp.Web.Persistence;
using ngApp.Web.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ngApp.Web.Controllers
{
    public class MainController<TEntity, TViewModel> : Controller
        where TEntity: EntityId, new()
        where TViewModel: BaseIdViewModel<TEntity>, new()
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<TEntity> repository;

        public MainController(IUnitOfWork _unitOfWork, IRepository<TEntity> _repository)
        {
            unitOfWork = _unitOfWork;
            repository = _repository;
        }

        public IEnumerable<TViewModel> GetList()
        {
            var list = repository.GetAll().ToList();
            var vList = new List<TViewModel>();
            foreach (var l in list)
            {
                Type viewModelType = typeof(TViewModel);
                ConstructorInfo viewModelConstructor = viewModelType.GetConstructor(new[] { typeof(TEntity) });
                if (viewModelConstructor != null)
                    vList.Add((TViewModel)viewModelConstructor.Invoke(new object[] { l }));
            }

            return vList;
        }

        [HttpGet]
        [Route("{Id:long}")]
        public TViewModel GetById(long Id)
        {
            var model = Id > 0 ? repository.Get(Id) : new TEntity();
            var viewModel = new TViewModel();

            Type viewModelType = typeof(TViewModel);
            ConstructorInfo viewModelConstructor = viewModelType.GetConstructor(new[] { typeof(TEntity) });

            if (viewModelConstructor != null)
                viewModel = (TViewModel)viewModelConstructor.Invoke(new object[] { model });

            OnGet(viewModel);

            return viewModel;
        }

        protected virtual void OnGet(TViewModel viewModel)
        {

        }

        [HttpPost]
        public IActionResult Post([FromBody]TViewModel viewModel)
        {
            var model = new TEntity();
            viewModel.GetUpdatedModel(model);
            repository.Add(model);
            unitOfWork.Complete();

            return Ok(model.Id);
        }

        [HttpPut]
        public IActionResult Put([FromBody]TViewModel viewModel)
        {
            var model = repository.Get(viewModel.Id);
            viewModel.GetUpdatedModel(model);
            
            repository.Update(model);
            OnPost(model, viewModel);
            unitOfWork.Complete();

            return Ok(model.Id);
        }

        protected virtual void OnPost(TEntity model, TViewModel viewModel)
        {

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
