using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_AllTopics_with_WebGentle.Models
{
    public static class CustomHelper
    {
        // with static method
        public static IHtmlString Image(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src = '{0}'  alt = '{1}' ></ img > ", src, alt));
        }
        // with extension method
        public static IHtmlString Img(this HtmlHelper helper, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src = '{0}'  alt = '{1}' ></ img > ", src, alt));
        }
        // without html tag
        public static IHtmlString File(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tagBuilder = new TagBuilder("img");
            tagBuilder.Attributes.Add("src", src);
            tagBuilder.Attributes.Add("alt", alt);
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}