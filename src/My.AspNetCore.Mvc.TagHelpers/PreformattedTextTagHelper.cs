using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace My.AspNetCore.Mvc.TagHelpers
{
    [HtmlTargetElement("pre")]
    public class PreformattedTextTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();
            output.Content.SetHtmlContent(HtmlEncoder.Default.Encode(content.GetContent()));
        }
    }
}
