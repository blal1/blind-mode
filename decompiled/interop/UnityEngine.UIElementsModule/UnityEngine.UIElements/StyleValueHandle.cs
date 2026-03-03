using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000442")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct StyleValueHandle
{
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private StyleValueType m_ValueType;

	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x4")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	[SerializeField]
	internal int valueIndex;

	[Token(Token = "0x1700088A")]
	public StyleValueType valueType
	{
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x1500B10", Offset = "0x14FFD10", VA = "0x181500B10")]
		get
		{
			return default(StyleValueType);
		}
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
		internal set
		{
		}
	}
}
