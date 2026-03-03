using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000459")]
[DisallowMultipleComponent]
public class UIEntityDuplicator : MonoBehaviour
{
	[Token(Token = "0x4001546")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_LimitLength;

	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> m_Entities;

	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsClone;

	[Token(Token = "0x4001549")]
	[FieldOffset(Offset = "0x38")]
	public Action<GameObject, int> onUpdateEntityCallback;

	[Token(Token = "0x6001C21")]
	[Address(RVA = "0x613580", Offset = "0x612780", VA = "0x180613580")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x6135F0", Offset = "0x6127F0", VA = "0x1806135F0")]
	private void PrepareEntities(int length)
	{
	}

	[Token(Token = "0x6001C23")]
	[Address(RVA = "0x613810", Offset = "0x612A10", VA = "0x180613810")]
	public void UpdateDataCount(int dataCount)
	{
	}

	[Token(Token = "0x6001C24")]
	[Address(RVA = "0x613AB0", Offset = "0x612CB0", VA = "0x180613AB0")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6001C25")]
	[Address(RVA = "0x613B70", Offset = "0x612D70", VA = "0x180613B70")]
	public UIEntityDuplicator()
	{
	}
}
