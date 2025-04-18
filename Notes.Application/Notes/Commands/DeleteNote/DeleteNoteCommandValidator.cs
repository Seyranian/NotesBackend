using FluentValidation;

namespace Notes.Application.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommandValidator : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidator()
        {
            RuleFor(dnc => dnc.Id).NotEqual(Guid.Empty);
            RuleFor(dnc => dnc.UserId).NotEqual(Guid.Empty);
        }
    }
}
