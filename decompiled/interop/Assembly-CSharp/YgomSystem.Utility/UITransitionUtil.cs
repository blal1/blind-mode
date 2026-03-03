using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x200041F")]
public class UITransitionUtil
{
	[Token(Token = "0x2000420")]
	public enum BlockType
	{
		[Token(Token = "0x4001450")]
		None,
		[Token(Token = "0x4001451")]
		Game,
		[Token(Token = "0x4001452")]
		System
	}

	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0x10")]
	private TweenContainer tweenContainer;

	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x5F7670", Offset = "0x5F6870", VA = "0x1805F7670")]
	public void Setup(GameObject target)
	{
	}

	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x5F7510", Offset = "0x5F6710", VA = "0x1805F7510")]
	public void Play(string label, BlockType blockType, Action onPlayFinished, bool stop, string stopLabel)
	{
	}

	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x5F74F0", Offset = "0x5F66F0", VA = "0x1805F74F0")]
	public void Immediate(string label)
	{
	}

	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x5F7790", Offset = "0x5F6990", VA = "0x1805F7790")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x6001A98")]
	[Address(RVA = "0x5F7760", Offset = "0x5F6960", VA = "0x1805F7760")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x5F74D0", Offset = "0x5F66D0", VA = "0x1805F74D0")]
	private int GetBlockPriority(BlockType blockType)
	{
		return default(int);
	}

	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public UITransitionUtil()
	{
	}
}
