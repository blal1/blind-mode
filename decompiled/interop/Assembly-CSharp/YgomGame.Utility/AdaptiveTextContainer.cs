using Il2CppDummyDll;
using UnityEngine.UI;

namespace YgomGame.Utility;

[Token(Token = "0x20008EF")]
public class AdaptiveTextContainer : ContentSizeFitter
{
	[Token(Token = "0x20008F0")]
	public enum Mode
	{
		[Token(Token = "0x40088E1")]
		HorizontalEx,
		[Token(Token = "0x40088E2")]
		VerticalEx
	}

	[Token(Token = "0x40088DD")]
	[FieldOffset(Offset = "0x38")]
	public int maxWidth;

	[Token(Token = "0x40088DE")]
	[FieldOffset(Offset = "0x3C")]
	public int maxHeight;

	[Token(Token = "0x40088DF")]
	[FieldOffset(Offset = "0x40")]
	public Mode mode;

	[Token(Token = "0x600359D")]
	[Address(RVA = "0x7B4CF0", Offset = "0x7B3EF0", VA = "0x1807B4CF0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600359E")]
	[Address(RVA = "0x7B4D20", Offset = "0x7B3F20", VA = "0x1807B4D20", Slot = "19")]
	public override void SetLayoutHorizontal()
	{
	}

	[Token(Token = "0x600359F")]
	[Address(RVA = "0x7B4DD0", Offset = "0x7B3FD0", VA = "0x1807B4DD0", Slot = "20")]
	public override void SetLayoutVertical()
	{
	}

	[Token(Token = "0x60035A0")]
	[Address(RVA = "0x7B4E80", Offset = "0x7B4080", VA = "0x1807B4E80")]
	public AdaptiveTextContainer()
	{
	}
}
