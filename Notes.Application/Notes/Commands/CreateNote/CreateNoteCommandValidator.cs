using FluentValidation;

namespace Notes.Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator()
        {
            RuleFor(cnc => cnc.Title)
                .NotEmpty()
                .MaximumLength(250);
            RuleFor(cnc => cnc.UserId)
                .NotEqual(Guid.Empty);
        }
    }
}
