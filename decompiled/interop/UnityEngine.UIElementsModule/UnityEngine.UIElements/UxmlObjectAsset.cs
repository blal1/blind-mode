using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004BC")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class UxmlObjectAsset : UxmlAsset
{
	[Token(Token = "0x4000F6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool m_IsField;

	[Token(Token = "0x1700092E")]
	public bool isField
	{
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x2A1E080", Offset = "0x2A1D280", VA = "0x182A1E080")]
	public UxmlObjectAsset(string fullTypeNameOrFieldName, bool isField, [Optional] UxmlNamespaceDefinition xmlNamespace)
	{
	}

	[Token(Token = "0x60022CB")]
	[Address(RVA = "0x2A1DF80", Offset = "0x2A1D180", VA = "0x182A1DF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
