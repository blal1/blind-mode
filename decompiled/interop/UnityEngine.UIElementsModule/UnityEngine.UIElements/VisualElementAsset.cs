using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004C3")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver
{
	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string m_Name;

	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int m_RuleIndex;

	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string m_Text;

	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PickingMode m_PickingMode;

	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string[] m_Classes;

	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<string> m_StylesheetPaths;

	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<StyleSheet> m_Stylesheets;

	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x80")]
	[SerializeReference]
	internal UxmlSerializedData m_SerializedData;

	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private bool m_SkipClone;

	[Token(Token = "0x17000931")]
	public int ruleIndex
	{
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x158E350", Offset = "0x158D550", VA = "0x18158E350")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000932")]
	public string[] classes
	{
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x287DBA0", Offset = "0x287CDA0", VA = "0x18287DBA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000933")]
	public List<string> stylesheetPaths
	{
		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x2A20DC0", Offset = "0x2A1FFC0", VA = "0x182A20DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000934")]
	public bool hasStylesheetPaths
	{
		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x2024280", Offset = "0x2023480", VA = "0x182024280")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000935")]
	public List<StyleSheet> stylesheets
	{
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x2A20E40", Offset = "0x2A20040", VA = "0x182A20E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000936")]
	public bool hasStylesheets
	{
		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x2A20DB0", Offset = "0x2A1FFB0", VA = "0x182A20DB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000937")]
	public UxmlSerializedData serializedData
	{
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000938")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool skipClone
	{
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x422F90", Offset = "0x422190", VA = "0x180422F90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x2A20BA0", Offset = "0x2A1FDA0", VA = "0x182A20BA0", Slot = "6")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x2A203A0", Offset = "0x2A1F5A0", VA = "0x182A203A0")]
	private static bool IdsPathMatchesAttributeOverrideIdsPath(List<int> idsPath, List<int> attributeOverrideIdsPath, int templateId)
	{
		return default(bool);
	}

	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x2A204C0", Offset = "0x2A1F6C0", VA = "0x182A204C0", Slot = "7")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal virtual VisualElement Instantiate(CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x60022E7")]
	[Address(RVA = "0x2A20D30", Offset = "0x2A1FF30", VA = "0x182A20D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
