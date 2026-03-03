using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C7C")]
public class MDMarkupContentCustomBoardPageHandler : IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId, IMDMarkupSourceRequireTextData
{
	[Token(Token = "0x4009B2B")]
	[FieldOffset(Offset = "0x10")]
	public int startIdx;

	[Token(Token = "0x4009B2C")]
	[FieldOffset(Offset = "0x14")]
	public int length;

	[Token(Token = "0x4009B2D")]
	[FieldOffset(Offset = "0x18")]
	public string title;

	[Token(Token = "0x4009B2E")]
	[FieldOffset(Offset = "0x20")]
	public Func<int, object> onCreatePageMMAContainerFunc;

	[Token(Token = "0x4009B2F")]
	[FieldOffset(Offset = "0x28")]
	public Action<MDMarkupBoardPagerContainerWidget.Context, int> onUpdatePageCallback;

	[Token(Token = "0x17000A4F")]
	public MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x937170", Offset = "0x936370", VA = "0x180937170", Slot = "4")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A50")]
	public int contentIndent
	{
		[Token(Token = "0x6004B91")]
		[Address(RVA = "0x937160", Offset = "0x936360", VA = "0x180937160", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A51")]
	public bool isValidData
	{
		[Token(Token = "0x6004B92")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A52")]
	public string id
	{
		[Token(Token = "0x6004B93")]
		[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A53")]
	public TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400006E")]
	public event Action<int, bool> onFocusPageEvent
	{
		[Token(Token = "0x6004B94")]
		[Address(RVA = "0x9370B0", Offset = "0x9362B0", VA = "0x1809370B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x937180", Offset = "0x936380", VA = "0x180937180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004B98")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520", Slot = "13")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004B99")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	public void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004B9A")]
	[Address(RVA = "0x937050", Offset = "0x936250", VA = "0x180937050")]
	public void InvokeOnFocusPageEvent(int idx, bool isFirst)
	{
	}

	[Token(Token = "0x6004B9B")]
	[Address(RVA = "0x936FF0", Offset = "0x9361F0", VA = "0x180936FF0", Slot = "7")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004B9C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004B9D")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0", Slot = "6")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x6004B9E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public void SetArgs(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004B9F")]
	[Address(RVA = "0x937070", Offset = "0x936270", VA = "0x180937070")]
	public MDMarkupContentCustomBoardPageHandler()
	{
	}
}
