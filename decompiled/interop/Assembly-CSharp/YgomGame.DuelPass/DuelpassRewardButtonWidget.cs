using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EE0")]
public class DuelpassRewardButtonWidget : ElementWidgetBase
{
	[Token(Token = "0x400A52C")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text countText;

	[Token(Token = "0x400A52D")]
	[FieldOffset(Offset = "0x30")]
	private GameObject rewardThumbHolder;

	[Token(Token = "0x400A52E")]
	[FieldOffset(Offset = "0x38")]
	private GameObject completedOutline;

	[Token(Token = "0x400A52F")]
	[FieldOffset(Offset = "0x40")]
	private GameObject progressOutline;

	[Token(Token = "0x400A530")]
	[FieldOffset(Offset = "0x48")]
	private GameObject recievableOutline;

	[Token(Token = "0x400A531")]
	[FieldOffset(Offset = "0x50")]
	private TMP_Text rewardNumText;

	[Token(Token = "0x400A532")]
	[FieldOffset(Offset = "0x58")]
	private GameObject recievedIcon;

	[Token(Token = "0x400A533")]
	[FieldOffset(Offset = "0x60")]
	private GameObject completedShadow;

	[Token(Token = "0x400A534")]
	[FieldOffset(Offset = "0x68")]
	private GameObject reward;

	[Token(Token = "0x400A535")]
	[FieldOffset(Offset = "0x70")]
	private GameObject body;

	[Token(Token = "0x400A536")]
	[FieldOffset(Offset = "0x78")]
	private GameObject blankLine;

	[Token(Token = "0x17000DEA")]
	public SelectionButton Button
	{
		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DEB")]
	public int RewardId
	{
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x5889C0", Offset = "0x587BC0", VA = "0x1805889C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005A26")]
		[Address(RVA = "0x588B20", Offset = "0x587D20", VA = "0x180588B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DEC")]
	public bool IsReceivable
	{
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x8A9920", Offset = "0x8A8B20", VA = "0x1808A9920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x9F3670", Offset = "0x9F2870", VA = "0x1809F3670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005A2A")]
	[Address(RVA = "0x9F3320", Offset = "0x9F2520", VA = "0x1809F3320")]
	public DuelpassRewardButtonWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005A2B")]
	[Address(RVA = "0x9F2C70", Offset = "0x9F1E70", VA = "0x1809F2C70")]
	public void Init(int rewardId)
	{
	}

	[Token(Token = "0x6005A2C")]
	[Address(RVA = "0x9F2FC0", Offset = "0x9F21C0", VA = "0x1809F2FC0")]
	public void Off()
	{
	}

	[Token(Token = "0x6005A2D")]
	[Address(RVA = "0x9F2FD0", Offset = "0x9F21D0", VA = "0x1809F2FD0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6005A2E")]
	[Address(RVA = "0x9F30C0", Offset = "0x9F22C0", VA = "0x1809F30C0")]
	private void UpdateButtonState(DuelpassRewardContext context)
	{
	}

	[Token(Token = "0x6005A2F")]
	[Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6005A30")]
	[Address(RVA = "0x9F3650", Offset = "0x9F2850", VA = "0x1809F3650")]
	public bool isReceivedCondi()
	{
		return default(bool);
	}
}
