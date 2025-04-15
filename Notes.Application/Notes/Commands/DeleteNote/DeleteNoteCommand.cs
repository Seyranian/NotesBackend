using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;

namespace Notes.Application.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
