using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005CB")]
[RequireComponent(typeof(TweenImage))]
[AddComponentMenu("Ygom/UI/Platform Overrider/TweenImage Overrider")]
public class PlatformTweenImageOverrider : PropertyOverriderBase<TweenImage>
{
	[Token(Token = "0x4001BEF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TweenImage m_TargetTween;

	[Token(Token = "0x4001BF0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideSpriteArrayProperty m_Frames;

	[Token(Token = "0x600260A")]
	[Address(RVA = "0x69DAB0", Offset = "0x69CCB0", VA = "0x18069DAB0", Slot = "24")]
	protected override TweenImage GetTargetComponent()
	{
		return null;
	}

	[Token(Token = "0x600260B")]
	[Address(RVA = "0x69DB40", Offset = "0x69CD40", VA = "0x18069DB40", Slot = "26")]
	protected override void ImportImpl(TweenImage target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600260C")]
	[Address(RVA = "0x69DA30", Offset = "0x69CC30", VA = "0x18069DA30", Slot = "25")]
	protected override void ExportImpl(TweenImage target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600260D")]
	[Address(RVA = "0x69DBB0", Offset = "0x69CDB0", VA = "0x18069DBB0")]
	public PlatformTweenImageOverrider()
	{
	}
}
