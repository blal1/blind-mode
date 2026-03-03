using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001A03")]
public class DrawOperation
{
	[Token(Token = "0x2001A04")]
	private enum Step
	{
		[Token(Token = "0x400F027")]
		WaitPlaceToReady,
		[Token(Token = "0x400F028")]
		WaitCardMove,
		[Token(Token = "0x400F029")]
		Init,
		[Token(Token = "0x400F02A")]
		MoveDeck,
		[Token(Token = "0x400F02B")]
		Touchable,
		[Token(Token = "0x400F02C")]
		WaitBack,
		[Token(Token = "0x400F02D")]
		Finish
	}

	[Token(Token = "0x2001A05")]
	private enum TouchPhase
	{
		[Token(Token = "0x400F02F")]
		Init,
		[Token(Token = "0x400F030")]
		Neutral,
		[Token(Token = "0x400F031")]
		InitDrawCardCenterFirst,
		[Token(Token = "0x400F032")]
		WaitDrawCardCenterFirst,
		[Token(Token = "0x400F033")]
		InitDrawCardCenterLatter,
		[Token(Token = "0x400F034")]
		WaitDrawCardCenterLatter,
		[Token(Token = "0x400F035")]
		WaitDetail,
		[Token(Token = "0x400F036")]
		Finish
	}

	[Token(Token = "0x400F004")]
	[FieldOffset(Offset = "0x10")]
	private RunEffectWorker worker;

	[Token(Token = "0x400F005")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F006")]
	[FieldOffset(Offset = "0x1C")]
	private Engine.CardStatus fromStatus;

	[Token(Token = "0x400F007")]
	[FieldOffset(Offset = "0x34")]
	private Engine.CardStatus toStatus;

	[Token(Token = "0x400F008")]
	[FieldOffset(Offset = "0x50")]
	private CardPlace fromPlace;

	[Token(Token = "0x400F009")]
	[FieldOffset(Offset = "0x58")]
	private CardPlace toPlace;

	[Token(Token = "0x400F00A")]
	[FieldOffset(Offset = "0x60")]
	private int uniqueID;

	[Token(Token = "0x400F00B")]
	[FieldOffset(Offset = "0x64")]
	private bool isFace;

	[Token(Token = "0x400F00C")]
	[FieldOffset(Offset = "0x68")]
	private int player;

	[Token(Token = "0x400F00D")]
	[FieldOffset(Offset = "0x6C")]
	private int team;

	[Token(Token = "0x400F00E")]
	[FieldOffset(Offset = "0x70")]
	private TouchPhase phase;

	[Token(Token = "0x400F00F")]
	[FieldOffset(Offset = "0x78")]
	private DeckCardPlace deckPlace;

	[Token(Token = "0x400F010")]
	[FieldOffset(Offset = "0x80")]
	private CardRoot drawCard;

	[Token(Token = "0x400F011")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 defaultPos;

	[Token(Token = "0x400F012")]
	[FieldOffset(Offset = "0x94")]
	private Quaternion defaultRot;

	[Token(Token = "0x400F013")]
	[FieldOffset(Offset = "0xA4")]
	private float camDist;

	[Token(Token = "0x400F014")]
	[FieldOffset(Offset = "0xA8")]
	private SimpleEffect drawArrowEff;

	[Token(Token = "0x400F015")]
	[FieldOffset(Offset = "0xB0")]
	private bool calledCardMove;

	[Token(Token = "0x400F016")]
	[FieldOffset(Offset = "0xB4")]
	private float frameOutTime;

	[Token(Token = "0x400F017")]
	[FieldOffset(Offset = "0xB8")]
	private bool isScreenOperated;

	[Token(Token = "0x400F018")]
	[FieldOffset(Offset = "0xBC")]
	private float time;

	[Token(Token = "0x400F019")]
	[FieldOffset(Offset = "0xC0")]
	private ScreenSelector screenSelector;

	[Token(Token = "0x400F01A")]
	[FieldOffset(Offset = "0xC8")]
	private SelectionButton shortCutKey;

	[Token(Token = "0x400F01B")]
	[FieldOffset(Offset = "0xD0")]
	private ChainedBezierMotion deckCloseUpMotion;

	[Token(Token = "0x400F01C")]
	[FieldOffset(Offset = "0xD8")]
	private ChainedBezierMotion deckBackMotion;

	[Token(Token = "0x400F01D")]
	[FieldOffset(Offset = "0xE0")]
	private ChainedBezierMotion drawMotionFirst;

	[Token(Token = "0x400F01E")]
	[FieldOffset(Offset = "0xE8")]
	private ChainedBezierMotion drawMotionLatter;

	[Token(Token = "0x400F01F")]
	[FieldOffset(Offset = "0xF0")]
	private ChainedBezierMotion toHandMotion;

	[Token(Token = "0x400F020")]
	[FieldOffset(Offset = "0xF8")]
	private Vector2 dragDirection;

	[Token(Token = "0x400F021")]
	[FieldOffset(Offset = "0x100")]
	private int originCardRenderQueue;

	[Token(Token = "0x400F022")]
	private const float neutralPhaseTimeLimit = 10f;

	[Token(Token = "0x400F023")]
	private const float waitDetailPhaseTimeLimit = 10f;

	[Token(Token = "0x400F024")]
	[FieldOffset(Offset = "0x108")]
	private SimpleEffect limitedEffectImpact;

	[Token(Token = "0x170019E1")]
	public bool finished
	{
		[Token(Token = "0x600A807")]
		[Address(RVA = "0x8AF070", Offset = "0x8AE270", VA = "0x1808AF070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A808")]
		[Address(RVA = "0x8AF090", Offset = "0x8AE290", VA = "0x1808AF090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019E2")]
	private Vector3 cardPosTo
	{
		[Token(Token = "0x600A819")]
		[Address(RVA = "0xF41610", Offset = "0xF40810", VA = "0x180F41610")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170019E3")]
	private Quaternion cardRotTo
	{
		[Token(Token = "0x600A81A")]
		[Address(RVA = "0xF417B0", Offset = "0xF409B0", VA = "0x180F417B0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x170019E4")]
	private Vector3 deckPosTo
	{
		[Token(Token = "0x600A81B")]
		[Address(RVA = "0xF418A0", Offset = "0xF40AA0", VA = "0x180F418A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170019E5")]
	private Quaternion deckRotTo
	{
		[Token(Token = "0x600A81C")]
		[Address(RVA = "0xF419A0", Offset = "0xF40BA0", VA = "0x180F419A0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x170019E6")]
	private Vector3 deckScaleTo
	{
		[Token(Token = "0x600A81D")]
		[Address(RVA = "0x4205B0", Offset = "0x41F7B0", VA = "0x1804205B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600A800")]
	[Address(RVA = "0xF3E000", Offset = "0xF3D200", VA = "0x180F3E000")]
	public static DrawOperation Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x600A801")]
	[Address(RVA = "0xF3E6E0", Offset = "0xF3D8E0", VA = "0x180F3E6E0")]
	public void Terminate(bool refreshDeck)
	{
	}

	[Token(Token = "0x600A802")]
	[Address(RVA = "0xF3E4F0", Offset = "0xF3D6F0", VA = "0x180F3E4F0")]
	public bool IsBusyEffect(Engine.ViewType viewType)
	{
		return default(bool);
	}

	[Token(Token = "0x600A803")]
	[Address(RVA = "0xF411D0", Offset = "0xF403D0", VA = "0x180F411D0")]
	public void WaitInput(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600A804")]
	[Address(RVA = "0xF3E250", Offset = "0xF3D450", VA = "0x180F3E250")]
	private void DrawCommand()
	{
	}

	[Token(Token = "0x600A805")]
	[Address(RVA = "0xF3DCD0", Offset = "0xF3CED0", VA = "0x180F3DCD0")]
	public void CardMove(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600A806")]
	[Address(RVA = "0xF40E20", Offset = "0xF40020", VA = "0x180F40E20")]
	public void Update()
	{
	}

	[Token(Token = "0x600A809")]
	[Address(RVA = "0xF413D0", Offset = "0xF405D0", VA = "0x180F413D0")]
	private void WaitPlaceToReadyStep()
	{
	}

	[Token(Token = "0x600A80A")]
	[Address(RVA = "0xF411B0", Offset = "0xF403B0", VA = "0x180F411B0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600A80B")]
	[Address(RVA = "0xF3E2D0", Offset = "0xF3D4D0", VA = "0x180F3E2D0")]
	private void InitStep()
	{
	}

	[Token(Token = "0x600A80C")]
	[Address(RVA = "0xF3E570", Offset = "0xF3D770", VA = "0x180F3E570")]
	private void MoveDeckStep()
	{
	}

	[Token(Token = "0x600A80D")]
	[Address(RVA = "0xF40800", Offset = "0xF3FA00", VA = "0x180F40800")]
	private void TouchableStep()
	{
	}

	[Token(Token = "0x600A80E")]
	[Address(RVA = "0xF3EF90", Offset = "0xF3E190", VA = "0x180F3EF90")]
	private void TouchableStepInit()
	{
	}

	[Token(Token = "0x600A80F")]
	[Address(RVA = "0xF3F600", Offset = "0xF3E800", VA = "0x180F3F600")]
	private void TouchableStepNeutral()
	{
	}

	[Token(Token = "0x600A810")]
	[Address(RVA = "0xF3E8B0", Offset = "0xF3DAB0", VA = "0x180F3E8B0")]
	private void TouchableStepInitDrawCardCenterFirst()
	{
	}

	[Token(Token = "0x600A811")]
	[Address(RVA = "0xF3FD20", Offset = "0xF3EF20", VA = "0x180F3FD20")]
	private void TouchableStepWaitDrawCardCenterFirst()
	{
	}

	[Token(Token = "0x600A812")]
	[Address(RVA = "0xF40260", Offset = "0xF3F460", VA = "0x180F40260")]
	private void TouchableStepWaitDrawCardCenterLatter()
	{
	}

	[Token(Token = "0x600A813")]
	[Address(RVA = "0xF3F7E0", Offset = "0xF3E9E0", VA = "0x180F3F7E0")]
	private void TouchableStepWaitDetail()
	{
	}

	[Token(Token = "0x600A814")]
	[Address(RVA = "0xF3E8A0", Offset = "0xF3DAA0", VA = "0x180F3E8A0")]
	private void TouchableStepFinish()
	{
	}

	[Token(Token = "0x600A815")]
	[Address(RVA = "0xF40CD0", Offset = "0xF3FED0", VA = "0x180F40CD0")]
	private bool UpdateDeckBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600A816")]
	[Address(RVA = "0xF41160", Offset = "0xF40360", VA = "0x180F41160")]
	private void WaitBackStep()
	{
	}

	[Token(Token = "0x600A817")]
	[Address(RVA = "0xF3E2C0", Offset = "0xF3D4C0", VA = "0x180F3E2C0")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600A818")]
	[Address(RVA = "0xF3DC40", Offset = "0xF3CE40", VA = "0x180F3DC40")]
	public void Abort()
	{
	}

	[Token(Token = "0x600A81E")]
	[Address(RVA = "0xF415B0", Offset = "0xF407B0", VA = "0x180F415B0")]
	public DrawOperation()
	{
	}
}
