using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AC")]
public class ParticleConverge : MonoBehaviour
{
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem pe;

	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem.Particle[] particle;

	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x30")]
	public int particle_total;

	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x34")]
	public float particle_radius;

	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x38")]
	public float particule_start_time;

	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x3C")]
	public float particule_appearance_interval;

	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x40")]
	private float particule_appearance_time;

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x44")]
	public float anlgle_speed;

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x48")]
	public float anlgle_accel;

	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x4C")]
	public float converge_time;

	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x50")]
	public float converge_size;

	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x54")]
	public float circle_decrease_speed;

	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x58")]
	private int particle_num;

	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x5C")]
	private float angle_interval;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x60")]
	private float particle_angle;

	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x64")]
	private float time;

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x67C760", Offset = "0x67B960", VA = "0x18067C760")]
	private void Start()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x67C7F0", Offset = "0x67B9F0", VA = "0x18067C7F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x67CBD0", Offset = "0x67BDD0", VA = "0x18067CBD0")]
	private void particle_ini()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x67CA00", Offset = "0x67BC00", VA = "0x18067CA00")]
	private void lay_converge()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x67C9B0", Offset = "0x67BBB0", VA = "0x18067C9B0")]
	public ParticleConverge()
	{
	}
}
