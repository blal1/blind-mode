using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x2000422")]
public class TweenContainer
{
	[Token(Token = "0x4001456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<Tween> tweens;

	[Token(Token = "0x4001457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Action onPlayFinished;

	[Token(Token = "0x4001458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string playingLabel;

	[Token(Token = "0x4001459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool playing;

	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x5F2810", Offset = "0x5F1A10", VA = "0x1805F2810")]
	public void Setup(GameObject target)
	{
	}

	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x5F2020", Offset = "0x5F1220", VA = "0x1805F2020")]
	public void AddTweens(Tween[] tweens)
	{
	}

	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x5F25B0", Offset = "0x5F17B0", VA = "0x1805F25B0")]
	public void Play(string playLabel, Action onPlayFinished, bool stop = true, string stopLabel = "")
	{
	}

	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x5F28A0", Offset = "0x5F1AA0", VA = "0x1805F28A0")]
	public void Stop(string label)
	{
	}

	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x5F23E0", Offset = "0x5F15E0", VA = "0x1805F23E0")]
	private bool IsPlaying([Optional] string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x5F2A80", Offset = "0x5F1C80", VA = "0x1805F2A80")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x5F2220", Offset = "0x5F1420", VA = "0x1805F2220")]
	public void Immediate(string label)
	{
	}

	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x5F2080", Offset = "0x5F1280", VA = "0x1805F2080")]
	public void CaptureFrom([Optional] string label)
	{
	}

	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0x5F2390", Offset = "0x5F1590", VA = "0x1805F2390")]
	private void InvokeOnPlayFinished()
	{
	}

	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x5F2B10", Offset = "0x5F1D10", VA = "0x1805F2B10")]
	public TweenContainer()
	{
	}
}
