using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomGame.Certification;

[Serializable]
[Token(Token = "0x200151A")]
public class TreeData<T> where T : QuizInfo
{
	[Token(Token = "0x400CB24")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int Lv;

	[Token(Token = "0x400CB25")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private string Memo;

	[Token(Token = "0x400CB26")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[FormerlySerializedAs("m_quizList")]
	private T[] m_quizList;

	[Token(Token = "0x600829A")]
	public T[] GetDataList()
	{
		return null;
	}

	[Token(Token = "0x600829B")]
	public TreeData<T> Copy()
	{
		return null;
	}

	[Token(Token = "0x600829C")]
	public TreeData()
	{
	}
}
