using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Shop;

[Token(Token = "0x20009DE")]
public class TicketInventoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20009DF")]
	private class Context : IComparable<Context>
	{
		[Token(Token = "0x4008E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int shopId;

		[Token(Token = "0x4008E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly bool currentShopTarget;

		[Token(Token = "0x4008E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public readonly bool isPeriod;

		[Token(Token = "0x4008E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int itemCategory;

		[Token(Token = "0x4008E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly int itemId;

		[Token(Token = "0x4008E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly int priceIdx;

		[Token(Token = "0x4008E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ProductContext m_ProductContext;

		[Token(Token = "0x170007EC")]
		public ProductContext productContext
		{
			[Token(Token = "0x6003C28")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007ED")]
		public long limitdateTs
		{
			[Token(Token = "0x6003C29")]
			[Address(RVA = "0x821990", Offset = "0x820B90", VA = "0x180821990")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170007EE")]
		public string limitdate
		{
			[Token(Token = "0x6003C2A")]
			[Address(RVA = "0x821A20", Offset = "0x820C20", VA = "0x180821A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EF")]
		public int itemHave
		{
			[Token(Token = "0x6003C2B")]
			[Address(RVA = "0x821970", Offset = "0x820B70", VA = "0x180821970")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x821900", Offset = "0x820B00", VA = "0x180821900")]
		public Context(int shopId, bool currentShopId, bool isPeriod, int itemCategory, int itemId, int priceIdx, ProductContext productContext)
		{
		}

		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x821830", Offset = "0x820A30", VA = "0x180821830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x58A430", Offset = "0x589630", VA = "0x18058A430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x821740", Offset = "0x820940", VA = "0x180821740")]
		public int Compare(Context a, Context b)
		{
			return default(int);
		}

		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x821650", Offset = "0x820850", VA = "0x180821650", Slot = "4")]
		public int CompareTo(Context other)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4008E03")]
	private const string k_ArgsCurrentShopId = "priceContexts";

	[Token(Token = "0x4008E04")]
	private const string k_ELabelScrollView = "ScrollView";

	[Token(Token = "0x4008E05")]
	private const string k_ELabelTextEmpty = "TextEmpty";

	[Token(Token = "0x4008E06")]
	private const string k_ELabelEntity_On = "On";

	[Token(Token = "0x4008E07")]
	private const string k_ELabelEntity_Off = "Off";

	[Token(Token = "0x4008E08")]
	private const string k_ELabelEntity_TicketThumbHolder = "TicketThumbHolder";

	[Token(Token = "0x4008E09")]
	private const string k_ELabelEntity_ProductThumbHolder = "ProductThumbHolder";

	[Token(Token = "0x4008E0A")]
	private const string k_ELabelEntity_TextName = "TextName";

	[Token(Token = "0x4008E0B")]
	private const string k_ELabelEntity_PriceTimeLimitIcon = "PriceTimeLimitIcon";

	[Token(Token = "0x4008E0C")]
	private const string k_OLabel_ThumbOvLabel = "Inventory";

	[Token(Token = "0x4008E0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x4008E0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<Context> m_Contexts;

	[Token(Token = "0x4008E0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Dictionary<int, ProductContext> m_ProductContextCacheMap;

	[Token(Token = "0x4008E10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int[] m_UsableShopIds;

	[Token(Token = "0x4008E11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private long m_LaunchTs;

	[Token(Token = "0x170007EB")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003C1D")]
		[Address(RVA = "0x841F50", Offset = "0x841150", VA = "0x180841F50", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003C1E")]
	[Address(RVA = "0x8416D0", Offset = "0x8408D0", VA = "0x1808416D0")]
	public static void Open(int currentShopId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003C1F")]
	[Address(RVA = "0x841660", Offset = "0x840860", VA = "0x180841660")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003C20")]
	[Address(RVA = "0x841D30", Offset = "0x840F30", VA = "0x180841D30")]
	private ProductContext TryGetProductContext(int shopId)
	{
		return null;
	}

	[Token(Token = "0x6003C21")]
	[Address(RVA = "0x8403C0", Offset = "0x83F5C0", VA = "0x1808403C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003C22")]
	[Address(RVA = "0x841870", Offset = "0x840A70", VA = "0x180841870")]
	private Context TryCreateTicketContexts(int currentShopId, bool isPeriod, int itemCategory, int itemId, int usableShopId)
	{
		return null;
	}

	[Token(Token = "0x6003C23")]
	[Address(RVA = "0x840D60", Offset = "0x83FF60", VA = "0x180840D60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003C24")]
	[Address(RVA = "0x8417E0", Offset = "0x8409E0", VA = "0x1808417E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003C25")]
	[Address(RVA = "0x840FC0", Offset = "0x8401C0", VA = "0x180840FC0")]
	private void OnUpdateEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x6003C26")]
	[Address(RVA = "0x840B70", Offset = "0x83FD70", VA = "0x180840B70")]
	private void OnClickEntity(int idx)
	{
	}

	[Token(Token = "0x6003C27")]
	[Address(RVA = "0x841E80", Offset = "0x841080", VA = "0x180841E80")]
	public TicketInventoryViewController()
	{
	}
}
