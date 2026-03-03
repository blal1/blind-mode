using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu;

[Token(Token = "0x2001176")]
public class SaveDialogViewController : DialogViewControllerBase, IBokeSupported
{
	[Token(Token = "0x400B752")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject prefab;

	[Token(Token = "0x6006D74")]
	[Address(RVA = "0xB506E0", Offset = "0xB4F8E0", VA = "0x180B506E0")]
	private static bool LoadPrefab()
	{
		return default(bool);
	}

	[Token(Token = "0x6006D75")]
	[Address(RVA = "0xB508A0", Offset = "0xB4FAA0", VA = "0x180B508A0")]
	public static void Open(string title, string message, string button1Label, Action button1Action, string button2Label, Action button2Action, string button3Label, Action button3Action)
	{
	}

	[Token(Token = "0x6006D76")]
	[Address(RVA = "0xB511B0", Offset = "0xB503B0", VA = "0x180B511B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006D77")]
	[Address(RVA = "0xB50BE0", Offset = "0xB4FDE0", VA = "0x180B50BE0")]
	private void SetupUI()
	{
	}

	[Token(Token = "0x6006D78")]
	[Address(RVA = "0xB50810", Offset = "0xB4FA10", VA = "0x180B50810", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006D79")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public SaveDialogViewController()
	{
	}
}
