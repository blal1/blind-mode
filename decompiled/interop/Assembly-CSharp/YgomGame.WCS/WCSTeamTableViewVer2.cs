using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS;

[Token(Token = "0x2000762")]
public class WCSTeamTableViewVer2
{
	[Token(Token = "0x2000763")]
	public enum Side
	{
		[Token(Token = "0x400250E")]
		Left,
		[Token(Token = "0x400250F")]
		Right
	}

	[Token(Token = "0x2000764")]
	public enum Result
	{
		[Token(Token = "0x4002511")]
		NONE,
		[Token(Token = "0x4002512")]
		WIN,
		[Token(Token = "0x4002513")]
		LOSE,
		[Token(Token = "0x4002514")]
		DRAW
	}

	[Token(Token = "0x2000765")]
	public class TableSetData
	{
		[Token(Token = "0x2000766")]
		public class TableData
		{
			[Token(Token = "0x2000767")]
			public class PlayerData
			{
				[Token(Token = "0x400251D")]
				[FieldOffset(Offset = "0x10")]
				public Result _result;

				[Token(Token = "0x400251E")]
				[FieldOffset(Offset = "0x18")]
				public string _name;

				[Token(Token = "0x400251F")]
				[FieldOffset(Offset = "0x20")]
				public int _profileIconID;

				[Token(Token = "0x4002520")]
				[FieldOffset(Offset = "0x24")]
				public int _profileIconFrameID;

				[Token(Token = "0x6003098")]
				[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
				public PlayerData()
				{
				}
			}

			[Token(Token = "0x4002519")]
			[FieldOffset(Offset = "0x10")]
			public PlayerData[] _players;

			[Token(Token = "0x400251A")]
			[FieldOffset(Offset = "0x18")]
			public StringBuilder _statusText;

			[Token(Token = "0x400251B")]
			[FieldOffset(Offset = "0x20")]
			public bool _buttonPushable;

			[Token(Token = "0x400251C")]
			[FieldOffset(Offset = "0x28")]
			public UnityAction _callback;

			[Token(Token = "0x6003097")]
			[Address(RVA = "0x732100", Offset = "0x731300", VA = "0x180732100")]
			public TableData()
			{
			}
		}

		[Token(Token = "0x4002515")]
		[FieldOffset(Offset = "0x10")]
		public bool _active;

		[Token(Token = "0x4002516")]
		[FieldOffset(Offset = "0x11")]
		public bool _finished;

		[Token(Token = "0x4002517")]
		[FieldOffset(Offset = "0x18")]
		public readonly TableData[] tables;

		[Token(Token = "0x4002518")]
		[FieldOffset(Offset = "0x20")]
		public readonly int _templateType;

		[Token(Token = "0x6003096")]
		[Address(RVA = "0x732270", Offset = "0x731470", VA = "0x180732270")]
		public TableSetData(int templateType)
		{
		}
	}

	[Token(Token = "0x4002504")]
	[FieldOffset(Offset = "0x10")]
	private readonly TableSetData[] _tableSets;

	[Token(Token = "0x4002505")]
	[FieldOffset(Offset = "0x18")]
	protected readonly ElementObjectManager _eom;

	[Token(Token = "0x4002506")]
	[FieldOffset(Offset = "0x20")]
	protected readonly InfinityScrollView _scrollView;

	[Token(Token = "0x4002507")]
	[FieldOffset(Offset = "0x28")]
	protected readonly ExtendedTextMeshProUGUI _title;

	[Token(Token = "0x4002508")]
	[FieldOffset(Offset = "0x30")]
	protected readonly ElementObjectManager[] _teamInfoEoms;

	[Token(Token = "0x4002509")]
	[FieldOffset(Offset = "0x38")]
	private readonly bool _buttonDispAlways;

	[Token(Token = "0x400250A")]
	[FieldOffset(Offset = "0x3C")]
	private int _currentSetNoIndex;

	[Token(Token = "0x400250B")]
	[FieldOffset(Offset = "0x40")]
	private bool _updated;

	[Token(Token = "0x400250C")]
	[FieldOffset(Offset = "0x44")]
	private int _cachedTableSetNum;

	[Token(Token = "0x17000603")]
	public int activeTableSetCount
	{
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x748960", Offset = "0x747B60", VA = "0x180748960")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000604")]
	public int currentSetNo
	{
		[Token(Token = "0x6003075")]
		[Address(RVA = "0x748AB0", Offset = "0x747CB0", VA = "0x180748AB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x748AC0", Offset = "0x747CC0", VA = "0x180748AC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000605")]
	protected List<int> activeTemplateList
	{
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x7489C0", Offset = "0x747BC0", VA = "0x1807489C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003077")]
	[Address(RVA = "0x748560", Offset = "0x747760", VA = "0x180748560")]
	public WCSTeamTableViewVer2(ElementObjectManager eom, bool btnDispAlways = false)
	{
	}

	[Token(Token = "0x6003078")]
	[Address(RVA = "0x746940", Offset = "0x745B40", VA = "0x180746940", Slot = "4")]
	public virtual void CreateView(Action onEnd)
	{
	}

	[Token(Token = "0x6003079")]
	[Address(RVA = "0x7484A0", Offset = "0x7476A0", VA = "0x1807484A0")]
	public void UpdateUI()
	{
	}

	[Token(Token = "0x600307A")]
	[Address(RVA = "0x7467A0", Offset = "0x7459A0", VA = "0x1807467A0")]
	private string AcquireTableSetName(int tableSetNoIndex, bool holding)
	{
		return null;
	}

	[Token(Token = "0x600307B")]
	[Address(RVA = "0x747B80", Offset = "0x746D80", VA = "0x180747B80", Slot = "5")]
	protected virtual void UpdateEntity(GameObject obj, int index)
	{
	}

	[Token(Token = "0x600307C")]
	[Address(RVA = "0x746E00", Offset = "0x746000", VA = "0x180746E00")]
	public void FocusCurrentTableSet()
	{
	}

	[Token(Token = "0x600307D")]
	[Address(RVA = "0x747B50", Offset = "0x746D50", VA = "0x180747B50")]
	public void SetTitle(string title)
	{
	}

	[Token(Token = "0x600307E")]
	[Address(RVA = "0x747850", Offset = "0x746A50", VA = "0x180747850")]
	protected void SetTeamInfo(ElementObjectManager target, string areaName, string name, int? score, string iconPath)
	{
	}

	[Token(Token = "0x600307F")]
	[Address(RVA = "0x747160", Offset = "0x746360", VA = "0x180747160")]
	public void SetLeftTeamInfo(string areaName, string name, int? score, string iconPath)
	{
	}

	[Token(Token = "0x6003080")]
	[Address(RVA = "0x747540", Offset = "0x746740", VA = "0x180747540")]
	public void SetRightTeamInfo(string areaName, string name, int? score, string iconPath)
	{
	}

	[Token(Token = "0x6003081")]
	[Address(RVA = "0x746D50", Offset = "0x745F50", VA = "0x180746D50")]
	protected void EnableTeamInfoButton(Side side, bool on)
	{
	}

	[Token(Token = "0x6003082")]
	[Address(RVA = "0x746C80", Offset = "0x745E80", VA = "0x180746C80")]
	public void EnableLeftTeamInfoBtn(bool on)
	{
	}

	[Token(Token = "0x6003083")]
	[Address(RVA = "0x746C90", Offset = "0x745E90", VA = "0x180746C90")]
	public void EnableRightTeamInfoBtn(bool on)
	{
	}

	[Token(Token = "0x6003084")]
	[Address(RVA = "0x747A60", Offset = "0x746C60", VA = "0x180747A60")]
	public void SetTeamWin(Side which)
	{
	}

	[Token(Token = "0x6003085")]
	[Address(RVA = "0x746EF0", Offset = "0x7460F0", VA = "0x180746EF0")]
	public void ResetTeamResult()
	{
	}

	[Token(Token = "0x6003086")]
	[Address(RVA = "0x746CB0", Offset = "0x745EB0", VA = "0x180746CB0")]
	public void EnableTableSetAll(bool on)
	{
	}

	[Token(Token = "0x6003087")]
	[Address(RVA = "0x746D10", Offset = "0x745F10", VA = "0x180746D10")]
	public void EnableTableSet(int setNoIndex, bool on)
	{
	}

	[Token(Token = "0x6003088")]
	[Address(RVA = "0x747740", Offset = "0x746940", VA = "0x180747740")]
	public void SetTableStatusText(int setNoIndex, int index, string text)
	{
	}

	[Token(Token = "0x6003089")]
	[Address(RVA = "0x7471B0", Offset = "0x7463B0", VA = "0x1807471B0")]
	public void SetPlayerInfo(TableSetData.TableData.PlayerData data, string name, (int, int)? profileIconIDs)
	{
	}

	[Token(Token = "0x600308A")]
	[Address(RVA = "0x746FC0", Offset = "0x7461C0", VA = "0x180746FC0")]
	public void SetLeftPlayerInfo(int setNoIndex, int index, string name, (int, int)? profileIconIDs)
	{
	}

	[Token(Token = "0x600308B")]
	[Address(RVA = "0x7473A0", Offset = "0x7465A0", VA = "0x1807473A0")]
	public void SetRightPlayerInfo(int setNoIndex, int index, string name, (int, int)? profileIconIDs)
	{
	}

	[Token(Token = "0x600308C")]
	[Address(RVA = "0x747260", Offset = "0x746460", VA = "0x180747260")]
	public void SetPlayerWin(int setNoIndex, int tableIndex, Side which)
	{
	}

	[Token(Token = "0x600308D")]
	[Address(RVA = "0x747310", Offset = "0x746510", VA = "0x180747310")]
	public void SetResultDraw(int setNoIndex, int tableIndex)
	{
	}

	[Token(Token = "0x600308E")]
	[Address(RVA = "0x746E60", Offset = "0x746060", VA = "0x180746E60")]
	public void ResetBothPlayerResult(int setNoIndex, int tableIndex)
	{
	}

	[Token(Token = "0x600308F")]
	[Address(RVA = "0x747590", Offset = "0x746790", VA = "0x180747590")]
	public void SetTableSetFinished(int setNoIndex, bool finished = true)
	{
	}

	[Token(Token = "0x6003090")]
	[Address(RVA = "0x7477D0", Offset = "0x7469D0", VA = "0x1807477D0")]
	protected void SetTeamInfoButtonListener(Side side, UnityAction callback)
	{
	}

	[Token(Token = "0x6003091")]
	[Address(RVA = "0x7470F0", Offset = "0x7462F0", VA = "0x1807470F0")]
	public void SetLeftTeamInfoButtonListener(UnityAction callback)
	{
	}

	[Token(Token = "0x6003092")]
	[Address(RVA = "0x7474D0", Offset = "0x7466D0", VA = "0x1807474D0")]
	public void SetRightTeamInfoButtonListener(UnityAction callback)
	{
	}

	[Token(Token = "0x6003093")]
	[Address(RVA = "0x7476E0", Offset = "0x7468E0", VA = "0x1807476E0")]
	public void SetTableStatusButton(int setNoIndex, int index, bool pushable)
	{
	}

	[Token(Token = "0x6003094")]
	[Address(RVA = "0x747670", Offset = "0x746870", VA = "0x180747670")]
	public void SetTableStatusButtonListener(int setNoIndex, int index, UnityAction callback)
	{
	}

	[Token(Token = "0x6003095")]
	[Address(RVA = "0x7475D0", Offset = "0x7467D0", VA = "0x1807475D0")]
	public void SetTableStatusButtonAll(bool pushable)
	{
	}
}
