using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Serialization;
using YgomGame.Card;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor;

[Serializable]
[Token(Token = "0x200156F")]
public class ActorBindingRefs
{
	[Token(Token = "0x400CCB5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Header("シーケンスタイムライン/00.暗転（スキップ時用）")]
	private PlayableAsset m_TmSeq00_Empty;

	[Token(Token = "0x400CCB6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("シーケンスタイムライン/01.パック入り単体")]
	private PlayableAsset m_TmSeq01_PackEntry01;

	[Token(Token = "0x400CCB7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("シーケンスタイムライン/01.パック入り10連初回")]
	private PlayableAsset m_TmSeq01_PackEntry10First;

	[Token(Token = "0x400CCB8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("シーケンスタイムライン/01.パック入り10連2回目以降")]
	private PlayableAsset m_TmSeq01_PackEntry10Next;

	[Token(Token = "0x400CCB9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Header("シーケンスタイムライン/02.パック開封前カミナリ_1")]
	public PlayableAsset tmSeq02_PackThunder01;

	[Token(Token = "0x400CCBA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Header("シーケンスタイムライン/02.パック開封前カミナリ_2")]
	public PlayableAsset tmSeq02_PackThunder02;

	[Token(Token = "0x400CCBB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Header("シーケンスタイムライン/02.パック開封前カミナリ_3")]
	public PlayableAsset tmSeq02_PackThunder03;

	[Token(Token = "0x400CCBC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Header("シーケンスタイムライン/03.パック入り後昇格N->SR")]
	[FormerlySerializedAs("m_TmSeq02_PackShakeUpgradeNToSR")]
	private PlayableAsset m_TmSeq03_PackShakeUpgradeNToSR;

	[Token(Token = "0x400CCBD")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Header("シーケンスタイムライン/03.パック入り後昇格N->UR")]
	public PlayableAsset tmSeq03_PackShakeUpgradeNToUR;

	[Token(Token = "0x400CCBE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Header("シーケンスタイムライン/03.パック入り後昇格SR->UR")]
	[FormerlySerializedAs("m_TmSeq02_PackShakeUpgradeSRToUR")]
	private PlayableAsset m_TmSeq03_PackShakeUpgradeSRToUR;

	[Token(Token = "0x400CCBF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Header("シーケンスタイムライン/04.特殊カット演出_ホープ")]
	public PlayableAsset tmSeq04_CutHope;

	[Token(Token = "0x400CCC0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Header("シーケンスタイムライン/05.パック開封昇格なし")]
	[FormerlySerializedAs("m_TmSeq03_PackOpen")]
	private PlayableAsset m_TmSeq05_PackOpen;

	[Token(Token = "0x400CCC1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Header("シーケンスタイムライン/05.パック開封昇格あり")]
	[FormerlySerializedAs("m_TmSeq03_PackOpenUpgrade")]
	private PlayableAsset m_TmSeq05_PackOpenUpgrade;

	[Token(Token = "0x400CCC2")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Header("シーケンスタイムライン/06.カード出入り")]
	[FormerlySerializedAs("m_TmSeq04_CardEntry")]
	private PlayableAsset m_TmSeq06_CardEntry;

	[Token(Token = "0x400CCC3")]
	[FieldOffset(Offset = "0x80")]
	[Header("背景/Material")]
	[SerializeField]
	private Material m_ScrollBgMatN;

	[Token(Token = "0x400CCC4")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Material m_ScrollBgMatSR;

	[Token(Token = "0x400CCC5")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Material m_ScrollBgMatUR;

	[Token(Token = "0x400CCC6")]
	[FieldOffset(Offset = "0x98")]
	[Header("背景下部モヤ/Sprite")]
	[SerializeField]
	private Sprite m_BottomBgSpriteSR;

	[Token(Token = "0x400CCC7")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Sprite m_BottomBgSpriteUR;

	[Token(Token = "0x400CCC8")]
	[FieldOffset(Offset = "0xA8")]
	[Header("パック/Prefab")]
	[SerializeField]
	private ElementObjectManager m_PackPrefDefault;

	[Token(Token = "0x400CCC9")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private ElementObjectManager m_PackPrefSR;

	[Token(Token = "0x400CCCA")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private ElementObjectManager m_PackPrefUR;

	[Token(Token = "0x400CCCB")]
	[FieldOffset(Offset = "0xC0")]
	[Header("カード/Prefab")]
	[SerializeField]
	private ElementObjectManager m_CardPrefDefault;

	[Token(Token = "0x400CCCC")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private ElementObjectManager m_CardPrefSR;

	[Token(Token = "0x400CCCD")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private ElementObjectManager m_CardPrefUR;

	[Token(Token = "0x400CCCE")]
	[FieldOffset(Offset = "0xD8")]
	[Header("カード/アニメーション")]
	[SerializeField]
	private PlayableAsset m_TmCardOpenDefault;

	[Token(Token = "0x400CCCF")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PlayableAsset m_TmCardOpenShake;

	[Token(Token = "0x400CCD0")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private PlayableAsset m_TmCardOpenSR;

	[Token(Token = "0x400CCD1")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private PlayableAsset m_TmCardOpenUR;

	[Token(Token = "0x400CCD2")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private PlayableAsset m_TmCardOpenPremium1;

	[Token(Token = "0x400CCD3")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private PlayableAsset m_TmCardOpenPremium2;

	[Token(Token = "0x400CCD4")]
	[FieldOffset(Offset = "0x108")]
	[Header("Info/ラベル帯")]
	[SerializeField]
	private Sprite[] m_InfoLabelBandSprites;

	[Token(Token = "0x17001438")]
	public PlayableAsset tmSeq00_Empty
	{
		[Token(Token = "0x6008463")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001439")]
	public PlayableAsset tmSeq01_PackEntry01
	{
		[Token(Token = "0x6008464")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143A")]
	public PlayableAsset tmSeq01_PackEntry10First
	{
		[Token(Token = "0x6008465")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143B")]
	public PlayableAsset tmSeq01_PackEntry10Next
	{
		[Token(Token = "0x6008466")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143C")]
	public PlayableAsset tmSeq02_PackShakeUpgradeNToSR
	{
		[Token(Token = "0x6008467")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143D")]
	public PlayableAsset tmSeq02_PackShakeUpgradeSRToUR
	{
		[Token(Token = "0x6008468")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143E")]
	public PlayableAsset tmSeq03_PackOpen
	{
		[Token(Token = "0x6008469")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700143F")]
	public PlayableAsset tmSeq03_PackOpenUpgrade
	{
		[Token(Token = "0x600846A")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001440")]
	public PlayableAsset tmSeq04_CardEntry
	{
		[Token(Token = "0x600846B")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001441")]
	public Material scrollBgMatN
	{
		[Token(Token = "0x600846C")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001442")]
	public Material scrollBgMatSR
	{
		[Token(Token = "0x600846D")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001443")]
	public Material scrollBgMatUR
	{
		[Token(Token = "0x600846E")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001444")]
	public Sprite bottomBgSpriteSR
	{
		[Token(Token = "0x600846F")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001445")]
	public Sprite bottomBgSpriteUR
	{
		[Token(Token = "0x6008470")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001446")]
	public ElementObjectManager packPrefDefault
	{
		[Token(Token = "0x6008471")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001447")]
	public ElementObjectManager packPrefSR
	{
		[Token(Token = "0x6008472")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001448")]
	public ElementObjectManager packPrefUR
	{
		[Token(Token = "0x6008473")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001449")]
	public ElementObjectManager cardPrefDefault
	{
		[Token(Token = "0x6008474")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144A")]
	public ElementObjectManager cardPrefSR
	{
		[Token(Token = "0x6008475")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144B")]
	public ElementObjectManager cardPrefUR
	{
		[Token(Token = "0x6008476")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144C")]
	public PlayableAsset tmCardOpenDefault
	{
		[Token(Token = "0x6008477")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144D")]
	public PlayableAsset tmCardOpenShake
	{
		[Token(Token = "0x6008478")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144E")]
	public PlayableAsset tmCardOpenSR
	{
		[Token(Token = "0x6008479")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144F")]
	public PlayableAsset tmCardOpenUR
	{
		[Token(Token = "0x600847A")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001450")]
	public PlayableAsset tmCardOpenPremium1
	{
		[Token(Token = "0x600847B")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001451")]
	public PlayableAsset tmCardOpenPremium2
	{
		[Token(Token = "0x600847C")]
		[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001452")]
	public Sprite[] infoLabelBandSprites
	{
		[Token(Token = "0x600847D")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600847E")]
	[Address(RVA = "0xCCCE20", Offset = "0xCCC020", VA = "0x180CCCE20")]
	public PlayableAsset GetTmCardOnOpen(DrawCardData drawCardData)
	{
		return null;
	}

	[Token(Token = "0x600847F")]
	[Address(RVA = "0xCCCDF0", Offset = "0xCCBFF0", VA = "0x180CCCDF0")]
	public ElementObjectManager GetPackPref(CardCollectionInfo.Rarity packRarity)
	{
		return null;
	}

	[Token(Token = "0x6008480")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ActorBindingRefs()
	{
	}
}
