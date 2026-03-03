using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200187F")]
public class DuelActivatedCardEffect
{
	[Token(Token = "0x400E5F3")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, List<int>> myActivatedCardEffectNoDict;

	[Token(Token = "0x400E5F4")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, List<int>> rivalActivatedCardEffectNoDict;

	[Token(Token = "0x400E5F5")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<int, List<int>> mySpecialSummonEffectNoDict;

	[Token(Token = "0x400E5F6")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<int, List<int>> rivalSpecialSummonEffectNoDict;

	[Token(Token = "0x400E5F7")]
	[FieldOffset(Offset = "0x20")]
	private static bool myCardActivated;

	[Token(Token = "0x400E5F8")]
	[FieldOffset(Offset = "0x21")]
	private static bool rivalCardActivated;

	[Token(Token = "0x400E5F9")]
	[FieldOffset(Offset = "0x22")]
	public static bool showingActivatedIconCardEffectTextByButton;

	[Token(Token = "0x400E5FA")]
	[FieldOffset(Offset = "0x24")]
	public static int uIdActivatedIconCardEffectTextByButton;

	[Token(Token = "0x6009CCC")]
	[Address(RVA = "0xEA1120", Offset = "0xEA0320", VA = "0x180EA1120")]
	public static void CutinActivate(int player)
	{
	}

	[Token(Token = "0x6009CCD")]
	[Address(RVA = "0xEA0E60", Offset = "0xEA0060", VA = "0x180EA0E60")]
	public static void CardHappen(int cardId, int efxNo)
	{
	}

	[Token(Token = "0x6009CCE")]
	[Address(RVA = "0xEA1970", Offset = "0xEA0B70", VA = "0x180EA1970")]
	public static void SpecialSummonHappen(int cardId, int efxNo)
	{
	}

	[Token(Token = "0x6009CCF")]
	[Address(RVA = "0xEA1230", Offset = "0xEA0430", VA = "0x180EA1230")]
	public static void EffectTaskRunDialog(int cardId, int efxNo, int player)
	{
	}

	[Token(Token = "0x6009CD0")]
	[Address(RVA = "0xEA18B0", Offset = "0xEA0AB0", VA = "0x180EA18B0")]
	public static void SetShowActivatedIconCardEffectTextByButton(bool show)
	{
	}

	[Token(Token = "0x6009CD1")]
	[Address(RVA = "0xEA1910", Offset = "0xEA0B10", VA = "0x180EA1910")]
	public static void SetUniqueIdActivatedIconCardEffectTextByButton(int uId)
	{
	}

	[Token(Token = "0x6009CD2")]
	[Address(RVA = "0xEA0F40", Offset = "0xEA0140", VA = "0x180EA0F40")]
	public static bool CheckActivatedCardEffectNo(int cardId, int owner, bool checkSpSummon = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6009CD3")]
	[Address(RVA = "0xEA1330", Offset = "0xEA0530", VA = "0x180EA1330")]
	public static List<int> GetActivatedCardEffectNo(int cardId, int owner)
	{
		return null;
	}

	[Token(Token = "0x6009CD4")]
	[Address(RVA = "0xEA0CA0", Offset = "0xE9FEA0", VA = "0x180EA0CA0")]
	private static void AddActivatedCardEffectNoDict(Dictionary<int, List<int>> activatedCardEffectNoDict, int cardId, int efxNo, bool isSpecialSummon = false)
	{
	}

	[Token(Token = "0x6009CD5")]
	[Address(RVA = "0xEA1650", Offset = "0xEA0850", VA = "0x180EA1650")]
	public static void InitActivatedCardEffectDict()
	{
	}

	[Token(Token = "0x6009CD6")]
	[Address(RVA = "0xEA17D0", Offset = "0xEA09D0", VA = "0x180EA17D0")]
	public static void ResetActivatedCardEffectDictValue()
	{
	}

	[Token(Token = "0x6009CD7")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelActivatedCardEffect()
	{
	}
}
