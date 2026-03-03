using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.CardFile;

[Token(Token = "0x200157D")]
public abstract class CardFileBase : MonoBehaviour
{
	[Token(Token = "0x200157E")]
	private class PageItem
	{
		[Token(Token = "0x400CD5A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, SelectionButton> cardItemList;

		[Token(Token = "0x600854A")]
		[Address(RVA = "0xCDDB40", Offset = "0xCDCD40", VA = "0x180CDDB40")]
		public PageItem()
		{
		}
	}

	[Token(Token = "0x2001582")]
	[CompilerGenerated]
	private sealed class _003CInitAllPlacesProcess_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CD66")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CD67")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CD68")]
		[FieldOffset(Offset = "0x20")]
		public CardFileBase _003C_003E4__this;

		[Token(Token = "0x400CD69")]
		[FieldOffset(Offset = "0x28")]
		public Action onFinished;

		[Token(Token = "0x400CD6A")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x400CD6B")]
		[FieldOffset(Offset = "0x34")]
		private int _003Cpos_003E5__3;

		[Token(Token = "0x17001481")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600855E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001482")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008560")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600855B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitAllPlacesProcess_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600855C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600855D")]
		[Address(RVA = "0xCE1B20", Offset = "0xCE0D20", VA = "0x180CE1B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600855F")]
		[Address(RVA = "0xCE1E30", Offset = "0xCE1030", VA = "0x180CE1E30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CD53")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_CardFileDummy;

	[Token(Token = "0x400CD54")]
	[FieldOffset(Offset = "0x28")]
	private Selector selector;

	[Token(Token = "0x400CD55")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<CardFileDefinition.Location, PageItem> itemList;

	[Token(Token = "0x400CD56")]
	[FieldOffset(Offset = "0x38")]
	private CardFileDefinition.Location currentLoc;

	[Token(Token = "0x400CD57")]
	[FieldOffset(Offset = "0x3C")]
	private int currentPos;

	[Token(Token = "0x1700147F")]
	public CardFileManager cfManager
	{
		[Token(Token = "0x6008537")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008538")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001480")]
	public GameObject offsetObject
	{
		[Token(Token = "0x6008539")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600853A")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6008536")]
	public static T Create<T>(CardFileManager cfManager, GameObject root, string name, Action onFinished) where T : CardFileBase
	{
		return null;
	}

	[Token(Token = "0x600853B")]
	[Address(RVA = "0xCCDDF0", Offset = "0xCCCFF0", VA = "0x180CCDDF0")]
	protected void Initialize(Action onFinished)
	{
	}

	[Token(Token = "0x600853C")]
	[Address(RVA = "0xCCF720", Offset = "0xCCE920", VA = "0x180CCF720")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600853D")]
	protected abstract void AssignAll(CardFileDefinition.Location loc, GameObject parent);

	[Token(Token = "0x600853E")]
	protected abstract GameObject GetFrame(CardFileDefinition.Location loc, int position);

	[Token(Token = "0x600853F")]
	[Address(RVA = "0xCCE360", Offset = "0xCCD560", VA = "0x180CCE360")]
	private void SetOffsetDistance()
	{
	}

	[Token(Token = "0x6008540")]
	[Address(RVA = "0xCCDD60", Offset = "0xCCCF60", VA = "0x180CCDD60")]
	[IteratorStateMachine(typeof(_003CInitAllPlacesProcess_003Ed__20))]
	private IEnumerator InitAllPlacesProcess(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x6008541")]
	[Address(RVA = "0xCCD220", Offset = "0xCCC420", VA = "0x180CCD220")]
	private GameObject CreateAnchor(CardFileDefinition.Location loc, int position)
	{
		return null;
	}

	[Token(Token = "0x6008542")]
	[Address(RVA = "0xCCD0A0", Offset = "0xCCC2A0", VA = "0x180CCD0A0")]
	public void AddSelectionItem(CardFileDefinition.Location location, int position, SelectionButton item)
	{
	}

	[Token(Token = "0x6008543")]
	[Address(RVA = "0xCCDC70", Offset = "0xCCCE70", VA = "0x180CCDC70")]
	public SelectionButton GetSelectionItem(CardFileDefinition.Location location, int position)
	{
		return null;
	}

	[Token(Token = "0x6008544")]
	[Address(RVA = "0xCCF550", Offset = "0xCCE750", VA = "0x180CCF550")]
	public void SetupSelectionItemTransition()
	{
	}

	[Token(Token = "0x6008545")]
	[Address(RVA = "0xCCE440", Offset = "0xCCD640", VA = "0x180CCE440")]
	private void SetupSelectionItemTransition(SelectionButton item, PadInputDirection direction, CardFileDefinition.Location loc, int index)
	{
	}

	[Token(Token = "0x6008546")]
	[Address(RVA = "0xCCF0D0", Offset = "0xCCE2D0", VA = "0x180CCF0D0")]
	private void SetupSelectionItemTransition(SelectionButton item, PadInputDirection direction, CardFileDefinition.Location loc, int index, Dictionary<int, CardFileDefinition.CardPosition> selectionDict)
	{
	}

	[Token(Token = "0x6008547")]
	[Address(RVA = "0xCCE040", Offset = "0xCCD240", VA = "0x180CCE040")]
	public void SelectDefaultItem()
	{
	}

	[Token(Token = "0x6008548")]
	[Address(RVA = "0xCCDC00", Offset = "0xCCCE00", VA = "0x180CCDC00")]
	public void DeselectCurrentItem()
	{
	}

	[Token(Token = "0x6008549")]
	[Address(RVA = "0xCCF7C0", Offset = "0xCCE9C0", VA = "0x180CCF7C0")]
	protected CardFileBase()
	{
	}
}
