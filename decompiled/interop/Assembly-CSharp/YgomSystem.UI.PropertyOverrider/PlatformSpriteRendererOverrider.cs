using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C4")]
[RequireComponent(typeof(SpriteRenderer))]
[AddComponentMenu("Ygom/UI/Platform Overrider/SpriteRenderer Overrider")]
public class PlatformSpriteRendererOverrider : PropertyOverriderBase<SpriteRenderer>
{
	[Token(Token = "0x4001BDC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideSpriteProperty m_Sprite;

	[Token(Token = "0x17000474")]
	public OverrideSpriteProperty sprite
	{
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x69CEE0", Offset = "0x69C0E0", VA = "0x18069CEE0", Slot = "26")]
	protected override void ImportImpl(SpriteRenderer target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025EE")]
	[Address(RVA = "0x69CE60", Offset = "0x69C060", VA = "0x18069CE60", Slot = "25")]
	protected override void ExportImpl(SpriteRenderer target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x69CF60", Offset = "0x69C160", VA = "0x18069CF60")]
	public PlatformSpriteRendererOverrider()
	{
	}
}
