using System.Runtime.CompilerServices;
using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.CreateNote;

namespace Notes.WebApi.Models
{
    public class CreateNoteDto : IMapWith<CreateNoteCommand>
    {
        public string Title { get; set; } =string.Empty;
        public string Details { get; set; } = string.Empty;
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateNoteDto, CreateNoteCommand>()
                .ForMember(nc => nc.Title,
                    opt => opt.MapFrom(dto => dto.Title))
                .ForMember(nc => nc.Details,
                    opt => opt.MapFrom(dto => dto.Details));
        }
    }
}
