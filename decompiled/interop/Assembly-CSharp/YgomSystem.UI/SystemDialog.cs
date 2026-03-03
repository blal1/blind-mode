using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI;

[Token(Token = "0x2000435")]
public class SystemDialog : MonoBehaviour
{
	[Token(Token = "0x200043A")]
	[CompilerGenerated]
	private sealed class _003CwaitLocalizedFontsLoad_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40014B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40014B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40014B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SystemDialog _003C_003E4__this;

		[Token(Token = "0x40014B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x1700027B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B18")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitLocalizedFontsLoad_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x5F4BA0", Offset = "0x5F3DA0", VA = "0x1805F4BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x5F4CD0", Offset = "0x5F3ED0", VA = "0x1805F4CD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001498")]
	public const string k_ArgKeyTitle = "title";

	[Token(Token = "0x4001499")]
	public const string k_ArgKeyUpperMessage = "upperMessage";

	[Token(Token = "0x400149A")]
	public const string k_ArgKeyLowerMessage = "lowerMessage";

	[Token(Token = "0x400149B")]
	public const string k_ArgKeyLowerMessageScrollHeight = "lowerMessageScrollHeight";

	[Token(Token = "0x400149C")]
	public const string k_ArgKeyTime = "time";

	[Token(Token = "0x400149D")]
	public const string k_ArgKeyImagePath = "imagePath";

	[Token(Token = "0x400149E")]
	public const string k_ArgKeyImageScale = "imageScale";

	[Token(Token = "0x400149F")]
	public const string k_ArgKeyImageVisible = "imageVisible";

	[Token(Token = "0x40014A0")]
	public const string k_ArgKeyButtonLabel = "buttonLabel";

	[Token(Token = "0x40014A1")]
	public const string k_ArgKeyAction = "action";

	[Token(Token = "0x40014A2")]
	public const string k_ArgKeyButtonLabel2 = "buttonLabel2";

	[Token(Token = "0x40014A3")]
	public const string k_ArgKeyAction2 = "action2";

	[Token(Token = "0x40014A4")]
	public const string k_ArgKeyRebootButtonVisible = "rebootVisible";

	[Token(Token = "0x40014A5")]
	public const string k_ArgKeyWindowWidth = "windowWidth";

	[Token(Token = "0x40014A6")]
	public const string k_ArgKeyOpenSe = "opense";

	[Token(Token = "0x40014A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string k_MaintenanceBannerPath;

	[Token(Token = "0x40014A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ElementObjectManager m_SystemDialogPref;

	[Token(Token = "0x40014A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CommonDialogContentContainerWidget m_SystemDialogWidget;

	[Token(Token = "0x40014AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private IEnumerator m_FontLoadCoroutine;

	[Token(Token = "0x40014AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action m_ActionCallback1;

	[Token(Token = "0x40014AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action m_ActionCallback2;

	[Token(Token = "0x17000279")]
	public bool isExistsDialog
	{
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x5EFA70", Offset = "0x5EEC70", VA = "0x1805EFA70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027A")]
	private int defaultMinHeight
	{
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x5EFA10", Offset = "0x5EEC10", VA = "0x1805EFA10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x5ED420", Offset = "0x5EC620", VA = "0x1805ED420")]
	public bool OpenFatalErrorDialog(string message, [Optional] string label1, [Optional] Action action1, [Optional] string label2, [Optional] Action action2, [Optional] Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x5ECFF0", Offset = "0x5EC1F0", VA = "0x1805ECFF0")]
	public Dictionary<string, object> GetMaintenanceDialogArgs()
	{
		return null;
	}

	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x5EE0D0", Offset = "0x5ED2D0", VA = "0x1805EE0D0")]
	public void OpenOperationMainteDialog([Optional] Dictionary<string, object> defaultArgs, [Optional] Dictionary<string, object> overrideArgs)
	{
	}

	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x5ED920", Offset = "0x5ECB20", VA = "0x1805ED920")]
	public bool OpenMaintenanceDialog(Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x5EF730", Offset = "0x5EE930", VA = "0x1805EF730")]
	private bool OpenSystemDialog(List<IEntryData> entryDatas, [Optional] Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x5EFAC0", Offset = "0x5EECC0", VA = "0x1805EFAC0")]
	[IteratorStateMachine(typeof(_003CwaitLocalizedFontsLoad_003Ed__30))]
	private IEnumerator waitLocalizedFontsLoad(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6001B03")]
	[Address(RVA = "0x5EF3D0", Offset = "0x5EE5D0", VA = "0x1805EF3D0")]
	private void OpenSystemDialogCore(List<IEntryData> entryDatas, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6001B04")]
	[Address(RVA = "0x5ECED0", Offset = "0x5EC0D0", VA = "0x1805ECED0")]
	private void CloseSystemDialog()
	{
	}

	[Token(Token = "0x6001B05")]
	[Address(RVA = "0x5ECDA0", Offset = "0x5EBFA0", VA = "0x1805ECDA0")]
	private void ClearCallbacks()
	{
	}

	[Token(Token = "0x6001B06")]
	[Address(RVA = "0x5ECDE0", Offset = "0x5EBFE0", VA = "0x1805ECDE0")]
	public void ClearOnReboot()
	{
	}

	[Token(Token = "0x6001B07")]
	[Address(RVA = "0x5ED3D0", Offset = "0x5EC5D0", VA = "0x1805ED3D0")]
	private void OnClickReboot()
	{
	}

	[Token(Token = "0x6001B08")]
	[Address(RVA = "0x5ED310", Offset = "0x5EC510", VA = "0x1805ED310")]
	private void OnClickAction1()
	{
	}

	[Token(Token = "0x6001B09")]
	[Address(RVA = "0x5ED370", Offset = "0x5EC570", VA = "0x1805ED370")]
	private void OnClickAction2()
	{
	}

	[Token(Token = "0x6001B0A")]
	[Address(RVA = "0x5EF9C0", Offset = "0x5EEBC0", VA = "0x1805EF9C0")]
	public SystemDialog()
	{
	}
}
