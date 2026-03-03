using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AD")]
public class ParticleRingConverge : MonoBehaviour
{
	[Token(Token = "0x20000AE")]
	private class ParticleInfo
	{
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x10")]
		public float particle_life;

		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x14")]
		public float particle_start_pos;

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x18")]
		public float particle_range;

		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x1C")]
		public float particle_rotation_x;

		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x20")]
		public float particle_rotation_y;

		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x24")]
		public float particle_rotation_z;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ParticleInfo()
		{
		}
	}

	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem pe;

	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem.Particle[] particle;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x30")]
	public int particle_total;

	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x34")]
	public int start_particle_total;

	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x38")]
	public float particle_appearance_interval;

	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x3C")]
	public float particle_appear_radius;

	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x40")]
	public float particle_appear_radius_max;

	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x44")]
	public float appear_spread_time;

	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x48")]
	public float appear_spread_speed;

	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x4C")]
	public float converge_radius_spread_time;

	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x50")]
	public float converge_radius_spread_speed;

	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x54")]
	public float converge_radius_max;

	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x58")]
	public float anlgle_speed;

	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x5C")]
	public float anlgle_accel;

	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x60")]
	public float anlgle_max_speed;

	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x64")]
	public float circle_decrease_speed;

	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x68")]
	private int particle_num;

	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x6C")]
	private int numParticlesAlive;

	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x70")]
	private float base_particle_angle;

	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x74")]
	private float particule_appearance_time;

	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x78")]
	private float converge_radius;

	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x7C")]
	private float time;

	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x80")]
	private List<ParticleInfo> particleInfos;

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x67CD50", Offset = "0x67BF50", VA = "0x18067CD50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x67CE30", Offset = "0x67C030", VA = "0x18067CE30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x67D0F0", Offset = "0x67C2F0", VA = "0x18067D0F0")]
	private void particle_ini()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x67D260", Offset = "0x67C460", VA = "0x18067D260")]
	private void particle_move()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x67D010", Offset = "0x67C210", VA = "0x18067D010")]
	public ParticleRingConverge()
	{
	}
}
