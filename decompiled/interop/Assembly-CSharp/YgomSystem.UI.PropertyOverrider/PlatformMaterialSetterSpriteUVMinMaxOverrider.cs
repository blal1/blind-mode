using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Effect;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B7")]
[RequireComponent(typeof(MaterialSetterSpriteUVMinMax))]
[AddComponentMenu("Ygom/UI/Platform Overrider/MaterialSetterSpriteUVMinMax Overrider")]
public class PlatformMaterialSetterSpriteUVMinMaxOverrider : PlatformPropertyOverriderMultiBase<MaterialSetterSpriteUVMinMax>
{
	[Token(Token = "0x4001BC5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideSpriteProperty m_SourceSprite;

	[Token(Token = "0x60025A6")]
	[Address(RVA = "0x69BD70", Offset = "0x69AF70", VA = "0x18069BD70", Slot = "26")]
	protected override void ImportImpl(MaterialSetterSpriteUVMinMax target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x69BCC0", Offset = "0x69AEC0", VA = "0x18069BCC0", Slot = "25")]
	protected override void ExportImpl(MaterialSetterSpriteUVMinMax target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x69BDF0", Offset = "0x69AFF0", VA = "0x18069BDF0")]
	public PlatformMaterialSetterSpriteUVMinMaxOverrider()
	{
	}
}
