using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EEC")]
public class DuelLiveProductGroupData : IDuelLiveProductGruopData
{
	[Token(Token = "0x400A56F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int m_GroupId;

	[Token(Token = "0x400A570")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_LabelTextId;

	[Token(Token = "0x400A571")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_Param;

	[Token(Token = "0x400A572")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsBadge;

	[Token(Token = "0x400A573")]
	[FieldOffset(Offset = "0x29")]
	private bool m_isHighlight;

	[Token(Token = "0x400A574")]
	[FieldOffset(Offset = "0x2C")]
	private int m_bgPathId;

	[Token(Token = "0x17000DFB")]
	public int groupId
	{
		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000DFC")]
	public string labelTextId
	{
		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFD")]
	public virtual string labelText
	{
		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0xA09320", Offset = "0xA08520", VA = "0x180A09320", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFE")]
	public string param
	{
		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFF")]
	public bool isBadge
	{
		[Token(Token = "0x6005A90")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E00")]
	public bool isHighlight
	{
		[Token(Token = "0x6005A91")]
		[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E01")]
	public int bgPathId
	{
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005A93")]
	[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
	public void SetGroupId(int id)
	{
	}

	[Token(Token = "0x6005A94")]
	[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
	public void SetLabelTextId(string id)
	{
	}

	[Token(Token = "0x6005A95")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetParam(string para)
	{
	}

	[Token(Token = "0x6005A96")]
	[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
	public void SetIsBadge(bool frag)
	{
	}

	[Token(Token = "0x6005A97")]
	[Address(RVA = "0x631700", Offset = "0x630900", VA = "0x180631700")]
	public void SetIsHighlight(bool frag)
	{
	}

	[Token(Token = "0x6005A98")]
	[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
	public void SetbgPathId(int id)
	{
	}

	[Token(Token = "0x6005A99")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
	public virtual bool IsMatchProduct(IProductContext product)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A9A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveProductGroupData()
	{
	}
}
