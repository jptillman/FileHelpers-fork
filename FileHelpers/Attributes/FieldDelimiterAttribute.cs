

using System;

namespace FileHelpers
{
	/// <summary>Indicates a different delimiter for this field. </summary>
	/// <remarks>See the <a href="attributes.html">complete attributes list</a> for more information and examples of each one.</remarks>
	/// <seealso href="attributes.html">Attributes list</seealso>
	/// <seealso href="quick_start.html">Quick start guide</seealso>
	/// <seealso href="examples.html">Examples of use</seealso>
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class FieldDelimiterAttribute : FieldAttribute
	{
	    /// <summary>Indicates a different delimiter for this field. </summary>
		/// <param name="separator">The separator string used to split the fields of the record.</param>
		public FieldDelimiterAttribute(string separator)
		{
			if (separator == null || separator.Length == 0)
				throw new BadUsageException("The separator parameter of the FieldDelimiter attribute can't be null or empty");
			else
				this.Delimiter = separator;
		}

        /// <summary>
        /// The Delimiter for this field
        /// </summary>
	    public string Delimiter { get; private set; }
	}
}