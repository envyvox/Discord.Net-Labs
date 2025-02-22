using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord
{
    /// <summary>
    ///     Represents a thread channel inside of a guild.
    /// </summary>
    public interface IThreadChannel : ITextChannel, IGuildChannel
    {
        /// <summary>
        ///     Gets the type of the current thread channel.
        /// </summary>
        ThreadType Type { get; }

        /// <summary>
        ///     <see langword="true"/> if the current user has joined this thread, otherwise <see langword="false"/>.
        /// </summary>
        bool Joined { get; }

        /// <summary>
        ///     <see langword="true"/> if the current thread is archived, otherwise <see langword="false"/>.
        /// </summary>
        bool Archived { get; }

        /// <summary>
        ///     Duration to automatically archive the thread after recent activity.
        /// </summary>
        ThreadArchiveDuration AutoArchiveDuration { get; }

        /// <summary>
        ///     Timestamp when the thread's archive status was last changed, used for calculating recent activity.
        /// </summary>
        DateTimeOffset ArchiveTimestamp { get; }

        /// <summary>
        ///     <see langword="true"/> if the current thread is locked, otherwise <see langword="false"/>
        /// </summary>
        bool Locked { get; }

        /// <summary>
        ///     An approximate count of users in a thread, stops counting at 50.
        /// </summary>
        int MemberCount { get; }

        /// <summary>
        ///     An approximate count of messages in a thread, stops counting at 50.
        /// </summary>
        int MessageCount { get; }

        /// <summary>
        ///     Joins the current thread.
        /// </summary>
        /// <param name="options">The options to be used when sending the request.</param>
        /// <returns>
        ///     A task that represents the asynchronous join operation. 
        /// </returns>
        Task JoinAsync(RequestOptions options = null);

        /// <summary>
        ///     Leaves the current thread.
        /// </summary>
        /// <param name="options">The options to be used when sending the request.</param>
        /// <returns>
        ///     A task that represents the asynchronous leave operation. 
        /// </returns>
        Task LeaveAsync(RequestOptions options = null);

        /// <summary>
        ///     Adds a user to this thread.
        /// </summary>
        /// <param name="user">The <see cref="IGuildUser"/> to add.</param>
        /// <param name="options">The options to be used when sending the request.</param>
        /// <returns>
        ///     A task that represents the asynchronous operation of adding a member to a thread. 
        /// </returns>
        Task AddUserAsync(IGuildUser user, RequestOptions options = null);

        /// <summary>
        ///     Removes a user from this thread.
        /// </summary>
        /// <param name="user">The <see cref="IGuildUser"/> to remove from this thread.</param>
        /// <param name="options">The options to be used when sending the request.</param>
        /// <returns>
        ///     A task that represents the asynchronous operation of removing a user from this thread. 
        /// </returns>
        Task RemoveUserAsync(IGuildUser user, RequestOptions options = null);
    }
}
