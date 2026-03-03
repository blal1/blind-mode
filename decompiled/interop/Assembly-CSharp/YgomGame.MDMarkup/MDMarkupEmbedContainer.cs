using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C6E")]
public class MDMarkupEmbedContainer : IMDMarkupContainer, IMDMarkupSourceRequireTextData, IMDMarkupOwnedId
{
	[Token(Token = "0x4009B1C")]
	[FieldOffset(Offset = "0x10")]
	public MDMarkupContentEmbedContainerTab embedContent;

	[Token(Token = "0x17000A39")]
	public MDMarkupDef.ContainerType containerType
	{
		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "4")]
		get
		{
			return default(MDMarkupDef.ContainerType);
		}
	}

	[Token(Token = "0x17000A3A")]
	private List<IMDMarkupModifier> YgomGame_002EMDMarkup_002EIMDMarkupContainer_002Emodifiers
	{
		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x93D4C0", Offset = "0x93C6C0", VA = "0x18093D4C0", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x93D530", Offset = "0x93C730", VA = "0x18093D530", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000A3B")]
	public GlobalTextData title
	{
		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x534450", Offset = "0x533650", VA = "0x180534450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3C")]
	public List<IMDMarkupContent> contents
	{
		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x93D680", Offset = "0x93C880", VA = "0x18093D680", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B52")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004B53")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void Clear()
	{
	}

	[Token(Token = "0x6004B54")]
	[Address(RVA = "0x93D0F0", Offset = "0x93C2F0", VA = "0x18093D0F0", Slot = "10")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004B55")]
	[Address(RVA = "0x93D3E0", Offset = "0x93C5E0", VA = "0x18093D3E0", Slot = "12")]
	public void ImportJson(string json)
	{
	}

	[Token(Token = "0x6004B56")]
	[Address(RVA = "0x93D350", Offset = "0x93C550", VA = "0x18093D350", Slot = "11")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004B57")]
	[Address(RVA = "0x93D480", Offset = "0x93C680", VA = "0x18093D480", Slot = "13")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004B58")]
	[Address(RVA = "0x93D610", Offset = "0x93C810", VA = "0x18093D610")]
	public MDMarkupEmbedContainer()
	{
	}
}
