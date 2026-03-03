using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A16")]
public class DuelEffectHandle : MonoBehaviour
{
	[Token(Token = "0x400F090")]
	[FieldOffset(Offset = "0x20")]
	protected GameObject target;

	[Token(Token = "0x400F091")]
	[FieldOffset(Offset = "0x28")]
	private float time;

	[Token(Token = "0x400F092")]
	[FieldOffset(Offset = "0x2C")]
	private float timeToQuit;

	[Token(Token = "0x400F093")]
	[FieldOffset(Offset = "0x30")]
	private bool reqQuit;

	[Token(Token = "0x400F094")]
	[FieldOffset(Offset = "0x31")]
	protected bool autoQuit;

	[Token(Token = "0x400F095")]
	[FieldOffset(Offset = "0x38")]
	private Action onFinished;

	[Token(Token = "0x400F096")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 defaultPosition;

	[Token(Token = "0x400F097")]
	[FieldOffset(Offset = "0x4C")]
	private Quaternion defaultRotation;

	[Token(Token = "0x400F098")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 defaultScale;

	[Token(Token = "0x170019FA")]
	public DuelEffectPool effectPool
	{
		[Token(Token = "0x600A89D")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A89E")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019FB")]
	public virtual bool isPlaying
	{
		[Token(Token = "0x600A8A4")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019FC")]
	public DuelEffectPool.Type type
	{
		[Token(Token = "0x600A8A5")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		[CompilerGenerated]
		get
		{
			return default(DuelEffectPool.Type);
		}
		[Token(Token = "0x600A8A6")]
		[Address(RVA = "0x99DB50", Offset = "0x99CD50", VA = "0x18099DB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A899")]
	[Address(RVA = "0xF4A290", Offset = "0xF49490", VA = "0x180F4A290")]
	public void Initialize(DuelEffectPool effectPool, DuelEffectPool.Type type, GameObject target, bool autoQuit, Action onFinished)
	{
	}

	[Token(Token = "0x600A89A")]
	[Address(RVA = "0xF4A620", Offset = "0xF49820", VA = "0x180F4A620")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A89B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	protected virtual void OnInitialize()
	{
	}

	[Token(Token = "0x600A89C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	protected virtual void OnTerminate()
	{
	}

	[Token(Token = "0x600A89F")]
	[Address(RVA = "0x55A020", Offset = "0x559220", VA = "0x18055A020", Slot = "6")]
	public virtual void Play()
	{
	}

	[Token(Token = "0x600A8A0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	protected virtual void OnPlay()
	{
	}

	[Token(Token = "0x600A8A1")]
	[Address(RVA = "0xF4A5A0", Offset = "0xF497A0", VA = "0x180F4A5A0")]
	public void Stop()
	{
	}

	[Token(Token = "0x600A8A2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	protected virtual void OnStop()
	{
	}

	[Token(Token = "0x600A8A3")]
	[Address(RVA = "0xF4A580", Offset = "0xF49780", VA = "0x180F4A580")]
	public void ReqQuit(float timeToQuit)
	{
	}

	[Token(Token = "0x600A8A7")]
	[Address(RVA = "0xF4A700", Offset = "0xF49900", VA = "0x180F4A700")]
	private void Update()
	{
	}

	[Token(Token = "0x600A8A8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x600A8A9")]
	[Address(RVA = "0xF4A430", Offset = "0xF49630", VA = "0x180F4A430")]
	private void QuitImmediate()
	{
	}

	[Token(Token = "0x600A8AA")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelEffectHandle()
	{
	}
}
