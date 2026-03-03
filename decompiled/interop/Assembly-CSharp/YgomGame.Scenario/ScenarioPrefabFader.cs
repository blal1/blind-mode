using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A83")]
public class ScenarioPrefabFader : MonoBehaviour
{
	[Token(Token = "0x4009292")]
	[FieldOffset(Offset = "0x20")]
	private List<Material> m_TargetMaterials;

	[Token(Token = "0x4009293")]
	[FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x4009294")]
	[FieldOffset(Offset = "0x2C")]
	private float m_PastSec;

	[Token(Token = "0x4009295")]
	[FieldOffset(Offset = "0x30")]
	private float m_FromAlpha;

	[Token(Token = "0x4009296")]
	[FieldOffset(Offset = "0x34")]
	private float m_DstAlpha;

	[Token(Token = "0x4009297")]
	[FieldOffset(Offset = "0x38")]
	private float m_CurrentAlpha;

	[Token(Token = "0x14000055")]
	public event Action onCompleteEvent
	{
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x88EE60", Offset = "0x88E060", VA = "0x18088EE60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x88EF00", Offset = "0x88E100", VA = "0x18088EF00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60040C2")]
	[Address(RVA = "0x88E620", Offset = "0x88D820", VA = "0x18088E620")]
	public void AssignChildren(GameObject root)
	{
	}

	[Token(Token = "0x60040C3")]
	[Address(RVA = "0x88E900", Offset = "0x88DB00", VA = "0x18088E900")]
	public void Assign(GameObject target)
	{
	}

	[Token(Token = "0x60040C4")]
	[Address(RVA = "0x88E6D0", Offset = "0x88D8D0", VA = "0x18088E6D0")]
	public void Assign(MeshRenderer meshRenderer)
	{
	}

	[Token(Token = "0x60040C5")]
	[Address(RVA = "0x88E6D0", Offset = "0x88D8D0", VA = "0x18088E6D0")]
	public void Assign(SpriteRenderer spriteRenderer)
	{
	}

	[Token(Token = "0x60040C6")]
	[Address(RVA = "0x88E6D0", Offset = "0x88D8D0", VA = "0x18088E6D0")]
	public void Assign(ParticleSystemRenderer particleRenderer)
	{
	}

	[Token(Token = "0x60040C7")]
	[Address(RVA = "0x88E820", Offset = "0x88DA20", VA = "0x18088E820")]
	public void Assign(Material material)
	{
	}

	[Token(Token = "0x60040C8")]
	[Address(RVA = "0x88ED60", Offset = "0x88DF60", VA = "0x18088ED60")]
	public void PlayFadeIn()
	{
	}

	[Token(Token = "0x60040C9")]
	[Address(RVA = "0x88EDA0", Offset = "0x88DFA0", VA = "0x18088EDA0")]
	public void PlayFadeOut()
	{
	}

	[Token(Token = "0x60040CA")]
	[Address(RVA = "0x88EB80", Offset = "0x88DD80", VA = "0x18088EB80")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60040CB")]
	[Address(RVA = "0x88EDE0", Offset = "0x88DFE0", VA = "0x18088EDE0")]
	public ScenarioPrefabFader()
	{
	}
}
