using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20017B7")]
[CreateAssetMenu(menuName = "Scriptable Object/DuelTutorialData")]
public class DuelTutorialData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20017B8")]
	public class MessageInfo
	{
		[Token(Token = "0x400DDF0")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("メッセージを開始するターン")]
		public int startTurn;

		[Token(Token = "0x400DDF1")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("メッセージ表示のタイミング")]
		public View startView;

		[Token(Token = "0x400DDF2")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("開始時の遅延時間")]
		public float startDelay;

		[Token(Token = "0x400DDF3")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("中央メッセージ")]
		public List<string> centerMessage;

		[Token(Token = "0x400DDF4")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("上部メッセージを使うか")]
		public bool useTopMessage;

		[Token(Token = "0x400DDF5")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("上部メッセージ")]
		public string topMessage;

		[Token(Token = "0x400DDF6")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("上部メッセージの表示終了ターン")]
		public int finishTurn;

		[Token(Token = "0x400DDF7")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("上部メッセージの表示終了タイミング")]
		public View finishView;

		[Token(Token = "0x400DDF8")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("無効フェイズリスト")]
		public List<Engine.Phase> invalidPhase;

		[Token(Token = "0x400DDF9")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("無効フェイズ選択時のメッセージ")]
		public string invalidPhaseMessage;

		[Token(Token = "0x400DDFA")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("無効コマンドリスト")]
		public List<Engine.CommandType> invalidCommand;

		[Token(Token = "0x400DDFB")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("無効コマンド選択時のメッセージ")]
		public string invalidCommandMessage;

		[Token(Token = "0x400DDFC")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("エフェクトリスト(操作指示)")]
		public List<EffectInfo> effectList;

		[Token(Token = "0x400DDFD")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("カード発動確認のスキップフラグ")]
		public bool skipCardActivation;

		[Token(Token = "0x400DDFE")]
		[FieldOffset(Offset = "0x69")]
		[Tooltip("キャンセル無効フラグ")]
		public bool noCancel;

		[Token(Token = "0x400DDFF")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("キャンセル無効化時にキャンセルした際のメッセージ")]
		public string noCancelMessage;

		[Token(Token = "0x400DE00")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Trueキャンセル無効フラグ")]
		public bool noTrueCancel;

		[Token(Token = "0x400DE01")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Trueキャンセル無効化時にキャンセルした際のメッセージ")]
		public string noTrueCancelMessage;

		[Token(Token = "0x400DE02")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("無効な表示形式")]
		public CardCommandEx.StandType invalidStandType;

		[Token(Token = "0x400DE03")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("上部メッセージの表示終了タイミング")]
		public string invalidStandTypeMessage;

		[Token(Token = "0x400DE04")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("無効カードIDリスト")]
		public List<int> invalidCardID;

		[Token(Token = "0x400DE05")]
		[FieldOffset(Offset = "0xA0")]
		[Tooltip("無効カード選択時のメッセージ")]
		public string invalidCardIDMessage;

		[Token(Token = "0x400DE06")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("プルダウンでの対象以外を選択した場合のメッセージ")]
		public string invalidPulldownTargetMessage;

		[Token(Token = "0x400DE07")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("効果対象の番号")]
		public int effectSelectionTarget;

		[Token(Token = "0x400DE08")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("無効な対象を選択した際のメッセージ")]
		public string invalidEffectSelectionTargetMessage;

		[Token(Token = "0x400DE09")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("カードの配置場所指定")]
		public List<int> locationTargetPosition;

		[Token(Token = "0x400DE0A")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("EXデッキのコマンド表示無効化")]
		public bool blockExtraDeckCommand;

		[Token(Token = "0x400DE0B")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("EXデッキ無効化時に選択した際のメッセージ")]
		public string blockExtraDeckCommandMessage;

		[Token(Token = "0x400DE0C")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("ヘルプアセットのパス")]
		public string helpLabelPath;

		[Token(Token = "0x170016BE")]
		public List<string> CenterMessage
		{
			[Token(Token = "0x6009551")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016BF")]
		public string TopMessage
		{
			[Token(Token = "0x6009552")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C0")]
		public string InvalidPhaseMessage
		{
			[Token(Token = "0x6009553")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C1")]
		public string InvalidCommandMessage
		{
			[Token(Token = "0x6009554")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C2")]
		public string NoCancelMessage
		{
			[Token(Token = "0x6009555")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C3")]
		public string NoTrueCancelMessage
		{
			[Token(Token = "0x6009556")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C4")]
		public string InvalidStandTypeMessage
		{
			[Token(Token = "0x6009557")]
			[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C5")]
		public string InvalidCardIDMessage
		{
			[Token(Token = "0x6009558")]
			[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C6")]
		public string InvalidPulldownTargetMessage
		{
			[Token(Token = "0x6009559")]
			[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C7")]
		public string InvalidEffectSelectionTargetMessage
		{
			[Token(Token = "0x600955A")]
			[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016C8")]
		public string BlockExtraDeckCommandMessage
		{
			[Token(Token = "0x600955B")]
			[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600955C")]
		[Address(RVA = "0xE39EF0", Offset = "0xE390F0", VA = "0x180E39EF0")]
		public MessageInfo()
		{
		}
	}

	[Token(Token = "0x20017B9")]
	public enum View
	{
		[Token(Token = "0x400DE0E")]
		None,
		[Token(Token = "0x400DE0F")]
		DuelStart,
		[Token(Token = "0x400DE10")]
		PhaseChangeDrawStart,
		[Token(Token = "0x400DE11")]
		PhaseChangeStandbyStart,
		[Token(Token = "0x400DE12")]
		PhaseChangeMain1Start,
		[Token(Token = "0x400DE13")]
		PhaseChangeBattleStart,
		[Token(Token = "0x400DE14")]
		PhaseChangeMain2Start,
		[Token(Token = "0x400DE15")]
		PhaseChangeEndStart,
		[Token(Token = "0x400DE16")]
		CommandSummon,
		[Token(Token = "0x400DE17")]
		AllAttacked,
		[Token(Token = "0x400DE18")]
		CommandAttack,
		[Token(Token = "0x400DE19")]
		CommandSet,
		[Token(Token = "0x400DE1A")]
		BattleAttack,
		[Token(Token = "0x400DE1B")]
		CardHappen,
		[Token(Token = "0x400DE1C")]
		ChainEnd,
		[Token(Token = "0x400DE1D")]
		FirstWaitInputMainPhase1,
		[Token(Token = "0x400DE1E")]
		CommandSummonSp,
		[Token(Token = "0x400DE1F")]
		CommandAction,
		[Token(Token = "0x400DE20")]
		CommandPendulum,
		[Token(Token = "0x400DE21")]
		CommandBegin,
		[Token(Token = "0x400DE22")]
		CommandExecuted,
		[Token(Token = "0x400DE23")]
		LocationBegin,
		[Token(Token = "0x400DE24")]
		LocationExecuted,
		[Token(Token = "0x400DE25")]
		BeginDialog,
		[Token(Token = "0x400DE26")]
		BeginList,
		[Token(Token = "0x400DE27")]
		CheckTiming
	}

	[Token(Token = "0x20017BA")]
	public enum Effect
	{
		[Token(Token = "0x400DE29")]
		HighlightCard,
		[Token(Token = "0x400DE2A")]
		HighlightPhase,
		[Token(Token = "0x400DE2B")]
		HighlightGrave,
		[Token(Token = "0x400DE2C")]
		ArrowCard,
		[Token(Token = "0x400DE2D")]
		UIHighlightActivateButton,
		[Token(Token = "0x400DE2E")]
		UIHighlightListCard,
		[Token(Token = "0x400DE2F")]
		UIHighlightCommand,
		[Token(Token = "0x400DE30")]
		UIHighlightPhase,
		[Token(Token = "0x400DE31")]
		HighlightExtra,
		[Token(Token = "0x400DE32")]
		UIHighlightStandType,
		[Token(Token = "0x400DE33")]
		UIHighlightPulldown,
		[Token(Token = "0x400DE34")]
		UIHighlightCancelButton
	}

	[Serializable]
	[Token(Token = "0x20017BB")]
	public class EffectInfo
	{
		[Token(Token = "0x400DE35")]
		[FieldOffset(Offset = "0x10")]
		public Effect effect;

		[Token(Token = "0x400DE36")]
		[FieldOffset(Offset = "0x14")]
		public int param;

		[Token(Token = "0x600955D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public EffectInfo()
		{
		}
	}

	[Token(Token = "0x400DDEC")]
	[FieldOffset(Offset = "0x18")]
	public List<MessageInfo> infoList;

	[Token(Token = "0x400DDED")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("クライマックスBGMを再生するか")]
	public bool playClimaxBGM;

	[Token(Token = "0x400DDEE")]
	[FieldOffset(Offset = "0x21")]
	[Tooltip("初回チュートリアルか")]
	public bool isFirstTutorial;

	[Token(Token = "0x400DDEF")]
	[FieldOffset(Offset = "0x22")]
	[Tooltip("ストラテジーか")]
	public bool isStrategy;

	[Token(Token = "0x600954D")]
	[Address(RVA = "0xE367F0", Offset = "0xE359F0", VA = "0x180E367F0")]
	public MessageInfo Get(int turn, View view, List<MessageInfo> ignoreList)
	{
		return null;
	}

	[Token(Token = "0x600954E")]
	[Address(RVA = "0xE36750", Offset = "0xE35950", VA = "0x180E36750")]
	public MessageInfo Get(int index, int turn, View view)
	{
		return null;
	}

	[Token(Token = "0x600954F")]
	[Address(RVA = "0xE36620", Offset = "0xE35820", VA = "0x180E36620")]
	public List<string> GetHelp()
	{
		return null;
	}

	[Token(Token = "0x6009550")]
	[Address(RVA = "0xE368E0", Offset = "0xE35AE0", VA = "0x180E368E0")]
	public DuelTutorialData()
	{
	}
}
