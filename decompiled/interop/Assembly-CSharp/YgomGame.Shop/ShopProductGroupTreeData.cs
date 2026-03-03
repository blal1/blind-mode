using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomGame.Shop;

[Serializable]
[Token(Token = "0x200092C")]
public class ShopProductGroupTreeData<T> : ShopProductGroupData where T : class, IShopProductGruopData
{
	[Token(Token = "0x4008A1A")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[FormerlySerializedAs("m_GroupDatas")]
	private T[] m_Children;

	[Token(Token = "0x4008A1B")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, T> m_ChildrenMap;

	[Token(Token = "0x17000722")]
	public T[] children
	{
		[Token(Token = "0x60037A6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60037A7")]
	public T GetGroupData(int groupId)
	{
		return null;
	}

	[Token(Token = "0x60037A8")]
	public ShopProductGroupTreeData()
	{
	}
}
