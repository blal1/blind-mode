using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005AE")]
[RequireComponent(typeof(BindingImageEx))]
public class PlatformBindingImageAspectModeOverrider : PropertyOverriderBase<BindingImageEx>
{
	[Token(Token = "0x4001B9B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode;

	[Token(Token = "0x600257B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "26")]
	protected override void ImportImpl(BindingImageEx target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600257C")]
	[Address(RVA = "0x699830", Offset = "0x698A30", VA = "0x180699830", Slot = "25")]
	protected override void ExportImpl(BindingImageEx target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600257D")]
	[Address(RVA = "0x699860", Offset = "0x698A60", VA = "0x180699860")]
	public PlatformBindingImageAspectModeOverrider()
	{
	}
}
