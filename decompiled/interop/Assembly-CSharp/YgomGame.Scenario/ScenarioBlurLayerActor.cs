using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Effect;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A5D")]
public class ScenarioBlurLayerActor
{
	[Token(Token = "0x40091B0")]
	[FieldOffset(Offset = "0x10")]
	private readonly int k_DepthBg;

	[Token(Token = "0x40091B1")]
	[FieldOffset(Offset = "0x14")]
	private readonly int k_DepthBgPrefab;

	[Token(Token = "0x40091B2")]
	[FieldOffset(Offset = "0x18")]
	private readonly int k_DepthCard;

	[Token(Token = "0x40091B3")]
	[FieldOffset(Offset = "0x1C")]
	private readonly int k_DepthCardPop;

	[Token(Token = "0x40091B4")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_MatKeyEffect;

	[Token(Token = "0x40091B5")]
	[FieldOffset(Offset = "0x28")]
	private readonly ElementObject m_Eo;

	[Token(Token = "0x40091B6")]
	[FieldOffset(Offset = "0x30")]
	private readonly ScenarioObjectContainer3D m_ObjectContainer3D;

	[Token(Token = "0x40091B7")]
	[FieldOffset(Offset = "0x38")]
	private readonly SpriteRenderer m_SpriteRenderer;

	[Token(Token = "0x40091B8")]
	[FieldOffset(Offset = "0x40")]
	public readonly SpriteScaler spriteScaler;

	[Token(Token = "0x40091B9")]
	[FieldOffset(Offset = "0x48")]
	private int m_Depth;

	[Token(Token = "0x17000883")]
	public float effect
	{
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x869B00", Offset = "0x868D00", VA = "0x180869B00")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x869B50", Offset = "0x868D50", VA = "0x180869B50")]
		set
		{
		}
	}

	[Token(Token = "0x17000884")]
	public int depth
	{
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x869B40", Offset = "0x868D40", VA = "0x180869B40")]
		set
		{
		}
	}

	[Token(Token = "0x6003FD3")]
	[Address(RVA = "0x8699F0", Offset = "0x868BF0", VA = "0x1808699F0")]
	public ScenarioBlurLayerActor(ElementObject eo, ScenarioObjectContainer3D objectContainer)
	{
	}

	[Token(Token = "0x6003FD4")]
	[Address(RVA = "0x869640", Offset = "0x868840", VA = "0x180869640")]
	private void ApplyDepthLayers()
	{
	}

	[Token(Token = "0x6003FD5")]
	[Address(RVA = "0x8698C0", Offset = "0x868AC0", VA = "0x1808698C0")]
	public void UpdateBlurLayerCard(ScenarioCardActor targetCard)
	{
	}

	[Token(Token = "0x6003FD6")]
	[Address(RVA = "0x8698B0", Offset = "0x868AB0", VA = "0x1808698B0")]
	public void UpdateBlurLayerBGPref(GameObject target)
	{
	}

	[Token(Token = "0x6003FD7")]
	[Address(RVA = "0x869930", Offset = "0x868B30", VA = "0x180869930")]
	private void UpdateBlurLayerGameObject(GameObject target, int targetDepth)
	{
	}
}
