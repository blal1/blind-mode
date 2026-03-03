using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Shop;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C2")]
[RequireComponent(typeof(BindingShopProductThumb))]
public class PlatformShopProductThumbFormatOverrider : PropertyOverriderBase<BindingShopProductThumb>
{
	[Token(Token = "0x4001BDA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideShopProductThumbFormatProperty m_Format;

	[Token(Token = "0x17000473")]
	public OverrideShopProductThumbFormatProperty format
	{
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x69CB30", Offset = "0x69BD30", VA = "0x18069CB30", Slot = "25")]
	protected override void ExportImpl(BindingShopProductThumb target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025E7")]
	[Address(RVA = "0x69CBB0", Offset = "0x69BDB0", VA = "0x18069CBB0", Slot = "26")]
	protected override void ImportImpl(BindingShopProductThumb target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025E8")]
	[Address(RVA = "0x69CC30", Offset = "0x69BE30", VA = "0x18069CC30")]
	public PlatformShopProductThumbFormatOverrider()
	{
	}
}
