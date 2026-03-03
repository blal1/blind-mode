using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x2001A06")]
public class DuelChainManager : MonoBehaviour
{
	[Token(Token = "0x2001A07")]
	public struct ChainSpotData
	{
		[Token(Token = "0x400F040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int uniqueid;

		[Token(Token = "0x400F041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int cardid;

		[Token(Token = "0x400F042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int styleid;

		[Token(Token = "0x400F043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int player;

		[Token(Token = "0x400F044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int position;

		[Token(Token = "0x400F045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int chainnum;

		[Token(Token = "0x400F046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 worldpos;

		[Token(Token = "0x600A842")]
		[Address(RVA = "0xF44220", Offset = "0xF43420", VA = "0x180F44220")]
		public ChainSpotData(int uniqueid, int player, int position, int chainnum, Vector3 worldpos)
		{
		}
	}

	[Token(Token = "0x2001A08")]
	private enum ChainStep
	{
		[Token(Token = "0x400F048")]
		IDLE,
		[Token(Token = "0x400F049")]
		ACTIVE,
		[Token(Token = "0x400F04A")]
		CHAINSET,
		[Token(Token = "0x400F04B")]
		CHAINRESOLVE1,
		[Token(Token = "0x400F04C")]
		CHAINRESOLVE2,
		[Token(Token = "0x400F04D")]
		EFFECTRESOLVE
	}

	[Token(Token = "0x2001A09")]
	private class ChainStepMachine
	{
		[Token(Token = "0x170019EB")]
		public ChainStep step
		{
			[Token(Token = "0x600A843")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(ChainStep);
			}
			[Token(Token = "0x600A844")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600A845")]
		[Address(RVA = "0xF44340", Offset = "0xF43540", VA = "0x180F44340")]
		public ChainStepMachine()
		{
		}

		[Token(Token = "0x600A846")]
		[Address(RVA = "0xF44320", Offset = "0xF43520", VA = "0x180F44320")]
		public void Increase()
		{
		}

		[Token(Token = "0x600A847")]
		[Address(RVA = "0xF442F0", Offset = "0xF434F0", VA = "0x180F442F0")]
		public void Decrease()
		{
		}

		[Token(Token = "0x600A848")]
		[Address(RVA = "0xB7F3E0", Offset = "0xB7E5E0", VA = "0x180B7F3E0")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityAction onAdded;

	[Token(Token = "0x400F038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ChainStepMachine m_StateMachine;

	[Token(Token = "0x400F039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<ChainSpotData> m_ChainSpotDataList;

	[Token(Token = "0x400F03A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Dictionary<int, List<DuelChainSpot>>> m_PosChainSpotTable;

	[Token(Token = "0x400F03B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PlayableDirector m_CurrentTimeline;

	[Token(Token = "0x400F03C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Queue<ChainSpotData> m_ChainSpotDataQueue;

	[Token(Token = "0x400F03D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_MinimumChainEndCount;

	[Token(Token = "0x400F03E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int m_MinimumChainRunCount;

	[Token(Token = "0x400F03F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private DuelClient m_Host;

	[Token(Token = "0x170019E7")]
	public bool isChainSet
	{
		[Token(Token = "0x600A828")]
		[Address(RVA = "0xF466F0", Offset = "0xF458F0", VA = "0x180F466F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019E8")]
	public bool isChainRevolve
	{
		[Token(Token = "0x600A829")]
		[Address(RVA = "0xF466C0", Offset = "0xF458C0", VA = "0x180F466C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019E9")]
	public bool IsTimelinePlaying
	{
		[Token(Token = "0x600A82A")]
		[Address(RVA = "0xF46630", Offset = "0xF45830", VA = "0x180F46630")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019EA")]
	private DuelChainSpot m_LastChainSpot
	{
		[Token(Token = "0x600A82B")]
		[Address(RVA = "0xF46710", Offset = "0xF45910", VA = "0x180F46710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A82C")]
	[Address(RVA = "0xF44D10", Offset = "0xF43F10", VA = "0x180F44D10")]
	public static DuelChainManager Create(Transform parent, DuelClient host)
	{
		return null;
	}

	[Token(Token = "0x600A82D")]
	[Address(RVA = "0xF44490", Offset = "0xF43690", VA = "0x180F44490")]
	public void ActiveEffect(int uniqueid, int player, int position, int chainnum, Vector3 dstpos, [Optional] UnityAction onAdded, bool mutesound = false)
	{
	}

	[Token(Token = "0x600A82E")]
	[Address(RVA = "0xF44360", Offset = "0xF43560", VA = "0x180F44360")]
	public void ActiveEffectMinimum(int uniqueid, int player, int position, int chainnum, Vector3 dstpos)
	{
	}

	[Token(Token = "0x600A82F")]
	[Address(RVA = "0xF45420", Offset = "0xF44620", VA = "0x180F45420")]
	public void OnAudienceReplayFinished()
	{
	}

	[Token(Token = "0x600A830")]
	[Address(RVA = "0xF45E70", Offset = "0xF45070", VA = "0x180F45E70")]
	public void ResolveEffect(int chainnum, [Optional] Action onRemoved)
	{
	}

	[Token(Token = "0x600A831")]
	[Address(RVA = "0xF45860", Offset = "0xF44A60", VA = "0x180F45860")]
	public void RemoveChainSpotMinimum()
	{
	}

	[Token(Token = "0x600A832")]
	[Address(RVA = "0xF45E60", Offset = "0xF45060", VA = "0x180F45E60")]
	public void ResolveEffectMinimum()
	{
	}

	[Token(Token = "0x600A833")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void SkipTimeline()
	{
	}

	[Token(Token = "0x600A834")]
	[Address(RVA = "0xF44C60", Offset = "0xF43E60", VA = "0x180F44C60")]
	public int CheckChainIdByUniqueId(int uniqueid)
	{
		return default(int);
	}

	[Token(Token = "0x600A835")]
	[Address(RVA = "0xF44ED0", Offset = "0xF440D0", VA = "0x180F44ED0")]
	public int GetCardidByChainId(int chainid)
	{
		return default(int);
	}

	[Token(Token = "0x600A836")]
	[Address(RVA = "0xF44DF0", Offset = "0xF43FF0", VA = "0x180F44DF0")]
	public int CurrentChainStackCount()
	{
		return default(int);
	}

	[Token(Token = "0x600A837")]
	[Address(RVA = "0xF458D0", Offset = "0xF44AD0", VA = "0x180F458D0")]
	public void RemoveChainSpot()
	{
	}

	[Token(Token = "0x600A838")]
	[Address(RVA = "0xF45010", Offset = "0xF44210", VA = "0x180F45010")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600A839")]
	[Address(RVA = "0xF44780", Offset = "0xF43980", VA = "0x180F44780")]
	private void AddChainSpot(int uniqueid, int player, int position, int chainnum, Vector3 worldpos, bool mutesound = false)
	{
	}

	[Token(Token = "0x600A83A")]
	[Address(RVA = "0xF44F60", Offset = "0xF44160", VA = "0x180F44F60")]
	private DuelChainSpot GetChainSpot()
	{
		return null;
	}

	[Token(Token = "0x600A83B")]
	[Address(RVA = "0xF458E0", Offset = "0xF44AE0", VA = "0x180F458E0")]
	private void RemoveSpot()
	{
	}

	[Token(Token = "0x600A83C")]
	[Address(RVA = "0xF45F70", Offset = "0xF45170", VA = "0x180F45F70")]
	private void SetChainSpotCircle(List<DuelChainSpot> spotlist, int count, Vector3 centerpos)
	{
	}

	[Token(Token = "0x600A83D")]
	[Address(RVA = "0xF45A80", Offset = "0xF44C80", VA = "0x180F45A80")]
	private void ResolveChain(Action onRemoved, bool isFirst)
	{
	}

	[Token(Token = "0x600A83E")]
	[Address(RVA = "0xF461B0", Offset = "0xF453B0", VA = "0x180F461B0")]
	private void SetChain()
	{
	}

	[Token(Token = "0x600A83F")]
	[Address(RVA = "0x3F2960", Offset = "0x3F1B60", VA = "0x1803F2960")]
	private void OnChainTimelineEnd()
	{
	}

	[Token(Token = "0x600A840")]
	[Address(RVA = "0xF44E30", Offset = "0xF44030", VA = "0x180F44E30")]
	private void DuelChainNumSE()
	{
	}

	[Token(Token = "0x600A841")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelChainManager()
	{
	}
}
