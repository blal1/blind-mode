using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A80")]
public class ScenarioPrefabContainer : ScenarioContainerBase
{
	[Token(Token = "0x4009285")]
	[FieldOffset(Offset = "0x28")]
	private readonly int k_LocatorLen;

	[Token(Token = "0x4009286")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLocatorFormat;

	[Token(Token = "0x4009287")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_PrefLabelBg;

	[Token(Token = "0x4009288")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<string, GameObject> m_CreatedObjectMap;

	[Token(Token = "0x4009289")]
	[FieldOffset(Offset = "0x48")]
	private readonly Transform[] m_BackUILocators;

	[Token(Token = "0x400928A")]
	[FieldOffset(Offset = "0x50")]
	public readonly ElementObjectManager backUIEom;

	[Token(Token = "0x400928B")]
	[FieldOffset(Offset = "0x58")]
	public Action<string, GameObject> onCreateCallback;

	[Token(Token = "0x60040B4")]
	[Address(RVA = "0x88C430", Offset = "0x88B630", VA = "0x18088C430")]
	public bool isBgLabel(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x60040B5")]
	[Address(RVA = "0x88E400", Offset = "0x88D600", VA = "0x18088E400")]
	public ScenarioPrefabContainer(ElementObjectManager backUIEom)
	{
	}

	[Token(Token = "0x60040B6")]
	[Address(RVA = "0x88DE40", Offset = "0x88D040", VA = "0x18088DE40")]
	public void CreatePrefabObject(string label, string path, int locateSlot, Action<GameObject> onComplete)
	{
	}

	[Token(Token = "0x60040B7")]
	[Address(RVA = "0x88E310", Offset = "0x88D510", VA = "0x18088E310")]
	public GameObject GetCreatedGameObject(string label)
	{
		return null;
	}

	[Token(Token = "0x60040B8")]
	[Address(RVA = "0x88E180", Offset = "0x88D380", VA = "0x18088E180")]
	public GameObject[] FindBGObjects()
	{
		return null;
	}

	[Token(Token = "0x60040B9")]
	[Address(RVA = "0x88E090", Offset = "0x88D290", VA = "0x18088E090")]
	public bool DestroyPrefabObject(string label)
	{
		return default(bool);
	}
}
