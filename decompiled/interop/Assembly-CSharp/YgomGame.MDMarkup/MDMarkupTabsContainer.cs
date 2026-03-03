using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C6C")]
public class MDMarkupTabsContainer : MDMarkupContainerBase
{
	[NonSerialized]
	[Token(Token = "0x4009B1B")]
	[FieldOffset(Offset = "0x28")]
	public int startTab;

	[Token(Token = "0x17000A37")]
	public override MDMarkupDef.ContainerType containerType
	{
		[Token(Token = "0x6004B47")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.ContainerType);
		}
	}

	[Token(Token = "0x6004B48")]
	[Address(RVA = "0x93D8B0", Offset = "0x93CAB0", VA = "0x18093D8B0", Slot = "17")]
	public override object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004B49")]
	[Address(RVA = "0x93D950", Offset = "0x93CB50", VA = "0x18093D950", Slot = "18")]
	public override void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004B4A")]
	[Address(RVA = "0x9360C0", Offset = "0x9352C0", VA = "0x1809360C0")]
	public MDMarkupTabsContainer()
	{
	}
}
