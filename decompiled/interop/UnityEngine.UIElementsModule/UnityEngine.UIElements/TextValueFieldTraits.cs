using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x200015C")]
[Obsolete("TextValueFieldTraits<TValueType, TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class TextValueFieldTraits<TValueType, TValueUxmlAttributeType> : BaseFieldTraits<TValueType, TValueUxmlAttributeType> where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
{
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x0")]
	private UxmlStringAttributeDescription m_PlaceholderText;

	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x0")]
	private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus;

	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x0")]
	private UxmlBoolAttributeDescription m_IsReadOnly;

	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x0")]
	private UxmlBoolAttributeDescription m_IsDelayed;

	[Token(Token = "0x6000A97")]
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
	{
	}

	[Token(Token = "0x6000A98")]
	public TextValueFieldTraits()
	{
	}
}
