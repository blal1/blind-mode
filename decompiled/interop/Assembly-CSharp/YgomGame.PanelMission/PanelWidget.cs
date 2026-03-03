using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.PanelMission;

[Token(Token = "0x2000C2C")]
public class PanelWidget : ElementWidgetBase
{
	[Token(Token = "0x4009A73")]
	private const string k_ELabel_TitleText = "TitleText";

	[Token(Token = "0x4009A74")]
	private const string k_ELabel_TitleLabelText = "TitleLabelText";

	[Token(Token = "0x4009A75")]
	private const string k_ELabel_TitleLabelTextReceived = "TitleLabelTextReceived";

	[Token(Token = "0x4009A76")]
	private const string k_ELabel_ProgressText = "ProgressText";

	[Token(Token = "0x4009A77")]
	private const string k_ELabel_HintButton = "HintButton";

	[Token(Token = "0x4009A78")]
	private const string k_ELabel_HintButton_ShortcutIcon = "HintButton/ShortcutIconGroup";

	[Token(Token = "0x4009A79")]
	private const string k_ELabel_RewardWidget = "RewardWidget";

	[Token(Token = "0x4009A7A")]
	private const string k_ELabel_RewardWidget_ThumbHolder = "RewardWidget/RewardThumbHolder";

	[Token(Token = "0x4009A7B")]
	private const string k_ELabel_RewardWidget_NumText = "RewardWidget/RewardNumText";

	[Token(Token = "0x4009A7C")]
	private const string k_ELabel_ReceivedBase = "ReceivedBase";

	[Token(Token = "0x4009A7D")]
	private const string k_ELabel_ReceivedIcon = "RewardWidget/ReceivedIcon";

	[Token(Token = "0x4009A7E")]
	internal const string k_SLabel_OnRecieved = "SE_MISSION_CHECK";

	[Token(Token = "0x4009A7F")]
	internal const string k_TLabel_OnRecieved = "OnRecieved";

	[Token(Token = "0x4009A80")]
	internal const string k_OGLabel_Default = "Default";

	[Token(Token = "0x4009A81")]
	internal const string k_OGLabel_Receivable = "Receivable";

	[Token(Token = "0x4009A82")]
	internal const string k_OGLabel_Grayout = "Grayout";

	[Token(Token = "0x17000A12")]
	public TMP_Text titleText
	{
		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0x945670", Offset = "0x944870", VA = "0x180945670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A13")]
	public bool existsTitleLabelText
	{
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x945290", Offset = "0x944490", VA = "0x180945290")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A14")]
	public TMP_Text titleLabelText
	{
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x945610", Offset = "0x944810", VA = "0x180945610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A15")]
	public TMP_Text titleLabelTextReceived
	{
		[Token(Token = "0x6004A60")]
		[Address(RVA = "0x9455B0", Offset = "0x9447B0", VA = "0x1809455B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A16")]
	public bool existsProgressText
	{
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x945240", Offset = "0x944440", VA = "0x180945240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A17")]
	public TMP_Text progressText
	{
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x945400", Offset = "0x944600", VA = "0x180945400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A18")]
	public PlatformOverriderGroup ovGroup
	{
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x9453A0", Offset = "0x9445A0", VA = "0x1809453A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A19")]
	public SelectionButton button
	{
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x9451E0", Offset = "0x9443E0", VA = "0x1809451E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1A")]
	public GameObject rewardThumbHolder
	{
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x945560", Offset = "0x944760", VA = "0x180945560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1B")]
	public TMP_Text rewardNumText
	{
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x945500", Offset = "0x944700", VA = "0x180945500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1C")]
	public GameObject receivedBase
	{
		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x945460", Offset = "0x944660", VA = "0x180945460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1D")]
	public GameObject receivedIcon
	{
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x9454B0", Offset = "0x9446B0", VA = "0x1809454B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1E")]
	public SelectionButton hintButton
	{
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x945340", Offset = "0x944540", VA = "0x180945340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1F")]
	public ShortcutIcon hintButtonShortcutIcon
	{
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x9452E0", Offset = "0x9444E0", VA = "0x1809452E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004A6B")]
	[Address(RVA = "0x8847B0", Offset = "0x8839B0", VA = "0x1808847B0")]
	public PanelWidget(ElementObjectManager eom)
	{
	}
}
