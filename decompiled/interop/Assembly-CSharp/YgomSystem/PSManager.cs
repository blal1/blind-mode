using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x200017A")]
public class PSManager : MonoBehaviour
{
	[Token(Token = "0x4000908")]
	public const int ICON_CENTER = 0;

	[Token(Token = "0x4000909")]
	public const int ICON_LEFT = 1;

	[Token(Token = "0x400090A")]
	public const int ICON_RIGHT = 2;

	[Token(Token = "0x400090B")]
	private const float premiumFeatureIntervalVal = 2f;

	[Token(Token = "0x6000995")]
	[Address(RVA = "0xAFCE40", Offset = "0xAFC040", VA = "0x180AFCE40")]
	public static void StartPSPremiumCheck(bool IsSpectating, Action<bool> callback, bool openPlusDialog = false)
	{
	}

	[Token(Token = "0x6000996")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void EndPSPremiumCheck()
	{
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void ShowPsStoreIcon(bool state, int postion = 0)
	{
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0xAFCE20", Offset = "0xAFC020", VA = "0x180AFCE20")]
	public static void CheckCommunicationRestriction(Action<bool> callback)
	{
	}

	[Token(Token = "0x6000999")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void StartTutorialActivity()
	{
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void EndTutorialActivity()
	{
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void StartMatchActivity()
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void EndMatchActivity()
	{
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void StartTeamMatchActivity()
	{
	}

	[Token(Token = "0x600099E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void EndTeamMatchActivity()
	{
	}

	[Token(Token = "0x600099F")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	public static bool IsPSPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
	public static bool IsMultiPlayOK()
	{
		return default(bool);
	}

	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void ShowMultiPlayNGMessage()
	{
	}

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
	public static string GetPushContextId(bool isInvite = false)
	{
		return null;
	}

	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void ShowEmptyStoreMessage()
	{
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PSManager()
	{
	}
}
