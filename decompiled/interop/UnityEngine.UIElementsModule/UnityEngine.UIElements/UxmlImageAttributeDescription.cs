using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004B9")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class UxmlImageAttributeDescription : UxmlAttributeDescription
{
	[Token(Token = "0x4000F62")]
	[FieldOffset(Offset = "0x40")]
	private Type m_AssetType;

	[Token(Token = "0x17000929")]
	public Background defaultValue
	{
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x2A1D640", Offset = "0x2A1C840", VA = "0x182A1D640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x2A1D5A0", Offset = "0x2A1C7A0", VA = "0x182A1D5A0")]
	public UxmlImageAttributeDescription()
	{
	}

	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x2A1D3F0", Offset = "0x2A1C5F0", VA = "0x182A1D3F0")]
	public Background GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return default(Background);
	}
}
