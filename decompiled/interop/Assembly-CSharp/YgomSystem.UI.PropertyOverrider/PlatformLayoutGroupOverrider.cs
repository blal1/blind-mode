using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B6")]
[RequireComponent(typeof(HorizontalOrVerticalLayoutGroup))]
[AddComponentMenu("Ygom/UI/Platform Overrider/LayoutGroup Overrider")]
public class PlatformLayoutGroupOverrider : PropertyOverriderBase<HorizontalOrVerticalLayoutGroup>
{
	[Token(Token = "0x4001BBB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideRectOffsetProperty m_Padding;

	[Token(Token = "0x4001BBC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideTextAnchorProperty m_ChildAlignment;

	[Token(Token = "0x4001BBD")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideFloatProperty m_Spacing;

	[Token(Token = "0x4001BBE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OverrideBoolProperty m_ChildForceExpandWidth;

	[Token(Token = "0x4001BBF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private OverrideBoolProperty m_ChildForceExpandHeight;

	[Token(Token = "0x4001BC0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private OverrideBoolProperty m_ChildControlWidth;

	[Token(Token = "0x4001BC1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private OverrideBoolProperty m_ChildControlHeight;

	[Token(Token = "0x4001BC2")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private OverrideBoolProperty m_ChildScaleWidth;

	[Token(Token = "0x4001BC3")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private OverrideBoolProperty m_ChildScaleHeight;

	[Token(Token = "0x4001BC4")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private OverrideBoolProperty m_ReverseArrangement;

	[Token(Token = "0x1700045F")]
	public OverrideRectOffsetProperty padding
	{
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000460")]
	public OverrideFloatProperty spacing
	{
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000461")]
	public OverrideTextAnchorProperty childAlignment
	{
		[Token(Token = "0x60025A0")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000462")]
	public OverrideBoolProperty childControlWidth
	{
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000463")]
	public OverrideBoolProperty childForceExpandWidth
	{
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x69B6E0", Offset = "0x69A8E0", VA = "0x18069B6E0", Slot = "26")]
	protected override void ImportImpl(HorizontalOrVerticalLayoutGroup target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x69B4D0", Offset = "0x69A6D0", VA = "0x18069B4D0", Slot = "25")]
	protected override void ExportImpl(HorizontalOrVerticalLayoutGroup target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x69B950", Offset = "0x69AB50", VA = "0x18069B950")]
	public PlatformLayoutGroupOverrider()
	{
	}
}
