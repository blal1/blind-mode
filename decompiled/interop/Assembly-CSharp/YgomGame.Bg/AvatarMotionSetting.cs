using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D94")]
public class AvatarMotionSetting : ScriptableObject
{
	[Token(Token = "0x2001D95")]
	public enum MotionID
	{
		[Token(Token = "0x4010443")]
		WAIT1,
		[Token(Token = "0x4010444")]
		WAIT2,
		[Token(Token = "0x4010445")]
		WAIT3,
		[Token(Token = "0x4010446")]
		MATCHING,
		[Token(Token = "0x4010447")]
		ENTRY,
		[Token(Token = "0x4010448")]
		ATTACK,
		[Token(Token = "0x4010449")]
		DAMAGE,
		[Token(Token = "0x401044A")]
		COST_DAMAGE,
		[Token(Token = "0x401044B")]
		VICTORY,
		[Token(Token = "0x401044C")]
		DEFEAT,
		[Token(Token = "0x401044D")]
		TAP1,
		[Token(Token = "0x401044E")]
		TAP2,
		[Token(Token = "0x401044F")]
		TAP3,
		[Token(Token = "0x4010450")]
		APPEAL,
		[Token(Token = "0x4010451")]
		SHOP,
		[Token(Token = "0x4010452")]
		PROFILE,
		[Token(Token = "0x4010453")]
		OUTGAME,
		[Token(Token = "0x4010454")]
		CHANGE,
		[Token(Token = "0x4010455")]
		CHANGE2
	}

	[Serializable]
	[Token(Token = "0x2001D96")]
	public class AvatarMotionInfo
	{
		[Token(Token = "0x4010456")]
		[FieldOffset(Offset = "0x10")]
		public MotionID motionID;

		[Token(Token = "0x4010457")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x600BD7E")]
		[Address(RVA = "0x582250", Offset = "0x581450", VA = "0x180582250")]
		public AvatarMotionInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600BD7F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AvatarMotionInfo()
		{
		}
	}

	[Token(Token = "0x401043F")]
	private const string avatarMotionSettingPath = "Duel/ScriptableObject/AvatarMotionSetting";

	[Token(Token = "0x4010440")]
	[FieldOffset(Offset = "0x0")]
	private static AvatarMotionSetting motionSetting;

	[Token(Token = "0x4010441")]
	[FieldOffset(Offset = "0x18")]
	public List<AvatarMotionInfo> motionInfoList;

	[Token(Token = "0x600BD7B")]
	[Address(RVA = "0x5822D0", Offset = "0x5814D0", VA = "0x1805822D0")]
	public AvatarMotionInfo GetMotionInfo(MotionID id)
	{
		return null;
	}

	[Token(Token = "0x600BD7C")]
	[Address(RVA = "0x5823A0", Offset = "0x5815A0", VA = "0x1805823A0")]
	public static AvatarMotionSetting Load()
	{
		return null;
	}

	[Token(Token = "0x600BD7D")]
	[Address(RVA = "0x582510", Offset = "0x581710", VA = "0x180582510")]
	public AvatarMotionSetting()
	{
	}
}
