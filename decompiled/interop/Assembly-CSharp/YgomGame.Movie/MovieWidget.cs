using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;
using YgomSystem.ElementSystem;
using YgomSystem.Video;

namespace YgomGame.Movie;

[Token(Token = "0x20016C5")]
public class MovieWidget : MonoBehaviour
{
	[Token(Token = "0x20016C6")]
	public enum LoadType
	{
		[Token(Token = "0x400D89D")]
		Local,
		[Token(Token = "0x400D89E")]
		Remote
	}

	[Token(Token = "0x20016C7")]
	public enum MovieState
	{
		[Token(Token = "0x400D8A0")]
		Empty,
		[Token(Token = "0x400D8A1")]
		Play,
		[Token(Token = "0x400D8A2")]
		Pause,
		[Token(Token = "0x400D8A3")]
		End,
		[Token(Token = "0x400D8A4")]
		Loading,
		[Token(Token = "0x400D8A5")]
		Rollback
	}

	[Token(Token = "0x20016CB")]
	[CompilerGenerated]
	private sealed class _003CCheckDoubleclick_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D8B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D8B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D8B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget _003C_003E4__this;

		[Token(Token = "0x400D8B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x17001583")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008DED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001584")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008DEF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008DEA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckDoubleclick_003Ed__109(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008DEB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008DEC")]
		[Address(RVA = "0xDA5A80", Offset = "0xDA4C80", VA = "0x180DA5A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008DEE")]
		[Address(RVA = "0xDA5B60", Offset = "0xDA4D60", VA = "0x180DA5B60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016CC")]
	[CompilerGenerated]
	private sealed class _003CCheckFrame_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D8B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D8B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D8B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget _003C_003E4__this;

		[Token(Token = "0x400D8B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double s;

		[Token(Token = "0x17001585")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008DF3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001586")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008DF5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008DF0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckFrame_003Ed__116(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008DF1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008DF2")]
		[Address(RVA = "0xDA5BA0", Offset = "0xDA4DA0", VA = "0x180DA5BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008DF4")]
		[Address(RVA = "0xDA6060", Offset = "0xDA5260", VA = "0x180DA6060", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016CD")]
	[CompilerGenerated]
	private sealed class _003CClearRTatNextFrame_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D8BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D8BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D8BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget _003C_003E4__this;

		[Token(Token = "0x400D8BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x400D8BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onComplete;

		[Token(Token = "0x17001587")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008DF9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001588")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008DFB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008DF6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CClearRTatNextFrame_003Ed__82(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008DF7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008DF8")]
		[Address(RVA = "0xDA60A0", Offset = "0xDA52A0", VA = "0x180DA60A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008DFA")]
		[Address(RVA = "0xDA6130", Offset = "0xDA5330", VA = "0x180DA6130", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016CE")]
	[CompilerGenerated]
	private sealed class _003CPrepareAtNextFrame_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D8BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D8C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D8C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget _003C_003E4__this;

		[Token(Token = "0x17001589")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008DFF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700158A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008E01")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008DFC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPrepareAtNextFrame_003Ed__80(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008DFD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008DFE")]
		[Address(RVA = "0xDA6290", Offset = "0xDA5490", VA = "0x180DA6290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008E00")]
		[Address(RVA = "0xDA63B0", Offset = "0xDA55B0", VA = "0x180DA63B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016CF")]
	[CompilerGenerated]
	private sealed class _003CWaitFrameSkiped_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D8C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D8C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D8C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget _003C_003E4__this;

		[Token(Token = "0x400D8C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public long frame;

		[Token(Token = "0x400D8C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<long> onCompleted;

		[Token(Token = "0x1700158B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008E05")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700158C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008E07")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008E02")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitFrameSkiped_003Ed__112(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008E03")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008E04")]
		[Address(RVA = "0xDA7730", Offset = "0xDA6930", VA = "0x180DA7730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008E06")]
		[Address(RVA = "0xDA78F0", Offset = "0xDA6AF0", VA = "0x180DA78F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016D0")]
	[CompilerGenerated]
	private sealed class _003CyRetryWait_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D8C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D8C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D8C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x400D8CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MovieWidget _003C_003E4__this;

		[Token(Token = "0x1700158D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008E0B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700158E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008E0D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008E08")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyRetryWait_003Ed__115(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008E09")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008E0A")]
		[Address(RVA = "0xDA7F20", Offset = "0xDA7120", VA = "0x180DA7F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008E0C")]
		[Address(RVA = "0xDA7FF0", Offset = "0xDA71F0", VA = "0x180DA7FF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D868")]
	private const string k_MovieUIPath = "Prefabs/UI/Movie/MovieWidgetContainer";

	[Token(Token = "0x400D869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string LABEL_MOVIEPLAYER;

	[Token(Token = "0x400D86A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string LABEL_PLAYBUTTON;

	[Token(Token = "0x400D86B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string LABEL_STOPBUTTON;

	[Token(Token = "0x400D86C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string LABEL_SKIPBUTTON;

	[Token(Token = "0x400D86D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string LABEL_BACKBUTTON;

	[Token(Token = "0x400D86E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string LABEL_LOADINGICON;

	[Token(Token = "0x400D86F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly long skipTime;

	[Token(Token = "0x400D870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly int ignoreChangeFrame;

	[Token(Token = "0x400D871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly float loadingIconTime;

	[Token(Token = "0x400D872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LoadType loadType;

	[Token(Token = "0x400D873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string path;

	[Token(Token = "0x400D874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float scale;

	[Token(Token = "0x400D875")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Color initColor;

	[Token(Token = "0x400D876")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Action DestroyCallback;

	[Token(Token = "0x400D877")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float volume;

	[Token(Token = "0x400D878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ElementObjectManager m_ContainerEom;

	[Token(Token = "0x400D879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float loadingTime;

	[Token(Token = "0x400D87A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private MovieState innerState;

	[Token(Token = "0x400D87B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isLoading;

	[Token(Token = "0x400D87C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private MDVideoPlayer m_VideoPlayer;

	[Token(Token = "0x400D87D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private MovieData m_MovieData;

	[Token(Token = "0x400D87E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x400D87F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject m_LoadingIcon;

	[Token(Token = "0x400D880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private RawImage m_RawImage;

	[Token(Token = "0x400D881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long m_LastFrame;

	[Token(Token = "0x400D882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float m_FrameCheckTimer;

	[Token(Token = "0x400D883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int m_FramerateSetting;

	[Token(Token = "0x400D884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int m_ErrorCount;

	[Token(Token = "0x400D885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private int m_LimitErrorCount;

	[Token(Token = "0x400D886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float m_RetryWaitTime;

	[Token(Token = "0x400D887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool isRecestedCreateContainer;

	[Token(Token = "0x400D888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
	private bool isCheckingFrame;

	[Token(Token = "0x400D889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB6")]
	private bool isSettingFrame;

	[Token(Token = "0x400D88A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB7")]
	private bool isPrepareCompleted;

	[Token(Token = "0x400D88B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool isDoubleclicked;

	[Token(Token = "0x400D88C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Action LoadedCallback;

	[Token(Token = "0x400D88D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Action UnloadedCallback;

	[Token(Token = "0x400D88E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Action EndCallback;

	[Token(Token = "0x400D88F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Action<string> ErrorCallback;

	[Token(Token = "0x400D890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Action onFatalError;

	[Token(Token = "0x400D891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Action RollbackCallback;

	[Token(Token = "0x400D892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private UnityAction ClickedCallback;

	[Token(Token = "0x400D893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private UnityAction DoubleclickCallbackRight;

	[Token(Token = "0x400D894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private UnityAction DoubleclickCallbackLeft;

	[Token(Token = "0x400D895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private UnityAction PlaybackError;

	[Token(Token = "0x400D896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Coroutine m_FrameSkipCoroutine;

	[Token(Token = "0x400D897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Coroutine m_FrameCheckCoroutine;

	[Token(Token = "0x400D898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Coroutine m_RetryWaitCoroutine;

	[Token(Token = "0x400D899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int m_FrameMarker;

	[Token(Token = "0x400D89A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private FrameMarkAsset m_FrameMarkAsset;

	[Token(Token = "0x400D89B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Action<int, double> onMarkerChanged;

	[Token(Token = "0x1700157D")]
	public MovieState state
	{
		[Token(Token = "0x6008DA6")]
		[Address(RVA = "0xD7D120", Offset = "0xD7C320", VA = "0x180D7D120")]
		get
		{
			return default(MovieState);
		}
		[Token(Token = "0x6008DA7")]
		[Address(RVA = "0xD7FF90", Offset = "0xD7F190", VA = "0x180D7FF90")]
		private set
		{
		}
	}

	[Token(Token = "0x1700157E")]
	public long frame
	{
		[Token(Token = "0x6008DA8")]
		[Address(RVA = "0xD7FE70", Offset = "0xD7F070", VA = "0x180D7FE70")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700157F")]
	public double clockTime
	{
		[Token(Token = "0x6008DA9")]
		[Address(RVA = "0xD7FD50", Offset = "0xD7EF50", VA = "0x180D7FD50")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17001580")]
	public ulong frameCount
	{
		[Token(Token = "0x6008DAA")]
		[Address(RVA = "0xD7FDE0", Offset = "0xD7EFE0", VA = "0x180D7FDE0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001581")]
	public double length
	{
		[Token(Token = "0x6008DAB")]
		[Address(RVA = "0xD7FF00", Offset = "0xD7F100", VA = "0x180D7FF00")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17001582")]
	public int frameMarker
	{
		[Token(Token = "0x6008DAC")]
		[Address(RVA = "0xD7FE60", Offset = "0xD7F060", VA = "0x180D7FE60")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008DAD")]
	[Address(RVA = "0xD7F8A0", Offset = "0xD7EAA0", VA = "0x180D7F8A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6008DAE")]
	[Address(RVA = "0xD7E7C0", Offset = "0xD7D9C0", VA = "0x180D7E7C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008DAF")]
	[Address(RVA = "0xD7D500", Offset = "0xD7C700", VA = "0x180D7D500")]
	private void CreateContainer([Optional] string path, [Optional] Action CreatedCallback)
	{
	}

	[Token(Token = "0x6008DB0")]
	[Address(RVA = "0xD7D930", Offset = "0xD7CB30", VA = "0x180D7D930")]
	public static MovieWidget CreateMovieWidget(GameObject obj, [Optional] string ui, float scale = 1f, float loadingTime = 10f, [Optional] Action<GameObject> CreatedCallback)
	{
		return null;
	}

	[Token(Token = "0x6008DB1")]
	[Address(RVA = "0xD7DA00", Offset = "0xD7CC00", VA = "0x180D7DA00")]
	public static MovieWidget CreateMovieWidget(GameObject obj, string path, LoadType type, Color initColor, [Optional] string ui, float scale = 1f, float loadingTime = 10f, float volume = 1f, [Optional] Action<GameObject> CreatedCallback)
	{
		return null;
	}

	[Token(Token = "0x6008DB2")]
	[Address(RVA = "0xD7D610", Offset = "0xD7C810", VA = "0x180D7D610")]
	public static MovieWidget CreateMovieWidgetWithSubtitle(GameObject obj, [Optional] string ui, float scale = 1f, float loadingTime = 10f, [Optional] Action<GameObject> CreatedCallback, [Optional] FrameMarkAsset frameMarkAsset)
	{
		return null;
	}

	[Token(Token = "0x6008DB3")]
	[Address(RVA = "0xD7D6F0", Offset = "0xD7C8F0", VA = "0x180D7D6F0")]
	public static MovieWidget CreateMovieWidgetWithSubtitle(GameObject obj, string path, LoadType type, Color initColor, [Optional] string ui, float scale = 1f, float loadingTime = 10f, float volume = 1f, [Optional] Action<GameObject> CreatedCallback, [Optional] FrameMarkAsset frameMarkAsset)
	{
		return null;
	}

	[Token(Token = "0x6008DB4")]
	[Address(RVA = "0xD7DDB0", Offset = "0xD7CFB0", VA = "0x180D7DDB0")]
	public void InitComponent()
	{
	}

	[Token(Token = "0x6008DB5")]
	[Address(RVA = "0xD7F390", Offset = "0xD7E590", VA = "0x180D7F390", Slot = "4")]
	public virtual void SetMovie(string path, LoadType type, Color initColor)
	{
	}

	[Token(Token = "0x6008DB6")]
	[Address(RVA = "0xD7EFA0", Offset = "0xD7E1A0", VA = "0x180D7EFA0")]
	public void ReleaseMovie()
	{
	}

	[Token(Token = "0x6008DB7")]
	[Address(RVA = "0xD7F160", Offset = "0xD7E360", VA = "0x180D7F160")]
	public void SetErrorParams(float retryWaitTime, int limitErrorCount)
	{
	}

	[Token(Token = "0x6008DB8")]
	[Address(RVA = "0xD7EDD0", Offset = "0xD7DFD0", VA = "0x180D7EDD0")]
	private void PrepareCompleted(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6008DB9")]
	[Address(RVA = "0xD7E5F0", Offset = "0xD7D7F0", VA = "0x180D7E5F0")]
	private void LoadLocalMovie(string path)
	{
	}

	[Token(Token = "0x6008DBA")]
	[Address(RVA = "0xD7ED60", Offset = "0xD7DF60", VA = "0x180D7ED60")]
	[IteratorStateMachine(typeof(_003CPrepareAtNextFrame_003Ed__80))]
	private IEnumerator PrepareAtNextFrame()
	{
		return null;
	}

	[Token(Token = "0x6008DBB")]
	[Address(RVA = "0xD7D2A0", Offset = "0xD7C4A0", VA = "0x180D7D2A0")]
	private void ClearRT(Color color)
	{
	}

	[Token(Token = "0x6008DBC")]
	[Address(RVA = "0xD7D3B0", Offset = "0xD7C5B0", VA = "0x180D7D3B0")]
	[IteratorStateMachine(typeof(_003CClearRTatNextFrame_003Ed__82))]
	private IEnumerator ClearRTatNextFrame(Color color, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008DBD")]
	[Address(RVA = "0xD7EBE0", Offset = "0xD7DDE0", VA = "0x180D7EBE0")]
	public void Play()
	{
	}

	[Token(Token = "0x6008DBE")]
	[Address(RVA = "0xD7EA90", Offset = "0xD7DC90", VA = "0x180D7EA90")]
	public void Pause()
	{
	}

	[Token(Token = "0x6008DBF")]
	[Address(RVA = "0xD7F9B0", Offset = "0xD7EBB0", VA = "0x180D7F9B0")]
	public void Stop()
	{
	}

	[Token(Token = "0x6008DC0")]
	[Address(RVA = "0xD7D450", Offset = "0xD7C650", VA = "0x180D7D450")]
	public void Clear()
	{
	}

	[Token(Token = "0x6008DC1")]
	[Address(RVA = "0xD7EB20", Offset = "0xD7DD20", VA = "0x180D7EB20")]
	public void PlayToggle()
	{
	}

	[Token(Token = "0x6008DC2")]
	[Address(RVA = "0xD7F810", Offset = "0xD7EA10", VA = "0x180D7F810")]
	public void SetVolume(float volume)
	{
	}

	[Token(Token = "0x6008DC3")]
	[Address(RVA = "0xD7DD80", Offset = "0xD7CF80", VA = "0x180D7DD80")]
	public float GetVolume()
	{
		return default(float);
	}

	[Token(Token = "0x6008DC4")]
	[Address(RVA = "0xD7F540", Offset = "0xD7E740", VA = "0x180D7F540")]
	public void SetPlaybackPosition(double s)
	{
	}

	[Token(Token = "0x6008DC5")]
	[Address(RVA = "0xD7C290", Offset = "0xD7B490", VA = "0x180D7C290")]
	public void ResetFrameCheckTimer()
	{
	}

	[Token(Token = "0x6008DC6")]
	[Address(RVA = "0xD7F170", Offset = "0xD7E370", VA = "0x180D7F170")]
	public void SetFrameMarkAsset(FrameMarkAsset asset)
	{
	}

	[Token(Token = "0x6008DC7")]
	[Address(RVA = "0xD7F1A0", Offset = "0xD7E3A0", VA = "0x180D7F1A0")]
	private int SetFrameMarker(double second)
	{
		return default(int);
	}

	[Token(Token = "0x6008DC8")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	public void SetDestroyCallback(Action destroyCallback)
	{
	}

	[Token(Token = "0x6008DC9")]
	[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
	public void SetLoadedCallback(Action loadedCallback)
	{
	}

	[Token(Token = "0x6008DCA")]
	[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
	public void SetUnloadedCallback(Action unloadedCallback)
	{
	}

	[Token(Token = "0x6008DCB")]
	[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
	public void SetEndCallback(Action endCallback)
	{
	}

	[Token(Token = "0x6008DCC")]
	[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
	public void SetErrorCallback(Action<string> errorCallback)
	{
	}

	[Token(Token = "0x6008DCD")]
	[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
	public void SetFatalErrorCallback(Action onFatalError)
	{
	}

	[Token(Token = "0x6008DCE")]
	[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
	public void SetPlaybackErrorCallback(UnityAction errorcallback)
	{
	}

	[Token(Token = "0x6008DCF")]
	[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
	public void SetClickedCallback(UnityAction clickedCallback)
	{
	}

	[Token(Token = "0x6008DD0")]
	[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
	public void SetDoubleclickedCallbackRight(UnityAction callback)
	{
	}

	[Token(Token = "0x6008DD1")]
	[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
	public void SetDoubleclickedCallbackLeft(UnityAction callback)
	{
	}

	[Token(Token = "0x6008DD2")]
	[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
	public void SetRollbackCallback(Action callback)
	{
	}

	[Token(Token = "0x6008DD3")]
	[Address(RVA = "0xD7E700", Offset = "0xD7D900", VA = "0x180D7E700")]
	public void OnClicked()
	{
	}

	[Token(Token = "0x6008DD4")]
	[Address(RVA = "0x7ACDE0", Offset = "0x7ABFE0", VA = "0x1807ACDE0")]
	public void SetOnMarkerChangerdCallback(Action<int, double> action)
	{
	}

	[Token(Token = "0x6008DD5")]
	[Address(RVA = "0xD7E6D0", Offset = "0xD7D8D0", VA = "0x180D7E6D0")]
	private void LoopPoint(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6008DD6")]
	[Address(RVA = "0xD7DC00", Offset = "0xD7CE00", VA = "0x180D7DC00")]
	private void Error(VideoPlayer vp, string message)
	{
	}

	[Token(Token = "0x6008DD7")]
	[Address(RVA = "0xD7D1B0", Offset = "0xD7C3B0", VA = "0x180D7D1B0")]
	[IteratorStateMachine(typeof(_003CCheckDoubleclick_003Ed__109))]
	private IEnumerator CheckDoubleclick()
	{
		return null;
	}

	[Token(Token = "0x6008DD8")]
	[Address(RVA = "0xD7E9D0", Offset = "0xD7DBD0", VA = "0x180D7E9D0")]
	public void OnDoubleclickedRight()
	{
	}

	[Token(Token = "0x6008DD9")]
	[Address(RVA = "0xD7E910", Offset = "0xD7DB10", VA = "0x180D7E910")]
	public void OnDoubleclickedLeft()
	{
	}

	[Token(Token = "0x6008DDA")]
	[Address(RVA = "0xD7FA60", Offset = "0xD7EC60", VA = "0x180D7FA60")]
	[IteratorStateMachine(typeof(_003CWaitFrameSkiped_003Ed__112))]
	private IEnumerator WaitFrameSkiped(long frame, [Optional] Action<long> onCompleted)
	{
		return null;
	}

	[Token(Token = "0x6008DDB")]
	[Address(RVA = "0xD7CAE0", Offset = "0xD7BCE0", VA = "0x180D7CAE0")]
	private long TimeToFrame(double s)
	{
		return default(long);
	}

	[Token(Token = "0x6008DDC")]
	[Address(RVA = "0xD7E500", Offset = "0xD7D700", VA = "0x180D7E500")]
	private void KillFrameCheckCoroutine(Coroutine coroutine)
	{
	}

	[Token(Token = "0x6008DDD")]
	[Address(RVA = "0xD80020", Offset = "0xD7F220", VA = "0x180D80020")]
	[IteratorStateMachine(typeof(_003CyRetryWait_003Ed__115))]
	private IEnumerator yRetryWait(float waitTime)
	{
		return null;
	}

	[Token(Token = "0x6008DDE")]
	[Address(RVA = "0xD7D220", Offset = "0xD7C420", VA = "0x180D7D220")]
	[IteratorStateMachine(typeof(_003CCheckFrame_003Ed__116))]
	private IEnumerator CheckFrame(double s)
	{
		return null;
	}

	[Token(Token = "0x6008DDF")]
	[Address(RVA = "0xD7FD00", Offset = "0xD7EF00", VA = "0x180D7FD00")]
	public MovieWidget()
	{
	}
}
