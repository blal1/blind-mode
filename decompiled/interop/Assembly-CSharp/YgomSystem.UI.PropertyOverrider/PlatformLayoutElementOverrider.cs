using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B5")]
[RequireComponent(typeof(LayoutElement))]
[AddComponentMenu("Ygom/UI/Platform Overrider/LayoutElement Overrider")]
public class PlatformLayoutElementOverrider : PropertyOverriderBase<LayoutElement>
{
	[Token(Token = "0x4001BB3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideBoolProperty m_IgnoreLayout;

	[Token(Token = "0x4001BB4")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideFloatProperty m_MinWidth;

	[Token(Token = "0x4001BB5")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideFloatProperty m_MinHeight;

	[Token(Token = "0x4001BB6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OverrideFloatProperty m_PreferredWidth;

	[Token(Token = "0x4001BB7")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private OverrideFloatProperty m_PreferredHeight;

	[Token(Token = "0x4001BB8")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private OverrideFloatProperty m_FlexibleWidth;

	[Token(Token = "0x4001BB9")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private OverrideFloatProperty m_FlexibleHeight;

	[Token(Token = "0x4001BBA")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private OverrideIntProperty m_LayoutPriority;

	[Token(Token = "0x600259B")]
	[Address(RVA = "0x69AFE0", Offset = "0x69A1E0", VA = "0x18069AFE0", Slot = "26")]
	protected override void ImportImpl(LayoutElement target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600259C")]
	[Address(RVA = "0x69ADD0", Offset = "0x699FD0", VA = "0x18069ADD0", Slot = "25")]
	protected override void ExportImpl(LayoutElement target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600259D")]
	[Address(RVA = "0x69B210", Offset = "0x69A410", VA = "0x18069B210")]
	public PlatformLayoutElementOverrider()
	{
	}
}
