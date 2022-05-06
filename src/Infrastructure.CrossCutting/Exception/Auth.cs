using System;

namespace Infrastructure.CrossCutting.Exception
{
    /// <summary>
    /// The issued access token has expired
    /// </summary>
    public class ExpiredAccessTokenException : UnauthorizedAccessException
    {
    }

    /// <summary>
    /// Failure occurs when attempt to authenticate user with given credentials
    /// </summary>
    public class FailAuthenticationAttemptException : UnauthorizedAccessException
    {
        public FailAuthenticationAttemptException(string message = "Failed to authenticate") : base(message)
        {
        }
    }
}