using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomGame.TextIDs;
using YgomSystem.Network;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x200078C")]
public class Util
{
	[Token(Token = "0x200078E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x40025E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int api_code;

		[Token(Token = "0x600317D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600317E")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CPrepareWcsfCampaignData_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x2000791")]
	[CompilerGenerated]
	private sealed class _003CPrepareWcsfCampaignData_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40025E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40025E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40025EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x40025EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> resultCallback;

		[Token(Token = "0x40025EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Handle _003Capi_handle_003E5__2;

		[Token(Token = "0x17000620")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003186")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000621")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003188")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003183")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPrepareWcsfCampaignData_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003184")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003185")]
		[Address(RVA = "0x759810", Offset = "0x758A10", VA = "0x180759810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003187")]
		[Address(RVA = "0x759A60", Offset = "0x758C60", VA = "0x180759A60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40025D9")]
	private const string k_teamIconDir = "Images/WCS/Portal/";

	[Token(Token = "0x40025DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[,] s_teamIconFileNames;

	[Token(Token = "0x40025DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly IDS_WCSPORTAL[] s_teamAreaIDs;

	[Token(Token = "0x600315A")]
	[Address(RVA = "0x7603E0", Offset = "0x75F5E0", VA = "0x1807603E0")]
	public static void OpenPortal()
	{
	}

	[Token(Token = "0x600315B")]
	[Address(RVA = "0x7603A0", Offset = "0x75F5A0", VA = "0x1807603A0")]
	public static void OpenPortalOnHome()
	{
	}

	[Token(Token = "0x600315C")]
	[Address(RVA = "0x75FD20", Offset = "0x75EF20", VA = "0x18075FD20")]
	public static void GoToVotePushOnHome()
	{
	}

	[Token(Token = "0x600315D")]
	[Address(RVA = "0x75FA60", Offset = "0x75EC60", VA = "0x18075FA60")]
	public static void GoTo1stStagePush()
	{
	}

	[Token(Token = "0x600315E")]
	[Address(RVA = "0x75FBC0", Offset = "0x75EDC0", VA = "0x18075FBC0")]
	public static void GoToTournamentPush()
	{
	}

	[Token(Token = "0x600315F")]
	[Address(RVA = "0x760440", Offset = "0x75F640", VA = "0x180760440")]
	[IteratorStateMachine(typeof(_003CPrepareWcsfCampaignData_003Ed__5))]
	public static IEnumerator PrepareWcsfCampaignData(Action<bool> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6003160")]
	[Address(RVA = "0x7604B0", Offset = "0x75F6B0", VA = "0x1807604B0")]
	public static void ShowExpiredDialog([Optional] Action callback)
	{
	}

	[Token(Token = "0x6003161")]
	[Address(RVA = "0x75FE80", Offset = "0x75F080", VA = "0x18075FE80")]
	public static bool HandleResultCode(Handle handle, UnityAction onSuccess, UnityAction<int> onFailed, bool showDialog = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6003162")]
	[Address(RVA = "0x7602A0", Offset = "0x75F4A0", VA = "0x1807602A0")]
	public static bool IsCampaignOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6003163")]
	[Address(RVA = "0x75EFA0", Offset = "0x75E1A0", VA = "0x18075EFA0")]
	public static Def.CampaignStatus GetCampaignStatus()
	{
		return default(Def.CampaignStatus);
	}

	[Token(Token = "0x6003164")]
	[Address(RVA = "0x75F0A0", Offset = "0x75E2A0", VA = "0x18075F0A0")]
	public static int GetChampionTeamID()
	{
		return default(int);
	}

	[Token(Token = "0x6003165")]
	[Address(RVA = "0x760310", Offset = "0x75F510", VA = "0x180760310")]
	public static bool IsReceivableVoteReward()
	{
		return default(bool);
	}

	[Token(Token = "0x6003166")]
	[Address(RVA = "0x75F020", Offset = "0x75E220", VA = "0x18075F020")]
	public static Dictionary<string, object> GetCampaign()
	{
		return null;
	}

	[Token(Token = "0x6003167")]
	[Address(RVA = "0x75EEA0", Offset = "0x75E0A0", VA = "0x18075EEA0")]
	public static Dictionary<string, object> GetCampaignDates()
	{
		return null;
	}

	[Token(Token = "0x6003168")]
	[Address(RVA = "0x75EF20", Offset = "0x75E120", VA = "0x18075EF20")]
	public static Dictionary<string, object> GetCampaignMaster()
	{
		return null;
	}

	[Token(Token = "0x6003169")]
	[Address(RVA = "0x75F3D0", Offset = "0x75E5D0", VA = "0x18075F3D0")]
	public static string GetTeamIconPathByIndex(int index, bool isLarge)
	{
		return null;
	}

	[Token(Token = "0x600316A")]
	[Address(RVA = "0x75F2C0", Offset = "0x75E4C0", VA = "0x18075F2C0")]
	public static string GetTeamIconPathByIconID(int teamIconID, bool isLarge)
	{
		return null;
	}

	[Token(Token = "0x600316B")]
	[Address(RVA = "0x75F480", Offset = "0x75E680", VA = "0x18075F480")]
	public static string GetTeamIconPath(int teamID, bool isLarge)
	{
		return null;
	}

	[Token(Token = "0x600316C")]
	[Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110")]
	public static string GetTeamAreaName(int teamID)
	{
		return null;
	}

	[Token(Token = "0x600316D")]
	[Address(RVA = "0x75ED90", Offset = "0x75DF90", VA = "0x18075ED90")]
	public static string GetAreaName(int areaID)
	{
		return null;
	}

	[Token(Token = "0x600316E")]
	[Address(RVA = "0x75F950", Offset = "0x75EB50", VA = "0x18075F950")]
	public static string GetTeamName(int teamID)
	{
		return null;
	}

	[Token(Token = "0x600316F")]
	[Address(RVA = "0x75F9E0", Offset = "0x75EBE0", VA = "0x18075F9E0")]
	public static int GetTeamOrder(int teamID)
	{
		return default(int);
	}

	[Token(Token = "0x6003170")]
	[Address(RVA = "0x75F790", Offset = "0x75E990", VA = "0x18075F790")]
	public static Dictionary<string, object> GetTeamMaster(int teamID)
	{
		return null;
	}

	[Token(Token = "0x6003171")]
	[Address(RVA = "0x75F640", Offset = "0x75E840", VA = "0x18075F640")]
	public static TeamInfo GetTeamInfo(int teamID)
	{
		return null;
	}

	[Token(Token = "0x6003172")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Util()
	{
	}
}
