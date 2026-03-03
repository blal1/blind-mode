using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B1")]
[RequireComponent(typeof(GridLayoutGroup))]
[AddComponentMenu("Ygom/UI/Platform Overrider/GridLayoutGroup Overrider")]
public class PlatformGridLayoutGroupOverrider : PropertyOverriderBase<GridLayoutGroup>
{
	[Token(Token = "0x4001BA6")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideRectOffsetProperty m_Padding;

	[Token(Token = "0x4001BA7")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideTextAnchorProperty m_ChildAlignment;

	[Token(Token = "0x4001BA8")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideGridLayoutGroupCornerProperty m_StartCorner;

	[Token(Token = "0x4001BA9")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OverrideGridLayoutGroupAxisProperty m_StartAxis;

	[Token(Token = "0x4001BAA")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private OverrideVector2Property m_CellSize;

	[Token(Token = "0x4001BAB")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private OverrideVector2Property m_Spacing;

	[Token(Token = "0x4001BAC")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private OverrideGridLayoutGroupConstraintProperty m_Constraint;

	[Token(Token = "0x4001BAD")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private OverrideIntProperty m_ConstraintCount;

	[Token(Token = "0x1700045A")]
	public OverrideRectOffsetProperty padding
	{
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045B")]
	public OverrideIntProperty constraintCount
	{
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600258C")]
	[Address(RVA = "0x69A240", Offset = "0x699440", VA = "0x18069A240", Slot = "26")]
	protected override void ImportImpl(GridLayoutGroup target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600258D")]
	[Address(RVA = "0x69A060", Offset = "0x699260", VA = "0x18069A060", Slot = "25")]
	protected override void ExportImpl(GridLayoutGroup target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600258E")]
	[Address(RVA = "0x69A4A0", Offset = "0x6996A0", VA = "0x18069A4A0")]
	public PlatformGridLayoutGroupOverrider()
	{
	}
}
