using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSystem.Utility;

[Token(Token = "0x2000393")]
public class SummonCountSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000394")]
	public class SummonCountInfo
	{
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public bool enable;

		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string note;

		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public int cardID;

		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public int countMax;

		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public Sprite iconSprite;

		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Sprite iconSpriteMax;

		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public string countMaxSE;

		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public List<DuelSummonCountManager.SummonType> targetTypes;

		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public List<DuelSummonCountManager.PositionType> positions;

		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x5C29F0", Offset = "0x5C1BF0", VA = "0x1805C29F0")]
		public SummonCountInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SummonCountInfo()
		{
		}
	}

	[Token(Token = "0x400124F")]
	private const string path = "Duel/ScriptableObject/SummonCountSetting";

	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x18")]
	public List<SummonCountInfo> countInfoList;

	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x0")]
	private static SummonCountSetting _instance;

	[Token(Token = "0x17000239")]
	public static SummonCountSetting instance
	{
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x5C2CE0", Offset = "0x5C1EE0", VA = "0x1805C2CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60015DE")]
	[Address(RVA = "0x5C2B70", Offset = "0x5C1D70", VA = "0x1805C2B70")]
	public SummonCountInfo Get(int cardID)
	{
		return null;
	}

	[Token(Token = "0x60015DF")]
	[Address(RVA = "0x5C2A70", Offset = "0x5C1C70", VA = "0x1805C2A70")]
	public Sprite GetIconSprite(int cardID, bool isMax = false)
	{
		return null;
	}

	[Token(Token = "0x60015E1")]
	[Address(RVA = "0x5C2C60", Offset = "0x5C1E60", VA = "0x1805C2C60")]
	public SummonCountSetting()
	{
	}
}
