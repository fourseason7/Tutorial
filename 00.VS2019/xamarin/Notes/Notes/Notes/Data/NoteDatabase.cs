using Notes.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Data
{
  public class NoteDatabase
  {
    readonly SQLiteAsyncConnection database;

    public NoteDatabase(string dbPath)
    {
      database = new SQLiteAsyncConnection(dbPath);
      database.CreateTableAsync<Note>().Wait();
    }

    public Task<List<Note>> GetNotesAsync()
    {
      // get all notes.
      return database.Table<Note>().ToListAsync();
    }

    public Task<Note> GetNoteAsync(int id)
    {
      // get a specfic note
      return database.Table<Note>()
        .Where(i => i.ID == id)
        .FirstOrDefaultAsync()
        ;
    }

    public Task<int> SaveNoteAsync(Note note)
    {
      if (note.ID != 0)
      {
        // update an existing note
        return database.UpdateAsync(note);
      }
      else
      {
        // save a new note
        return database.InsertAsync(note);
      }
    }

    public Task<int> DeleteNoteAsync(Note note)
    {
      // delete a note
      return database.DeleteAsync(note);
    }
  }
}
