using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000029")]
public class InAppBilling : MonoBehaviour
{
	[Token(Token = "0x200002A")]
	public delegate void Func();

	[Token(Token = "0x40000A4")]
	private const string version = "0.7.20250618";

	[Token(Token = "0x40000A5")]
	public const int SUCCESS = 0;

	[Token(Token = "0x40000A6")]
	public const int ERR_REQUIRE_AGE = -1;

	[Token(Token = "0x40000A7")]
	public const int ERR_INVALID_RECEIPT = -2;

	[Token(Token = "0x40000A8")]
	public const int ERR_BAD_REQUEST = -3;

	[Token(Token = "0x40000A9")]
	public const int ERR_ALREADY_FINISHED = -4;

	[Token(Token = "0x40000AA")]
	public const int ERR_SERVER = -5;

	[Token(Token = "0x40000AB")]
	public const int ERR_USER_CANNOT_BUY = -6;

	[Token(Token = "0x40000AC")]
	public const int ERR_MAINTENANCE = -7;

	[Token(Token = "0x40000AD")]
	public const int ERR_NOT_ENOUGH_POINT = -8;

	[Token(Token = "0x40000AE")]
	public const int ERR_BAD_USER = -9;

	[Token(Token = "0x40000AF")]
	public const int ERR_PURCHASE_CANCELED = -13;

	[Token(Token = "0x40000B0")]
	public const int ERR_NO_SUBSCRIPTIONS = -14;

	[Token(Token = "0x40000B1")]
	public const int ERR_VOIDED_PURCHASE = -15;

	[Token(Token = "0x40000B2")]
	public const int ERR_PURCHASE_PENDING = -16;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public string base64EncodedPublicKey;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x28")]
	public bool debuggable;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x0")]
	private static Queue<Func> queue;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x3E1200", Offset = "0x3E0400", VA = "0x1803E1200")]
	private string decode(string str)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x3E0F90", Offset = "0x3E0190", VA = "0x1803E0F90")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x3E0FE0", Offset = "0x3E01E0", VA = "0x1803E0FE0")]
	public static void RunOnMainThread(Func f)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x3E1060", Offset = "0x3E0260", VA = "0x1803E1060")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x3E11B0", Offset = "0x3E03B0", VA = "0x1803E11B0")]
	public InAppBilling()
	{
	}
}
