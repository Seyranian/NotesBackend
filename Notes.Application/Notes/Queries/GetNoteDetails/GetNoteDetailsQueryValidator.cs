using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidator()
        {
                RuleFor(getNote => getNote.Id).NotEqual(Guid.Empty);
                RuleFor(getNote => getNote.UserId).NotEqual(Guid.Empty);
        }
    }
}
