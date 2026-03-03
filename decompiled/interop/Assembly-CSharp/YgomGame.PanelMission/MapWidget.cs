using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.PanelMission;

[Token(Token = "0x2000C2A")]
public class MapWidget : ElementWidgetBase
{
	[Token(Token = "0x4009A67")]
	private const string k_ELabel_NameText = "NameText";

	[Token(Token = "0x4009A68")]
	private const string k_ELabel_LimitDateGroup = "LimitDateGroup";

	[Token(Token = "0x4009A69")]
	private const string k_ELabel_LimitDateText = "LimitDateText";

	[Token(Token = "0x4009A6A")]
	private const string k_ELabel_CompletePanel = "CompletePanel";

	[Token(Token = "0x4009A6B")]
	private const string k_ELabel_PanelReg = "Panel_0*(?<n>\\d+)";

	[Token(Token = "0x4009A6C")]
	private const string k_PLabel_BgId = "bgId";

	[Token(Token = "0x4009A6D")]
	internal const string k_TLabel_LimitDate_Default = "Default";

	[Token(Token = "0x4009A6E")]
	internal const string k_TLabel_LimitDate_Highlight = "Highlight";

	[Token(Token = "0x4009A6F")]
	[FieldOffset(Offset = "0x20")]
	private readonly PanelWidget m_CompletePanel;

	[Token(Token = "0x4009A70")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, PanelWidget> m_PanelMap;

	[Token(Token = "0x17000A0D")]
	public int bgId
	{
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x93F3A0", Offset = "0x93E5A0", VA = "0x18093F3A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A0E")]
	public TMP_Text nameText
	{
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x93F4C0", Offset = "0x93E6C0", VA = "0x18093F4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0F")]
	public GameObject limitDateGroup
	{
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x93F410", Offset = "0x93E610", VA = "0x18093F410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A10")]
	public TMP_Text limitDateText
	{
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x93F460", Offset = "0x93E660", VA = "0x18093F460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A11")]
	public PanelWidget completePanel
	{
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004A58")]
	[Address(RVA = "0x93ED00", Offset = "0x93DF00", VA = "0x18093ED00")]
	public PanelWidget GetPanelAt(int idx)
	{
		return null;
	}

	[Token(Token = "0x6004A59")]
	[Address(RVA = "0x93ED90", Offset = "0x93DF90", VA = "0x18093ED90")]
	public MapWidget(ElementObjectManager eom)
	{
	}
}
