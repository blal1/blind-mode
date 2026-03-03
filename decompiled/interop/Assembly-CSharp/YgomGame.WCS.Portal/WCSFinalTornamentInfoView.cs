using Il2CppDummyDll;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x200076B")]
public class WCSFinalTornamentInfoView : WCSBattleInfoBaseViewController.View
{
	[Token(Token = "0x200076C")]
	private enum SlotPos
	{
		[Token(Token = "0x400252E")]
		SEMI_FINAL_POS1,
		[Token(Token = "0x400252F")]
		SEMI_FINAL_POS2,
		[Token(Token = "0x4002530")]
		SEMI_FINAL_POS3,
		[Token(Token = "0x4002531")]
		SEMI_FINAL_POS4,
		[Token(Token = "0x4002532")]
		FINAL_POS1,
		[Token(Token = "0x4002533")]
		FINAL_POS2,
		[Token(Token = "0x4002534")]
		CHAMPION_POS
	}

	[Token(Token = "0x200076D")]
	private enum WinningLinePos
	{
		[Token(Token = "0x4002536")]
		SEMI_FINAL_LEFT,
		[Token(Token = "0x4002537")]
		SEMI_FINAL_RIGHT,
		[Token(Token = "0x4002538")]
		FINAL
	}

	[Token(Token = "0x200076E")]
	private enum WinningLineStatus
	{
		[Token(Token = "0x400253A")]
		NO_WINNER,
		[Token(Token = "0x400253B")]
		LEFT_WINNER,
		[Token(Token = "0x400253C")]
		RIGHT_WINNER
	}

	[Token(Token = "0x4002528")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager _topEom;

	[Token(Token = "0x4002529")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager[] _slotEoms;

	[Token(Token = "0x400252A")]
	[FieldOffset(Offset = "0x48")]
	private ElementObjectManager[] _winningLineEoms;

	[Token(Token = "0x400252B")]
	[FieldOffset(Offset = "0x50")]
	private SelectionButton[] _slotButtons;

	[Token(Token = "0x400252C")]
	[FieldOffset(Offset = "0x58")]
	private SelectionButton _ruleButton;

	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x738360", Offset = "0x737560", VA = "0x180738360")]
	private string GetDefaultSlotName(SlotPos pos)
	{
		return null;
	}

	[Token(Token = "0x60030A2")]
	[Address(RVA = "0x738230", Offset = "0x737430", VA = "0x180738230")]
	private string GetBattleStartDate(WinningLinePos pos)
	{
		return null;
	}

	[Token(Token = "0x60030A3")]
	[Address(RVA = "0x739160", Offset = "0x738360", VA = "0x180739160")]
	public WCSFinalTornamentInfoView(ElementObjectManager topEom, ElementObjectManager scrollEom, ViewControllerManager manager, bool helpBtnInvisible, bool isAdmin)
	{
	}

	[Token(Token = "0x60030A4")]
	[Address(RVA = "0x7390C0", Offset = "0x7382C0", VA = "0x1807390C0", Slot = "4")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x60030A5")]
	[Address(RVA = "0x7387F0", Offset = "0x7379F0", VA = "0x1807387F0")]
	private void SetChampionCrownIcon(bool disp)
	{
	}

	[Token(Token = "0x60030A6")]
	[Address(RVA = "0x738A70", Offset = "0x737C70", VA = "0x180738A70")]
	private void SetTeamInfo(SlotPos pos, string areaName, string teamName, string teamDesc)
	{
	}

	[Token(Token = "0x60030A7")]
	[Address(RVA = "0x738930", Offset = "0x737B30", VA = "0x180738930")]
	private void SetTeamIcon(SlotPos pos, string iconSpritePath)
	{
	}

	[Token(Token = "0x60030A8")]
	[Address(RVA = "0x738CE0", Offset = "0x737EE0", VA = "0x180738CE0")]
	private void SetTeamWinner(SlotPos pos, bool on)
	{
	}

	[Token(Token = "0x60030A9")]
	[Address(RVA = "0x738F80", Offset = "0x738180", VA = "0x180738F80")]
	private void SetWinningLineStatus(WinningLinePos pos, WinningLineStatus status)
	{
	}

	[Token(Token = "0x60030AA")]
	[Address(RVA = "0x7386F0", Offset = "0x7378F0", VA = "0x1807386F0")]
	private void SetBattleScoreText(WinningLinePos pos, string score)
	{
	}

	[Token(Token = "0x60030AB")]
	[Address(RVA = "0x738D90", Offset = "0x737F90", VA = "0x180738D90")]
	private void SetWinningLineStatusFromWinner(SlotPos winnerPos)
	{
	}

	[Token(Token = "0x60030AC")]
	[Address(RVA = "0x7385B0", Offset = "0x7377B0", VA = "0x1807385B0")]
	private void RegisterTeamSituationBtnAction(SlotPos pos, UnityAction callback, bool inDuel)
	{
	}

	[Token(Token = "0x60030AD")]
	[Address(RVA = "0x7371C0", Offset = "0x7363C0", VA = "0x1807371C0", Slot = "5")]
	protected override void ApplyFromCW(object baseData)
	{
	}

	[Token(Token = "0x60030AE")]
	[Address(RVA = "0x738540", Offset = "0x737740", VA = "0x180738540")]
	private void OpenExplanationPage()
	{
	}

	[Token(Token = "0x60030AF")]
	[Address(RVA = "0x738520", Offset = "0x737720", VA = "0x180738520")]
	private void OpenDuelRoom(int roomId)
	{
	}
}
