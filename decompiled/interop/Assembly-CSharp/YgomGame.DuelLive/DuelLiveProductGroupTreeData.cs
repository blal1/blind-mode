using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EED")]
public class DuelLiveProductGroupTreeData<T> : DuelLiveProductGroupData where T : class, IDuelLiveProductGruopData
{
	[Token(Token = "0x400A575")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[FormerlySerializedAs("m_GroupDatas")]
	private T[] m_Children;

	[Token(Token = "0x400A576")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, T> m_ChildrenMap;

	[Token(Token = "0x6005A9B")]
	public T[] GetChildren()
	{
		return null;
	}

	[Token(Token = "0x6005A9C")]
	public T GetGroupData(int groupId)
	{
		return null;
	}

	[Token(Token = "0x6005A9D")]
	public void AddChildrenData(T data)
	{
	}

	[Token(Token = "0x6005A9E")]
	public DuelLiveProductGroupTreeData()
	{
	}
}
