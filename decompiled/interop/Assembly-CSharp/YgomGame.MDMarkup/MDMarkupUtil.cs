using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C64")]
public static class MDMarkupUtil
{
	[Token(Token = "0x6004B11")]
	[Address(RVA = "0x93DC00", Offset = "0x93CE00", VA = "0x18093DC00")]
	public static IMDMarkupContainer CreateContainer(MDMarkupDef.ContainerType containerType)
	{
		return null;
	}

	[Token(Token = "0x6004B12")]
	[Address(RVA = "0x93DDC0", Offset = "0x93CFC0", VA = "0x18093DDC0")]
	public static IMDMarkupContent CreateContent(MDMarkupDef.MarkupType markupType)
	{
		return null;
	}

	[Token(Token = "0x6004B13")]
	[Address(RVA = "0x93E500", Offset = "0x93D700", VA = "0x18093E500")]
	public static IMDMarkupModifier CreateModifier(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004B14")]
	[Address(RVA = "0x93E470", Offset = "0x93D670", VA = "0x18093E470")]
	public static IMDMarkupModifier CreateModifier(MDMarkupDef.ModifierType modifierType)
	{
		return null;
	}

	[Token(Token = "0x6004B15")]
	[Address(RVA = "0x93E620", Offset = "0x93D820", VA = "0x18093E620")]
	public static void ImportJsonContents(MDMarkupDef.ContainerType containerType, string json, List<IMDMarkupContent> destContents)
	{
	}

	[Token(Token = "0x6004B16")]
	[Address(RVA = "0x93E660", Offset = "0x93D860", VA = "0x18093E660")]
	public static void ImportJsonObjContents(MDMarkupDef.ContainerType containerType, object jsonObj, List<IMDMarkupContent> destContents)
	{
	}

	[Token(Token = "0x6004B17")]
	[Address(RVA = "0x93E8C0", Offset = "0x93DAC0", VA = "0x18093E8C0")]
	public static List<IMDMarkupModifier> ImportJsonObjModifiers(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004B18")]
	[Address(RVA = "0x93D9D0", Offset = "0x93CBD0", VA = "0x18093D9D0")]
	public static void CollectContentsIdMap(List<IMDMarkupContent> contents, Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004B19")]
	[Address(RVA = "0x93EBB0", Offset = "0x93DDB0", VA = "0x18093EBB0")]
	public static bool IsSupportedContent(MDMarkupDef.ContainerType containerType, MDMarkupDef.MarkupType markupType)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B1A")]
	[Address(RVA = "0x93EC00", Offset = "0x93DE00", VA = "0x18093EC00")]
	public static void PickInvalidMessage(IMDMarkupSource source, ref int invalidMessagePriority, ref string invalidMessageText)
	{
	}
}
