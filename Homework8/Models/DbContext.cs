namespace Homework8.Models
{
    public class DbContext
    {
        internal JsonRepository<BirthdayModel> BirthdayRepository;
        internal JsonRepository<NoteModel> NoteRepository;
    }
}
