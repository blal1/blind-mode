using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EF5")]
public class DuelLiveCategorySetting
{
	[Token(Token = "0x2000EF6")]
	public class DuelLiveMainCategoryData
	{
		[Token(Token = "0x400A584")]
		[FieldOffset(Offset = "0x10")]
		private DuelLiveCategoryShowcaseData m_CategoryData;

		[Token(Token = "0x400A585")]
		[FieldOffset(Offset = "0x18")]
		private DuelLiveShowcaseImportData m_replayData;

		[Token(Token = "0x400A586")]
		[FieldOffset(Offset = "0x20")]
		private DuelLiveWCSData m_wcsData;

		[Token(Token = "0x400A587")]
		[FieldOffset(Offset = "0x28")]
		private DuelLiveShopData m_ShopData;

		[Token(Token = "0x400A588")]
		[FieldOffset(Offset = "0x30")]
		private DuelLiveBannerData m_BannerData;

		[Token(Token = "0x17000E03")]
		public DuelLiveCategoryShowcaseData categoryData
		{
			[Token(Token = "0x6005AAD")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E04")]
		public DuelLiveShowcaseImportData replayData
		{
			[Token(Token = "0x6005AAE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E05")]
		public DuelLiveWCSData wcsData
		{
			[Token(Token = "0x6005AAF")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E06")]
		public DuelLiveShopData shopData
		{
			[Token(Token = "0x6005AB0")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E07")]
		public DuelLiveBannerData bannerData
		{
			[Token(Token = "0x6005AB1")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0xA08FA0", Offset = "0xA081A0", VA = "0x180A08FA0")]
		public DuelLiveMainCategoryData()
		{
		}
	}

	[Token(Token = "0x400A57F")]
	[FieldOffset(Offset = "0x10")]
	private List<DuelLiveMainCategoryData> m_DuelLiveMainDatas;

	[Token(Token = "0x400A580")]
	[FieldOffset(Offset = "0x18")]
	private DuelLiveCategoryShowcaseData m_CategoryData;

	[Token(Token = "0x400A581")]
	[FieldOffset(Offset = "0x20")]
	private DuelLiveShowcaseImportData m_replayData;

	[Token(Token = "0x400A582")]
	[FieldOffset(Offset = "0x28")]
	private DuelLiveWCSData m_wcsData;

	[Token(Token = "0x400A583")]
	[FieldOffset(Offset = "0x30")]
	private List<DuelLiveCardPackData> m_cardPackData;

	[Token(Token = "0x17000E02")]
	public List<DuelLiveMainCategoryData> duelLiveMainDatas
	{
		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005AAB")]
	[Address(RVA = "0xA01C20", Offset = "0xA00E20", VA = "0x180A01C20")]
	public Either<string, bool> InitDuelLiveCategorySetting()
	{
		return null;
	}

	[Token(Token = "0x6005AAC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveCategorySetting()
	{
	}
}
