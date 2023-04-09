using System.Linq;

namespace Z_Link
{
	internal static class QuickFunctions
	{
		public static bool In(this object value, params object[] values)
		{
			return values.Contains(value);
		}
	}
}
