using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000519")]
[AddComponentMenu("Ygom/UI/Binding/Binding Image")]
public class BindingImage : Binding
{
	[Token(Token = "0x40018F5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string spritePath;

	[Token(Token = "0x40018F6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool immediate;

	[Token(Token = "0x40018F7")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	public bool showloading;

	[Token(Token = "0x40018F8")]
	[FieldOffset(Offset = "0x38")]
	private string materialPath;

	[Token(Token = "0x40018F9")]
	[FieldOffset(Offset = "0x40")]
	private uint crc;

	[Token(Token = "0x40018FA")]
	[FieldOffset(Offset = "0x44")]
	private uint usingCrc;

	[Token(Token = "0x40018FB")]
	[FieldOffset(Offset = "0x48")]
	private string loadPath;

	[Token(Token = "0x40018FC")]
	[FieldOffset(Offset = "0x50")]
	private uint materialCrc;

	[Token(Token = "0x40018FD")]
	[FieldOffset(Offset = "0x54")]
	private uint materialUsingCrc;

	[Token(Token = "0x40018FE")]
	[FieldOffset(Offset = "0x58")]
	private bool isDoneMaterial;

	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x60")]
	private string assetContainerLabel;

	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x68")]
	private Type assetType;

	[Token(Token = "0x17000357")]
	[SerializeField]
	public string SpritePath
	{
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x632CE0", Offset = "0x631EE0", VA = "0x180632CE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000358")]
	public string MaterialPath
	{
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x632C30", Offset = "0x631E30", VA = "0x180632C30")]
		set
		{
		}
	}

	[Token(Token = "0x600210D")]
	[Address(RVA = "0x632BC0", Offset = "0x631DC0", VA = "0x180632BC0", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x600210E")]
	[Address(RVA = "0x632840", Offset = "0x631A40", VA = "0x180632840")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600210F")]
	[Address(RVA = "0x6329D0", Offset = "0x631BD0", VA = "0x1806329D0", Slot = "4")]
	public override void OnRebind()
	{
	}

	[Token(Token = "0x6002110")]
	[Address(RVA = "0x631BE0", Offset = "0x630DE0", VA = "0x180631BE0", Slot = "5")]
	public override bool OnBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6002111")]
	[Address(RVA = "0x631AA0", Offset = "0x630CA0", VA = "0x180631AA0")]
	private bool OnBindingMaterial()
	{
		return default(bool);
	}

	[Token(Token = "0x6002112")]
	[Address(RVA = "0x632A20", Offset = "0x631C20", VA = "0x180632A20")]
	private void SetMaterial(Material material)
	{
	}

	[Token(Token = "0x6002113")]
	[Address(RVA = "0x51AA40", Offset = "0x519C40", VA = "0x18051AA40")]
	public BindingImage()
	{
	}
}
