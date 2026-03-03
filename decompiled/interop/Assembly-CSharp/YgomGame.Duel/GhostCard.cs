using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001A3F")]
public class GhostCard : MonoBehaviour
{
	[Token(Token = "0x400F23E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int cardID;

	[Token(Token = "0x400F23F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int sleeveID;

	[Token(Token = "0x400F240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rareID;

	[Token(Token = "0x400F241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool cardCreated;

	[Token(Token = "0x400F242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject cardParent;

	[Token(Token = "0x400F243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CardModel card;

	[Token(Token = "0x400F244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 targetPosition;

	[Token(Token = "0x400F245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion targetCardRotation;

	[Token(Token = "0x400F246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Color cardColor;

	[Token(Token = "0x400F249")]
	private const float moveFactor = 0.8f;

	[Token(Token = "0x400F24A")]
	private const float rotFactor = 0.5f;

	[Token(Token = "0x400F24B")]
	private const float turnFactor = 0.8f;

	[Token(Token = "0x400F24C")]
	private const float powerFactor = 10f;

	[Token(Token = "0x400F24D")]
	private const float powerRotLimit = 30f;

	[Token(Token = "0x17001A3F")]
	public bool isShowing
	{
		[Token(Token = "0x600AA03")]
		[Address(RVA = "0xF09E30", Offset = "0xF09030", VA = "0x180F09E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AA04")]
		[Address(RVA = "0xF09E60", Offset = "0xF09060", VA = "0x180F09E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A40")]
	public bool isActivate
	{
		[Token(Token = "0x600AA05")]
		[Address(RVA = "0xF09E20", Offset = "0xF09020", VA = "0x180F09E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AA06")]
		[Address(RVA = "0xF09E50", Offset = "0xF09050", VA = "0x180F09E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A41")]
	private Quaternion parentRotation
	{
		[Token(Token = "0x600AA13")]
		[Address(RVA = "0xF682D0", Offset = "0xF674D0", VA = "0x180F682D0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x600AA07")]
	[Address(RVA = "0xF67590", Offset = "0xF66790", VA = "0x180F67590")]
	public static GhostCard Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600AA08")]
	[Address(RVA = "0xF676E0", Offset = "0xF668E0", VA = "0x180F676E0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600AA09")]
	[Address(RVA = "0xF67AA0", Offset = "0xF66CA0", VA = "0x180F67AA0")]
	public void Setup(int cardID, int sleeveID, int rareID, [Optional] Action onCreated)
	{
	}

	[Token(Token = "0x600AA0A")]
	[Address(RVA = "0xF67D10", Offset = "0xF66F10", VA = "0x180F67D10")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600AA0B")]
	[Address(RVA = "0xF67C80", Offset = "0xF66E80", VA = "0x180F67C80")]
	private void TerminateCard()
	{
	}

	[Token(Token = "0x600AA0C")]
	[Address(RVA = "0xF67910", Offset = "0xF66B10", VA = "0x180F67910")]
	public void SetTargetPosition(Vector3 position, bool immediate)
	{
	}

	[Token(Token = "0x600AA0D")]
	[Address(RVA = "0xF67820", Offset = "0xF66A20", VA = "0x180F67820")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x600AA0E")]
	[Address(RVA = "0xF678E0", Offset = "0xF66AE0", VA = "0x180F678E0")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x600AA0F")]
	[Address(RVA = "0xF67790", Offset = "0xF66990", VA = "0x180F67790")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x600AA10")]
	[Address(RVA = "0xF677D0", Offset = "0xF669D0", VA = "0x180F677D0")]
	public void SetCardTargetRotation(Quaternion rotation, bool immediate)
	{
	}

	[Token(Token = "0x600AA11")]
	[Address(RVA = "0xF67970", Offset = "0xF66B70", VA = "0x180F67970")]
	public SelectionButton SetupSelectionButton()
	{
		return null;
	}

	[Token(Token = "0x600AA12")]
	[Address(RVA = "0xF67DE0", Offset = "0xF66FE0", VA = "0x180F67DE0")]
	private void Update()
	{
	}

	[Token(Token = "0x600AA14")]
	[Address(RVA = "0xF682B0", Offset = "0xF674B0", VA = "0x180F682B0")]
	public GhostCard()
	{
	}
}
