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
using YgomSystem.UI;

namespace YgomGame.Scenario;

[Token(Token = "0x2000ACE")]
public class ScenarioViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x2000AD1")]
	[CompilerGenerated]
	private sealed class _003CyPlayCloseFadeOut_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40093DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40093DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40093E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScenarioViewController _003C_003E4__this;

		[Token(Token = "0x170008DA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004291")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004293")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600428E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayCloseFadeOut_003Ed__54(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600428F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004290")]
		[Address(RVA = "0x8AA9B0", Offset = "0x8A9BB0", VA = "0x1808AA9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004292")]
		[Address(RVA = "0x8AADF0", Offset = "0x8A9FF0", VA = "0x1808AADF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40093BD")]
	public const string k_PrefabPath = "Scenario/Scenario";

	[Token(Token = "0x40093BE")]
	public const string k_ScenarioAssetPathFormat = "Scenarios/Gates/ScenarioAseets/{0}";

	[Token(Token = "0x40093BF")]
	public const string k_ELabelBackKey = "BackKeyShortcutButton";

	[Token(Token = "0x40093C0")]
	public const string k_ELabelLogBackKey = "LogScreen/LogBackKeyShortcutButton";

	[Token(Token = "0x40093C1")]
	public const string k_ELabelBlockerBackKey = "BlockerBackKeyShortcutButton";

	[Token(Token = "0x40093C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_TweenLabelPopSkip;

	[Token(Token = "0x40093C3")]
	public const string k_ArgKeyName = "name";

	[Token(Token = "0x40093C4")]
	private const string k_ArgKeyData = "data";

	[Token(Token = "0x40093C5")]
	public const string k_ArgKeyOnComplete = "oncomplete";

	[Token(Token = "0x40093C6")]
	private const string k_ArgKeyDemoMode = "demomode";

	[Token(Token = "0x40093C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private string m_ScenarioName;

	[Token(Token = "0x40093C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<object> m_ScenarioData;

	[Token(Token = "0x40093C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ScenarioWork m_Work;

	[Token(Token = "0x40093CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ScenarioLoadGroupContainer m_LoadGroupContainer;

	[Token(Token = "0x40093CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ScenarioObjectContainer m_ObjectContainer;

	[Token(Token = "0x40093CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ScenarioController m_ScenarioController;

	[Token(Token = "0x40093CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string m_BeforeBgm;

	[Token(Token = "0x40093CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int m_TransitionStep;

	[Token(Token = "0x40093CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private bool m_IsUnlockedInput;

	[Token(Token = "0x40093D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float m_CowntdownAutoHideSec;

	[Token(Token = "0x40093D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private bool m_ClickedInputBlocker;

	[Token(Token = "0x40093D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	private bool m_DemoSkipEnable;

	[Token(Token = "0x40093D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
	private bool m_DemoSkipRequest;

	[Token(Token = "0x40093D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
	private bool m_IsSkipped;

	[Token(Token = "0x40093D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool m_Ready;

	[Token(Token = "0x40093D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	private bool m_IsReleased;

	[Token(Token = "0x40093D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Coroutine m_yCloseFadeOut;

	[Token(Token = "0x40093D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool m_ClickedBlockInputFlame;

	[Token(Token = "0x40093D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	private bool m_ToFullScreenFrame;

	[Token(Token = "0x170008D7")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x6004254")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008D8")]
	public string scenarioName
	{
		[Token(Token = "0x6004255")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D9")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6004256")]
		[Address(RVA = "0x8A72A0", Offset = "0x8A64A0", VA = "0x1808A72A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004257")]
	[Address(RVA = "0x8A55A0", Offset = "0x8A47A0", VA = "0x1808A55A0")]
	public static void Open(string scenarioName, [Optional] Action<bool> onCompleteCallback)
	{
	}

	[Token(Token = "0x6004258")]
	[Address(RVA = "0x8A5390", Offset = "0x8A4590", VA = "0x1808A5390")]
	public static void OpenDemo(string scenarioName, [Optional] Action<bool> onCompleteCallback)
	{
	}

	[Token(Token = "0x6004259")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x600425A")]
	[Address(RVA = "0x8A28D0", Offset = "0x8A1AD0", VA = "0x1808A28D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600425B")]
	[Address(RVA = "0x8A5760", Offset = "0x8A4960", VA = "0x1808A5760", Slot = "9")]
	public override float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x600425C")]
	[Address(RVA = "0x8A4650", Offset = "0x8A3850", VA = "0x1808A4650")]
	private bool OnLoadCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600425D")]
	[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
	public ElementObjectManager GetViewEom()
	{
		return null;
	}

	[Token(Token = "0x600425E")]
	[Address(RVA = "0x8A5D60", Offset = "0x8A4F60", VA = "0x1808A5D60", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600425F")]
	[Address(RVA = "0x8A5D70", Offset = "0x8A4F70", VA = "0x1808A5D70", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6004260")]
	[Address(RVA = "0x8A67D0", Offset = "0x8A59D0", VA = "0x1808A67D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6004261")]
	[Address(RVA = "0x8A2CB0", Offset = "0x8A1EB0", VA = "0x1808A2CB0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004262")]
	[Address(RVA = "0x8A5870", Offset = "0x8A4A70", VA = "0x1808A5870")]
	private void Release()
	{
	}

	[Token(Token = "0x6004263")]
	[Address(RVA = "0x8A44D0", Offset = "0x8A36D0", VA = "0x1808A44D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004264")]
	[Address(RVA = "0x8A5D10", Offset = "0x8A4F10", VA = "0x1808A5D10")]
	public void Suspend()
	{
	}

	[Token(Token = "0x6004265")]
	[Address(RVA = "0x8A5940", Offset = "0x8A4B40", VA = "0x1808A5940")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004266")]
	[Address(RVA = "0x8A3380", Offset = "0x8A2580", VA = "0x1808A3380")]
	private void UpdateAutoHideCount()
	{
	}

	[Token(Token = "0x6004267")]
	[Address(RVA = "0x8A2730", Offset = "0x8A1930", VA = "0x1808A2730")]
	public void HideUI()
	{
	}

	[Token(Token = "0x6004268")]
	[Address(RVA = "0x8A5990", Offset = "0x8A4B90", VA = "0x1808A5990")]
	public void ShowUI()
	{
	}

	[Token(Token = "0x6004269")]
	[Address(RVA = "0x8A54F0", Offset = "0x8A46F0", VA = "0x1808A54F0")]
	public void OpenLog()
	{
	}

	[Token(Token = "0x600426A")]
	[Address(RVA = "0x8A2690", Offset = "0x8A1890", VA = "0x1808A2690")]
	public void CloseLog()
	{
	}

	[Token(Token = "0x600426B")]
	[Address(RVA = "0x8A56C0", Offset = "0x8A48C0", VA = "0x1808A56C0")]
	private void PlayCloseFadeOut()
	{
	}

	[Token(Token = "0x600426C")]
	[Address(RVA = "0x8A7370", Offset = "0x8A6570", VA = "0x1808A7370")]
	[IteratorStateMachine(typeof(_003CyPlayCloseFadeOut_003Ed__54))]
	private IEnumerator yPlayCloseFadeOut()
	{
		return null;
	}

	[Token(Token = "0x600426D")]
	[Address(RVA = "0x8A5B30", Offset = "0x8A4D30", VA = "0x1808A5B30")]
	private void StopSoundLabels(List<string> soundLabels, bool isSe, float fade = -1f)
	{
	}

	[Token(Token = "0x600426E")]
	[Address(RVA = "0x8A3060", Offset = "0x8A2260", VA = "0x1808A3060")]
	private void OnChangedAutoActive(bool isAuto)
	{
	}

	[Token(Token = "0x600426F")]
	[Address(RVA = "0x8A4350", Offset = "0x8A3550", VA = "0x1808A4350")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6004270")]
	[Address(RVA = "0x8A31E0", Offset = "0x8A23E0", VA = "0x1808A31E0")]
	private void OnClickInputBlocker()
	{
	}

	[Token(Token = "0x6004271")]
	[Address(RVA = "0x8A33F0", Offset = "0x8A25F0", VA = "0x1808A33F0")]
	private void OnClickMenuButton(ScenarioMenuContainer.ButtonType buttonType)
	{
	}

	[Token(Token = "0x6004272")]
	[Address(RVA = "0x8A3380", Offset = "0x8A2580", VA = "0x1808A3380")]
	private void OnClickMenuAnyButton()
	{
	}

	[Token(Token = "0x6004273")]
	[Address(RVA = "0x8A3070", Offset = "0x8A2270", VA = "0x1808A3070")]
	private void OnClickAuto()
	{
	}

	[Token(Token = "0x6004274")]
	[Address(RVA = "0x8A32A0", Offset = "0x8A24A0", VA = "0x1808A32A0")]
	private void OnClickLog()
	{
	}

	[Token(Token = "0x6004275")]
	[Address(RVA = "0x8A3710", Offset = "0x8A2910", VA = "0x1808A3710")]
	private void OnClickSkip()
	{
	}

	[Token(Token = "0x6004276")]
	[Address(RVA = "0x8A3930", Offset = "0x8A2B30", VA = "0x1808A3930")]
	private void OnClickSubtitle()
	{
	}

	[Token(Token = "0x6004277")]
	[Address(RVA = "0x8A3560", Offset = "0x8A2760", VA = "0x1808A3560")]
	private void OnClickMovieSubtitle()
	{
	}

	[Token(Token = "0x6004278")]
	[Address(RVA = "0x8A3B10", Offset = "0x8A2D10", VA = "0x1808A3B10")]
	private void OnClickView()
	{
	}

	[Token(Token = "0x6004279")]
	[Address(RVA = "0x8A3290", Offset = "0x8A2490", VA = "0x1808A3290")]
	private void OnClickLogClose()
	{
	}

	[Token(Token = "0x600427A")]
	[Address(RVA = "0x8A3D50", Offset = "0x8A2F50", VA = "0x1808A3D50")]
	private void OnClickVolumeButton(ScenarioSettingsWrapper.SoundSettingType[] soundSettingTypes)
	{
	}

	[Token(Token = "0x600427B")]
	[Address(RVA = "0x8A2E50", Offset = "0x8A2050", VA = "0x1808A2E50", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600427C")]
	[Address(RVA = "0x8A71F0", Offset = "0x8A63F0", VA = "0x1808A71F0")]
	public ScenarioViewController()
	{
	}
}
