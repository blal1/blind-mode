using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Common;

[Token(Token = "0x2000C57")]
public class MatchingCommentWithWaiting : MatchingComment
{
	[Token(Token = "0x4009AC3")]
	[FieldOffset(Offset = "0x48")]
	private GameObject _baseStandbyObj;

	[Token(Token = "0x4009AC4")]
	[FieldOffset(Offset = "0x50")]
	private GameObject _dotObjRoot;

	[Token(Token = "0x4009AC5")]
	[FieldOffset(Offset = "0x58")]
	private bool _waitingCommentFlag;

	[Token(Token = "0x6004B0A")]
	[Address(RVA = "0x93F520", Offset = "0x93E720", VA = "0x18093F520", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6004B0B")]
	[Address(RVA = "0x93F760", Offset = "0x93E960", VA = "0x18093F760", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6004B0C")]
	[Address(RVA = "0x93F660", Offset = "0x93E860", VA = "0x18093F660", Slot = "5")]
	public override void SetComment(string comment)
	{
	}

	[Token(Token = "0x6004B0D")]
	[Address(RVA = "0x93F640", Offset = "0x93E840", VA = "0x18093F640", Slot = "6")]
	public override void HideComment()
	{
	}

	[Token(Token = "0x6004B0E")]
	[Address(RVA = "0x93F6F0", Offset = "0x93E8F0", VA = "0x18093F6F0")]
	public void SetWaitingComment(string message)
	{
	}

	[Token(Token = "0x6004B0F")]
	[Address(RVA = "0x93F730", Offset = "0x93E930", VA = "0x18093F730")]
	public void StopWaitingComment()
	{
	}

	[Token(Token = "0x6004B10")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MatchingCommentWithWaiting()
	{
	}
}
