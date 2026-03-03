using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F09")]
public class DuelLiveWidgetMapSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000F0A")]
	public class Container
	{
		[Token(Token = "0x400A5CE")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400A5CF")]
		[FieldOffset(Offset = "0x18")]
		public int templateId;

		[Token(Token = "0x400A5D0")]
		[FieldOffset(Offset = "0x1C")]
		public bool isSelectable;

		[Token(Token = "0x400A5D1")]
		[FieldOffset(Offset = "0x1D")]
		public bool isInnerTemplate;

		[Token(Token = "0x400A5D2")]
		[FieldOffset(Offset = "0x20")]
		public UnityEngine.Object asset;

		[Token(Token = "0x6005B06")]
		[Address(RVA = "0xA01870", Offset = "0xA00A70", VA = "0x180A01870")]
		public Container()
		{
		}
	}

	[Token(Token = "0x400A5CD")]
	[FieldOffset(Offset = "0x18")]
	public List<Container> containers;

	[Token(Token = "0x6005AFE")]
	[Address(RVA = "0xA13FA0", Offset = "0xA131A0", VA = "0x180A13FA0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6005AFF")]
	[Address(RVA = "0xA13E50", Offset = "0xA13050", VA = "0x180A13E50")]
	public Container GetContainer(string label)
	{
		return null;
	}

	[Token(Token = "0x6005B00")]
	[Address(RVA = "0xA13CD0", Offset = "0xA12ED0", VA = "0x180A13CD0")]
	public UnityEngine.Object GetAsset(string label)
	{
		return null;
	}

	[Token(Token = "0x6005B01")]
	public T GetAsset<T>(string label) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6005B02")]
	[Address(RVA = "0xA13D10", Offset = "0xA12F10", VA = "0x180A13D10")]
	public Container GetContainer(int tempId)
	{
		return null;
	}

	[Token(Token = "0x6005B03")]
	[Address(RVA = "0xA13CF0", Offset = "0xA12EF0", VA = "0x180A13CF0")]
	public UnityEngine.Object GetAsset(int id)
	{
		return null;
	}

	[Token(Token = "0x6005B04")]
	public T GetAsset<T>(int id) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6005B05")]
	[Address(RVA = "0xA140C0", Offset = "0xA132C0", VA = "0x180A140C0")]
	public DuelLiveWidgetMapSettings()
	{
	}
}
