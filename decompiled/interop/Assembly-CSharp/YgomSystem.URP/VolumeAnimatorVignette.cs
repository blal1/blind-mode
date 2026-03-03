using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x200030F")]
public class VolumeAnimatorVignette : VolumeAnimatorComponentBase<Vignette>
{
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool color_Ov;

	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Color color_Val;

	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool center_Ov;

	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector2 center_Val;

	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool intensity_Ov;

	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Range(0f, 1f)]
	private float intensity_Val;

	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool smoothness_Ov;

	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float smoothness_Val;

	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool rounded_Ov;

	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x61")]
	[SerializeField]
	private bool rounded_Val;

	[Token(Token = "0x6001318")]
	[Address(RVA = "0x41D730", Offset = "0x41C930", VA = "0x18041D730", Slot = "10")]
	protected override void ExecuteImport(Vignette component)
	{
	}

	[Token(Token = "0x6001319")]
	[Address(RVA = "0x41D590", Offset = "0x41C790", VA = "0x18041D590", Slot = "11")]
	protected override void ExecuteExport(Vignette component)
	{
	}

	[Token(Token = "0x600131A")]
	[Address(RVA = "0x41D8E0", Offset = "0x41CAE0", VA = "0x18041D8E0")]
	public VolumeAnimatorVignette()
	{
	}
}
