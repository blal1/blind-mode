using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x20019D1")]
public class CardRunEffect
{
	[Token(Token = "0x20019D2")]
	public class CardRunEffectUnit
	{
		[Token(Token = "0x400EE61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DuelGameObjectManager goManager;

		[Token(Token = "0x400EE63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CardRunEffectSetting.Player player;

		[Token(Token = "0x400EE67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<string> preparedTimelineList;

		[Token(Token = "0x1700199B")]
		public CardRunEffectSetting.CardRunEffectInfo info
		{
			[Token(Token = "0x600A69A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A69B")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700199C")]
		public bool isReadied
		{
			[Token(Token = "0x600A69C")]
			[Address(RVA = "0x5CF080", Offset = "0x5CE280", VA = "0x1805CF080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A69D")]
			[Address(RVA = "0x5CF0A0", Offset = "0x5CE2A0", VA = "0x1805CF0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700199D")]
		public bool isPlaying
		{
			[Token(Token = "0x600A69E")]
			[Address(RVA = "0x5CF090", Offset = "0x5CE290", VA = "0x1805CF090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A69F")]
			[Address(RVA = "0x5CF0B0", Offset = "0x5CE2B0", VA = "0x1805CF0B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700199E")]
		public int chainIndex
		{
			[Token(Token = "0x600A6A0")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600A6A1")]
			[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600A6A2")]
		[Address(RVA = "0xF23830", Offset = "0xF22A30", VA = "0x180F23830")]
		public CardRunEffectUnit(CardRunEffectSetting.CardRunEffectInfo info, DuelGameObjectManager goManager, CardRunEffectSetting.Player player, int chainIndex)
		{
		}

		[Token(Token = "0x600A6A3")]
		[Address(RVA = "0xF229C0", Offset = "0xF21BC0", VA = "0x180F229C0")]
		public void Load(Action onLoaded)
		{
		}

		[Token(Token = "0x600A6A4")]
		[Address(RVA = "0xF22F50", Offset = "0xF22150", VA = "0x180F22F50")]
		private void OnLoaded(Action onLoaded)
		{
		}

		[Token(Token = "0x600A6A5")]
		[Address(RVA = "0xF22F70", Offset = "0xF22170", VA = "0x180F22F70")]
		public bool Play(Vector3 position, [Optional] Action on_stop, [Optional] CardRoot targetCard)
		{
			return default(bool);
		}

		[Token(Token = "0x600A6A6")]
		[Address(RVA = "0xF229A0", Offset = "0xF21BA0", VA = "0x180F229A0")]
		public bool IsTiming(CardRunEffectSetting.RunTiming timing)
		{
			return default(bool);
		}

		[Token(Token = "0x600A6A7")]
		[Address(RVA = "0xF22840", Offset = "0xF21A40", VA = "0x180F22840")]
		public bool IsCardMoveEffectTarget(int moveCardID, Engine.CardMoveType moveType)
		{
			return default(bool);
		}

		[Token(Token = "0x600A6A8")]
		[Address(RVA = "0xF22750", Offset = "0xF21950", VA = "0x180F22750")]
		public CardMoveEffectBase CreateCardMoveEffect(int moveCardID, int moveCardSleeveID, int moveCardRareID, int fromPlayer, int fromPosition)
		{
			return null;
		}

		[Token(Token = "0x600A6A9")]
		[Address(RVA = "0xF236F0", Offset = "0xF228F0", VA = "0x180F236F0")]
		public void Terminate()
		{
		}
	}

	[Token(Token = "0x400EE58")]
	private const string settingPath = "Duel/ScriptableObject/CardRunEffectSetting";

	[Token(Token = "0x400EE59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CardRunEffect instance;

	[Token(Token = "0x400EE5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private CardRunEffectSetting setting;

	[Token(Token = "0x400EE5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool _isReady;

	[Token(Token = "0x400EE5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DuelGameObjectManager goManager;

	[Token(Token = "0x400EE5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _chainRunPlayer;

	[Token(Token = "0x400EE5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int _chainRunCardID;

	[Token(Token = "0x400EE5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<CardRunEffectUnit> unitStack;

	[Token(Token = "0x17001997")]
	public static bool isReady
	{
		[Token(Token = "0x600A667")]
		[Address(RVA = "0xF27E70", Offset = "0xF27070", VA = "0x180F27E70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001998")]
	public static int chainRunCardID
	{
		[Token(Token = "0x600A668")]
		[Address(RVA = "0xF27DD0", Offset = "0xF26FD0", VA = "0x180F27DD0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001999")]
	public static int chainRunPlayer
	{
		[Token(Token = "0x600A669")]
		[Address(RVA = "0xF27E20", Offset = "0xF27020", VA = "0x180F27E20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700199A")]
	public CardRunEffectUnit currentUnit
	{
		[Token(Token = "0x600A66A")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A66B")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A66C")]
	[Address(RVA = "0xF253C0", Offset = "0xF245C0", VA = "0x180F253C0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x600A66D")]
	[Address(RVA = "0xF26520", Offset = "0xF25720", VA = "0x180F26520")]
	public static void Terminate()
	{
	}

	[Token(Token = "0x600A66E")]
	[Address(RVA = "0xF26BE0", Offset = "0xF25DE0", VA = "0x180F26BE0")]
	private void _LoadSetting(Action loaded_callback, DuelGameObjectManager go_manager)
	{
	}

	[Token(Token = "0x600A66F")]
	[Address(RVA = "0xF258D0", Offset = "0xF24AD0", VA = "0x180F258D0")]
	public static void LoadSetting(Action loaded_callback, DuelGameObjectManager go_manager)
	{
	}

	[Token(Token = "0x600A670")]
	[Address(RVA = "0xF263C0", Offset = "0xF255C0", VA = "0x180F263C0")]
	public static bool StackEffect(int mrk, CardRunEffectSetting.Player player, int effectNo, int chainIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600A671")]
	[Address(RVA = "0xF27C30", Offset = "0xF26E30", VA = "0x180F27C30")]
	private bool _StackEffect(int mrk, CardRunEffectSetting.Player player, int effectNo, int chainIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600A672")]
	[Address(RVA = "0xF251C0", Offset = "0xF243C0", VA = "0x180F251C0")]
	public static CardRunEffectUnit CreateEffectUnit(int mrk, CardRunEffectSetting.Player player, int effectNo, int chainIndex)
	{
		return null;
	}

	[Token(Token = "0x600A673")]
	[Address(RVA = "0xF266D0", Offset = "0xF258D0", VA = "0x180F266D0")]
	private CardRunEffectUnit _CreateEffectUnit(int mrk, CardRunEffectSetting.Player player, int effectNo, int chainIndex)
	{
		return null;
	}

	[Token(Token = "0x600A674")]
	[Address(RVA = "0xF24FA0", Offset = "0xF241A0", VA = "0x180F24FA0")]
	public static CardRunEffectSetting.Position CardPositionToPosition(int player, int position)
	{
		return default(CardRunEffectSetting.Position);
	}

	[Token(Token = "0x600A675")]
	[Address(RVA = "0xF27B10", Offset = "0xF26D10", VA = "0x180F27B10")]
	private bool _PopEffectUnit(int chainIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600A676")]
	[Address(RVA = "0xF25E90", Offset = "0xF25090", VA = "0x180F25E90")]
	public static bool PopEffectUnit(int chainIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600A677")]
	[Address(RVA = "0xF25520", Offset = "0xF24720", VA = "0x180F25520")]
	public bool IsEffectReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600A678")]
	[Address(RVA = "0xF268E0", Offset = "0xF25AE0", VA = "0x180F268E0")]
	private bool _IsEffectReadey()
	{
		return default(bool);
	}

	[Token(Token = "0x600A679")]
	[Address(RVA = "0xF25B00", Offset = "0xF24D00", VA = "0x180F25B00")]
	public static void OnChainRun(int player, int cardID, int chainNum)
	{
	}

	[Token(Token = "0x600A67A")]
	[Address(RVA = "0xF25A60", Offset = "0xF24C60", VA = "0x180F25A60")]
	public static void OnChainEnd()
	{
	}

	[Token(Token = "0x600A67B")]
	[Address(RVA = "0xF26360", Offset = "0xF25560", VA = "0x180F26360")]
	public static void SkipCurrentEffectUnit()
	{
	}

	[Token(Token = "0x600A67C")]
	[Address(RVA = "0xF26D40", Offset = "0xF25F40", VA = "0x180F26D40")]
	private bool _PlayEffect(CardRunEffectSetting.Player player, CardRunEffectSetting.PlayType playType, string effectPath, int effectType, float delay, CardRunEffectSetting.RotationType rotationType, Vector3 pivot, CardRunEffectSetting.ExtraSetting extraSetting, Vector3 position, Action onStop, bool blockInput, [Optional] CardRunEffectSetting.CardRunEffectInfo info, [Optional] CardRoot targetCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A67D")]
	[Address(RVA = "0xF25CD0", Offset = "0xF24ED0", VA = "0x180F25CD0")]
	public static bool PlayEffect(CardRunEffectSetting.Player player, CardRunEffectSetting.PlayType playType, string effectPath, int effectType, float delay, CardRunEffectSetting.RotationType rotationType, Vector3 pivot, CardRunEffectSetting.ExtraSetting extraSetting, Vector3 position, Action onStop, bool blockInput, [Optional] CardRunEffectSetting.CardRunEffectInfo info, [Optional] CardRoot targetCard)
	{
		return default(bool);
	}

	[Token(Token = "0x600A67E")]
	[Address(RVA = "0xF25CB0", Offset = "0xF24EB0", VA = "0x180F25CB0")]
	private void OnStop(CardRunEffectSetting.Player player, CardRunEffectSetting.ExtraSetting extraSetting)
	{
	}

	[Token(Token = "0x600A67F")]
	[Address(RVA = "0xF24100", Offset = "0xF23300", VA = "0x180F24100")]
	private void ApplyExtraSettingPositionActivation(Transform effect, CardRunEffectSetting.Player player)
	{
	}

	[Token(Token = "0x600A680")]
	[Address(RVA = "0xF24040", Offset = "0xF23240", VA = "0x180F24040")]
	private void ApplyExtraSettingCardAttackPosition(Transform effect, bool isAttack)
	{
	}

	[Token(Token = "0x600A681")]
	[Address(RVA = "0xF23990", Offset = "0xF22B90", VA = "0x180F23990")]
	private void ApplyChangeLayerMagic(CardRunEffectSetting.Player player, bool onStart)
	{
	}

	[Token(Token = "0x600A682")]
	[Address(RVA = "0xF23B50", Offset = "0xF22D50", VA = "0x180F23B50")]
	private void ApplyChangeRenderQueue(CardRoot cardRoot, bool onStart)
	{
	}

	[Token(Token = "0x600A683")]
	[Address(RVA = "0xF23910", Offset = "0xF22B10", VA = "0x180F23910")]
	private void ApplyChangeLayerDuelOver3D(GameObject effect)
	{
	}

	[Token(Token = "0x600A684")]
	[Address(RVA = "0xF24DC0", Offset = "0xF23FC0", VA = "0x180F24DC0")]
	private void ApplyTraceTargetCard(GameObject effect, Vector3 position, bool targetIsAttack)
	{
	}

	[Token(Token = "0x600A685")]
	[Address(RVA = "0xF249D0", Offset = "0xF23BD0", VA = "0x180F249D0")]
	private void ApplyTraceRotatedTargetCard(GameObject effect, Vector3 position, Quaternion rootRotation, CardRoot targetCard)
	{
	}

	[Token(Token = "0x600A686")]
	[Address(RVA = "0xF24230", Offset = "0xF23430", VA = "0x180F24230")]
	private void ApplyMulcharmyFuwalos(GameObject effect, CardRunEffectSetting.Player runPlayer)
	{
	}

	[Token(Token = "0x600A687")]
	[Address(RVA = "0xF25FF0", Offset = "0xF251F0", VA = "0x180F25FF0")]
	private void SetupMulcharmyFuwakisDeckEffect(ElementObjectManager deckEom, bool disp, int player, int position)
	{
	}

	[Token(Token = "0x600A688")]
	[Address(RVA = "0xF246D0", Offset = "0xF238D0", VA = "0x180F246D0")]
	private void ApplyMulcharmyPurulia(GameObject effect, CardRunEffectSetting.Player runPlayer)
	{
	}

	[Token(Token = "0x600A689")]
	[Address(RVA = "0xF24420", Offset = "0xF23620", VA = "0x180F24420")]
	private void ApplyMulcharmyMeowls(GameObject effect, CardRunEffectSetting.Player runPlayer, string seLabel)
	{
	}

	[Token(Token = "0x600A68A")]
	[Address(RVA = "0xF23C20", Offset = "0xF22E20", VA = "0x180F23C20")]
	private void ApplyDrollAndLockBird(GameObject effect, bool alt)
	{
	}

	[Token(Token = "0x600A68B")]
	[Address(RVA = "0xF248F0", Offset = "0xF23AF0", VA = "0x180F248F0")]
	private void ApplyPlacePositionEffectOffset(GameObject effect, Vector3 position)
	{
	}

	[Token(Token = "0x600A68C")]
	[Address(RVA = "0xF25E20", Offset = "0xF25020", VA = "0x180F25E20")]
	public static void PlaySE(string seLabel, bool is3D, Vector3 position)
	{
	}

	[Token(Token = "0x600A68D")]
	[Address(RVA = "0xF26B10", Offset = "0xF25D10", VA = "0x180F26B10")]
	private bool _IsExist(int cardID, CardRunEffectSetting.Player player, CardRunEffectSetting.RunTiming runTiming, int effectNo)
	{
		return default(bool);
	}

	[Token(Token = "0x600A68E")]
	[Address(RVA = "0xF25760", Offset = "0xF24960", VA = "0x180F25760")]
	public static bool IsExist(int cardID, CardRunEffectSetting.Player player, CardRunEffectSetting.RunTiming runTiming, int effectNo)
	{
		return default(bool);
	}

	[Token(Token = "0x600A68F")]
	[Address(RVA = "0xF26A70", Offset = "0xF25C70", VA = "0x180F26A70")]
	private bool _IsExist(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600A690")]
	[Address(RVA = "0xF25870", Offset = "0xF24A70", VA = "0x180F25870")]
	public static bool IsExist(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600A691")]
	[Address(RVA = "0xF26900", Offset = "0xF25B00", VA = "0x180F26900")]
	private bool _IsEssential(int cardID, CardRunEffectSetting.Player player, int effectNo)
	{
		return default(bool);
	}

	[Token(Token = "0x600A692")]
	[Address(RVA = "0xF25660", Offset = "0xF24860", VA = "0x180F25660")]
	public static bool IsEssential(int cardID, CardRunEffectSetting.Player player, int effectNo)
	{
		return default(bool);
	}

	[Token(Token = "0x600A693")]
	[Address(RVA = "0xF269C0", Offset = "0xF25BC0", VA = "0x180F269C0")]
	private bool _IsEssential(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600A694")]
	[Address(RVA = "0xF25580", Offset = "0xF24780", VA = "0x180F25580")]
	public static bool IsEssential(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600A695")]
	[Address(RVA = "0xF26800", Offset = "0xF25A00", VA = "0x180F26800")]
	private CardRunEffectSetting.ExtraSetting _GetExtraSetting(int cardID, CardRunEffectSetting.Player player, CardRunEffectSetting.RunTiming runTiming, int effectNo)
	{
		return default(CardRunEffectSetting.ExtraSetting);
	}

	[Token(Token = "0x600A696")]
	[Address(RVA = "0xF252A0", Offset = "0xF244A0", VA = "0x180F252A0")]
	public static CardRunEffectSetting.ExtraSetting GetExtraSetting(int cardID, CardRunEffectSetting.Player player, CardRunEffectSetting.RunTiming runTiming, int effectNo)
	{
		return default(CardRunEffectSetting.ExtraSetting);
	}

	[Token(Token = "0x600A697")]
	[Address(RVA = "0xF25250", Offset = "0xF24450", VA = "0x180F25250")]
	public static CardRunEffectUnit GetCurrentEffectUnit()
	{
		return null;
	}

	[Token(Token = "0x600A698")]
	[Address(RVA = "0xF253B0", Offset = "0xF245B0", VA = "0x180F253B0")]
	public static CardRunEffectSetting.Player GetPlayer(bool isMyself)
	{
		return default(CardRunEffectSetting.Player);
	}

	[Token(Token = "0x600A699")]
	[Address(RVA = "0xF27D50", Offset = "0xF26F50", VA = "0x180F27D50")]
	public CardRunEffect()
	{
	}
}
