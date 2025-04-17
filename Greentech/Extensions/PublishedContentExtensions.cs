using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Greentech.Extensions
{
    public static class PublishedContentExtensions
    {
        public static HomePage? GetHomePage(this IPublishedContent publishedContent)
        {
            return publishedContent.AncestorOrSelf<HomePage>();
        }

        public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent)
        {
            var homePage = GetHomePage(publishedContent);
            if (homePage == null) return null;
            return homePage.FirstChild<SiteSettings>();
        }

        public static string GetMetaTitleOrName(this IPublishedContent publishedContent, string? metaTitle)
        {
            if(!string.IsNullOrWhiteSpace(metaTitle)) return metaTitle;

            return publishedContent.Name;
        }

        public static string? GetSiteName(this IPublishedContent publishedContent)
        {
            var homePage = publishedContent.GetHomePage();
            if (homePage is null) return null;
            var siteSettings = homePage.GetSiteSettings();
            if(siteSettings is null) return null;
            return siteSettings.SiteName ?? null;
        }

    }
}
