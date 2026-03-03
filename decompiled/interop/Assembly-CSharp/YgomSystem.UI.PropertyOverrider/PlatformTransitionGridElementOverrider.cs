using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005CA")]
[RequireComponent(typeof(TransitionGridElement))]
[AddComponentMenu("Ygom/UI/Platform Overrider/PlatformTransitionGridElement Overrider")]
public class PlatformTransitionGridElementOverrider : PropertyOverriderBase<TransitionGridElement>
{
	[Token(Token = "0x4001BEC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideIntProperty m_PosX;

	[Token(Token = "0x4001BED")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideIntProperty m_PosY;

	[Token(Token = "0x4001BEE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideIntProperty m_SubPriority;

	[Token(Token = "0x6002607")]
	[Address(RVA = "0x69D860", Offset = "0x69CA60", VA = "0x18069D860", Slot = "26")]
	protected override void ImportImpl(TransitionGridElement target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002608")]
	[Address(RVA = "0x69D7C0", Offset = "0x69C9C0", VA = "0x18069D7C0", Slot = "25")]
	protected override void ExportImpl(TransitionGridElement target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002609")]
	[Address(RVA = "0x69D900", Offset = "0x69CB00", VA = "0x18069D900")]
	public PlatformTransitionGridElementOverrider()
	{
	}
}
