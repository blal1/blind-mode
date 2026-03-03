using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

[Token(Token = "0x2000096")]
public class WCSFinal_TimerSettingViewController : BaseMenuViewController
{
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0xD0")]
	private IReadOnlyList<int> hourlist;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0xD8")]
	private IReadOnlyList<int> minute_secondlist;

	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0xE0")]
	private InfinityScrollView hourscrollView;

	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0xE8")]
	private InfinityScrollView minutescrollView;

	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0xF0")]
	private InfinityScrollView secondscrollView;

	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0xF8")]
	private ExtendedTextMeshProUGUI texttimer;

	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x100")]
	private int selectedhour;

	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x104")]
	private int selectedminute;

	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x108")]
	private int selectedsecond;

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x401140", Offset = "0x400340", VA = "0x180401140", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void OnCreatedTimeEntity(GameObject go)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x401810", Offset = "0x400A10", VA = "0x180401810")]
	public void OnUpdateHourEntity(GameObject go, int index)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x401BE0", Offset = "0x400DE0", VA = "0x180401BE0")]
	public void OnUpdateMinuteEntity(GameObject go, int index)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x401FB0", Offset = "0x4011B0", VA = "0x180401FB0")]
	public void OnUpdateSecondEntity(GameObject go, int index)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x401050", Offset = "0x400250", VA = "0x180401050")]
	public void ChangeSelectedButton(ElementObjectManager tmp, int btnindex, ref int selected)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x4024A0", Offset = "0x4016A0", VA = "0x1804024A0")]
	private void SetTimeText()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x402380", Offset = "0x401580", VA = "0x180402380")]
	private string ReadTimeToText(float time)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x402A60", Offset = "0x401C60", VA = "0x180402A60")]
	public WCSFinal_TimerSettingViewController()
	{
	}
}
