using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000254")]
public class DynamicAtlasSettings
{
	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	private int m_MinAtlasSize;

	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	[SerializeField]
	private int m_MaxAtlasSize;

	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private int m_MaxSubTextureSize;

	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasFilters m_ActiveFilters;

	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x20")]
	private DynamicAtlasCustomFilter m_CustomFilter;

	[Token(Token = "0x170002F5")]
	public int minAtlasSize
	{
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		set
		{
		}
	}

	[Token(Token = "0x170002F6")]
	public int maxAtlasSize
	{
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		set
		{
		}
	}

	[Token(Token = "0x170002F7")]
	public int maxSubTextureSize
	{
		[Token(Token = "0x6001039")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		set
		{
		}
	}

	[Token(Token = "0x170002F8")]
	public DynamicAtlasFilters activeFilters
	{
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
		get
		{
			return default(DynamicAtlasFilters);
		}
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
		set
		{
		}
	}

	[Token(Token = "0x170002F9")]
	public static DynamicAtlasFilters defaultFilters
	{
		[Token(Token = "0x600103D")]
		[Address(RVA = "0x2B2A2A0", Offset = "0x2B294A0", VA = "0x182B2A2A0")]
		get
		{
			return default(DynamicAtlasFilters);
		}
	}

	[Token(Token = "0x170002FA")]
	public DynamicAtlasCustomFilter customFilter
	{
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x600103F")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x170002FB")]
	public static DynamicAtlasSettings defaults
	{
		[Token(Token = "0x6001040")]
		[Address(RVA = "0x2B2A2B0", Offset = "0x2B294B0", VA = "0x182B2A2B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001041")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DynamicAtlasSettings()
	{
	}
}
