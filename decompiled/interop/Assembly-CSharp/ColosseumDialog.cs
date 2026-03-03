using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Colosseum;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

[Token(Token = "0x2000032")]
public class ColosseumDialog : MonoBehaviour
{
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x28")]
	public bool isOpen;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x30")]
	public Selector selector;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x38")]
	public Action<bool> onOpened;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x40")]
	public Action<bool> onClosed;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 openPos;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 closePos;

	[Token(Token = "0x17000012")]
	public ElementObjectManager eom
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x3D7F00", Offset = "0x3D7100", VA = "0x1803D7F00", Slot = "4")]
	public virtual void Initialize(ColosseumDialogMangaer manager)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x3D8140", Offset = "0x3D7340", VA = "0x1803D8140")]
	internal void Open(bool isTween = true)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x3D7D60", Offset = "0x3D6F60", VA = "0x1803D7D60")]
	internal void Close(bool isTween = true)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	internal virtual void UpdateData(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3D82E0", Offset = "0x3D74E0", VA = "0x1803D82E0")]
	public ColosseumDialog()
	{
	}
}
