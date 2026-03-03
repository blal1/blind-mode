using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Token(Token = "0x20009CB")]
public class ShopCardThumbSettingLoader : MonoBehaviour
{
	[Token(Token = "0x4008DC3")]
	[FieldOffset(Offset = "0x0")]
	private static ShopCardThumbSettingLoader s_Instance;

	[Token(Token = "0x4008DC4")]
	[FieldOffset(Offset = "0x20")]
	private ShopCardThumbSettings m_Setting;

	[Token(Token = "0x4008DC5")]
	[FieldOffset(Offset = "0x28")]
	private List<(GameObject, Action<ShopCardThumbSettings>)> m_Requests;

	[Token(Token = "0x4008DC6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> m_Referer;

	[Token(Token = "0x6003BBB")]
	[Address(RVA = "0x839670", Offset = "0x838870", VA = "0x180839670")]
	public static void Load(GameObject owner, Action<ShopCardThumbSettings> callback)
	{
	}

	[Token(Token = "0x6003BBC")]
	[Address(RVA = "0x839B00", Offset = "0x838D00", VA = "0x180839B00")]
	public static void Unload(GameObject owner)
	{
	}

	[Token(Token = "0x6003BBD")]
	[Address(RVA = "0x839C50", Offset = "0x838E50", VA = "0x180839C50")]
	public ShopCardThumbSettingLoader()
	{
	}
}
