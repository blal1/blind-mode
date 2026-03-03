using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D4F")]
public class BgGraveModelSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001D50")]
	public class GraveModelInfo
	{
		[Token(Token = "0x4010346")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4010347")]
		[FieldOffset(Offset = "0x18")]
		public string modelName;

		[Token(Token = "0x600BC2E")]
		[Address(RVA = "0x57A580", Offset = "0x579780", VA = "0x18057A580")]
		public GraveModelInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600BC2F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public GraveModelInfo()
		{
		}
	}

	[Token(Token = "0x4010341")]
	private const string graveModelSettingPath = "Duel/ScriptableObject/Bg/BgGraveModelSetting";

	[Token(Token = "0x4010342")]
	private const string graveResPath = "Duel/BG/Grave/Grave_{0}{1:000}/Grave_{0}{1:000}_{2}";

	[Token(Token = "0x4010343")]
	private const string graveResTypePath = "Duel/BG/Grave/Grave_{0}{1:000}/<_RESOURCE_TYPE_>/Grave_{0}{1:000}_{2}";

	[Token(Token = "0x4010344")]
	private const int defaultGraveNo = 2;

	[Token(Token = "0x4010345")]
	[FieldOffset(Offset = "0x18")]
	public List<GraveModelInfo> infoList;

	[Token(Token = "0x600BC26")]
	[Address(RVA = "0x567880", Offset = "0x566A80", VA = "0x180567880")]
	public string GetModelName(int id)
	{
		return null;
	}

	[Token(Token = "0x600BC27")]
	[Address(RVA = "0x567980", Offset = "0x566B80", VA = "0x180567980")]
	public int GetModelNo(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600BC28")]
	[Address(RVA = "0x567E80", Offset = "0x567080", VA = "0x180567E80")]
	public BgGrave.GraveType GetModelType(int id)
	{
		return default(BgGrave.GraveType);
	}

	[Token(Token = "0x600BC29")]
	[Address(RVA = "0x567E20", Offset = "0x567020", VA = "0x180567E20")]
	public string GetModelResPath(int id, BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BC2A")]
	[Address(RVA = "0x567FD0", Offset = "0x5671D0", VA = "0x180567FD0")]
	public static void Load(Action<BgGraveModelSetting> onFinish)
	{
	}

	[Token(Token = "0x600BC2B")]
	[Address(RVA = "0x567AE0", Offset = "0x566CE0", VA = "0x180567AE0")]
	public static string GetModelResPath(BgGrave.GraveType graveType, int graveNo, BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BC2C")]
	[Address(RVA = "0x567810", Offset = "0x566A10", VA = "0x180567810")]
	public static string GetGraveTypeInital(BgGrave.GraveType graveType)
	{
		return null;
	}

	[Token(Token = "0x600BC2D")]
	[Address(RVA = "0x5680B0", Offset = "0x5672B0", VA = "0x1805680B0")]
	public BgGraveModelSetting()
	{
	}
}
