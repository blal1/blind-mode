using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000437")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StyleRule
{
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private StyleProperty[] m_Properties;

	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x18")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	[SerializeField]
	internal int line;

	[NonSerialized]
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x1C")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal int customPropertiesCount;

	[Token(Token = "0x1700087E")]
	public StyleProperty[] properties
	{
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StyleRule()
	{
	}
}
