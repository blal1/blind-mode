using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200056C")]
[AddComponentMenu("Ygom/UI/View Controller/Root View Controller Manager")]
public class RootViewControllerManager : ViewControllerManager
{
	[Token(Token = "0x4001A6D")]
	[FieldOffset(Offset = "0xA8")]
	public Action<ViewControllerManager> onBackEvent;

	[Token(Token = "0x170003C8")]
	public static RootViewControllerManager instance
	{
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x64DB10", Offset = "0x64CD10", VA = "0x18064DB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x64DB50", Offset = "0x64CD50", VA = "0x18064DB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002321")]
	[Address(RVA = "0x64D880", Offset = "0x64CA80", VA = "0x18064D880", Slot = "17")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6002322")]
	[Address(RVA = "0x64D970", Offset = "0x64CB70", VA = "0x18064D970", Slot = "18")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6002323")]
	[Address(RVA = "0x64DA60", Offset = "0x64CC60", VA = "0x18064DA60")]
	private void Start()
	{
	}

	[Token(Token = "0x6002324")]
	[Address(RVA = "0x64DA70", Offset = "0x64CC70", VA = "0x18064DA70", Slot = "19")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002325")]
	[Address(RVA = "0x64DAC0", Offset = "0x64CCC0", VA = "0x18064DAC0")]
	public RootViewControllerManager()
	{
	}
}
