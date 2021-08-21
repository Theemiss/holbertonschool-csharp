using System;
/// <summary>
/// class obj
/// </summary>
public class Obj
{
	/// <summary>
    /// return if obj is int or no
    /// </summary>
    /// <param name="obj"> obj to check</param>
    /// <returns>True or False</returns>
	public static bool IsOfTypeInt(object obj)
	{
		if (obj is int)
		{
			return true;
		}
		else
			return false;
	}
}
