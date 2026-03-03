using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004F4")]
[AddComponentMenu("Ygom/UI/Tween/Tween SE")]
public class TweenSE : Tween
{
	[Token(Token = "0x400186B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public string m_SoundLabel;

	[Token(Token = "0x400186C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public bool m_PlayOnFinish;

	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0x7C")]
	private int instanceId;

	[Token(Token = "0x400186E")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsPlayInFrame;

	[Token(Token = "0x60020A5")]
	[Address(RVA = "0x63E540", Offset = "0x63D740", VA = "0x18063E540", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020A6")]
	[Address(RVA = "0x63E530", Offset = "0x63D730", VA = "0x18063E530")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x63E660", Offset = "0x63D860", VA = "0x18063E660")]
	public TweenSE()
	{
	}
}
