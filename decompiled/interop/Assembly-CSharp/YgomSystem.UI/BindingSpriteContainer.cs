using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;

namespace YgomSystem.UI;

[Token(Token = "0x2000520")]
[AddComponentMenu("Ygom/UI/Binding/Binding Sprite Container")]
public class BindingSpriteContainer : Binding, IAsyncProgressContent
{
	[Token(Token = "0x4001918")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string spriteContainerPath;

	[Token(Token = "0x4001919")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string spriteLabel;

	[Token(Token = "0x400191A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public bool immediate;

	[Token(Token = "0x400191B")]
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	public bool showloading;

	[Token(Token = "0x400191C")]
	[FieldOffset(Offset = "0x3C")]
	private uint crc;

	[Token(Token = "0x17000363")]
	[SerializeField]
	public string SpriteContainerPath
	{
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x633A20", Offset = "0x632C20", VA = "0x180633A20")]
		set
		{
		}
	}

	[Token(Token = "0x17000364")]
	[SerializeField]
	public string SpriteLabel
	{
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x633AD0", Offset = "0x632CD0", VA = "0x180633AD0")]
		set
		{
		}
	}

	[Token(Token = "0x6002141")]
	[Address(RVA = "0x633990", Offset = "0x632B90", VA = "0x180633990")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002142")]
	[Address(RVA = "0x6339B0", Offset = "0x632BB0", VA = "0x1806339B0", Slot = "4")]
	public override void OnRebind()
	{
	}

	[Token(Token = "0x6002143")]
	[Address(RVA = "0x6335B0", Offset = "0x6327B0", VA = "0x1806335B0", Slot = "5")]
	public override bool OnBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6002144")]
	[Address(RVA = "0x633540", Offset = "0x632740", VA = "0x180633540", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6002145")]
	[Address(RVA = "0x6339C0", Offset = "0x632BC0", VA = "0x1806339C0", Slot = "8")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6002146")]
	[Address(RVA = "0x633A10", Offset = "0x632C10", VA = "0x180633A10")]
	public BindingSpriteContainer()
	{
	}
}
