using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F99")]
public class DiceRallyUtil : MonoBehaviour
{
	[Token(Token = "0x2000F9A")]
	public enum Category
	{
		[Token(Token = "0x400A959")]
		EDGE = 1,
		[Token(Token = "0x400A95A")]
		MOVE,
		[Token(Token = "0x400A95B")]
		CARD,
		[Token(Token = "0x400A95C")]
		RARITY,
		[Token(Token = "0x400A95D")]
		DUEL,
		[Token(Token = "0x400A95E")]
		MIGHTY
	}

	[Token(Token = "0x2000F9B")]
	public enum EdgeCategory
	{
		[Token(Token = "0x400A960")]
		START = 1,
		[Token(Token = "0x400A961")]
		GOAL
	}

	[Token(Token = "0x2000F9C")]
	public enum MoveCategory
	{
		[Token(Token = "0x400A963")]
		CONSTANT = 1
	}

	[Token(Token = "0x2000F9D")]
	public enum CardCategory
	{
		[Token(Token = "0x400A965")]
		N = 1,
		[Token(Token = "0x400A966")]
		R,
		[Token(Token = "0x400A967")]
		SR,
		[Token(Token = "0x400A968")]
		UR
	}

	[Token(Token = "0x2000F9E")]
	public enum DuelCategory
	{
		[Token(Token = "0x400A96A")]
		CARD = 1,
		[Token(Token = "0x400A96B")]
		LP,
		[Token(Token = "0x400A96C")]
		TIME
	}

	[Token(Token = "0x2000F9F")]
	public enum ZoomType
	{
		[Token(Token = "0x400A96E")]
		LARGE = 1,
		[Token(Token = "0x400A96F")]
		MEDIUM,
		[Token(Token = "0x400A970")]
		SMALL
	}

	[Token(Token = "0x2000FA0")]
	public enum TemplateSpace
	{
		[Token(Token = "0x400A972")]
		Card,
		[Token(Token = "0x400A973")]
		CardGet,
		[Token(Token = "0x400A974")]
		CardRarityUp,
		[Token(Token = "0x400A975")]
		DuelCardPlus1,
		[Token(Token = "0x400A976")]
		DuelLpHalf,
		[Token(Token = "0x400A977")]
		DuelTimeHalf,
		[Token(Token = "0x400A978")]
		MapPlus2,
		[Token(Token = "0x400A979")]
		RarityUp,
		[Token(Token = "0x400A97A")]
		Mighty,
		[Token(Token = "0x400A97B")]
		EdgeStart,
		[Token(Token = "0x400A97C")]
		EdgeGoal
	}

	[Token(Token = "0x6005EA9")]
	[Address(RVA = "0xA36C00", Offset = "0xA35E00", VA = "0x180A36C00")]
	public static bool GetIsPresentSend(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x6005EAA")]
	[Address(RVA = "0xA36C90", Offset = "0xA35E90", VA = "0x180A36C90")]
	public static int GetPlayBeginEffect(int eventId)
	{
		return default(int);
	}

	[Token(Token = "0x6005EAB")]
	[Address(RVA = "0xA36B70", Offset = "0xA35D70", VA = "0x180A36B70")]
	public static Dictionary<string, object> GetInfo(int eventId)
	{
		return null;
	}

	[Token(Token = "0x6005EAC")]
	[Address(RVA = "0xA36750", Offset = "0xA35950", VA = "0x180A36750")]
	public static Dictionary<string, object> GetBoardGrid(int eventId)
	{
		return null;
	}

	[Token(Token = "0x6005EAD")]
	[Address(RVA = "0xA367E0", Offset = "0xA359E0", VA = "0x180A367E0")]
	public static Dictionary<string, object> GetBoardInfo(int eventId)
	{
		return null;
	}

	[Token(Token = "0x6005EAE")]
	[Address(RVA = "0xA36AE0", Offset = "0xA35CE0", VA = "0x180A36AE0")]
	public static int GetCurrentGridNumber(int eventId)
	{
		return default(int);
	}

	[Token(Token = "0x6005EAF")]
	[Address(RVA = "0xA36D20", Offset = "0xA35F20", VA = "0x180A36D20")]
	public static int GetRarityUpCount(int eventId)
	{
		return default(int);
	}

	[Token(Token = "0x6005EB0")]
	[Address(RVA = "0xA372B0", Offset = "0xA364B0", VA = "0x180A372B0")]
	public static int GetTargetGachaId(int eventId)
	{
		return default(int);
	}

	[Token(Token = "0x6005EB1")]
	[Address(RVA = "0xA366C0", Offset = "0xA358C0", VA = "0x180A366C0")]
	public static int GetAddPoint(int eventId)
	{
		return default(int);
	}

	[Token(Token = "0x6005EB2")]
	[Address(RVA = "0xA36630", Offset = "0xA35830", VA = "0x180A36630")]
	public static Dictionary<string, object> GetAddPointDetail(int eventId)
	{
		return null;
	}

	[Token(Token = "0x6005EB3")]
	[Address(RVA = "0xA36DB0", Offset = "0xA35FB0", VA = "0x180A36DB0")]
	public static List<int> GetRollResult(int eventId)
	{
		return null;
	}

	[Token(Token = "0x6005EB4")]
	[Address(RVA = "0xA37020", Offset = "0xA36220", VA = "0x180A37020")]
	public static List<object> GetRollResult(int eventId, out bool isGoal)
	{
		return null;
	}

	[Token(Token = "0x6005EB5")]
	[Address(RVA = "0xA36870", Offset = "0xA35A70", VA = "0x180A36870")]
	public static List<int> GetCardList(int eventId)
	{
		return null;
	}

	[Token(Token = "0x6005EB6")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DiceRallyUtil()
	{
	}
}
