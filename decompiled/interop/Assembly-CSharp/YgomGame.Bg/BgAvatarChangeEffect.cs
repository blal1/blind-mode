using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Bg;

[Token(Token = "0x2001D31")]
public class BgAvatarChangeEffect : MonoBehaviour
{
	[Token(Token = "0x4010240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action delayCallback;

	[Token(Token = "0x4010241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool delayCheck;

	[Token(Token = "0x4010242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float playtime;

	[Token(Token = "0x4010243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float sePan;

	[Token(Token = "0x4010244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ElementObjectManager manager;

	[Token(Token = "0x4010245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem toMainObj;

	[Token(Token = "0x4010246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem toSubObj;

	[Token(Token = "0x4010247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float changeDelay;

	[Token(Token = "0x4010248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float delay;

	[Token(Token = "0x4010249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool playChangeEffectInAdvance;

	[Token(Token = "0x401024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string toMainLabel;

	[Token(Token = "0x401024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string toSubLabel;

	[Token(Token = "0x401024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string toMainSELabel;

	[Token(Token = "0x401024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string toSubSELabel;

	[Token(Token = "0x600BB96")]
	[Address(RVA = "0x562AE0", Offset = "0x561CE0", VA = "0x180562AE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BB97")]
	[Address(RVA = "0x562F90", Offset = "0x562190", VA = "0x180562F90")]
	private void Update()
	{
	}

	[Token(Token = "0x600BB98")]
	[Address(RVA = "0x562C30", Offset = "0x561E30", VA = "0x180562C30")]
	public void PlayEffect(bool toMain, [Optional] Action callback)
	{
	}

	[Token(Token = "0x600BB99")]
	[Address(RVA = "0x562E80", Offset = "0x562080", VA = "0x180562E80")]
	public void TraceMainCameraSetting(Camera target)
	{
	}

	[Token(Token = "0x600BB9A")]
	[Address(RVA = "0x562E70", Offset = "0x562070", VA = "0x180562E70")]
	public void SetSePan(float pan)
	{
	}

	[Token(Token = "0x600BB9B")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BgAvatarChangeEffect()
	{
	}
}
