using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Utility;

[Token(Token = "0x200091B")]
public class NGWordCheck
{
	[Token(Token = "0x200091C")]
	public enum ErrorType
	{
		[Token(Token = "0x40089AA")]
		Normal,
		[Token(Token = "0x40089AB")]
		Error1,
		[Token(Token = "0x40089AC")]
		Error2
	}

	[Token(Token = "0x40089A5")]
	private const int lowerLimit = 3;

	[Token(Token = "0x40089A6")]
	private const int upperLimit = 12;

	[Token(Token = "0x40089A7")]
	private const int numLimit = 6;

	[Token(Token = "0x40089A8")]
	private const string numberRegex = "\\d";

	[Token(Token = "0x60036A1")]
	[Address(RVA = "0x7C58B0", Offset = "0x7C4AB0", VA = "0x1807C58B0")]
	public static (ErrorType, string) Check(string src, [Optional] TMP_FontAsset fontAsset)
	{
		return default((ErrorType, string));
	}

	[Token(Token = "0x60036A2")]
	[Address(RVA = "0x7C5A00", Offset = "0x7C4C00", VA = "0x1807C5A00")]
	public static string GetErrorMessage(ErrorType errorType)
	{
		return null;
	}

	[Token(Token = "0x60036A3")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public NGWordCheck()
	{
	}
}
