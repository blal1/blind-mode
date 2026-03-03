using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomSystem.UI.MultiVCTab;

[Serializable]
[Token(Token = "0x20005CF")]
public class MultiVCTabProductGroupTreeData<T> : MultiVCTabProductGroupData where T : class, IMultiVCTabProductGruopData
{
	[Token(Token = "0x4001BF9")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[FormerlySerializedAs("m_GroupDatas")]
	private T[] m_Children;

	[Token(Token = "0x4001BFA")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, T> m_ChildrenMap;

	[Token(Token = "0x4001BFB")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private MultiVCTabProductGroupData[] m_HorizonSubTab;

	[Token(Token = "0x4001BFC")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, MultiVCTabProductGroupData> m_HorizonSubTabMap;

	[Token(Token = "0x600261F")]
	public T[] GetChildren()
	{
		return null;
	}

	[Token(Token = "0x6002620")]
	public int GetActiveChildrenCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002621")]
	public MultiVCTabProductGroupData[] GetHorizonSubTab()
	{
		return null;
	}

	[Token(Token = "0x6002622")]
	public T GetGroupData(int groupId)
	{
		return null;
	}

	[Token(Token = "0x6002623")]
	public MultiVCTabProductGroupData GetHorizonSubTabDate(int groupId)
	{
		return null;
	}

	[Token(Token = "0x6002624")]
	public void AddChildrenData(T data)
	{
	}

	[Token(Token = "0x6002625")]
	public MultiVCTabProductGroupTreeData()
	{
	}
}
