using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x2000414")]
public sealed class TextData
{
	[Token(Token = "0x2000415")]
	internal class TextGroup
	{
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x10")]
		private int refCount;

		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x18")]
		private string type;

		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x20")]
		private string resourcePath;

		[Token(Token = "0x400142D")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> texts;

		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x30")]
		private bool scrambling;

		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isDone;

		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0x32")]
		private bool m_isError;

		[Token(Token = "0x4001431")]
		[FieldOffset(Offset = "0x0")]
		private static Regex reg;

		[Token(Token = "0x4001432")]
		[FieldOffset(Offset = "0x34")]
		private int SaftyRecursiveCheck;

		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x5F0390", Offset = "0x5EF590", VA = "0x1805F0390")]
		internal string getResourcePath(string typename)
		{
			return null;
		}

		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x5F00F0", Offset = "0x5EF2F0", VA = "0x1805F00F0")]
		public TextGroup(string tp, bool async = false)
		{
		}

		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x5F01F0", Offset = "0x5EF3F0", VA = "0x1805F01F0")]
		public TextGroup(Type tp, bool async = false)
		{
		}

		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x5EFF90", Offset = "0x5EF190", VA = "0x1805EFF90")]
		public void Reload()
		{
		}

		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x5F0320", Offset = "0x5EF520", VA = "0x1805F0320")]
		public void addRef()
		{
		}

		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x5F0330", Offset = "0x5EF530", VA = "0x1805F0330")]
		public bool delRef()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		public int getRef()
		{
			return default(int);
		}

		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		public bool isDone()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x5F0800", Offset = "0x5EFA00", VA = "0x1805F0800")]
		public bool isError()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x5EFF50", Offset = "0x5EF150", VA = "0x1805EFF50")]
		private void LoadRequestCompleteHandler(string path)
		{
		}

		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x5F0460", Offset = "0x5EF660", VA = "0x1805F0460")]
		private void initProc()
		{
		}

		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x5EFB50", Offset = "0x5EED50", VA = "0x1805EFB50")]
		public bool ContainsText(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x5EFC00", Offset = "0x5EEE00", VA = "0x1805EFC00")]
		public string GetText(string name, bool richTextEx)
		{
			return null;
		}
	}

	[Token(Token = "0x4001427")]
	[FieldOffset(Offset = "0x0")]
	private static string s_lang;

	[Token(Token = "0x4001428")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, TextGroup> s_text;

	[Token(Token = "0x4001429")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, string> s_replace;

	[Token(Token = "0x6001A3F")]
	public static void Load<T>()
	{
	}

	[Token(Token = "0x6001A40")]
	public static void LoadAsync<T>()
	{
	}

	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x5E0650", Offset = "0x5DF850", VA = "0x1805E0650")]
	public static void Load(string groupid)
	{
	}

	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x5E0180", Offset = "0x5DF380", VA = "0x1805E0180")]
	public static void LoadAsync(string groupid)
	{
	}

	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x5E04D0", Offset = "0x5DF6D0", VA = "0x1805E04D0")]
	private static void LoadGroup(string group)
	{
	}

	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x5E0350", Offset = "0x5DF550", VA = "0x1805E0350")]
	private static void LoadGroupAsync(string group)
	{
	}

	[Token(Token = "0x6001A45")]
	public static void Unload<T>()
	{
	}

	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x5E1210", Offset = "0x5E0410", VA = "0x1805E1210")]
	public static void Unload(string groupid)
	{
	}

	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x5E10D0", Offset = "0x5E02D0", VA = "0x1805E10D0")]
	private static void UnloadGroup(string group)
	{
	}

	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x5E0E20", Offset = "0x5E0020", VA = "0x1805E0E20")]
	public static void Reload()
	{
	}

	[Token(Token = "0x6001A49")]
	public static void Reload<T>()
	{
	}

	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x5E0D40", Offset = "0x5DFF40", VA = "0x1805E0D40")]
	private static void ReloadGroup(string group)
	{
	}

	[Token(Token = "0x6001A4B")]
	public static bool IsLoad<T>()
	{
		return default(bool);
	}

	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x5DFFB0", Offset = "0x5DF1B0", VA = "0x1805DFFB0")]
	public static bool IsLoad(Type tp)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x5E0060", Offset = "0x5DF260", VA = "0x1805E0060")]
	public static bool IsLoad(string groupid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A4E")]
	public static int GetRefCount<T>()
	{
		return default(int);
	}

	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0x5DF660", Offset = "0x5DE860", VA = "0x1805DF660")]
	public static int GetRefCount(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x6001A50")]
	[Address(RVA = "0x5DF7B0", Offset = "0x5DE9B0", VA = "0x1805DF7B0")]
	public static int GetRefCount(string groupid)
	{
		return default(int);
	}

	[Token(Token = "0x6001A51")]
	public static bool IsDone<T>()
	{
		return default(bool);
	}

	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x5DFA90", Offset = "0x5DEC90", VA = "0x1805DFA90")]
	public static bool IsDoneWithName(string fullTextId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x5DFDA0", Offset = "0x5DEFA0", VA = "0x1805DFDA0")]
	public static bool IsErrorWithName(string fullTextId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x5DF990", Offset = "0x5DEB90", VA = "0x1805DF990")]
	public static bool IsDoneWithGroup(string groupId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x5DFCA0", Offset = "0x5DEEA0", VA = "0x1805DFCA0")]
	public static bool IsErrorWithGroup(string groupId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x5E0110", Offset = "0x5DF310", VA = "0x1805E0110")]
	public static bool IsTextId(string fullTextId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A57")]
	public static string EnumToFullTextId<T>(T textEnum)
	{
		return null;
	}

	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x5E0AD0", Offset = "0x5DFCD0", VA = "0x1805E0AD0")]
	public static bool ParseTextId(string fullTextId, out string groupId, out string textId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A59")]
	[Address(RVA = "0x5E09B0", Offset = "0x5DFBB0", VA = "0x1805E09B0")]
	public static bool ParseTextId2(string fullTextId, out string groupId, out string textId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A5A")]
	[Address(RVA = "0x5E0820", Offset = "0x5DFA20", VA = "0x1805E0820")]
	public static string MakeGroupId(string groupId)
	{
		return null;
	}

	[Token(Token = "0x6001A5B")]
	[Address(RVA = "0x5E0940", Offset = "0x5DFB40", VA = "0x1805E0940")]
	public static string MakeTextId(string groupId, string textId)
	{
		return null;
	}

	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x5E0860", Offset = "0x5DFA60", VA = "0x1805E0860")]
	public static string MakeTextId(string textId)
	{
		return null;
	}

	[Token(Token = "0x6001A5D")]
	public static bool ContainsText<T>(T TextEnum)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A5E")]
	public static string GetText<T>(T TextEnum, bool richTextEx = false)
	{
		return null;
	}

	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x5E1040", Offset = "0x5E0240", VA = "0x1805E1040")]
	public static void SetReplaceText(string label, string text)
	{
	}

	[Token(Token = "0x6001A60")]
	[Address(RVA = "0x5DF8B0", Offset = "0x5DEAB0", VA = "0x1805DF8B0")]
	public static string GetReplaceText(string label)
	{
		return null;
	}

	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x5E0BF0", Offset = "0x5DFDF0", VA = "0x1805E0BF0")]
	public static void ReloadAllText()
	{
	}

	[Token(Token = "0x6001A62")]
	[Address(RVA = "0x5E0F70", Offset = "0x5E0170", VA = "0x1805E0F70")]
	public static void SetLanguage(string lang, bool forceReload = false)
	{
	}

	[Token(Token = "0x6001A63")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TextData()
	{
	}
}
