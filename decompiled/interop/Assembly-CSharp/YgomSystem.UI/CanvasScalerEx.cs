using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x200052B")]
public class CanvasScalerEx : CanvasScaler
{
	[Token(Token = "0x4001934")]
	[FieldOffset(Offset = "0x68")]
	private Rect camPixelRext;

	[Token(Token = "0x4001935")]
	[FieldOffset(Offset = "0x78")]
	private Vector2 orgResolution;

	[Token(Token = "0x4001936")]
	[FieldOffset(Offset = "0x80")]
	private Canvas canvas;

	[Token(Token = "0x4001937")]
	[FieldOffset(Offset = "0x88")]
	private bool isInit;

	[Token(Token = "0x600218B")]
	[Address(RVA = "0x635540", Offset = "0x634740", VA = "0x180635540", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600218C")]
	[Address(RVA = "0x6353D0", Offset = "0x6345D0", VA = "0x1806353D0")]
	private void CalcScale()
	{
	}

	[Token(Token = "0x600218D")]
	[Address(RVA = "0x635760", Offset = "0x634960", VA = "0x180635760")]
	public CanvasScalerEx()
	{
	}
}
