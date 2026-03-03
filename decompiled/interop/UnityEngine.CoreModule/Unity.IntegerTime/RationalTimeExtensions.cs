using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IntegerTime;

public static class RationalTimeExtensions : Il2CppSystem.Object
{
	private delegate double ToDouble_InjectedDelegate([In] System.IntPtr value);

	private delegate bool IsValid_InjectedDelegate([In] System.IntPtr value);

	private delegate void Add_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);

	private delegate void Subtract_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);

	private delegate void Multiply_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);

	private delegate void Divide_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Static_RationalTime_RationalTime_TicksPerSecond_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Injected_Private_Static_Void_byref_RationalTime_byref_TicksPerSecond_byref_RationalTime_0;

	private static readonly ToDouble_InjectedDelegate ToDouble_InjectedDelegateField;

	private static readonly IsValid_InjectedDelegate IsValid_InjectedDelegateField;

	private static readonly Add_InjectedDelegate Add_InjectedDelegateField;

	private static readonly Subtract_InjectedDelegate Subtract_InjectedDelegateField;

	private static readonly Multiply_InjectedDelegate Multiply_InjectedDelegateField;

	private static readonly Divide_InjectedDelegate Divide_InjectedDelegateField;

	static RationalTimeExtensions()
	{
		Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IntegerTime", "RationalTimeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Convert_Public_Static_RationalTime_RationalTime_TicksPerSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_Convert_Injected_Private_Static_Void_byref_RationalTime_byref_TicksPerSecond_byref_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr, 100663401);
		ToDouble_InjectedDelegateField = IL2CPP.ResolveICall<ToDouble_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::ToDouble_Injected");
		IsValid_InjectedDelegateField = IL2CPP.ResolveICall<IsValid_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::IsValid_Injected");
		Add_InjectedDelegateField = IL2CPP.ResolveICall<Add_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Add_Injected");
		Subtract_InjectedDelegateField = IL2CPP.ResolveICall<Subtract_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Subtract_Injected");
		Multiply_InjectedDelegateField = IL2CPP.ResolveICall<Multiply_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Multiply_Injected");
		Divide_InjectedDelegateField = IL2CPP.ResolveICall<Divide_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Divide_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164502, XrefRangeEnd = 1164504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RationalTime Convert(this RationalTime time, RationalTime.TicksPerSecond rate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(RationalTime.TicksPerSecond**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Convert_Public_Static_RationalTime_RationalTime_TicksPerSecond_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RationalTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164504, XrefRangeEnd = 1164506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Convert_Injected([In] ref RationalTime time, [In] ref RationalTime.TicksPerSecond rate, out RationalTime ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref time);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rate);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Convert_Injected_Private_Static_Void_byref_RationalTime_byref_TicksPerSecond_byref_RationalTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RationalTimeExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static double ToDouble(RationalTime value)
	{
		return ToDouble_Injected(ref value);
	}

	public static bool IsValid(RationalTime value)
	{
		return IsValid_Injected(ref value);
	}

	public static RationalTime Add(RationalTime lhs, RationalTime rhs)
	{
		Add_Injected(ref lhs, ref rhs, out var ret);
		return ret;
	}

	public static RationalTime Subtract(RationalTime lhs, RationalTime rhs)
	{
		Subtract_Injected(ref lhs, ref rhs, out var ret);
		return ret;
	}

	public static RationalTime Multiply(RationalTime lhs, RationalTime rhs)
	{
		Multiply_Injected(ref lhs, ref rhs, out var ret);
		return ret;
	}

	public static RationalTime Divide(RationalTime lhs, RationalTime rhs)
	{
		Divide_Injected(ref lhs, ref rhs, out var ret);
		return ret;
	}

	public unsafe static double ToDouble_Injected([In] ref RationalTime value)
	{
		return ToDouble_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool IsValid_Injected([In] ref RationalTime value)
	{
		return IsValid_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void Add_Injected([In] ref RationalTime lhs, [In] ref RationalTime rhs, out RationalTime ret)
	{
		Add_InjectedDelegateField((nint)Unsafe.AsPointer(ref lhs), (nint)Unsafe.AsPointer(ref rhs), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Subtract_Injected([In] ref RationalTime lhs, [In] ref RationalTime rhs, out RationalTime ret)
	{
		Subtract_InjectedDelegateField((nint)Unsafe.AsPointer(ref lhs), (nint)Unsafe.AsPointer(ref rhs), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Multiply_Injected([In] ref RationalTime lhs, [In] ref RationalTime rhs, out RationalTime ret)
	{
		Multiply_InjectedDelegateField((nint)Unsafe.AsPointer(ref lhs), (nint)Unsafe.AsPointer(ref rhs), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Divide_Injected([In] ref RationalTime lhs, [In] ref RationalTime rhs, out RationalTime ret)
	{
		Divide_InjectedDelegateField((nint)Unsafe.AsPointer(ref lhs), (nint)Unsafe.AsPointer(ref rhs), (nint)Unsafe.AsPointer(ref ret));
	}
}
