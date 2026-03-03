using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20017BC")]
[CreateAssetMenu(menuName = "Scriptable Object/DuelTutorialSetting")]
public class DuelTutorialSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20017BD")]
	public class TutorialChapter
	{
		[Token(Token = "0x400DE38")]
		[FieldOffset(Offset = "0x10")]
		public int chapter;

		[Token(Token = "0x6009560")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TutorialChapter()
		{
		}
	}

	[Token(Token = "0x400DE37")]
	[FieldOffset(Offset = "0x18")]
	public List<TutorialChapter> tutorialChapterList;

	[Token(Token = "0x600955E")]
	[Address(RVA = "0xE36960", Offset = "0xE35B60", VA = "0x180E36960")]
	public bool IsTutorialChapter(int chapter)
	{
		return default(bool);
	}

	[Token(Token = "0x600955F")]
	[Address(RVA = "0xE36A10", Offset = "0xE35C10", VA = "0x180E36A10")]
	public DuelTutorialSetting()
	{
	}
}
