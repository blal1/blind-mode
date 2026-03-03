using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001942")]
public class BattleAimingEffect : DuelEffectHandle
{
	[Token(Token = "0x2001943")]
	public enum Shading
	{
		[Token(Token = "0x400EB83")]
		SURFACE,
		[Token(Token = "0x400EB84")]
		LINE
	}

	[Token(Token = "0x400EB70")]
	private const int TETRAGON_COUNT = 16;

	[Token(Token = "0x400EB71")]
	private const int NOSE_VERTEX_COUNT = 3;

	[Token(Token = "0x400EB72")]
	private const int ARROW_POLYGON_COUNT = 3;

	[Token(Token = "0x400EB73")]
	private const int Z_POINT_COUNT = 17;

	[Token(Token = "0x400EB74")]
	private const int VERTEX_COUNT = 37;

	[Token(Token = "0x400EB75")]
	[FieldOffset(Offset = "0x78")]
	private float STREACH_SPEED;

	[Token(Token = "0x400EB76")]
	[FieldOffset(Offset = "0x7C")]
	private float FADE_SPEED;

	[Token(Token = "0x400EB77")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 from;

	[Token(Token = "0x400EB78")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 to;

	[Token(Token = "0x400EB79")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 aim;

	[Token(Token = "0x400EB7A")]
	[FieldOffset(Offset = "0xA4")]
	private float width;

	[Token(Token = "0x400EB7B")]
	[FieldOffset(Offset = "0xA8")]
	private float alpha;

	[Token(Token = "0x400EB7C")]
	[FieldOffset(Offset = "0xAC")]
	private Color color;

	[Token(Token = "0x400EB7D")]
	[FieldOffset(Offset = "0xC0")]
	private MeshRenderer mr;

	[Token(Token = "0x400EB7E")]
	[FieldOffset(Offset = "0xC8")]
	private float lengthRate;

	[Token(Token = "0x400EB7F")]
	[FieldOffset(Offset = "0xCC")]
	private bool reqStop;

	[Token(Token = "0x400EB80")]
	[FieldOffset(Offset = "0xCD")]
	private bool isEnd;

	[Token(Token = "0x400EB81")]
	[FieldOffset(Offset = "0xCE")]
	private bool isSetPosition;

	[Token(Token = "0x170018F0")]
	public override bool isPlaying
	{
		[Token(Token = "0x600A2CB")]
		[Address(RVA = "0xEE9DA0", Offset = "0xEE8FA0", VA = "0x180EE9DA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A2C6")]
	[Address(RVA = "0xEE9C50", Offset = "0xEE8E50", VA = "0x180EE9C50")]
	public void SetPositions(Vector3 srcPos, Vector3 dstPos)
	{
	}

	[Token(Token = "0x600A2C7")]
	[Address(RVA = "0xEE9C40", Offset = "0xEE8E40", VA = "0x180EE9C40")]
	public void SetColor(Color col)
	{
	}

	[Token(Token = "0x600A2C8")]
	[Address(RVA = "0xEE9D70", Offset = "0xEE8F70", VA = "0x180EE9D70")]
	public void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600A2C9")]
	[Address(RVA = "0xEE9760", Offset = "0xEE8960", VA = "0x180EE9760", Slot = "4")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x600A2CA")]
	[Address(RVA = "0xEE98F0", Offset = "0xEE8AF0", VA = "0x180EE98F0", Slot = "5")]
	protected override void OnTerminate()
	{
	}

	[Token(Token = "0x600A2CC")]
	[Address(RVA = "0xEE9960", Offset = "0xEE8B60", VA = "0x180EE9960", Slot = "10")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600A2CD")]
	[Address(RVA = "0xAA2540", Offset = "0xAA1740", VA = "0x180AA2540", Slot = "8")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600A2CE")]
	[Address(RVA = "0xEE88F0", Offset = "0xEE7AF0", VA = "0x180EE88F0")]
	public static void MakeAimingArrowMesh(Shading shading, Mesh mesh, Vector3 from, Vector3 to, Vector3 aim, float lengthRate, float width, float wingWidthRate, Color color, Vector3 camPos, bool isTopHorizontally)
	{
	}

	[Token(Token = "0x600A2CF")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public BattleAimingEffect()
	{
	}
}
