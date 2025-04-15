﻿using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class NoteLookUpDto : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note,NoteLookUpDto>()
                .ForMember(dto => dto.Id,
                    opt => opt.MapFrom(note => note.Id))
                .ForMember(dto => dto.Title,
                    opt => opt.MapFrom(note => note.Title));
        }
    }
}
