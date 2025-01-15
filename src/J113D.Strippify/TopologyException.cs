using System;

namespace J113D.Strippify
{
	/// <summary>
	/// Gets raised when certain 3D topology rules are ignored and/or not processable
	/// </summary>
	public class TopologyException : Exception
	{
		/// <summary>
		/// Creates a new topology exception.
		/// </summary>
		/// <param name="message">The message to pass along.</param>
		public TopologyException(string? message) : base(message) { }
	}
}
