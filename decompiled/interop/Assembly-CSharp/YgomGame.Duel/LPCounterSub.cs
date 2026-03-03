using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001918")]
public class LPCounterSub : MonoBehaviour
{
	[Token(Token = "0x400EA98")]
	protected const string LABEL_TW_EFFECTRECOVER = "RecoverEffect";

	[Token(Token = "0x400EA99")]
	protected const string LABEL_TW_EFFECTDAMAGE = "DamageEffect";

	[Token(Token = "0x400EA9A")]
	protected const string LABEL_TW_EFFECTCOST = "CostEffect";

	[Token(Token = "0x400EA9B")]
	[FieldOffset(Offset = "0x20")]
	protected Action<Color, int, Engine.DamageType> onFinished;

	[Token(Token = "0x400EA9C")]
	[FieldOffset(Offset = "0x28")]
	protected Engine.DamageType m_Type;

	[Token(Token = "0x400EA9D")]
	[FieldOffset(Offset = "0x2C")]
	protected int m_TargetLP;

	[Token(Token = "0x400EA9E")]
	[FieldOffset(Offset = "0x30")]
	protected ExtendedTextMeshProUGUI m_SubText_Origin;

	[Token(Token = "0x170018BE")]
	protected ExtendedTextMeshProUGUI m_SubText
	{
		[Token(Token = "0x600A1C6")]
		[Address(RVA = "0xEED860", Offset = "0xEECA60", VA = "0x180EED860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018BF")]
	public bool active
	{
		[Token(Token = "0x600A1CA")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A1C7")]
	[Address(RVA = "0xEED3B0", Offset = "0xEEC5B0", VA = "0x180EED3B0")]
	public void ApplyEffect(int value, int targetlp, Vector2 startpos, Engine.DamageType type, Action<Color, int, Engine.DamageType> onFinished)
	{
	}

	[Token(Token = "0x600A1C8")]
	[Address(RVA = "0xEED5E0", Offset = "0xEEC7E0", VA = "0x180EED5E0")]
	public void OnEffectEnd()
	{
	}

	[Token(Token = "0x600A1C9")]
	[Address(RVA = "0xEED660", Offset = "0xEEC860", VA = "0x180EED660")]
	public void Reset()
	{
	}

	[Token(Token = "0x600A1CB")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LPCounterSub()
	{
	}
}
