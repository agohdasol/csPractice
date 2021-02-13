using System.Collections.Generic;

namespace DotNetNote.Models
{
  public interface INoteRepository
  {
    void Add(Note model);
    int DeleteNote(int id, string password);
    List<Note> GetAll(int page);
    int GetCountAll();
    int GetCountBySearch(string searchField, string searchQuery);
    string GetFileNameById(int id);
    Note GetNoteById(int id);
    List<Note> GetSearchAll(int page, string searchField, string searchQuery);
    void ReplyNote(Note model);
    void UpdateDownCount(string fileName);
    void UpdateDownCountById(int id);
    int UpdateNote(Note model);

    List<Note> GetRecentPosts();
    List<Note> GetNewPhotos();
    List<Note> GetNoteSummaryByCategory(string categort);

    void Pinned(int id);
  }
}
