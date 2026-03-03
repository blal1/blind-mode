using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001894")]
public class DuelEndMessage : MonoBehaviour
{
	[Token(Token = "0x2001895")]
	public enum FollowButtonStatus
	{
		[Token(Token = "0x400E69D")]
		ShowEnable,
		[Token(Token = "0x400E69E")]
		ShowDisableNoop,
		[Token(Token = "0x400E69F")]
		ShowDisableFollowing,
		[Token(Token = "0x400E6A0")]
		Hide
	}

	[Token(Token = "0x400E67B")]
	[FieldOffset(Offset = "0x20")]
	private SelectionButton nextButton;

	[Token(Token = "0x400E67C")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text nextButtonText;

	[Token(Token = "0x400E67D")]
	[FieldOffset(Offset = "0x30")]
	private GameObject messageBase;

	[Token(Token = "0x400E67E")]
	[FieldOffset(Offset = "0x38")]
	private ExtendedTextMeshProUGUI messageText;

	[Token(Token = "0x400E67F")]
	[FieldOffset(Offset = "0x40")]
	private ExtendedTextMeshProUGUI player0Name;

	[Token(Token = "0x400E680")]
	[FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI player1Name;

	[Token(Token = "0x400E681")]
	[FieldOffset(Offset = "0x50")]
	private Transform player0Icon;

	[Token(Token = "0x400E682")]
	[FieldOffset(Offset = "0x58")]
	private Transform player1Icon;

	[Token(Token = "0x400E683")]
	[FieldOffset(Offset = "0x60")]
	private SelectionButton profileCard0Button;

	[Token(Token = "0x400E684")]
	[FieldOffset(Offset = "0x68")]
	private SelectionButton profileCard1Button;

	[Token(Token = "0x400E685")]
	[FieldOffset(Offset = "0x70")]
	private GameObject player0PlatformRoot;

	[Token(Token = "0x400E686")]
	[FieldOffset(Offset = "0x78")]
	private GameObject player1PlatformRoot;

	[Token(Token = "0x400E687")]
	[FieldOffset(Offset = "0x80")]
	private Image player0PlatformIcon;

	[Token(Token = "0x400E688")]
	[FieldOffset(Offset = "0x88")]
	private Image player1PlatformIcon;

	[Token(Token = "0x400E689")]
	[FieldOffset(Offset = "0x90")]
	private TMP_Text player0PlatformID;

	[Token(Token = "0x400E68A")]
	[FieldOffset(Offset = "0x98")]
	private TMP_Text player1PlatformID;

	[Token(Token = "0x400E68B")]
	[FieldOffset(Offset = "0xA0")]
	private SelectionButton retryButton;

	[Token(Token = "0x400E68C")]
	[FieldOffset(Offset = "0xA8")]
	private SelectionButton followButton;

	[Token(Token = "0x400E68D")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject player0WinIcon;

	[Token(Token = "0x400E68E")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject player1WinIcon;

	[Token(Token = "0x400E68F")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject autoGoNextMessageRoot;

	[Token(Token = "0x400E690")]
	[FieldOffset(Offset = "0xC8")]
	private TMP_Text autoGoNextMessageText;

	[Token(Token = "0x400E691")]
	[FieldOffset(Offset = "0xD0")]
	private DuelClient host;

	[Token(Token = "0x400E692")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<string, object> profileDataMyself;

	[Token(Token = "0x400E693")]
	[FieldOffset(Offset = "0xE0")]
	private Dictionary<string, object> profileDataRival;

	[Token(Token = "0x400E694")]
	[FieldOffset(Offset = "0xE8")]
	private long pcodeMyself;

	[Token(Token = "0x400E695")]
	[FieldOffset(Offset = "0xF0")]
	private long pcodeRival;

	[Token(Token = "0x400E696")]
	[FieldOffset(Offset = "0xF8")]
	private string followButtonPopupText;

	[Token(Token = "0x400E697")]
	[FieldOffset(Offset = "0x100")]
	private FollowButtonStatus followButtonStatus;

	[Token(Token = "0x400E698")]
	[FieldOffset(Offset = "0x104")]
	private bool followed;

	[Token(Token = "0x400E69A")]
	private const string currentPlatformIconPath = "Images/PlatformIcon/<_PLATFORM_>/CurrentPlatformS";

	[Token(Token = "0x170017F7")]
	public GameObject profileCardObj
	{
		[Token(Token = "0x6009D89")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009D8A")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017F8")]
	public static bool IsNextButtonClicked
	{
		[Token(Token = "0x6009D8C")]
		[Address(RVA = "0xEAC160", Offset = "0xEAB360", VA = "0x180EAC160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009D8B")]
		[Address(RVA = "0xEAC1A0", Offset = "0xEAB3A0", VA = "0x180EAC1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6009D8D")]
	[Address(RVA = "0xEAA320", Offset = "0xEA9520", VA = "0x180EAA320")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6009D8E")]
	[Address(RVA = "0xEABAD0", Offset = "0xEAACD0", VA = "0x180EABAD0")]
	public void Show()
	{
	}

	[Token(Token = "0x6009D8F")]
	[Address(RVA = "0x4AEA80", Offset = "0x4ADC80", VA = "0x1804AEA80")]
	public void Hide()
	{
	}

	[Token(Token = "0x6009D90")]
	[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190")]
	public bool IsShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6009D91")]
	[Address(RVA = "0xEAAFF0", Offset = "0xEAA1F0", VA = "0x180EAAFF0")]
	public void Play(string label)
	{
	}

	[Token(Token = "0x6009D92")]
	[Address(RVA = "0xEAAB70", Offset = "0xEA9D70", VA = "0x180EAAB70")]
	public bool IsPlaying(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6009D93")]
	[Address(RVA = "0xEAAE30", Offset = "0xEAA030", VA = "0x180EAAE30")]
	private void OnNextButton()
	{
	}

	[Token(Token = "0x6009D94")]
	[Address(RVA = "0xEAAFB0", Offset = "0xEAA1B0", VA = "0x180EAAFB0")]
	private void OnRetryButton()
	{
	}

	[Token(Token = "0x6009D95")]
	[Address(RVA = "0xEAACF0", Offset = "0xEA9EF0", VA = "0x180EAACF0")]
	private void OnFollowButton()
	{
	}

	[Token(Token = "0x6009D96")]
	[Address(RVA = "0xEAABF0", Offset = "0xEA9DF0", VA = "0x180EAABF0")]
	private void OnClickProfileCardButton(Dictionary<string, object> profileData)
	{
	}

	[Token(Token = "0x6009D97")]
	[Address(RVA = "0xEAB220", Offset = "0xEAA420", VA = "0x180EAB220")]
	public void Setup(DuelClient host, string message, bool dispProfileCard, bool isOnlineMode, bool isReplayMode, string userNameMyself, int iconIDMyself, int frameIDMyself, string onlineIDMyself, bool isSameOSMyself, Dictionary<string, object> profileDataMyself, bool winMyself, string userNameRival, int iconIDRival, int frameIDRival, string onlineIDRival, bool isSameOSRival, Dictionary<string, object> profileDataRival, bool winRival, bool disp, bool showRetryButton, int playeridMyself, int playeridRival, bool showAutoGoNext, bool hidePlayerID, FollowButtonStatus followButtonStatus, string followButtonPopupText, long pcodeMyself, long pcodeRival)
	{
	}

	[Token(Token = "0x6009D98")]
	[Address(RVA = "0xEAB0E0", Offset = "0xEAA2E0", VA = "0x180EAB0E0")]
	private void SetFollowButtonColor(FollowButtonStatus status)
	{
	}

	[Token(Token = "0x6009D99")]
	[Address(RVA = "0xEAB160", Offset = "0xEAA360", VA = "0x180EAB160")]
	private void SetMessage(string message, bool disp = true)
	{
	}

	[Token(Token = "0x6009D9A")]
	[Address(RVA = "0xEAC070", Offset = "0xEAB270", VA = "0x180EAC070")]
	public void UpdateAutoGoNextMessage(float currentTime)
	{
	}

	[Token(Token = "0x6009D9B")]
	[Address(RVA = "0xEAB070", Offset = "0xEAA270", VA = "0x180EAB070")]
	public void SelectEndMessageBtn()
	{
	}

	[Token(Token = "0x6009D9C")]
	[Address(RVA = "0xEAB070", Offset = "0xEAA270", VA = "0x180EAB070")]
	private void SelectNearestBtnImpl()
	{
	}

	[Token(Token = "0x6009D9D")]
	[Address(RVA = "0xEAB0A0", Offset = "0xEAA2A0", VA = "0x180EAB0A0")]
	private void SetDispMessage(bool disp)
	{
	}

	[Token(Token = "0x6009D9E")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelEndMessage()
	{
	}
}
