using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004E4")]
[AddComponentMenu("Ygom/UI/Tween/Tween Color To")]
public class TweenColorTo : Tween
{
	[Token(Token = "0x4001833")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public ColorLabelProperty toLabel;

	[Token(Token = "0x4001834")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Color to;

	[Token(Token = "0x4001835")]
	[FieldOffset(Offset = "0x88")]
	public bool isRecusive;

	[Token(Token = "0x4001836")]
	[FieldOffset(Offset = "0x90")]
	private List<KeyValuePair<Graphic, Color>> childGraps;

	[Token(Token = "0x6002078")]
	[Address(RVA = "0x63A500", Offset = "0x639700", VA = "0x18063A500", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002079")]
	[Address(RVA = "0x63A880", Offset = "0x639A80", VA = "0x18063A880", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600207A")]
	[Address(RVA = "0x63AC70", Offset = "0x639E70", VA = "0x18063AC70")]
	public TweenColorTo()
	{
	}
}
