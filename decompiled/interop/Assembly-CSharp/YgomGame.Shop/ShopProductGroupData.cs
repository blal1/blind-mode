using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomGame.Shop;

[Serializable]
[Token(Token = "0x200092B")]
public class ShopProductGroupData : IShopProductGruopData
{
	[Token(Token = "0x4008A0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string k_NobrFormat;

	[Token(Token = "0x4008A10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int m_GroupId;

	[Token(Token = "0x4008A11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_LabelTextId;

	[Token(Token = "0x4008A12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_LabelNobr;

	[Token(Token = "0x4008A13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool m_Constant;

	[Token(Token = "0x4008A14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string m_ProductWidgetLabel;

	[Token(Token = "0x4008A15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("m_BackGroundType")]
	private int m_BgId;

	[Token(Token = "0x4008A16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool m_SkipSoldoutSort;

	[Token(Token = "0x4008A17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[SerializeField]
	private bool m_IsShortPayAmountSort;

	[Token(Token = "0x4008A18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[SerializeField]
	private bool m_IgnoreTurnoffBadge;

	[Token(Token = "0x4008A19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string m_TabIcon;

	[Token(Token = "0x1700071B")]
	public int groupId
	{
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700071C")]
	public string labelTextId
	{
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071D")]
	public virtual string labelText
	{
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x7DCFD0", Offset = "0x7DC1D0", VA = "0x1807DCFD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071E")]
	public bool constant
	{
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700071F")]
	public virtual bool existsDescButton
	{
		[Token(Token = "0x600379E")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000720")]
	public virtual string descButtonLabel
	{
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000721")]
	public virtual Action descButtonAction
	{
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60037A1")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "15")]
	public virtual bool IsMatchProduct(ProductContext product)
	{
		return default(bool);
	}

	[Token(Token = "0x60037A2")]
	[Address(RVA = "0x7DCD80", Offset = "0x7DBF80", VA = "0x1807DCD80")]
	public bool FindBoolData(string key, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60037A3")]
	[Address(RVA = "0x7DCE60", Offset = "0x7DC060", VA = "0x1807DCE60", Slot = "9")]
	public int FindIntData(string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60037A4")]
	[Address(RVA = "0x7DCEC0", Offset = "0x7DC0C0", VA = "0x1807DCEC0", Slot = "10")]
	public string FindStringData(string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60037A5")]
	[Address(RVA = "0x7DCF70", Offset = "0x7DC170", VA = "0x1807DCF70")]
	public ShopProductGroupData()
	{
	}
}
