using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A72")]
public class SelectingCursorEffect : DuelEffectHandle
{
	[Token(Token = "0x400F398")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 from;

	[Token(Token = "0x400F399")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 to;

	[Token(Token = "0x400F39A")]
	[FieldOffset(Offset = "0x90")]
	private Color color;

	[Token(Token = "0x400F39B")]
	[FieldOffset(Offset = "0xA0")]
	private MeshRenderer mr;

	[Token(Token = "0x400F39C")]
	[FieldOffset(Offset = "0xA8")]
	private float rate;

	[Token(Token = "0x400F39D")]
	[FieldOffset(Offset = "0xAC")]
	private float timer;

	[Token(Token = "0x400F39E")]
	[FieldOffset(Offset = "0xB0")]
	private bool isEnd;

	[Token(Token = "0x400F39F")]
	[FieldOffset(Offset = "0xB1")]
	private bool isSetPosition;

	[Token(Token = "0x17001A7C")]
	public override bool isPlaying
	{
		[Token(Token = "0x600ABB4")]
		[Address(RVA = "0x42DC80", Offset = "0x42CE80", VA = "0x18042DC80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600ABAF")]
	[Address(RVA = "0x42DC20", Offset = "0x42CE20", VA = "0x18042DC20")]
	public void SetPosition(Vector3 srcPos, Vector3 dstPos)
	{
	}

	[Token(Token = "0x600ABB0")]
	[Address(RVA = "0x42DC10", Offset = "0x42CE10", VA = "0x18042DC10")]
	public void SetColor(Color col)
	{
	}

	[Token(Token = "0x600ABB1")]
	[Address(RVA = "0x42DC50", Offset = "0x42CE50", VA = "0x18042DC50")]
	public void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600ABB2")]
	[Address(RVA = "0x42D6C0", Offset = "0x42C8C0", VA = "0x18042D6C0", Slot = "4")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x600ABB3")]
	[Address(RVA = "0x42D7F0", Offset = "0x42C9F0", VA = "0x18042D7F0", Slot = "5")]
	protected override void OnTerminate()
	{
	}

	[Token(Token = "0x600ABB5")]
	[Address(RVA = "0x42D860", Offset = "0x42CA60", VA = "0x18042D860", Slot = "10")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600ABB6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600ABB7")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public SelectingCursorEffect()
	{
	}
}
