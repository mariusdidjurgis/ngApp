using AutoMapper;
using ngApp.Web.Models.Vechicles;
using ngApp.Web.ViewModels;
using ngApp.Web.ViewModels.Base;

namespace ngApp.Web.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile(){
            CreateMap<Make, MakeViewModel>();

            CreateMap<Model, ModelViewModel>()
                .BeforeMap((m, v) => { var make = m.Make.Name; })
                .ForMember(x => x.Color, opt => opt.MapFrom(src => new IdWithName((long)src.Color, src.Color.ToString())))
                .ForMember(x => x.Make, opt =>
                {
                    opt.MapFrom(src => new IdWithName(src.MakeId, src.Make.Name));
                });

            CreateMap<ModelViewModel, Model>();
            CreateMap<Feature, FeatureViewModel>();
            CreateMap<FeatureViewModel, Feature>().ForMember(x => x.Active, opt => opt.Ignore()).ForMember(x => x.Price, opt => opt.Ignore());
        }

    }
}