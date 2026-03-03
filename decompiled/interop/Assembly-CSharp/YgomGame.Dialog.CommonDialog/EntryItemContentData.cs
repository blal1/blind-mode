using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FBB")]
public class EntryItemContentData : EntryDataBase
{
	[Token(Token = "0x400AA81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isPeriod;

	[Token(Token = "0x400AA82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int itemCategory;

	[Token(Token = "0x400AA83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int itemId;

	[Token(Token = "0x400AA84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x400AA85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool effect;

	[Token(Token = "0x400AA86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string spItemProductLabel;

	[Token(Token = "0x400AA87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Dictionary<string, object> itemArgs;

	[Token(Token = "0x400AA88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string additionalButtonLabel;

	[Token(Token = "0x400AA89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action additionalButtonCallback;

	[Token(Token = "0x400AA8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool hideItemCategory;

	[Token(Token = "0x17000F04")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F64")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public EntryItemContentData()
	{
	}

	[Token(Token = "0x6005F65")]
	[Address(RVA = "0xA6AE00", Offset = "0xA6A000", VA = "0x180A6AE00")]
	public EntryItemContentData(bool isPeriod, int itemCategory, int itemId, [Optional] string text, bool effect = false, [Optional] Dictionary<string, object> itemArgs, [Optional] string additionalButtonLabel, [Optional] Action additionalButtonCallback)
	{
	}
}
