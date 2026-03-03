using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000CAC")]
public abstract class MDMarkupModifierBase : IMDMarkupModifier
{
	[Token(Token = "0x4009BC9")]
	[FieldOffset(Offset = "0x10")]
	public string targetId;

	[Token(Token = "0x4009BCA")]
	[FieldOffset(Offset = "0x18")]
	public MDMarkupDef.IdMatchType targetIdMatchType;

	[Token(Token = "0x4009BCB")]
	[FieldOffset(Offset = "0x20")]
	private Regex m_RegexCache;

	[Token(Token = "0x17000AE5")]
	public abstract MDMarkupDef.ModifierType modifierType
	{
		[Token(Token = "0x6004CE0")]
		get;
	}

	[Token(Token = "0x6004CE1")]
	[Address(RVA = "0x955D60", Offset = "0x954F60", VA = "0x180955D60", Slot = "5")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CE2")]
	public abstract void OnImportJsonObj(object jsonObj);

	[Token(Token = "0x6004CE3")]
	[Address(RVA = "0x955BC0", Offset = "0x954DC0", VA = "0x180955BC0", Slot = "6")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004CE4")]
	public abstract void OnExportJsonObj(object jsonObj);

	[Token(Token = "0x6004CE5")]
	[Address(RVA = "0x955E40", Offset = "0x955040", VA = "0x180955E40", Slot = "7")]
	public bool MatchTargetId(IMDMarkupId idContent)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CE6")]
	[Address(RVA = "0x955FC0", Offset = "0x9551C0", VA = "0x180955FC0")]
	protected MDMarkupModifierBase()
	{
	}
}
