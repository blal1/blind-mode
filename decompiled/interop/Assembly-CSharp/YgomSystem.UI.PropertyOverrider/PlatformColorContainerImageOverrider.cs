using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B0")]
[RequireComponent(typeof(ColorContainerImage))]
[AddComponentMenu("Ygom/UI/Platform Overrider/ColorContainerImage Overrider")]
public class PlatformColorContainerImageOverrider : PropertyOverriderBase<ColorContainerImage>
{
	[Token(Token = "0x4001B9F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int colorContainerIndex;

	[Token(Token = "0x4001BA0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Header("colorContainerIndexを複数持つ場合のみ必要")]
	public SelectionButton ownerButton;

	[Token(Token = "0x4001BA1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideSpriteProperty m_SpriteUnselected;

	[Token(Token = "0x4001BA2")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OverrideSpriteProperty m_SpriteSelected;

	[Token(Token = "0x4001BA3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private OverrideSpriteProperty m_SpriteButtonDown;

	[Token(Token = "0x4001BA4")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private OverrideSpriteProperty m_SpriteButtonEnter;

	[Token(Token = "0x4001BA5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private OverrideSpriteProperty m_SpriteInactive;

	[Token(Token = "0x17000455")]
	public OverrideSpriteProperty spriteUnselected
	{
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000456")]
	public OverrideSpriteProperty spriteSelected
	{
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000457")]
	public OverrideSpriteProperty spriteButtonDown
	{
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000458")]
	public OverrideSpriteProperty spriteButtonEnter
	{
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000459")]
	public OverrideSpriteProperty spriteInactive
	{
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002586")]
	[Address(RVA = "0x699CE0", Offset = "0x698EE0", VA = "0x180699CE0", Slot = "24")]
	protected override ColorContainerImage GetTargetComponent()
	{
		return null;
	}

	[Token(Token = "0x6002587")]
	[Address(RVA = "0x699D70", Offset = "0x698F70", VA = "0x180699D70", Slot = "26")]
	protected override void ImportImpl(ColorContainerImage target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002588")]
	[Address(RVA = "0x699B20", Offset = "0x698D20", VA = "0x180699B20", Slot = "25")]
	protected override void ExportImpl(ColorContainerImage target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002589")]
	[Address(RVA = "0x699EA0", Offset = "0x6990A0", VA = "0x180699EA0")]
	public PlatformColorContainerImageOverrider()
	{
	}
}
