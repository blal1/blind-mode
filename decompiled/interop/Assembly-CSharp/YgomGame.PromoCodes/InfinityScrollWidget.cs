using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B75")]
public class InfinityScrollWidget : WidgetBase<InfinityScrollWidget.Source>, IWidgetContainer
{
	[Token(Token = "0x2000B76")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x2000B77")]
		public class TemplateInfo
		{
			[Token(Token = "0x4009705")]
			[FieldOffset(Offset = "0x10")]
			public string prefLinkerLabel;

			[Token(Token = "0x4009706")]
			[FieldOffset(Offset = "0x18")]
			public Type widgetType;

			[Token(Token = "0x600462F")]
			[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
			public TemplateInfo(string prefLinkerLabel, Type widgetType)
			{
			}
		}

		[Token(Token = "0x4009704")]
		[FieldOffset(Offset = "0x10")]
		public readonly IReadOnlyList<TemplateInfo> templateInfos;

		[Token(Token = "0x600462E")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public Source(IReadOnlyList<TemplateInfo> templateInfos)
		{
		}
	}

	[Token(Token = "0x2000B78")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4009707")]
		[FieldOffset(Offset = "0x10")]
		public InfinityScrollWidget _003C_003E4__this;

		[Token(Token = "0x4009708")]
		[FieldOffset(Offset = "0x18")]
		public bool scrollReady;

		[Token(Token = "0x6004630")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6004631")]
		[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
		internal void _003COnProgressInitialize_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000B7A")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400970B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400970C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400970D")]
		[FieldOffset(Offset = "0x20")]
		public InfinityScrollWidget _003C_003E4__this;

		[Token(Token = "0x400970E")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		[Token(Token = "0x400970F")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CreadyTemplates_003E5__2;

		[Token(Token = "0x4009710")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform[] _003Cwidgets_003E5__3;

		[Token(Token = "0x4009711")]
		[FieldOffset(Offset = "0x40")]
		private TMP_Text[] _003Ctexts_003E5__4;

		[Token(Token = "0x17000967")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004637")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000968")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004639")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004634")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004635")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004636")]
		[Address(RVA = "0x8F61C0", Offset = "0x8F53C0", VA = "0x1808F61C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004638")]
		[Address(RVA = "0x8F7120", Offset = "0x8F6320", VA = "0x1808F7120", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40096FA")]
	private const string k_Elabel_ScrollView = "ScrollView";

	[Token(Token = "0x40096FB")]
	[FieldOffset(Offset = "0x38")]
	private readonly GameObject m_TemplateRoot;

	[Token(Token = "0x40096FC")]
	[FieldOffset(Offset = "0x40")]
	private readonly InfinityScrollView m_ScrollView;

	[Token(Token = "0x40096FD")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> m_Templates;

	[Token(Token = "0x40096FE")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<GameObject, IWidget> m_WidgetMap;

	[Token(Token = "0x40096FF")]
	[FieldOffset(Offset = "0x58")]
	private int m_FreeSizeTextTemplateIdx;

	[Token(Token = "0x4009700")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, int> m_TemplateIdx_FreeSizeTextMap;

	[Token(Token = "0x4009701")]
	[FieldOffset(Offset = "0x68")]
	public Action<IWidget> onCreateWidget;

	[Token(Token = "0x4009702")]
	[FieldOffset(Offset = "0x70")]
	public Action<IWidget, int> onUpdateWidget;

	[Token(Token = "0x4009703")]
	[FieldOffset(Offset = "0x78")]
	public Func<int, bool> isSelectableDataIndexCallback;

	[Token(Token = "0x17000965")]
	public InfinityScrollView scrollView
	{
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000966")]
	public int freeSizeTextTemplateIdx
	{
		[Token(Token = "0x6004622")]
		[Address(RVA = "0x42D5A0", Offset = "0x42C7A0", VA = "0x18042D5A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004623")]
	[Address(RVA = "0x8E62D0", Offset = "0x8E54D0", VA = "0x1808E62D0", Slot = "16")]
	public IEnumerable<IWidget> GetChildWidgets()
	{
		return null;
	}

	[Token(Token = "0x6004624")]
	[Address(RVA = "0x42D670", Offset = "0x42C870", VA = "0x18042D670")]
	public void AssginFreeSizeTextTemplateIdx(int templateIdx)
	{
	}

	[Token(Token = "0x6004625")]
	[Address(RVA = "0x8E6260", Offset = "0x8E5460", VA = "0x1808E6260")]
	public void AssginFreeSizeText(string text)
	{
	}

	[Token(Token = "0x6004626")]
	[Address(RVA = "0x8E67B0", Offset = "0x8E59B0", VA = "0x1808E67B0")]
	public int TryGetFreeSizeTextTemplateIdx(string text)
	{
		return default(int);
	}

	[Token(Token = "0x6004627")]
	[Address(RVA = "0x8E6840", Offset = "0x8E5A40", VA = "0x1808E6840")]
	public InfinityScrollWidget(ElementObjectManager eom, GameObject templateRoot)
	{
	}

	[Token(Token = "0x6004628")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x6004629")]
	[Address(RVA = "0x8E66B0", Offset = "0x8E58B0", VA = "0x1808E66B0", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__21))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}

	[Token(Token = "0x600462A")]
	[Address(RVA = "0x8E6340", Offset = "0x8E5540", VA = "0x1808E6340")]
	private void OnCreatedEntity(GameObject entity)
	{
	}

	[Token(Token = "0x600462B")]
	[Address(RVA = "0x8E6720", Offset = "0x8E5920", VA = "0x1808E6720")]
	private void OnUpdateEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x600462C")]
	[Address(RVA = "0x8E6320", Offset = "0x8E5520", VA = "0x1808E6320")]
	private bool IsSelectableDataIndex(int dataIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600462D")]
	[Address(RVA = "0x8E6620", Offset = "0x8E5820", VA = "0x1808E6620")]
	private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
	{
		return null;
	}
}
