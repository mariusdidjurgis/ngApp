using AutoMapper;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels;

namespace ngApp.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile(){
            CreateMap<Make, MakeViewModel>();
            CreateMap<Model, ModelViewModel>();
            CreateMap<ModelViewModel, Model>();
            CreateMap<Feature, FeatureViewModel>();
            CreateMap<FeatureViewModel, Feature>().ForMember(x => x.Active, opt => opt.Ignore()).ForMember(x => x.Price, opt => opt.Ignore());
        }

    }
}