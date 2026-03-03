using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomGame.DuelPreview.Controller;
using YgomGame.DuelPreview.Data;

namespace YgomGame.DuelPreview;

[Token(Token = "0x2000E2D")]
public class DuelPreviewPlayer
{
	[Token(Token = "0x2000E2E")]
	public class Option
	{
		[Token(Token = "0x400A283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool hideOnInitialize;

		[Token(Token = "0x400A284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool mute;

		[Token(Token = "0x6005606")]
		[Address(RVA = "0x9BCBE0", Offset = "0x9BBDE0", VA = "0x1809BCBE0")]
		public Option()
		{
		}
	}

	[Token(Token = "0x2000E30")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass82_0
	{
		[Token(Token = "0x400A287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DuelPreviewPlayer _003C_003E4__this;

		[Token(Token = "0x400A288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RawImage rawImage;

		[Token(Token = "0x400A289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onReady;

		[Token(Token = "0x6005609")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass82_0()
		{
		}

		[Token(Token = "0x600560A")]
		[Address(RVA = "0x9C76D0", Offset = "0x9C68D0", VA = "0x1809C76D0")]
		internal void _003CyPlaySequence_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000E32")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A28B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A28C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A28D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelPreviewPlayer _003C_003E4__this;

		[Token(Token = "0x400A28E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x400A28F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<IEnumerator> _003CinitRoutines_003E5__2;

		[Token(Token = "0x400A290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003CdoneCnt_003E5__3;

		[Token(Token = "0x17000CE2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005611")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005613")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600560E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__74(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600560F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005610")]
		[Address(RVA = "0x9C7E50", Offset = "0x9C7050", VA = "0x1809C7E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005612")]
		[Address(RVA = "0x9C8D40", Offset = "0x9C7F40", VA = "0x1809C8D40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E33")]
	[CompilerGenerated]
	private sealed class _003CyPlaySequence_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelPreviewPlayer _003C_003E4__this;

		[Token(Token = "0x400A294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RawImage rawImage;

		[Token(Token = "0x400A295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onReady;

		[Token(Token = "0x400A296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string duelPreviewAssetPath;

		[Token(Token = "0x400A297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass82_0 _003C_003E8__1;

		[Token(Token = "0x400A298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action onFinish;

		[Token(Token = "0x400A299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IEnumerator _003Croutine_003E5__2;

		[Token(Token = "0x17000CE4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005617")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005619")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005614")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlaySequence_003Ed__82(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005615")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005616")]
		[Address(RVA = "0x9C98B0", Offset = "0x9C8AB0", VA = "0x1809C98B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005618")]
		[Address(RVA = "0x9C9CA0", Offset = "0x9C8EA0", VA = "0x1809C9CA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E34")]
	[CompilerGenerated]
	private sealed class _003CyPlaySequenceRoutine_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A29A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A29B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A29C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RawImage rawImage;

		[Token(Token = "0x400A29D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DuelPreviewPlayer _003C_003E4__this;

		[Token(Token = "0x400A29E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DuelPreviewAsset duelPreviewAsset;

		[Token(Token = "0x400A29F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onReady;

		[Token(Token = "0x400A2A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IEnumerator _003CsetupRoutine_003E5__2;

		[Token(Token = "0x400A2A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IEnumerator _003CcardLoadRoutine_003E5__3;

		[Token(Token = "0x400A2A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IEnumerator _003CplayRoutine_003E5__4;

		[Token(Token = "0x17000CE6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600561D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600561F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600561A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlaySequenceRoutine_003Ed__83(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600561B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600561C")]
		[Address(RVA = "0x9C90F0", Offset = "0x9C82F0", VA = "0x1809C90F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600561E")]
		[Address(RVA = "0x9C9870", Offset = "0x9C8A70", VA = "0x1809C9870", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A26A")]
	private const string k_ObjName = "DuelPreviewPlayerRoot";

	[Token(Token = "0x400A26B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string k_ELabelPreviewCameras;

	[Token(Token = "0x400A26C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string k_ELabelScreenFiller;

	[Token(Token = "0x400A26D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelDuelFieldBg;

	[Token(Token = "0x400A26E")]
	internal const string k_WKey_Mrk = "playerMrk";

	[Token(Token = "0x400A26F")]
	internal const string k_WKey_DuelPreviewAsset = "duelPreviewAsset";

	[Token(Token = "0x400A270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string k_PlayerPrefPath;

	[Token(Token = "0x400A271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string k_PlayerSettingPath;

	[Token(Token = "0x400A272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string k_RunEffectSettingPath;

	[Token(Token = "0x400A273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Option m_Option;

	[Token(Token = "0x400A274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<ControllerType, IPreviewPlayerController> m_ControllerMap;

	[Token(Token = "0x400A275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Dictionary<string, object> m_Work;

	[Token(Token = "0x400A277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CardRunEffectSetting m_CardRunEffectSetting;

	[Token(Token = "0x400A278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject m_PlayerPref;

	[Token(Token = "0x400A279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private DuelPreviewSetting m_ProductViewerSetting;

	[Token(Token = "0x400A27A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject m_PlayerGob;

	[Token(Token = "0x400A27B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private DuelPreviewSequence m_PreviewSequence;

	[Token(Token = "0x400A27C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Coroutine m_PreviewPlayRoutine;

	[Token(Token = "0x400A27D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool m_IsReady;

	[Token(Token = "0x400A27E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool m_IsPlaying;

	[Token(Token = "0x400A281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Dictionary<int, bool> m_IsSupportedDuelPreviewCache;

	[Token(Token = "0x400A282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Coroutine m_InitializeRoutine;

	[Token(Token = "0x17000CCF")]
	public Option option
	{
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD0")]
	public PreviewResourceController resourceController
	{
		[Token(Token = "0x60055DF")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD1")]
	public CardRunEffectSetting cardRunEffectSetting
	{
		[Token(Token = "0x60055E0")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD2")]
	public PreviewCameraController cameraController
	{
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x9B6090", Offset = "0x9B5290", VA = "0x1809B6090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD3")]
	public PreviewRenderTextureController rtController
	{
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0x9B6500", Offset = "0x9B5700", VA = "0x1809B6500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD4")]
	public PreviewScreenController screenController
	{
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x9B65A0", Offset = "0x9B57A0", VA = "0x1809B65A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD5")]
	public PreviewFieldController fieldController
	{
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x9B62C0", Offset = "0x9B54C0", VA = "0x1809B62C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD6")]
	public PreviewCardController cardController
	{
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0x9B6130", Offset = "0x9B5330", VA = "0x1809B6130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD7")]
	public PreviewMonsterCutinController monsterCutinController
	{
		[Token(Token = "0x60055E6")]
		[Address(RVA = "0x9B6380", Offset = "0x9B5580", VA = "0x1809B6380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD8")]
	public PreviewBezierMotionController bezierMotionController
	{
		[Token(Token = "0x60055E7")]
		[Address(RVA = "0x9B5FF0", Offset = "0x9B51F0", VA = "0x1809B5FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD9")]
	public PreviewTimeline3DController timeline3DController
	{
		[Token(Token = "0x60055E8")]
		[Address(RVA = "0x9B66E0", Offset = "0x9B58E0", VA = "0x1809B66E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CDA")]
	public PreviewSimpleEffectController simpleEffectController
	{
		[Token(Token = "0x60055E9")]
		[Address(RVA = "0x9B6640", Offset = "0x9B5840", VA = "0x1809B6640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CDB")]
	public PreviewCardRunEffectController cardRunEffectController
	{
		[Token(Token = "0x60055EA")]
		[Address(RVA = "0x9B61D0", Offset = "0x9B53D0", VA = "0x1809B61D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CDC")]
	public PreviewPrefabController prefabController
	{
		[Token(Token = "0x60055EB")]
		[Address(RVA = "0x9B6460", Offset = "0x9B5660", VA = "0x1809B6460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CDD")]
	public IReadOnlyDictionary<string, object> work
	{
		[Token(Token = "0x60055EC")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CDE")]
	public int mrk
	{
		[Token(Token = "0x60055ED")]
		[Address(RVA = "0x9B6420", Offset = "0x9B5620", VA = "0x1809B6420")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000CDF")]
	public DuelPreviewAsset duelPreviewAsset
	{
		[Token(Token = "0x60055EE")]
		[Address(RVA = "0x9B6270", Offset = "0x9B5470", VA = "0x1809B6270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CE0")]
	public bool isReady
	{
		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x9B6370", Offset = "0x9B5570", VA = "0x1809B6370")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000CE1")]
	public bool isPlaying
	{
		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x9B6360", Offset = "0x9B5560", VA = "0x1809B6360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000089")]
	public event Action onPlayPreviewStart
	{
		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x9B5F40", Offset = "0x9B5140", VA = "0x1809B5F40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60055F2")]
		[Address(RVA = "0x9B6830", Offset = "0x9B5A30", VA = "0x1809B6830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400008A")]
	public event Action onPlayPreviewEnd
	{
		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x9B5E90", Offset = "0x9B5090", VA = "0x1809B5E90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x9B6780", Offset = "0x9B5980", VA = "0x1809B6780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60055F5")]
	[Address(RVA = "0x9B4D40", Offset = "0x9B3F40", VA = "0x1809B4D40")]
	public bool IsSupportedPlay(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x60055F6")]
	[Address(RVA = "0x9B4D30", Offset = "0x9B3F30", VA = "0x1809B4D30")]
	public bool IsSupportedMonsterCutin(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x60055F7")]
	[Address(RVA = "0x9B4B70", Offset = "0x9B3D70", VA = "0x1809B4B70")]
	public bool IsSupportedDuelPreview(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x60055F8")]
	[Address(RVA = "0x9B49A0", Offset = "0x9B3BA0", VA = "0x1809B49A0")]
	public GameObject FindObj(string label)
	{
		return null;
	}

	[Token(Token = "0x60055F9")]
	[Address(RVA = "0x9B5630", Offset = "0x9B4830", VA = "0x1809B5630")]
	public DuelPreviewPlayer()
	{
	}

	[Token(Token = "0x60055FA")]
	[Address(RVA = "0x9B4A90", Offset = "0x9B3C90", VA = "0x1809B4A90")]
	public void Initialize([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60055FB")]
	[Address(RVA = "0x9B68E0", Offset = "0x9B5AE0", VA = "0x1809B68E0")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__74))]
	private IEnumerator yInitialize([Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60055FC")]
	[Address(RVA = "0x9B5520", Offset = "0x9B4720", VA = "0x1809B5520")]
	public void UnloadCache()
	{
	}

	[Token(Token = "0x60055FD")]
	[Address(RVA = "0x9B52D0", Offset = "0x9B44D0", VA = "0x1809B52D0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60055FE")]
	[Address(RVA = "0x9B50D0", Offset = "0x9B42D0", VA = "0x1809B50D0")]
	public void Release()
	{
	}

	[Token(Token = "0x60055FF")]
	[Address(RVA = "0x9B47D0", Offset = "0x9B39D0", VA = "0x1809B47D0")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6005600")]
	[Address(RVA = "0x9B5080", Offset = "0x9B4280", VA = "0x1809B5080")]
	public void PlayStrongSummon(RawImage rawImage, int mrk, [Optional] Action onReady, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6005601")]
	[Address(RVA = "0x9B4D80", Offset = "0x9B3F80", VA = "0x1809B4D80")]
	public void PlayDuelPreview(RawImage rawImage, int mrk, [Optional] Action onReady, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6005602")]
	[Address(RVA = "0x9B4E20", Offset = "0x9B4020", VA = "0x1809B4E20")]
	private void PlaySequence(string duelPreviewAssetPath, RawImage rawImage, int mrk, [Optional] Action onReady, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6005603")]
	[Address(RVA = "0x9B6A30", Offset = "0x9B5C30", VA = "0x1809B6A30")]
	[IteratorStateMachine(typeof(_003CyPlaySequence_003Ed__82))]
	private IEnumerator yPlaySequence(string duelPreviewAssetPath, RawImage rawImage, [Optional] Action onReady, [Optional] Action onFinish)
	{
		return null;
	}

	[Token(Token = "0x6005604")]
	[Address(RVA = "0x9B6970", Offset = "0x9B5B70", VA = "0x1809B6970")]
	[IteratorStateMachine(typeof(_003CyPlaySequenceRoutine_003Ed__83))]
	private IEnumerator yPlaySequenceRoutine(DuelPreviewAsset duelPreviewAsset, RawImage rawImage, [Optional] Action onReady)
	{
		return null;
	}
}
