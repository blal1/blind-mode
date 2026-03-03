using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000541")]
public class ParticleAlphaGroup : MonoBehaviour
{
	[Token(Token = "0x400198D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_Alpha;

	[Token(Token = "0x400198E")]
	[FieldOffset(Offset = "0x28")]
	private List<ParticleAlphaGroupTarget> m_Targets;

	[Token(Token = "0x1700039D")]
	public float alpha
	{
		[Token(Token = "0x600222B")]
		[Address(RVA = "0x64BF80", Offset = "0x64B180", VA = "0x18064BF80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600222C")]
		[Address(RVA = "0x64BF90", Offset = "0x64B190", VA = "0x18064BF90")]
		set
		{
		}
	}

	[Token(Token = "0x600222D")]
	[Address(RVA = "0x64BE00", Offset = "0x64B000", VA = "0x18064BE00")]
	public void AssignTarget(ParticleAlphaGroupTarget target)
	{
	}

	[Token(Token = "0x600222E")]
	[Address(RVA = "0x64BF30", Offset = "0x64B130", VA = "0x18064BF30")]
	public void RemoveTarget(ParticleAlphaGroupTarget target)
	{
	}

	[Token(Token = "0x600222F")]
	[Address(RVA = "0x58BA00", Offset = "0x58AC00", VA = "0x18058BA00")]
	public ParticleAlphaGroup()
	{
	}
}
