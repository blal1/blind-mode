using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Utility;

namespace YgomSystem.Utility;

[Token(Token = "0x2000409")]
public static class StringUtil
{
	[Token(Token = "0x4001404")]
	public const string ColorTagRed = "<color=#F39700>";

	[Token(Token = "0x4001405")]
	public const string ColorTagBlue = "<color=#00D2FF>";

	[Token(Token = "0x4001406")]
	public const string ColorTagOrange = "<color=#FFC200>";

	[Token(Token = "0x4001407")]
	public const string EFFECTSEPERATER_TAG = "●";

	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x5D9E60", Offset = "0x5D9060", VA = "0x1805D9E60")]
	public static string NumToCommaString(int number)
	{
		return null;
	}

	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x5D9E80", Offset = "0x5D9080", VA = "0x1805D9E80")]
	public static string NumToCommaString(long number)
	{
		return null;
	}

	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x5D7B30", Offset = "0x5D6D30", VA = "0x1805D7B30")]
	public static string BinaryToString(byte[] src)
	{
		return null;
	}

	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x5D8C20", Offset = "0x5D7E20", VA = "0x1805D8C20")]
	public static string CreateText(int textId)
	{
		return null;
	}

	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x5D83F0", Offset = "0x5D75F0", VA = "0x1805D83F0")]
	public static string CreateTextFromListItems(int listIdx)
	{
		return null;
	}

	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x5D8570", Offset = "0x5D7770", VA = "0x1805D8570")]
	public static string CreateTextImpl(int textId, Func<int> mixNumFunc, Func<int, Engine.DialogMixTextType> mixTypeFunc, Func<int, int> mixDataFunc)
	{
		return null;
	}

	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x5D9930", Offset = "0x5D8B30", VA = "0x1805D9930")]
	public static bool IsMixedTextContainsTextID(int textID)
	{
		return default(bool);
	}

	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x5D7CF0", Offset = "0x5D6EF0", VA = "0x1805D7CF0")]
	public static string ChangeEffectColor(this string text, int eff)
	{
		return null;
	}

	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x5D8000", Offset = "0x5D7200", VA = "0x1805D8000")]
	public static string Coloring(this string str, string color)
	{
		return null;
	}

	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x5D9EA0", Offset = "0x5D90A0", VA = "0x1805D9EA0")]
	public static string Resizing(this string str, int size)
	{
		return null;
	}

	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x5D9F00", Offset = "0x5D9100", VA = "0x1805D9F00")]
	public static string Scaling(this string str, float scale)
	{
		return null;
	}

	[Token(Token = "0x60019C5")]
	[Address(RVA = "0x5D8120", Offset = "0x5D7320", VA = "0x1805D8120")]
	public static string Coloring(this string str, int color)
	{
		return null;
	}

	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x5D8250", Offset = "0x5D7450", VA = "0x1805D8250")]
	public static string Coloring(this string str, Color color)
	{
		return null;
	}

	[Token(Token = "0x60019C7")]
	[Address(RVA = "0x5D9AE0", Offset = "0x5D8CE0", VA = "0x1805D9AE0")]
	public static string MergeTextWithSeparateline(this string orgstr, string targetstr)
	{
		return null;
	}

	[Token(Token = "0x60019C8")]
	[Address(RVA = "0x5D99E0", Offset = "0x5D8BE0", VA = "0x1805D99E0")]
	public static string Italic(this string str)
	{
		return null;
	}

	[Token(Token = "0x60019C9")]
	[Address(RVA = "0x5D7C30", Offset = "0x5D6E30", VA = "0x1805D7C30")]
	public static string Bold(this string str)
	{
		return null;
	}

	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x5D7C80", Offset = "0x5D6E80", VA = "0x1805D7C80")]
	public static string Bracket(this string str)
	{
		return null;
	}

	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x5D9A30", Offset = "0x5D8C30", VA = "0x1805D9A30")]
	public static string LenticularBracket(this string str)
	{
		return null;
	}

	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x5D8EB0", Offset = "0x5D80B0", VA = "0x1805D8EB0")]
	public static string GetCounterName(Engine.CounterType counter)
	{
		return null;
	}

	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x5DA160", Offset = "0x5D9360", VA = "0x1805DA160")]
	public static string WildCardPatternToRegExPattern(string wcpattern)
	{
		return null;
	}

	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x5D9F70", Offset = "0x5D9170", VA = "0x1805D9F70")]
	public static Regex WildCardPatternToRegExObject(string wcpattern)
	{
		return null;
	}

	[Token(Token = "0x60019CF")]
	[Address(RVA = "0x5D9AA0", Offset = "0x5D8CA0", VA = "0x1805D9AA0")]
	public static string MakeFormatedText(string baseText, TextGroupLoadHolder textGroupLoadHolder, [Optional] List<object> args)
	{
		return null;
	}

	[Token(Token = "0x60019D0")]
	[Address(RVA = "0x5D97C0", Offset = "0x5D89C0", VA = "0x1805D97C0")]
	private static string InnerMakeFormatedText(string baseText, TextGroupLoadHolder textGroupLoadHolder, List<object> args)
	{
		return null;
	}

	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x5D8FC0", Offset = "0x5D81C0", VA = "0x1805D8FC0")]
	private static string InnerMakeFormatedText(TextGroupLoadHolder textGroupLoadHolder, object source)
	{
		return null;
	}
}
