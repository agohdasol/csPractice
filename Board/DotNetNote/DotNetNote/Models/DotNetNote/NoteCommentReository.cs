using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace DotNetNote.Models
{
  public class NoteCommentRepository:INoteCommentRepository
  {
    private string _connectionString;
    private SqlConnection con;

    public NoteCommentRepository(string connectionString)
    {
      _connectionString = connectionString;
      con = new SqlConnection(_connectionString);
    }
    public void AddNoteComment(NoteComment model)
    {
      var parameters = new DynamicParameters();
      parameters.Add("@BoardId", value: model.BoardId, dbType: DbType.Int32);
      parameters.Add("@Name", value: model.Name, dbType: DbType.String);
      parameters.Add("@Opinion", value: model.Opinion, dbType: DbType.String);
      parameters.Add("@Password", value: model.Password, dbType: DbType.String);

      string sql = @"
        Insert Into NoteComments (BoardId, Name, Opinion, Password)
        Values(@BoardId, @Name, @Opinion, @Password);
        Update Notes Set CommentCount = CommentCount + 1
        Where Id = @BoardId
      ";

      con.Execute(sql, parameters, commandType: CommandType.Text);
    }
    public List<NoteComment> GetNoteComments(int boardId)
    {
      return con.Query<NoteComment>("Select * From NoteComments Where BoardId = @BoardId"
        , new { BoardId = boardId }
        , commandType: CommandType.Text).ToList();
    }
    public int GetCountBy(int boardId, int id, string password)
    {
      return con.Query<int>(@"Select Count(*) From NoteComments 
        Where BoardId = @BoardId And Id = @Id And Password = @Password"
        , new { BoardId = boardId, Id = id, Password = password }
        , commandType: CommandType.Text).SingleOrDefault();
    }
    public int DeleteNoteComment(int boardId, int id, string password)
    {
      return con.Execute(@"Delete NoteComments
        Where BoardId = @BoardId And Id = @Id And Password = @Password;
        Update Notes Set ComentCount = CommentCount - 1
        Where Id = @BoardId"
        , new { BoardId = boardId, Id = id, Password = password }
        , commandType: CommandType.Text);
      //쿼리 마지막 부분 Where BoardId = @BoardId 아닌지?
    }
    public List<NoteComment> GetRecentComments()
    {
      string sql = @"SELECT TOP 3 Id, BoardId, Opinion, PostDate 
        FROM NoteComments Order By Id Desc";
      return con.Query<NoteComment>(sql).ToList();
    }
  }
}
