using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20017BE")]
public static class TutorialUtil
{
	[Token(Token = "0x20017BF")]
	private enum CommandType
	{
		[Token(Token = "0x400DE4E")]
		None,
		[Token(Token = "0x400DE4F")]
		Summon,
		[Token(Token = "0x400DE50")]
		Set,
		[Token(Token = "0x400DE51")]
		Attack,
		[Token(Token = "0x400DE52")]
		SummonSp,
		[Token(Token = "0x400DE53")]
		Action,
		[Token(Token = "0x400DE54")]
		Pendulum
	}

	[Token(Token = "0x20017C0")]
	private class EffectInfo
	{
		[Token(Token = "0x400DE55")]
		[FieldOffset(Offset = "0x10")]
		public DuelTutorialData.EffectInfo info;

		[Token(Token = "0x400DE56")]
		[FieldOffset(Offset = "0x18")]
		public SimpleEffect effect;

		[Token(Token = "0x60095BD")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public EffectInfo(DuelTutorialData.EffectInfo info, SimpleEffect effect)
		{
		}
	}

	[Token(Token = "0x20017C1")]
	private class UIEffectInfo
	{
		[Token(Token = "0x400DE57")]
		[FieldOffset(Offset = "0x10")]
		public DuelTutorialData.EffectInfo info;

		[Token(Token = "0x400DE58")]
		[FieldOffset(Offset = "0x18")]
		public GameObject effect;

		[Token(Token = "0x60095BE")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public UIEffectInfo(DuelTutorialData.EffectInfo info, GameObject effect)
		{
		}
	}

	[Token(Token = "0x400DE39")]
	[FieldOffset(Offset = "0x0")]
	private static bool initialized;

	[Token(Token = "0x400DE3B")]
	[FieldOffset(Offset = "0x8")]
	private static DuelTutorialSetting setting;

	[Token(Token = "0x400DE3C")]
	[FieldOffset(Offset = "0x10")]
	private static DuelTutorialSetting setting2;

	[Token(Token = "0x400DE3D")]
	[FieldOffset(Offset = "0x18")]
	private static DuelTutorialData data;

	[Token(Token = "0x400DE3E")]
	[FieldOffset(Offset = "0x20")]
	private static DuelTutorialData.MessageInfo currentMessageInfo;

	[Token(Token = "0x400DE3F")]
	[FieldOffset(Offset = "0x28")]
	private static int currentMessageIndex;

	[Token(Token = "0x400DE40")]
	[FieldOffset(Offset = "0x30")]
	private static List<DuelTutorialData.MessageInfo> doneMessageInfoList;

	[Token(Token = "0x400DE41")]
	[FieldOffset(Offset = "0x38")]
	private static CommandType preDoCommand;

	[Token(Token = "0x400DE42")]
	[FieldOffset(Offset = "0x3C")]
	private static bool phaseStartStep;

	[Token(Token = "0x400DE44")]
	[FieldOffset(Offset = "0x48")]
	private static List<EffectInfo> playingEffectList;

	[Token(Token = "0x400DE45")]
	[FieldOffset(Offset = "0x50")]
	private static List<UIEffectInfo> playingUIEffectList;

	[Token(Token = "0x400DE46")]
	[FieldOffset(Offset = "0x58")]
	private static GameObject prefabUIEffect;

	[Token(Token = "0x400DE47")]
	private const string UIEffectLabelPhaseButton = "TutorialPhaseButtonUI";

	[Token(Token = "0x400DE48")]
	private const string UIEffectLabelCommand = "TutorialCommandUI";

	[Token(Token = "0x400DE49")]
	private const string UIEffectLabelCard = "TutorialCardUI";

	[Token(Token = "0x400DE4A")]
	private const string UIEffectLabelSquareButton = "TutorialSquareButtonUI";

	[Token(Token = "0x400DE4B")]
	private const string UIEffectLabelPulldownButton = "TutorialPulldownButtonUI";

	[Token(Token = "0x170016C9")]
	public static bool isReady
	{
		[Token(Token = "0x6009561")]
		[Address(RVA = "0xE44300", Offset = "0xE43500", VA = "0x180E44300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009562")]
		[Address(RVA = "0xE44410", Offset = "0xE43610", VA = "0x180E44410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170016CA")]
	private static DuelGameObjectManager goManager
	{
		[Token(Token = "0x6009563")]
		[Address(RVA = "0xE442B0", Offset = "0xE434B0", VA = "0x180E442B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009564")]
		[Address(RVA = "0xE443A0", Offset = "0xE435A0", VA = "0x180E443A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170016CB")]
	public static bool isTutorial
	{
		[Token(Token = "0x6009565")]
		[Address(RVA = "0xE44350", Offset = "0xE43550", VA = "0x180E44350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009566")]
		[Address(RVA = "0xE44470", Offset = "0xE43670", VA = "0x180E44470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6009567")]
	[Address(RVA = "0xE42C80", Offset = "0xE41E80", VA = "0x180E42C80")]
	private static void LoadTutorialSetting(Action onFinished)
	{
	}

	[Token(Token = "0x6009568")]
	[Address(RVA = "0xE41C60", Offset = "0xE40E60", VA = "0x180E41C60")]
	public static void InitializeTutorial(DuelGameObjectManager goManager, DuelClient host, Action onFinished)
	{
	}

	[Token(Token = "0x6009569")]
	[Address(RVA = "0xE41BA0", Offset = "0xE40DA0", VA = "0x180E41BA0")]
	public static void HideTutorialMessage()
	{
	}

	[Token(Token = "0x600956A")]
	[Address(RVA = "0xE43EE0", Offset = "0xE430E0", VA = "0x180E43EE0")]
	public static void TerminateTutorial()
	{
	}

	[Token(Token = "0x600956B")]
	[Address(RVA = "0xE43650", Offset = "0xE42850", VA = "0x180E43650")]
	private static void ShowCenterMessage(IList<string> textIDList, Action finishedCallback, float delay)
	{
	}

	[Token(Token = "0x600956C")]
	[Address(RVA = "0xE437D0", Offset = "0xE429D0", VA = "0x180E437D0")]
	private static void ShowHelp(string helpLabelPath, Action onFinished)
	{
	}

	[Token(Token = "0x600956D")]
	[Address(RVA = "0xE419C0", Offset = "0xE40BC0", VA = "0x180E419C0")]
	public static bool HelpExists()
	{
		return default(bool);
	}

	[Token(Token = "0x600956E")]
	[Address(RVA = "0xE41640", Offset = "0xE40840", VA = "0x180E41640")]
	public static string GetHelp()
	{
		return null;
	}

	[Token(Token = "0x600956F")]
	[Address(RVA = "0xE43E30", Offset = "0xE43030", VA = "0x180E43E30")]
	private static void ShowTopMessage(string textID)
	{
	}

	[Token(Token = "0x6009570")]
	[Address(RVA = "0xE41B20", Offset = "0xE40D20", VA = "0x180E41B20")]
	private static void HideTopMessage()
	{
	}

	[Token(Token = "0x6009571")]
	[Address(RVA = "0xE41AA0", Offset = "0xE40CA0", VA = "0x180E41AA0")]
	private static void HideCenterMessage()
	{
	}

	[Token(Token = "0x6009572")]
	[Address(RVA = "0xE430D0", Offset = "0xE422D0", VA = "0x180E430D0")]
	private static List<string> ParseTextIDs(IList<string> textIDs)
	{
		return null;
	}

	[Token(Token = "0x6009573")]
	[Address(RVA = "0xE42FF0", Offset = "0xE421F0", VA = "0x180E42FF0")]
	private static string ParseTextID(string textID)
	{
		return null;
	}

	[Token(Token = "0x6009574")]
	[Address(RVA = "0xE405A0", Offset = "0xE3F7A0", VA = "0x180E405A0")]
	public static void Check(DuelTutorialData.View view, Action finishedCallback)
	{
	}

	[Token(Token = "0x6009575")]
	[Address(RVA = "0xE40160", Offset = "0xE3F360", VA = "0x180E40160")]
	public static void CheckPhaseChange(Engine.Phase phase, Action finishedCallback)
	{
	}

	[Token(Token = "0x6009576")]
	[Address(RVA = "0xE40350", Offset = "0xE3F550", VA = "0x180E40350")]
	public static void CheckWaitInput(Action finishedCallback)
	{
	}

	[Token(Token = "0x6009577")]
	[Address(RVA = "0xE40300", Offset = "0xE3F500", VA = "0x180E40300")]
	public static void CheckTiming(Action finishedCallback)
	{
	}

	[Token(Token = "0x6009578")]
	[Address(RVA = "0xE43360", Offset = "0xE42560", VA = "0x180E43360")]
	public static void SetPhaseChanged()
	{
	}

	[Token(Token = "0x6009579")]
	[Address(RVA = "0xE433B0", Offset = "0xE425B0", VA = "0x180E433B0")]
	public static void SetPreDoCommand(Engine.CommandType commandType)
	{
	}

	[Token(Token = "0x600957A")]
	[Address(RVA = "0xE43300", Offset = "0xE42500", VA = "0x180E43300")]
	public static void ResetPreDoCommand()
	{
	}

	[Token(Token = "0x600957B")]
	[Address(RVA = "0xE3DCC0", Offset = "0xE3CEC0", VA = "0x180E3DCC0")]
	public static void CheckBattleAttack(Action finishedCallback)
	{
	}

	[Token(Token = "0x600957C")]
	[Address(RVA = "0xE3DDB0", Offset = "0xE3CFB0", VA = "0x180E3DDB0")]
	public static void CheckCardHappen(Action finishedCallback)
	{
	}

	[Token(Token = "0x600957D")]
	[Address(RVA = "0xE3DE00", Offset = "0xE3D000", VA = "0x180E3DE00")]
	public static void CheckChainEnd(Action finishedCallback)
	{
	}

	[Token(Token = "0x600957E")]
	[Address(RVA = "0xE3DE50", Offset = "0xE3D050", VA = "0x180E3DE50")]
	public static void CheckCommandBegin(Action finishedCallback)
	{
	}

	[Token(Token = "0x600957F")]
	[Address(RVA = "0xE3DEA0", Offset = "0xE3D0A0", VA = "0x180E3DEA0")]
	public static void CheckCommandExecuted(Action finishedCallback)
	{
	}

	[Token(Token = "0x6009580")]
	[Address(RVA = "0xE400C0", Offset = "0xE3F2C0", VA = "0x180E400C0")]
	public static void CheckLocationBegin(Action finishedCallback)
	{
	}

	[Token(Token = "0x6009581")]
	[Address(RVA = "0xE40110", Offset = "0xE3F310", VA = "0x180E40110")]
	public static void CheckLocationExecuted(Action finishedCallback)
	{
	}

	[Token(Token = "0x6009582")]
	[Address(RVA = "0xE3DD10", Offset = "0xE3CF10", VA = "0x180E3DD10")]
	public static void CheckBeginDialog(Action finishedCallback)
	{
	}

	[Token(Token = "0x6009583")]
	[Address(RVA = "0xE3DD60", Offset = "0xE3CF60", VA = "0x180E3DD60")]
	public static void CheckBeginList(Action finishedCallback)
	{
	}

	[Token(Token = "0x6009584")]
	[Address(RVA = "0xE42740", Offset = "0xE41940", VA = "0x180E42740")]
	public static bool IsInvalidPhase(Engine.Phase phase)
	{
		return default(bool);
	}

	[Token(Token = "0x6009585")]
	[Address(RVA = "0xE43A70", Offset = "0xE42C70", VA = "0x180E43A70")]
	public static void ShowInvalidPhaseMessage()
	{
	}

	[Token(Token = "0x6009586")]
	[Address(RVA = "0xE42690", Offset = "0xE41890", VA = "0x180E42690")]
	public static bool IsInvalidCommand(Engine.CommandType command)
	{
		return default(bool);
	}

	[Token(Token = "0x6009587")]
	[Address(RVA = "0xE438F0", Offset = "0xE42AF0", VA = "0x180E438F0")]
	public static void ShowInvalidCommandMessage()
	{
	}

	[Token(Token = "0x6009588")]
	[Address(RVA = "0xE427F0", Offset = "0xE419F0", VA = "0x180E427F0")]
	public static bool IsInvalidStandType(CardCommandEx.StandType standType)
	{
		return default(bool);
	}

	[Token(Token = "0x6009589")]
	[Address(RVA = "0xE43BF0", Offset = "0xE42DF0", VA = "0x180E43BF0")]
	public static void ShowInvalidStandTypeMessage()
	{
	}

	[Token(Token = "0x600958A")]
	[Address(RVA = "0xE425E0", Offset = "0xE417E0", VA = "0x180E425E0")]
	public static bool IsInvalidCardID(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600958B")]
	[Address(RVA = "0xE43830", Offset = "0xE42A30", VA = "0x180E43830")]
	public static void ShowInvalidCardMessage()
	{
	}

	[Token(Token = "0x600958C")]
	[Address(RVA = "0xE43CB0", Offset = "0xE42EB0", VA = "0x180E43CB0")]
	public static void ShowNoCancelMessage()
	{
	}

	[Token(Token = "0x600958D")]
	[Address(RVA = "0xE43D70", Offset = "0xE42F70", VA = "0x180E43D70")]
	public static void ShowNoTrueCancelMessage()
	{
	}

	[Token(Token = "0x600958E")]
	[Address(RVA = "0xE43590", Offset = "0xE42790", VA = "0x180E43590")]
	public static void ShowBlockExtraDeckCommandMessage()
	{
	}

	[Token(Token = "0x600958F")]
	[Address(RVA = "0xE421F0", Offset = "0xE413F0", VA = "0x180E421F0")]
	public static bool IsEffectSelectionTarget(int effectIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6009590")]
	[Address(RVA = "0xE439B0", Offset = "0xE42BB0", VA = "0x180E439B0")]
	public static void ShowInvalidEffectSelectionTargetMessage()
	{
	}

	[Token(Token = "0x6009591")]
	[Address(RVA = "0xE42880", Offset = "0xE41A80", VA = "0x180E42880")]
	public static bool IsLocationTargetPosition(int position)
	{
		return default(bool);
	}

	[Token(Token = "0x6009592")]
	[Address(RVA = "0xE43B30", Offset = "0xE42D30", VA = "0x180E43B30")]
	public static void ShowInvalidPulldownIndexMessage()
	{
	}

	[Token(Token = "0x6009593")]
	[Address(RVA = "0xE3EA10", Offset = "0xE3DC10", VA = "0x180E3EA10")]
	public static void CheckEffectField()
	{
	}

	[Token(Token = "0x6009594")]
	[Address(RVA = "0xE3DEF0", Offset = "0xE3D0F0", VA = "0x180E3DEF0")]
	private static void CheckEffectCard()
	{
	}

	[Token(Token = "0x6009595")]
	[Address(RVA = "0xE3EEC0", Offset = "0xE3E0C0", VA = "0x180E3EEC0")]
	private static void CheckEffectPhaseButton()
	{
	}

	[Token(Token = "0x6009596")]
	[Address(RVA = "0xE3EA70", Offset = "0xE3DC70", VA = "0x180E3EA70")]
	private static void CheckEffectGrave()
	{
	}

	[Token(Token = "0x6009597")]
	[Address(RVA = "0xE3E5A0", Offset = "0xE3D7A0", VA = "0x180E3E5A0")]
	private static void CheckEffectExtra()
	{
	}

	[Token(Token = "0x6009598")]
	[Address(RVA = "0xE3FAC0", Offset = "0xE3ECC0", VA = "0x180E3FAC0")]
	public static void CheckEffectUIPhase(Engine.Phase phase, Transform target)
	{
	}

	[Token(Token = "0x6009599")]
	[Address(RVA = "0xE3F780", Offset = "0xE3E980", VA = "0x180E3F780")]
	public static void CheckEffectUICommand(Engine.CommandType command, Transform target)
	{
	}

	[Token(Token = "0x600959A")]
	[Address(RVA = "0xE3F390", Offset = "0xE3E590", VA = "0x180E3F390")]
	public static void CheckEffectUIActivateButton(Transform target)
	{
	}

	[Token(Token = "0x600959B")]
	[Address(RVA = "0xE3F920", Offset = "0xE3EB20", VA = "0x180E3F920")]
	public static void CheckEffectUIListCard(int cardID, Transform target)
	{
	}

	[Token(Token = "0x600959C")]
	[Address(RVA = "0xE41740", Offset = "0xE40940", VA = "0x180E41740")]
	public static List<int> GetHighlightListCardIdx(List<ListCardData> cardList)
	{
		return null;
	}

	[Token(Token = "0x600959D")]
	[Address(RVA = "0xE41ED0", Offset = "0xE410D0", VA = "0x180E41ED0")]
	public static bool IsCurrentTutorialContainsUIListCard()
	{
		return default(bool);
	}

	[Token(Token = "0x600959E")]
	[Address(RVA = "0xE422B0", Offset = "0xE414B0", VA = "0x180E422B0")]
	public static bool IsEffectTargetUIListCard(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600959F")]
	[Address(RVA = "0xE3FF20", Offset = "0xE3F120", VA = "0x180E3FF20")]
	public static void CheckEffectUIStandType(CardCommandEx.StandType standType, Transform target)
	{
	}

	[Token(Token = "0x60095A0")]
	[Address(RVA = "0xE3FD80", Offset = "0xE3EF80", VA = "0x180E3FD80")]
	public static void CheckEffectUIPulldownDialog(int index, Transform target)
	{
	}

	[Token(Token = "0x60095A1")]
	[Address(RVA = "0xE41FF0", Offset = "0xE411F0", VA = "0x180E41FF0")]
	public static bool IsCurrentTutorialContainsUIPulldown()
	{
		return default(bool);
	}

	[Token(Token = "0x60095A2")]
	[Address(RVA = "0xE423E0", Offset = "0xE415E0", VA = "0x180E423E0")]
	public static bool IsEffectTargetUIPulldown(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60095A3")]
	[Address(RVA = "0xE3F570", Offset = "0xE3E770", VA = "0x180E3F570")]
	public static void CheckEffectUICancelButton(Transform target, bool decision, bool cardList)
	{
	}

	[Token(Token = "0x60095A4")]
	[Address(RVA = "0xE3D9D0", Offset = "0xE3CBD0", VA = "0x180E3D9D0")]
	private static void AddPlayingEffect(DuelTutorialData.EffectInfo effectInfo, SimpleEffect effect)
	{
	}

	[Token(Token = "0x60095A5")]
	[Address(RVA = "0xE3DB00", Offset = "0xE3CD00", VA = "0x180E3DB00")]
	private static void AddPlayingUIEffect(DuelTutorialData.EffectInfo effectInfo, GameObject effect)
	{
	}

	[Token(Token = "0x60095A6")]
	[Address(RVA = "0xE42970", Offset = "0xE41B70", VA = "0x180E42970")]
	private static bool IsPlayingEffect(DuelTutorialData.EffectInfo effectInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60095A7")]
	[Address(RVA = "0xE41390", Offset = "0xE40590", VA = "0x180E41390")]
	private static GameObject CreateUIEffect(Transform parent, string showLabel)
	{
		return null;
	}

	[Token(Token = "0x60095A8")]
	[Address(RVA = "0xE40AD0", Offset = "0xE3FCD0", VA = "0x180E40AD0")]
	public static void ClearEffectAll()
	{
	}

	[Token(Token = "0x60095A9")]
	[Address(RVA = "0xE40EF0", Offset = "0xE400F0", VA = "0x180E40EF0")]
	public static void ClearUIEffectPhase()
	{
	}

	[Token(Token = "0x60095AA")]
	[Address(RVA = "0xE40E00", Offset = "0xE40000", VA = "0x180E40E00")]
	public static void ClearUIEffectCommand()
	{
	}

	[Token(Token = "0x60095AB")]
	[Address(RVA = "0xE40F90", Offset = "0xE40190", VA = "0x180E40F90")]
	public static void ClearUIEffectStandType()
	{
	}

	[Token(Token = "0x60095AC")]
	[Address(RVA = "0xE40C00", Offset = "0xE3FE00", VA = "0x180E40C00")]
	public static void ClearUIEffectActivateButton()
	{
	}

	[Token(Token = "0x60095AD")]
	[Address(RVA = "0xE40EA0", Offset = "0xE400A0", VA = "0x180E40EA0")]
	public static void ClearUIEffectListCard()
	{
	}

	[Token(Token = "0x60095AE")]
	[Address(RVA = "0xE40DB0", Offset = "0xE3FFB0", VA = "0x180E40DB0")]
	public static void ClearUIEffectCancelButton(bool decision)
	{
	}

	[Token(Token = "0x60095AF")]
	[Address(RVA = "0xE40E50", Offset = "0xE40050", VA = "0x180E40E50")]
	public static void ClearUIEffectListCard(int cardID)
	{
	}

	[Token(Token = "0x60095B0")]
	[Address(RVA = "0xE40F40", Offset = "0xE40140", VA = "0x180E40F40")]
	public static void ClearUIEffectPulldown(int index)
	{
	}

	[Token(Token = "0x60095B1")]
	[Address(RVA = "0xE40FE0", Offset = "0xE401E0", VA = "0x180E40FE0")]
	private static void ClearUIEffect(DuelTutorialData.Effect effect)
	{
	}

	[Token(Token = "0x60095B2")]
	[Address(RVA = "0xE41180", Offset = "0xE40380", VA = "0x180E41180")]
	private static void ClearUIEffect(DuelTutorialData.Effect effect, int param)
	{
	}

	[Token(Token = "0x60095B3")]
	[Address(RVA = "0xE40C50", Offset = "0xE3FE50", VA = "0x180E40C50")]
	public static void ClearUIEffectAll()
	{
	}

	[Token(Token = "0x60095B4")]
	[Address(RVA = "0xE42B20", Offset = "0xE41D20", VA = "0x180E42B20")]
	public static bool IsSkipActivation()
	{
		return default(bool);
	}

	[Token(Token = "0x60095B5")]
	[Address(RVA = "0xE42F60", Offset = "0xE42160", VA = "0x180E42F60")]
	public static bool NoCancel()
	{
		return default(bool);
	}

	[Token(Token = "0x60095B6")]
	[Address(RVA = "0xE42ED0", Offset = "0xE420D0", VA = "0x180E42ED0")]
	public static bool NoCancelTrue()
	{
		return default(bool);
	}

	[Token(Token = "0x60095B7")]
	[Address(RVA = "0xE3DC30", Offset = "0xE3CE30", VA = "0x180E3DC30")]
	public static bool BlockExtraDeckCommand()
	{
		return default(bool);
	}

	[Token(Token = "0x60095B8")]
	[Address(RVA = "0xE41E00", Offset = "0xE41000", VA = "0x180E41E00")]
	public static bool IsClimaxBGMPlayable()
	{
		return default(bool);
	}

	[Token(Token = "0x60095B9")]
	[Address(RVA = "0xE42510", Offset = "0xE41710", VA = "0x180E42510")]
	public static bool IsFirstTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x60095BA")]
	[Address(RVA = "0xE42BB0", Offset = "0xE41DB0", VA = "0x180E42BB0")]
	public static bool IsStrategy()
	{
		return default(bool);
	}

	[Token(Token = "0x60095BB")]
	[Address(RVA = "0xE42110", Offset = "0xE41310", VA = "0x180E42110")]
	public static bool IsDone()
	{
		return default(bool);
	}
}
