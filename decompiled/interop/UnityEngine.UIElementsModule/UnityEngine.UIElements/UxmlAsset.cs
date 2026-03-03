using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004BB")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class UxmlAsset : IUxmlAttributes
{
	[Token(Token = "0x4000F67")]
	public const string NullNodeType = "null";

	[Token(Token = "0x4000F68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_FullTypeName;

	[Token(Token = "0x4000F69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UxmlNamespaceDefinition m_XmlNamespace;

	[Token(Token = "0x4000F6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_Id;

	[Token(Token = "0x4000F6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int m_OrderInDocument;

	[Token(Token = "0x4000F6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_ParentId;

	[Token(Token = "0x4000F6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<UxmlNamespaceDefinition> m_NamespaceDefinitions;

	[Token(Token = "0x4000F6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected List<string> m_Properties;

	[Token(Token = "0x1700092A")]
	public string fullTypeName
	{
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700092B")]
	public int id
	{
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		set
		{
		}
	}

	[Token(Token = "0x1700092C")]
	public int orderInDocument
	{
		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700092D")]
	public int parentId
	{
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		set
		{
		}
	}

	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x1E347F0", Offset = "0x1E339F0", VA = "0x181E347F0")]
	public UxmlAsset(string fullTypeName, [Optional] UxmlNamespaceDefinition xmlNamespace)
	{
	}

	[Token(Token = "0x60022C4")]
	[Address(RVA = "0x2A1B940", Offset = "0x2A1AB40", VA = "0x182A1B940", Slot = "4")]
	public bool TryGetAttributeValue(string propertyName, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x60022C5")]
	[Address(RVA = "0x2A1B770", Offset = "0x2A1A970", VA = "0x182A1B770")]
	public void SetAttribute(string name, string value)
	{
	}

	[Token(Token = "0x60022C6")]
	[Address(RVA = "0x2A1B680", Offset = "0x2A1A880", VA = "0x182A1B680")]
	public void RemoveAttribute(string attributeName)
	{
	}

	[Token(Token = "0x60022C7")]
	[Address(RVA = "0x2A1B770", Offset = "0x2A1A970", VA = "0x182A1B770")]
	private void SetOrAddProperty(string propertyName, string propertyValue)
	{
	}

	[Token(Token = "0x60022C8")]
	[Address(RVA = "0x2A1B8D0", Offset = "0x2A1AAD0", VA = "0x182A1B8D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
