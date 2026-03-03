using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001948")]
[CreateAssetMenu(fileName = "BezierMotionContainer", menuName = "Scriptable Object/BezierMotionContainer")]
public class BezierMotionContainer : ScriptableObject
{
	[Token(Token = "0x400EB91")]
	[FieldOffset(Offset = "0x18")]
	public List<BezierMotionSetting> motionList;

	[Token(Token = "0x600A2DC")]
	[Address(RVA = "0xEEA9F0", Offset = "0xEE9BF0", VA = "0x180EEA9F0")]
	public ChainedBezierMotion GetChainedBezierMotion()
	{
		return null;
	}

	[Token(Token = "0x600A2DD")]
	[Address(RVA = "0xEEA7E0", Offset = "0xEE99E0", VA = "0x180EEA7E0")]
	public BezierMotionContainer Clone()
	{
		return null;
	}

	[Token(Token = "0x600A2DE")]
	[Address(RVA = "0xEEAA60", Offset = "0xEE9C60", VA = "0x180EEAA60")]
	public BezierMotionContainer()
	{
	}
}
