﻿using Notes.Persistence;

namespace Notes.Tests.Common
{
    public class TestCommandBase : IDisposable
    {
        protected readonly NoteDbContext Context;
        public TestCommandBase()
        {
            Context = NotesContextFactory.Create();
        }
        public void Dispose()
        {
            NotesContextFactory.Destroy(Context);
        }
    }
}
