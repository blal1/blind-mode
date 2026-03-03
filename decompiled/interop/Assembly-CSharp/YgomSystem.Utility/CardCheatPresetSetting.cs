using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSystem.Utility;

[Token(Token = "0x20003B8")]
public class CardCheatPresetSetting : ScriptableObject
{
	[Token(Token = "0x20003B9")]
	public enum PositionType
	{
		[Token(Token = "0x40012AE")]
		Field,
		[Token(Token = "0x40012AF")]
		Hand,
		[Token(Token = "0x40012B0")]
		Deck,
		[Token(Token = "0x40012B1")]
		Grave,
		[Token(Token = "0x40012B2")]
		Exclude
	}

	[Serializable]
	[Token(Token = "0x20003BA")]
	public class CheatInfo
	{
		[Token(Token = "0x40012B3")]
		[FieldOffset(Offset = "0x10")]
		public SharedDefinition.Location location;

		[Token(Token = "0x40012B4")]
		[FieldOffset(Offset = "0x14")]
		public PositionType position;

		[Token(Token = "0x40012B5")]
		[FieldOffset(Offset = "0x18")]
		public int cardID;

		[Token(Token = "0x40012B6")]
		[FieldOffset(Offset = "0x1C")]
		public int createNum;

		[Token(Token = "0x40012B7")]
		[FieldOffset(Offset = "0x20")]
		public string note;

		[Token(Token = "0x6001665")]
		[Address(RVA = "0x5A1F10", Offset = "0x5A1110", VA = "0x1805A1F10")]
		public CheatInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x6001666")]
		[Address(RVA = "0x5A1F90", Offset = "0x5A1190", VA = "0x1805A1F90")]
		public CheatInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003BB")]
	public class CheatPreset
	{
		[Token(Token = "0x40012B8")]
		[FieldOffset(Offset = "0x10")]
		public int presetID;

		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x18")]
		public List<CheatInfo> infoList;

		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x20")]
		public string note;

		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x28")]
		public int searchID;

		[Token(Token = "0x6001667")]
		[Address(RVA = "0x5A1FA0", Offset = "0x5A11A0", VA = "0x1805A1FA0")]
		public CheatPreset Copy()
		{
			return null;
		}

		[Token(Token = "0x6001668")]
		[Address(RVA = "0x5A21E0", Offset = "0x5A13E0", VA = "0x1805A21E0")]
		public CheatPreset()
		{
		}
	}

	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0x18")]
	public List<CheatPreset> presetList;

	[Token(Token = "0x40012AB")]
	private const string path = "Debug/ScriptableObjects/CardCheatPresetSetting";

	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x0")]
	private static CardCheatPresetSetting _instance;

	[Token(Token = "0x17000249")]
	public static CardCheatPresetSetting instance
	{
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x5A1D90", Offset = "0x5A0F90", VA = "0x1805A1D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600165F")]
	[Address(RVA = "0x5A1A90", Offset = "0x5A0C90", VA = "0x1805A1A90")]
	public CheatPreset GetAt(int index)
	{
		return null;
	}

	[Token(Token = "0x6001660")]
	[Address(RVA = "0x5A1C10", Offset = "0x5A0E10", VA = "0x1805A1C10")]
	public CheatPreset Get(int presetID)
	{
		return null;
	}

	[Token(Token = "0x6001661")]
	[Address(RVA = "0x5A1B10", Offset = "0x5A0D10", VA = "0x1805A1B10")]
	public int GetIndex(int presetID)
	{
		return default(int);
	}

	[Token(Token = "0x6001662")]
	[Address(RVA = "0x5A1BD0", Offset = "0x5A0DD0", VA = "0x1805A1BD0")]
	public int GetNum()
	{
		return default(int);
	}

	[Token(Token = "0x6001664")]
	[Address(RVA = "0x5A1D10", Offset = "0x5A0F10", VA = "0x1805A1D10")]
	public CardCheatPresetSetting()
	{
	}
}
