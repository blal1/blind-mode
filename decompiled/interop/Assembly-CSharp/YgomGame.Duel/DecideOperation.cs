using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20019FF")]
public class DecideOperation
{
	[Token(Token = "0x400EFE5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400EFE6")]
	private const string prefabPath = "Prefabs/Duel/UI/DecideOperation";

	[Token(Token = "0x400EFE7")]
	[FieldOffset(Offset = "0x18")]
	private ElementObjectManager ui;

	[Token(Token = "0x400EFE8")]
	[FieldOffset(Offset = "0x20")]
	private GameObject operationObject;

	[Token(Token = "0x400EFE9")]
	[FieldOffset(Offset = "0x28")]
	private SelectionButton bgButton;

	[Token(Token = "0x400EFEA")]
	[FieldOffset(Offset = "0x30")]
	private CardCommand cardCommand;

	[Token(Token = "0x400EFEB")]
	[FieldOffset(Offset = "0x38")]
	private RunEffectWorker worker;

	[Token(Token = "0x400EFEF")]
	[FieldOffset(Offset = "0x50")]
	private Action onExecuteCommand;

	[Token(Token = "0x400EFF0")]
	[FieldOffset(Offset = "0x58")]
	private int loadCount;

	[Token(Token = "0x400EFF3")]
	[FieldOffset(Offset = "0x60")]
	private CardRoot targetCard;

	[Token(Token = "0x400EFF4")]
	[FieldOffset(Offset = "0x68")]
	private bool isCancelButtonActive;

	[Token(Token = "0x400EFF5")]
	[FieldOffset(Offset = "0x69")]
	private bool isDecisionButtonActive;

	[Token(Token = "0x400EFF6")]
	[FieldOffset(Offset = "0x70")]
	private CommandZoneIconController zoneIcon;

	[Token(Token = "0x170019D9")]
	public int player
	{
		[Token(Token = "0x600A7D7")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A7D8")]
		[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019DA")]
	public int position
	{
		[Token(Token = "0x600A7D9")]
		[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A7DA")]
		[Address(RVA = "0x86B170", Offset = "0x86A370", VA = "0x18086B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019DB")]
	public int index
	{
		[Token(Token = "0x600A7DB")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A7DC")]
		[Address(RVA = "0x49C4C0", Offset = "0x49B6C0", VA = "0x18049C4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019DC")]
	public bool initialized
	{
		[Token(Token = "0x600A7DD")]
		[Address(RVA = "0xF3D170", Offset = "0xF3C370", VA = "0x180F3D170")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019DD")]
	public bool isTerminated
	{
		[Token(Token = "0x600A7DE")]
		[Address(RVA = "0xF3D1A0", Offset = "0xF3C3A0", VA = "0x180F3D1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A7DF")]
		[Address(RVA = "0xF3D1B0", Offset = "0xF3C3B0", VA = "0x180F3D1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019DE")]
	public bool activate
	{
		[Token(Token = "0x600A7E0")]
		[Address(RVA = "0x6ADBD0", Offset = "0x6ACDD0", VA = "0x1806ADBD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A7E1")]
		[Address(RVA = "0x6ADD60", Offset = "0x6ACF60", VA = "0x1806ADD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019DF")]
	public bool isCommandDisp
	{
		[Token(Token = "0x600A7E2")]
		[Address(RVA = "0xF3D180", Offset = "0xF3C380", VA = "0x180F3D180")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A7E3")]
	[Address(RVA = "0xF3C8B0", Offset = "0xF3BAB0", VA = "0x180F3C8B0")]
	public static DecideOperation Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x600A7E4")]
	[Address(RVA = "0xF3CCB0", Offset = "0xF3BEB0", VA = "0x180F3CCB0")]
	private void Initialize(RunEffectWorker worker)
	{
	}

	[Token(Token = "0x600A7E5")]
	[Address(RVA = "0xF3CF00", Offset = "0xF3C100", VA = "0x180F3CF00")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A7E6")]
	[Address(RVA = "0xF3C320", Offset = "0xF3B520", VA = "0x180F3C320")]
	public bool BeginCommand(int player, int position, int index, Action onExecuteCommand, Vector2 screenPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x600A7E7")]
	[Address(RVA = "0xF3D020", Offset = "0xF3C220", VA = "0x180F3D020")]
	public void Update()
	{
	}

	[Token(Token = "0x600A7E8")]
	[Address(RVA = "0xF3C920", Offset = "0xF3BB20", VA = "0x180F3C920")]
	public void End(bool selectOpenedItem = true)
	{
	}

	[Token(Token = "0x600A7E9")]
	[Address(RVA = "0xF3CB80", Offset = "0xF3BD80", VA = "0x180F3CB80")]
	private void ExecuteCommand()
	{
	}

	[Token(Token = "0x600A7EA")]
	[Address(RVA = "0xF3CC80", Offset = "0xF3BE80", VA = "0x180F3CC80")]
	public void ExecuteDecideCommand()
	{
	}

	[Token(Token = "0x600A7EB")]
	[Address(RVA = "0xF3CED0", Offset = "0xF3C0D0", VA = "0x180F3CED0")]
	public void SetSelected(int player, int position, bool selected)
	{
	}

	[Token(Token = "0x600A7EC")]
	[Address(RVA = "0xF3CEB0", Offset = "0xF3C0B0", VA = "0x180F3CEB0")]
	public void SetCursor(int index)
	{
	}

	[Token(Token = "0x600A7ED")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DecideOperation()
	{
	}
}
