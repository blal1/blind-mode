using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005BF")]
[RequireComponent(typeof(RectMask2D))]
public class PlatformRectMask2DOverrider : PropertyOverriderBase<RectMask2D>
{
	[Token(Token = "0x4001BD2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideVector4Property m_Padding;

	[Token(Token = "0x17000471")]
	public OverrideVector4Property padding
	{
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025DB")]
	[Address(RVA = "0x69C340", Offset = "0x69B540", VA = "0x18069C340", Slot = "26")]
	protected override void ImportImpl(RectMask2D target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025DC")]
	[Address(RVA = "0x69C2B0", Offset = "0x69B4B0", VA = "0x18069C2B0", Slot = "25")]
	protected override void ExportImpl(RectMask2D target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x69C3C0", Offset = "0x69B5C0", VA = "0x18069C3C0")]
	public PlatformRectMask2DOverrider()
	{
	}
}
