using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DF5")]
public class EnqueteViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x2000DF6")]
	private enum Mode
	{
		[Token(Token = "0x400A16A")]
		Input,
		[Token(Token = "0x400A16B")]
		FreeWordConfirm,
		[Token(Token = "0x400A16C")]
		Decided
	}

	[Token(Token = "0x2000DFC")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x400A184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EnqueteViewController _003C_003E4__this;

		[Token(Token = "0x400A185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int localLoadingCnt;

		[Token(Token = "0x6005450")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6005451")]
		[Address(RVA = "0x9B0200", Offset = "0x9AF400", VA = "0x1809B0200")]
		internal void _003CyInitialize_003Eb__1(UnityEngine.Object jsonAsset)
		{
		}

		[Token(Token = "0x6005452")]
		[Address(RVA = "0x9B01D0", Offset = "0x9AF3D0", VA = "0x1809B01D0")]
		internal void _003CyInitialize_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000DFD")]
	[CompilerGenerated]
	private sealed class _003CConfirmInputValues_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnqueteViewController _003C_003E4__this;

		[Token(Token = "0x400A189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> onComplete;

		[Token(Token = "0x400A18A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003CasyncCnt_003E5__2;

		[Token(Token = "0x17000C64")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005456")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C65")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005458")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005453")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CConfirmInputValues_003Ed__48(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005454")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005455")]
		[Address(RVA = "0x9ABCA0", Offset = "0x9AAEA0", VA = "0x1809ABCA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005457")]
		[Address(RVA = "0x9ACDD0", Offset = "0x9ABFD0", VA = "0x1809ACDD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000DFE")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A18B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A18C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A18D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnqueteViewController _003C_003E4__this;

		[Token(Token = "0x400A18E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		[Token(Token = "0x17000C66")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600545C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C67")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600545E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005459")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600545A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600545B")]
		[Address(RVA = "0x9B2310", Offset = "0x9B1510", VA = "0x1809B2310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600545D")]
		[Address(RVA = "0x9B3410", Offset = "0x9B2610", VA = "0x1809B3410", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000DFF")]
	[CompilerGenerated]
	private sealed class _003CyUpdatePage_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A18F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int page;

		[Token(Token = "0x400A192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnqueteViewController _003C_003E4__this;

		[Token(Token = "0x400A193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool forceUpdate;

		[Token(Token = "0x400A194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SheetWidget _003CsheetWidget_003E5__2;

		[Token(Token = "0x17000C68")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005462")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C69")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005464")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600545F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyUpdatePage_003Ed__46(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005460")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005461")]
		[Address(RVA = "0x9B3450", Offset = "0x9B2650", VA = "0x1809B3450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005463")]
		[Address(RVA = "0x9B3CA0", Offset = "0x9B2EA0", VA = "0x1809B3CA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A14D")]
	public const string k_BoardImageSPath = "Images/Enquete/EnqueteBoard_S";

	[Token(Token = "0x400A14E")]
	public const string k_BoardImageMPath = "Images/Enquete/EnqueteBoard_M";

	[Token(Token = "0x400A14F")]
	private const string k_ArgKeySourceJsonLinkerLabel = "sourceJsonLabel";

	[Token(Token = "0x400A150")]
	private const string k_ArgKeySourceJson = "sourceJson";

	[Token(Token = "0x400A151")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400A152")]
	private const string k_ArgKeyCloseOnFinish = "closeOnFinish";

	[Token(Token = "0x400A153")]
	private const string k_ArgKeyDispHeader = "dispHeader";

	[Token(Token = "0x400A154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Selector m_FooterSelector;

	[Token(Token = "0x400A155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private RootContext m_RootContext;

	[Token(Token = "0x400A156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<string> m_LoadTextGroups;

	[Token(Token = "0x400A157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private RectTransform m_SheetTemplate;

	[Token(Token = "0x400A158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SheetWidgetFactory m_SheetWidgetFactory;

	[Token(Token = "0x400A159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int m_PageLength;

	[Token(Token = "0x400A15A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int m_CurrentPage;

	[Token(Token = "0x400A15B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ExtendedScrollRect m_ScrollRect;

	[Token(Token = "0x400A15C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private TMP_Text m_PageText;

	[Token(Token = "0x400A15D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private SelectionButton m_BackPageButton;

	[Token(Token = "0x400A15E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private SelectionButton m_NextPageButton;

	[Token(Token = "0x400A15F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton m_BackEditButton;

	[Token(Token = "0x400A160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SelectionButton m_DecideButton;

	[Token(Token = "0x400A161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SheetWidget[] m_SheetWidgets;

	[Token(Token = "0x400A162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private SheetWidget m_FreeWordConfirmSheetWidget;

	[Token(Token = "0x400A163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Coroutine m_ConfirmInputValuesRoutine;

	[Token(Token = "0x400A164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Dictionary<string, object> m_InputValues;

	[Token(Token = "0x400A165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<string> m_ReplacedInputKeys;

	[Token(Token = "0x400A166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Mode m_Mode;

	[Token(Token = "0x400A167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject m_BackKeyShortcut;

	[Token(Token = "0x400A168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Selector m_ScrollSelector;

	[Token(Token = "0x17000C61")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6005421")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000C62")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6005422")]
		[Address(RVA = "0x9A3DE0", Offset = "0x9A2FE0", VA = "0x1809A3DE0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C63")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x6005424")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005423")]
	[Address(RVA = "0x9A25A0", Offset = "0x9A17A0", VA = "0x1809A25A0", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6005425")]
	[Address(RVA = "0x9A3050", Offset = "0x9A2250", VA = "0x1809A3050")]
	public static void OpenEnquete(int enqueteId, [Optional] Action<Dictionary<string, object>> callback, bool openThanksOnFinish = true, bool closeOnFinish = true, [Optional] Action onLaunchCallback, bool openOnHome = false)
	{
	}

	[Token(Token = "0x6005426")]
	[Address(RVA = "0x9A22E0", Offset = "0x9A14E0", VA = "0x1809A22E0")]
	private static void InnerOpenEnquete(int enqueteId, [Optional] Action<Dictionary<string, object>> callback, bool openThanksOnFinish = true, bool closeOnFinish = true, [Optional] Action onLaunchCallback, bool openOnHome = false)
	{
	}

	[Token(Token = "0x6005427")]
	[Address(RVA = "0x9A38D0", Offset = "0x9A2AD0", VA = "0x1809A38D0")]
	public static void PushFirstEnquete(ViewControllerManager manager, Action<Dictionary<string, object>> callback, bool closeOnFinish = true)
	{
	}

	[Token(Token = "0x6005428")]
	[Address(RVA = "0x9A3170", Offset = "0x9A2370", VA = "0x1809A3170")]
	private static void ProgressResultSequence(Dictionary<string, object> result, [Optional] Action<Dictionary<string, object>> callback, bool openReward = true, bool openThanksOnFinish = true, bool closeOnFinish = true)
	{
	}

	[Token(Token = "0x6005429")]
	[Address(RVA = "0x9A2DA0", Offset = "0x9A1FA0", VA = "0x1809A2DA0")]
	private static void OnFailedAnswers(Dictionary<string, object> result, [Optional] Action<Dictionary<string, object>> callback, bool closeOnFinish = true)
	{
	}

	[Token(Token = "0x600542A")]
	[Address(RVA = "0x9A2670", Offset = "0x9A1870", VA = "0x1809A2670", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600542B")]
	[Address(RVA = "0x9A3EB0", Offset = "0x9A30B0", VA = "0x1809A3EB0")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__41))]
	private IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x600542C")]
	[Address(RVA = "0x9A2120", Offset = "0x9A1320", VA = "0x1809A2120")]
	private void ImportJsonStr(string jsonStr)
	{
	}

	[Token(Token = "0x600542D")]
	[Address(RVA = "0x9A26F0", Offset = "0x9A18F0", VA = "0x1809A26F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600542E")]
	[Address(RVA = "0x9A3CB0", Offset = "0x9A2EB0", VA = "0x1809A3CB0")]
	private void UpdatePage(int page, bool forceUpdate = false, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x600542F")]
	[Address(RVA = "0x9A3F20", Offset = "0x9A3120", VA = "0x1809A3F20")]
	[IteratorStateMachine(typeof(_003CyUpdatePage_003Ed__46))]
	private IEnumerator yUpdatePage(int page, bool forceUpdate = false)
	{
		return null;
	}

	[Token(Token = "0x6005430")]
	[Address(RVA = "0x9A3BE0", Offset = "0x9A2DE0", VA = "0x1809A3BE0")]
	private void UpdateNextButton()
	{
	}

	[Token(Token = "0x6005431")]
	[Address(RVA = "0x9A2090", Offset = "0x9A1290", VA = "0x1809A2090")]
	[IteratorStateMachine(typeof(_003CConfirmInputValues_003Ed__48))]
	private IEnumerator ConfirmInputValues(Action<bool> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6005432")]
	[Address(RVA = "0x9A1F40", Offset = "0x9A1140", VA = "0x1809A1F40")]
	private void ApplyViewMode()
	{
	}

	[Token(Token = "0x6005433")]
	[Address(RVA = "0x9A3A60", Offset = "0x9A2C60", VA = "0x1809A3A60")]
	private void ToDecide()
	{
	}

	[Token(Token = "0x6005434")]
	[Address(RVA = "0x9A2FB0", Offset = "0x9A21B0", VA = "0x1809A2FB0")]
	private void OnInputUp()
	{
	}

	[Token(Token = "0x6005435")]
	[Address(RVA = "0x9A2E30", Offset = "0x9A2030", VA = "0x1809A2E30")]
	private void OnInputDown()
	{
	}

	[Token(Token = "0x6005436")]
	[Address(RVA = "0x9A2ED0", Offset = "0x9A20D0", VA = "0x1809A2ED0")]
	private void OnInputLeft()
	{
	}

	[Token(Token = "0x6005437")]
	[Address(RVA = "0x9A2F40", Offset = "0x9A2140", VA = "0x1809A2F40")]
	private void OnInputRight()
	{
	}

	[Token(Token = "0x6005438")]
	[Address(RVA = "0x9A2BA0", Offset = "0x9A1DA0", VA = "0x1809A2BA0")]
	private void OnClickBackPage()
	{
	}

	[Token(Token = "0x6005439")]
	[Address(RVA = "0x9A2D70", Offset = "0x9A1F70", VA = "0x1809A2D70")]
	private void OnClickNextPage()
	{
	}

	[Token(Token = "0x600543A")]
	[Address(RVA = "0x9A2AD0", Offset = "0x9A1CD0", VA = "0x1809A2AD0")]
	private void OnClickBackEdit()
	{
	}

	[Token(Token = "0x600543B")]
	[Address(RVA = "0x9A2BD0", Offset = "0x9A1DD0", VA = "0x1809A2BD0")]
	private void OnClickDecide()
	{
	}

	[Token(Token = "0x600543C")]
	[Address(RVA = "0x9A28A0", Offset = "0x9A1AA0", VA = "0x1809A28A0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600543D")]
	[Address(RVA = "0x9A3CD0", Offset = "0x9A2ED0", VA = "0x1809A3CD0")]
	public EnqueteViewController()
	{
	}
}
