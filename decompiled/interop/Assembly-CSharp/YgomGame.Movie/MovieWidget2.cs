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

[Token(Token = "0x20016B4")]
public class MovieWidget2 : MonoBehaviour
{
	[Token(Token = "0x20016B5")]
	public enum LoadType
	{
		[Token(Token = "0x400D833")]
		Local,
		[Token(Token = "0x400D834")]
		Remote
	}

	[Token(Token = "0x20016B6")]
	public enum MovieState
	{
		[Token(Token = "0x400D836")]
		Empty,
		[Token(Token = "0x400D837")]
		Play,
		[Token(Token = "0x400D838")]
		Pause,
		[Token(Token = "0x400D839")]
		End,
		[Token(Token = "0x400D83A")]
		Loading,
		[Token(Token = "0x400D83B")]
		Rollback
	}

	[Token(Token = "0x20016B9")]
	[CompilerGenerated]
	private sealed class _003CCheckDoubleclick_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget2 _003C_003E4__this;

		[Token(Token = "0x400D846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x17001570")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008D6E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001571")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008D70")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008D6B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckDoubleclick_003Ed__96(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008D6C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008D6D")]
		[Address(RVA = "0xD8CC50", Offset = "0xD8BE50", VA = "0x180D8CC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008D6F")]
		[Address(RVA = "0xD8CDE0", Offset = "0xD8BFE0", VA = "0x180D8CDE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016BA")]
	[CompilerGenerated]
	private sealed class _003CCheckFrame_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget2 _003C_003E4__this;

		[Token(Token = "0x400D84A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double s;

		[Token(Token = "0x17001572")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008D74")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001573")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008D76")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008D71")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckFrame_003Ed__105(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008D72")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008D73")]
		[Address(RVA = "0xD8CE20", Offset = "0xD8C020", VA = "0x180D8CE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008D75")]
		[Address(RVA = "0xD8D480", Offset = "0xD8C680", VA = "0x180D8D480", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016BB")]
	[CompilerGenerated]
	private sealed class _003CClearRTatNextFrame_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D84B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D84C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D84D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget2 _003C_003E4__this;

		[Token(Token = "0x400D84E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x400D84F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onComplete;

		[Token(Token = "0x17001574")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008D7A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001575")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008D7C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008D77")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CClearRTatNextFrame_003Ed__74(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008D78")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008D79")]
		[Address(RVA = "0xD8D4C0", Offset = "0xD8C6C0", VA = "0x180D8D4C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008D7B")]
		[Address(RVA = "0xD8D640", Offset = "0xD8C840", VA = "0x180D8D640", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016BC")]
	[CompilerGenerated]
	private sealed class _003CPrepareAtNextFrame_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget2 _003C_003E4__this;

		[Token(Token = "0x17001576")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008D80")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001577")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008D82")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008D7D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPrepareAtNextFrame_003Ed__72(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008D7E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008D7F")]
		[Address(RVA = "0xD8D850", Offset = "0xD8CA50", VA = "0x180D8D850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008D81")]
		[Address(RVA = "0xD8D970", Offset = "0xD8CB70", VA = "0x180D8D970", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20016BD")]
	[CompilerGenerated]
	private sealed class _003CWaitFrameSkiped_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovieWidget2 _003C_003E4__this;

		[Token(Token = "0x400D856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public long frame;

		[Token(Token = "0x400D857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<long> onCompleted;

		[Token(Token = "0x17001578")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008D86")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001579")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008D88")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008D83")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitFrameSkiped_003Ed__100(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008D84")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008D85")]
		[Address(RVA = "0xD90A70", Offset = "0xD8FC70", VA = "0x180D90A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008D87")]
		[Address(RVA = "0xD90C60", Offset = "0xD8FE60", VA = "0x180D90C60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D803")]
	private const string k_MovieUIPath = "Prefabs/UI/Movie/MovieWidgetContainer";

	[Token(Token = "0x400D804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string LABEL_MOVIEPLAYER;

	[Token(Token = "0x400D805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string LABEL_PLAYBUTTON;

	[Token(Token = "0x400D806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string LABEL_STOPBUTTON;

	[Token(Token = "0x400D807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string LABEL_SKIPBUTTON;

	[Token(Token = "0x400D808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string LABEL_BACKBUTTON;

	[Token(Token = "0x400D809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string LABEL_LOADINGICON;

	[Token(Token = "0x400D80A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly long skipTime;

	[Token(Token = "0x400D80B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly int ignoreChangeFrame;

	[Token(Token = "0x400D80C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly float loadingIconTime;

	[Token(Token = "0x400D80D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LoadType loadType;

	[Token(Token = "0x400D80E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string path;

	[Token(Token = "0x400D80F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float scale;

	[Token(Token = "0x400D810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Color initColor;

	[Token(Token = "0x400D811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Action DestroyCallback;

	[Token(Token = "0x400D812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float volume;

	[Token(Token = "0x400D813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ElementObjectManager m_ContainerEom;

	[Token(Token = "0x400D814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float loadingTime;

	[Token(Token = "0x400D815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private MovieState innerState;

	[Token(Token = "0x400D816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isLoading;

	[Token(Token = "0x400D817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private MDVideoPlayer m_VideoPlayer;

	[Token(Token = "0x400D818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private MovieData m_MovieData;

	[Token(Token = "0x400D819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x400D81A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject m_LoadingIcon;

	[Token(Token = "0x400D81B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private RawImage m_RawImage;

	[Token(Token = "0x400D81C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long m_LastFrame;

	[Token(Token = "0x400D81D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float m_FrameCheckTimer;

	[Token(Token = "0x400D81E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int m_FramerateSetting;

	[Token(Token = "0x400D81F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int m_FrameMarker;

	[Token(Token = "0x400D820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool isRecestedCreateContainer;

	[Token(Token = "0x400D821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
	private bool isCheckingFrame;

	[Token(Token = "0x400D822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
	private bool isSettingFrame;

	[Token(Token = "0x400D823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAF")]
	private bool isPrepareCompleted;

	[Token(Token = "0x400D824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool isDoubleclicked;

	[Token(Token = "0x400D825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Action LoadedCallback;

	[Token(Token = "0x400D826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Action UnloadedCallback;

	[Token(Token = "0x400D827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Action EndCallback;

	[Token(Token = "0x400D828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Action<string> ErrorCallback;

	[Token(Token = "0x400D829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Action RollbackCallback;

	[Token(Token = "0x400D82A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Action<int, double> onMarkerChanged;

	[Token(Token = "0x400D82B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private UnityAction ClickedCallback;

	[Token(Token = "0x400D82C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private UnityAction DoubleclickCallbackRight;

	[Token(Token = "0x400D82D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private UnityAction DoubleclickCallbackLeft;

	[Token(Token = "0x400D82E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private UnityAction PlaybackError;

	[Token(Token = "0x400D82F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Coroutine m_FrameSkipCoroutine;

	[Token(Token = "0x400D830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Coroutine m_FrameCheckCoroutine;

	[Token(Token = "0x400D831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private FrameMarkAsset m_FrameMarkAsset;

	[Token(Token = "0x1700156A")]
	public MovieState state
	{
		[Token(Token = "0x6008D2F")]
		[Address(RVA = "0xD7D120", Offset = "0xD7C320", VA = "0x180D7D120")]
		get
		{
			return default(MovieState);
		}
		[Token(Token = "0x6008D30")]
		[Address(RVA = "0xD7D130", Offset = "0xD7C330", VA = "0x180D7D130")]
		private set
		{
		}
	}

	[Token(Token = "0x1700156B")]
	public long frame
	{
		[Token(Token = "0x6008D31")]
		[Address(RVA = "0xD7D000", Offset = "0xD7C200", VA = "0x180D7D000")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700156C")]
	public double clockTime
	{
		[Token(Token = "0x6008D32")]
		[Address(RVA = "0xD7CEF0", Offset = "0xD7C0F0", VA = "0x180D7CEF0")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700156D")]
	public ulong frameCount
	{
		[Token(Token = "0x6008D33")]
		[Address(RVA = "0xD7CF80", Offset = "0xD7C180", VA = "0x180D7CF80")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700156E")]
	public double length
	{
		[Token(Token = "0x6008D34")]
		[Address(RVA = "0xD7D090", Offset = "0xD7C290", VA = "0x180D7D090")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700156F")]
	public int frameMarker
	{
		[Token(Token = "0x6008D35")]
		[Address(RVA = "0x42D5E0", Offset = "0x42C7E0", VA = "0x18042D5E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008D36")]
	[Address(RVA = "0xD7C940", Offset = "0xD7BB40", VA = "0x180D7C940")]
	private void Start()
	{
	}

	[Token(Token = "0x6008D37")]
	[Address(RVA = "0xD7B940", Offset = "0xD7AB40", VA = "0x180D7B940")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008D38")]
	[Address(RVA = "0xD7AAA0", Offset = "0xD79CA0", VA = "0x180D7AAA0")]
	private void CreateContainer([Optional] string path, [Optional] Action CreatedCallback)
	{
	}

	[Token(Token = "0x6008D39")]
	[Address(RVA = "0xD7ADF0", Offset = "0xD79FF0", VA = "0x180D7ADF0")]
	public static MovieWidget2 CreateMovieWidget(GameObject obj, [Optional] string ui, float scale = 1f, float loadingTime = 10f, [Optional] Action<GameObject> CreatedCallback, [Optional] FrameMarkAsset frameMarkAsset)
	{
		return null;
	}

	[Token(Token = "0x6008D3A")]
	[Address(RVA = "0xD7ABB0", Offset = "0xD79DB0", VA = "0x180D7ABB0")]
	public static MovieWidget2 CreateMovieWidget(GameObject obj, string path, LoadType type, Color initColor, [Optional] string ui, float scale = 1f, float loadingTime = 10f, float volume = 1f, [Optional] Action<GameObject> CreatedCallback, [Optional] FrameMarkAsset frameMarkAsset)
	{
		return null;
	}

	[Token(Token = "0x6008D3B")]
	[Address(RVA = "0xD7AF00", Offset = "0xD7A100", VA = "0x180D7AF00")]
	public void InitComponent()
	{
	}

	[Token(Token = "0x6008D3C")]
	[Address(RVA = "0xD7C430", Offset = "0xD7B630", VA = "0x180D7C430", Slot = "4")]
	public virtual void SetMovie(string path, LoadType type, Color initColor)
	{
	}

	[Token(Token = "0x6008D3D")]
	[Address(RVA = "0xD7C120", Offset = "0xD7B320", VA = "0x180D7C120")]
	public void ReleaseMovie()
	{
	}

	[Token(Token = "0x6008D3E")]
	[Address(RVA = "0xD7BF50", Offset = "0xD7B150", VA = "0x180D7BF50")]
	private void PrepareCompleted(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6008D3F")]
	[Address(RVA = "0xD7B770", Offset = "0xD7A970", VA = "0x180D7B770")]
	private void LoadLocalMovie(string path)
	{
	}

	[Token(Token = "0x6008D40")]
	[Address(RVA = "0xD7BEE0", Offset = "0xD7B0E0", VA = "0x180D7BEE0")]
	[IteratorStateMachine(typeof(_003CPrepareAtNextFrame_003Ed__72))]
	private IEnumerator PrepareAtNextFrame()
	{
		return null;
	}

	[Token(Token = "0x6008D41")]
	[Address(RVA = "0xD7A840", Offset = "0xD79A40", VA = "0x180D7A840")]
	private void ClearRT(Color color)
	{
	}

	[Token(Token = "0x6008D42")]
	[Address(RVA = "0xD7A950", Offset = "0xD79B50", VA = "0x180D7A950")]
	[IteratorStateMachine(typeof(_003CClearRTatNextFrame_003Ed__74))]
	private IEnumerator ClearRTatNextFrame(Color color, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008D43")]
	[Address(RVA = "0xD7BD60", Offset = "0xD7AF60", VA = "0x180D7BD60")]
	public void Play()
	{
	}

	[Token(Token = "0x6008D44")]
	[Address(RVA = "0xD7BC10", Offset = "0xD7AE10", VA = "0x180D7BC10")]
	public void Pause()
	{
	}

	[Token(Token = "0x6008D45")]
	[Address(RVA = "0xD7CA50", Offset = "0xD7BC50", VA = "0x180D7CA50")]
	public void Stop()
	{
	}

	[Token(Token = "0x6008D46")]
	[Address(RVA = "0xD7A9F0", Offset = "0xD79BF0", VA = "0x180D7A9F0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6008D47")]
	[Address(RVA = "0xD7BCA0", Offset = "0xD7AEA0", VA = "0x180D7BCA0")]
	public void PlayToggle()
	{
	}

	[Token(Token = "0x6008D48")]
	[Address(RVA = "0xD7C8B0", Offset = "0xD7BAB0", VA = "0x180D7C8B0")]
	public void SetVolume(float volume)
	{
	}

	[Token(Token = "0x6008D49")]
	[Address(RVA = "0xD7C5E0", Offset = "0xD7B7E0", VA = "0x180D7C5E0")]
	public void SetPlaybackPosition(double s)
	{
	}

	[Token(Token = "0x6008D4A")]
	[Address(RVA = "0xD7C290", Offset = "0xD7B490", VA = "0x180D7C290")]
	public void ResetFrameCheckTimer()
	{
	}

	[Token(Token = "0x6008D4B")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	public void SetDestroyCallback(Action destroyCallback)
	{
	}

	[Token(Token = "0x6008D4C")]
	[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
	public void SetLoadedCallback(Action loadedCallback)
	{
	}

	[Token(Token = "0x6008D4D")]
	[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
	public void SetUnloadedCallback(Action unloadedCallback)
	{
	}

	[Token(Token = "0x6008D4E")]
	[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
	public void SetEndCallback(Action endCallback)
	{
	}

	[Token(Token = "0x6008D4F")]
	[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
	public void SetErrorCallback(Action<string> errorCallback)
	{
	}

	[Token(Token = "0x6008D50")]
	[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
	public void SetPlaybackErrorCallback(UnityAction errorcallback)
	{
	}

	[Token(Token = "0x6008D51")]
	[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
	public void SetClickedCallback(UnityAction clickedCallback)
	{
	}

	[Token(Token = "0x6008D52")]
	[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
	public void SetDoubleclickedCallbackRight(UnityAction callback)
	{
	}

	[Token(Token = "0x6008D53")]
	[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
	public void SetDoubleclickedCallbackLeft(UnityAction callback)
	{
	}

	[Token(Token = "0x6008D54")]
	[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
	public void SetRollbackCallback(Action callback)
	{
	}

	[Token(Token = "0x6008D55")]
	[Address(RVA = "0xD7B880", Offset = "0xD7AA80", VA = "0x180D7B880")]
	public void OnClicked()
	{
	}

	[Token(Token = "0x6008D56")]
	[Address(RVA = "0xD7B850", Offset = "0xD7AA50", VA = "0x180D7B850")]
	private void LoopPoint(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6008D57")]
	[Address(RVA = "0xD7AED0", Offset = "0xD7A0D0", VA = "0x180D7AED0")]
	private void Error(VideoPlayer vp, string message)
	{
	}

	[Token(Token = "0x6008D58")]
	[Address(RVA = "0xD7A750", Offset = "0xD79950", VA = "0x180D7A750")]
	[IteratorStateMachine(typeof(_003CCheckDoubleclick_003Ed__96))]
	private IEnumerator CheckDoubleclick()
	{
		return null;
	}

	[Token(Token = "0x6008D59")]
	[Address(RVA = "0xD7BB50", Offset = "0xD7AD50", VA = "0x180D7BB50")]
	public void OnDoubleclickedRight()
	{
	}

	[Token(Token = "0x6008D5A")]
	[Address(RVA = "0xD7BA90", Offset = "0xD7AC90", VA = "0x180D7BA90")]
	public void OnDoubleclickedLeft()
	{
	}

	[Token(Token = "0x6008D5B")]
	[Address(RVA = "0xD7C2A0", Offset = "0xD7B4A0", VA = "0x180D7C2A0")]
	public void SetFrameMarkAsset(FrameMarkAsset asset)
	{
	}

	[Token(Token = "0x6008D5C")]
	[Address(RVA = "0xD7CC10", Offset = "0xD7BE10", VA = "0x180D7CC10")]
	[IteratorStateMachine(typeof(_003CWaitFrameSkiped_003Ed__100))]
	private IEnumerator WaitFrameSkiped(long frame, [Optional] Action<long> onCompleted)
	{
		return null;
	}

	[Token(Token = "0x6008D5D")]
	[Address(RVA = "0xD7CAE0", Offset = "0xD7BCE0", VA = "0x180D7CAE0")]
	private long TimeToFrame(double s)
	{
		return default(long);
	}

	[Token(Token = "0x6008D5E")]
	[Address(RVA = "0xD7C2D0", Offset = "0xD7B4D0", VA = "0x180D7C2D0")]
	private int SetFrameMarker(double second)
	{
		return default(int);
	}

	[Token(Token = "0x6008D5F")]
	[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
	public void SetOnMarkerChangerdCallback(Action<int, double> action)
	{
	}

	[Token(Token = "0x6008D60")]
	[Address(RVA = "0xD7B650", Offset = "0xD7A850", VA = "0x180D7B650")]
	private void KillFrameCheckCoroutine(Coroutine coroutine)
	{
	}

	[Token(Token = "0x6008D61")]
	[Address(RVA = "0xD7A7C0", Offset = "0xD799C0", VA = "0x180D7A7C0")]
	[IteratorStateMachine(typeof(_003CCheckFrame_003Ed__105))]
	private IEnumerator CheckFrame(double s)
	{
		return null;
	}

	[Token(Token = "0x6008D62")]
	[Address(RVA = "0xD7CEB0", Offset = "0xD7C0B0", VA = "0x180D7CEB0")]
	public MovieWidget2()
	{
	}
}
