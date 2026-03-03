using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000041")]
[CreateAssetMenu(fileName = "DownloadQuizSettings", menuName = "Scriptable Object/DownloadQuizSettings")]
public class DownloadQuizSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000042")]
	public class QuizData
	{
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x10")]
		public int poolId;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x14")]
		public int quizId;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x18")]
		public int quizType;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x20")]
		public string quizText;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x28")]
		public string quizPath;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x30")]
		public List<string> answers;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x3E3A90", Offset = "0x3E2C90", VA = "0x1803E3A90")]
		public QuizData Copy()
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public QuizData()
		{
		}
	}

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x18")]
	public List<QuizData> quizDatas;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x3DB8F0", Offset = "0x3DAAF0", VA = "0x1803DB8F0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x3DB7B0", Offset = "0x3DA9B0", VA = "0x1803DB7B0")]
	public QuizData GetQuizData(int quizId)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x3DBA10", Offset = "0x3DAC10", VA = "0x1803DBA10")]
	public DownloadQuizSettings()
	{
	}
}
