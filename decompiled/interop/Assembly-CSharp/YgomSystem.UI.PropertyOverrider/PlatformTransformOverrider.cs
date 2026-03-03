using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C9")]
[RequireComponent(typeof(Transform))]
[AddComponentMenu("Ygom/UI/Platform Overrider/Transform Overrider")]
public class PlatformTransformOverrider : PropertyOverriderBase<Transform>
{
	[Token(Token = "0x4001BE9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideVector3Property m_Position;

	[Token(Token = "0x4001BEA")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideQuaternionProperty m_Rotation;

	[Token(Token = "0x4001BEB")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideVector3Property m_Scale;

	[Token(Token = "0x6002604")]
	[Address(RVA = "0x69D550", Offset = "0x69C750", VA = "0x18069D550", Slot = "26")]
	protected override void ImportImpl(Transform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002605")]
	[Address(RVA = "0x69D420", Offset = "0x69C620", VA = "0x18069D420", Slot = "25")]
	protected override void ExportImpl(Transform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002606")]
	[Address(RVA = "0x69D680", Offset = "0x69C880", VA = "0x18069D680")]
	public PlatformTransformOverrider()
	{
	}
}
