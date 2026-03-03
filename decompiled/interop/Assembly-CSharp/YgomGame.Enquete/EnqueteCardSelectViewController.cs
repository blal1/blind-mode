using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem;
using YgomSystem.Utility;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DF0")]
public class EnqueteCardSelectViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000DF2")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x400A144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isFinishedApi;

		[Token(Token = "0x400A145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EnqueteCardSelectViewController _003C_003E4__this;

		[Token(Token = "0x400A146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isCreatedPickupWidget;

		[Token(Token = "0x6005413")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6005414")]
		[Address(RVA = "0x9AFD10", Offset = "0x9AEF10", VA = "0x1809AFD10")]
		internal void _003CyInitialize_003Eb__0(bool res)
		{
		}

		[Token(Token = "0x6005415")]
		[Address(RVA = "0x9AFD40", Offset = "0x9AEF40", VA = "0x1809AFD40")]
		internal void _003CyInitialize_003Eb__1(int x)
		{
		}

		[Token(Token = "0x6005416")]
		[Address(RVA = "0x9AFF40", Offset = "0x9AF140", VA = "0x1809AFF40")]
		internal void _003CyInitialize_003Eb__4(int cardId)
		{
		}

		[Token(Token = "0x6005417")]
		[Address(RVA = "0x9AFF60", Offset = "0x9AF160", VA = "0x1809AFF60")]
		internal void _003CyInitialize_003Eb__5(Either<string, PickupCardSelectionWidget> res)
		{
		}

		[Token(Token = "0x6005418")]
		[Address(RVA = "0x9AFDF0", Offset = "0x9AEFF0", VA = "0x1809AFDF0")]
		internal void _003CyInitialize_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000DF4")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A14A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A14B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnqueteCardSelectViewController _003C_003E4__this;

		[Token(Token = "0x400A14C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass38_0 _003C_003E8__1;

		[Token(Token = "0x17000C5F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600541E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C60")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005420")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600541B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600541C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600541D")]
		[Address(RVA = "0x9B15B0", Offset = "0x9B07B0", VA = "0x1809B15B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600541F")]
		[Address(RVA = "0x9B22D0", Offset = "0x9B14D0", VA = "0x1809B22D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A12C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string _PrefabPath;

	[Token(Token = "0x400A12D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelDetailView;

	[Token(Token = "0x400A12E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string Label_Args_Min;

	[Token(Token = "0x400A12F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string Label_Args_Max;

	[Token(Token = "0x400A130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string Label_Args_CardPoolId;

	[Token(Token = "0x400A131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string Label_Args_Label;

	[Token(Token = "0x400A132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string Label_Args_PickedIds;

	[Token(Token = "0x400A133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly string Label_Args_OnBack;

	[Token(Token = "0x400A134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string Label_PickCardArea;

	[Token(Token = "0x400A135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public KeyConfigContainer _keyConfig;

	[Token(Token = "0x400A136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private PickupCardSelectionWidget m_PickupCardSelectionWidget;

	[Token(Token = "0x400A137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private EnqueteCardDetailWidget m_CardDetailWidget;

	[Token(Token = "0x400A138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private CardSelectAreaWidget m_CardSelectWidget;

	[Token(Token = "0x400A139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<int> pickedIds;

	[Token(Token = "0x400A13A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int min;

	[Token(Token = "0x400A13B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private int max;

	[Token(Token = "0x400A13C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int cardpoolId;

	[Token(Token = "0x400A13D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string label;

	[Token(Token = "0x400A13E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Action<List<int>> onBackAction;

	[Token(Token = "0x400A13F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool isError;

	[Token(Token = "0x400A140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string errorText;

	[Token(Token = "0x400A141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool isInitializedCardSelectWidget;

	[Token(Token = "0x400A142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private int blockCount;

	[Token(Token = "0x17000C5C")]
	public bool isMobile
	{
		[Token(Token = "0x60053FA")]
		[Address(RVA = "0x9A1D40", Offset = "0x9A0F40", VA = "0x1809A1D40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000C5D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60053FB")]
		[Address(RVA = "0x9A1D90", Offset = "0x9A0F90", VA = "0x1809A1D90", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C5E")]
	public PickupCardSelectionWidget pickupCardSelectionWidget
	{
		[Token(Token = "0x60053FC")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60053FD")]
	[Address(RVA = "0x9A1180", Offset = "0x9A0380", VA = "0x1809A1180")]
	private Dictionary<string, object> GetEnqueteDic()
	{
		return null;
	}

	[Token(Token = "0x60053FE")]
	[Address(RVA = "0x9A1120", Offset = "0x9A0320", VA = "0x1809A1120")]
	private List<object> GetCardPoolIds()
	{
		return null;
	}

	[Token(Token = "0x60053FF")]
	[Address(RVA = "0x9A0B40", Offset = "0x99FD40", VA = "0x1809A0B40")]
	private void CallAPIGetCardPool(Action<bool> onFinished)
	{
	}

	[Token(Token = "0x6005400")]
	[Address(RVA = "0x9A1300", Offset = "0x9A0500", VA = "0x1809A1300")]
	public static void Open(int cardPoolId, string label, int min, int max, List<int> pickedIds, [Optional] Action<List<int>> onBackAction)
	{
	}

	[Token(Token = "0x6005401")]
	[Address(RVA = "0x9A11E0", Offset = "0x9A03E0", VA = "0x1809A11E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005402")]
	[Address(RVA = "0x9A1260", Offset = "0x9A0460", VA = "0x1809A1260", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6005403")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005404")]
	[Address(RVA = "0x9A12B0", Offset = "0x9A04B0", VA = "0x1809A12B0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6005405")]
	[Address(RVA = "0x9A1770", Offset = "0x9A0970", VA = "0x1809A1770")]
	private void Start()
	{
	}

	[Token(Token = "0x6005406")]
	[Address(RVA = "0x9A1ED0", Offset = "0x9A10D0", VA = "0x1809A1ED0")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__38))]
	private IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005407")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6005408")]
	[Address(RVA = "0x9A0F90", Offset = "0x9A0190", VA = "0x1809A0F90")]
	private void ErrorDialog(string text)
	{
	}

	[Token(Token = "0x6005409")]
	[Address(RVA = "0x9A0E50", Offset = "0x9A0050", VA = "0x1809A0E50")]
	public void CardDetailUpdate(int cardId)
	{
	}

	[Token(Token = "0x600540A")]
	[Address(RVA = "0x9A1530", Offset = "0x9A0730", VA = "0x1809A1530")]
	public bool PickCardUpdate(int cardId, bool isClickOwnBtn = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600540B")]
	[Address(RVA = "0x9A10B0", Offset = "0x9A02B0", VA = "0x1809A10B0")]
	private int GetAdjustedCount(List<int> list, int max, bool isAdd)
	{
		return default(int);
	}

	[Token(Token = "0x600540C")]
	[Address(RVA = "0x9A1C20", Offset = "0x9A0E20", VA = "0x1809A1C20")]
	public EnqueteCardSelectViewController()
	{
	}
}
