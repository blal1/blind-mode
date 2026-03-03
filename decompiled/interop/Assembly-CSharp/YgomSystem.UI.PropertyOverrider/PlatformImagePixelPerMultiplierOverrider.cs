using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B3")]
[RequireComponent(typeof(Image))]
[AddComponentMenu("Ygom/UI/Platform Overrider/Image PixelPerMultiplier Overrider")]
public class PlatformImagePixelPerMultiplierOverrider : PropertyOverriderBase<Image>
{
	[Token(Token = "0x4001BB1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideFloatProperty m_PixelsPerUnitMultiplier;

	[Token(Token = "0x6002595")]
	[Address(RVA = "0x69AB30", Offset = "0x699D30", VA = "0x18069AB30", Slot = "26")]
	protected override void ImportImpl(Image target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002596")]
	[Address(RVA = "0x69AAB0", Offset = "0x699CB0", VA = "0x18069AAB0", Slot = "25")]
	protected override void ExportImpl(Image target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002597")]
	[Address(RVA = "0x69ABA0", Offset = "0x699DA0", VA = "0x18069ABA0")]
	public PlatformImagePixelPerMultiplierOverrider()
	{
	}
}
