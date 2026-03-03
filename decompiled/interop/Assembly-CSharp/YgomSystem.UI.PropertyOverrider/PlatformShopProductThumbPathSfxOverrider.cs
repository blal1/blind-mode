using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Shop;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C3")]
[RequireComponent(typeof(BindingShopProductThumb))]
public class PlatformShopProductThumbPathSfxOverrider : PropertyOverriderBase<BindingShopProductThumb>
{
	[Token(Token = "0x4001BDB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideStringProperty m_PathSfx;

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x69CCD0", Offset = "0x69BED0", VA = "0x18069CCD0", Slot = "25")]
	protected override void ExportImpl(BindingShopProductThumb target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025EA")]
	[Address(RVA = "0x69CD50", Offset = "0x69BF50", VA = "0x18069CD50", Slot = "26")]
	protected override void ImportImpl(BindingShopProductThumb target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x69CDC0", Offset = "0x69BFC0", VA = "0x18069CDC0")]
	public PlatformShopProductThumbPathSfxOverrider()
	{
	}
}
