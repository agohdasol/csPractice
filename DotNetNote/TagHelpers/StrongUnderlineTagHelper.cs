using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace DotNetNote.TagHelpers
{
  public class StrongUnderlineTagHelper:TagHelper
  {
    public override async Task ProcessAsync(TagHelperContext context,TagHelperOutput output)
    {
      string origin = (await output.GetChildContentAsync()).GetContent();

      string result = $"<u>{origin}</u>";

      output.TagName = "strong";

      output.Content.AppendHtml(result);
    }
  }
}
