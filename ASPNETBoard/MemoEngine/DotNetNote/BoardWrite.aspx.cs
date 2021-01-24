using System;
using DotNetNote.Models;

namespace MemoEngine.DotNetNote
{
  public partial class BoardWrite : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      CtlBoardEditorFormControl.FormType = BoardWriteFormType.Write;
    }
  }
}