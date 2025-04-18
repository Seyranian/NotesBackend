using System.Runtime.InteropServices.ObjectiveC;
using FluentValidation;
namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(unc => unc.Id).NotEqual(Guid.Empty);
            RuleFor(unc => unc.UserId).NotEqual(Guid.Empty);
            RuleFor(unc => unc.Title).NotEmpty()
                .MaximumLength(250);
        }
    }
}
