using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C66")]
public abstract class MDMarkupContainerBase : IMDMarkupContainer, IMDMarkupSourceRequireTextData, IMDMarkupOwnedId
{
	[Token(Token = "0x4009B07")]
	[FieldOffset(Offset = "0x10")]
	public List<IMDMarkupModifier> modifiers;

	[Token(Token = "0x4009B08")]
	[FieldOffset(Offset = "0x18")]
	public GlobalTextData title;

	[Token(Token = "0x4009B09")]
	[FieldOffset(Offset = "0x20")]
	public List<IMDMarkupContent> contents;

	[Token(Token = "0x17000A30")]
	public abstract MDMarkupDef.ContainerType containerType
	{
		[Token(Token = "0x6004B24")]
		get;
	}

	[Token(Token = "0x17000A31")]
	private List<IMDMarkupModifier> YgomGame_002EMDMarkup_002EIMDMarkupContainer_002Emodifiers
	{
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000A32")]
	private GlobalTextData YgomGame_002EMDMarkup_002EIMDMarkupContainer_002Etitle
	{
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A33")]
	private List<IMDMarkupContent> YgomGame_002EMDMarkup_002EIMDMarkupContainer_002Econtents
	{
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B29")]
	[Address(RVA = "0x9360D0", Offset = "0x9352D0", VA = "0x1809360D0", Slot = "16")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6004B2A")]
	[Address(RVA = "0x936170", Offset = "0x935370", VA = "0x180936170", Slot = "17")]
	public virtual object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004B2B")]
	[Address(RVA = "0x936910", Offset = "0x935B10", VA = "0x180936910", Slot = "12")]
	public void ImportJson(string json)
	{
	}

	[Token(Token = "0x6004B2C")]
	[Address(RVA = "0x9367C0", Offset = "0x9359C0", VA = "0x1809367C0", Slot = "18")]
	public virtual void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004B2D")]
	[Address(RVA = "0x936160", Offset = "0x935360", VA = "0x180936160", Slot = "19")]
	public virtual void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004B2E")]
	[Address(RVA = "0x936950", Offset = "0x935B50", VA = "0x180936950", Slot = "13")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004B2F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "20")]
	protected virtual void InnerSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004B30")]
	[Address(RVA = "0x936C70", Offset = "0x935E70", VA = "0x180936C70")]
	protected MDMarkupContainerBase()
	{
	}
}
