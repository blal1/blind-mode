using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000300")]
public class VolumeAnimatorChannelMixer : VolumeAnimatorComponentBase<ChannelMixer>
{
	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool redOutRedIn_Ov;

	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Range(0f, 1f)]
	private float redOutRedIn_Val;

	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool redOutGreenIn_Ov;

	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float redOutGreenIn_Val;

	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool redOutBlueIn_Ov;

	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float redOutBlueIn_Val;

	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool greenOutRedIn_Ov;

	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float greenOutRedIn_Val;

	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool greenOutGreenIn_Ov;

	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Range(0f, 1f)]
	private float greenOutGreenIn_Val;

	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool greenOutBlueIn_Ov;

	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float greenOutBlueIn_Val;

	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool blueOutRedIn_Ov;

	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Range(0f, 1f)]
	private float blueOutRedIn_Val;

	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool blueOutGreenIn_Ov;

	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float blueOutGreenIn_Val;

	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool blueOutBlueIn_Ov;

	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Range(0f, 1f)]
	private float blueOutBlueIn_Val;

	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x41A2F0", Offset = "0x4194F0", VA = "0x18041A2F0", Slot = "10")]
	protected override void ExecuteImport(ChannelMixer component)
	{
	}

	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x41A040", Offset = "0x419240", VA = "0x18041A040", Slot = "11")]
	protected override void ExecuteExport(ChannelMixer component)
	{
	}

	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x41A5A0", Offset = "0x4197A0", VA = "0x18041A5A0")]
	public VolumeAnimatorChannelMixer()
	{
	}
}
