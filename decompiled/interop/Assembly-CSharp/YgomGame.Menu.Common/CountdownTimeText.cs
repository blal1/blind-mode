using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001405")]
public class CountdownTimeText : MonoBehaviour
{
	[Token(Token = "0x400C4E0")]
	[FieldOffset(Offset = "0x20")]
	private TMP_Text m_TargetText;

	[Token(Token = "0x400C4E1")]
	[FieldOffset(Offset = "0x28")]
	private long m_LimitUnixTime;

	[Token(Token = "0x400C4E2")]
	[FieldOffset(Offset = "0x30")]
	private long m_LastUpdatedUnixTime;

	[Token(Token = "0x400C4E3")]
	[FieldOffset(Offset = "0x38")]
	private Action<TMP_Text, long> m_TextUpdateCallback;

	[Token(Token = "0x6007C81")]
	[Address(RVA = "0xC5FA00", Offset = "0xC5EC00", VA = "0x180C5FA00")]
	public static CountdownTimeText Attach(TMP_Text target, long limitUnixTime, Action<TMP_Text, long> textUpdateCallback)
	{
		return null;
	}

	[Token(Token = "0x6007C82")]
	[Address(RVA = "0xC5FAE0", Offset = "0xC5ECE0", VA = "0x180C5FAE0")]
	public static void Detach(TMP_Text target, bool isDestroy = true)
	{
	}

	[Token(Token = "0x6007C83")]
	[Address(RVA = "0xC5FEC0", Offset = "0xC5F0C0", VA = "0x180C5FEC0")]
	public TimeSpan GetTimeSpan()
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x6007C84")]
	[Address(RVA = "0xC5FF50", Offset = "0xC5F150", VA = "0x180C5FF50")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6007C85")]
	[Address(RVA = "0xC60030", Offset = "0xC5F230", VA = "0x180C60030")]
	public static void SetClampedMinutesRemainText(TMP_Text targetText, long remainSec)
	{
	}

	[Token(Token = "0x6007C86")]
	[Address(RVA = "0xC5FFF0", Offset = "0xC5F1F0", VA = "0x180C5FFF0")]
	public static void SetClampedDaysRemainText(TMP_Text targetText, long remainSec)
	{
	}

	[Token(Token = "0x6007C87")]
	[Address(RVA = "0xC5FBE0", Offset = "0xC5EDE0", VA = "0x180C5FBE0")]
	public static string GetClampedDaysRemainText(long remainSec)
	{
		return null;
	}

	[Token(Token = "0x6007C88")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CountdownTimeText()
	{
	}
}
