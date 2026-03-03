using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000CAF")]
public class MDMarkupStrFormatByArgsModifier : MDMarkupModifierBase, IMDMarkupModifierPreload, IMDMarkupModifier, IMDMarkupModifierOnLoadComplete
{
	[Token(Token = "0x4009BCC")]
	[FieldOffset(Offset = "0x28")]
	public List<string> argKeys;

	[Token(Token = "0x4009BCD")]
	[FieldOffset(Offset = "0x30")]
	private object[] m_ArgParams;

	[Token(Token = "0x4009BCE")]
	[FieldOffset(Offset = "0x38")]
	private bool m_InvalidArgs;

	[Token(Token = "0x17000AE6")]
	public override MDMarkupDef.ModifierType modifierType
	{
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "8")]
		get
		{
			return default(MDMarkupDef.ModifierType);
		}
	}

	[Token(Token = "0x6004CE9")]
	[Address(RVA = "0x959960", Offset = "0x958B60", VA = "0x180959960", Slot = "9")]
	public override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CEA")]
	[Address(RVA = "0x959710", Offset = "0x958910", VA = "0x180959710", Slot = "10")]
	public override void OnExportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CEB")]
	[Address(RVA = "0x9593A0", Offset = "0x9585A0", VA = "0x1809593A0", Slot = "11")]
	public bool ModifyOnPreload(IMDMarkupId idContent, Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CEC")]
	[Address(RVA = "0x959380", Offset = "0x958580", VA = "0x180959380", Slot = "12")]
	public bool ModifyOnLoadComplete(IMDMarkupId idContent, Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CED")]
	[Address(RVA = "0x959310", Offset = "0x958510", VA = "0x180959310")]
	private bool IsTargetModifier(IMDMarkupId idContent, bool onPreload)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CEE")]
	[Address(RVA = "0x9593C0", Offset = "0x9585C0", VA = "0x1809593C0")]
	private bool Modify(IMDMarkupId idContent, Dictionary<string, object> args, bool onPreload)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CEF")]
	[Address(RVA = "0x955FC0", Offset = "0x9551C0", VA = "0x180955FC0")]
	public MDMarkupStrFormatByArgsModifier()
	{
	}
}
