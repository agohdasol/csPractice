using System.Collections.Generic;

namespace DotNetNote.Models
{
  public class NoteCommentViewModel
  {
    public List<NoteComment> NoteCommentList { get; set; }
    public int BoardId { get; set; }
  }
}
