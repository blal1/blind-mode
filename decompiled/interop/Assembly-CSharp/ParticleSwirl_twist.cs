using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AF")]
public class ParticleSwirl_twist : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	private class ParticleInfo
	{
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x10")]
		public float particle_life;

		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x14")]
		public float particle_start_pos;

		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x18")]
		public float particle_range;

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x1C")]
		public float particle_rotation_x;

		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x20")]
		public float particle_rotation_y;

		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x24")]
		public float particle_rotation_z;

		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x28")]
		public float particle_twist_rotation;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ParticleInfo()
		{
		}
	}

	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem pe;

	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem.Particle[] particle;

	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x30")]
	public int particle_total;

	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x34")]
	public int start_particle_total;

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x38")]
	public float particle_appearance_interval;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x3C")]
	public float particle_appear_radius;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x40")]
	public float particle_appear_radius_max;

	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x44")]
	public float particle_thick;

	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x48")]
	public float appear_spread_time;

	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x4C")]
	public float appear_spread_speed;

	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x50")]
	public bool particle_3D_rotation;

	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x54")]
	public float converge_radius_spread_time;

	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x58")]
	public float converge_radius_spread_speed;

	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x5C")]
	public float converge_radius_max;

	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x60")]
	public float anlgle_speed;

	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0x64")]
	public float anlgle_accel;

	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x68")]
	public float anlgle_max_speed;

	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x6C")]
	public float circle_decrease_speed;

	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x70")]
	private int particle_num;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x74")]
	private int numParticlesAlive;

	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x78")]
	private float base_particle_angle;

	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x7C")]
	private float particule_appearance_time;

	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x80")]
	private float converge_radius;

	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x84")]
	private float base_particle_twist_angle;

	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x88")]
	private float time;

	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x8C")]
	private int cut_num;

	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x90")]
	private int cut_total;

	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x98")]
	private List<ParticleInfo> particleInfos;

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x67D660", Offset = "0x67C860", VA = "0x18067D660")]
	private void Start()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x67D750", Offset = "0x67C950", VA = "0x18067D750")]
	private void Update()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x67DA60", Offset = "0x67CC60", VA = "0x18067DA60")]
	private void particle_ini()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x67DCC0", Offset = "0x67CEC0", VA = "0x18067DCC0")]
	private void particle_move()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x67D960", Offset = "0x67CB60", VA = "0x18067D960")]
	public ParticleSwirl_twist()
	{
	}
}
