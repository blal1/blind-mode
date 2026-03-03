using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.Network;

namespace YgomGame.Tdy;

[Token(Token = "0x2000872")]
public class Util
{
	[Token(Token = "0x400865B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly PlayEffectDesc[] s_emptyEffects;

	[Token(Token = "0x6003336")]
	[Address(RVA = "0x77D700", Offset = "0x77C900", VA = "0x18077D700")]
	public static void OpenTopMenu(bool openOnHome = false)
	{
	}

	[Token(Token = "0x6003337")]
	[Address(RVA = "0x77D230", Offset = "0x77C430", VA = "0x18077D230")]
	public static bool IsOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6003338")]
	[Address(RVA = "0x77CF60", Offset = "0x77C160", VA = "0x18077CF60")]
	public static object GetMapFromCW(TDYMapParam param)
	{
		return null;
	}

	[Token(Token = "0x6003339")]
	[Address(RVA = "0x77C530", Offset = "0x77B730", VA = "0x18077C530")]
	public static bool ExistsResult()
	{
		return default(bool);
	}

	[Token(Token = "0x600333A")]
	[Address(RVA = "0x77D980", Offset = "0x77CB80", VA = "0x18077D980")]
	internal static void PollMapData(TDYMapParam param, Action<Handle> onEnd)
	{
	}

	[Token(Token = "0x600333B")]
	[Address(RVA = "0x77CFE0", Offset = "0x77C1E0", VA = "0x18077CFE0")]
	internal static bool HandleMapPollResult(Handle res, Action<int> onEnd)
	{
		return default(bool);
	}

	[Token(Token = "0x600333C")]
	[Address(RVA = "0x77D960", Offset = "0x77CB60", VA = "0x18077D960")]
	public static int PlayEffectToKizunaID(PlayEffectType eff)
	{
		return default(int);
	}

	[Token(Token = "0x600333D")]
	[Address(RVA = "0x77C6E0", Offset = "0x77B8E0", VA = "0x18077C6E0")]
	public static string GetChainName(int kid)
	{
		return null;
	}

	[Token(Token = "0x600333E")]
	[Address(RVA = "0x77D1F0", Offset = "0x77C3F0", VA = "0x18077D1F0")]
	public static bool IsChainEffect(PlayEffectType eff)
	{
		return default(bool);
	}

	[Token(Token = "0x600333F")]
	[Address(RVA = "0x77D210", Offset = "0x77C410", VA = "0x18077D210")]
	public static bool IsKizunaEffect(PlayEffectType eff)
	{
		return default(bool);
	}

	[Token(Token = "0x6003340")]
	[Address(RVA = "0x77C5C0", Offset = "0x77B7C0", VA = "0x18077C5C0")]
	public static PlayEffectDesc[] GetChainEffectList(string cwpath)
	{
		return null;
	}

	[Token(Token = "0x6003341")]
	[Address(RVA = "0x77CB60", Offset = "0x77BD60", VA = "0x18077CB60")]
	public static PlayEffectDesc GetKizunaEffect(string cwpath)
	{
		return null;
	}

	[Token(Token = "0x6003342")]
	[Address(RVA = "0x77C760", Offset = "0x77B960", VA = "0x18077C760")]
	public static PlayEffectDesc GetCompleteEffect(string cwpath)
	{
		return null;
	}

	[Token(Token = "0x6003343")]
	[Address(RVA = "0x77F100", Offset = "0x77E300", VA = "0x18077F100")]
	private static PlayEffectDesc[] getPlayEffects(string cwpath, Predicate<PlayEffectType> filter)
	{
		return null;
	}

	[Token(Token = "0x6003344")]
	[Address(RVA = "0x77CCB0", Offset = "0x77BEB0", VA = "0x18077CCB0")]
	public static List<RewardDialogData> GetKizunaRewards()
	{
		return null;
	}

	[Token(Token = "0x6003345")]
	[Address(RVA = "0x77C8B0", Offset = "0x77BAB0", VA = "0x18077C8B0")]
	public static List<RewardDialogData> GetCompleteRewards()
	{
		return null;
	}

	[Token(Token = "0x6003346")]
	[Address(RVA = "0x77D360", Offset = "0x77C560", VA = "0x18077D360")]
	public static void OpenChains(PlayEffectDesc[] effs, [Optional] Action finishCallback)
	{
	}

	[Token(Token = "0x6003347")]
	[Address(RVA = "0x77D5D0", Offset = "0x77C7D0", VA = "0x18077D5D0")]
	public static void OpenGetKizuna(PlayEffectDesc eff, [Optional] List<RewardDialogData> rewardDatas, [Optional] Action finishCallback)
	{
	}

	[Token(Token = "0x6003348")]
	[Address(RVA = "0x77D4B0", Offset = "0x77C6B0", VA = "0x18077D4B0")]
	public static void OpenCompleteKizuna([Optional] List<RewardDialogData> rewardDatas, [Optional] Action finishCallback)
	{
	}

	[Token(Token = "0x6003349")]
	[Address(RVA = "0x77DAF0", Offset = "0x77CCF0", VA = "0x18077DAF0")]
	public static List<(EntryItemListData.Context, bool)> RewardDialogToTuples(List<RewardDialogData> dialogDataList)
	{
		return null;
	}

	[Token(Token = "0x600334A")]
	[Address(RVA = "0x77BFF0", Offset = "0x77B1F0", VA = "0x18077BFF0")]
	public static BindingGameObjectEx BindingCurrentKizunaIcon(GameObject target, bool fitParentSize = false, bool async = true, bool rebind = true, [Optional] Action onCreated, [Optional] Dictionary<string, object> cwKizuna)
	{
		return null;
	}

	[Token(Token = "0x600334B")]
	[Address(RVA = "0x77C370", Offset = "0x77B570", VA = "0x18077C370")]
	private static BindingGameObjectEx BindingKizunaIcon(GameObject target, KizunaStatus[] kizunas, bool fitParentSize = false, bool async = true, bool rebind = true, [Optional] Action onCreated)
	{
		return null;
	}

	[Token(Token = "0x600334C")]
	[Address(RVA = "0x77DD20", Offset = "0x77CF20", VA = "0x18077DD20")]
	private static void SetKizunaIcon(ElementObjectManager eom, params KizunaStatus[] kizunas)
	{
	}

	[Token(Token = "0x600334D")]
	[Address(RVA = "0x77EE40", Offset = "0x77E040", VA = "0x18077EE40")]
	public static void SetTdyIconForDuelMenu(Image target)
	{
	}

	[Token(Token = "0x600334E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Util()
	{
	}
}
