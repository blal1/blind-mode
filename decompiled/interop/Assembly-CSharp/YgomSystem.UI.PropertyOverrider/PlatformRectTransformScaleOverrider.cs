using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C1")]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("Ygom/UI/Platform Overrider/RectTransformScale Overrider")]
public class PlatformRectTransformScaleOverrider : PropertyOverriderBase<RectTransform>
{
	[Token(Token = "0x4001BD9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideVector3Property m_Scale;

	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x69CA00", Offset = "0x69BC00", VA = "0x18069CA00", Slot = "26")]
	protected override void ImportImpl(RectTransform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025E3")]
	[Address(RVA = "0x69C970", Offset = "0x69BB70", VA = "0x18069C970", Slot = "25")]
	protected override void ExportImpl(RectTransform target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x69CA90", Offset = "0x69BC90", VA = "0x18069CA90")]
	public PlatformRectTransformScaleOverrider()
	{
	}
}
