using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FB6")]
public class EntryCheckBoxListData : EntryDataBase
{
	[Token(Token = "0x2000FB7")]
	public class EntryCheckBoxData
	{
		[Token(Token = "0x400AA74")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x400AA75")]
		[FieldOffset(Offset = "0x18")]
		public bool isOn;

		[Token(Token = "0x400AA76")]
		[FieldOffset(Offset = "0x19")]
		public bool interactive;

		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0xA6ABE0", Offset = "0xA69DE0", VA = "0x180A6ABE0")]
		public EntryCheckBoxData(string text, bool isOn = false, bool interactive = true)
		{
		}
	}

	[Token(Token = "0x400AA71")]
	[FieldOffset(Offset = "0x18")]
	public List<EntryCheckBoxData> checkBoxList;

	[Token(Token = "0x400AA72")]
	[FieldOffset(Offset = "0x20")]
	public Action<List<bool>> callback;

	[Token(Token = "0x400AA73")]
	[FieldOffset(Offset = "0x28")]
	public bool isEnableMulti;

	[Token(Token = "0x17000F00")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F58")]
		[Address(RVA = "0x577DA0", Offset = "0x576FA0", VA = "0x180577DA0", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F59")]
	[Address(RVA = "0xA6AC40", Offset = "0xA69E40", VA = "0x180A6AC40")]
	public EntryCheckBoxListData(List<EntryCheckBoxData> checkBoxList, Action<List<bool>> callback, bool isEnableMulti = true)
	{
	}
}
