using AutoMapper;
using ExpressionTreePresentation.Business.Objects;

namespace ExpressionTreePresentation.Models
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
            : base()
        {
            CreateMap<Video, VideoDto>()
                .ForMember(d => d.ChannelTitle, opt => opt.MapFrom(src => src.ChannelName));
        }
    }
}
