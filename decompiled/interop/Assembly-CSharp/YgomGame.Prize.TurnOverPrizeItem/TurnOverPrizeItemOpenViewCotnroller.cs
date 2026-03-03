using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomGame.Shop;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Token(Token = "0x2000B9C")]
public class TurnOverPrizeItemOpenViewCotnroller : BaseMenuViewController
{
	[Token(Token = "0x2000B9E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4009774")]
		[FieldOffset(Offset = "0x10")]
		public bool doneDecideApi;

		[Token(Token = "0x4009775")]
		[FieldOffset(Offset = "0x18")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x913F60", Offset = "0x913160", VA = "0x180913F60")]
		internal void _003CyMainRoutine_003Eb__1()
		{
		}

		[Token(Token = "0x60046D3")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		internal bool _003CyMainRoutine_003Eb__2()
		{
			return default(bool);
		}

		[Token(Token = "0x60046D4")]
		[Address(RVA = "0x6E35F0", Offset = "0x6E27F0", VA = "0x1806E35F0")]
		internal void _003CyMainRoutine_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000B9F")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4009776")]
		[FieldOffset(Offset = "0x10")]
		public int selectedIdx;

		[Token(Token = "0x4009777")]
		[FieldOffset(Offset = "0x14")]
		public int confirmIdx;

		[Token(Token = "0x4009778")]
		[FieldOffset(Offset = "0x18")]
		public bool decided;

		[Token(Token = "0x4009779")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}
	}

	[Token(Token = "0x2000BA3")]
	[CompilerGenerated]
	private sealed class _003CSetPrizeOnUnlock_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400977F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009780")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009781")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x4009782")]
		[FieldOffset(Offset = "0x28")]
		public int idx;

		[Token(Token = "0x1700098A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046E1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046E3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetPrizeOnUnlock_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x912DD0", Offset = "0x911FD0", VA = "0x180912DD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x913180", Offset = "0x912380", VA = "0x180913180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BA4")]
	[CompilerGenerated]
	private sealed class _003CSetPrizesAsBeforeSuffle_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009783")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009784")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009785")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x4009786")]
		[FieldOffset(Offset = "0x28")]
		private List<BindingItemThumb> _003Cbinding_003E5__2;

		[Token(Token = "0x4009787")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CisDoneAll_003E5__3;

		[Token(Token = "0x1700098C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046E7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046E9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetPrizesAsBeforeSuffle_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046E5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046E6")]
		[Address(RVA = "0x9131C0", Offset = "0x9123C0", VA = "0x1809131C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60046E8")]
		[Address(RVA = "0x913700", Offset = "0x912900", VA = "0x180913700", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BA5")]
	[CompilerGenerated]
	private sealed class _003CyMainRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009788")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009789")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400978A")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x400978B")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		[Token(Token = "0x1700098E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046ED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046EF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046EA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMainRoutine_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046EB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046EC")]
		[Address(RVA = "0x9156B0", Offset = "0x9148B0", VA = "0x1809156B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x915D00", Offset = "0x914F00", VA = "0x180915D00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BA6")]
	[CompilerGenerated]
	private sealed class _003CyPlayResult_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400978C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400978D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400978E")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x17000990")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046F3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000991")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046F5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046F0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayResult_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046F1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046F2")]
		[Address(RVA = "0x916000", Offset = "0x915200", VA = "0x180916000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x916180", Offset = "0x915380", VA = "0x180916180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BA7")]
	[CompilerGenerated]
	private sealed class _003CyPlayShuffle_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400978F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009790")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009791")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x17000992")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046F9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000993")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046FB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046F6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayShuffle_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046F7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x916300", Offset = "0x915500", VA = "0x180916300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x916450", Offset = "0x915650", VA = "0x180916450", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BA8")]
	[CompilerGenerated]
	private sealed class _003CySelectPrize_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009792")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009793")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009794")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeItemOpenViewCotnroller _003C_003E4__this;

		[Token(Token = "0x4009795")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		[Token(Token = "0x17000994")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046FF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000995")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004701")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySelectPrize_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046FE")]
		[Address(RVA = "0x916F80", Offset = "0x916180", VA = "0x180916F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004700")]
		[Address(RVA = "0x917850", Offset = "0x916A50", VA = "0x180917850", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009761")]
	private const string k_VCPath = "Prize/TurnOverPrizeItem/TurnOverPrizeItemOpen";

	[Token(Token = "0x4009762")]
	private const string k_SettingPath = "Prefabs/Prize/TurnOverPrizeItem/TurnOverPrizeItemOpen/PrizeItemSetting";

	[Token(Token = "0x4009763")]
	private const string k_SECategory = "SE_ANNIV";

	[Token(Token = "0x4009764")]
	private const string k_ArgKeyPrizeId = "prizeId";

	[Token(Token = "0x4009765")]
	internal const string k_ArgKeyPurchaseHandler = "priceContext";

	[Token(Token = "0x4009766")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_BeforePostProcessing;

	[Token(Token = "0x4009767")]
	[FieldOffset(Offset = "0xD8")]
	private ShopPurchase.PurchaseHandler m_PurchaseHandler;

	[Token(Token = "0x4009768")]
	[FieldOffset(Offset = "0xE0")]
	private string m_CoverPath;

	[Token(Token = "0x4009769")]
	[FieldOffset(Offset = "0xE8")]
	private List<object> m_PrizeDatas;

	[Token(Token = "0x400976A")]
	[FieldOffset(Offset = "0xF0")]
	private List<string> m_LoadedAssetsPath;

	[Token(Token = "0x400976B")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject m_Root3D;

	[Token(Token = "0x400976C")]
	[FieldOffset(Offset = "0x100")]
	private ActorRoot m_ActorRoot;

	[Token(Token = "0x400976D")]
	[FieldOffset(Offset = "0x108")]
	private int m_DecidedIdx;

	[Token(Token = "0x400976E")]
	[FieldOffset(Offset = "0x110")]
	private Dictionary<int, string> m_CategoryItemSetting;

	[Token(Token = "0x400976F")]
	[FieldOffset(Offset = "0x118")]
	private Dictionary<int, string> m_IDItemSettting;

	[Token(Token = "0x4009770")]
	[FieldOffset(Offset = "0x120")]
	private Dictionary<string, object> m_ItemResult;

	[Token(Token = "0x4009771")]
	[FieldOffset(Offset = "0x128")]
	private bool m_IsPresentSend;

	[Token(Token = "0x17000989")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x8F55D0", Offset = "0x8F47D0", VA = "0x1808F55D0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60046BD")]
	[Address(RVA = "0x8F4250", Offset = "0x8F3450", VA = "0x1808F4250")]
	public static void Open(int prizeId, ShopPurchase.PurchaseHandler purchaseHandler, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60046BE")]
	[Address(RVA = "0x8F3AB0", Offset = "0x8F2CB0", VA = "0x1808F3AB0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60046BF")]
	[Address(RVA = "0x8F3F90", Offset = "0x8F3190", VA = "0x1808F3F90", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60046C0")]
	[Address(RVA = "0x8F4D80", Offset = "0x8F3F80", VA = "0x1808F4D80")]
	private void Start()
	{
	}

	[Token(Token = "0x60046C1")]
	[Address(RVA = "0x8F3EC0", Offset = "0x8F30C0", VA = "0x1808F3EC0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60046C2")]
	[Address(RVA = "0x8F40D0", Offset = "0x8F32D0", VA = "0x1808F40D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60046C3")]
	[Address(RVA = "0x8F57D0", Offset = "0x8F49D0", VA = "0x1808F57D0")]
	[IteratorStateMachine(typeof(_003CyMainRoutine_003Ed__25))]
	private IEnumerator yMainRoutine()
	{
		return null;
	}

	[Token(Token = "0x60046C4")]
	[Address(RVA = "0x8F58B0", Offset = "0x8F4AB0", VA = "0x1808F58B0")]
	[IteratorStateMachine(typeof(_003CyPlayShuffle_003Ed__26))]
	private IEnumerator yPlayShuffle()
	{
		return null;
	}

	[Token(Token = "0x60046C5")]
	[Address(RVA = "0x8F5920", Offset = "0x8F4B20", VA = "0x1808F5920")]
	[IteratorStateMachine(typeof(_003CySelectPrize_003Ed__27))]
	private IEnumerator ySelectPrize()
	{
		return null;
	}

	[Token(Token = "0x60046C6")]
	[Address(RVA = "0x8F5840", Offset = "0x8F4A40", VA = "0x1808F5840")]
	[IteratorStateMachine(typeof(_003CyPlayResult_003Ed__28))]
	private IEnumerator yPlayResult()
	{
		return null;
	}

	[Token(Token = "0x60046C7")]
	[Address(RVA = "0x8F4380", Offset = "0x8F3580", VA = "0x1808F4380")]
	private void SetAllPrizes(bool setArrowVisible = false)
	{
	}

	[Token(Token = "0x60046C8")]
	[Address(RVA = "0x8F45F0", Offset = "0x8F37F0", VA = "0x1808F45F0")]
	private void SetPrizeByPos(int pos, bool setArrowVisible = false)
	{
	}

	[Token(Token = "0x60046C9")]
	[Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
	[IteratorStateMachine(typeof(_003CSetPrizesAsBeforeSuffle_003Ed__31))]
	private IEnumerator SetPrizesAsBeforeSuffle()
	{
		return null;
	}

	[Token(Token = "0x60046CA")]
	[Address(RVA = "0x8F4C90", Offset = "0x8F3E90", VA = "0x1808F4C90")]
	[IteratorStateMachine(typeof(_003CSetPrizeOnUnlock_003Ed__32))]
	private IEnumerator SetPrizeOnUnlock(int idx)
	{
		return null;
	}

	[Token(Token = "0x60046CB")]
	[Address(RVA = "0x8F54D0", Offset = "0x8F46D0", VA = "0x1808F54D0")]
	public TurnOverPrizeItemOpenViewCotnroller()
	{
	}
}
