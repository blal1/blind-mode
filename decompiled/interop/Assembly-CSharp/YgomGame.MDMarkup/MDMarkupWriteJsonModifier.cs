using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000CB0")]
public class MDMarkupWriteJsonModifier : MDMarkupModifierBase, IMDMarkupSourceRequireTextData, IMDMarkupModifierOnLoadComplete, IMDMarkupModifier
{
	[Serializable]
	[Token(Token = "0x2000CB1")]
	public class WriteData
	{
		[Token(Token = "0x4009BD1")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4009BD2")]
		[FieldOffset(Offset = "0x18")]
		public string writePath;

		[Token(Token = "0x4009BD3")]
		[FieldOffset(Offset = "0x20")]
		public string valueFormat;

		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x964ED0", Offset = "0x9640D0", VA = "0x180964ED0")]
		public void ImportJsonObj(object jsonObj)
		{
		}

		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x964DE0", Offset = "0x963FE0", VA = "0x180964DE0")]
		public object ExportJsonObj()
		{
			return null;
		}

		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public WriteData()
		{
		}
	}

	[Token(Token = "0x4009BCF")]
	[FieldOffset(Offset = "0x28")]
	public List<WriteData> writeDatas;

	[Token(Token = "0x4009BD0")]
	[FieldOffset(Offset = "0x30")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x17000AE7")]
	public override MDMarkupDef.ModifierType modifierType
	{
		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "8")]
		get
		{
			return default(MDMarkupDef.ModifierType);
		}
	}

	[Token(Token = "0x6004CF1")]
	[Address(RVA = "0x95D1F0", Offset = "0x95C3F0", VA = "0x18095D1F0", Slot = "9")]
	public override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CF2")]
	[Address(RVA = "0x95CEB0", Offset = "0x95C0B0", VA = "0x18095CEB0", Slot = "10")]
	public override void OnExportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CF3")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0", Slot = "11")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004CF4")]
	[Address(RVA = "0x95CC70", Offset = "0x95BE70", VA = "0x18095CC70", Slot = "12")]
	public bool ModifyOnLoadComplete(IMDMarkupId idContent, Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CF5")]
	[Address(RVA = "0x955FC0", Offset = "0x9551C0", VA = "0x180955FC0")]
	public MDMarkupWriteJsonModifier()
	{
	}
}
