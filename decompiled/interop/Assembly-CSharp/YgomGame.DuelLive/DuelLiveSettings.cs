using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using YgomSystem;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EFB")]
public class DuelLiveSettings
{
	[Token(Token = "0x400A596")]
	internal const string k_Path = "Definition/DuelLive/DuelLiveSettings";

	[Token(Token = "0x400A597")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[FormerlySerializedAs("m_ProductGroupSetting")]
	private DuelLiveCategorySetting m_CategorySetting;

	[Token(Token = "0x400A598")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string[] m_BGMonsterImgPaths;

	[Token(Token = "0x17000E0B")]
	public List<DuelLiveCategorySetting.DuelLiveMainCategoryData> mainCategoryData
	{
		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0x5343D0", Offset = "0x5335D0", VA = "0x1805343D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E0C")]
	public string[] bgMonsterImgPaths
	{
		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005AC0")]
	[Address(RVA = "0xA0BC80", Offset = "0xA0AE80", VA = "0x180A0BC80")]
	public DuelLiveCategoryShowcaseData getCategoryData(int index)
	{
		return null;
	}

	[Token(Token = "0x6005AC1")]
	[Address(RVA = "0xA0BD10", Offset = "0xA0AF10", VA = "0x180A0BD10")]
	public DuelLiveShowcaseImportData getReplayImportData(int index)
	{
		return null;
	}

	[Token(Token = "0x6005AC2")]
	[Address(RVA = "0xA0BE30", Offset = "0xA0B030", VA = "0x180A0BE30")]
	public DuelLiveWCSData getWcsData(int index)
	{
		return null;
	}

	[Token(Token = "0x6005AC3")]
	[Address(RVA = "0xA0BDA0", Offset = "0xA0AFA0", VA = "0x180A0BDA0")]
	public DuelLiveShopData getShopData(int index)
	{
		return null;
	}

	[Token(Token = "0x6005AC4")]
	[Address(RVA = "0xA0BBF0", Offset = "0xA0ADF0", VA = "0x180A0BBF0")]
	public List<DuelLiveCardPackData> getCardPackData(int index)
	{
		return null;
	}

	[Token(Token = "0x6005AC5")]
	[Address(RVA = "0xA0BB60", Offset = "0xA0AD60", VA = "0x180A0BB60")]
	public DuelLiveBannerData getBannerData(int index)
	{
		return null;
	}

	[Token(Token = "0x6005AC7")]
	[Address(RVA = "0xA0B9F0", Offset = "0xA0ABF0", VA = "0x180A0B9F0")]
	public Either<string, bool> InitDuelLiveSetting()
	{
		return null;
	}

	[Token(Token = "0x6005AC8")]
	[Address(RVA = "0xA0BA70", Offset = "0xA0AC70", VA = "0x180A0BA70")]
	public DuelLiveSettings()
	{
	}
}
