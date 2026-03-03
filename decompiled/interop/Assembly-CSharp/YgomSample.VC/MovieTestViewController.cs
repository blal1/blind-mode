using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomGame.Movie;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomSample.VC;

[Token(Token = "0x2001DB9")]
public class MovieTestViewController : BaseMenuViewController
{
	[Token(Token = "0x2001DBA")]
	private enum LoopState
	{
		[Token(Token = "0x40104FB")]
		Stop,
		[Token(Token = "0x40104FC")]
		Loop,
		[Token(Token = "0x40104FD")]
		Continue
	}

	[Token(Token = "0x2001DBD")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		[Token(Token = "0x4010506")]
		[FieldOffset(Offset = "0x10")]
		public MovieTestViewController _003C_003E4__this;

		[Token(Token = "0x4010507")]
		[FieldOffset(Offset = "0x18")]
		public List<MovieData> currentList;

		[Token(Token = "0x4010508")]
		[FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__1;

		[Token(Token = "0x600BE26")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[Token(Token = "0x600BE27")]
		[Address(RVA = "0x593D70", Offset = "0x592F70", VA = "0x180593D70")]
		internal void _003CLoadMovieList_003Eb__0(int res)
		{
		}

		[Token(Token = "0x600BE28")]
		[Address(RVA = "0x593FB0", Offset = "0x5931B0", VA = "0x180593FB0")]
		internal void _003CLoadMovieList_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2001DBF")]
	[CompilerGenerated]
	private sealed class _003CInitialSetting_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401050B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401050C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x401050D")]
		[FieldOffset(Offset = "0x20")]
		public MovieTestViewController _003C_003E4__this;

		[Token(Token = "0x17001C2F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BE2E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C30")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BE30")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BE2B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialSetting_003Ed__43(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BE2C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BE2D")]
		[Address(RVA = "0x58F840", Offset = "0x58EA40", VA = "0x18058F840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BE2F")]
		[Address(RVA = "0x58FA60", Offset = "0x58EC60", VA = "0x18058FA60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001DC0")]
	[CompilerGenerated]
	private sealed class _003CLoadMovieList_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401050E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401050F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010510")]
		[FieldOffset(Offset = "0x20")]
		public MovieTestViewController _003C_003E4__this;

		[Token(Token = "0x4010511")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		[Token(Token = "0x17001C31")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BE34")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C32")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BE36")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BE31")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadMovieList_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BE32")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BE33")]
		[Address(RVA = "0x58FD90", Offset = "0x58EF90", VA = "0x18058FD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BE35")]
		[Address(RVA = "0x590570", Offset = "0x58F770", VA = "0x180590570", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40104D4")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string LABEL_MOVIE_CONTAINER;

	[Token(Token = "0x40104D5")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string counterLabel;

	[Token(Token = "0x40104D6")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string buttonsLabel;

	[Token(Token = "0x40104D7")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string playButtonLabel;

	[Token(Token = "0x40104D8")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string listButtonLabel;

	[Token(Token = "0x40104D9")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string stopButtonLabel;

	[Token(Token = "0x40104DA")]
	[FieldOffset(Offset = "0x100")]
	private readonly string switchButtonLabel;

	[Token(Token = "0x40104DB")]
	[FieldOffset(Offset = "0x108")]
	private readonly string buttonTextLabel;

	[Token(Token = "0x40104DC")]
	[FieldOffset(Offset = "0x110")]
	private readonly string loopButtonLabel;

	[Token(Token = "0x40104DD")]
	[FieldOffset(Offset = "0x118")]
	private readonly string r1ButtonLabel;

	[Token(Token = "0x40104DE")]
	[FieldOffset(Offset = "0x120")]
	private readonly string l1ButtonLabel;

	[Token(Token = "0x40104DF")]
	[FieldOffset(Offset = "0x128")]
	private readonly string cwRemoteListPath;

	[Token(Token = "0x40104E0")]
	[FieldOffset(Offset = "0x130")]
	private readonly string cwURLKey;

	[Token(Token = "0x40104E1")]
	[FieldOffset(Offset = "0x138")]
	private readonly string cwFolderKey;

	[Token(Token = "0x40104E2")]
	[FieldOffset(Offset = "0x140")]
	private readonly string cwNameKey;

	[Token(Token = "0x40104E3")]
	[FieldOffset(Offset = "0x148")]
	private ElementObjectManager buttonEOM;

	[Token(Token = "0x40104E4")]
	private const float analogInputSence = 0.005f;

	[Token(Token = "0x40104E5")]
	[FieldOffset(Offset = "0x150")]
	private MovieData currentMovie;

	[Token(Token = "0x40104E6")]
	[FieldOffset(Offset = "0x158")]
	private string BaseURL;

	[Token(Token = "0x40104E7")]
	[FieldOffset(Offset = "0x160")]
	private string Folder;

	[Token(Token = "0x40104E8")]
	[FieldOffset(Offset = "0x168")]
	private List<MovieData> localList;

	[Token(Token = "0x40104E9")]
	[FieldOffset(Offset = "0x170")]
	private List<MovieData> remoteList;

	[Token(Token = "0x40104EA")]
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	private FrameMarkAsset frameMarkAsset;

	[Token(Token = "0x40104EB")]
	[FieldOffset(Offset = "0x180")]
	private MovieWidget2 m_MovieWidget;

	[Token(Token = "0x40104EC")]
	[FieldOffset(Offset = "0x188")]
	private GameObject counter;

	[Token(Token = "0x40104ED")]
	[FieldOffset(Offset = "0x190")]
	private TextMeshProUGUI text;

	[Token(Token = "0x40104EE")]
	[FieldOffset(Offset = "0x198")]
	private ExtendedTextMeshProUGUI switchText;

	[Token(Token = "0x40104EF")]
	[FieldOffset(Offset = "0x1A0")]
	private ExtendedTextMeshProUGUI playButtonText;

	[Token(Token = "0x40104F0")]
	[FieldOffset(Offset = "0x1A8")]
	private ExtendedTextMeshProUGUI loopButtonText;

	[Token(Token = "0x40104F1")]
	[FieldOffset(Offset = "0x1B0")]
	private Slider slider;

	[Token(Token = "0x40104F2")]
	[FieldOffset(Offset = "0x1B8")]
	private bool isClickHandle;

	[Token(Token = "0x40104F3")]
	[FieldOffset(Offset = "0x1B9")]
	private bool isAnalogInput;

	[Token(Token = "0x40104F4")]
	[FieldOffset(Offset = "0x1BA")]
	private bool isRemote;

	[Token(Token = "0x40104F5")]
	[FieldOffset(Offset = "0x1C0")]
	private SelectionButton selectionButton;

	[Token(Token = "0x40104F6")]
	[FieldOffset(Offset = "0x1C8")]
	private LoopState loopState;

	[Token(Token = "0x40104F7")]
	[FieldOffset(Offset = "0x1CC")]
	private int playNum;

	[Token(Token = "0x40104F8")]
	[FieldOffset(Offset = "0x1D0")]
	private bool isEndCreated;

	[Token(Token = "0x40104F9")]
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private RenderTexture targetTexture;

	[Token(Token = "0x600BE05")]
	[Address(RVA = "0x58BB70", Offset = "0x58AD70", VA = "0x18058BB70")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BE06")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void Start()
	{
	}

	[Token(Token = "0x600BE07")]
	[Address(RVA = "0x58C550", Offset = "0x58B750", VA = "0x18058C550", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600BE08")]
	[Address(RVA = "0x58C610", Offset = "0x58B810", VA = "0x18058C610", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600BE09")]
	[Address(RVA = "0x58C090", Offset = "0x58B290", VA = "0x18058C090")]
	[IteratorStateMachine(typeof(_003CInitialSetting_003Ed__43))]
	private IEnumerator InitialSetting()
	{
		return null;
	}

	[Token(Token = "0x600BE0A")]
	[Address(RVA = "0x58D940", Offset = "0x58CB40", VA = "0x18058D940")]
	private void Update()
	{
	}

	[Token(Token = "0x600BE0B")]
	[Address(RVA = "0x58D5B0", Offset = "0x58C7B0", VA = "0x18058D5B0")]
	private string SecondsToMinites(double s)
	{
		return null;
	}

	[Token(Token = "0x600BE0C")]
	[Address(RVA = "0x58D710", Offset = "0x58C910", VA = "0x18058D710")]
	private void ShowMovieList()
	{
	}

	[Token(Token = "0x600BE0D")]
	[Address(RVA = "0x58C380", Offset = "0x58B580", VA = "0x18058C380")]
	[IteratorStateMachine(typeof(_003CLoadMovieList_003Ed__47))]
	private IEnumerator LoadMovieList()
	{
		return null;
	}

	[Token(Token = "0x600BE0E")]
	[Address(RVA = "0x58D7D0", Offset = "0x58C9D0", VA = "0x18058D7D0")]
	private void ToggleMoviePath()
	{
	}

	[Token(Token = "0x600BE0F")]
	[Address(RVA = "0x58BBE0", Offset = "0x58ADE0", VA = "0x18058BBE0")]
	private void ChangeLoopState()
	{
	}

	[Token(Token = "0x600BE10")]
	[Address(RVA = "0x58BD00", Offset = "0x58AF00", VA = "0x18058BD00")]
	private void EndMovie()
	{
	}

	[Token(Token = "0x600BE11")]
	[Address(RVA = "0x58D860", Offset = "0x58CA60", VA = "0x18058D860")]
	private void TouchSliderWithPad(Vector2 v)
	{
	}

	[Token(Token = "0x600BE12")]
	[Address(RVA = "0x58C3F0", Offset = "0x58B5F0", VA = "0x18058C3F0")]
	private void MovieError(string message)
	{
	}

	[Token(Token = "0x600BE13")]
	[Address(RVA = "0x58C100", Offset = "0x58B300", VA = "0x18058C100")]
	private void LoadLocalMovie(string path)
	{
	}

	[Token(Token = "0x600BE14")]
	[Address(RVA = "0x58BCF0", Offset = "0x58AEF0", VA = "0x18058BCF0")]
	private MovieWidget2.LoadType ConvertLoadType(MovieWidget.LoadType type)
	{
		return default(MovieWidget2.LoadType);
	}

	[Token(Token = "0x600BE15")]
	[Address(RVA = "0x58DC10", Offset = "0x58CE10", VA = "0x18058DC10")]
	public MovieTestViewController()
	{
	}
}
