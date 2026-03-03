using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000501")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StyleMatchingContext
{
	[Token(Token = "0x400106F")]
	[FieldOffset(Offset = "0x10")]
	private List<StyleSheet> m_StyleSheetStack;

	[Token(Token = "0x4001070")]
	[FieldOffset(Offset = "0x18")]
	public StyleVariableContext variableContext;

	[Token(Token = "0x4001071")]
	[FieldOffset(Offset = "0x20")]
	public VisualElement currentElement;

	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x28")]
	public Action<VisualElement, MatchResultInfo> processResult;

	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x30")]
	public AncestorFilter ancestorFilter;

	[Token(Token = "0x17000966")]
	public int styleSheetCount
	{
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x2A32C10", Offset = "0x2A31E10", VA = "0x182A32C10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60023FA")]
	[Address(RVA = "0x2A32AF0", Offset = "0x2A31CF0", VA = "0x182A32AF0")]
	public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult)
	{
	}

	[Token(Token = "0x60023FB")]
	[Address(RVA = "0x2A32940", Offset = "0x2A31B40", VA = "0x182A32940")]
	public void AddStyleSheet(StyleSheet sheet)
	{
	}

	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x2A32A80", Offset = "0x2A31C80", VA = "0x182A32A80")]
	public void RemoveStyleSheetRange(int index, int count)
	{
	}

	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x2A32A20", Offset = "0x2A31C20", VA = "0x182A32A20")]
	public StyleSheet GetStyleSheetAt(int index)
	{
		return null;
	}
}
