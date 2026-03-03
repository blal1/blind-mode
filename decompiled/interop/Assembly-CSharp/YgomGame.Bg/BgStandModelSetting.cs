using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D69")]
public class BgStandModelSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001D6A")]
	public class StandModelInfo
	{
		[Token(Token = "0x40103A9")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40103AA")]
		[FieldOffset(Offset = "0x18")]
		public string modelName;

		[Token(Token = "0x600BCBF")]
		[Address(RVA = "0x58F360", Offset = "0x58E560", VA = "0x18058F360")]
		public StandModelInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600BCC0")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public StandModelInfo()
		{
		}
	}

	[Token(Token = "0x40103A5")]
	private const string standModelSettingPath = "Duel/ScriptableObject/Bg/BgStandModelSetting";

	[Token(Token = "0x40103A6")]
	private const string standModelResPath = "Duel/BG/AvatarStand/AvatarStand_{0}{1:000}/AvatarStand_{0}{1:000}_{2}";

	[Token(Token = "0x40103A7")]
	private const string standModelResTypePath = "Duel/BG/AvatarStand/AvatarStand_{0}{1:000}/<_RESOURCE_TYPE_>/AvatarStand_{0}{1:000}_{2}";

	[Token(Token = "0x40103A8")]
	[FieldOffset(Offset = "0x18")]
	public List<StandModelInfo> infoList;

	[Token(Token = "0x600BCB7")]
	[Address(RVA = "0x583810", Offset = "0x582A10", VA = "0x180583810")]
	public string GetModelName(int id)
	{
		return null;
	}

	[Token(Token = "0x600BCB8")]
	[Address(RVA = "0x583910", Offset = "0x582B10", VA = "0x180583910")]
	public int GetModelNo(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600BCB9")]
	[Address(RVA = "0x583FF0", Offset = "0x5831F0", VA = "0x180583FF0")]
	public BgUnit.AvatarStandType GetModelType(int id)
	{
		return default(BgUnit.AvatarStandType);
	}

	[Token(Token = "0x600BCBA")]
	[Address(RVA = "0x583A70", Offset = "0x582C70", VA = "0x180583A70")]
	public string GetModelResPath(int id, BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BCBB")]
	[Address(RVA = "0x584130", Offset = "0x583330", VA = "0x180584130")]
	public static void Load(Action<BgStandModelSetting> onFinish)
	{
	}

	[Token(Token = "0x600BCBC")]
	[Address(RVA = "0x583D20", Offset = "0x582F20", VA = "0x180583D20")]
	public static string GetModelResPath(BgUnit.AvatarStandType standType, int standNo, BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BCBD")]
	[Address(RVA = "0x5837A0", Offset = "0x5829A0", VA = "0x1805837A0")]
	public static string GetAvatarStandTypeInital(BgUnit.AvatarStandType standType)
	{
		return null;
	}

	[Token(Token = "0x600BCBE")]
	[Address(RVA = "0x584210", Offset = "0x583410", VA = "0x180584210")]
	public BgStandModelSetting()
	{
	}
}
