using System.Collections;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class Enumerable : ArrayList
	{
		/// <summary>
		/// 
		/// </summary>
		public Enumerable()
		{

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="c"></param>
		public Enumerable(ICollection c) : base(c)
		{

		}
	}
}