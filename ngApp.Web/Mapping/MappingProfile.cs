using AutoMapper;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile(){
            CreateMap<Make, MakeViewModel>();
            CreateMap<Model, ModelViewModel>();
            
        }

    }
}