using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.TextIDs;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x2001311")]
public class ProfileDataViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001312")]
	internal class ProfileDataInfo
	{
		[Token(Token = "0x400BF25")]
		[FieldOffset(Offset = "0x10")]
		internal IDS_RECORD record;

		[Token(Token = "0x400BF26")]
		[FieldOffset(Offset = "0x18")]
		internal long value;

		[Token(Token = "0x600765C")]
		[Address(RVA = "0xBD55C0", Offset = "0xBD47C0", VA = "0x180BD55C0")]
		public ProfileDataInfo(IDS_RECORD record, long value)
		{
		}
	}

	[Token(Token = "0x400BF14")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_DATA_LABEL;

	[Token(Token = "0x400BF15")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_CAUTION_LABEL;

	[Token(Token = "0x400BF16")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TEXT_TITLE_LABEL;

	[Token(Token = "0x400BF17")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TEXT_VALUE_LABEL;

	[Token(Token = "0x400BF18")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string RANK_HISTORY;

	[Token(Token = "0x400BF19")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string SEASON_POINT;

	[Token(Token = "0x400BF1A")]
	[FieldOffset(Offset = "0x100")]
	private InfinityScrollView isvData;

	[Token(Token = "0x400BF1B")]
	[FieldOffset(Offset = "0x108")]
	private SelectionButton m_CautionButton;

	[Token(Token = "0x400BF1C")]
	[FieldOffset(Offset = "0x110")]
	private SelectionButtonUntouchable m_DataAreaButton;

	[Token(Token = "0x400BF1D")]
	[FieldOffset(Offset = "0x118")]
	private long totalPvP;

	[Token(Token = "0x400BF1E")]
	[FieldOffset(Offset = "0x120")]
	private long pcode;

	[Token(Token = "0x400BF1F")]
	[FieldOffset(Offset = "0x128")]
	private List<object> rankHistory;

	[Token(Token = "0x400BF20")]
	[FieldOffset(Offset = "0x130")]
	private Dictionary<string, object> seasonPoint;

	[Token(Token = "0x400BF21")]
	[FieldOffset(Offset = "0x138")]
	private List<ProfileDataInfo> dataInfos;

	[Token(Token = "0x400BF22")]
	[FieldOffset(Offset = "0x140")]
	private int rankHeadIndex;

	[Token(Token = "0x400BF23")]
	[FieldOffset(Offset = "0x144")]
	private int seasonPtHeadIndex;

	[Token(Token = "0x400BF24")]
	[FieldOffset(Offset = "0x148")]
	private int dataInfoHeadIndex;

	[Token(Token = "0x17001273")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007650")]
		[Address(RVA = "0xBCBF00", Offset = "0xBCB100", VA = "0x180BCBF00", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007651")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007652")]
	[Address(RVA = "0xBCA510", Offset = "0xBC9710", VA = "0x180BCA510", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007653")]
	[Address(RVA = "0xBCB2C0", Offset = "0xBCA4C0", VA = "0x180BCB2C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6007654")]
	[Address(RVA = "0xBCB6B0", Offset = "0xBCA8B0", VA = "0x180BCB6B0")]
	private void UpdateProfileData(Dictionary<string, object> recordDict)
	{
	}

	[Token(Token = "0x6007655")]
	[Address(RVA = "0xBCA860", Offset = "0xBC9A60", VA = "0x180BCA860")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6007656")]
	[Address(RVA = "0xBCA780", Offset = "0xBC9980", VA = "0x180BCA780")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6007657")]
	[Address(RVA = "0xBCB180", Offset = "0xBCA380", VA = "0x180BCB180")]
	private void OpenCautionDialog()
	{
	}

	[Token(Token = "0x6007658")]
	[Address(RVA = "0xBCBDB0", Offset = "0xBCAFB0", VA = "0x180BCBDB0")]
	public ProfileDataViewController()
	{
	}
}
