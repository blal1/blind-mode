using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001A76")]
public class SelectStandOperation
{
	[Token(Token = "0x2001A77")]
	public enum Status
	{
		[Token(Token = "0x400F3EC")]
		None,
		[Token(Token = "0x400F3ED")]
		Neutral,
		[Token(Token = "0x400F3EE")]
		Drag,
		[Token(Token = "0x400F3EF")]
		OnTarget
	}

	[Token(Token = "0x2001A78")]
	public enum StandType
	{
		[Token(Token = "0x400F3F1")]
		FaceAttackFaceDefense,
		[Token(Token = "0x400F3F2")]
		FaceAttackBackDefense,
		[Token(Token = "0x400F3F3")]
		FaceDefenseBackDefense,
		[Token(Token = "0x400F3F4")]
		All,
		[Token(Token = "0x400F3F5")]
		None
	}

	[Token(Token = "0x2001A79")]
	public enum ZoneMode
	{
		[Token(Token = "0x400F3F7")]
		SelectStand,
		[Token(Token = "0x400F3F8")]
		DecidePosition
	}

	[Token(Token = "0x400F3C5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400F3C6")]
	private const string prefabPath = "Prefabs/Duel/UI/CommandOperation";

	[Token(Token = "0x400F3C7")]
	[FieldOffset(Offset = "0x18")]
	private ElementObjectManager ui;

	[Token(Token = "0x400F3C8")]
	[FieldOffset(Offset = "0x20")]
	private GhostCard dragCard;

	[Token(Token = "0x400F3C9")]
	[FieldOffset(Offset = "0x28")]
	private SelectionButton dragCardButton;

	[Token(Token = "0x400F3CA")]
	[FieldOffset(Offset = "0x30")]
	private GameObject operationObject;

	[Token(Token = "0x400F3CB")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton bgButton;

	[Token(Token = "0x400F3CC")]
	[FieldOffset(Offset = "0x40")]
	private CardCommandEx cardCommandEx;

	[Token(Token = "0x400F3CD")]
	[FieldOffset(Offset = "0x48")]
	private bool usingInfoDialog;

	[Token(Token = "0x400F3CE")]
	[FieldOffset(Offset = "0x50")]
	private RunEffectWorker worker;

	[Token(Token = "0x400F3D2")]
	[FieldOffset(Offset = "0x64")]
	private Status status;

	[Token(Token = "0x400F3D3")]
	[FieldOffset(Offset = "0x68")]
	private Action<int, int, int, uint> onExecuteSpSummon;

	[Token(Token = "0x400F3D4")]
	[FieldOffset(Offset = "0x70")]
	public ZoneMode zoneMode;

	[Token(Token = "0x400F3D5")]
	[FieldOffset(Offset = "0x74")]
	private StandType standType;

	[Token(Token = "0x400F3D6")]
	[FieldOffset(Offset = "0x78")]
	private int loadCount;

	[Token(Token = "0x400F3DA")]
	[FieldOffset(Offset = "0x7F")]
	private bool dragging;

	[Token(Token = "0x400F3DB")]
	[FieldOffset(Offset = "0x80")]
	private uint directDraggedStand;

	[Token(Token = "0x400F3DC")]
	[FieldOffset(Offset = "0x84")]
	private bool directDraggedUpsideDown;

	[Token(Token = "0x400F3DD")]
	[FieldOffset(Offset = "0x88")]
	private int cardID;

	[Token(Token = "0x400F3DE")]
	[FieldOffset(Offset = "0x8C")]
	private int uniqueID;

	[Token(Token = "0x400F3DF")]
	[FieldOffset(Offset = "0x90")]
	private CardRoot targetCard;

	[Token(Token = "0x400F3E0")]
	[FieldOffset(Offset = "0x98")]
	private CommandZoneIconController zoneIcon;

	[Token(Token = "0x400F3E1")]
	[FieldOffset(Offset = "0xA0")]
	private TargetingLine targetLine;

	[Token(Token = "0x400F3E9")]
	private const float dragCardHeight = 18f;

	[Token(Token = "0x400F3EA")]
	private const float dragCardHeightOnTarget = 1f;

	[Token(Token = "0x17001A7E")]
	public int player
	{
		[Token(Token = "0x600ABDF")]
		[Address(RVA = "0x42D5A0", Offset = "0x42C7A0", VA = "0x18042D5A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600ABE0")]
		[Address(RVA = "0x42D670", Offset = "0x42C870", VA = "0x18042D670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A7F")]
	public int position
	{
		[Token(Token = "0x600ABE1")]
		[Address(RVA = "0x404870", Offset = "0x403A70", VA = "0x180404870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600ABE2")]
		[Address(RVA = "0x4048B0", Offset = "0x403AB0", VA = "0x1804048B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A80")]
	public int index
	{
		[Token(Token = "0x600ABE3")]
		[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600ABE4")]
		[Address(RVA = "0x4048C0", Offset = "0x403AC0", VA = "0x1804048C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A81")]
	public bool initialized
	{
		[Token(Token = "0x600ABE5")]
		[Address(RVA = "0x42D500", Offset = "0x42C700", VA = "0x18042D500")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A82")]
	public bool isTerminated
	{
		[Token(Token = "0x600ABE6")]
		[Address(RVA = "0x42D530", Offset = "0x42C730", VA = "0x18042D530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ABE7")]
		[Address(RVA = "0x42D650", Offset = "0x42C850", VA = "0x18042D650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A83")]
	public bool activate
	{
		[Token(Token = "0x600ABE8")]
		[Address(RVA = "0x42D4C0", Offset = "0x42C6C0", VA = "0x18042D4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ABE9")]
		[Address(RVA = "0x42D610", Offset = "0x42C810", VA = "0x18042D610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A84")]
	public bool draggable
	{
		[Token(Token = "0x600ABEA")]
		[Address(RVA = "0x42D4F0", Offset = "0x42C6F0", VA = "0x18042D4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ABEB")]
		[Address(RVA = "0x42D640", Offset = "0x42C840", VA = "0x18042D640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A85")]
	public int targetPlayer
	{
		[Token(Token = "0x600ABEC")]
		[Address(RVA = "0x42D5E0", Offset = "0x42C7E0", VA = "0x18042D5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600ABED")]
		[Address(RVA = "0x42D690", Offset = "0x42C890", VA = "0x18042D690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A86")]
	public int targetPosition
	{
		[Token(Token = "0x600ABEE")]
		[Address(RVA = "0x42D5F0", Offset = "0x42C7F0", VA = "0x18042D5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600ABEF")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C8A0", VA = "0x18042D6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A87")]
	public int targetIndex
	{
		[Token(Token = "0x600ABF0")]
		[Address(RVA = "0x42D5D0", Offset = "0x42C7D0", VA = "0x18042D5D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600ABF1")]
		[Address(RVA = "0x42D680", Offset = "0x42C880", VA = "0x18042D680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A88")]
	public uint targetStand
	{
		[Token(Token = "0x600ABF2")]
		[Address(RVA = "0x42D600", Offset = "0x42C800", VA = "0x18042D600")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600ABF3")]
		[Address(RVA = "0x42D6B0", Offset = "0x42C8B0", VA = "0x18042D6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A89")]
	public bool decideCommand
	{
		[Token(Token = "0x600ABF4")]
		[Address(RVA = "0x42D4D0", Offset = "0x42C6D0", VA = "0x18042D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ABF5")]
		[Address(RVA = "0x42D620", Offset = "0x42C820", VA = "0x18042D620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A8A")]
	public bool decideLocation
	{
		[Token(Token = "0x600ABF6")]
		[Address(RVA = "0x42D4E0", Offset = "0x42C6E0", VA = "0x18042D4E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ABF7")]
		[Address(RVA = "0x42D630", Offset = "0x42C830", VA = "0x18042D630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A8B")]
	public bool onTarget
	{
		[Token(Token = "0x600ABF8")]
		[Address(RVA = "0x42D590", Offset = "0x42C790", VA = "0x18042D590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ABF9")]
		[Address(RVA = "0x42D660", Offset = "0x42C860", VA = "0x18042D660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001A8C")]
	public bool isCommandDisp
	{
		[Token(Token = "0x600ABFA")]
		[Address(RVA = "0x42D510", Offset = "0x42C710", VA = "0x18042D510")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A8D")]
	public bool readyToSpSummon
	{
		[Token(Token = "0x600ABFB")]
		[Address(RVA = "0x42D5B0", Offset = "0x42C7B0", VA = "0x18042D5B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A8E")]
	private Vector2 neutralScreenPosition
	{
		[Token(Token = "0x600AC06")]
		[Address(RVA = "0x42D540", Offset = "0x42C740", VA = "0x18042D540")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x600ABFC")]
	[Address(RVA = "0x42B0E0", Offset = "0x42A2E0", VA = "0x18042B0E0")]
	public static SelectStandOperation Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x600ABFD")]
	[Address(RVA = "0x42B870", Offset = "0x42AA70", VA = "0x18042B870")]
	private void Initialize(RunEffectWorker worker)
	{
	}

	[Token(Token = "0x600ABFE")]
	[Address(RVA = "0x42CA30", Offset = "0x42BC30", VA = "0x18042CA30")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600ABFF")]
	[Address(RVA = "0x42A650", Offset = "0x429850", VA = "0x18042A650")]
	public void BeginSpSummon(StandType standType, int uniqueID, Action<int, int, int, uint> onExecuteSpSummon, Vector2 screenPoint, Status status, ZoneMode zoneMode)
	{
	}

	[Token(Token = "0x600AC00")]
	[Address(RVA = "0x42A480", Offset = "0x429680", VA = "0x18042A480")]
	public void BeginDrag(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600AC01")]
	[Address(RVA = "0x42D350", Offset = "0x42C550", VA = "0x18042D350")]
	public void Update()
	{
	}

	[Token(Token = "0x600AC02")]
	[Address(RVA = "0x42CF40", Offset = "0x42C140", VA = "0x18042CF40")]
	public void UpdateDrag(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600AC03")]
	[Address(RVA = "0x42CCA0", Offset = "0x42BEA0", VA = "0x18042CCA0")]
	private void UpdateCardPosition(Vector2 screenPoint, float height, bool immediate)
	{
	}

	[Token(Token = "0x600AC04")]
	[Address(RVA = "0x42BB20", Offset = "0x42AD20", VA = "0x18042BB20")]
	public void SetCardPosition(int player, int position, bool reqOnTarget)
	{
	}

	[Token(Token = "0x600AC05")]
	[Address(RVA = "0x42BDD0", Offset = "0x42AFD0", VA = "0x18042BDD0")]
	private void SetDraggedUpsideDown(bool upsideDown, bool immediate)
	{
	}

	[Token(Token = "0x600AC07")]
	[Address(RVA = "0x42B440", Offset = "0x42A640", VA = "0x18042B440")]
	public void End()
	{
	}

	[Token(Token = "0x600AC08")]
	[Address(RVA = "0x42B150", Offset = "0x42A350", VA = "0x18042B150")]
	public bool EndDrag(Vector2 screenPoint, Status noTargetStatus = Status.Neutral)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC09")]
	[Address(RVA = "0x42C290", Offset = "0x42B490", VA = "0x18042C290")]
	public void SetStatus(Status status)
	{
	}

	[Token(Token = "0x600AC0A")]
	[Address(RVA = "0x42BAB0", Offset = "0x42ACB0", VA = "0x18042BAB0")]
	public bool IsAvailableZone(int player, int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC0B")]
	[Address(RVA = "0x42C4C0", Offset = "0x42B6C0", VA = "0x18042C4C0")]
	public bool SetTargetLocation(int player, int position, bool playDecideEffect = true, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC0C")]
	[Address(RVA = "0x42C3E0", Offset = "0x42B5E0", VA = "0x18042C3E0")]
	private void SetTargetCardColor(Color color)
	{
	}

	[Token(Token = "0x600AC0D")]
	[Address(RVA = "0x42C5A0", Offset = "0x42B7A0", VA = "0x18042C5A0")]
	public void SetTargetStand(uint stand)
	{
	}

	[Token(Token = "0x600AC0E")]
	[Address(RVA = "0x42AF30", Offset = "0x42A130", VA = "0x18042AF30")]
	private void CancelCommand()
	{
	}

	[Token(Token = "0x600AC0F")]
	[Address(RVA = "0x42B700", Offset = "0x42A900", VA = "0x18042B700")]
	private bool ExecuteTargetSpSummon(bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC10")]
	[Address(RVA = "0x42C260", Offset = "0x42B460", VA = "0x18042C260")]
	public void SetSelected(int player, int position, bool selected)
	{
	}

	[Token(Token = "0x600AC11")]
	[Address(RVA = "0x42BDB0", Offset = "0x42AFB0", VA = "0x18042BDB0")]
	public void SetCursor(int index)
	{
	}

	[Token(Token = "0x600AC12")]
	[Address(RVA = "0x42BAF0", Offset = "0x42ACF0", VA = "0x18042BAF0")]
	public void Reset()
	{
	}

	[Token(Token = "0x600AC13")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SelectStandOperation()
	{
	}
}
