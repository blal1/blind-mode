using System;
using Il2CppDummyDll;
using YgomGame.Colosseum;
using YgomGame.Menu;

namespace YgomGame.Solo;

[Token(Token = "0x20008ED")]
public class SoloStartProductionViewController : BaseMenuViewController
{
	[Token(Token = "0x20008EE")]
	public enum Step
	{
		[Token(Token = "0x40088D4")]
		None,
		[Token(Token = "0x40088D5")]
		Init,
		[Token(Token = "0x40088D6")]
		WaitInit,
		[Token(Token = "0x40088D7")]
		SelectTurn,
		[Token(Token = "0x40088D8")]
		WaitSelectTurn,
		[Token(Token = "0x40088D9")]
		Final,
		[Token(Token = "0x40088DA")]
		WaitFinal,
		[Token(Token = "0x40088DB")]
		StartDuel,
		[Token(Token = "0x40088DC")]
		End
	}

	[Token(Token = "0x40088CD")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string ROOT_RESULT_COINTOSS_LABEL;

	[Token(Token = "0x40088CE")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TXT_LABEL;

	[Token(Token = "0x40088CF")]
	[FieldOffset(Offset = "0xE0")]
	private Step step;

	[Token(Token = "0x40088D0")]
	[FieldOffset(Offset = "0xE4")]
	private int chapterID;

	[Token(Token = "0x40088D1")]
	[FieldOffset(Offset = "0xE8")]
	private ColosseumUtil.Turn playerTurn;

	[Token(Token = "0x40088D2")]
	[FieldOffset(Offset = "0xEC")]
	private SoloModeUtil.DeckType deckType;

	[Token(Token = "0x17000687")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x7C9320", Offset = "0x7C8520", VA = "0x1807C9320", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600358B")]
	[Address(RVA = "0x7C8830", Offset = "0x7C7A30", VA = "0x1807C8830", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600358C")]
	[Address(RVA = "0x7C88E0", Offset = "0x7C7AE0", VA = "0x1807C88E0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600358D")]
	[Address(RVA = "0x7C8910", Offset = "0x7C7B10", VA = "0x1807C8910", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600358E")]
	[Address(RVA = "0x7C8AF0", Offset = "0x7C7CF0", VA = "0x1807C8AF0", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x600358F")]
	[Address(RVA = "0x7C9210", Offset = "0x7C8410", VA = "0x1807C9210")]
	public void Update()
	{
	}

	[Token(Token = "0x6003590")]
	[Address(RVA = "0x7C86D0", Offset = "0x7C78D0", VA = "0x1807C86D0")]
	private void EvalEachSteps()
	{
	}

	[Token(Token = "0x6003591")]
	[Address(RVA = "0x7C8820", Offset = "0x7C7A20", VA = "0x1807C8820")]
	private void Init()
	{
	}

	[Token(Token = "0x6003592")]
	[Address(RVA = "0x7C9260", Offset = "0x7C8460", VA = "0x1807C9260")]
	private void WaitInit()
	{
	}

	[Token(Token = "0x6003593")]
	[Address(RVA = "0x7C8B10", Offset = "0x7C7D10", VA = "0x1807C8B10")]
	private void SelectTurn()
	{
	}

	[Token(Token = "0x6003594")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitSelectTurn()
	{
	}

	[Token(Token = "0x6003595")]
	[Address(RVA = "0x7C87F0", Offset = "0x7C79F0", VA = "0x1807C87F0")]
	private void Final()
	{
	}

	[Token(Token = "0x6003596")]
	[Address(RVA = "0x7C9220", Offset = "0x7C8420", VA = "0x1807C9220")]
	private void WaitFinal()
	{
	}

	[Token(Token = "0x6003597")]
	[Address(RVA = "0x7C9140", Offset = "0x7C8340", VA = "0x1807C9140")]
	private void StartDuel()
	{
	}

	[Token(Token = "0x6003598")]
	[Address(RVA = "0x7C8360", Offset = "0x7C7560", VA = "0x1807C8360")]
	private void DispFirstorSecond(ColosseumUtil.Turn turn)
	{
	}

	[Token(Token = "0x6003599")]
	[Address(RVA = "0x7C9290", Offset = "0x7C8490", VA = "0x1807C9290")]
	public SoloStartProductionViewController()
	{
	}
}
