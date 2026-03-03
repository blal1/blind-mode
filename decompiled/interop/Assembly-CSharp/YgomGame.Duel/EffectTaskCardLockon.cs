using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AE8")]
public class EffectTaskCardLockon : EffectTask
{
	[Token(Token = "0x2001AE9")]
	private enum Step
	{
		[Token(Token = "0x400F690")]
		WaitCardLoad,
		[Token(Token = "0x400F691")]
		WaitCardMove,
		[Token(Token = "0x400F692")]
		WaitCardReload,
		[Token(Token = "0x400F693")]
		WaitEffect,
		[Token(Token = "0x400F694")]
		MoveFront,
		[Token(Token = "0x400F695")]
		CardShow,
		[Token(Token = "0x400F696")]
		MoveBack,
		[Token(Token = "0x400F697")]
		Finish
	}

	[Token(Token = "0x2001AEA")]
	private enum Type
	{
		[Token(Token = "0x400F699")]
		Target,
		[Token(Token = "0x400F69A")]
		NotTarget,
		[Token(Token = "0x400F69B")]
		Show,
		[Token(Token = "0x400F69C")]
		Zone
	}

	[Token(Token = "0x400F679")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F67A")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F67B")]
	[FieldOffset(Offset = "0x20")]
	private CardPlace cardPlace;

	[Token(Token = "0x400F67C")]
	[FieldOffset(Offset = "0x28")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F67D")]
	[FieldOffset(Offset = "0x30")]
	private bool tempCard;

	[Token(Token = "0x400F67E")]
	[FieldOffset(Offset = "0x34")]
	private int team;

	[Token(Token = "0x400F67F")]
	[FieldOffset(Offset = "0x38")]
	private int position;

	[Token(Token = "0x400F680")]
	[FieldOffset(Offset = "0x3C")]
	private int index;

	[Token(Token = "0x400F681")]
	[FieldOffset(Offset = "0x40")]
	private int uniqueID;

	[Token(Token = "0x400F682")]
	[FieldOffset(Offset = "0x44")]
	private bool face;

	[Token(Token = "0x400F683")]
	[FieldOffset(Offset = "0x48")]
	private int cardID;

	[Token(Token = "0x400F684")]
	[FieldOffset(Offset = "0x4C")]
	private bool exist;

	[Token(Token = "0x400F685")]
	[FieldOffset(Offset = "0x50")]
	private int waitFrame;

	[Token(Token = "0x400F686")]
	[FieldOffset(Offset = "0x54")]
	private bool loadingCard;

	[Token(Token = "0x400F687")]
	[FieldOffset(Offset = "0x58")]
	private Type type;

	[Token(Token = "0x400F688")]
	[FieldOffset(Offset = "0x5C")]
	private float time;

	[Token(Token = "0x400F689")]
	private const float MOVE_TIME = 0.375f;

	[Token(Token = "0x400F68A")]
	private const float WAIT_TIME = 0.5f;

	[Token(Token = "0x400F68B")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 defaultPos;

	[Token(Token = "0x400F68C")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 dstPos;

	[Token(Token = "0x400F68D")]
	[FieldOffset(Offset = "0x78")]
	private Quaternion defaultQuat;

	[Token(Token = "0x400F68E")]
	[FieldOffset(Offset = "0x88")]
	private Quaternion dstQuat;

	[Token(Token = "0x600AEC1")]
	[Address(RVA = "0x45D500", Offset = "0x45C700", VA = "0x18045D500")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AEC2")]
	[Address(RVA = "0x45CB80", Offset = "0x45BD80", VA = "0x18045CB80")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AEC3")]
	[Address(RVA = "0x45DBC0", Offset = "0x45CDC0", VA = "0x18045DBC0")]
	public EffectTaskCardLockon(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AEC4")]
	[Address(RVA = "0x45CCC0", Offset = "0x45BEC0", VA = "0x18045CCC0")]
	private void MakeCardRoot(bool createTempCard)
	{
	}

	[Token(Token = "0x600AEC5")]
	[Address(RVA = "0x45D710", Offset = "0x45C910", VA = "0x18045D710", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AEC6")]
	[Address(RVA = "0x45DA50", Offset = "0x45CC50", VA = "0x18045DA50")]
	private void WaitCardLoad()
	{
	}

	[Token(Token = "0x600AEC7")]
	[Address(RVA = "0x45DA60", Offset = "0x45CC60", VA = "0x18045DA60")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AEC8")]
	[Address(RVA = "0x45DBB0", Offset = "0x45CDB0", VA = "0x18045DBB0")]
	private void WaitCardReloadStep()
	{
	}

	[Token(Token = "0x600AEC9")]
	[Address(RVA = "0x45C4D0", Offset = "0x45B6D0", VA = "0x18045C4D0")]
	private void BeginCardShow()
	{
	}

	[Token(Token = "0x600AECA")]
	[Address(RVA = "0x45D100", Offset = "0x45C300", VA = "0x18045D100")]
	private void MoveFrontStep()
	{
	}

	[Token(Token = "0x600AECB")]
	[Address(RVA = "0x45CAD0", Offset = "0x45BCD0", VA = "0x18045CAD0")]
	private void CardShowStep()
	{
	}

	[Token(Token = "0x600AECC")]
	[Address(RVA = "0x45CE60", Offset = "0x45C060", VA = "0x18045CE60")]
	private void MoveBackStep()
	{
	}

	[Token(Token = "0x600AECD")]
	[Address(RVA = "0x45CC20", Offset = "0x45BE20", VA = "0x18045CC20")]
	private void FinishStep()
	{
	}
}
