using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A4C")]
public class SeasonPointUtil : MonoBehaviour
{
	[Token(Token = "0x2000A4D")]
	public enum MemberStatus
	{
		[Token(Token = "0x4009147")]
		NotEntry,
		[Token(Token = "0x4009148")]
		Entry,
		[Token(Token = "0x4009149")]
		RequestDisband
	}

	[Token(Token = "0x2000A4E")]
	public enum TeamStatus
	{
		[Token(Token = "0x400914B")]
		NotExist,
		[Token(Token = "0x400914C")]
		Invited,
		[Token(Token = "0x400914D")]
		Formed,
		[Token(Token = "0x400914E")]
		Disband,
		[Token(Token = "0x400914F")]
		LeaderDisbanded,
		[Token(Token = "0x4009150")]
		MemberDisbanded
	}

	[Token(Token = "0x4009143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string ArgsKey_OnCompleted;

	[Token(Token = "0x4009144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string ArgsKey_IsOwn;

	[Token(Token = "0x4009145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string ArgsKey_UniqueId;

	[Token(Token = "0x6003F36")]
	[Address(RVA = "0x877940", Offset = "0x876B40", VA = "0x180877940")]
	public static void HandleResultCode(Handle handle, UnityAction onSuccess, [Optional] Action<SeasonPtCode> onFailed)
	{
	}

	[Token(Token = "0x6003F37")]
	[Address(RVA = "0x877EA0", Offset = "0x8770A0", VA = "0x180877EA0")]
	public static TextMeshProUGUI SetRankText(TextMeshProUGUI text, int rank)
	{
		return null;
	}

	[Token(Token = "0x6003F38")]
	[Address(RVA = "0x877750", Offset = "0x876950", VA = "0x180877750")]
	public static string GetTeamCreateLimit()
	{
		return null;
	}

	[Token(Token = "0x6003F39")]
	[Address(RVA = "0x877630", Offset = "0x876830", VA = "0x180877630")]
	public static string GetSeasonYearText()
	{
		return null;
	}

	[Token(Token = "0x6003F3A")]
	[Address(RVA = "0x876C40", Offset = "0x875E40", VA = "0x180876C40")]
	public static Dictionary<string, object> GetInviteMember(int index)
	{
		return null;
	}

	[Token(Token = "0x6003F3B")]
	[Address(RVA = "0x876FA0", Offset = "0x8761A0", VA = "0x180876FA0")]
	public static Dictionary<string, object> GetSeasonPtDic()
	{
		return null;
	}

	[Token(Token = "0x6003F3C")]
	[Address(RVA = "0x8772E0", Offset = "0x8764E0", VA = "0x1808772E0")]
	public static Dictionary<string, object> GetSeasonPtTeamDic(bool isResult = false)
	{
		return null;
	}

	[Token(Token = "0x6003F3D")]
	[Address(RVA = "0x877420", Offset = "0x876620", VA = "0x180877420")]
	public static int GetSeasonPtTeamUniqueId()
	{
		return default(int);
	}

	[Token(Token = "0x6003F3E")]
	[Address(RVA = "0x877340", Offset = "0x876540", VA = "0x180877340")]
	public static Dictionary<string, object> GetSeasonPtTeamMemberDic(int index)
	{
		return null;
	}

	[Token(Token = "0x6003F3F")]
	[Address(RVA = "0x877060", Offset = "0x876260", VA = "0x180877060")]
	public static Dictionary<string, object> GetSeasonPtPtDic()
	{
		return null;
	}

	[Token(Token = "0x6003F40")]
	[Address(RVA = "0x876ED0", Offset = "0x8760D0", VA = "0x180876ED0")]
	public static int GetOwnSeasonPt()
	{
		return default(int);
	}

	[Token(Token = "0x6003F41")]
	[Address(RVA = "0x8778E0", Offset = "0x876AE0", VA = "0x1808778E0")]
	public static int GetTeamTotalSeasonPt()
	{
		return default(int);
	}

	[Token(Token = "0x6003F42")]
	[Address(RVA = "0x876E40", Offset = "0x876040", VA = "0x180876E40")]
	public static int GetMemberSeasonPt(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6003F43")]
	[Address(RVA = "0x876CD0", Offset = "0x875ED0", VA = "0x180876CD0")]
	public static string GetLeaderName()
	{
		return null;
	}

	[Token(Token = "0x6003F44")]
	[Address(RVA = "0x8771A0", Offset = "0x8763A0", VA = "0x1808771A0")]
	public static Dictionary<string, object> GetSeasonPtRecordProfileDic(int index)
	{
		return null;
	}

	[Token(Token = "0x6003F45")]
	[Address(RVA = "0x8770C0", Offset = "0x8762C0", VA = "0x1808770C0")]
	public static Dictionary<string, object> GetSeasonPtRecordMemberDic(int index)
	{
		return null;
	}

	[Token(Token = "0x6003F46")]
	[Address(RVA = "0x877280", Offset = "0x876480", VA = "0x180877280")]
	public static Dictionary<string, object> GetSeasonPtRecordTeamTotal()
	{
		return null;
	}

	[Token(Token = "0x6003F47")]
	[Address(RVA = "0x876F30", Offset = "0x876130", VA = "0x180876F30")]
	public static string GetSeasonPtAggregateDate()
	{
		return null;
	}

	[Token(Token = "0x6003F48")]
	[Address(RVA = "0x877000", Offset = "0x876200", VA = "0x180877000")]
	public static Dictionary<string, object> GetSeasonPtMyRanking()
	{
		return null;
	}

	[Token(Token = "0x6003F49")]
	[Address(RVA = "0x8774E0", Offset = "0x8766E0", VA = "0x1808774E0")]
	public static Dictionary<string, object> GetSeasonPtTopRanking(int index, bool isResult, int seasonId)
	{
		return null;
	}

	[Token(Token = "0x6003F4A")]
	[Address(RVA = "0x876B80", Offset = "0x875D80", VA = "0x180876B80")]
	public static Image ChangeTeamIconBlue(Image image)
	{
		return null;
	}

	[Token(Token = "0x6003F4B")]
	[Address(RVA = "0x877D70", Offset = "0x876F70", VA = "0x180877D70")]
	public static void SetDetailButton(SelectionButton sb)
	{
	}

	[Token(Token = "0x6003F4C")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SeasonPointUtil()
	{
	}
}
