using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Certification;

[Serializable]
[Token(Token = "0x200151B")]
public class QuizInfo : IComparable<QuizInfo>
{
	[Token(Token = "0x400CB27")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int quiz_no;

	[Token(Token = "0x400CB28")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int timer_id;

	[Token(Token = "0x400CB29")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int quiz_id;

	[Token(Token = "0x400CB2A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int quiz_type;

	[Token(Token = "0x400CB2B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int answer_type;

	[Token(Token = "0x400CB2C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string text_id;

	[Token(Token = "0x400CB2D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string prefab_path;

	[Token(Token = "0x400CB2E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int view_type;

	[Token(Token = "0x400CB2F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string[] choices;

	[Token(Token = "0x400CB30")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int answer;

	[Token(Token = "0x400CB31")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int Expr_prefab_type;

	[Token(Token = "0x400CB32")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string Expr_prefab_path;

	[Token(Token = "0x400CB33")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string Expr_text_id;

	[Token(Token = "0x600829D")]
	[Address(RVA = "0xCC5E90", Offset = "0xCC5090", VA = "0x180CC5E90", Slot = "4")]
	public int CompareTo(QuizInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x600829E")]
	[Address(RVA = "0xCC5EC0", Offset = "0xCC50C0", VA = "0x180CC5EC0")]
	public QuizInfo Copy()
	{
		return null;
	}

	[Token(Token = "0x600829F")]
	[Address(RVA = "0xCC5F40", Offset = "0xCC5140", VA = "0x180CC5F40")]
	public QuizInfo()
	{
	}
}
