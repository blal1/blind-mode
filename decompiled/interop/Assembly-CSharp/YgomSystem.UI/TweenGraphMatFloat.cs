using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Effect;

namespace YgomSystem.UI;

[Token(Token = "0x20004E7")]
[AddComponentMenu("Ygom/UI/Tween/Tween Graph Material Float")]
public class TweenGraphMatFloat : Tween
{
	[Token(Token = "0x400183C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public string field;

	[Token(Token = "0x400183D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public float from;

	[Token(Token = "0x400183E")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public float to;

	[Token(Token = "0x400183F")]
	[FieldOffset(Offset = "0x80")]
	private MaterialSetterGraphWriter m_TargetWriter;

	[Token(Token = "0x6002081")]
	[Address(RVA = "0x63B840", Offset = "0x63AA40", VA = "0x18063B840", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002082")]
	[Address(RVA = "0x63B960", Offset = "0x63AB60", VA = "0x18063B960")]
	public TweenGraphMatFloat()
	{
	}
}
