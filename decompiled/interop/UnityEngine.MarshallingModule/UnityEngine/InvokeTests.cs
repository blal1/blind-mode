using System;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public class InvokeTests
{
	private delegate bool TestInvokeBoolDelegate(bool arg);

	private delegate sbyte TestInvokeSByteDelegate(sbyte arg);

	private delegate byte TestInvokeByteDelegate(byte arg);

	private delegate char TestInvokeCharDelegate(char arg);

	private delegate short TestInvokeShortDelegate(short arg);

	private delegate ushort TestInvokeUShortDelegate(ushort arg);

	private delegate int TestInvokeIntDelegate(int arg);

	private delegate uint TestInvokeUIntDelegate(uint arg);

	private delegate long TestInvokeLongDelegate(long arg);

	private delegate ulong TestInvokeULongDelegate(ulong arg);

	private delegate System.IntPtr TestInvokeIntPtrDelegate(System.IntPtr arg);

	private delegate System.UIntPtr TestInvokeUIntPtrDelegate(System.UIntPtr arg);

	private delegate float TestInvokeFloatDelegate(float arg);

	private delegate double TestInvokeDoubleDelegate(double arg);

	private static readonly TestInvokeBoolDelegate TestInvokeBoolDelegateField = IL2CPP.ResolveICall<TestInvokeBoolDelegate>("UnityEngine.InvokeTests::TestInvokeBool");

	private static readonly TestInvokeSByteDelegate TestInvokeSByteDelegateField = IL2CPP.ResolveICall<TestInvokeSByteDelegate>("UnityEngine.InvokeTests::TestInvokeSByte");

	private static readonly TestInvokeByteDelegate TestInvokeByteDelegateField = IL2CPP.ResolveICall<TestInvokeByteDelegate>("UnityEngine.InvokeTests::TestInvokeByte");

	private static readonly TestInvokeCharDelegate TestInvokeCharDelegateField = IL2CPP.ResolveICall<TestInvokeCharDelegate>("UnityEngine.InvokeTests::TestInvokeChar");

	private static readonly TestInvokeShortDelegate TestInvokeShortDelegateField = IL2CPP.ResolveICall<TestInvokeShortDelegate>("UnityEngine.InvokeTests::TestInvokeShort");

	private static readonly TestInvokeUShortDelegate TestInvokeUShortDelegateField = IL2CPP.ResolveICall<TestInvokeUShortDelegate>("UnityEngine.InvokeTests::TestInvokeUShort");

	private static readonly TestInvokeIntDelegate TestInvokeIntDelegateField = IL2CPP.ResolveICall<TestInvokeIntDelegate>("UnityEngine.InvokeTests::TestInvokeInt");

	private static readonly TestInvokeUIntDelegate TestInvokeUIntDelegateField = IL2CPP.ResolveICall<TestInvokeUIntDelegate>("UnityEngine.InvokeTests::TestInvokeUInt");

	private static readonly TestInvokeLongDelegate TestInvokeLongDelegateField = IL2CPP.ResolveICall<TestInvokeLongDelegate>("UnityEngine.InvokeTests::TestInvokeLong");

	private static readonly TestInvokeULongDelegate TestInvokeULongDelegateField = IL2CPP.ResolveICall<TestInvokeULongDelegate>("UnityEngine.InvokeTests::TestInvokeULong");

	private static readonly TestInvokeIntPtrDelegate TestInvokeIntPtrDelegateField = IL2CPP.ResolveICall<TestInvokeIntPtrDelegate>("UnityEngine.InvokeTests::TestInvokeIntPtr");

	private static readonly TestInvokeUIntPtrDelegate TestInvokeUIntPtrDelegateField = IL2CPP.ResolveICall<TestInvokeUIntPtrDelegate>("UnityEngine.InvokeTests::TestInvokeUIntPtr");

	private static readonly TestInvokeFloatDelegate TestInvokeFloatDelegateField = IL2CPP.ResolveICall<TestInvokeFloatDelegate>("UnityEngine.InvokeTests::TestInvokeFloat");

	private static readonly TestInvokeDoubleDelegate TestInvokeDoubleDelegateField = IL2CPP.ResolveICall<TestInvokeDoubleDelegate>("UnityEngine.InvokeTests::TestInvokeDouble");

	public static bool TestInvokeBool(bool arg)
	{
		return TestInvokeBoolDelegateField(arg);
	}

	public static sbyte TestInvokeSByte(sbyte arg)
	{
		return TestInvokeSByteDelegateField(arg);
	}

	public static byte TestInvokeByte(byte arg)
	{
		return TestInvokeByteDelegateField(arg);
	}

	public static char TestInvokeChar(char arg)
	{
		return TestInvokeCharDelegateField(arg);
	}

	public static short TestInvokeShort(short arg)
	{
		return TestInvokeShortDelegateField(arg);
	}

	public static ushort TestInvokeUShort(ushort arg)
	{
		return TestInvokeUShortDelegateField(arg);
	}

	public static int TestInvokeInt(int arg)
	{
		return TestInvokeIntDelegateField(arg);
	}

	public static uint TestInvokeUInt(uint arg)
	{
		return TestInvokeUIntDelegateField(arg);
	}

	public static long TestInvokeLong(long arg)
	{
		return TestInvokeLongDelegateField(arg);
	}

	public static ulong TestInvokeULong(ulong arg)
	{
		return TestInvokeULongDelegateField(arg);
	}

	public static System.IntPtr TestInvokeIntPtr(System.IntPtr arg)
	{
		return TestInvokeIntPtrDelegateField(arg);
	}

	public static System.UIntPtr TestInvokeUIntPtr(System.UIntPtr arg)
	{
		return TestInvokeUIntPtrDelegateField(arg);
	}

	public static float TestInvokeFloat(float arg)
	{
		return TestInvokeFloatDelegateField(arg);
	}

	public static double TestInvokeDouble(double arg)
	{
		return TestInvokeDoubleDelegateField(arg);
	}

	public static bool InvokeBool(bool arg)
	{
		return arg;
	}

	public static sbyte InvokeSByte(sbyte arg)
	{
		return arg;
	}

	public static byte InvokeByte(byte arg)
	{
		return arg;
	}

	public static char InvokeChar(char arg)
	{
		return arg;
	}

	public static short InvokeShort(short arg)
	{
		return arg;
	}

	public static ushort InvokeUShort(ushort arg)
	{
		return arg;
	}

	public static int InvokeInt(int arg)
	{
		return arg;
	}

	public static uint InvokeUInt(uint arg)
	{
		return arg;
	}

	public static long InvokeLong(long arg)
	{
		return arg;
	}

	public static ulong InvokeULong(ulong arg)
	{
		return arg;
	}

	public static System.IntPtr InvokeIntPtr(System.IntPtr arg)
	{
		return arg;
	}

	public static System.UIntPtr InvokeUIntPtr(System.UIntPtr arg)
	{
		return arg;
	}

	public static float InvokeFloat(float arg)
	{
		return arg;
	}

	public static double InvokeDouble(double arg)
	{
		return arg;
	}
}
