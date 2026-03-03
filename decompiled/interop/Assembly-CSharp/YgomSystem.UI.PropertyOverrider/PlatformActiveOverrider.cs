using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005AD")]
[AddComponentMenu("Ygom/UI/Platform Overrider/Active Overrider")]
public class PlatformActiveOverrider : PropertyOverriderBase<Transform>
{
	[Token(Token = "0x4001B9A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Header("確認後は当オブジェクトをアクティブにして下さい")]
	private OverrideBoolProperty m_Active;

	[Token(Token = "0x6002578")]
	[Address(RVA = "0x699700", Offset = "0x698900", VA = "0x180699700", Slot = "26")]
	protected override void ImportImpl(Transform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002579")]
	[Address(RVA = "0x699670", Offset = "0x698870", VA = "0x180699670", Slot = "25")]
	protected override void ExportImpl(Transform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600257A")]
	[Address(RVA = "0x699790", Offset = "0x698990", VA = "0x180699790")]
	public PlatformActiveOverrider()
	{
	}
}
