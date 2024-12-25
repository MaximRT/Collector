using Application.Dto;
using AutoMapper;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<FrameDto,ImageAnalysisRequestDto>();
    }
}   