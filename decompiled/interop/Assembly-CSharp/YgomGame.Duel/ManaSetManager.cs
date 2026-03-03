using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x200191B")]
public class ManaSetManager : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x400EAB0")]
	[FieldOffset(Offset = "0x20")]
	private ManaSet prefab;

	[Token(Token = "0x400EAB1")]
	private const string prefabPath = "Prefabs/Duel/ManaSet";

	[Token(Token = "0x400EAB2")]
	private const string key = "ManaSetManager";

	[Token(Token = "0x400EAB3")]
	[FieldOffset(Offset = "0x28")]
	private List<ManaSet> manasetList;

	[Token(Token = "0x170018C0")]
	public string poolKey
	{
		[Token(Token = "0x600A1D1")]
		[Address(RVA = "0xEF4E20", Offset = "0xEF4020", VA = "0x180EF4E20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C1")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600A1D2")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A1D3")]
	[Address(RVA = "0xEF47F0", Offset = "0xEF39F0", VA = "0x180EF47F0")]
	public static ManaSetManager Create(Transform parent, Action<ManaSetManager> initializedCallback)
	{
		return null;
	}

	[Token(Token = "0x600A1D4")]
	[Address(RVA = "0xEF4AC0", Offset = "0xEF3CC0", VA = "0x180EF4AC0")]
	private void Initialize(Action onFinished)
	{
	}

	[Token(Token = "0x600A1D5")]
	[Address(RVA = "0xEF4550", Offset = "0xEF3750", VA = "0x180EF4550")]
	private ManaSet CreateManaSet()
	{
		return null;
	}

	[Token(Token = "0x600A1D6")]
	[Address(RVA = "0xEF4AB0", Offset = "0xEF3CB0", VA = "0x180EF4AB0")]
	public ManaSet GetManaSet()
	{
		return null;
	}

	[Token(Token = "0x600A1D7")]
	[Address(RVA = "0xEF4D70", Offset = "0xEF3F70", VA = "0x180EF4D70")]
	public void ShowAll()
	{
	}

	[Token(Token = "0x600A1D8")]
	[Address(RVA = "0x4AEA80", Offset = "0x4ADC80", VA = "0x1804AEA80")]
	public void HideAll()
	{
	}

	[Token(Token = "0x600A1D9")]
	[Address(RVA = "0xEF4BB0", Offset = "0xEF3DB0", VA = "0x180EF4BB0", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600A1DA")]
	[Address(RVA = "0xEF4DA0", Offset = "0xEF3FA0", VA = "0x180EF4DA0")]
	public ManaSetManager()
	{
	}
}
