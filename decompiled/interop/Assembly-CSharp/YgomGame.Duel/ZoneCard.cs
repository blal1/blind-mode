using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x2001AB9")]
public abstract class ZoneCard
{
	[Token(Token = "0x2001ABA")]
	public enum Zone
	{
		[Token(Token = "0x400F57D")]
		Grave,
		[Token(Token = "0x400F57E")]
		Exclude
	}

	[Token(Token = "0x2001ABB")]
	public enum Mode
	{
		[Token(Token = "0x400F580")]
		Out,
		[Token(Token = "0x400F581")]
		In
	}

	[Token(Token = "0x400F573")]
	[FieldOffset(Offset = "0x10")]
	protected GameObject autoReleaseObject;

	[Token(Token = "0x400F574")]
	[FieldOffset(Offset = "0x18")]
	protected PlayableDirector timeline;

	[Token(Token = "0x400F575")]
	[FieldOffset(Offset = "0x20")]
	protected Mode mode;

	[Token(Token = "0x400F579")]
	[FieldOffset(Offset = "0x50")]
	protected string timelineLabel;

	[Token(Token = "0x17001AE5")]
	public Vector3 position
	{
		[Token(Token = "0x600ADC3")]
		[Address(RVA = "0x453D50", Offset = "0x452F50", VA = "0x180453D50")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600ADC4")]
		[Address(RVA = "0x453DB0", Offset = "0x452FB0", VA = "0x180453DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AE6")]
	public Quaternion rotation
	{
		[Token(Token = "0x600ADC5")]
		[Address(RVA = "0x453D70", Offset = "0x452F70", VA = "0x180453D70")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600ADC6")]
		[Address(RVA = "0x453DC0", Offset = "0x452FC0", VA = "0x180453DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AE7")]
	public Vector3 scale
	{
		[Token(Token = "0x600ADC7")]
		[Address(RVA = "0x453D80", Offset = "0x452F80", VA = "0x180453D80")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600ADC8")]
		[Address(RVA = "0x453DD0", Offset = "0x452FD0", VA = "0x180453DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AE8")]
	public bool isPlaying
	{
		[Token(Token = "0x600ADC9")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ADCA")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001AE9")]
	public bool isPreparing
	{
		[Token(Token = "0x600ADCB")]
		[Address(RVA = "0x453D40", Offset = "0x452F40", VA = "0x180453D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ADCC")]
		[Address(RVA = "0x453DA0", Offset = "0x452FA0", VA = "0x180453DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600ADCD")]
	[Address(RVA = "0x4533A0", Offset = "0x4525A0", VA = "0x1804533A0")]
	protected void Initialize(Zone zone, Mode mode, int index, Action<ZoneCard> onLoadFinished)
	{
	}

	[Token(Token = "0x600ADCE")]
	[Address(RVA = "0x453930", Offset = "0x452B30", VA = "0x180453930")]
	public void Setup(int cardID, int uniqueID)
	{
	}

	[Token(Token = "0x600ADCF")]
	[Address(RVA = "0x453720", Offset = "0x452920", VA = "0x180453720")]
	private void LoadCardFront(int cardID, Material targetMaterial)
	{
	}

	[Token(Token = "0x600ADD0")]
	[Address(RVA = "0x453660", Offset = "0x452860", VA = "0x180453660")]
	private void LoadCardBack(int sleeveID, Action<Material> onFinished)
	{
	}

	[Token(Token = "0x600ADD1")]
	[Address(RVA = "0x453C30", Offset = "0x452E30", VA = "0x180453C30")]
	private string ZoneToTimelineLabel(Zone zone, Mode mode, int index)
	{
		return null;
	}

	[Token(Token = "0x600ADD2")]
	[Address(RVA = "0x453900", Offset = "0x452B00", VA = "0x180453900")]
	public void SetPosture(Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}

	[Token(Token = "0x600ADD3")]
	public abstract void Play(int cardID, int uniqueID, bool isFace, Action onPlayFinished);

	[Token(Token = "0x600ADD4")]
	[Address(RVA = "0x453B70", Offset = "0x452D70", VA = "0x180453B70", Slot = "5")]
	public virtual void Terminate()
	{
	}

	[Token(Token = "0x600ADD5")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected ZoneCard()
	{
	}
}
