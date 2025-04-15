using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Application.Common.Exceptions;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandHandler : IRequestHandler<UpdateNoteCommand>
    {
        private readonly INoteDbContext _context;
        public UpdateNoteCommandHandler(INoteDbContext context)
            => _context = context;

        public async Task Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
        {
           var entity = await _context.Notes.FirstOrDefaultAsync(n => 
                    n.Id == request.Id,cancellationToken);

            if (entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Note),request.Id);
            } 

            entity.Title = request.Title;
            entity.Details = request.Details;
            entity.EditDate = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
