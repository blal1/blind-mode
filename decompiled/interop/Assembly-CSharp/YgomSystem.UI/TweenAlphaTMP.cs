using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004E1")]
[AddComponentMenu("Ygom/UI/Tween/Tween Alpha TMP")]
public class TweenAlphaTMP : Tween
{
	[Token(Token = "0x4001823")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Range(0f, 1f)]
	public float from;

	[Token(Token = "0x4001824")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Range(0f, 1f)]
	public float to;

	[Token(Token = "0x4001825")]
	[FieldOffset(Offset = "0x78")]
	public bool isRecusive;

	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x80")]
	public List<TextMeshPro> childTMPs;

	[Token(Token = "0x600206F")]
	[Address(RVA = "0x639250", Offset = "0x638450", VA = "0x180639250", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002070")]
	[Address(RVA = "0x639480", Offset = "0x638680", VA = "0x180639480", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0x639680", Offset = "0x638880", VA = "0x180639680")]
	public TweenAlphaTMP()
	{
	}
}
