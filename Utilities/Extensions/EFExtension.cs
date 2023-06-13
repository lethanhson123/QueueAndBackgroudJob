using System.Reflection;

namespace Utilities.Extensions
{
	public static class EFExtension
	{
		public static string EFToString(this object obj, List<string> fieldstoexclude)
		{
			string res = "";
			foreach (PropertyInfo p in obj.GetType().GetProperties())
			{
				if (!fieldstoexclude.Exists(o => o.ToLower().Equals(p.Name.ToLower())))
				{
					res = string.Concat(res, " ", obj.GetType().GetProperty(p.Name).GetValue(obj));
				}
			}
			return res;
		}
	}
}
