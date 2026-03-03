using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomGame.Notification;
using YgomGame.Solo;
using YgomSystem.UI;

namespace YgomSystem.Home;

[Token(Token = "0x2000380")]
[RequireComponent(typeof(RawImage))]
public class BindingTopicsCardUV : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2000381")]
	private enum SettingType
	{
		[Token(Token = "0x4001205")]
		NORMAL,
		[Token(Token = "0x4001206")]
		SOLO
	}

	[Token(Token = "0x2000386")]
	[CompilerGenerated]
	private sealed class _003CyDelayFrame_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int waitFrame;

		[Token(Token = "0x4001215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x4001216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000233")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60015B1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000234")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyDelayFrame_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x533700", Offset = "0x532900", VA = "0x180533700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x533770", Offset = "0x532970", VA = "0x180533770", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40011F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string settingPath;

	[Token(Token = "0x40011FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int mrk;

	[Token(Token = "0x40011FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string settingId;

	[Token(Token = "0x40011FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Tooltip("trueだとペンデュラムかそうでないかをチェックしてRawImageの比率を自動で調整します")]
	private bool fitScalePendulum;

	[Token(Token = "0x40011FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Tooltip("ソロモードの設定を使用する場合はtrueにします")]
	private SettingType settingType;

	[Token(Token = "0x40011FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector4 uvVector4;

	[Token(Token = "0x40011FF")]
	public const SoloCardThumbSettings.Format TARGET_SOLO_FORMAT = SoloCardThumbSettings.Format.Gate;

	[Token(Token = "0x4001200")]
	public const string TOPICS_CARDUV_SOLO_PATH = "Prefabs/Notification/ScriptableObject/TopicsCardUVSetting_Next3";

	[Token(Token = "0x4001201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool loadStart;

	[Token(Token = "0x4001202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool isLoadedSolo;

	[Token(Token = "0x17000232")]
	public bool visible
	{
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000015")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x5210F0", Offset = "0x5202F0", VA = "0x1805210F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x5211C0", Offset = "0x5203C0", VA = "0x1805211C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600159A")]
	[Address(RVA = "0x520CD0", Offset = "0x51FED0", VA = "0x180520CD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600159B")]
	[Address(RVA = "0x520F30", Offset = "0x520130", VA = "0x180520F30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600159C")]
	[Address(RVA = "0x521030", Offset = "0x520230", VA = "0x180521030")]
	private void Start()
	{
	}

	[Token(Token = "0x600159D")]
	[Address(RVA = "0x520EE0", Offset = "0x5200E0", VA = "0x180520EE0", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600159E")]
	[Address(RVA = "0x520FB0", Offset = "0x5201B0", VA = "0x180520FB0", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x600159F")]
	[Address(RVA = "0x520D60", Offset = "0x51FF60", VA = "0x180520D60")]
	[ContextMenu("Binding実行")]
	public void ExecuteBinding()
	{
	}

	[Token(Token = "0x60015A0")]
	[Address(RVA = "0x5207C0", Offset = "0x51F9C0", VA = "0x1805207C0")]
	private void ApplySetting([Optional] TopicsCardUVSetting setting)
	{
	}

	[Token(Token = "0x60015A1")]
	[Address(RVA = "0x520400", Offset = "0x51F600", VA = "0x180520400")]
	private void ApplySettingSolo()
	{
	}

	[Token(Token = "0x60015A2")]
	[Address(RVA = "0x520D80", Offset = "0x51FF80", VA = "0x180520D80")]
	private void FitScalePendulum(RawImage rawImage, int mrk)
	{
	}

	[Token(Token = "0x60015A3")]
	[Address(RVA = "0x521260", Offset = "0x520460", VA = "0x180521260")]
	[IteratorStateMachine(typeof(_003CyDelayFrame_003Ed__25))]
	private IEnumerator yDelayFrame(int waitFrame = 1, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x521060", Offset = "0x520260", VA = "0x180521060")]
	public BindingTopicsCardUV()
	{
	}
}
