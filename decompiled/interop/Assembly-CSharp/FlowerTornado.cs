using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AA")]
public class FlowerTornado : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	private class ParticleInfo
	{
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x10")]
		public float particle_life;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x14")]
		public float particle_start_pos;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x18")]
		public float particle_revo_range;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x1C")]
		public float particle_rotation_x;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x20")]
		public float particle_rotation_y;

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x24")]
		public float particle_rotation_z;

		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x28")]
		public float particle_twist_rotation;

		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x2C")]
		public float particle_dist;

		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x30")]
		public float particle_gravity;

		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x34")]
		public float particle_range;

		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x38")]
		public float particle_spread_speed;

		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x3C")]
		public float particle_spread_accel;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ParticleInfo()
		{
		}
	}

	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem pe;

	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem.Particle[] particle;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x30")]
	public int particle_total;

	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x34")]
	public int start_particle_total;

	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x38")]
	public float particle_appearance_interval;

	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x3C")]
	public float particle_appear_radius;

	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x40")]
	public float particle_appear_radius_max;

	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x44")]
	public float particle_thick;

	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x48")]
	public float particle_spread;

	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x4C")]
	public float particle_radius_ellipse;

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x50")]
	public float appear_spread_time;

	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x54")]
	public float appear_spread_speed;

	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x58")]
	public bool particle_3D_rotation;

	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x5C")]
	public float particle_distortion;

	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x60")]
	public float converge_radius_spread_time;

	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x64")]
	public float converge_radius_spread_speed;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x68")]
	public float converge_radius_max;

	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x6C")]
	public float anlgle_speed;

	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x70")]
	public float anlgle_accel;

	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x74")]
	public float anlgle_max_speed;

	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x78")]
	public float circle_decrease_speed;

	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x7C")]
	public int add_particle_total;

	[Token(Token = "0x4000349")]
	[FieldOffset(Offset = "0x80")]
	public float add_particle_time;

	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0x84")]
	public float gravity_start;

	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0x88")]
	public float gravity_accel;

	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x8C")]
	public float gravity_float;

	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x90")]
	private int particle_num;

	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x94")]
	private int numParticlesAlive;

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x98")]
	private float base_particle_angle;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x9C")]
	private float particule_appearance_time;

	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0xA0")]
	private float converge_radius;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0xA4")]
	private float base_particle_twist_angle;

	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0xA8")]
	private float time;

	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0xAC")]
	private int cut_num;

	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0xB0")]
	private int cut_total;

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0xB8")]
	private List<ParticleInfo> particleInfos;

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x679070", Offset = "0x678270", VA = "0x180679070")]
	private void Start()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x679140", Offset = "0x678340", VA = "0x180679140")]
	private void Update()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x679490", Offset = "0x678690", VA = "0x180679490")]
	private void particle_ini()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x679760", Offset = "0x678960", VA = "0x180679760")]
	private void particle_move()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x679350", Offset = "0x678550", VA = "0x180679350")]
	public FlowerTornado()
	{
	}
}
