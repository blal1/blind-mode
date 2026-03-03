using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu;

[Token(Token = "0x200123A")]
public class LoginBonusViewController : BaseMenuViewController
{
	[Token(Token = "0x200123B")]
	public enum Mode
	{
		[Token(Token = "0x400BAB6")]
		View,
		[Token(Token = "0x400BAB7")]
		Obtain
	}

	[Token(Token = "0x200123F")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		[Token(Token = "0x400BABD")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x400BABE")]
		[FieldOffset(Offset = "0x18")]
		public Action _003C_003E9__0;

		[Token(Token = "0x600719B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		[Token(Token = "0x600719C")]
		[Address(RVA = "0xB7F3E0", Offset = "0xB7E5E0", VA = "0x180B7F3E0")]
		internal void _003CObtainRewards_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2001240")]
	[CompilerGenerated]
	private sealed class _003CObtainRewards_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BABF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BAC0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BAC1")]
		[FieldOffset(Offset = "0x20")]
		public LoginBonusViewController _003C_003E4__this;

		[Token(Token = "0x400BAC2")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		[Token(Token = "0x400BAC3")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CisPresentSent_003E5__2;

		[Token(Token = "0x400BAC4")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, EntryItemListData> _003CitemListDic_003E5__3;

		[Token(Token = "0x400BAC5")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, List<object>> _003CshopInfoListDic_003E5__4;

		[Token(Token = "0x170011E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60071A0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60071A2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600719D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CObtainRewards_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600719E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600719F")]
		[Address(RVA = "0xB7DD50", Offset = "0xB7CF50", VA = "0x180B7DD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60071A1")]
		[Address(RVA = "0xB7E500", Offset = "0xB7D700", VA = "0x180B7E500", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001241")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BAC6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BAC7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BAC8")]
		[FieldOffset(Offset = "0x20")]
		public LoginBonusViewController _003C_003E4__this;

		[Token(Token = "0x170011E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60071A6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60071A8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60071A3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60071A4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60071A5")]
		[Address(RVA = "0xB7E540", Offset = "0xB7D740", VA = "0x180B7E540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60071A7")]
		[Address(RVA = "0xB7E740", Offset = "0xB7D940", VA = "0x180B7E740", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BAA1")]
	private const string VC_PATH = "LoginBonus/LoginBonus";

	[Token(Token = "0x400BAA2")]
	private const string GENERAL_MAP_PREFAB_PATH = "Prefabs/LoginBonus/Maps/Common/LBMap_Common";

	[Token(Token = "0x400BAA3")]
	private const string k_ArgKeyMode = "mode";

	[Token(Token = "0x400BAA4")]
	internal const string k_ArgKeyLaunchId = "id";

	[Token(Token = "0x400BAA5")]
	internal const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400BAA6")]
	private const string k_ELabelMapLocator = "MapLocator";

	[Token(Token = "0x400BAA7")]
	private const string k_ELabelOKButton = "OKButton";

	[Token(Token = "0x400BAA8")]
	public const string MAP_DATA_PATH = "Prefabs/LoginBonus/Maps/LoginBonusMapData";

	[Token(Token = "0x400BAA9")]
	private const string MAP_DATA_LABEL_DEFAULT1 = "default1";

	[Token(Token = "0x400BAAA")]
	private const string MAP_DATA_LABEL_DEFAULT2 = "default2";

	[Token(Token = "0x400BAAB")]
	[FieldOffset(Offset = "0xD0")]
	private Mode m_Mode;

	[Token(Token = "0x400BAAC")]
	[FieldOffset(Offset = "0xD4")]
	private int m_LaunchId;

	[Token(Token = "0x400BAAD")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_EnabledSkipSectionMainte;

	[Token(Token = "0x400BAAE")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_MapPref;

	[Token(Token = "0x400BAAF")]
	[FieldOffset(Offset = "0xE8")]
	private LoginBonusMapWidet m_MapWidget;

	[Token(Token = "0x400BAB0")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<string, object> m_SourceData;

	[Token(Token = "0x400BAB1")]
	[FieldOffset(Offset = "0xF8")]
	private readonly LoginBonusButton[] _buttons;

	[Token(Token = "0x400BAB2")]
	[FieldOffset(Offset = "0x100")]
	private Action m_Callback;

	[Token(Token = "0x400BAB3")]
	[FieldOffset(Offset = "0x108")]
	private AssetLinkContainer _mapAssetInfo;

	[Token(Token = "0x170011E1")]
	public bool initialized
	{
		[Token(Token = "0x600717F")]
		[Address(RVA = "0x8AF070", Offset = "0x8AE270", VA = "0x1808AF070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600717E")]
		[Address(RVA = "0x8AF090", Offset = "0x8AE290", VA = "0x1808AF090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011E2")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007180")]
		[Address(RVA = "0xB7BCB0", Offset = "0xB7AEB0", VA = "0x180B7BCB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600717D")]
	[Address(RVA = "0xB7A820", Offset = "0xB79A20", VA = "0x180B7A820")]
	public static bool IsIDDefaultLabel(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6007181")]
	[Address(RVA = "0xB7B1B0", Offset = "0xB7A3B0", VA = "0x180B7B1B0")]
	public static void Open(ViewControllerManager manager, Mode mode, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007182")]
	[Address(RVA = "0xB7B4F0", Offset = "0xB7A6F0", VA = "0x180B7B4F0")]
	private static void RequestServer(Mode mode, int loginBonusID, Action<Handle, LoginBonusCode> onEnd)
	{
	}

	[Token(Token = "0x6007183")]
	[Address(RVA = "0xB7ABD0", Offset = "0xB79DD0", VA = "0x180B7ABD0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007184")]
	[Address(RVA = "0xB7AE70", Offset = "0xB7A070", VA = "0x180B7AE70", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007185")]
	[Address(RVA = "0xB7B030", Offset = "0xB7A230", VA = "0x180B7B030", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007186")]
	[Address(RVA = "0xB7B940", Offset = "0xB7AB40", VA = "0x180B7B940", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6007187")]
	[Address(RVA = "0xB7B850", Offset = "0xB7AA50", VA = "0x180B7B850")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6007188")]
	[Address(RVA = "0xB7B410", Offset = "0xB7A610", VA = "0x180B7B410")]
	private void Ready()
	{
	}

	[Token(Token = "0x6007189")]
	[Address(RVA = "0xB7AFC0", Offset = "0xB7A1C0", VA = "0x180B7AFC0")]
	[IteratorStateMachine(typeof(_003CObtainRewards_003Ed__35))]
	private IEnumerator ObtainRewards()
	{
		return null;
	}

	[Token(Token = "0x600718A")]
	[Address(RVA = "0xB7B900", Offset = "0xB7AB00", VA = "0x180B7B900")]
	private void ToEnableSkipSectionMainte()
	{
	}

	[Token(Token = "0x600718B")]
	[Address(RVA = "0xB7B8C0", Offset = "0xB7AAC0", VA = "0x180B7B8C0")]
	private void ToDisableSkipSectionMainte()
	{
	}

	[Token(Token = "0x600718C")]
	[Address(RVA = "0xB7A890", Offset = "0xB79A90", VA = "0x180B7A890")]
	private void LoadDataAsync()
	{
	}

	[Token(Token = "0x600718D")]
	[Address(RVA = "0xB7A6B0", Offset = "0xB798B0", VA = "0x180B7A6B0")]
	private void CreateMapWidget()
	{
	}

	[Token(Token = "0x600718E")]
	[Address(RVA = "0xB7B600", Offset = "0xB7A800", VA = "0x180B7B600")]
	private void SetupButtons()
	{
	}

	[Token(Token = "0x600718F")]
	[Address(RVA = "0xB7BC50", Offset = "0xB7AE50", VA = "0x180B7BC50")]
	public LoginBonusViewController()
	{
	}
}
