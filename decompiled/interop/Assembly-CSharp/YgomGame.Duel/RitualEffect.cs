using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001A99")]
public class RitualEffect : SummonEffectBase
{
	[Token(Token = "0x400F4E1")]
	[FieldOffset(Offset = "0xB8")]
	private List<PlayableDirector> showTimeline;

	[Token(Token = "0x400F4E2")]
	private const string SUMMON_RITUAL_SHOW1 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard01";

	[Token(Token = "0x400F4E3")]
	private const string SUMMON_RITUAL_SHOW2 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard02";

	[Token(Token = "0x400F4E4")]
	private const string SUMMON_RITUAL_SHOW3 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard03";

	[Token(Token = "0x400F4E5")]
	private const string SUMMON_RITUAL_SHOW4 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard04";

	[Token(Token = "0x400F4E6")]
	private const string SUMMON_RITUAL_SHOW5 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard05";

	[Token(Token = "0x400F4E7")]
	private const string SUMMON_RITUAL_SHOW6 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCard06";

	[Token(Token = "0x400F4E8")]
	private const string SUMMON_RITUAL_SHOWPARTS01 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitParts/SummonRitualShowUnitParts01";

	[Token(Token = "0x400F4E9")]
	private const string SUMMON_RITUAL_SHOWPARTS02 = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitParts/SummonRitualShowUnitParts02";

	[Token(Token = "0x400F4EA")]
	private const string SUMMON_RITUAL = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitual01";

	[Token(Token = "0x400F4EB")]
	private const string SUMMON_RITUAL_NOMATERIAL = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitual02";

	[Token(Token = "0x400F4EC")]
	private const string SUMMON_RITUAL_CARDNUM = "Duel/Timeline/Duel/Universal/Summon/SummonRitual/SummonRitualShowUnitCard/SummonRitualShowUnitCardNum";

	[Token(Token = "0x17001ACA")]
	public override Engine.SpSummonType spSummonType
	{
		[Token(Token = "0x600ACF5")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "4")]
		get
		{
			return default(Engine.SpSummonType);
		}
	}

	[Token(Token = "0x600ACF6")]
	[Address(RVA = "0x4450B0", Offset = "0x4442B0", VA = "0x1804450B0")]
	public static RitualEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600ACF7")]
	[Address(RVA = "0x445490", Offset = "0x444690", VA = "0x180445490", Slot = "6")]
	protected override bool PlayEffect(Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600ACF8")]
	[Address(RVA = "0x445300", Offset = "0x444500", VA = "0x180445300", Slot = "5")]
	public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
	{
	}

	[Token(Token = "0x600ACF9")]
	[Address(RVA = "0x445520", Offset = "0x444720", VA = "0x180445520")]
	private bool PlayRitualEffect(int materialNum, Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600ACFA")]
	[Address(RVA = "0x4454A0", Offset = "0x4446A0", VA = "0x1804454A0")]
	private void PlayMainTimeline(Action onFinished)
	{
	}

	[Token(Token = "0x600ACFB")]
	[Address(RVA = "0x445E40", Offset = "0x445040", VA = "0x180445E40")]
	private void SetupCardShowTimeline(PlayableDirector timeline, int materialNum)
	{
	}

	[Token(Token = "0x600ACFC")]
	[Address(RVA = "0x446240", Offset = "0x445440", VA = "0x180446240")]
	private void SetupRitualTimeline(PlayableDirector timeline, int materialNum)
	{
	}

	[Token(Token = "0x600ACFD")]
	[Address(RVA = "0x4460F0", Offset = "0x4452F0", VA = "0x1804460F0")]
	private void SetupDestCardTexture(ElementObjectManager manager)
	{
	}

	[Token(Token = "0x600ACFE")]
	[Address(RVA = "0x4463E0", Offset = "0x4455E0", VA = "0x1804463E0", Slot = "8")]
	public override bool Skip()
	{
		return default(bool);
	}

	[Token(Token = "0x600ACFF")]
	[Address(RVA = "0x445160", Offset = "0x444360", VA = "0x180445160", Slot = "7")]
	protected override void Finish()
	{
	}

	[Token(Token = "0x600AD00")]
	[Address(RVA = "0x446530", Offset = "0x445730", VA = "0x180446530")]
	public RitualEffect()
	{
	}
}
