using ngApp.Web.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.ViewModels.Base
{
    public class BaseIdViewModel<TModel> where TModel : EntityId
    {
        public long Id { get; set; }

        public BaseIdViewModel() { }
        public BaseIdViewModel(EntityId entityId)
        {
            Id = entityId.Id;
        }

        public virtual void GetUpdatedModel(TModel model)
        {

        }
    }

    public class BaseNameViewModel<TEntityWithName> : BaseIdViewModel<TEntityWithName>
        where TEntityWithName : EntityWithName
    {
        public string Name { get; set; }

        public BaseNameViewModel() { }
        public BaseNameViewModel(EntityWithName entityWithName) : base(entityWithName)
        {
            Name = entityWithName.Name;
        }

        public override void GetUpdatedModel(TEntityWithName model)
        {
            base.GetUpdatedModel(model);
            model.Name = Name;
        }
    }

}
