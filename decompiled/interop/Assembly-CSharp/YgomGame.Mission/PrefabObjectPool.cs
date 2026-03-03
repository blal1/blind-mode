using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Mission;

[Token(Token = "0x2000BF4")]
public class PrefabObjectPool
{
	[Token(Token = "0x400993D")]
	[FieldOffset(Offset = "0x10")]
	private readonly Transform m_Root;

	[Token(Token = "0x400993E")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<GameObject, Stack<GameObject>> m_ReusableStackMap;

	[Token(Token = "0x400993F")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<GameObject, Action<GameObject>> onCreatedCallbackMap;

	[Token(Token = "0x60048BE")]
	[Address(RVA = "0x924000", Offset = "0x923200", VA = "0x180924000")]
	private Stack<GameObject> GetReusableStack(GameObject pref)
	{
		return null;
	}

	[Token(Token = "0x60048BF")]
	[Address(RVA = "0x924340", Offset = "0x923540", VA = "0x180924340")]
	public PrefabObjectPool(Transform root)
	{
	}

	[Token(Token = "0x60048C0")]
	[Address(RVA = "0x923F10", Offset = "0x923110", VA = "0x180923F10")]
	private GameObject Create(GameObject pref, Transform owner)
	{
		return null;
	}

	[Token(Token = "0x60048C1")]
	[Address(RVA = "0x9241F0", Offset = "0x9233F0", VA = "0x1809241F0")]
	public void Reserve(GameObject pref, int count = 1)
	{
	}

	[Token(Token = "0x60048C2")]
	[Address(RVA = "0x9240F0", Offset = "0x9232F0", VA = "0x1809240F0")]
	public GameObject Rent(GameObject pref, GameObject owner)
	{
		return null;
	}

	[Token(Token = "0x60048C3")]
	[Address(RVA = "0x9242A0", Offset = "0x9234A0", VA = "0x1809242A0")]
	public void Return(GameObject pref, GameObject obj)
	{
	}
}
