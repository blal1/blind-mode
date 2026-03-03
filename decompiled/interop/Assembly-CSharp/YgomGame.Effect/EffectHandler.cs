using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Effect;

[Token(Token = "0x2000E28")]
public class EffectHandler : MonoBehaviour
{
	[Token(Token = "0x400A254")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem[] particles;

	[Token(Token = "0x400A255")]
	[FieldOffset(Offset = "0x28")]
	private TrailRenderer[] trails;

	[Token(Token = "0x400A256")]
	[FieldOffset(Offset = "0x30")]
	private bool autoDestroy;

	[Token(Token = "0x400A257")]
	[FieldOffset(Offset = "0x38")]
	private Action onFinishedCallback;

	[Token(Token = "0x17000CCD")]
	public bool isPlaying
	{
		[Token(Token = "0x60055CA")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055CB")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60055CC")]
	[Address(RVA = "0x9B94B0", Offset = "0x9B86B0", VA = "0x1809B94B0")]
	public static void Create(string path, Transform parent, Action<EffectHandler> onLoadedCallback, bool autoDestroy)
	{
	}

	[Token(Token = "0x60055CD")]
	[Address(RVA = "0x9B93F0", Offset = "0x9B85F0", VA = "0x1809B93F0")]
	public static EffectHandler Create(GameObject target, bool autoDestroy)
	{
		return null;
	}

	[Token(Token = "0x60055CE")]
	[Address(RVA = "0x9B93A0", Offset = "0x9B85A0", VA = "0x1809B93A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60055CF")]
	[Address(RVA = "0x9B93A0", Offset = "0x9B85A0", VA = "0x1809B93A0")]
	public void Setup()
	{
	}

	[Token(Token = "0x60055D0")]
	[Address(RVA = "0x9B9690", Offset = "0x9B8890", VA = "0x1809B9690")]
	public void Play(Action onFinishedCallback)
	{
	}

	[Token(Token = "0x60055D1")]
	[Address(RVA = "0x9B95C0", Offset = "0x9B87C0", VA = "0x1809B95C0")]
	private bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x60055D2")]
	[Address(RVA = "0x9B9770", Offset = "0x9B8970", VA = "0x1809B9770")]
	public void Stop()
	{
	}

	[Token(Token = "0x60055D3")]
	[Address(RVA = "0x9B9830", Offset = "0x9B8A30", VA = "0x1809B9830")]
	private void Update()
	{
	}

	[Token(Token = "0x60055D4")]
	[Address(RVA = "0x44E9B0", Offset = "0x44DBB0", VA = "0x18044E9B0")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x60055D5")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public EffectHandler()
	{
	}
}
