using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C0")]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("Ygom/UI/Platform Overrider/RectTransform Overrider")]
public class PlatformRectTransformOverrider : PropertyOverriderBase<RectTransform>
{
	[Token(Token = "0x4001BD3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool m_AddCanvasExpandSizeY;

	[Token(Token = "0x4001BD4")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideVector2Property m_AnchorMin;

	[Token(Token = "0x4001BD5")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideVector2Property m_AnchorMax;

	[Token(Token = "0x4001BD6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OverrideVector2Property m_AnchoredPosition;

	[Token(Token = "0x4001BD7")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private OverrideVector2Property m_SizeDelta;

	[Token(Token = "0x4001BD8")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private OverrideVector2Property m_Pivot;

	[Token(Token = "0x17000472")]
	public OverrideVector2Property sizeDelta
	{
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025DF")]
	[Address(RVA = "0x69C680", Offset = "0x69B880", VA = "0x18069C680", Slot = "26")]
	protected override void ImportImpl(RectTransform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025E0")]
	[Address(RVA = "0x69C460", Offset = "0x69B660", VA = "0x18069C460", Slot = "25")]
	protected override void ExportImpl(RectTransform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x69C7B0", Offset = "0x69B9B0", VA = "0x18069C7B0")]
	public PlatformRectTransformOverrider()
	{
	}
}
