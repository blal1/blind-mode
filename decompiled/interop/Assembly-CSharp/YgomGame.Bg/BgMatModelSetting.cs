using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D5E")]
public class BgMatModelSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001D5F")]
	public class MatModelInfo
	{
		[Token(Token = "0x401038B")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x401038C")]
		[FieldOffset(Offset = "0x18")]
		public string modelName;

		[Token(Token = "0x401038D")]
		[FieldOffset(Offset = "0x20")]
		public string seLabel;

		[Token(Token = "0x401038E")]
		[FieldOffset(Offset = "0x28")]
		public bool isResources;

		[Token(Token = "0x600BC95")]
		[Address(RVA = "0x58BAF0", Offset = "0x58ACF0", VA = "0x18058BAF0")]
		public MatModelInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600BC96")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MatModelInfo()
		{
		}
	}

	[Token(Token = "0x4010386")]
	private const string matModelSettingPath = "Duel/ScriptableObject/Bg/BgMatModelSetting";

	[Token(Token = "0x4010387")]
	private const string bgModelResPath = "Duel/BG/Mat/Mat_{0:000}/Mat_{0:000}_{1}";

	[Token(Token = "0x4010388")]
	private const string bgModelResTypePath = "Duel/BG/Mat/Mat_{0:000}/<_RESOURCE_TYPE_>/Mat_{0:000}_{1}";

	[Token(Token = "0x4010389")]
	public const int defaultMatNo = 2;

	[Token(Token = "0x401038A")]
	[FieldOffset(Offset = "0x18")]
	public List<MatModelInfo> infoList;

	[Token(Token = "0x600BC8D")]
	[Address(RVA = "0x582A90", Offset = "0x581C90", VA = "0x180582A90")]
	public string GetPath(int id)
	{
		return null;
	}

	[Token(Token = "0x600BC8E")]
	[Address(RVA = "0x582670", Offset = "0x581870", VA = "0x180582670")]
	public int GetModelNo(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600BC8F")]
	[Address(RVA = "0x582590", Offset = "0x581790", VA = "0x180582590")]
	public int GetModelIdFromNo(int no)
	{
		return default(int);
	}

	[Token(Token = "0x600BC90")]
	[Address(RVA = "0x582B90", Offset = "0x581D90", VA = "0x180582B90")]
	public string GetSeLabel(int id)
	{
		return null;
	}

	[Token(Token = "0x600BC91")]
	[Address(RVA = "0x582770", Offset = "0x581970", VA = "0x180582770")]
	public string GetModelResPathFromId(int id, BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BC92")]
	[Address(RVA = "0x582E50", Offset = "0x582050", VA = "0x180582E50")]
	public static void Load(Action<BgMatModelSetting> onFinish)
	{
	}

	[Token(Token = "0x600BC93")]
	[Address(RVA = "0x582880", Offset = "0x581A80", VA = "0x180582880")]
	public static string GetModelResPath(int bgNo, BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BC94")]
	[Address(RVA = "0x582F30", Offset = "0x582130", VA = "0x180582F30")]
	public BgMatModelSetting()
	{
	}
}
