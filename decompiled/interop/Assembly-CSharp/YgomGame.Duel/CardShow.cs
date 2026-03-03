using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019E2")]
public class CardShow
{
	[Token(Token = "0x20019E3")]
	public enum Step
	{
		[Token(Token = "0x400EEE9")]
		Init,
		[Token(Token = "0x400EEEA")]
		WaitLoad,
		[Token(Token = "0x400EEEB")]
		Move,
		[Token(Token = "0x400EEEC")]
		Wait,
		[Token(Token = "0x400EEED")]
		Back,
		[Token(Token = "0x400EEEE")]
		Finish
	}

	[Token(Token = "0x20019E4")]
	public enum Mode
	{
		[Token(Token = "0x400EEF0")]
		Happen,
		[Token(Token = "0x400EEF1")]
		Disabled,
		[Token(Token = "0x400EEF2")]
		Apply
	}

	[Token(Token = "0x400EED5")]
	[FieldOffset(Offset = "0x40")]
	private CardRoot cardRoot;

	[Token(Token = "0x400EED6")]
	[FieldOffset(Offset = "0x48")]
	private bool cardFace;

	[Token(Token = "0x400EED7")]
	[FieldOffset(Offset = "0x4C")]
	private Mode mode;

	[Token(Token = "0x400EED8")]
	[FieldOffset(Offset = "0x50")]
	private int team;

	[Token(Token = "0x400EED9")]
	[FieldOffset(Offset = "0x54")]
	private int position;

	[Token(Token = "0x400EEDA")]
	[FieldOffset(Offset = "0x58")]
	private float time;

	[Token(Token = "0x400EEDB")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 startPosition;

	[Token(Token = "0x400EEDC")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion startRotation;

	[Token(Token = "0x400EEDD")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 startScale;

	[Token(Token = "0x400EEDE")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 movedPosition;

	[Token(Token = "0x400EEDF")]
	[FieldOffset(Offset = "0x90")]
	private Quaternion movedRotation;

	[Token(Token = "0x400EEE0")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 movedScale;

	[Token(Token = "0x400EEE1")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 waitedPosition;

	[Token(Token = "0x400EEE2")]
	[FieldOffset(Offset = "0xB8")]
	private Quaternion waitedRotation;

	[Token(Token = "0x400EEE3")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 waitedScale;

	[Token(Token = "0x400EEE4")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 destScale;

	[Token(Token = "0x400EEE5")]
	[FieldOffset(Offset = "0xE0")]
	private BezierMotionSetting motionShow;

	[Token(Token = "0x400EEE6")]
	[FieldOffset(Offset = "0xE8")]
	private BezierMotionSetting motionWait;

	[Token(Token = "0x400EEE7")]
	[FieldOffset(Offset = "0xF0")]
	private BezierMotionSetting motionBack;

	[Token(Token = "0x1700199F")]
	public Action OnInitCallback
	{
		[Token(Token = "0x600A6C7")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x600A6C6")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170019A0")]
	public Action OnMoveCallback
	{
		[Token(Token = "0x600A6C9")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x600A6C8")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170019A1")]
	public Action OnWaitCallback
	{
		[Token(Token = "0x600A6CB")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x600A6CA")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170019A2")]
	public Action OnBackCallback
	{
		[Token(Token = "0x600A6CD")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x600A6CC")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170019A3")]
	public Action OnFinishCallback
	{
		[Token(Token = "0x600A6CF")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x600A6CE")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170019A4")]
	public Step step
	{
		[Token(Token = "0x600A6D0")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		[CompilerGenerated]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x600A6D1")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A6D2")]
	[Address(RVA = "0xF285F0", Offset = "0xF277F0", VA = "0x180F285F0")]
	public void Initialize(CardRoot setCardRoot, Mode mode, int team, int position)
	{
	}

	[Token(Token = "0x600A6D3")]
	[Address(RVA = "0xF28A70", Offset = "0xF27C70", VA = "0x180F28A70")]
	public void UpdateStatus()
	{
	}

	[Token(Token = "0x600A6D4")]
	[Address(RVA = "0xF281B0", Offset = "0xF273B0", VA = "0x180F281B0")]
	private void Init()
	{
	}

	[Token(Token = "0x600A6D5")]
	[Address(RVA = "0xF28CB0", Offset = "0xF27EB0", VA = "0x180F28CB0")]
	private void WaitLoad()
	{
	}

	[Token(Token = "0x600A6D6")]
	[Address(RVA = "0xF28640", Offset = "0xF27840", VA = "0x180F28640")]
	private void Move()
	{
	}

	[Token(Token = "0x600A6D7")]
	[Address(RVA = "0xF28DD0", Offset = "0xF27FD0", VA = "0x180F28DD0")]
	private void Wait()
	{
	}

	[Token(Token = "0x600A6D8")]
	[Address(RVA = "0xF27EC0", Offset = "0xF270C0", VA = "0x180F27EC0")]
	private void Back()
	{
	}

	[Token(Token = "0x600A6D9")]
	[Address(RVA = "0xF28170", Offset = "0xF27370", VA = "0x180F28170")]
	private void Finish()
	{
	}

	[Token(Token = "0x600A6DA")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardShow()
	{
	}
}
