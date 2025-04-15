using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.UpdateNote;

namespace Notes.WebApi.Models
{
    public class UpdateNoteDto : IMapWith<UpdateNoteCommand>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateNoteDto, UpdateNoteCommand>()
               .ForMember(nu => nu.Title,
                   opt => opt.MapFrom(dto => dto.Title))
               .ForMember(nu => nu.Details,
                   opt => opt.MapFrom(dto => dto.Details))
               .ForMember(nu => nu.Id,
                   opt => opt.MapFrom(dto => dto.Id));
        }
    }
}
