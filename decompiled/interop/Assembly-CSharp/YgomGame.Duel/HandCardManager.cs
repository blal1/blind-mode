using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001A41")]
public class HandCardManager
{
	[Token(Token = "0x2001A42")]
	public class HandInfo
	{
		[Token(Token = "0x400F25A")]
		[FieldOffset(Offset = "0x10")]
		public int m_Mrk;

		[Token(Token = "0x400F25B")]
		[FieldOffset(Offset = "0x14")]
		public int m_UniqueId;

		[Token(Token = "0x400F25C")]
		[FieldOffset(Offset = "0x18")]
		public bool m_IsHide;

		[Token(Token = "0x400F25D")]
		[FieldOffset(Offset = "0x1C")]
		public int m_styleID;

		[Token(Token = "0x400F25E")]
		[FieldOffset(Offset = "0x20")]
		public int m_ViewIndex;

		[Token(Token = "0x600AA56")]
		[Address(RVA = "0xF6EE80", Offset = "0xF6E080", VA = "0x180F6EE80")]
		public HandInfo()
		{
		}
	}

	[Token(Token = "0x2001A43")]
	public enum ViewSortMode
	{
		[Token(Token = "0x400F260")]
		EngineIndex,
		[Token(Token = "0x400F261")]
		Random,
		[Token(Token = "0x400F262")]
		Custom
	}

	[Token(Token = "0x2001A44")]
	public enum DispMode
	{
		[Token(Token = "0x400F264")]
		Full,
		[Token(Token = "0x400F265")]
		Small
	}

	[Token(Token = "0x400F250")]
	[FieldOffset(Offset = "0x10")]
	private List<HandInfo> nearHandInfoList;

	[Token(Token = "0x400F251")]
	[FieldOffset(Offset = "0x18")]
	private List<HandInfo> farHandInfoList;

	[Token(Token = "0x400F254")]
	[FieldOffset(Offset = "0x0")]
	public static DefinitionSetting handCardDefinision;

	[Token(Token = "0x400F258")]
	[FieldOffset(Offset = "0x34")]
	private DispMode _nearHandDispMode;

	[Token(Token = "0x17001A42")]
	public bool nearAllOpen
	{
		[Token(Token = "0x600AA17")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AA18")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001A43")]
	public bool farAllOpen
	{
		[Token(Token = "0x600AA19")]
		[Address(RVA = "0x5D7890", Offset = "0x5D6A90", VA = "0x1805D7890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AA1A")]
		[Address(RVA = "0x671010", Offset = "0x670210", VA = "0x180671010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001A44")]
	public DuelClient host
	{
		[Token(Token = "0x600AA1C")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AA1D")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001A45")]
	public bool isInitialized
	{
		[Token(Token = "0x600AA1F")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AA20")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A46")]
	public bool isTerminated
	{
		[Token(Token = "0x600AA22")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AA23")]
		[Address(RVA = "0x768DE0", Offset = "0x767FE0", VA = "0x180768DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A47")]
	public DispMode nearHandDispMode
	{
		[Token(Token = "0x600AA51")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(DispMode);
		}
		[Token(Token = "0x600AA52")]
		[Address(RVA = "0xF6AC80", Offset = "0xF69E80", VA = "0x180F6AC80")]
		set
		{
		}
	}

	[Token(Token = "0x17001A48")]
	public Action<DispMode> onNearHandDispModeChanged
	{
		[Token(Token = "0x600AA53")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AA54")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600AA1B")]
	[Address(RVA = "0xF68670", Offset = "0xF67870", VA = "0x180F68670")]
	public static HandCardManager Create(DuelClient host)
	{
		return null;
	}

	[Token(Token = "0x600AA1E")]
	[Address(RVA = "0xF68FC0", Offset = "0xF681C0", VA = "0x180F68FC0")]
	private void Initialize(DuelClient host)
	{
	}

	[Token(Token = "0x600AA21")]
	[Address(RVA = "0xF6ABB0", Offset = "0xF69DB0", VA = "0x180F6ABB0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600AA24")]
	[Address(RVA = "0xF68630", Offset = "0xF67830", VA = "0x180F68630")]
	public void AddNearHandCard(int mrk, int unique_id, int index = -1, bool is_hide = false, ViewSortMode sortMode = ViewSortMode.EngineIndex)
	{
	}

	[Token(Token = "0x600AA25")]
	[Address(RVA = "0xF68460", Offset = "0xF67660", VA = "0x180F68460")]
	public void AddFarHandCard(int mrk, int unique_id, int index = -1, bool is_hide = false, ViewSortMode sortMode = ViewSortMode.EngineIndex)
	{
	}

	[Token(Token = "0x600AA26")]
	[Address(RVA = "0xF684A0", Offset = "0xF676A0", VA = "0x180F684A0")]
	private void AddHandCard(List<HandInfo> info_list, int mrk, int unique_id, int index = -1, bool is_hide = false, ViewSortMode sortMode = ViewSortMode.EngineIndex)
	{
	}

	[Token(Token = "0x600AA27")]
	[Address(RVA = "0xF696C0", Offset = "0xF688C0", VA = "0x180F696C0")]
	public void SetNearHandInfo(int index, int mrk)
	{
	}

	[Token(Token = "0x600AA28")]
	[Address(RVA = "0xF693A0", Offset = "0xF685A0", VA = "0x180F693A0")]
	public void SetFarHandInfo(int index, int mrk)
	{
	}

	[Token(Token = "0x600AA29")]
	[Address(RVA = "0xF694B0", Offset = "0xF686B0", VA = "0x180F694B0")]
	private void SetHandCardInfo(List<HandInfo> infoList, int index, int mrk)
	{
	}

	[Token(Token = "0x600AA2A")]
	[Address(RVA = "0xF69390", Offset = "0xF68590", VA = "0x180F69390")]
	public void RemoveNearHandCard(int index)
	{
	}

	[Token(Token = "0x600AA2B")]
	[Address(RVA = "0xF692B0", Offset = "0xF684B0", VA = "0x180F692B0")]
	public void RemoveFarHandCard(int index)
	{
	}

	[Token(Token = "0x600AA2C")]
	[Address(RVA = "0xF692C0", Offset = "0xF684C0", VA = "0x180F692C0")]
	private void RemoveHandCard(List<HandInfo> info_list, int index)
	{
	}

	[Token(Token = "0x600AA2D")]
	[Address(RVA = "0xF68CC0", Offset = "0xF67EC0", VA = "0x180F68CC0")]
	public int GetNearHandCardNum()
	{
		return default(int);
	}

	[Token(Token = "0x600AA2E")]
	[Address(RVA = "0xF68770", Offset = "0xF67970", VA = "0x180F68770")]
	public int GetFarHandCardNum()
	{
		return default(int);
	}

	[Token(Token = "0x600AA2F")]
	[Address(RVA = "0xF6ABA0", Offset = "0xF69DA0", VA = "0x180F6ABA0")]
	public bool SyncNearHandInfo(int[] uniqueIdList)
	{
		return default(bool);
	}

	[Token(Token = "0x600AA30")]
	[Address(RVA = "0xF6AA30", Offset = "0xF69C30", VA = "0x180F6AA30")]
	public bool SyncFarHandInfo(int[] uniqueIdList)
	{
		return default(bool);
	}

	[Token(Token = "0x600AA31")]
	[Address(RVA = "0xF6AA40", Offset = "0xF69C40", VA = "0x180F6AA40")]
	private bool SyncHandInfo(List<HandInfo> info_list, int[] uniqueIdList)
	{
		return default(bool);
	}

	[Token(Token = "0x600AA32")]
	[Address(RVA = "0xF68D00", Offset = "0xF67F00", VA = "0x180F68D00")]
	public HandInfo GetNearHandInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x600AA33")]
	[Address(RVA = "0xF687B0", Offset = "0xF679B0", VA = "0x180F687B0")]
	public HandInfo GetFarHandInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x600AA34")]
	[Address(RVA = "0xF689E0", Offset = "0xF67BE0", VA = "0x180F689E0")]
	private HandInfo GetHandInfo(List<HandInfo> info_list, int index)
	{
		return null;
	}

	[Token(Token = "0x600AA35")]
	[Address(RVA = "0xF69850", Offset = "0xF68A50", VA = "0x180F69850")]
	public void SetupNearViewIndex(ViewSortMode sortMode)
	{
	}

	[Token(Token = "0x600AA36")]
	[Address(RVA = "0xF697D0", Offset = "0xF689D0", VA = "0x180F697D0")]
	public void SetupFarViewIndex(ViewSortMode sortMode)
	{
	}

	[Token(Token = "0x600AA37")]
	[Address(RVA = "0xF6A850", Offset = "0xF69A50", VA = "0x180F6A850")]
	private void SetupViewIndex(List<HandInfo> infoList, ViewSortMode sortMode)
	{
	}

	[Token(Token = "0x600AA38")]
	[Address(RVA = "0xF6A660", Offset = "0xF69860", VA = "0x180F6A660")]
	private void SetupViewIndexEngineIndex(List<HandInfo> infoList)
	{
	}

	[Token(Token = "0x600AA39")]
	[Address(RVA = "0xF6A6E0", Offset = "0xF698E0", VA = "0x180F6A6E0")]
	private void SetupViewIndexRandom(List<HandInfo> infoList)
	{
	}

	[Token(Token = "0x600AA3A")]
	[Address(RVA = "0xF69890", Offset = "0xF68A90", VA = "0x180F69890")]
	private void SetupViewIndexCustom(List<HandInfo> infoList)
	{
	}

	[Token(Token = "0x600AA3B")]
	[Address(RVA = "0xF690A0", Offset = "0xF682A0", VA = "0x180F690A0")]
	public void InsertNearViewIndex(int targetIndex, int insertViewIndex)
	{
	}

	[Token(Token = "0x600AA3C")]
	[Address(RVA = "0xF69050", Offset = "0xF68250", VA = "0x180F69050")]
	public void InsertFarViewIndex(int targetIndex, int insertViewIndex)
	{
	}

	[Token(Token = "0x600AA3D")]
	[Address(RVA = "0xF69190", Offset = "0xF68390", VA = "0x180F69190")]
	private void InsertViewIndex(List<HandInfo> infoList, int targetIndex, int insertViewIndex)
	{
	}

	[Token(Token = "0x600AA3E")]
	[Address(RVA = "0xF69080", Offset = "0xF68280", VA = "0x180F69080")]
	public void InsertNearViewIndexIfOpen()
	{
	}

	[Token(Token = "0x600AA3F")]
	[Address(RVA = "0xF68FE0", Offset = "0xF681E0", VA = "0x180F68FE0")]
	public void InsertFarViewIndexIfOpen()
	{
	}

	[Token(Token = "0x600AA40")]
	[Address(RVA = "0xF690D0", Offset = "0xF682D0", VA = "0x180F690D0")]
	private void InsertViewIndexIfOpen(List<HandInfo> infoList, int insertViewIndex)
	{
	}

	[Token(Token = "0x600AA41")]
	[Address(RVA = "0xF68EA0", Offset = "0xF680A0", VA = "0x180F68EA0")]
	public int GetNearViewIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600AA42")]
	[Address(RVA = "0xF68950", Offset = "0xF67B50", VA = "0x180F68950")]
	public int GetFarViewIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600AA43")]
	[Address(RVA = "0xF68F30", Offset = "0xF68130", VA = "0x180F68F30")]
	public int GetViewIndex(List<HandInfo> infoList, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600AA44")]
	[Address(RVA = "0xF68E10", Offset = "0xF68010", VA = "0x180F68E10")]
	public int GetNearIndexByViewIndex(int viewIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600AA45")]
	[Address(RVA = "0xF688C0", Offset = "0xF67AC0", VA = "0x180F688C0")]
	public int GetFarIndexByViewIndex(int viewIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600AA46")]
	[Address(RVA = "0xF68C20", Offset = "0xF67E20", VA = "0x180F68C20")]
	private int GetIndexByViewIndex(List<HandInfo> infoList, int viewIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600AA47")]
	[Address(RVA = "0xF68D80", Offset = "0xF67F80", VA = "0x180F68D80")]
	public int GetNearIndexByUniqueID(int uniqueID)
	{
		return default(int);
	}

	[Token(Token = "0x600AA48")]
	[Address(RVA = "0xF68830", Offset = "0xF67A30", VA = "0x180F68830")]
	public int GetFarIndexByUniqueID(int uniqueID)
	{
		return default(int);
	}

	[Token(Token = "0x600AA49")]
	[Address(RVA = "0xF68B80", Offset = "0xF67D80", VA = "0x180F68B80")]
	private int GetIndexByUniqueID(List<HandInfo> infoList, int uniqueID)
	{
		return default(int);
	}

	[Token(Token = "0x600AA4A")]
	[Address(RVA = "0xF69750", Offset = "0xF68950", VA = "0x180F69750")]
	public void SetNearHide(int index, bool hide)
	{
	}

	[Token(Token = "0x600AA4B")]
	[Address(RVA = "0xF69430", Offset = "0xF68630", VA = "0x180F69430")]
	public void SetFarHide(int index, bool hide)
	{
	}

	[Token(Token = "0x600AA4C")]
	[Address(RVA = "0xF69640", Offset = "0xF68840", VA = "0x180F69640")]
	private void SetHide(List<HandInfo> infoList, int index, bool hide)
	{
	}

	[Token(Token = "0x600AA4D")]
	[Address(RVA = "0xF69740", Offset = "0xF68940", VA = "0x180F69740")]
	public void SetNearHideAll(bool hide)
	{
	}

	[Token(Token = "0x600AA4E")]
	[Address(RVA = "0xF69420", Offset = "0xF68620", VA = "0x180F69420")]
	public void SetFarHideAll(bool hide)
	{
	}

	[Token(Token = "0x600AA4F")]
	[Address(RVA = "0xF69530", Offset = "0xF68730", VA = "0x180F69530")]
	private void SetHideAll(List<HandInfo> infoList, bool hide)
	{
	}

	[Token(Token = "0x600AA50")]
	[Address(RVA = "0xF68A60", Offset = "0xF67C60", VA = "0x180F68A60")]
	private int GetIconSortPoint(int cardid)
	{
		return default(int);
	}

	[Token(Token = "0x600AA55")]
	[Address(RVA = "0xF6ABD0", Offset = "0xF69DD0", VA = "0x180F6ABD0")]
	public HandCardManager()
	{
	}
}
