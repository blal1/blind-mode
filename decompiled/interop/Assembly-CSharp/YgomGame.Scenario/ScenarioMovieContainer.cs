using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Movie;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A7A")]
public class ScenarioMovieContainer : ScenarioContainerBase
{
	[Token(Token = "0x4009235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly int k_LocatorLen;

	[Token(Token = "0x4009236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLocatorFormat;

	[Token(Token = "0x4009237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string k_PrefLabelBg;

	[Token(Token = "0x4009238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Dictionary<string, (GameObject, MovieWidget)> m_CreatedObjectMap;

	[Token(Token = "0x4009239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Transform[] m_BackUILocators;

	[Token(Token = "0x400923A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public readonly ElementObjectManager backUIEom;

	[Token(Token = "0x400923B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject m_MovieUI;

	[Token(Token = "0x400923C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Slider seekBar;

	[Token(Token = "0x400923D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private SelectionButton seekBarHandle;

	[Token(Token = "0x400923E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ElementObjectManager movieToggleEom;

	[Token(Token = "0x400923F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public SelectionButton movieToggleButton;

	[Token(Token = "0x4009240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public SelectionButton movieToggleButtonCenter;

	[Token(Token = "0x4009241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RectTransform movieStateImagePlay;

	[Token(Token = "0x4009242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private RectTransform movieStateImagePause;

	[Token(Token = "0x4009243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private RectTransform movieStateIconPlay;

	[Token(Token = "0x4009244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private RectTransform movieStateIconPause;

	[Token(Token = "0x4009245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private RectTransform movieToggleButtonIconPlay;

	[Token(Token = "0x4009246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private RectTransform movieToggleButtonIconPause;

	[Token(Token = "0x4009247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RectTransform movieStatePlay;

	[Token(Token = "0x4009248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private RectTransform movieStatePause;

	[Token(Token = "0x4009249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ElementObjectManager m_ArrowSkip;

	[Token(Token = "0x400924A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private ElementObjectManager m_ArrowBack;

	[Token(Token = "0x400924B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<ElementObjectManager> m_FooterDescList;

	[Token(Token = "0x400924C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool isClickHandle;

	[Token(Token = "0x400924D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private TextMeshProUGUI m_MovieText;

	[Token(Token = "0x400924E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float movieLength;

	[Token(Token = "0x400924F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string lengthText;

	[Token(Token = "0x4009250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private MovieWidget.MovieState returnState;

	[Token(Token = "0x4009251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private MovieWidget m_MovieWidget;

	[Token(Token = "0x4009252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Action<string, GameObject> onCreateCallback;

	[Token(Token = "0x4009253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Action onDestroyMovieCallback;

	[Token(Token = "0x4009254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Action onLoadedCallback;

	[Token(Token = "0x4009255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Action onClickedCallback;

	[Token(Token = "0x4009256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Action onDoubleclickedCallbackRight;

	[Token(Token = "0x4009257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Action onDoubleclickedCallbackLeft;

	[Token(Token = "0x4009258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Action onClickAnyButton;

	[Token(Token = "0x4009259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public TextMeshProUGUI subtitle;

	[Token(Token = "0x400925A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public SelectionButton volumeButton;

	[Token(Token = "0x400925B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private bool m_IsVisibleUI;

	[Token(Token = "0x400925C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
	public bool m_IsOpenDialog;

	[Token(Token = "0x400925D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private float m_SkipTime;

	[Token(Token = "0x400925E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private string[] m_MovieStateText;

	[Token(Token = "0x400925F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public bool CanSkip;

	[Token(Token = "0x4009260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public float retryWait;

	[Token(Token = "0x4009261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public int limitError;

	[Token(Token = "0x1700089D")]
	public float SliderValue
	{
		[Token(Token = "0x600407A")]
		[Address(RVA = "0x88CAE0", Offset = "0x88BCE0", VA = "0x18088CAE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700089E")]
	public bool visibleUI
	{
		[Token(Token = "0x600407B")]
		[Address(RVA = "0x88C420", Offset = "0x88B620", VA = "0x18088C420")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x88CD70", Offset = "0x88BF70", VA = "0x18088CD70")]
		set
		{
		}
	}

	[Token(Token = "0x1700089F")]
	public bool isPlayMovie
	{
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x88C3F0", Offset = "0x88B5F0", VA = "0x18088C3F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008A0")]
	public float SkipTime
	{
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x88C3E0", Offset = "0x88B5E0", VA = "0x18088C3E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x88C470", Offset = "0x88B670", VA = "0x18088C470")]
		set
		{
		}
	}

	[Token(Token = "0x6004080")]
	[Address(RVA = "0x88C430", Offset = "0x88B630", VA = "0x18088C430")]
	public bool isBgLabel(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6004081")]
	[Address(RVA = "0x88B850", Offset = "0x88AA50", VA = "0x18088B850")]
	public ScenarioMovieContainer(ElementObjectManager backUIEom, ElementObjectManager footerEom)
	{
	}

	[Token(Token = "0x6004082")]
	[Address(RVA = "0x88AE10", Offset = "0x88A010", VA = "0x18088AE10")]
	private void SeekBarHandle_onExit(SelectionItem this_item)
	{
	}

	[Token(Token = "0x6004083")]
	[Address(RVA = "0x88AF70", Offset = "0x88A170", VA = "0x18088AF70")]
	public void ToggleStateIcon()
	{
	}

	[Token(Token = "0x6004084")]
	[Address(RVA = "0x889A30", Offset = "0x888C30", VA = "0x180889A30")]
	public MovieWidget CreateMovieWidget(string label, float length, string URL, MovieWidget.LoadType type, Action<GameObject> onComplete, Action<string> onError, [Optional] FrameMarkAsset fma, float retryWait = 0f, int limitError = 0)
	{
		return null;
	}

	[Token(Token = "0x6004085")]
	[Address(RVA = "0x88A430", Offset = "0x889630", VA = "0x18088A430")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6004086")]
	[Address(RVA = "0x88A350", Offset = "0x889550", VA = "0x18088A350")]
	public (GameObject, MovieWidget) GetCreatedGameObject(string label)
	{
		return default((GameObject, MovieWidget));
	}

	[Token(Token = "0x6004087")]
	[Address(RVA = "0x88A1C0", Offset = "0x8893C0", VA = "0x18088A1C0")]
	public GameObject[] FindBGObjects()
	{
		return null;
	}

	[Token(Token = "0x6004088")]
	[Address(RVA = "0x88A0D0", Offset = "0x8892D0", VA = "0x18088A0D0")]
	public bool DestroyPrefabObject(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6004089")]
	[Address(RVA = "0x88ACD0", Offset = "0x889ED0", VA = "0x18088ACD0")]
	public void PlayShowUI(bool immediate = false)
	{
	}

	[Token(Token = "0x600408A")]
	[Address(RVA = "0x88AB90", Offset = "0x889D90", VA = "0x18088AB90")]
	public void PlayHideUI(bool immediate = false)
	{
	}

	[Token(Token = "0x600408B")]
	[Address(RVA = "0x88AEE0", Offset = "0x88A0E0", VA = "0x18088AEE0")]
	public void SetSubtitleVisible(bool visible)
	{
	}

	[Token(Token = "0x600408C")]
	[Address(RVA = "0x88AE50", Offset = "0x88A050", VA = "0x18088AE50")]
	public void SetFooterActive(bool isActive)
	{
	}
}
