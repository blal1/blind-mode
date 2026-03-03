using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001752")]
public class AdvantageGauge : MonoBehaviour
{
	[Token(Token = "0x400DBE4")]
	[FieldOffset(Offset = "0x0")]
	private static AdvantageGauge instance;

	[Token(Token = "0x400DBE5")]
	[FieldOffset(Offset = "0x20")]
	private float m_AdvantageCurrent;

	[Token(Token = "0x400DBE6")]
	[FieldOffset(Offset = "0x24")]
	private float m_AdvantageTarget;

	[Token(Token = "0x400DBE7")]
	[FieldOffset(Offset = "0x28")]
	private float m_AdvantageWave;

	[Token(Token = "0x400DBE8")]
	[FieldOffset(Offset = "0x2C")]
	private float m_AdvantageBias;

	[Token(Token = "0x400DBE9")]
	[FieldOffset(Offset = "0x30")]
	private float m_AdvantageBiasPre;

	[Token(Token = "0x400DBEA")]
	[FieldOffset(Offset = "0x34")]
	private int playerid;

	[Token(Token = "0x400DBEB")]
	[FieldOffset(Offset = "0x38")]
	private int rivalid;

	[Token(Token = "0x400DBEC")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_ShowEffect;

	[Token(Token = "0x400DBED")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_Eomanager;

	[Token(Token = "0x400DBEF")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Material material;

	[Token(Token = "0x17001684")]
	public static bool isCalc
	{
		[Token(Token = "0x600927A")]
		[Address(RVA = "0xDC3EF0", Offset = "0xDC30F0", VA = "0x180DC3EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009279")]
		[Address(RVA = "0xDC3F30", Offset = "0xDC3130", VA = "0x180DC3F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600927B")]
	[Address(RVA = "0xDC3340", Offset = "0xDC2540", VA = "0x180DC3340")]
	public static AdvantageGauge Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600927C")]
	[Address(RVA = "0xDC3A30", Offset = "0xDC2C30", VA = "0x180DC3A30")]
	public static bool SwitchGaugeVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600927D")]
	[Address(RVA = "0xDC3970", Offset = "0xDC2B70", VA = "0x180DC3970")]
	public static bool SwitchEffectVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600927E")]
	[Address(RVA = "0xDC3800", Offset = "0xDC2A00", VA = "0x180DC3800")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600927F")]
	[Address(RVA = "0xDC3B40", Offset = "0xDC2D40", VA = "0x180DC3B40")]
	private void Update()
	{
	}

	[Token(Token = "0x6009280")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public AdvantageGauge()
	{
	}
}
