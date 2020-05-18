
namespace LinksCheckers.Data.Enums
{
    /// <summary>
    /// List status of checking urls
    /// </summary>
    public enum UrlCheckStatus
    {
        /// <summary>
        /// Just add url or default status
        /// </summary>
        None = 0,

        /// <summary>
        /// Now url checking in progress
        /// </summary>
        Checking = 1,

        /// <summary>
        /// Checking finished Success
        /// </summary>
        Success = 2,

        /// <summary>
        /// Checking finished Failed 
        /// </summary>
        Failed = 3
    }
}
