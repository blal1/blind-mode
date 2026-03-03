using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomSystem.UI.MultiVCTab;

[Serializable]
[Token(Token = "0x20005D0")]
public class MultiVCTabProductGroupTopData<T> : MultiVCTabRootData where T : class, IMultiVCTabProductGruopData
{
	[Token(Token = "0x4001BFD")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[FormerlySerializedAs("m_GroupDatas")]
	private T[] m_Children;

	[Token(Token = "0x4001BFE")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, T> m_ChildrenMap;

	[Token(Token = "0x6002626")]
	public T[] GetChildren()
	{
		return null;
	}

	[Token(Token = "0x6002627")]
	public int GetActiveChildrenCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002628")]
	public T GetGroupData(int groupId)
	{
		return null;
	}

	[Token(Token = "0x6002629")]
	public void AddChildrenData(T data)
	{
	}

	[Token(Token = "0x600262A")]
	public MultiVCTabProductGroupTopData()
	{
	}
}
