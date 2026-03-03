using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x2000660")]
public class DeckEditViewController2 : BaseMenuViewController
{
	[Token(Token = "0x2000661")]
	public enum DisplayMode
	{
		[Token(Token = "0x4001F79")]
		Simple,
		[Token(Token = "0x4001F7A")]
		Detailed,
		[Token(Token = "0x4001F7B")]
		Rarity
	}

	[Token(Token = "0x2000662")]
	public enum EditMode
	{
		[Token(Token = "0x4001F7D")]
		Default,
		[Token(Token = "0x4001F7E")]
		Exhibition,
		[Token(Token = "0x4001F7F")]
		Cup,
		[Token(Token = "0x4001F80")]
		Wcs,
		[Token(Token = "0x4001F81")]
		RankEvent,
		[Token(Token = "0x4001F82")]
		DuelTrial,
		[Token(Token = "0x4001F83")]
		Versus,
		[Token(Token = "0x4001F84")]
		WcsFinal,
		[Token(Token = "0x4001F85")]
		Rdc,
		[Token(Token = "0x4001F86")]
		Dicerally
	}

	[Token(Token = "0x2000663")]
	public enum OperationType : byte
	{
		[Token(Token = "0x4001F88")]
		None,
		[Token(Token = "0x4001F89")]
		Add,
		[Token(Token = "0x4001F8A")]
		Remove,
		[Token(Token = "0x4001F8B")]
		AutoDeckBuild,
		[Token(Token = "0x4001F8C")]
		DeckReset
	}

	[Token(Token = "0x2000664")]
	protected enum ViewType
	{
		[Token(Token = "0x4001F8E")]
		None,
		[Token(Token = "0x4001F8F")]
		CardCollection,
		[Token(Token = "0x4001F90")]
		Deck,
		[Token(Token = "0x4001F91")]
		Unknown
	}

	[Token(Token = "0x2000665")]
	protected enum SelectedCardType
	{
		[Token(Token = "0x4001F93")]
		None,
		[Token(Token = "0x4001F94")]
		CollectionCard,
		[Token(Token = "0x4001F95")]
		DeckCard,
		[Token(Token = "0x4001F96")]
		RelatedCard
	}

	[Token(Token = "0x2000666")]
	private enum SaveDialogType
	{
		[Token(Token = "0x4001F98")]
		Back,
		[Token(Token = "0x4001F99")]
		SecretPack
	}

	[Token(Token = "0x2000667")]
	public struct AutoBuildSetting
	{
		[Token(Token = "0x4001F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int type;

		[Token(Token = "0x4001F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int rarity;

		[Token(Token = "0x4001F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int deckNum;

		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x488410", Offset = "0x487610", VA = "0x180488410")]
		public AutoBuildSetting(int type, int rarity, int deckNum)
		{
		}
	}

	[Token(Token = "0x2000668")]
	private delegate void craftCallBack(string message = "");

	[Token(Token = "0x2000688")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass348_0
	{
		[Token(Token = "0x4002026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DeckEditViewController2 _003C_003E4__this;

		[Token(Token = "0x4002027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CardCollectionView.Area area;

		[Token(Token = "0x4002028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SortComparer.Sorter sorter;

		[Token(Token = "0x4002029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Comparison<CardBaseData> _003C_003E9__4;

		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass348_0()
		{
		}

		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x6E6290", Offset = "0x6E5490", VA = "0x1806E6290")]
		internal void _003CAsyncFilterAndSort_003Eb__2()
		{
		}

		[Token(Token = "0x6002B86")]
		[Address(RVA = "0x6E61D0", Offset = "0x6E53D0", VA = "0x1806E61D0")]
		internal void _003CAsyncFilterAndSort_003Eb__1()
		{
		}

		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x6E62D0", Offset = "0x6E54D0", VA = "0x1806E62D0")]
		internal int _003CAsyncFilterAndSort_003Eb__4(CardBaseData a, CardBaseData b)
		{
			return default(int);
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200068F")]
	[CompilerGenerated]
	private struct _003CAsyncFilterAndSort_003Ed__348 : IAsyncStateMachine
	{
		[Token(Token = "0x4002038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4002039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400203A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckEditViewController2 _003C_003E4__this;

		[Token(Token = "0x400203B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool setAll;

		[Token(Token = "0x400203C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SortComparer.Sorter? targetSorter;

		[Token(Token = "0x400203D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool filter;

		[Token(Token = "0x400203E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass348_0 _003C_003E8__1;

		[Token(Token = "0x400203F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CardCollectionView.Area? targetArea;

		[Token(Token = "0x4002040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action onFinish;

		[Token(Token = "0x4002041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x6D8E50", Offset = "0x6D8050", VA = "0x1806D8E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x6D9920", Offset = "0x6D8B20", VA = "0x1806D9920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000690")]
	[CompilerGenerated]
	private struct _003CFirstAsyncFilterAndSort_003Ed__347 : IAsyncStateMachine
	{
		[Token(Token = "0x4002042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4002043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4002044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckEditViewController2 _003C_003E4__this;

		[Token(Token = "0x4002045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onFinish;

		[Token(Token = "0x4002046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x6D9C00", Offset = "0x6D8E00", VA = "0x1806D9C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x6DA6F0", Offset = "0x6D98F0", VA = "0x1806DA6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000691")]
	[CompilerGenerated]
	private sealed class _003CInitialSetDeck_003Ed__360 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckEditViewController2 _003C_003E4__this;

		[Token(Token = "0x400204A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onFinish;

		[Token(Token = "0x17000573")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BA0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000574")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BA2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialSetDeck_003Ed__360(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B9E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x6FCDC0", Offset = "0x6FBFC0", VA = "0x1806FCDC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BA1")]
		[Address(RVA = "0x6FD140", Offset = "0x6FC340", VA = "0x1806FD140", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000692")]
	[CompilerGenerated]
	private sealed class _003CInitialSetExtraDeck_003Ed__355 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400204B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400204C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400204D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckEditViewController2 _003C_003E4__this;

		[Token(Token = "0x400204E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<CardBaseData>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000575")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BA7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000576")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BA9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BA3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialSetExtraDeck_003Ed__355(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BA4")]
		[Address(RVA = "0x6FD4B0", Offset = "0x6FC6B0", VA = "0x1806FD4B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0x6FD180", Offset = "0x6FC380", VA = "0x1806FD180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BA6")]
		[Address(RVA = "0x6FD540", Offset = "0x6FC740", VA = "0x1806FD540")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x6FD470", Offset = "0x6FC670", VA = "0x1806FD470", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000693")]
	[CompilerGenerated]
	private sealed class _003CInitialSetLockCards_003Ed__356 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400204F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckEditViewController2 _003C_003E4__this;

		[Token(Token = "0x4002052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<CardBaseData>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000577")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BAE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000578")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BB0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BAA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialSetLockCards_003Ed__356(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BAB")]
		[Address(RVA = "0x6FD860", Offset = "0x6FCA60", VA = "0x1806FD860", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0x6FD590", Offset = "0x6FC790", VA = "0x1806FD590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x6FD8F0", Offset = "0x6FCAF0", VA = "0x1806FD8F0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x6FD820", Offset = "0x6FCA20", VA = "0x1806FD820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000694")]
	[CompilerGenerated]
	private sealed class _003CInitialSetMainDeck_003Ed__354 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeckEditViewController2 _003C_003E4__this;

		[Token(Token = "0x4002056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<CardBaseData>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000579")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BB5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BB7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BB1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialSetMainDeck_003Ed__354(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BB2")]
		[Address(RVA = "0x6FDC70", Offset = "0x6FCE70", VA = "0x1806FDC70", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0x6FD940", Offset = "0x6FCB40", VA = "0x1806FD940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0x6FDD00", Offset = "0x6FCF00", VA = "0x1806FDD00")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002BB6")]
		[Address(RVA = "0x6FDC30", Offset = "0x6FCE30", VA = "0x1806FDC30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001EC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int m_ExhibitionID;

	[Token(Token = "0x4001ECA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int m_CupID;

	[Token(Token = "0x4001ECB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_WcsID;

	[Token(Token = "0x4001ECC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_WcsFinalID;

	[Token(Token = "0x4001ECD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int m_WcsFinalMemberIdx;

	[Token(Token = "0x4001ECE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int m_WcsFinalMemberSlot;

	[Token(Token = "0x4001ECF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int m_RankEventID;

	[Token(Token = "0x4001ED0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int m_DuelTrialID;

	[Token(Token = "0x4001ED1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int m_VersusID;

	[Token(Token = "0x4001ED2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int m_VersusGroupID;

	[Token(Token = "0x4001ED3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int m_RdcID;

	[Token(Token = "0x4001ED4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private int m_DicerallyID;

	[Token(Token = "0x4001ED5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected int m_RegulationID;

	[Token(Token = "0x4001ED6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private int m_RoomRegulationID;

	[Token(Token = "0x4001ED7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected int m_RentalCardID;

	[Token(Token = "0x4001ED9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ElementObjectManager m_UI;

	[Token(Token = "0x4001EDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected Action<int> onSavedDeckCallback;

	[Token(Token = "0x4001EDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	protected DeckView.Mode deckViewMode;

	[Token(Token = "0x4001EDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	protected bool isScratch;

	[Token(Token = "0x4001EDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static bool isRunningFilterAndSort;

	[Token(Token = "0x4001EDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
	private bool firstSort;

	[Token(Token = "0x4001EDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected Content m_cci;

	[Token(Token = "0x4001EE0")]
	public const string k_ArgsKeyDefaultDeck = "DeckName";

	[Token(Token = "0x4001EE1")]
	public const string k_ArgsKeyEventDeckName = "EventDeckName";

	[Token(Token = "0x4001EE2")]
	public const string k_ArgsKeyDeckID = "DeckId";

	[Token(Token = "0x4001EE3")]
	public const string k_ArgsKeyExhibitionDeck = "ExhibitionID";

	[Token(Token = "0x4001EE4")]
	public const string k_ArgsKeyCupDeck = "CupID";

	[Token(Token = "0x4001EE5")]
	public const string k_ArgsKeyWcsDeck = "WcsID";

	[Token(Token = "0x4001EE6")]
	public const string k_ArgsKeyWcsFinalDeck = "WcsFinalID";

	[Token(Token = "0x4001EE7")]
	public const string k_ArgsKeyMemberIdx = "MemberIdx";

	[Token(Token = "0x4001EE8")]
	public const string k_ArgsKeyMemberSlot = "Slot";

	[Token(Token = "0x4001EE9")]
	public const string k_ArgsKeyRankEventDeck = "RankEventID";

	[Token(Token = "0x4001EEA")]
	public const string k_ArgsKeyDuelTrialDeck = "DuelTrialID";

	[Token(Token = "0x4001EEB")]
	public const string k_ArgsKeyVersusDeck = "VersusID";

	[Token(Token = "0x4001EEC")]
	public const string k_ArgsKeyVersusGroupDeck = "VersusGroupID";

	[Token(Token = "0x4001EED")]
	public const string k_ArgsKeyRdcDeck = "RdcID";

	[Token(Token = "0x4001EEE")]
	public const string k_ArgsKeyDicerallyDeck = "DicerallyID";

	[Token(Token = "0x4001EEF")]
	public const string k_ArgsKeyIsScratch = "Scratch";

	[Token(Token = "0x4001EF0")]
	public const string k_ArgsKeySecretPack = "SecretPack";

	[Token(Token = "0x4001EF1")]
	public const string k_ArgsKeyRegulation = "RegulationID";

	[Token(Token = "0x4001EF2")]
	public const string k_ArgsKeyRoomRegulation = "RoomRegulationID";

	[Token(Token = "0x4001EF3")]
	public const string PREFAB_PATH_DECKLISTVIEW = "DeckEdit/DeckList";

	[Token(Token = "0x4001EF4")]
	public const string PREFAB_PATH_CARDACTIONMENU = "DeckEdit/CardActionMenu";

	[Token(Token = "0x4001EF5")]
	public const string PREFAB_PATH_CARDDETAIL = "DeckEdit/CardDetail";

	[Token(Token = "0x4001EF6")]
	public const string PREFAB_PATH_CARDCOLLECTIONVIEW = "DeckEdit/CardCollection";

	[Token(Token = "0x4001EF7")]
	public const string PREFAB_PATH_CARDHISTORYVIEW = "DeckEdit/CardHIstory";

	[Token(Token = "0x4001EF8")]
	public const string PREFAB_PATH_LOOTSOURCE_VC = "DeckEdit/LootSource";

	[Token(Token = "0x4001EF9")]
	private const string LABEL_HEADER = "Header";

	[Token(Token = "0x4001EFA")]
	private const string LABEL_OVERHEADER = "OverHeader";

	[Token(Token = "0x4001EFB")]
	private const string LABEL_TXT_TOURNAMENTTITLE = "TextRegulation";

	[Token(Token = "0x4001EFC")]
	private const string LABEL_DECKVIEW = "DeckView";

	[Token(Token = "0x4001EFD")]
	private const string LABEL_CARDACTIONMENU = "CardActionMenu";

	[Token(Token = "0x4001EFE")]
	private const string LABEL_DETAILVIEW = "DetailView";

	[Token(Token = "0x4001EFF")]
	private const string LABEL_COLLECTIONVIEW = "CollectionView";

	[Token(Token = "0x4001F00")]
	private const string LABEL_HISTORYVIEW = "HistoryView";

	[Token(Token = "0x4001F01")]
	private const string LABEL_TEMPLATEFOOTERDESC = "TemplateFooterDesc";

	[Token(Token = "0x4001F02")]
	private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

	[Token(Token = "0x4001F03")]
	private const string LABEL_DROPAREA = "DropArea";

	[Token(Token = "0x4001F04")]
	private const string LABEL_DRAGCARD = "DragCard";

	[Token(Token = "0x4001F05")]
	private const string LABEL_RT_SELECTEDWINDOW = "CursorWindowSelect";

	[Token(Token = "0x4001F06")]
	private const string LABEL_RT_FOOTER = "Footer";

	[Token(Token = "0x4001F07")]
	public const string SG_DeckList = "DeckListGroup";

	[Token(Token = "0x4001F08")]
	public const string SG_Collection = "CardCollectionGroup";

	[Token(Token = "0x4001F09")]
	public const string SG_History = "CardHistoryGroup";

	[Token(Token = "0x4001F0A")]
	public const string SG_CardActionMenu = "CardActionMenu";

	[Token(Token = "0x4001F0B")]
	public const string SG_FilterDialog = "FilterDialog";

	[Token(Token = "0x4001F0C")]
	public const string SG_CraftDialog = "CraftDialog";

	[Token(Token = "0x4001F0D")]
	protected const string LABEL_SBN_DISPLAYMODE = "ButtonInfoSwitching";

	[Token(Token = "0x4001F0E")]
	protected const string LABEL_RT_DISPLAYMODE0 = "ButtonInfoSwitching/IconInfoSwitching0";

	[Token(Token = "0x4001F0F")]
	protected const string LABEL_RT_DISPLAYMODE1 = "ButtonInfoSwitching/IconInfoSwitching1";

	[Token(Token = "0x4001F10")]
	protected const string LABEL_RT_DISPLAYMODE2 = "ButtonInfoSwitching/IconInfoSwitching2";

	[Token(Token = "0x4001F11")]
	private const string LABEL_SBN_REGUBUTTON = "ButtonRegulation";

	[Token(Token = "0x4001F12")]
	private const string LABEL_IMG_REGU = "ButtonRegulation/Logo";

	[Token(Token = "0x4001F13")]
	protected const string LABEL_SBN_SAVEBUTTON = "ButtonSave";

	[Token(Token = "0x4001F14")]
	protected const string LABEL_SBN_MENUBUTTON = "ButtonMenu";

	[Token(Token = "0x4001F15")]
	private const string LABEL_SBN_CANCELBUTTON = "ButtonCancel";

	[Token(Token = "0x4001F16")]
	private const string LABEL_SBN_BACKBUTTON = "Back";

	[Token(Token = "0x4001F17")]
	private const string LABEL_TXT_NUMCPN = "NumTextCPN";

	[Token(Token = "0x4001F18")]
	private const string LABEL_TXT_NUMCPR = "NumTextCPR";

	[Token(Token = "0x4001F19")]
	private const string LABEL_TXT_NUMCPSR = "NumTextCPSR";

	[Token(Token = "0x4001F1A")]
	private const string LABEL_TXT_NUMCPUR = "NumTextCPUR";

	[Token(Token = "0x4001F1B")]
	private const string LABEL_SBN_SECRETPACK = "ButtonSecretPack";

	[Token(Token = "0x4001F1C")]
	private const string LABEL_SBN_REGLATION = "ButtonReglation";

	[Token(Token = "0x4001F1D")]
	private const string LABEL_TXT_NUMSECRETPACK = "NumBadgeText";

	[Token(Token = "0x4001F1E")]
	private const string LABEL_BADGE_SECRETPACK = "NumBadge";

	[Token(Token = "0x4001F1F")]
	protected const string Label_BGM = "BGM_MENU_02";

	[Token(Token = "0x4001F20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected ElementObjectManager m_HeaderEom;

	[Token(Token = "0x4001F21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected ElementObjectManager m_OverHeaderEom;

	[Token(Token = "0x4001F22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected ElementObjectManager m_DeckViewEom;

	[Token(Token = "0x4001F23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected ElementObjectManager m_CardActionMenuEom;

	[Token(Token = "0x4001F24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected ElementObjectManager m_DetailViewEom;

	[Token(Token = "0x4001F25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	protected ElementObjectManager m_CollectionViewEom;

	[Token(Token = "0x4001F26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private CraftEffect craftEffect;

	[Token(Token = "0x4001F27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool fromDeckSelect;

	[Token(Token = "0x4001F28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Action<int, List<int>> shopTransitionCallback;

	[Token(Token = "0x4001F29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	protected SelectionButton m_DisplayModeButton;

	[Token(Token = "0x4001F2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private RectTransform m_DisplayMode0;

	[Token(Token = "0x4001F2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private RectTransform m_DisplayMode1;

	[Token(Token = "0x4001F2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private RectTransform m_DisplayMode2;

	[Token(Token = "0x4001F2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	protected SelectionButton m_RegulationButton;

	[Token(Token = "0x4001F2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Image m_RegulationImage;

	[Token(Token = "0x4001F2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	protected SelectionButton m_SaveButton;

	[Token(Token = "0x4001F30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected SelectionButton m_MenuButton;

	[Token(Token = "0x4001F31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	protected SelectionButton m_CancelButton;

	[Token(Token = "0x4001F32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	protected SelectionButton m_BackButton;

	[Token(Token = "0x4001F33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private SelectionButton m_SecretPackButton;

	[Token(Token = "0x4001F34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	protected GameObject m_BadgeSecretPack;

	[Token(Token = "0x4001F35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ExtendedTextMeshProUGUI m_NumSecretPackText;

	[Token(Token = "0x4001F36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private ExtendedTextMeshProUGUI m_NumCPN;

	[Token(Token = "0x4001F37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private ExtendedTextMeshProUGUI m_NumCPR;

	[Token(Token = "0x4001F38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private ExtendedTextMeshProUGUI m_NumCPSR;

	[Token(Token = "0x4001F39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private ExtendedTextMeshProUGUI m_NumCPUR;

	[Token(Token = "0x4001F3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	protected ElementObjectManager m_templateFooterDesc;

	[Token(Token = "0x4001F3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private RectTransform m_Footer;

	[Token(Token = "0x4001F3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	protected AnalogDirectionListener m_AnalogManager;

	[Token(Token = "0x4001F3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	protected DeckView m_DeckView;

	[Token(Token = "0x4001F3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	protected CardActionMenu m_CardActionMenu;

	[Token(Token = "0x4001F3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	protected CardCollectionView m_CollectionView;

	[Token(Token = "0x4001F40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	protected CardDetailView m_DetailView;

	[Token(Token = "0x4001F41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	protected bool isCardActionMenuOpen;

	[Token(Token = "0x4001F45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private List<(OperationType, List<(int, int)>)> m_OperationList;

	[Token(Token = "0x4001F46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private int m_OperationListMax;

	[Token(Token = "0x4001F47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	protected List<CardBaseData> m_MainDeckCards;

	[Token(Token = "0x4001F48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	protected List<CardBaseData> m_ExtraDeckCards;

	[Token(Token = "0x4001F49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	protected List<CardBaseData> m_BookmarkedCards;

	[Token(Token = "0x4001F4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private List<CardBaseData> m_BookmarkedCardsBuf;

	[Token(Token = "0x4001F4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private List<CardBaseData> m_HistoryCards;

	[Token(Token = "0x4001F4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private List<CardBaseData> m_DismantleCards;

	[Token(Token = "0x4001F4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	protected List<CardBaseData> m_LockCards;

	[Token(Token = "0x4001F53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	private TransitionCard prefabTransitionCard;

	[Token(Token = "0x4001F54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private DeckEditFooter m_DeckEditFooter;

	[Token(Token = "0x4001F55")]
	protected const string LABEL_DropArea_Collection = "CardCollection";

	[Token(Token = "0x4001F56")]
	protected const string LABEL_DropArea_Deck = "DeckList";

	[Token(Token = "0x4001F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	protected Dictionary<string, UnityAction> dropAreaActions;

	[Token(Token = "0x4001F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	protected Dictionary<string, DropArea> dropAreas;

	[Token(Token = "0x4001F59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private Camera m_Camera;

	[Token(Token = "0x4001F5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private SearchFilter.Setting m_CardListFilterSettings;

	[Token(Token = "0x4001F5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private SearchFilter.Setting m_BookmarkFilterSettings;

	[Token(Token = "0x4001F5C")]
	private const string FilterOptionsFileName = "FilterOptions";

	[Token(Token = "0x4001F5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private string m_CardListSearchKeyword;

	[Token(Token = "0x4001F5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private string m_BockmarkSearchKeyword;

	[Token(Token = "0x4001F5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private SortComparer.Sorter m_CardListSorter;

	[Token(Token = "0x4001F60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private SortComparer.Sorter m_BookmarkSorter;

	[Token(Token = "0x4001F61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private float holdTime;

	[Token(Token = "0x4001F62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private SecretPackEffect secretPackEffect;

	[Token(Token = "0x4001F63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private int relatedCardID;

	[Token(Token = "0x4001F64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	protected ViewType currentView;

	[Token(Token = "0x4001F65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	protected SelectedCardType footerSelectingCard;

	[Token(Token = "0x4001F66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	protected bool option1Activate;

	[Token(Token = "0x4001F67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x345")]
	protected bool option2Activate;

	[Token(Token = "0x4001F68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x346")]
	protected bool option1ActivateChecker;

	[Token(Token = "0x4001F69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x347")]
	protected bool option2ActivateChecker;

	[Token(Token = "0x4001F6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	protected bool mainViewActivated;

	[Token(Token = "0x4001F6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	[SerializeField]
	protected KeyConfigContainer keyConfig;

	[Token(Token = "0x4001F6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	[SerializeField]
	private BezierMotionContainer bezierCraftCreate;

	[Token(Token = "0x4001F6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	[SerializeField]
	private BezierMotionContainer bezierCraftDismantle;

	[Token(Token = "0x4001F6E")]
	private const int MAX_HISTORY_CARDNUM = 30;

	[Token(Token = "0x4001F6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	private bool horizontalSwipe;

	[Token(Token = "0x4001F70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x369")]
	private bool activateTransition;

	[Token(Token = "0x4001F71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
	private Vector2 pressedPoint;

	[Token(Token = "0x4001F72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	private Dictionary<int, CardCollectionInfo.SecretPackInfo> secretPacks;

	[Token(Token = "0x4001F73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	private AutoBuildSetting m_AutoBuildSetting;

	[Token(Token = "0x4001F74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	protected Dictionary<int, CraftCompensation> m_Compensation;

	[Token(Token = "0x4001F75")]
	private const int MULTIDISMANTLEMAX = 60;

	[Token(Token = "0x4001F76")]
	private const int MULTILOCKMAX = 50;

	[Token(Token = "0x4001F77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	private bool requestUpdateView;

	[Token(Token = "0x17000561")]
	protected DisplayMode m_DisplayMode
	{
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x6D4620", Offset = "0x6D3820", VA = "0x1806D4620")]
		[CompilerGenerated]
		get
		{
			return default(DisplayMode);
		}
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x6D7640", Offset = "0x6D6840", VA = "0x1806D7640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000562")]
	protected EditMode m_EditMode
	{
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x6D4630", Offset = "0x6D3830", VA = "0x1806D4630")]
		[CompilerGenerated]
		get
		{
			return default(EditMode);
		}
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x6D7650", Offset = "0x6D6850", VA = "0x1806D7650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000563")]
	protected int m_OldRegulationID
	{
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x6D4710", Offset = "0x6D3910", VA = "0x1806D4710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x6D7720", Offset = "0x6D6920", VA = "0x1806D7720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000564")]
	protected DragCard dragCard
	{
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x6D4550", Offset = "0x6D3750", VA = "0x1806D4550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000565")]
	protected List<CardBaseData> m_CardCollection
	{
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x49B7B0", Offset = "0x49A9B0", VA = "0x18049B7B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x49C040", Offset = "0x49B240", VA = "0x18049C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000566")]
	private List<CardBaseData> m_CardListBuff
	{
		[Token(Token = "0x60029CE")]
		[Address(RVA = "0x6D4600", Offset = "0x6D3800", VA = "0x1806D4600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x6D7610", Offset = "0x6D6810", VA = "0x1806D7610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000567")]
	private List<CardBaseData> m_RelatedCardList
	{
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x49BC10", Offset = "0x49AE10", VA = "0x18049BC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x49C2C0", Offset = "0x49B4C0", VA = "0x18049C2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000568")]
	public int m_DeckID
	{
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x6D4610", Offset = "0x6D3810", VA = "0x1806D4610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x6D7630", Offset = "0x6D6830", VA = "0x1806D7630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000569")]
	public string m_DeckName
	{
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x49B8E0", Offset = "0x49AAE0", VA = "0x18049B8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x49C140", Offset = "0x49B340", VA = "0x18049C140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700056A")]
	public string m_EventDeckName
	{
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x6D4640", Offset = "0x6D3840", VA = "0x1806D4640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029D7")]
		[Address(RVA = "0x4D4300", Offset = "0x4D3500", VA = "0x1804D4300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700056B")]
	public string m_OldDeckName
	{
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x6D4700", Offset = "0x6D3900", VA = "0x1806D4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x498130", Offset = "0x497330", VA = "0x180498130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700056C")]
	protected bool showAllCards
	{
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x6D47F0", Offset = "0x6D39F0", VA = "0x1806D47F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x6D7890", Offset = "0x6D6A90", VA = "0x1806D7890")]
		set
		{
		}
	}

	[Token(Token = "0x1700056D")]
	public bool m_IsCopyDeckEdit
	{
		[Token(Token = "0x60029DD")]
		[Address(RVA = "0x6D46F0", Offset = "0x6D38F0", VA = "0x1806D46F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029DE")]
		[Address(RVA = "0x6D7710", Offset = "0x6D6910", VA = "0x1806D7710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700056E")]
	protected SearchFilter.Setting m_FilterSettings
	{
		[Token(Token = "0x60029DF")]
		[Address(RVA = "0x6D4650", Offset = "0x6D3850", VA = "0x1806D4650")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029E0")]
		[Address(RVA = "0x6D7660", Offset = "0x6D6860", VA = "0x1806D7660")]
		set
		{
		}
	}

	[Token(Token = "0x1700056F")]
	protected string m_SearchKeyword
	{
		[Token(Token = "0x60029E1")]
		[Address(RVA = "0x6D4720", Offset = "0x6D3920", VA = "0x1806D4720")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x6D7730", Offset = "0x6D6930", VA = "0x1806D7730")]
		set
		{
		}
	}

	[Token(Token = "0x17000570")]
	public SortComparer.Sorter m_Sorter
	{
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x6D4780", Offset = "0x6D3980", VA = "0x1806D4780")]
		get
		{
			return default(SortComparer.Sorter);
		}
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x6D77E0", Offset = "0x6D69E0", VA = "0x1806D77E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000571")]
	private int BookmarkNumMax
	{
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x6D4520", Offset = "0x6D3720", VA = "0x1806D4520")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000572")]
	protected bool isMobile
	{
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x6D45B0", Offset = "0x6D37B0", VA = "0x1806D45B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x6C1630", Offset = "0x6C0830", VA = "0x1806C1630")]
	protected void InitializeElements()
	{
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x6C4E50", Offset = "0x6C4050", VA = "0x1806C4E50")]
	public bool IsImplemented(int cardId)
	{
		return default(bool);
	}

	[Token(Token = "0x60029E7")]
	[Address(RVA = "0x6C50C0", Offset = "0x6C42C0", VA = "0x1806C50C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60029E8")]
	[Address(RVA = "0x6C1DF0", Offset = "0x6C0FF0", VA = "0x1806C1DF0", Slot = "28")]
	protected virtual void InitializeView()
	{
	}

	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x6CBB00", Offset = "0x6CAD00", VA = "0x1806CBB00", Slot = "29")]
	protected virtual void SetShortcutSettings()
	{
	}

	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x6BF320", Offset = "0x6BE520", VA = "0x1806BF320", Slot = "30")]
	protected virtual void InitDeckList()
	{
	}

	[Token(Token = "0x60029EB")]
	[Address(RVA = "0x6C07F0", Offset = "0x6BF9F0", VA = "0x1806C07F0")]
	private void InitRentalCards()
	{
	}

	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x6C6800", Offset = "0x6C5A00", VA = "0x1806C6800")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x6C53D0", Offset = "0x6C45D0", VA = "0x1806C53D0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x6C69D0", Offset = "0x6C5BD0", VA = "0x1806C69D0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x6C4FF0", Offset = "0x6C41F0", VA = "0x1806C4FF0")]
	protected void MainViewActivated()
	{
	}

	[Token(Token = "0x60029F0")]
	[Address(RVA = "0x6C5020", Offset = "0x6C4220", VA = "0x1806C5020")]
	protected void MainViewDeactivated()
	{
	}

	[Token(Token = "0x60029F1")]
	[Address(RVA = "0x657EB0", Offset = "0x6570B0", VA = "0x180657EB0")]
	private void Start()
	{
	}

	[Token(Token = "0x60029F2")]
	[Address(RVA = "0x6CD4E0", Offset = "0x6CC6E0", VA = "0x1806CD4E0")]
	protected void SortDeckViewCards()
	{
	}

	[Token(Token = "0x60029F3")]
	[Address(RVA = "0x6C0C90", Offset = "0x6BFE90", VA = "0x1806C0C90")]
	public void InitializeCardCollectionView()
	{
	}

	[Token(Token = "0x60029F4")]
	[Address(RVA = "0x6C4ED0", Offset = "0x6C40D0", VA = "0x1806C4ED0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60029F5")]
	[Address(RVA = "0x6C6D40", Offset = "0x6C5F40", VA = "0x1806C6D40")]
	public void OnSubmitDeckName(string deckName)
	{
	}

	[Token(Token = "0x60029F6")]
	[Address(RVA = "0x6C6AC0", Offset = "0x6C5CC0", VA = "0x1806C6AC0")]
	public void OnResetSearchButton()
	{
	}

	[Token(Token = "0x60029F7")]
	[Address(RVA = "0x6C6D90", Offset = "0x6C5F90", VA = "0x1806C6D90")]
	public void OnSubmitSearch(string text)
	{
	}

	[Token(Token = "0x60029F8")]
	[Address(RVA = "0x6C5820", Offset = "0x6C4A20", VA = "0x1806C5820")]
	public void OnClickFilterButton()
	{
	}

	[Token(Token = "0x60029F9")]
	[Address(RVA = "0x6CE080", Offset = "0x6CD280", VA = "0x1806CE080")]
	public void ToggleShowAllCards()
	{
	}

	[Token(Token = "0x60029FA")]
	[Address(RVA = "0x6D4150", Offset = "0x6D3350", VA = "0x1806D4150")]
	private List<CardBaseData> getTargetCardCollection(CardCollectionView.Area area)
	{
		return null;
	}

	[Token(Token = "0x60029FB")]
	[Address(RVA = "0x6C6060", Offset = "0x6C5260", VA = "0x1806C6060")]
	public void OnClickRelatedCardButton(int cardID)
	{
	}

	[Token(Token = "0x60029FC")]
	[Address(RVA = "0x6D3940", Offset = "0x6D2B40", VA = "0x1806D3940")]
	private List<CardBaseData> getRelatedCardList(int cardID, bool fullStyle)
	{
		return null;
	}

	[Token(Token = "0x60029FD")]
	[Address(RVA = "0x6BCAF0", Offset = "0x6BBCF0", VA = "0x1806BCAF0")]
	private void CloseRelatedCard()
	{
	}

	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x6B9B60", Offset = "0x6B8D60", VA = "0x1806B9B60")]
	private bool AddToBookmark(CardBaseData cbd)
	{
		return default(bool);
	}

	[Token(Token = "0x60029FF")]
	[Address(RVA = "0x6C8CB0", Offset = "0x6C7EB0", VA = "0x1806C8CB0")]
	private bool RemoveFromBookmark(CardBaseData cbd)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A00")]
	[Address(RVA = "0x6BA160", Offset = "0x6B9360", VA = "0x1806BA160")]
	public void AddToCardHistory(int id, int premiumID)
	{
	}

	[Token(Token = "0x6002A01")]
	[Address(RVA = "0x6B9FD0", Offset = "0x6B91D0", VA = "0x1806B9FD0")]
	public void AddToCardHistory(CardBaseData cbd)
	{
	}

	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x6C63A0", Offset = "0x6C55A0", VA = "0x1806C63A0")]
	public void OnClickSortButton()
	{
	}

	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x6C4DB0", Offset = "0x6C3FB0", VA = "0x1806C4DB0")]
	private bool IsBookmarked(CardBaseData cbd)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A04")]
	[Address(RVA = "0x6C4E00", Offset = "0x6C4000", VA = "0x1806C4E00")]
	private bool IsHistoried(CardBaseData cbd)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A05")]
	[Address(RVA = "0x6BDC30", Offset = "0x6BCE30", VA = "0x1806BDC30", Slot = "31")]
	protected virtual int GetDataIndex(CardBaseData cbd, List<CardBaseData> target)
	{
		return default(int);
	}

	[Token(Token = "0x6002A06")]
	[Address(RVA = "0x6C6ED0", Offset = "0x6C60D0", VA = "0x1806C6ED0")]
	private void OpenCPOverDialog([Optional] craftCallBack callback)
	{
	}

	[Token(Token = "0x6002A07")]
	[Address(RVA = "0x6C5AA0", Offset = "0x6C4CA0", VA = "0x1806C5AA0")]
	public void OnClickMassDismantleButton()
	{
	}

	[Token(Token = "0x6002A08")]
	[Address(RVA = "0x6BDD80", Offset = "0x6BCF80", VA = "0x1806BDD80")]
	public Dictionary<int, int> GetLackCards()
	{
		return null;
	}

	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x6BD560", Offset = "0x6BC760", VA = "0x1806BD560")]
	private List<CardBaseData> FormatLackCards(Dictionary<int, int> lackCards)
	{
		return null;
	}

	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x6C73D0", Offset = "0x6C65D0", VA = "0x1806C73D0")]
	public void OpenMultiCreateCraftDialog()
	{
	}

	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x6C5C60", Offset = "0x6C4E60", VA = "0x1806C5C60")]
	public void OnClickMultiDismantleButton()
	{
	}

	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x6C70A0", Offset = "0x6C62A0", VA = "0x1806C70A0", Slot = "32")]
	public virtual void OpenCardActionMenu(CardBaseData baseData, bool fromDeckList = true, int idx = -1)
	{
	}

	[Token(Token = "0x6002A0D")]
	[Address(RVA = "0x6BCBD0", Offset = "0x6BBDD0", VA = "0x1806BCBD0")]
	private void CraftCreate(CardBaseData baseData, bool actionMenu)
	{
	}

	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0x6BCFF0", Offset = "0x6BC1F0", VA = "0x1806BCFF0")]
	private void CraftDismantle(CardBaseData baseData, bool actionMenu)
	{
	}

	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0x6BCA60", Offset = "0x6BBC60", VA = "0x1806BCA60")]
	public void CloseActionDialog()
	{
	}

	[Token(Token = "0x6002A10")]
	[Address(RVA = "0x6D7990", Offset = "0x6D6B90", VA = "0x1806D7990")]
	protected bool updateInDeckCards(DeckInfo.DeckType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A11")]
	[Address(RVA = "0x6C5050", Offset = "0x6C4250", VA = "0x1806C5050")]
	protected bool NeedSave()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A12")]
	[Address(RVA = "0x6D5DE0", Offset = "0x6D4FE0", VA = "0x1806D5DE0", Slot = "33")]
	protected virtual void initializeDetailView(CardBaseData baseData)
	{
	}

	[Token(Token = "0x6002A13")]
	[Address(RVA = "0x6D4910", Offset = "0x6D3B10", VA = "0x1806D4910")]
	protected void initializeCard(DeckCard card, bool setData, int idx = -1)
	{
	}

	[Token(Token = "0x6002A14")]
	[Address(RVA = "0x6D5140", Offset = "0x6D4340", VA = "0x1806D5140")]
	private void initializeCard(CardStrip card, bool historyView)
	{
	}

	[Token(Token = "0x6002A15")]
	[Address(RVA = "0x6C65A0", Offset = "0x6C57A0", VA = "0x1806C65A0")]
	private void OnCreateCardInDeck(CardBaseData baseData, int craftNum, bool invokeFromActionMenu, int compensationId, bool check, (int, int, int) oldNum, bool isBoost, (CardCollectionInfo.Premium, int) boostParam, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6002A16")]
	[Address(RVA = "0x6C6850", Offset = "0x6C5A50", VA = "0x1806C6850")]
	private void OnDismantleCardInDeck(CardBaseData baseData, int craftNum, bool invokeFromActionMenu, (int, int, bool) compensationDic, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6002A17")]
	[Address(RVA = "0x6BA1D0", Offset = "0x6B93D0", VA = "0x1806BA1D0")]
	public DeckCard AddToMainOrExtraDeck(CardBase card, [Optional] Vector3? basePos, [Optional] Vector3? targetPos)
	{
		return null;
	}

	[Token(Token = "0x6002A18")]
	[Address(RVA = "0x6BA3C0", Offset = "0x6B95C0", VA = "0x1806BA3C0")]
	public DeckCard AddToMainOrExtraDeck(CardBaseData baseData, bool isUndo = false)
	{
		return null;
	}

	[Token(Token = "0x6002A19")]
	[Address(RVA = "0x6B90B0", Offset = "0x6B82B0", VA = "0x1806B90B0")]
	public DeckCard AddForDismantle(CardBase card, [Optional] Vector3? basePos, [Optional] Vector3? targetPos)
	{
		return null;
	}

	[Token(Token = "0x6002A1A")]
	[Address(RVA = "0x6B8B80", Offset = "0x6B7D80", VA = "0x1806B8B80")]
	public DeckCard AddForDismantle(CardBaseData baseData)
	{
		return null;
	}

	[Token(Token = "0x6002A1B")]
	[Address(RVA = "0x6B92B0", Offset = "0x6B84B0", VA = "0x1806B92B0")]
	public DeckCard AddForLock(CardBase card, [Optional] Vector3? basePos, [Optional] Vector3? targetPos)
	{
		return null;
	}

	[Token(Token = "0x6002A1C")]
	[Address(RVA = "0x6B94B0", Offset = "0x6B86B0", VA = "0x1806B94B0")]
	public DeckCard AddForLock(CardBaseData baseData)
	{
		return null;
	}

	[Token(Token = "0x6002A1D")]
	[Address(RVA = "0x6B98D0", Offset = "0x6B8AD0", VA = "0x1806B98D0")]
	public void AddOperationList(OperationType type, List<(int, int)> cardDataList)
	{
	}

	[Token(Token = "0x6002A1E")]
	[Address(RVA = "0x6CCDB0", Offset = "0x6CBFB0", VA = "0x1806CCDB0")]
	private bool ShowAddableMessage(DeckView.AddableType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A1F")]
	[Address(RVA = "0x6C9170", Offset = "0x6C8370", VA = "0x1806C9170")]
	public void RemoveFromDeck(DeckCard card, bool isDrag = false, [Optional] Vector3? pos, bool isFlick = false)
	{
	}

	[Token(Token = "0x6002A20")]
	[Address(RVA = "0x6C8F10", Offset = "0x6C8110", VA = "0x1806C8F10")]
	public DeckCard RemoveFromDeck(CardBaseData baseData, bool isUndo = false)
	{
		return null;
	}

	[Token(Token = "0x6002A21")]
	[Address(RVA = "0x6C8840", Offset = "0x6C7A40", VA = "0x1806C8840")]
	protected void RemoveAllFromDeck()
	{
	}

	[Token(Token = "0x6002A22")]
	[Address(RVA = "0x6C9440", Offset = "0x6C8640", VA = "0x1806C9440")]
	public void RemoveFromDismantle(DeckCard card, bool isDrag = false, [Optional] Vector3? pos, bool toCollectionTab = false)
	{
	}

	[Token(Token = "0x6002A23")]
	[Address(RVA = "0x6C9690", Offset = "0x6C8890", VA = "0x1806C9690")]
	public DeckCard RemoveFromDismantle(CardBaseData baseData)
	{
		return null;
	}

	[Token(Token = "0x6002A24")]
	[Address(RVA = "0x6C9AD0", Offset = "0x6C8CD0", VA = "0x1806C9AD0")]
	public void RemoveFromLock(DeckCard card, bool isDrag = false, [Optional] Vector3? pos, bool toCollectionTab = false)
	{
	}

	[Token(Token = "0x6002A25")]
	[Address(RVA = "0x6C98B0", Offset = "0x6C8AB0", VA = "0x1806C98B0")]
	public DeckCard RemoveFromLock(CardBaseData baseData)
	{
		return null;
	}

	[Token(Token = "0x6002A26")]
	[Address(RVA = "0x6CD750", Offset = "0x6CC950", VA = "0x1806CD750")]
	protected void StartCardTransition(CardBase baseCard, CardBase targetCard, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6002A27")]
	[Address(RVA = "0x6CD9D0", Offset = "0x6CCBD0", VA = "0x1806CD9D0")]
	private void StartCardTransition(Vector3 baseCardPosition, CardBase targetCard, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6002A28")]
	[Address(RVA = "0x6CD870", Offset = "0x6CCA70", VA = "0x1806CD870")]
	protected void StartCardTransition(CardBase baseCard, Vector3 targetPosition, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6002A29")]
	[Address(RVA = "0x6CDBE0", Offset = "0x6CCDE0", VA = "0x1806CDBE0")]
	private void StartCardTransition(CardBaseData cbd, Vector3 baseCardPosition, Vector3 targetPosition, TransitionCard.MotionMode motionMode, bool outFade, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6002A2A")]
	[Address(RVA = "0x6CD570", Offset = "0x6CC770", VA = "0x1806CD570")]
	protected void StartCardAddEffect(CardBase targetCard, TransitionCard.Size size)
	{
	}

	[Token(Token = "0x6002A2B")]
	[Address(RVA = "0x6BB210", Offset = "0x6BA410", VA = "0x1806BB210")]
	public bool BookmarkCard(CardBaseData baseData)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A2C")]
	[Address(RVA = "0x6C57A0", Offset = "0x6C49A0", VA = "0x1806C57A0")]
	public void OnClickBackButton()
	{
	}

	[Token(Token = "0x6002A2D")]
	[Address(RVA = "0x6CD290", Offset = "0x6CC490", VA = "0x1806CD290")]
	private void ShowModifiedDialog(SaveDialogType type, Action onAccept, Action onCancel)
	{
	}

	[Token(Token = "0x6002A2E")]
	[Address(RVA = "0x6C6200", Offset = "0x6C5400", VA = "0x1806C6200")]
	public void OnClickSaveButton()
	{
	}

	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0x6BF080", Offset = "0x6BE280", VA = "0x1806BF080")]
	private string GetSaveAlertMessage()
	{
		return null;
	}

	[Token(Token = "0x6002A30")]
	[Address(RVA = "0x6BD9A0", Offset = "0x6BCBA0", VA = "0x1806BD9A0")]
	protected Dictionary<string, object> GetCurrentPickCards()
	{
		return null;
	}

	[Token(Token = "0x6002A31")]
	[Address(RVA = "0x6C9E80", Offset = "0x6C9080", VA = "0x1806C9E80", Slot = "34")]
	protected virtual void SaveDeck([Optional] Action finishedCallback, bool blockInput = false)
	{
	}

	[Token(Token = "0x6002A32")]
	[Address(RVA = "0x6C7E60", Offset = "0x6C7060", VA = "0x1806C7E60")]
	private void OpenOutOfTermDialog()
	{
	}

	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x6C9D20", Offset = "0x6C8F20", VA = "0x1806C9D20")]
	private void SaveBookmark([Optional] Action finishedCallback)
	{
	}

	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x6CA4F0", Offset = "0x6C96F0", VA = "0x1806CA4F0")]
	private void SaveLockList([Optional] Action finishedCallback)
	{
	}

	[Token(Token = "0x6002A35")]
	[Address(RVA = "0x6CD130", Offset = "0x6CC330", VA = "0x1806CD130", Slot = "35")]
	protected virtual void ShowMenu()
	{
	}

	[Token(Token = "0x6002A36")]
	[Address(RVA = "0x6C8670", Offset = "0x6C7870", VA = "0x1806C8670")]
	private void RefreshRegulation(int regId)
	{
	}

	[Token(Token = "0x6002A37")]
	[Address(RVA = "0x6C5E50", Offset = "0x6C5050", VA = "0x1806C5E50")]
	private void OnClickRegulation()
	{
	}

	[Token(Token = "0x6002A38")]
	[Address(RVA = "0x6C5550", Offset = "0x6C4750", VA = "0x1806C5550")]
	private void OnClickAutoBuild([Optional] Action<bool> finishedCallback)
	{
	}

	[Token(Token = "0x6002A39")]
	[Address(RVA = "0x6BAA40", Offset = "0x6B9C40", VA = "0x1806BAA40")]
	private void AutoBuildDeck(bool isLackCard = false)
	{
	}

	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0x6D2500", Offset = "0x6D1700", VA = "0x1806D2500")]
	private void UndoOperation()
	{
	}

	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0x6C8100", Offset = "0x6C7300", VA = "0x1806C8100")]
	private void OpenResetDeckDialog()
	{
	}

	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0x6C6280", Offset = "0x6C5480", VA = "0x1806C6280")]
	private void OnClickSecretPack()
	{
	}

	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0x6CD3A0", Offset = "0x6CC5A0", VA = "0x1806CD3A0")]
	private void ShowSecretPackActivateEffect()
	{
	}

	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0x6CAA60", Offset = "0x6C9C60", VA = "0x1806CAA60")]
	protected void SetDispSecretPackButton(bool disp)
	{
	}

	[Token(Token = "0x6002A3F")]
	[Address(RVA = "0x6CA650", Offset = "0x6C9850", VA = "0x1806CA650")]
	protected void SetActiveDropAreas()
	{
	}

	[Token(Token = "0x6002A40")]
	[Address(RVA = "0x6CA790", Offset = "0x6C9990", VA = "0x1806CA790")]
	private void SetActiveExclusiveDropAreas(string label, bool canDrop = true)
	{
	}

	[Token(Token = "0x6002A41")]
	[Address(RVA = "0x6D6CA0", Offset = "0x6D5EA0", VA = "0x1806D6CA0")]
	private void onCraftCreateCard(CardBaseData cbd, int craftNum, bool isBoost, (CardCollectionInfo.Premium, int) boostParam, craftCallBack callback, bool invokeFromActionMenu, int compensationId, bool check)
	{
	}

	[Token(Token = "0x6002A42")]
	[Address(RVA = "0x6BD790", Offset = "0x6BC990", VA = "0x1806BD790")]
	private string GetCraftCreateResultMessage(CardBaseData cbd, int numNormal, int numShine, int numRoyal)
	{
		return null;
	}

	[Token(Token = "0x6002A43")]
	[Address(RVA = "0x6D3290", Offset = "0x6D2490", VA = "0x1806D3290")]
	private void UpdatePremNum(CardBaseData cbd, int premID)
	{
	}

	[Token(Token = "0x6002A44")]
	[Address(RVA = "0x6BB2B0", Offset = "0x6BA4B0", VA = "0x1806BB2B0")]
	private int CalcInsertPos(int cardID, int premID)
	{
		return default(int);
	}

	[Token(Token = "0x6002A45")]
	[Address(RVA = "0x6D7000", Offset = "0x6D6200", VA = "0x1806D7000")]
	private void onCraftDismantleCard(CardBaseData cbd, int craftNum, craftCallBack callback, bool invokeFromActionMenu, (int, int, bool) compensations)
	{
	}

	[Token(Token = "0x6002A46")]
	[Address(RVA = "0x6D2F50", Offset = "0x6D2150", VA = "0x1806D2F50")]
	private void UpdateCardBaseData(List<CardBaseData> list, int cardID, int premiumID)
	{
	}

	[Token(Token = "0x6002A47")]
	[Address(RVA = "0x6CDD90", Offset = "0x6CCF90", VA = "0x1806CDD90")]
	private void StartCreateEffect(RectTransform targetCard, RectTransform targetPoint, bool invokeFromActionMenu)
	{
	}

	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x6CDEE0", Offset = "0x6CD0E0", VA = "0x1806CDEE0")]
	private void StartDismantleEffect(RectTransform targetCard, RectTransform targetPoint, bool invokeFromActionMenu)
	{
	}

	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x6BDD20", Offset = "0x6BCF20", VA = "0x1806BDD20")]
	private RectTransform GetHeaderCraftPointRectTransform(int rarityID)
	{
		return null;
	}

	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x6D72F0", Offset = "0x6D64F0", VA = "0x1806D72F0")]
	private void saveFilterOptions()
	{
	}

	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x6D6630", Offset = "0x6D5830", VA = "0x1806D6630")]
	private void loadFilterOptions()
	{
	}

	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x6CAAA0", Offset = "0x6C9CA0", VA = "0x1806CAAA0")]
	protected void SetDisplayMode(DisplayMode displayMode, bool updateView)
	{
	}

	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x6D78D0", Offset = "0x6D6AD0", VA = "0x1806D78D0")]
	protected void toggleDisplayMode()
	{
	}

	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x6D4010", Offset = "0x6D3210", VA = "0x1806D4010")]
	protected int getRemainPremiumCard(int id, CardCollectionInfo.Premium prem)
	{
		return default(int);
	}

	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x6D7930", Offset = "0x6D6B30", VA = "0x1806D7930")]
	protected void toggleSelectedWindow(ViewType viewType, SelectedCardType selectingCard)
	{
	}

	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x6D3500", Offset = "0x6D2700", VA = "0x1806D3500")]
	private void UpdateSelectedWindow()
	{
	}

	[Token(Token = "0x6002A51")]
	[Address(RVA = "0x6CCAF0", Offset = "0x6CBCF0", VA = "0x1806CCAF0")]
	protected void SetupFooter()
	{
	}

	[Token(Token = "0x6002A52")]
	[Address(RVA = "0x6BCA30", Offset = "0x6BBC30", VA = "0x1806BCA30")]
	protected void ClearFooterDescription()
	{
	}

	[Token(Token = "0x6002A53")]
	[Address(RVA = "0x6CCEC0", Offset = "0x6CC0C0", VA = "0x1806CCEC0")]
	protected void ShowFooterDescription(ViewType viewType, SelectedCardType selectingCard)
	{
	}

	[Token(Token = "0x6002A54")]
	[Address(RVA = "0x6BD470", Offset = "0x6BC670", VA = "0x1806BD470")]
	[AsyncStateMachine(typeof(_003CFirstAsyncFilterAndSort_003Ed__347))]
	private Task FirstAsyncFilterAndSort(Action onFinish)
	{
		return null;
	}

	[Token(Token = "0x6002A55")]
	[Address(RVA = "0x6BA8E0", Offset = "0x6B9AE0", VA = "0x1806BA8E0")]
	[AsyncStateMachine(typeof(_003CAsyncFilterAndSort_003Ed__348))]
	private Task AsyncFilterAndSort(Action onFinish, bool setAll = true, [Optional] SortComparer.Sorter? targetSorter, bool filter = true, [Optional] CardCollectionView.Area? targetArea)
	{
		return null;
	}

	[Token(Token = "0x6002A56")]
	[Address(RVA = "0x6D3160", Offset = "0x6D2360", VA = "0x1806D3160")]
	public void UpdateCraftPointNum(int rarityID)
	{
	}

	[Token(Token = "0x6002A57")]
	[Address(RVA = "0x6D3240", Offset = "0x6D2440", VA = "0x1806D3240")]
	public void UpdateCraftPointNum()
	{
	}

	[Token(Token = "0x6002A58")]
	[Address(RVA = "0x6CAD10", Offset = "0x6C9F10", VA = "0x1806CAD10")]
	public void SetMode(DeckView.Mode mode)
	{
	}

	[Token(Token = "0x6002A59")]
	[Address(RVA = "0x6BB4B0", Offset = "0x6BA6B0", VA = "0x1806BB4B0")]
	public void CancelDismantleModeCheck()
	{
	}

	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0x6BB620", Offset = "0x6BA820", VA = "0x1806BB620")]
	public void CancelLockModeCheck()
	{
	}

	[Token(Token = "0x6002A5B")]
	[Address(RVA = "0x6C0C20", Offset = "0x6BFE20", VA = "0x1806C0C20")]
	[IteratorStateMachine(typeof(_003CInitialSetMainDeck_003Ed__354))]
	public IEnumerator InitialSetMainDeck()
	{
		return null;
	}

	[Token(Token = "0x6002A5C")]
	[Address(RVA = "0x6C0B40", Offset = "0x6BFD40", VA = "0x1806C0B40")]
	[IteratorStateMachine(typeof(_003CInitialSetExtraDeck_003Ed__355))]
	public IEnumerator InitialSetExtraDeck()
	{
		return null;
	}

	[Token(Token = "0x6002A5D")]
	[Address(RVA = "0x6C0BB0", Offset = "0x6BFDB0", VA = "0x1806C0BB0")]
	[IteratorStateMachine(typeof(_003CInitialSetLockCards_003Ed__356))]
	public IEnumerator InitialSetLockCards()
	{
		return null;
	}

	[Token(Token = "0x6002A5E")]
	[Address(RVA = "0x6BC670", Offset = "0x6BB870", VA = "0x1806BC670")]
	public bool CheckStyleFilling()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0x6BC8D0", Offset = "0x6BBAD0", VA = "0x1806BC8D0")]
	private bool CheckStyleFilling(CardBaseData cbd)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A60")]
	[Address(RVA = "0x6BE120", Offset = "0x6BD320", VA = "0x1806BE120")]
	public int GetNumInDeck(int cardID, int premiumID)
	{
		return default(int);
	}

	[Token(Token = "0x6002A61")]
	[Address(RVA = "0x6C0AB0", Offset = "0x6BFCB0", VA = "0x1806C0AB0")]
	[IteratorStateMachine(typeof(_003CInitialSetDeck_003Ed__360))]
	public IEnumerator InitialSetDeck(Action onFinish)
	{
		return null;
	}

	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x6C8560", Offset = "0x6C7760", VA = "0x1806C8560")]
	private void OpenStyleFillingDialog()
	{
	}

	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x6BBB50", Offset = "0x6BAD50", VA = "0x1806BBB50")]
	private (CardCollectionInfo.Premium, bool) CheckAlterPremiumInfo(ref CardBaseData baseData)
	{
		return default((CardCollectionInfo.Premium, bool));
	}

	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x6BBE70", Offset = "0x6BB070", VA = "0x1806BBE70")]
	private bool CheckReglationExistence()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x6C7F80", Offset = "0x6C7180", VA = "0x1806C7F80")]
	private void OpenReglationFillingDialog([Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6002A66")]
	[Address(RVA = "0x6C82A0", Offset = "0x6C74A0", VA = "0x1806C82A0")]
	private void OpenRoomRegulationCheck([Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6002A67")]
	[Address(RVA = "0x6C5980", Offset = "0x6C4B80", VA = "0x1806C5980")]
	public void OnClickLootSourceButton(CardBaseData data)
	{
	}

	[Token(Token = "0x6002A68")]
	[Address(RVA = "0x6BE370", Offset = "0x6BD570", VA = "0x1806BE370")]
	protected Dictionary<string, object> GetRepCards()
	{
		return null;
	}

	[Token(Token = "0x6002A69")]
	[Address(RVA = "0x6BBEF0", Offset = "0x6BB0F0", VA = "0x1806BBEF0")]
	protected Dictionary<string, object> CheckRepCards()
	{
		return null;
	}

	[Token(Token = "0x6002A6A")]
	[Address(RVA = "0x6C6A10", Offset = "0x6C5C10", VA = "0x1806C6A10")]
	protected void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0x6BBD00", Offset = "0x6BAF00", VA = "0x1806BBD00")]
	private void CheckFirstVisitRentalCard()
	{
	}

	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0x6D35A0", Offset = "0x6D27A0", VA = "0x1806D35A0")]
	public DeckEditViewController2()
	{
	}
}
