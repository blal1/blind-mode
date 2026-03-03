using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu;

[Token(Token = "0x20012F6")]
public class NeuronDeckSearchViewController : PublicDeckSearchController
{
	[Token(Token = "0x20012FA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x400BE90")]
		[FieldOffset(Offset = "0x10")]
		public bool completed;

		[Token(Token = "0x400BE91")]
		[FieldOffset(Offset = "0x14")]
		public int requestPageNo;

		[Token(Token = "0x400BE92")]
		[FieldOffset(Offset = "0x18")]
		public NeuronDeckSearchViewController _003C_003E4__this;

		[Token(Token = "0x400BE93")]
		[FieldOffset(Offset = "0x20")]
		public int sizePerPage;

		[Token(Token = "0x400BE94")]
		[FieldOffset(Offset = "0x24")]
		public bool isFirst;

		[Token(Token = "0x400BE95")]
		[FieldOffset(Offset = "0x28")]
		public UnityAction _003C_003E9__1;

		[Token(Token = "0x60075E6")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60075E7")]
		[Address(RVA = "0xBCF350", Offset = "0xBCE550", VA = "0x180BCF350")]
		internal void _003CDeckSearch_Search_003Eb__0(Handle e)
		{
		}

		[Token(Token = "0x60075E8")]
		[Address(RVA = "0xBCF600", Offset = "0xBCE800", VA = "0x180BCF600")]
		internal void _003CDeckSearch_Search_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20012FC")]
	[CompilerGenerated]
	private sealed class _003CAdditionalDeckDataLoad_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BE9C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BE9D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BE9E")]
		[FieldOffset(Offset = "0x20")]
		public NeuronDeckSearchViewController _003C_003E4__this;

		[Token(Token = "0x17001269")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60075EF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700126A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60075F1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60075EC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAdditionalDeckDataLoad_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60075ED")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60075EE")]
		[Address(RVA = "0xBCC980", Offset = "0xBCBB80", VA = "0x180BCC980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60075F0")]
		[Address(RVA = "0xBCCA70", Offset = "0xBCBC70", VA = "0x180BCCA70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20012FD")]
	[CompilerGenerated]
	private sealed class _003CDeckSearch_Search_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BE9F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BEA0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BEA1")]
		[FieldOffset(Offset = "0x20")]
		public int requestPageNo;

		[Token(Token = "0x400BEA2")]
		[FieldOffset(Offset = "0x28")]
		public NeuronDeckSearchViewController _003C_003E4__this;

		[Token(Token = "0x400BEA3")]
		[FieldOffset(Offset = "0x30")]
		public bool isFirst;

		[Token(Token = "0x400BEA4")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x1700126B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60075F5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700126C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60075F7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60075F2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDeckSearch_Search_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60075F3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60075F4")]
		[Address(RVA = "0xBCCAB0", Offset = "0xBCBCB0", VA = "0x180BCCAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60075F6")]
		[Address(RVA = "0xBCCCC0", Offset = "0xBCBEC0", VA = "0x180BCCCC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20012FE")]
	[CompilerGenerated]
	private sealed class _003CInitialize_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BEA5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BEA6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BEA7")]
		[FieldOffset(Offset = "0x20")]
		public NeuronDeckSearchViewController _003C_003E4__this;

		[Token(Token = "0x1700126D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60075FB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700126E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60075FD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60075F8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialize_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60075F9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60075FA")]
		[Address(RVA = "0xBCCDB0", Offset = "0xBCBFB0", VA = "0x180BCCDB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60075FC")]
		[Address(RVA = "0xBCCFC0", Offset = "0xBCC1C0", VA = "0x180BCCFC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BE79")]
	[FieldOffset(Offset = "0x270")]
	private readonly string k_ELabelDeckNumValue;

	[Token(Token = "0x400BE7A")]
	[FieldOffset(Offset = "0x278")]
	private readonly string k_ELabelTextDeckNumValue;

	[Token(Token = "0x400BE7B")]
	[FieldOffset(Offset = "0x280")]
	private readonly string k_ELabelNeuronDecksHelpButton;

	[Token(Token = "0x400BE7C")]
	[FieldOffset(Offset = "0x288")]
	private readonly string k_ELabelOpenNeuronDecksButton;

	[Token(Token = "0x400BE7D")]
	[FieldOffset(Offset = "0x290")]
	private readonly string k_ELabelNeuronLogoBG;

	[Token(Token = "0x400BE7E")]
	[FieldOffset(Offset = "0x298")]
	private readonly string k_ELabelNeuronLogoIconBG;

	[Token(Token = "0x400BE7F")]
	[FieldOffset(Offset = "0x2A0")]
	private Transform m_DeckNumValue;

	[Token(Token = "0x400BE80")]
	[FieldOffset(Offset = "0x2A8")]
	private TextMeshProUGUI m_TextDeckNumValue;

	[Token(Token = "0x400BE81")]
	[FieldOffset(Offset = "0x2B0")]
	private SelectionButton m_NeuronDecksHelpButton;

	[Token(Token = "0x400BE82")]
	[FieldOffset(Offset = "0x2B8")]
	private SelectionButton m_OpenNeuronDecksButton;

	[Token(Token = "0x400BE83")]
	[FieldOffset(Offset = "0x2C0")]
	private Transform m_NeuronLogoBG;

	[Token(Token = "0x400BE84")]
	[FieldOffset(Offset = "0x2C8")]
	private Image m_NeuronLogoIconBG;

	[Token(Token = "0x400BE85")]
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	private SpriteContainer m_BackGroundContainer;

	[Token(Token = "0x400BE86")]
	[FieldOffset(Offset = "0x2D8")]
	private readonly string k_LabelJpLogo;

	[Token(Token = "0x400BE87")]
	[FieldOffset(Offset = "0x2E0")]
	private readonly string k_LabelUniversalLogo;

	[Token(Token = "0x400BE88")]
	[FieldOffset(Offset = "0x2E8")]
	private readonly string k_LabelKoLogo;

	[Token(Token = "0x400BE89")]
	private const string GROUP_LABEL = "NeuronMyDeck";

	[Token(Token = "0x17001268")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60075CC")]
		[Address(RVA = "0xBC4EB0", Offset = "0xBC40B0", VA = "0x180BC4EB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075CD")]
	[Address(RVA = "0xBC26D0", Offset = "0xBC18D0", VA = "0x180BC26D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60075CE")]
	[Address(RVA = "0xBC2790", Offset = "0xBC1990", VA = "0x180BC2790", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60075CF")]
	[Address(RVA = "0xBC48E0", Offset = "0xBC3AE0", VA = "0x180BC48E0", Slot = "35")]
	protected override void UpdateDecks()
	{
	}

	[Token(Token = "0x60075D0")]
	[Address(RVA = "0xBC26E0", Offset = "0xBC18E0", VA = "0x180BC26E0", Slot = "31")]
	protected override void OnClickPublicDeck(string cardgameId, int deckNo, int pickCardId)
	{
	}

	[Token(Token = "0x60075D1")]
	[Address(RVA = "0xBC3430", Offset = "0xBC2630", VA = "0x180BC3430", Slot = "32")]
	public override void OpenDeckBrowser(string cardgameId, int deckNo, int pickCardId)
	{
	}

	[Token(Token = "0x60075D2")]
	[Address(RVA = "0xBC2660", Offset = "0xBC1860", VA = "0x180BC2660", Slot = "33")]
	[IteratorStateMachine(typeof(_003CInitialize_003Ed__24))]
	protected override IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x60075D3")]
	[Address(RVA = "0xBC2370", Offset = "0xBC1570", VA = "0x180BC2370", Slot = "34")]
	[IteratorStateMachine(typeof(_003CAdditionalDeckDataLoad_003Ed__25))]
	protected override IEnumerator AdditionalDeckDataLoad()
	{
		return null;
	}

	[Token(Token = "0x60075D4")]
	[Address(RVA = "0xBC31E0", Offset = "0xBC23E0", VA = "0x180BC31E0", Slot = "28")]
	public override void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x60075D5")]
	[Address(RVA = "0xBC2590", Offset = "0xBC1790", VA = "0x180BC2590")]
	private void GetNeuronToken(UnityAction getTokenEvent)
	{
	}

	[Token(Token = "0x60075D6")]
	[Address(RVA = "0xBC2500", Offset = "0xBC1700", VA = "0x180BC2500")]
	[IteratorStateMachine(typeof(_003CDeckSearch_Search_003Ed__28))]
	public IEnumerator DeckSearch_Search(int requestPageNo = 0, bool isFirst = false)
	{
		return null;
	}

	[Token(Token = "0x60075D7")]
	[Address(RVA = "0xBC23E0", Offset = "0xBC15E0", VA = "0x180BC23E0")]
	private void DeckSearch_Detail(string targetId, int deckNo, int pickCardId, bool isFirst = false)
	{
	}

	[Token(Token = "0x60075D8")]
	[Address(RVA = "0xBC33E0", Offset = "0xBC25E0", VA = "0x180BC33E0")]
	private void OpenCautionMMA()
	{
	}

	[Token(Token = "0x60075D9")]
	[Address(RVA = "0xBC4660", Offset = "0xBC3860", VA = "0x180BC4660", Slot = "36")]
	protected override void OpenMaintenanceDialog()
	{
	}

	[Token(Token = "0x60075DA")]
	[Address(RVA = "0xBC4CF0", Offset = "0xBC3EF0", VA = "0x180BC4CF0")]
	public NeuronDeckSearchViewController()
	{
	}
}
