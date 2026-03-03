using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005AF")]
[RequireComponent(typeof(BindingItemThumb))]
[AddComponentMenu("Ygom/UI/Platform Overrider/BindingItemThumb Overrider")]
public class PlatformBindingItemOverrider : PropertyOverriderBase<BindingItemThumb>
{
	[Token(Token = "0x4001B9C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideBoolProperty m_IsLargeIcon;

	[Token(Token = "0x4001B9D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideBoolProperty m_IsBoxScale;

	[Token(Token = "0x4001B9E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideBoolProperty m_UseLargeDeckCase;

	[Token(Token = "0x600257E")]
	[Address(RVA = "0x699940", Offset = "0x698B40", VA = "0x180699940", Slot = "26")]
	protected override void ImportImpl(BindingItemThumb target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600257F")]
	[Address(RVA = "0x6998A0", Offset = "0x698AA0", VA = "0x1806998A0", Slot = "25")]
	protected override void ExportImpl(BindingItemThumb target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002580")]
	[Address(RVA = "0x6999F0", Offset = "0x698BF0", VA = "0x1806999F0")]
	public PlatformBindingItemOverrider()
	{
	}
}
