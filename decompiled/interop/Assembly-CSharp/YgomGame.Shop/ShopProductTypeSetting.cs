using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Token(Token = "0x2000939")]
[CreateAssetMenu(fileName = "ShopProductTypeSetting", menuName = "Scriptable Object/ShopProductTypeSetting")]
public class ShopProductTypeSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200093A")]
	public class Data
	{
		[Token(Token = "0x4008A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_ProductTypeId;

		[Token(Token = "0x4008A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_TargetCategoryId;

		[Token(Token = "0x4008A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_TargetIsPeriod;

		[Token(Token = "0x4008A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_HasSetItems;

		[Token(Token = "0x4008A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool m_IsMarketProduct;

		[Token(Token = "0x4008A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int m_LimitAlertSec;

		[Token(Token = "0x4008A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_LimitConfirmSec;

		[Token(Token = "0x4008A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_LimitConfirmMessage;

		[Token(Token = "0x4008A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_LimitConfirmSoonMessage;

		[Token(Token = "0x4008A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string m_InformButtonLabel;

		[Token(Token = "0x4008A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ShopDef.HighlightType m_HighlightType;

		[Token(Token = "0x4008A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ShopDef.ViewerLoopType m_ViewerLoopType;

		[Token(Token = "0x4008A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_HideSummonPlay;

		[Token(Token = "0x4008A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool m_HideListPriceLabel;

		[Token(Token = "0x17000734")]
		public int productTypeId
		{
			[Token(Token = "0x60037CF")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000735")]
		public int targetCategoryId
		{
			[Token(Token = "0x60037D0")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000736")]
		public bool targetIsPeriod
		{
			[Token(Token = "0x60037D1")]
			[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000737")]
		public bool hasSetItems
		{
			[Token(Token = "0x60037D2")]
			[Address(RVA = "0x7CE720", Offset = "0x7CD920", VA = "0x1807CE720")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000738")]
		public bool isMarketProduct
		{
			[Token(Token = "0x60037D3")]
			[Address(RVA = "0x7CE750", Offset = "0x7CD950", VA = "0x1807CE750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000739")]
		public int limitAlertSec
		{
			[Token(Token = "0x60037D4")]
			[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700073A")]
		public string informButtonLabel
		{
			[Token(Token = "0x60037D5")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073B")]
		public ShopDef.HighlightType highlightType
		{
			[Token(Token = "0x60037D6")]
			[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
			get
			{
				return default(ShopDef.HighlightType);
			}
		}

		[Token(Token = "0x1700073C")]
		public ShopDef.ViewerLoopType viewerLoopType
		{
			[Token(Token = "0x60037D7")]
			[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0")]
			get
			{
				return default(ShopDef.ViewerLoopType);
			}
		}

		[Token(Token = "0x1700073D")]
		public bool hideSummonPlay
		{
			[Token(Token = "0x60037D8")]
			[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700073E")]
		public int limitConfirmSec
		{
			[Token(Token = "0x60037D9")]
			[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700073F")]
		public string limitConfirmMessage
		{
			[Token(Token = "0x60037DA")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000740")]
		public string limitConfirmSoonMessage
		{
			[Token(Token = "0x60037DB")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000741")]
		public bool hideListPriceLabel
		{
			[Token(Token = "0x60037DC")]
			[Address(RVA = "0x7CE730", Offset = "0x7CD930", VA = "0x1807CE730")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60037DD")]
		[Address(RVA = "0x7CE710", Offset = "0x7CD910", VA = "0x1807CE710")]
		public Data()
		{
		}
	}

	[Token(Token = "0x4008A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Data> m_Datas;

	[Token(Token = "0x4008A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, Dictionary<int, Dictionary<bool, Dictionary<bool, Data>>>> m_DataMap;

	[Token(Token = "0x60037CA")]
	[Address(RVA = "0x7DD230", Offset = "0x7DC430", VA = "0x1807DD230")]
	public Data FindProductTypeData(ProductContext productContext)
	{
		return null;
	}

	[Token(Token = "0x60037CB")]
	[Address(RVA = "0x7DD080", Offset = "0x7DC280", VA = "0x1807DD080")]
	public bool FindBoolData(ProductContext productContext, string key, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60037CC")]
	[Address(RVA = "0x7DD130", Offset = "0x7DC330", VA = "0x1807DD130")]
	public int FindIntData(ProductContext productContext, string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60037CD")]
	[Address(RVA = "0x7DDBA0", Offset = "0x7DCDA0", VA = "0x1807DDBA0")]
	public string FindStringData(ProductContext productContext, string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60037CE")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public ShopProductTypeSetting()
	{
	}
}
