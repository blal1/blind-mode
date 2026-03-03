using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C67")]
public class MDMarkupPagerContainer : MDMarkupContainerBase
{
	[Token(Token = "0x4009B0A")]
	[FieldOffset(Offset = "0x28")]
	public bool isLoop;

	[NonSerialized]
	[Token(Token = "0x4009B0B")]
	[FieldOffset(Offset = "0x2C")]
	public int startPage;

	[Token(Token = "0x17000A34")]
	public override MDMarkupDef.ContainerType containerType
	{
		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "15")]
		get
		{
			return default(MDMarkupDef.ContainerType);
		}
	}

	[Token(Token = "0x6004B32")]
	[Address(RVA = "0x93D6F0", Offset = "0x93C8F0", VA = "0x18093D6F0", Slot = "16")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6004B33")]
	[Address(RVA = "0x93D720", Offset = "0x93C920", VA = "0x18093D720", Slot = "17")]
	public override object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004B34")]
	[Address(RVA = "0x93D800", Offset = "0x93CA00", VA = "0x18093D800", Slot = "18")]
	public override void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004B35")]
	[Address(RVA = "0x9360C0", Offset = "0x9352C0", VA = "0x1809360C0")]
	public MDMarkupPagerContainer()
	{
	}
}
