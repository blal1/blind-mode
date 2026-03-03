using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20019EE")]
public class CommandOperation
{
	[Token(Token = "0x20019EF")]
	public enum Status
	{
		[Token(Token = "0x400EFC2")]
		None,
		[Token(Token = "0x400EFC3")]
		Neutral,
		[Token(Token = "0x400EFC4")]
		Drag,
		[Token(Token = "0x400EFC5")]
		OnTarget
	}

	[Token(Token = "0x400EF99")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400EF9A")]
	private const string prefabPath = "Prefabs/Duel/UI/CommandOperation";

	[Token(Token = "0x400EF9B")]
	[FieldOffset(Offset = "0x18")]
	private ElementObjectManager ui;

	[Token(Token = "0x400EF9C")]
	[FieldOffset(Offset = "0x20")]
	private GhostCard dragCard;

	[Token(Token = "0x400EF9D")]
	[FieldOffset(Offset = "0x28")]
	private SelectionButton dragCardButton;

	[Token(Token = "0x400EF9E")]
	[FieldOffset(Offset = "0x30")]
	private TargetingLine targetLine;

	[Token(Token = "0x400EF9F")]
	[FieldOffset(Offset = "0x38")]
	private GameObject operationObject;

	[Token(Token = "0x400EFA0")]
	[FieldOffset(Offset = "0x40")]
	private SelectionButton bgButton;

	[Token(Token = "0x400EFA1")]
	[FieldOffset(Offset = "0x48")]
	private CardCommand cardCommand;

	[Token(Token = "0x400EFA2")]
	[FieldOffset(Offset = "0x50")]
	private bool usingInfoDialog;

	[Token(Token = "0x400EFA3")]
	[FieldOffset(Offset = "0x58")]
	private RunEffectWorker worker;

	[Token(Token = "0x400EFA7")]
	[FieldOffset(Offset = "0x6C")]
	private uint commandMask;

	[Token(Token = "0x400EFA8")]
	[FieldOffset(Offset = "0x70")]
	private uint commandMaskOrigin;

	[Token(Token = "0x400EFA9")]
	[FieldOffset(Offset = "0x74")]
	private Status status;

	[Token(Token = "0x400EFAA")]
	[FieldOffset(Offset = "0x78")]
	private Action<int, int, int, Engine.CommandType> onExecuteCommand;

	[Token(Token = "0x400EFAB")]
	[FieldOffset(Offset = "0x80")]
	private int loadCount;

	[Token(Token = "0x400EFAF")]
	[FieldOffset(Offset = "0x87")]
	private bool dragging;

	[Token(Token = "0x400EFB0")]
	[FieldOffset(Offset = "0x88")]
	private int cardID;

	[Token(Token = "0x400EFB1")]
	[FieldOffset(Offset = "0x90")]
	private CardRoot targetCard;

	[Token(Token = "0x400EFB2")]
	[FieldOffset(Offset = "0x98")]
	private bool isMonsterCard;

	[Token(Token = "0x400EFB3")]
	[FieldOffset(Offset = "0xA0")]
	private List<Engine.CommandType> commandList;

	[Token(Token = "0x400EFB4")]
	[FieldOffset(Offset = "0xA8")]
	private CommandZoneIconController zoneIcon;

	[Token(Token = "0x400EFB5")]
	[FieldOffset(Offset = "0xB0")]
	private bool directDragging;

	[Token(Token = "0x400EFB6")]
	[FieldOffset(Offset = "0xB4")]
	private Engine.CommandType directDraggedCommand;

	[Token(Token = "0x400EFB7")]
	[FieldOffset(Offset = "0xB8")]
	private bool draggedUpsideDown;

	[Token(Token = "0x400EFBF")]
	private const float dragCardHeight = 3f;

	[Token(Token = "0x400EFC0")]
	private const float dragCardHeightOnTarget = 1f;

	[Token(Token = "0x170019C8")]
	public int player
	{
		[Token(Token = "0x600A769")]
		[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A76A")]
		[Address(RVA = "0x4048C0", Offset = "0x403AC0", VA = "0x1804048C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019C9")]
	public int position
	{
		[Token(Token = "0x600A76B")]
		[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A76C")]
		[Address(RVA = "0x91EA10", Offset = "0x91DC10", VA = "0x18091EA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019CA")]
	public int index
	{
		[Token(Token = "0x600A76D")]
		[Address(RVA = "0x6A9360", Offset = "0x6A8560", VA = "0x1806A9360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A76E")]
		[Address(RVA = "0xB2E810", Offset = "0xB2DA10", VA = "0x180B2E810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019CB")]
	public bool initialized
	{
		[Token(Token = "0x600A76F")]
		[Address(RVA = "0xF3B2E0", Offset = "0xF3A4E0", VA = "0x180F3B2E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019CC")]
	public bool isTerminated
	{
		[Token(Token = "0x600A770")]
		[Address(RVA = "0x8A9920", Offset = "0x8A8B20", VA = "0x1808A9920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A771")]
		[Address(RVA = "0x9F3670", Offset = "0x9F2870", VA = "0x1809F3670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019CD")]
	public bool activate
	{
		[Token(Token = "0x600A772")]
		[Address(RVA = "0x8A99D0", Offset = "0x8A8BD0", VA = "0x1808A99D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A773")]
		[Address(RVA = "0xF3B340", Offset = "0xF3A540", VA = "0x180F3B340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019CE")]
	public bool draggable
	{
		[Token(Token = "0x600A774")]
		[Address(RVA = "0x8A9930", Offset = "0x8A8B30", VA = "0x1808A9930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A775")]
		[Address(RVA = "0x8A9E90", Offset = "0x8A9090", VA = "0x1808A9E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019CF")]
	public int targetPlayer
	{
		[Token(Token = "0x600A776")]
		[Address(RVA = "0x667F00", Offset = "0x667100", VA = "0x180667F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A777")]
		[Address(RVA = "0x668100", Offset = "0x667300", VA = "0x180668100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019D0")]
	public int targetPosition
	{
		[Token(Token = "0x600A778")]
		[Address(RVA = "0xAA4ED0", Offset = "0xAA40D0", VA = "0x180AA4ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A779")]
		[Address(RVA = "0xAA4930", Offset = "0xAA3B30", VA = "0x180AA4930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019D1")]
	public int targetIndex
	{
		[Token(Token = "0x600A77A")]
		[Address(RVA = "0xF21C10", Offset = "0xF20E10", VA = "0x180F21C10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A77B")]
		[Address(RVA = "0xF3B380", Offset = "0xF3A580", VA = "0x180F3B380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019D2")]
	public Engine.CommandType targetCommand
	{
		[Token(Token = "0x600A77C")]
		[Address(RVA = "0xF21C80", Offset = "0xF20E80", VA = "0x180F21C80")]
		[CompilerGenerated]
		get
		{
			return default(Engine.CommandType);
		}
		[Token(Token = "0x600A77D")]
		[Address(RVA = "0xAA3880", Offset = "0xAA2A80", VA = "0x180AA3880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019D3")]
	public bool decideCommand
	{
		[Token(Token = "0x600A77E")]
		[Address(RVA = "0xAA1FE0", Offset = "0xAA11E0", VA = "0x180AA1FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A77F")]
		[Address(RVA = "0xF3B350", Offset = "0xF3A550", VA = "0x180F3B350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019D4")]
	public bool decideLocation
	{
		[Token(Token = "0x600A780")]
		[Address(RVA = "0xF3B2D0", Offset = "0xF3A4D0", VA = "0x180F3B2D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A781")]
		[Address(RVA = "0xF3B360", Offset = "0xF3A560", VA = "0x180F3B360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019D5")]
	private bool onTarget
	{
		[Token(Token = "0x600A782")]
		[Address(RVA = "0xF3B310", Offset = "0xF3A510", VA = "0x180F3B310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A783")]
		[Address(RVA = "0xF3B370", Offset = "0xF3A570", VA = "0x180F3B370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170019D6")]
	public bool isCommandDisp
	{
		[Token(Token = "0x600A784")]
		[Address(RVA = "0xF3B2F0", Offset = "0xF3A4F0", VA = "0x180F3B2F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019D7")]
	public bool readyToCommandExecution
	{
		[Token(Token = "0x600A785")]
		[Address(RVA = "0xF3B320", Offset = "0xF3A520", VA = "0x180F3B320")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019D8")]
	private Vector2 neutralScreenPosition
	{
		[Token(Token = "0x600A792")]
		[Address(RVA = "0x42D540", Offset = "0x42C740", VA = "0x18042D540")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x600A786")]
	[Address(RVA = "0xF38790", Offset = "0xF37990", VA = "0x180F38790")]
	public static CommandOperation Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x600A787")]
	[Address(RVA = "0xF390B0", Offset = "0xF382B0", VA = "0x180F390B0")]
	private void Initialize(RunEffectWorker worker)
	{
	}

	[Token(Token = "0x600A788")]
	[Address(RVA = "0xF3A2C0", Offset = "0xF394C0", VA = "0x180F3A2C0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A789")]
	[Address(RVA = "0xF38370", Offset = "0xF37570", VA = "0x180F38370")]
	public bool BeginCommand(int player, int position, int index, Action<int, int, int, Engine.CommandType> onExecuteCommand, Vector2 screenPoint, Status status)
	{
		return default(bool);
	}

	[Token(Token = "0x600A78A")]
	[Address(RVA = "0xF37B00", Offset = "0xF36D00", VA = "0x180F37B00")]
	public bool BeginCommand(uint commandMask, int player, int position, int index, Action<int, int, int, Engine.CommandType> onExecuteCommand, Vector2 screenPoint, Status status)
	{
		return default(bool);
	}

	[Token(Token = "0x600A78B")]
	[Address(RVA = "0xF38700", Offset = "0xF37900", VA = "0x180F38700")]
	private void CommandToList(uint commandMask)
	{
	}

	[Token(Token = "0x600A78C")]
	[Address(RVA = "0xF38460", Offset = "0xF37660", VA = "0x180F38460")]
	public void BeginDrag(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600A78D")]
	[Address(RVA = "0xF3A8D0", Offset = "0xF39AD0", VA = "0x180F3A8D0")]
	private void UpdateCommandInteractable(int targetPlayer, int targetPosition)
	{
	}

	[Token(Token = "0x600A78E")]
	[Address(RVA = "0xF39330", Offset = "0xF38530", VA = "0x180F39330")]
	private bool IsDragCommandMask(uint commandMask, bool isMonster)
	{
		return default(bool);
	}

	[Token(Token = "0x600A78F")]
	[Address(RVA = "0xF3B0B0", Offset = "0xF3A2B0", VA = "0x180F3B0B0")]
	public void Update()
	{
	}

	[Token(Token = "0x600A790")]
	[Address(RVA = "0xF3AB80", Offset = "0xF39D80", VA = "0x180F3AB80")]
	public void UpdateDrag(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600A791")]
	[Address(RVA = "0xF3A600", Offset = "0xF39800", VA = "0x180F3A600")]
	private void UpdateCardPosition(Vector2 screenPoint, float height, bool immediate)
	{
	}

	[Token(Token = "0x600A793")]
	[Address(RVA = "0xF39450", Offset = "0xF38650", VA = "0x180F39450")]
	private void SetDraggedUpsideDown(bool upsideDown, bool immediate)
	{
	}

	[Token(Token = "0x600A794")]
	[Address(RVA = "0xF38B50", Offset = "0xF37D50", VA = "0x180F38B50")]
	public void End(bool selectOpenedItem = true, bool closeCommand = true)
	{
	}

	[Token(Token = "0x600A795")]
	[Address(RVA = "0xF38860", Offset = "0xF37A60", VA = "0x180F38860")]
	public void EndDrag(Vector2 screenPoint, Status noTargetStatus = Status.Neutral)
	{
	}

	[Token(Token = "0x600A796")]
	[Address(RVA = "0xF39710", Offset = "0xF38910", VA = "0x180F39710")]
	public void SetStatus(Status status)
	{
	}

	[Token(Token = "0x600A797")]
	[Address(RVA = "0xF392F0", Offset = "0xF384F0", VA = "0x180F392F0")]
	public bool IsAvailableZone(int player, int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600A798")]
	[Address(RVA = "0xF39F40", Offset = "0xF39140", VA = "0x180F39F40")]
	public bool SetTargetLocation(int player, int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600A799")]
	[Address(RVA = "0xF39860", Offset = "0xF38A60", VA = "0x180F39860")]
	private void SetTargetCardColor(Color color)
	{
	}

	[Token(Token = "0x600A79A")]
	[Address(RVA = "0xF39940", Offset = "0xF38B40", VA = "0x180F39940")]
	public void SetTargetCommand(Engine.CommandType command)
	{
	}

	[Token(Token = "0x600A79B")]
	[Address(RVA = "0xF38F00", Offset = "0xF38100", VA = "0x180F38F00")]
	public bool ExecuteTargetCommand(bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600A79C")]
	[Address(RVA = "0xF396E0", Offset = "0xF388E0", VA = "0x180F396E0")]
	public void SetSelected(int player, int position, bool selected)
	{
	}

	[Token(Token = "0x600A79D")]
	[Address(RVA = "0xF39430", Offset = "0xF38630", VA = "0x180F39430")]
	public void SetCursor(int index)
	{
	}

	[Token(Token = "0x600A79E")]
	[Address(RVA = "0xF39390", Offset = "0xF38590", VA = "0x180F39390")]
	public void ReapplyCommandPosition()
	{
	}

	[Token(Token = "0x600A79F")]
	[Address(RVA = "0xF39350", Offset = "0xF38550", VA = "0x180F39350")]
	public bool IsOnlyAffectCommand()
	{
		return default(bool);
	}

	[Token(Token = "0x600A7A0")]
	[Address(RVA = "0xF39400", Offset = "0xF38600", VA = "0x180F39400")]
	public void Reset()
	{
	}

	[Token(Token = "0x600A7A1")]
	[Address(RVA = "0xF3B240", Offset = "0xF3A440", VA = "0x180F3B240")]
	public CommandOperation()
	{
	}
}
