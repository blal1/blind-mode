using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.Duel;

[Token(Token = "0x2001B70")]
public class EngineApiUtil
{
	[Token(Token = "0x2001B71")]
	public struct Place
	{
		[Token(Token = "0x400F8EC")]
		[FieldOffset(Offset = "0x0")]
		public int player;

		[Token(Token = "0x400F8ED")]
		[FieldOffset(Offset = "0x4")]
		public int position;

		[Token(Token = "0x400F8EE")]
		[FieldOffset(Offset = "0x8")]
		public int index;

		[Token(Token = "0x600B0FF")]
		[Address(RVA = "0x488410", Offset = "0x487610", VA = "0x180488410")]
		public Place(int player, int position, int index)
		{
		}

		[Token(Token = "0x600B100")]
		[Address(RVA = "0x488420", Offset = "0x487620", VA = "0x180488420")]
		public static bool operator ==(Place a, Place b)
		{
			return default(bool);
		}

		[Token(Token = "0x600B101")]
		[Address(RVA = "0x488440", Offset = "0x487640", VA = "0x180488440")]
		public static bool operator !=(Place a, Place b)
		{
			return default(bool);
		}

		[Token(Token = "0x600B102")]
		[Address(RVA = "0x4882D0", Offset = "0x4874D0", VA = "0x1804882D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600B103")]
		[Address(RVA = "0x488400", Offset = "0x487600", VA = "0x180488400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x400F8EB")]
	public const int uniqueIdStart = 1;

	[Token(Token = "0x600B0D7")]
	[Address(RVA = "0x486810", Offset = "0x485A10", VA = "0x180486810")]
	public static CardCollectionInfo.Regulation GetRegulation(int cardId)
	{
		return default(CardCollectionInfo.Regulation);
	}

	[Token(Token = "0x600B0D8")]
	[Address(RVA = "0x4868E0", Offset = "0x485AE0", VA = "0x1804868E0")]
	public static CardCollectionInfo.Regulation GetRegulation(int cardId, int regid)
	{
		return default(CardCollectionInfo.Regulation);
	}

	[Token(Token = "0x600B0D9")]
	[Address(RVA = "0x486350", Offset = "0x485550", VA = "0x180486350")]
	public static bool GetCardRealFace(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0DA")]
	[Address(RVA = "0x486230", Offset = "0x485430", VA = "0x180486230")]
	public static bool GetCardFace(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0DB")]
	[Address(RVA = "0x486F10", Offset = "0x486110", VA = "0x180486F10")]
	public static bool IsHandOpen(int player, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0DC")]
	[Address(RVA = "0x486F00", Offset = "0x486100", VA = "0x180486F00")]
	public static bool IsFieldPosition(int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0DD")]
	[Address(RVA = "0x487530", Offset = "0x486730", VA = "0x180487530")]
	public static bool IsMonsterPosition(int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0DE")]
	[Address(RVA = "0x487470", Offset = "0x486670", VA = "0x180487470")]
	public static bool IsMainMonsterPosition(int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0DF")]
	[Address(RVA = "0x486EF0", Offset = "0x4860F0", VA = "0x180486EF0")]
	public static bool IsExMonsterPosition(int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E0")]
	[Address(RVA = "0x487540", Offset = "0x486740", VA = "0x180487540")]
	public static bool IsPendulumPosition(int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E1")]
	[Address(RVA = "0x487450", Offset = "0x486650", VA = "0x180487450")]
	public static bool IsMagicPosition(int position, bool includeField = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E2")]
	[Address(RVA = "0x487550", Offset = "0x486750", VA = "0x180487550")]
	public static bool IsXyzMaterialPosition(int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E3")]
	[Address(RVA = "0x487480", Offset = "0x486680", VA = "0x180487480")]
	public static bool IsMaximumMaterialPosition(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E4")]
	[Address(RVA = "0x486B30", Offset = "0x485D30", VA = "0x180486B30")]
	public static bool IsCardKnown(int player, int position, int index, bool face)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E5")]
	[Address(RVA = "0x486D30", Offset = "0x485F30", VA = "0x180486D30")]
	public static bool IsCardKnown(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E6")]
	[Address(RVA = "0x486C50", Offset = "0x485E50", VA = "0x180486C50")]
	public static bool IsCardKnown(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E7")]
	[Address(RVA = "0x486E80", Offset = "0x486080", VA = "0x180486E80")]
	public static bool IsCardKnown(Engine.CardStatus status)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E8")]
	[Address(RVA = "0x4873A0", Offset = "0x4865A0", VA = "0x1804873A0")]
	public static bool IsMagicOrTrap(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0E9")]
	[Address(RVA = "0x4872B0", Offset = "0x4864B0", VA = "0x1804872B0")]
	public static bool IsMagicOrTrapByUniqueID(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0EA")]
	[Address(RVA = "0x487580", Offset = "0x486780", VA = "0x180487580")]
	public static ushort ToCardPos(int player, int position, int index)
	{
		return default(ushort);
	}

	[Token(Token = "0x600B0EB")]
	[Address(RVA = "0x485BD0", Offset = "0x484DD0", VA = "0x180485BD0")]
	public static (int, int, int) FromCardPos(ushort cardPos)
	{
		return default((int, int, int));
	}

	[Token(Token = "0x600B0EC")]
	[Address(RVA = "0x487010", Offset = "0x486210", VA = "0x180487010")]
	public static bool IsInsight(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0ED")]
	[Address(RVA = "0x4870A0", Offset = "0x4862A0", VA = "0x1804870A0")]
	public static bool IsInsight(Engine.CardStatus status)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0EE")]
	[Address(RVA = "0x485B00", Offset = "0x484D00", VA = "0x180485B00")]
	public static (int, int) BreakLong(int param)
	{
		return default((int, int));
	}

	[Token(Token = "0x600B0EF")]
	[Address(RVA = "0x485B60", Offset = "0x484D60", VA = "0x180485B60")]
	public static (int, int) BreakWord(int param)
	{
		return default((int, int));
	}

	[Token(Token = "0x600B0F0")]
	[Address(RVA = "0x486170", Offset = "0x485370", VA = "0x180486170")]
	public static bool GetCardExist(int player, int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0F1")]
	[Address(RVA = "0x487510", Offset = "0x486710", VA = "0x180487510")]
	public static bool IsMonsterNow(int position, int locate)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0F2")]
	[Address(RVA = "0x486480", Offset = "0x485680", VA = "0x180486480")]
	public static int GetCardUniqueID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600B0F3")]
	[Address(RVA = "0x485C40", Offset = "0x484E40", VA = "0x180485C40")]
	public static List<Place> GetAttackableMonsterPlaces()
	{
		return null;
	}

	[Token(Token = "0x600B0F4")]
	[Address(RVA = "0x486AB0", Offset = "0x485CB0", VA = "0x180486AB0")]
	public static bool IsAnythingCanDo()
	{
		return default(bool);
	}

	[Token(Token = "0x600B0F5")]
	[Address(RVA = "0x4869C0", Offset = "0x485BC0", VA = "0x1804869C0")]
	public static bool IsAnyCommand(int playerid)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0F6")]
	[Address(RVA = "0x487570", Offset = "0x486770", VA = "0x180487570")]
	public static uint RemoveNoneDuelCommandFlag(uint commandMask)
	{
		return default(uint);
	}

	[Token(Token = "0x600B0F7")]
	[Address(RVA = "0x4867A0", Offset = "0x4859A0", VA = "0x1804867A0")]
	public static uint GetCommandMaskRemoveNoneDuelFlag(int player, int position, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x600B0F8")]
	[Address(RVA = "0x486600", Offset = "0x485800", VA = "0x180486600")]
	public static List<Engine.CommandType> GetCommandList(int player, int position, int index)
	{
		return null;
	}

	[Token(Token = "0x600B0F9")]
	[Address(RVA = "0x4866F0", Offset = "0x4858F0", VA = "0x1804866F0")]
	public static List<Engine.CommandType> GetCommandList(uint commandMask)
	{
		return null;
	}

	[Token(Token = "0x600B0FA")]
	[Address(RVA = "0x486940", Offset = "0x485B40", VA = "0x180486940")]
	public static int GetTargetTopCardIndex(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600B0FB")]
	[Address(RVA = "0x485BC0", Offset = "0x484DC0", VA = "0x180485BC0")]
	public static bool ContainsAttribute(int bitMask, Engine.ListAttribute attribute)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0FC")]
	[Address(RVA = "0x485E20", Offset = "0x485020", VA = "0x180485E20")]
	public static List<Engine.ListAttribute> GetAttributeList(int bitMask)
	{
		return null;
	}

	[Token(Token = "0x600B0FD")]
	[Address(RVA = "0x487140", Offset = "0x486340", VA = "0x180487140")]
	public static bool IsLinkMonsterFromExtraDeck(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B0FE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public EngineApiUtil()
	{
	}
}
