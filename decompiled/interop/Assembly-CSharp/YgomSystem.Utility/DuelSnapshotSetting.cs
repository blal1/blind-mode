using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSystem.Utility;

[Token(Token = "0x20003CF")]
[CreateAssetMenu(menuName = "Scriptable Object/DuelSnapshotSetting")]
public class DuelSnapshotSetting : ScriptableObject
{
	[Token(Token = "0x20003D0")]
	public enum PositionType
	{
		[Token(Token = "0x4001335")]
		Field,
		[Token(Token = "0x4001336")]
		Hand,
		[Token(Token = "0x4001337")]
		Deck,
		[Token(Token = "0x4001338")]
		Extra,
		[Token(Token = "0x4001339")]
		Grave,
		[Token(Token = "0x400133A")]
		Exclude
	}

	[Serializable]
	[Token(Token = "0x20003D1")]
	public class SnapshotInfo
	{
		[Token(Token = "0x400133B")]
		[FieldOffset(Offset = "0x10")]
		public int cardID;

		[Token(Token = "0x400133C")]
		[FieldOffset(Offset = "0x18")]
		public string note;

		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0x20")]
		public SharedDefinition.Location location;

		[Token(Token = "0x400133E")]
		[FieldOffset(Offset = "0x24")]
		public PositionType position;

		[Token(Token = "0x400133F")]
		[FieldOffset(Offset = "0x28")]
		public int idx;

		[Token(Token = "0x4001340")]
		[FieldOffset(Offset = "0x2C")]
		public int fieldPos;

		[Token(Token = "0x4001341")]
		[FieldOffset(Offset = "0x30")]
		public bool face;

		[Token(Token = "0x4001342")]
		[FieldOffset(Offset = "0x31")]
		public bool turn;

		[Token(Token = "0x6001877")]
		[Address(RVA = "0x5C23A0", Offset = "0x5C15A0", VA = "0x1805C23A0")]
		public SnapshotInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x6001878")]
		[Address(RVA = "0x5C2790", Offset = "0x5C1990", VA = "0x1805C2790")]
		public Dictionary<string, object> GetDict()
		{
			return null;
		}

		[Token(Token = "0x6001879")]
		[Address(RVA = "0x5C2420", Offset = "0x5C1620", VA = "0x1805C2420")]
		public static SnapshotInfo CreateFromDict(Dictionary<string, object> dict)
		{
			return null;
		}

		[Token(Token = "0x600187A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SnapshotInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003D2")]
	public class DuelSnapshot
	{
		[Token(Token = "0x4001343")]
		[FieldOffset(Offset = "0x10")]
		public List<SnapshotInfo> infoList;

		[Token(Token = "0x4001344")]
		[FieldOffset(Offset = "0x18")]
		public string note;

		[Token(Token = "0x600187B")]
		[Address(RVA = "0x5BDEA0", Offset = "0x5BD0A0", VA = "0x1805BDEA0")]
		public DuelSnapshot Copy()
		{
			return null;
		}

		[Token(Token = "0x600187C")]
		[Address(RVA = "0x5BDDF0", Offset = "0x5BCFF0", VA = "0x1805BDDF0")]
		public void AddInfo(SnapshotInfo info)
		{
		}

		[Token(Token = "0x600187D")]
		[Address(RVA = "0x5BE4E0", Offset = "0x5BD6E0", VA = "0x1805BE4E0")]
		public Dictionary<string, object> GetDict()
		{
			return null;
		}

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x5BE0E0", Offset = "0x5BD2E0", VA = "0x1805BE0E0")]
		public static DuelSnapshot CreateFromDict(Dictionary<string, object> dict)
		{
			return null;
		}

		[Token(Token = "0x600187F")]
		[Address(RVA = "0x5BE790", Offset = "0x5BD990", VA = "0x1805BE790")]
		public DuelSnapshot()
		{
		}
	}

	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<DuelSnapshot> snapshotList;

	[Token(Token = "0x4001330")]
	private const string path = "Debug/ScriptableObjects/DuelSnapshotSetting";

	[Token(Token = "0x4001331")]
	private const string jsonFolderPath = "LocalSave/DuelSnapshot";

	[Token(Token = "0x4001332")]
	private const string jsonFilePath = "LocalSave/DuelSnapshot/DuelSnapshot.json";

	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0x0")]
	private static DuelSnapshotSetting _instance;

	[Token(Token = "0x17000256")]
	public static DuelSnapshotSetting instance
	{
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x5BDD60", Offset = "0x5BCF60", VA = "0x1805BDD60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600186C")]
	[Address(RVA = "0x5BD380", Offset = "0x5BC580", VA = "0x1805BD380")]
	public DuelSnapshot GetAt(int index)
	{
		return null;
	}

	[Token(Token = "0x600186D")]
	[Address(RVA = "0x5BD950", Offset = "0x5BCB50", VA = "0x1805BD950")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600186E")]
	[Address(RVA = "0x5BD400", Offset = "0x5BC600", VA = "0x1805BD400")]
	public int GetNum()
	{
		return default(int);
	}

	[Token(Token = "0x6001870")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void WriteData()
	{
	}

	[Token(Token = "0x6001871")]
	[Address(RVA = "0x5BD9C0", Offset = "0x5BCBC0", VA = "0x1805BD9C0")]
	public void WriteJson()
	{
	}

	[Token(Token = "0x6001872")]
	[Address(RVA = "0x5BD190", Offset = "0x5BC390", VA = "0x1805BD190")]
	public void CopyJsonToClipBoard(int index)
	{
	}

	[Token(Token = "0x6001873")]
	[Address(RVA = "0x5BD480", Offset = "0x5BC680", VA = "0x1805BD480")]
	public static void LoadJson()
	{
	}

	[Token(Token = "0x6001874")]
	[Address(RVA = "0x5BD0E0", Offset = "0x5BC2E0", VA = "0x1805BD0E0")]
	public void Add(DuelSnapshot duelSnapshot)
	{
	}

	[Token(Token = "0x6001875")]
	[Address(RVA = "0x5BD440", Offset = "0x5BC640", VA = "0x1805BD440")]
	public static PositionType GetPosType(int pos)
	{
		return default(PositionType);
	}

	[Token(Token = "0x6001876")]
	[Address(RVA = "0x5BDCE0", Offset = "0x5BCEE0", VA = "0x1805BDCE0")]
	public DuelSnapshotSetting()
	{
	}
}
