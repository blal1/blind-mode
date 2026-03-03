using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003BC")]
public static class ClientWork
{
	[Token(Token = "0x20003BD")]
	private struct UpdateInfo
	{
		[Token(Token = "0x40012C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string path;

		[Token(Token = "0x40012C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public object data;

		[Token(Token = "0x600168B")]
		[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
		public UpdateInfo(string updatePath, object updateData)
		{
		}
	}

	[Token(Token = "0x20003BE")]
	public delegate void NotyfyEventHandler(object v);

	[Token(Token = "0x20003BF")]
	public class notyfyEvent
	{
		[Token(Token = "0x40012C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<string, notyfyEvent> entry;

		[Token(Token = "0x40012C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool dirty;

		[Token(Token = "0x40012C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool modify;

		[Token(Token = "0x14000016")]
		public event NotyfyEventHandler handler
		{
			[Token(Token = "0x6001690")]
			[Address(RVA = "0x5C4290", Offset = "0x5C3490", VA = "0x1805C4290")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001691")]
			[Address(RVA = "0x5C47B0", Offset = "0x5C39B0", VA = "0x1805C47B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6001692")]
		[Address(RVA = "0x5C4210", Offset = "0x5C3410", VA = "0x1805C4210")]
		public notyfyEvent()
		{
		}

		[Token(Token = "0x6001693")]
		[Address(RVA = "0x5C4330", Offset = "0x5C3530", VA = "0x1805C4330")]
		public void callHandle(Dictionary<string, object> dic)
		{
		}

		[Token(Token = "0x6001694")]
		[Address(RVA = "0x5C43A0", Offset = "0x5C35A0", VA = "0x1805C43A0")]
		public void notyfyDirty(object val)
		{
		}

		[Token(Token = "0x6001695")]
		[Address(RVA = "0x5C4390", Offset = "0x5C3590", VA = "0x1805C4390")]
		public bool isLeaf()
		{
			return default(bool);
		}

		[Token(Token = "0x6001696")]
		[Address(RVA = "0x5C4350", Offset = "0x5C3550", VA = "0x1805C4350")]
		public int getLeafCount()
		{
			return default(int);
		}
	}

	[Token(Token = "0x40012BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_revision;

	[Token(Token = "0x40012BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, object> s_data;

	[Token(Token = "0x40012BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static notyfyEvent s_notyfy;

	[Token(Token = "0x40012BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static SortedDictionary<string, object> s_cache;

	[Token(Token = "0x40012C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static List<UpdateInfo> s_keepUpdateList;

	[Token(Token = "0x40012C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static List<string> s_keepDeleteList;

	[Token(Token = "0x6001669")]
	[Address(RVA = "0x5B62A0", Offset = "0x5B54A0", VA = "0x1805B62A0")]
	public static void ClearData()
	{
	}

	[Token(Token = "0x600166A")]
	[Address(RVA = "0x5B7530", Offset = "0x5B6730", VA = "0x1805B7530")]
	internal static void dirty(object add, notyfyEvent localnotyfy)
	{
	}

	[Token(Token = "0x600166B")]
	[Address(RVA = "0x5B6CE0", Offset = "0x5B5EE0", VA = "0x1805B6CE0")]
	internal static void dirtyDictionary(Dictionary<string, object> dicadd, notyfyEvent localnotyfy)
	{
	}

	[Token(Token = "0x600166C")]
	[Address(RVA = "0x5B72C0", Offset = "0x5B64C0", VA = "0x1805B72C0")]
	internal static void dirtyList(List<object> listadd, notyfyEvent localnotyfy)
	{
	}

	[Token(Token = "0x600166D")]
	[Address(RVA = "0x5B8640", Offset = "0x5B7840", VA = "0x1805B8640")]
	internal static void marge(object dst, object add)
	{
	}

	[Token(Token = "0x600166E")]
	[Address(RVA = "0x5B8010", Offset = "0x5B7210", VA = "0x1805B8010")]
	internal static void margeDictionary(Dictionary<string, object> dicdst, Dictionary<string, object> dicadd)
	{
	}

	[Token(Token = "0x600166F")]
	[Address(RVA = "0x5B83B0", Offset = "0x5B75B0", VA = "0x1805B83B0")]
	internal static void margeList(List<object> listdst, List<object> listadd)
	{
	}

	[Token(Token = "0x6001670")]
	[Address(RVA = "0x5B76B0", Offset = "0x5B68B0", VA = "0x1805B76B0")]
	internal static notyfyEvent findNotificator(string jsonPath)
	{
		return null;
	}

	[Token(Token = "0x6001671")]
	internal static T getTypedByJsonPath<T>(string jsonPath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6001672")]
	[Address(RVA = "0x5B9A50", Offset = "0x5B8C50", VA = "0x1805B9A50")]
	public static void update(object dict, bool keep = false)
	{
	}

	[Token(Token = "0x6001673")]
	[Address(RVA = "0x5B9490", Offset = "0x5B8690", VA = "0x1805B9490")]
	public static void update(string jsonPath, object dict, bool keep = false)
	{
	}

	[Token(Token = "0x6001674")]
	[Address(RVA = "0x5B8D70", Offset = "0x5B7F70", VA = "0x1805B8D70")]
	public static void updateValue(string jsonPath, object value, bool keep = false)
	{
	}

	[Token(Token = "0x6001675")]
	[Address(RVA = "0x5B88A0", Offset = "0x5B7AA0", VA = "0x1805B88A0")]
	public static void updateJson(string jsonString)
	{
	}

	[Token(Token = "0x6001676")]
	[Address(RVA = "0x5B8950", Offset = "0x5B7B50", VA = "0x1805B8950")]
	public static void updateJson(string jsonPath, string jsonString)
	{
	}

	[Token(Token = "0x6001677")]
	[Address(RVA = "0x5B8A10", Offset = "0x5B7C10", VA = "0x1805B8A10")]
	public static void updateKeep()
	{
	}

	[Token(Token = "0x6001678")]
	[Address(RVA = "0x5B6860", Offset = "0x5B5A60", VA = "0x1805B6860")]
	public static void clearKeep()
	{
	}

	[Token(Token = "0x6001679")]
	[Address(RVA = "0x5B6930", Offset = "0x5B5B30", VA = "0x1805B6930")]
	public static void deleteByJsonPath(string jsonPath, bool keep = false)
	{
	}

	[Token(Token = "0x600167A")]
	[Address(RVA = "0x5B7E70", Offset = "0x5B7070", VA = "0x1805B7E70")]
	public static int getRevision()
	{
		return default(int);
	}

	[Token(Token = "0x600167B")]
	[Address(RVA = "0x5B7A40", Offset = "0x5B6C40", VA = "0x1805B7A40")]
	public static object getByJsonPath(string jsonPath)
	{
		return null;
	}

	[Token(Token = "0x600167C")]
	[Address(RVA = "0x5B7BF0", Offset = "0x5B6DF0", VA = "0x1805B7BF0")]
	public static int getIntByJsonPath(string jsonPath, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x600167D")]
	[Address(RVA = "0x5B7D10", Offset = "0x5B6F10", VA = "0x1805B7D10")]
	public static long getLongByJsonPath(string jsonPath, long defaultValue = 0L)
	{
		return default(long);
	}

	[Token(Token = "0x600167E")]
	[Address(RVA = "0x5B7B40", Offset = "0x5B6D40", VA = "0x1805B7B40")]
	public static float getFloatByJsonPath(string jsonPath, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x600167F")]
	[Address(RVA = "0x5B7EC0", Offset = "0x5B70C0", VA = "0x1805B7EC0")]
	public static string getStringByJsonPath(string jsonPath, string defaultValue = "")
	{
		return null;
	}

	[Token(Token = "0x6001680")]
	[Address(RVA = "0x5B7890", Offset = "0x5B6A90", VA = "0x1805B7890")]
	public static bool getBoolByJsonPath(string jsonPath, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001681")]
	[Address(RVA = "0x5B7AD0", Offset = "0x5B6CD0", VA = "0x1805B7AD0")]
	public static Dictionary<string, object> getDictionaryByJsonPath(string jsonPath, [Optional] Dictionary<string, object> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6001682")]
	[Address(RVA = "0x5B7CA0", Offset = "0x5B6EA0", VA = "0x1805B7CA0")]
	public static List<object> getListByJsonPath(string jsonPath, [Optional] List<object> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6001683")]
	[Address(RVA = "0x5B7DC0", Offset = "0x5B6FC0", VA = "0x1805B7DC0")]
	public static object getObjectByJsonPath(string jsonPath, [Optional] object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6001684")]
	[Address(RVA = "0x5B7900", Offset = "0x5B6B00", VA = "0x1805B7900")]
	public static object getByJsonPathWithCache(string jsonPath)
	{
		return null;
	}

	[Token(Token = "0x6001685")]
	[Address(RVA = "0x5B63E0", Offset = "0x5B55E0", VA = "0x1805B63E0")]
	public static bool ContainsJsonPath(string jsonPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6001686")]
	[Address(RVA = "0x5B6560", Offset = "0x5B5760", VA = "0x1805B6560")]
	public static void SetNotificator(string jsonPath, NotyfyEventHandler handle)
	{
	}

	[Token(Token = "0x6001687")]
	[Address(RVA = "0x5B6480", Offset = "0x5B5680", VA = "0x1805B6480")]
	public static void ResetNotificator(string jsonPath, NotyfyEventHandler handle)
	{
	}

	[Token(Token = "0x6001688")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void DebugDump()
	{
	}

	[Token(Token = "0x6001689")]
	[Address(RVA = "0x5B6430", Offset = "0x5B5630", VA = "0x1805B6430")]
	public static notyfyEvent GetDebugNotyfyEvent(string jsonPath)
	{
		return null;
	}
}
