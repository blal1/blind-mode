using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room;

[Token(Token = "0x2000AEE")]
public class RoomEntryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000AEF")]
	public enum Mode
	{
		[Token(Token = "0x400947F")]
		NORMAL,
		[Token(Token = "0x4009480")]
		SPECTER
	}

	[Token(Token = "0x2000AF0")]
	internal class Data
	{
		[Token(Token = "0x4009481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int id;

		[Token(Token = "0x4009482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string name;

		[Token(Token = "0x4009483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string regulation;

		[Token(Token = "0x4009484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int comment;

		[Token(Token = "0x4009485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int memberMax;

		[Token(Token = "0x4009486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int memberNum;

		[Token(Token = "0x4009487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal string endDate;

		[Token(Token = "0x600435F")]
		[Address(RVA = "0x8C8950", Offset = "0x8C7B50", VA = "0x1808C8950")]
		public Data(int id, string name, string regulation, int comment, int memberMax, int memberNum, string endDate)
		{
		}
	}

	[Token(Token = "0x2000AF8")]
	[CompilerGenerated]
	private sealed class _003CDelaySelect_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400949A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400949B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400949C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RoomEntryViewController _003C_003E4__this;

		[Token(Token = "0x400949D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int dataindex;

		[Token(Token = "0x400949E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool selectItem;

		[Token(Token = "0x400949F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool isIni;

		[Token(Token = "0x17000904")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004379")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000905")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600437B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004376")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelaySelect_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004377")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004378")]
		[Address(RVA = "0x8DB0D0", Offset = "0x8DA2D0", VA = "0x1808DB0D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600437A")]
		[Address(RVA = "0x8DB190", Offset = "0x8DA390", VA = "0x1808DB190", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400946E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400946F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BTN_FILTER_LABEL;

	[Token(Token = "0x4009470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string BTN_RELOAD_LABEL;

	[Token(Token = "0x4009471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string INPUT_LABEL;

	[Token(Token = "0x4009472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string TXT_TITLE_LABEL;

	[Token(Token = "0x4009473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TXT_PLACEHOLDER_LABEL;

	[Token(Token = "0x4009474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private InfinityScrollView isv;

	[Token(Token = "0x4009475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<Data> dataList;

	[Token(Token = "0x4009476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Mode mode;

	[Token(Token = "0x4009477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private bool m_ReloadEnable;

	[Token(Token = "0x4009478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int m_Interval;

	[Token(Token = "0x4009479")]
	private const int m_RoomEntryList = 50;

	[Token(Token = "0x400947A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton m_ButtonReload;

	[Token(Token = "0x400947B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ElementObjectManager m_ButtonFilterEom;

	[Token(Token = "0x400947C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<int> m_SelectedRegulationList;

	[Token(Token = "0x400947D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Dictionary<string, object> m_RegulationDict;

	[Token(Token = "0x17000902")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x8D20F0", Offset = "0x8D12F0", VA = "0x1808D20F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000903")]
	private static bool isGamePad
	{
		[Token(Token = "0x6004350")]
		[Address(RVA = "0x8D2060", Offset = "0x8D1260", VA = "0x1808D2060")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004351")]
	[Address(RVA = "0x8D0860", Offset = "0x8CFA60", VA = "0x1808D0860", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004352")]
	[Address(RVA = "0x8D0A70", Offset = "0x8CFC70", VA = "0x1808D0A70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004353")]
	[Address(RVA = "0x8D1AB0", Offset = "0x8D0CB0", VA = "0x1808D1AB0")]
	private void UpdateEntity(GameObject gob, int index)
	{
	}

	[Token(Token = "0x6004354")]
	[Address(RVA = "0x8D0710", Offset = "0x8CF910", VA = "0x1808D0710")]
	private void FocusImmidiate(int dataindex, bool selectItem = false, bool isIni = true)
	{
	}

	[Token(Token = "0x6004355")]
	[Address(RVA = "0x8D0670", Offset = "0x8CF870", VA = "0x1808D0670")]
	[IteratorStateMachine(typeof(_003CDelaySelect_003Ed__25))]
	private IEnumerator DelaySelect(int dataindex, bool selectItem = false, bool isIni = true)
	{
		return null;
	}

	[Token(Token = "0x6004356")]
	[Address(RVA = "0x8D01F0", Offset = "0x8CF3F0", VA = "0x1808D01F0")]
	private void ButtonReLoadDisp(bool isOn = true)
	{
	}

	[Token(Token = "0x6004357")]
	[Address(RVA = "0x8D00B0", Offset = "0x8CF2B0", VA = "0x1808D00B0")]
	private void ButtonFilterDisp(bool isOn)
	{
	}

	[Token(Token = "0x6004358")]
	[Address(RVA = "0x8D12A0", Offset = "0x8D04A0", VA = "0x1808D12A0")]
	private void SetData()
	{
	}

	[Token(Token = "0x6004359")]
	[Address(RVA = "0x8D07F0", Offset = "0x8CF9F0", VA = "0x1808D07F0")]
	private string GetIDKeyName(Mode mode)
	{
		return null;
	}

	[Token(Token = "0x600435A")]
	[Address(RVA = "0x8D0220", Offset = "0x8CF420", VA = "0x1808D0220")]
	private void CallAPIRoomEntry(int id, Mode mode)
	{
	}

	[Token(Token = "0x600435B")]
	[Address(RVA = "0x8D0040", Offset = "0x8CF240", VA = "0x1808D0040")]
	private Handle APIRoomEntry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
	{
		return null;
	}

	[Token(Token = "0x600435C")]
	[Address(RVA = "0x8D04B0", Offset = "0x8CF6B0", VA = "0x1808D04B0")]
	private void CallAPIRoomGetRoomList([Optional] Action<bool> onEnd)
	{
	}

	[Token(Token = "0x600435D")]
	[Address(RVA = "0x8D0330", Offset = "0x8CF530", VA = "0x1808D0330")]
	private void CallAPIRoomGetRoomList2(Action<bool> onEnd)
	{
	}

	[Token(Token = "0x600435E")]
	[Address(RVA = "0x8D1F20", Offset = "0x8D1120", VA = "0x1808D1F20")]
	public RoomEntryViewController()
	{
	}
}
