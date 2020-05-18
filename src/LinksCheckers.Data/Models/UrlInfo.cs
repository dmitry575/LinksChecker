
using System;
using LinksCheckers.Data.Enums;

namespace LinksCheckers.Data.Models
{
    /// <summary>
    /// Information about url need checking
    /// </summary>
    public class UrlInfo
    {
        /// <summary>
        /// Id item
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Absolute url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Date added to database
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Current status process cheking url
        /// </summary>
        public UrlCheckStatus Status { get; set; }

        /// <summary>
        /// Date finished checking
        /// </summary>
        public DateTime DateChecked { get; set; }

        /// <summary>
        /// HTTP response
        /// </summary>
        public int HttpResponse { get; set; }
    }
}
