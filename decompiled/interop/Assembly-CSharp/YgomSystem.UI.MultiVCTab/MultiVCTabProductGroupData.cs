using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.MultiVCTab;

[Serializable]
[Token(Token = "0x20005CE")]
public class MultiVCTabProductGroupData : IMultiVCTabProductGruopData
{
	[Token(Token = "0x4001BF1")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int m_GroupId;

	[Token(Token = "0x4001BF2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_LabelTextId;

	[Token(Token = "0x4001BF3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_Param;

	[Token(Token = "0x4001BF4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_PrefabPath;

	[Token(Token = "0x4001BF5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_IsDescendingChildOrder;

	[Token(Token = "0x4001BF6")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool m_IsDescendingHorizonOrder;

	[Token(Token = "0x4001BF7")]
	[FieldOffset(Offset = "0x32")]
	[HideInInspector]
	public bool isActive;

	[Token(Token = "0x4001BF8")]
	[FieldOffset(Offset = "0x33")]
	[HideInInspector]
	public bool isBadge;

	[Token(Token = "0x17000485")]
	public string prefabPath
	{
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000486")]
	public int groupId
	{
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000487")]
	public string labelTextId
	{
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000488")]
	public virtual string labelText
	{
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x696AA0", Offset = "0x695CA0", VA = "0x180696AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000489")]
	public bool isDescendingChildOrder
	{
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700048A")]
	public bool isDescendingHorizonOrder
	{
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700048B")]
	public string param
	{
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600261A")]
	[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
	public void SetGroupId(int id)
	{
	}

	[Token(Token = "0x600261B")]
	[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
	public void SetLabelTextId(string id)
	{
	}

	[Token(Token = "0x600261C")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetParam(string para)
	{
	}

	[Token(Token = "0x600261D")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetPrefabPath(string path)
	{
	}

	[Token(Token = "0x600261E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MultiVCTabProductGroupData()
	{
	}
}
