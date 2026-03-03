using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x200043A")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct StyleSelectorPart
{
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private string m_Value;

	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private StyleSelectorType m_Type;

	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x10")]
	internal object tempData;

	[Token(Token = "0x17000881")]
	public string value
	{
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0x10E5520", Offset = "0x10E4720", VA = "0x1810E5520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000882")]
	public StyleSelectorType type
	{
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0x12CF490", Offset = "0x12CE690", VA = "0x1812CF490")]
		get
		{
			return default(StyleSelectorType);
		}
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x1EDF6D0", Offset = "0x1EDE8D0", VA = "0x181EDF6D0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal set
		{
		}
	}

	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x29F9020", Offset = "0x29F8220", VA = "0x1829F9020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x29F8F10", Offset = "0x29F8110", VA = "0x1829F8F10")]
	public static StyleSelectorPart CreateClass(string className)
	{
		return default(StyleSelectorPart);
	}

	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x29F8F70", Offset = "0x29F8170", VA = "0x1829F8F70")]
	public static StyleSelectorPart CreateId(string Id)
	{
		return default(StyleSelectorPart);
	}

	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x29F8FD0", Offset = "0x29F81D0", VA = "0x1829F8FD0")]
	public static StyleSelectorPart CreatePredicate(object predicate)
	{
		return default(StyleSelectorPart);
	}
}
