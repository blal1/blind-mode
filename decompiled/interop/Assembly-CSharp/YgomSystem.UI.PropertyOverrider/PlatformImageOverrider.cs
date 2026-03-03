using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B2")]
[RequireComponent(typeof(Image))]
[AddComponentMenu("Ygom/UI/Platform Overrider/Image Overrider")]
public class PlatformImageOverrider : PropertyOverriderBase<Image>, ISupportedChangedEvent
{
	[Token(Token = "0x4001BAE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideSpriteProperty m_SourceImage;

	[Token(Token = "0x4001BAF")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideMaterialProperty m_Material;

	[Token(Token = "0x4001BB0")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UnityEvent m_OnChanged;

	[Token(Token = "0x1700045C")]
	public OverrideSpriteProperty sprite
	{
		[Token(Token = "0x600258F")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045D")]
	public OverrideMaterialProperty material
	{
		[Token(Token = "0x6002590")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045E")]
	public UnityEvent onChanged
	{
		[Token(Token = "0x6002591")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002592")]
	[Address(RVA = "0x69A880", Offset = "0x699A80", VA = "0x18069A880", Slot = "26")]
	protected override void ImportImpl(Image target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002593")]
	[Address(RVA = "0x69A790", Offset = "0x699990", VA = "0x18069A790", Slot = "25")]
	protected override void ExportImpl(Image target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0x69A9C0", Offset = "0x699BC0", VA = "0x18069A9C0")]
	public PlatformImageOverrider()
	{
	}
}
