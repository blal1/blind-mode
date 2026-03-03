using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000438")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StyleSelector
{
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private StyleSelectorPart[] m_Parts;

	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private StyleSelectorRelationship m_PreviousRelationship;

	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x1C")]
	internal int pseudoStateMask;

	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x20")]
	internal int negatedPseudoStateMask;

	[Token(Token = "0x1700087F")]
	public StyleSelectorPart[] parts
	{
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal set
		{
		}
	}

	[Token(Token = "0x17000880")]
	public StyleSelectorRelationship previousRelationship
	{
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x138AC10", Offset = "0x1389E10", VA = "0x18138AC10")]
		get
		{
			return default(StyleSelectorRelationship);
		}
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal set
		{
		}
	}

	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x29F9160", Offset = "0x29F8360", VA = "0x1829F9160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x29F92C0", Offset = "0x29F84C0", VA = "0x1829F92C0")]
	public StyleSelector()
	{
	}
}
