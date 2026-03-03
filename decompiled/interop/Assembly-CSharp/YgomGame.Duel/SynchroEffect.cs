using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001AA8")]
public class SynchroEffect : SummonEffectBase
{
	[Token(Token = "0x400F521")]
	[FieldOffset(Offset = "0xB8")]
	private List<PlayableDirector> showTimeline;

	[Token(Token = "0x400F522")]
	[FieldOffset(Offset = "0xC0")]
	private int tunerNum;

	[Token(Token = "0x400F523")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<int, int> tunerLevelList;

	[Token(Token = "0x400F524")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<int, int> notTunerLevelList;

	[Token(Token = "0x400F525")]
	private const string SUMMON_SYNCHRO_SHOW2 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard02";

	[Token(Token = "0x400F526")]
	private const string SUMMON_SYNCHRO_SHOW3 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard03";

	[Token(Token = "0x400F527")]
	private const string SUMMON_SYNCHRO_SHOW4 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard04";

	[Token(Token = "0x400F528")]
	private const string SUMMON_SYNCHRO_SHOW5 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard05";

	[Token(Token = "0x400F529")]
	private const string SUMMON_SYNCHRO_SHOW6 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCard06";

	[Token(Token = "0x400F52A")]
	private const string SUMMON_SYNCHRO_SHOWPARTS1 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitParts/SummonSynchroShowUnitParts01";

	[Token(Token = "0x400F52B")]
	private const string SUMMON_SYNCHRO_SHOWPARTS2 = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitParts/SummonSynchroShowUnitParts02";

	[Token(Token = "0x400F52C")]
	private const string SUMMON_SYNCHRO = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroMain01/SummonSynchro01";

	[Token(Token = "0x400F52D")]
	private const string SUMMON_SYNCHRO_NOMATERIAL = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroMain02/SummonSynchro02";

	[Token(Token = "0x400F52E")]
	private const string SUMMON_SYNCHRO_CARDNUM = "Duel/Timeline/Duel/Universal/Summon/SummonSynchro/SummonSynchroShowUnitCard/SummonSynchroShowUnitCardNum";

	[Token(Token = "0x17001ADC")]
	public override Engine.SpSummonType spSummonType
	{
		[Token(Token = "0x600AD5A")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "4")]
		get
		{
			return default(Engine.SpSummonType);
		}
	}

	[Token(Token = "0x17001ADD")]
	private int tunerLevel
	{
		[Token(Token = "0x600AD5B")]
		[Address(RVA = "0x44E390", Offset = "0x44D590", VA = "0x18044E390")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001ADE")]
	private int notTunerLevel
	{
		[Token(Token = "0x600AD5C")]
		[Address(RVA = "0x44E250", Offset = "0x44D450", VA = "0x18044E250")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600AD5D")]
	[Address(RVA = "0x44C850", Offset = "0x44BA50", VA = "0x18044C850")]
	public static SynchroEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600AD5E")]
	[Address(RVA = "0x44CB20", Offset = "0x44BD20", VA = "0x18044CB20", Slot = "5")]
	public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
	{
	}

	[Token(Token = "0x600AD5F")]
	[Address(RVA = "0x44CC90", Offset = "0x44BE90", VA = "0x18044CC90", Slot = "6")]
	protected override bool PlayEffect(Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600AD60")]
	[Address(RVA = "0x44C840", Offset = "0x44BA40", VA = "0x18044C840")]
	public void AddTunerNum()
	{
	}

	[Token(Token = "0x600AD61")]
	[Address(RVA = "0x44C780", Offset = "0x44B980", VA = "0x18044C780")]
	public void AddTunerLevel(int uniqueID, int level)
	{
	}

	[Token(Token = "0x600AD62")]
	[Address(RVA = "0x44C6C0", Offset = "0x44B8C0", VA = "0x18044C6C0")]
	public void AddNotTunerLevel(int uniqueID, int level)
	{
	}

	[Token(Token = "0x600AD63")]
	[Address(RVA = "0x44D780", Offset = "0x44C980", VA = "0x18044D780")]
	public void ResetTuningInfo()
	{
	}

	[Token(Token = "0x600AD64")]
	[Address(RVA = "0x44CD90", Offset = "0x44BF90", VA = "0x18044CD90")]
	private bool PlaySynchroEffect(int materialNum, int tunerNum, int notTunerLevel, int tunerLevel, Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600AD65")]
	[Address(RVA = "0x44D7F0", Offset = "0x44C9F0", VA = "0x18044D7F0")]
	private void SetupCardShowTimeline(PlayableDirector timeline, int materialNum, int tunerNum)
	{
	}

	[Token(Token = "0x600AD66")]
	[Address(RVA = "0x44DD70", Offset = "0x44CF70", VA = "0x18044DD70")]
	private void SetupSynchroTimeline(PlayableDirector timeline, int notTunerLevel, int tunerLevel)
	{
	}

	[Token(Token = "0x600AD67")]
	[Address(RVA = "0x44DC20", Offset = "0x44CE20", VA = "0x18044DC20")]
	private void SetupDestCardTexture(ElementObjectManager manager)
	{
	}

	[Token(Token = "0x600AD68")]
	[Address(RVA = "0x44E000", Offset = "0x44D200", VA = "0x18044E000", Slot = "8")]
	public override bool Skip()
	{
		return default(bool);
	}

	[Token(Token = "0x600AD69")]
	[Address(RVA = "0x44C980", Offset = "0x44BB80", VA = "0x18044C980", Slot = "7")]
	protected override void Finish()
	{
	}

	[Token(Token = "0x600AD6A")]
	[Address(RVA = "0x44E150", Offset = "0x44D350", VA = "0x18044E150")]
	public SynchroEffect()
	{
	}
}
