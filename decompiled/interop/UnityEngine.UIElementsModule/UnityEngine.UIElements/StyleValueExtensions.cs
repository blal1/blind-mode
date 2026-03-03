using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.Layout;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003E6")]
internal static class StyleValueExtensions
{
	[Token(Token = "0x6001DFD")]
	internal static string DebugString<T>(this IStyleValue<T> styleValue)
	{
		return null;
	}

	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x29EB930", Offset = "0x29EAB30", VA = "0x1829EB930")]
	internal static LayoutValue ToLayoutValue(this Length length)
	{
		return default(LayoutValue);
	}

	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x29EBA40", Offset = "0x29EAC40", VA = "0x1829EBA40")]
	internal static Length ToLength(this StyleKeyword keyword)
	{
		return default(Length);
	}

	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x29EBC40", Offset = "0x29EAE40", VA = "0x1829EBC40")]
	internal static Rotate ToRotate(this StyleKeyword keyword)
	{
		return default(Rotate);
	}

	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x29EBDA0", Offset = "0x29EAFA0", VA = "0x1829EBDA0")]
	internal static Scale ToScale(this StyleKeyword keyword)
	{
		return default(Scale);
	}

	[Token(Token = "0x6001E02")]
	[Address(RVA = "0x29EBEE0", Offset = "0x29EB0E0", VA = "0x1829EBEE0")]
	internal static Translate ToTranslate(this StyleKeyword keyword)
	{
		return default(Translate);
	}

	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x29EBB30", Offset = "0x29EAD30", VA = "0x1829EBB30")]
	internal static Length ToLength(this StyleLength styleLength)
	{
		return default(Length);
	}

	[Token(Token = "0x6001E04")]
	internal static void CopyFrom<T>(this List<T> list, List<T> other)
	{
	}
}
