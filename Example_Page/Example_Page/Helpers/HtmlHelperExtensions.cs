using System.Web;
using System.Web.Mvc;

namespace Example_Page
{
    public static class HtmlHelperExtensions
    {
        public static string profilePicture = @"<img src='/Content/Profile.jpg' style='width: 150px; height: 150px'/>";
        public static HtmlString profilePictureHtml = new HtmlString(@"<img src='/Content/Profile.jpg' style='width: 150px; height: 150px'/>");

        public static IHtmlString ProfilePicture(this HtmlHelper helper)
        {
            return new HtmlString(@"<img src='/Content/Profile.jpg' style='width: 150px; height: 150px'/>");
        }

        /// <param name="helper"></param>
        /// <param name="source">Image source</param>
        /// <param name="width">Width in pixels</param>
        /// <param name="height">Height in pixels</param>
        /// <returns>HtmlString</returns>
        public static IHtmlString Image(this HtmlHelper helper, string source, int width, int height)
        {
            return new HtmlString($"<img src='{source}' style='width: {width}px; height: {height}px'/>");
        }
    }
}