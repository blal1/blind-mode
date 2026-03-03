using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x200048C")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class TemplateAsset : VisualElementAsset
{
	[Serializable]
	[Token(Token = "0x200048D")]
	public struct AttributeOverride
	{
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x0")]
		public string m_ElementName;

		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x8")]
		public string[] m_NamesPath;

		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x10")]
		public string m_AttributeName;

		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x18")]
		public string m_Value;

		[Token(Token = "0x6002239")]
		[Address(RVA = "0x2A09870", Offset = "0x2A08A70", VA = "0x182A09870")]
		public bool NamesPathMatchesElementNamesPath(IList<string> elementNamesPath)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x200048E")]
	public struct UxmlSerializedDataOverride
	{
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x0")]
		public int m_ElementId;

		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x8")]
		public List<int> m_ElementIdsPath;

		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x10")]
		[SerializeReference]
		public UxmlSerializedData m_SerializedData;
	}

	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private string m_TemplateAlias;

	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private List<AttributeOverride> m_AttributeOverrides;

	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private List<UxmlSerializedDataOverride> m_SerializedDataOverride;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages;

	[Token(Token = "0x17000917")]
	public List<AttributeOverride> attributeOverrides
	{
		[Token(Token = "0x6002235")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000918")]
	public List<UxmlSerializedDataOverride> serializedDataOverrides
	{
		[Token(Token = "0x6002236")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000919")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal List<VisualTreeAsset.SlotUsageEntry> slotUsages
	{
		[Token(Token = "0x6002238")]
		[Address(RVA = "0x287DB70", Offset = "0x287CD70", VA = "0x18287DB70")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002237")]
	[Address(RVA = "0x2A0A690", Offset = "0x2A09890", VA = "0x182A0A690", Slot = "7")]
	internal override VisualElement Instantiate(CreationContext cc)
	{
		return null;
	}
}
