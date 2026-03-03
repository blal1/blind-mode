using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomGame.Duel;

[Token(Token = "0x2001AB7")]
public class WorldDragController
{
	[Token(Token = "0x2001AB8")]
	public enum State
	{
		[Token(Token = "0x400F56F")]
		Idle,
		[Token(Token = "0x400F570")]
		BeginDrag,
		[Token(Token = "0x400F571")]
		Dragging,
		[Token(Token = "0x400F572")]
		EndDrag
	}

	[Token(Token = "0x400F567")]
	[FieldOffset(Offset = "0x10")]
	private ITranslateScreenToWorld scrToWorld;

	[Token(Token = "0x400F568")]
	[FieldOffset(Offset = "0x18")]
	private Queue<Vector3> dragHistory;

	[Token(Token = "0x400F569")]
	[FieldOffset(Offset = "0x20")]
	private float currentTime;

	[Token(Token = "0x400F56A")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 move;

	[Token(Token = "0x400F56B")]
	[FieldOffset(Offset = "0x30")]
	private bool draggingOnThisFrame;

	[Token(Token = "0x400F56C")]
	[FieldOffset(Offset = "0x34")]
	private State state;

	[Token(Token = "0x400F56D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int numDragSpeedHistories;

	[Token(Token = "0x17001AE4")]
	public bool dragging
	{
		[Token(Token = "0x600ADBA")]
		[Address(RVA = "0x451BE0", Offset = "0x450DE0", VA = "0x180451BE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600ADB9")]
	[Address(RVA = "0x4511F0", Offset = "0x4503F0", VA = "0x1804511F0")]
	public static WorldDragController Create(ITranslateScreenToWorld scrToWorld)
	{
		return null;
	}

	[Token(Token = "0x600ADBB")]
	[Address(RVA = "0x4517C0", Offset = "0x4509C0", VA = "0x1804517C0")]
	public State Update(out Vector3 move, out Vector3 average)
	{
		return default(State);
	}

	[Token(Token = "0x600ADBC")]
	[Address(RVA = "0x451480", Offset = "0x450680", VA = "0x180451480")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600ADBD")]
	[Address(RVA = "0x451560", Offset = "0x450760", VA = "0x180451560")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600ADBE")]
	[Address(RVA = "0x4517B0", Offset = "0x4509B0", VA = "0x1804517B0")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600ADBF")]
	[Address(RVA = "0x4512B0", Offset = "0x4504B0", VA = "0x1804512B0")]
	private void EnqueueDragHistory(Vector3 deltaMove)
	{
	}

	[Token(Token = "0x600ADC0")]
	[Address(RVA = "0x451390", Offset = "0x450590", VA = "0x180451390")]
	private Vector3 GetDirection(Vector2 s0, Vector2 s1)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600ADC1")]
	[Address(RVA = "0x451B60", Offset = "0x450D60", VA = "0x180451B60")]
	public WorldDragController()
	{
	}
}
