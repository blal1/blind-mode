using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B4")]
[RequireComponent(typeof(InfinityScrollView))]
[AddComponentMenu("Ygom/UI/Platform Overrider/InfinityScrollView Overrider")]
public class PlatformInfinityScrollViewOverrider : PropertyOverriderBase<InfinityScrollView>
{
	[Token(Token = "0x4001BB2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideStringProperty m_ELabelTemplate;

	[Token(Token = "0x6002598")]
	[Address(RVA = "0x69ACC0", Offset = "0x699EC0", VA = "0x18069ACC0", Slot = "26")]
	protected override void ImportImpl(InfinityScrollView target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0x69AC40", Offset = "0x699E40", VA = "0x18069AC40", Slot = "25")]
	protected override void ExportImpl(InfinityScrollView target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x600259A")]
	[Address(RVA = "0x69AD30", Offset = "0x699F30", VA = "0x18069AD30")]
	public PlatformInfinityScrollViewOverrider()
	{
	}
}
