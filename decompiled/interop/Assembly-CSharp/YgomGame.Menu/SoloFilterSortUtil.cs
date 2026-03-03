using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001177")]
public class SoloFilterSortUtil
{
	[Token(Token = "0x2001178")]
	[Flags]
	public enum GateFilter
	{
		[Token(Token = "0x400B75A")]
		NONE = 1,
		[Token(Token = "0x400B75B")]
		NOT_CLEAR = 2,
		[Token(Token = "0x400B75C")]
		CLEAR = 4,
		[Token(Token = "0x400B75D")]
		COMPLETE = 8
	}

	[Token(Token = "0x2001179")]
	public enum GateSort
	{
		[Token(Token = "0x400B75F")]
		ASC_DEFAULT = 1,
		[Token(Token = "0x400B760")]
		DESC_DEFAULT,
		[Token(Token = "0x400B761")]
		ASC_RECENT_RELEASE,
		[Token(Token = "0x400B762")]
		DESC_RECENT_RELEASE,
		[Token(Token = "0x400B763")]
		ASC_RECENT_PLAY,
		[Token(Token = "0x400B764")]
		DESC_RECENT_PLAY
	}

	[Token(Token = "0x400B753")]
	private const string PATH_SOLO_SAVE = "SoloSave230";

	[Token(Token = "0x400B754")]
	private const string PATH_SOLO_SAVE_OLD = "SoloSave";

	[Token(Token = "0x400B755")]
	public const string KEY_STORY_SAVE = "SoloStory";

	[Token(Token = "0x400B756")]
	public const string KEY_TRAINING_SAVE = "SoloTraining";

	[Token(Token = "0x400B757")]
	private const string KEY_FILTER = "Filter";

	[Token(Token = "0x400B758")]
	private const string KEY_SORT = "Sort";

	[Token(Token = "0x6006D7D")]
	[Address(RVA = "0xB51D10", Offset = "0xB50F10", VA = "0x180B51D10")]
	public static void SaveFilterSort(GateFilter gateFilter, GateSort gateSort, string category, Dictionary<string, object> filterSortDic)
	{
	}

	[Token(Token = "0x6006D7E")]
	[Address(RVA = "0xB517B0", Offset = "0xB509B0", VA = "0x180B517B0")]
	public static (GateFilter, GateSort) LoadFilterSort(string category, out Dictionary<string, object> filterSortDic)
	{
		return default((GateFilter, GateSort));
	}

	[Token(Token = "0x6006D7F")]
	[Address(RVA = "0xB51460", Offset = "0xB50660", VA = "0x180B51460")]
	private static (GateFilter, GateSort) FilterSortDicToTapple(Dictionary<string, object> dic)
	{
		return default((GateFilter, GateSort));
	}

	[Token(Token = "0x6006D80")]
	[Address(RVA = "0xB513E0", Offset = "0xB505E0", VA = "0x180B513E0")]
	private static byte[] DictionaryToLZ4(Dictionary<string, object> dic)
	{
		return null;
	}

	[Token(Token = "0x6006D81")]
	[Address(RVA = "0xB51640", Offset = "0xB50840", VA = "0x180B51640")]
	private static Dictionary<string, object> LZ4ToDictionary(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6006D82")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SoloFilterSortUtil()
	{
	}
}
