using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000436")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StyleProperty
{
	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_Name;

	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int m_Line;

	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private StyleValueHandle[] m_Values;

	[NonSerialized]
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x28")]
	internal bool isCustomProperty;

	[NonSerialized]
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x29")]
	internal bool requireVariableResolve;

	[Token(Token = "0x1700087C")]
	public string name
	{
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700087D")]
	public StyleValueHandle[] values
	{
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x276ACD0", Offset = "0x2769ED0", VA = "0x18276ACD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StyleProperty()
	{
	}
}
