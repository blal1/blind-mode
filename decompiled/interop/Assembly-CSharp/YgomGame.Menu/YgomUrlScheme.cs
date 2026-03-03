using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200138F")]
public class YgomUrlScheme
{
	[Token(Token = "0x2001390")]
	private class DelayCallUrl
	{
		[Token(Token = "0x400C27C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string delayLabel;

		[Token(Token = "0x400C27D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delayTime;

		[Token(Token = "0x400C27E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long delayUnixTime;

		[Token(Token = "0x400C27F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object url;

		[Token(Token = "0x400C280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool inputMask;

		[Token(Token = "0x6007972")]
		[Address(RVA = "0xC18BB0", Offset = "0xC17DB0", VA = "0x180C18BB0")]
		public DelayCallUrl(object url_, bool imask, float time, long utime, string label)
		{
		}
	}

	[Token(Token = "0x2001391")]
	private struct SchemeInfo
	{
		[Token(Token = "0x400C281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string url;

		[Token(Token = "0x400C282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public object option;

		[Token(Token = "0x400C283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object context;

		[Token(Token = "0x6007973")]
		[Address(RVA = "0xC21A70", Offset = "0xC20C70", VA = "0x180C21A70")]
		public SchemeInfo(string arg_url, [Optional] object arg_option, [Optional] object arg_context)
		{
		}
	}

	[Token(Token = "0x400C275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<DelayCallUrl> delayCall;

	[Token(Token = "0x400C276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, Action<Dictionary<string, object>>> callSchemeFuncs;

	[Token(Token = "0x400C277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<string, int> callSchemeRefCounter;

	[Token(Token = "0x400C278")]
	private const string URLQUEPATH = "UrlQueue";

	[Token(Token = "0x400C279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Dictionary<string, string> transitionCall;

	[Token(Token = "0x400C27A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string NOTIFICATIONPATH;

	[Token(Token = "0x400C27B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static List<SchemeInfo> keepSchemeContainer;

	[Token(Token = "0x600795C")]
	[Address(RVA = "0xC37240", Offset = "0xC36440", VA = "0x180C37240")]
	public static void CleanupYgomScheme()
	{
	}

	[Token(Token = "0x600795D")]
	[Address(RVA = "0xC3C940", Offset = "0xC3BB40", VA = "0x180C3C940")]
	public static void SetDelayUrlOpen(object url, bool inputMask, float time, long utime, string label)
	{
	}

	[Token(Token = "0x600795E")]
	[Address(RVA = "0xC374C0", Offset = "0xC366C0", VA = "0x180C374C0")]
	public static void DelayUpdate()
	{
	}

	[Token(Token = "0x600795F")]
	[Address(RVA = "0xC3D450", Offset = "0xC3C650", VA = "0x180C3D450")]
	private static void transitionHandle(ViewController.TransitionType tt, ViewController vc, ViewController preVc)
	{
	}

	[Token(Token = "0x6007960")]
	[Address(RVA = "0xC3D310", Offset = "0xC3C510", VA = "0x180C3D310")]
	private static void transitionHandleClear()
	{
	}

	[Token(Token = "0x6007961")]
	[Address(RVA = "0xC37B80", Offset = "0xC36D80", VA = "0x180C37B80")]
	public static void RegistYgomArgCommand()
	{
	}

	[Token(Token = "0x6007962")]
	[Address(RVA = "0xC38100", Offset = "0xC37300", VA = "0x180C38100")]
	public static void RegistYgomScheme()
	{
	}

	[Token(Token = "0x6007963")]
	[Address(RVA = "0xC3D0C0", Offset = "0xC3C2C0", VA = "0x180C3D0C0")]
	private static bool isScheme(ref string url, string scheme)
	{
		return default(bool);
	}

	[Token(Token = "0x6007964")]
	[Address(RVA = "0xC36E20", Offset = "0xC36020", VA = "0x180C36E20")]
	public static Handle CallWabApi(string url, [Optional] object option, string schemename = "webapi://", float timeout = 30f)
	{
		return null;
	}

	[Token(Token = "0x6007965")]
	[Address(RVA = "0xC368F0", Offset = "0xC35AF0", VA = "0x180C368F0")]
	public static Handle CallWabApiWithClientWork(string url, [Optional] object option, string schemename = "webapicw://", float timeout = 30f)
	{
		return null;
	}

	[Token(Token = "0x6007966")]
	[Address(RVA = "0xC3C780", Offset = "0xC3B980", VA = "0x180C3C780")]
	public static void ResponseNotificator(object value)
	{
	}

	[Token(Token = "0x6007967")]
	[Address(RVA = "0xC3C5F0", Offset = "0xC3B7F0", VA = "0x180C3C5F0")]
	public static void RegisterCallSchemeFunction(string callName, Action<Dictionary<string, object>> act)
	{
	}

	[Token(Token = "0x6007968")]
	[Address(RVA = "0xC3CCB0", Offset = "0xC3BEB0", VA = "0x180C3CCB0")]
	public static void UnregisterCallSchemeFunction(string callName)
	{
	}

	[Token(Token = "0x6007969")]
	[Address(RVA = "0xC378C0", Offset = "0xC36AC0", VA = "0x180C378C0")]
	public static bool IsCallSchemeFunction(string callName)
	{
		return default(bool);
	}

	[Token(Token = "0x600796A")]
	[Address(RVA = "0xC366C0", Offset = "0xC358C0", VA = "0x180C366C0")]
	public static void AddKeepScheme(string url, [Optional] object option, [Optional] object context)
	{
	}

	[Token(Token = "0x600796B")]
	[Address(RVA = "0xC37450", Offset = "0xC36650", VA = "0x180C37450")]
	public static void ClearKeepScheme()
	{
	}

	[Token(Token = "0x600796C")]
	[Address(RVA = "0xC37940", Offset = "0xC36B40", VA = "0x180C37940")]
	public static void OpenKeepScheme()
	{
	}

	[Token(Token = "0x600796D")]
	[Address(RVA = "0xC3D050", Offset = "0xC3C250", VA = "0x180C3D050")]
	private static bool checkMultiPlay()
	{
		return default(bool);
	}

	[Token(Token = "0x600796E")]
	[Address(RVA = "0xC3D110", Offset = "0xC3C310", VA = "0x180C3D110")]
	private static void parsePlayModeMenuUrl(string url, Action<Dictionary<string, object>> homepushAction)
	{
	}

	[Token(Token = "0x600796F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public YgomUrlScheme()
	{
	}
}
