using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x200055F")]
[AddComponentMenu("")]
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
public class uGuiParticleBase : MaskableGraphic
{
	[Token(Token = "0x2000560")]
	private struct param
	{
		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 vel;

		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x8")]
		public float rot;

		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0xC")]
		public float scale;

		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0x10")]
		public Color col;

		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x20")]
		public int sid;
	}

	[Token(Token = "0x2000561")]
	private class prim
	{
		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0x10")]
		public uGuiParticleBase pbase;

		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x4001A36")]
		[FieldOffset(Offset = "0x1C")]
		public float time;

		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x20")]
		public float lifetime;

		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x24")]
		public param src;

		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x48")]
		public param dst;

		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x6C")]
		private float pt;

		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 ps;

		[Token(Token = "0x170003BA")]
		public Color color
		{
			[Token(Token = "0x60022DF")]
			[Address(RVA = "0x65BB60", Offset = "0x65AD60", VA = "0x18065BB60")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x170003BB")]
		public Vector2 pos
		{
			[Token(Token = "0x60022E0")]
			[Address(RVA = "0x65BC90", Offset = "0x65AE90", VA = "0x18065BC90")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170003BC")]
		public float scale
		{
			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x65BCE0", Offset = "0x65AEE0", VA = "0x18065BCE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170003BD")]
		public float rot
		{
			[Token(Token = "0x60022E2")]
			[Address(RVA = "0x65BCB0", Offset = "0x65AEB0", VA = "0x18065BCB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170003BE")]
		public int sid
		{
			[Token(Token = "0x60022E3")]
			[Address(RVA = "0x65BD60", Offset = "0x65AF60", VA = "0x18065BD60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x65BA70", Offset = "0x65AC70", VA = "0x18065BA70")]
		public prim(uGuiParticleBase pbase_, float lifetime_, float delaytime_, Vector2 pos_, Vector2 vel, float rot, float scale, Color color, int sid, Vector2 dstVel, float dstRot, float dstScale, Color dstColor, int dstSid)
		{
		}

		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x65BDD0", Offset = "0x65AFD0", VA = "0x18065BDD0")]
		public bool update(float tm)
		{
			return default(bool);
		}

		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x65B850", Offset = "0x65AA50", VA = "0x18065B850")]
		public static Vector2[] CreateUvs(int divide, Texture tex)
		{
			return null;
		}

		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x65B2A0", Offset = "0x65A4A0", VA = "0x18065B2A0")]
		public bool AddVert(VertexHelper vh, Vector2[] uvs)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001A28")]
	[FieldOffset(Offset = "0xE0")]
	public Texture texture;

	[Token(Token = "0x4001A29")]
	[FieldOffset(Offset = "0xE8")]
	public int divide;

	[Token(Token = "0x4001A2A")]
	[FieldOffset(Offset = "0xF0")]
	public AnimationCurve colorCurve;

	[Token(Token = "0x4001A2B")]
	[FieldOffset(Offset = "0xF8")]
	public AnimationCurve velocityCurve;

	[Token(Token = "0x4001A2C")]
	[FieldOffset(Offset = "0x100")]
	public AnimationCurve scaleCurve;

	[Token(Token = "0x4001A2D")]
	[FieldOffset(Offset = "0x108")]
	private List<prim> particles;

	[Token(Token = "0x4001A2E")]
	[FieldOffset(Offset = "0x110")]
	private Vector2[] uvs;

	[Token(Token = "0x170003B9")]
	public override Texture mainTexture
	{
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x65C2C0", Offset = "0x65B4C0", VA = "0x18065C2C0", Slot = "65")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60022DA")]
	[Address(RVA = "0x65BF50", Offset = "0x65B150", VA = "0x18065BF50")]
	public void AddParticle(float lifetime, float delaytime, Vector2 pos, Vector2 velocity, float rot, float scale, Color color, int sid, Vector2 endVelocity, float endRot, float endScale, Color endColor, int endSid)
	{
	}

	[Token(Token = "0x60022DB")]
	[Address(RVA = "0x65C100", Offset = "0x65B300", VA = "0x18065C100", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x65C3C0", Offset = "0x65B5C0", VA = "0x18065C3C0")]
	public uGuiParticleBase()
	{
	}
}
