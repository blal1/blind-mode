using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A60")]
public class ManualAimingEffect : DuelEffectHandle
{
	[Token(Token = "0x2001A61")]
	private enum Step
	{
		[Token(Token = "0x400F2F7")]
		MAIN,
		[Token(Token = "0x400F2F8")]
		FADEOUT,
		[Token(Token = "0x400F2F9")]
		END
	}

	[Token(Token = "0x400F2ED")]
	[FieldOffset(Offset = "0x78")]
	private Step step;

	[Token(Token = "0x400F2EE")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 aim;

	[Token(Token = "0x400F2EF")]
	[FieldOffset(Offset = "0x88")]
	private bool playing;

	[Token(Token = "0x400F2F0")]
	[FieldOffset(Offset = "0x8C")]
	private float lengthRate;

	[Token(Token = "0x400F2F1")]
	[FieldOffset(Offset = "0x90")]
	private float alpha;

	[Token(Token = "0x400F2F2")]
	[FieldOffset(Offset = "0x94")]
	private Color color;

	[Token(Token = "0x400F2F3")]
	[FieldOffset(Offset = "0xA4")]
	private BattleAimingEffect.Shading shading;

	[Token(Token = "0x17001A74")]
	public override bool isPlaying
	{
		[Token(Token = "0x600AB37")]
		[Address(RVA = "0x422F90", Offset = "0x422190", VA = "0x180422F90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A75")]
	public Vector3 from
	{
		[Token(Token = "0x600AB3B")]
		[Address(RVA = "0x422F70", Offset = "0x422170", VA = "0x180422F70")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600AB3C")]
		[Address(RVA = "0x422FC0", Offset = "0x4221C0", VA = "0x180422FC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A76")]
	public Vector3 to
	{
		[Token(Token = "0x600AB3D")]
		[Address(RVA = "0x422FA0", Offset = "0x4221A0", VA = "0x180422FA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600AB3E")]
		[Address(RVA = "0x422FE0", Offset = "0x4221E0", VA = "0x180422FE0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600AB32")]
	[Address(RVA = "0x422800", Offset = "0x421A00", VA = "0x180422800", Slot = "4")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x600AB33")]
	[Address(RVA = "0x4229C0", Offset = "0x421BC0", VA = "0x1804229C0", Slot = "5")]
	protected override void OnTerminate()
	{
	}

	[Token(Token = "0x600AB34")]
	[Address(RVA = "0x4229A0", Offset = "0x421BA0", VA = "0x1804229A0", Slot = "7")]
	protected override void OnPlay()
	{
	}

	[Token(Token = "0x600AB35")]
	[Address(RVA = "0x4229B0", Offset = "0x421BB0", VA = "0x1804229B0", Slot = "8")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600AB36")]
	[Address(RVA = "0x4229D0", Offset = "0x421BD0", VA = "0x1804229D0", Slot = "10")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600AB38")]
	[Address(RVA = "0x422EF0", Offset = "0x4220F0", VA = "0x180422EF0")]
	public void SetPosition(Vector3 from, Vector3 to)
	{
	}

	[Token(Token = "0x600AB39")]
	[Address(RVA = "0x422EE0", Offset = "0x4220E0", VA = "0x180422EE0")]
	public void SetColor(Color col)
	{
	}

	[Token(Token = "0x600AB3A")]
	[Address(RVA = "0x422F50", Offset = "0x422150", VA = "0x180422F50")]
	public void SetShading(BattleAimingEffect.Shading shading)
	{
	}

	[Token(Token = "0x600AB3F")]
	[Address(RVA = "0x4229A0", Offset = "0x421BA0", VA = "0x1804229A0")]
	private void Show()
	{
	}

	[Token(Token = "0x600AB40")]
	[Address(RVA = "0x422720", Offset = "0x421920", VA = "0x180422720")]
	private void Hide()
	{
	}

	[Token(Token = "0x600AB41")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public ManualAimingEffect()
	{
	}
}
