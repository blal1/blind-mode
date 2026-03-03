using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading;

public static class Interlocked : Object
{
	private sealed class MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0;

	static Interlocked()
	{
		Il2CppClassPointerStore<Interlocked>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Interlocked");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interlocked>.NativeClassPtr);
		NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668015);
		NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668016);
		NativeMethodInfoPtr_CompareExchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668017);
		NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668018);
		NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668019);
		NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668020);
		NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668021);
		NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668022);
		NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668023);
		NativeMethodInfoPtr_Exchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668024);
		NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668025);
		NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668026);
		NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668027);
		NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668028);
		NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668029);
		NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668030);
		NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668031);
		NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668032);
		NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668033);
		NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668034);
		NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668035);
		NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668036);
		NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668037);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 771988, RefRangeEnd = 772039, XrefRangeStart = 771987, XrefRangeEnd = 771988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareExchange(ref int location1, int value, int comparand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparand;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772039, XrefRangeEnd = 772040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparand;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref succeeded);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772040, XrefRangeEnd = 772041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompareExchange(ref Object location1, ref Object value, ref Object comparand, ref Object result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location1);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparand);
		*(System.IntPtr**)num2 = &intPtr3;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num3 = &intPtr4;
		Unsafe.SkipInit(out System.IntPtr intPtr5);
		System.IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_byref_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		System.IntPtr intPtr7 = intPtr;
		location1 = ((intPtr7 == (System.IntPtr)0) ? null : new Object(intPtr7));
		System.IntPtr intPtr8 = intPtr2;
		value = ((intPtr8 == (System.IntPtr)0) ? null : new Object(intPtr8));
		System.IntPtr intPtr9 = intPtr3;
		comparand = ((intPtr9 == (System.IntPtr)0) ? null : new Object(intPtr9));
		System.IntPtr intPtr10 = intPtr4;
		result = ((intPtr10 == (System.IntPtr)0) ? null : new Object(intPtr10));
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 772042, RefRangeEnd = 772059, XrefRangeStart = 772041, XrefRangeEnd = 772042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CompareExchange(ref Object location1, Object value, Object comparand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location1);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparand);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		location1 = ((intPtr4 == (System.IntPtr)0) ? null : new Object(intPtr4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 772060, RefRangeEnd = 772061, XrefRangeStart = 772059, XrefRangeEnd = 772060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CompareExchange(ref float location1, float value, float comparand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparand;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 772062, RefRangeEnd = 772069, XrefRangeStart = 772061, XrefRangeEnd = 772062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Decrement(ref int location)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref location);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 772070, RefRangeEnd = 772089, XrefRangeStart = 772069, XrefRangeEnd = 772070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Increment(ref int location)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref location);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 772090, RefRangeEnd = 772092, XrefRangeStart = 772089, XrefRangeEnd = 772090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Increment(ref long location)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref location);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 772093, RefRangeEnd = 772123, XrefRangeStart = 772092, XrefRangeEnd = 772093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Exchange(ref int location1, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772123, XrefRangeEnd = 772124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Exchange(ref Object location1, ref Object value, ref Object result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location1);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num2 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		location1 = ((intPtr6 == (System.IntPtr)0) ? null : new Object(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		value = ((intPtr7 == (System.IntPtr)0) ? null : new Object(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		result = ((intPtr8 == (System.IntPtr)0) ? null : new Object(intPtr8));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 772125, RefRangeEnd = 772126, XrefRangeStart = 772124, XrefRangeEnd = 772125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Exchange(ref Object location1, Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location1);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		location1 = ((intPtr4 == (System.IntPtr)0) ? null : new Object(intPtr4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772126, XrefRangeEnd = 772127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Exchange(ref float location1, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 772128, RefRangeEnd = 772131, XrefRangeStart = 772127, XrefRangeEnd = 772128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long CompareExchange(ref long location1, long value, long comparand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparand;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 772128, RefRangeEnd = 772131, XrefRangeStart = 772128, XrefRangeEnd = 772131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CompareExchange(ref System.IntPtr location1, System.IntPtr value, System.IntPtr comparand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparand;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772131, XrefRangeEnd = 772132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CompareExchange(ref double location1, double value, double comparand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparand;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
	{
		//IL_005d->IL0060: Incompatible stack types: I vs Ref
		//IL_0050->IL0060: Incompatible stack types: I vs Ref
		//IL_00a5->IL00a8: Incompatible stack types: I vs Ref
		//IL_0098->IL00a8: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location1);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference2;
		if (!typeof(T).IsValueType)
		{
			T val2 = comparand;
			reference2 = ref *(_003F*)((!(val2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val2 is Il2CppObjectBase) ? val2 : null)) : IL2CPP.ManagedStringToIl2Cpp(val2 as string));
		}
		else
		{
			reference2 = ref comparand;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		location1 = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 772133, RefRangeEnd = 772149, XrefRangeStart = 772132, XrefRangeEnd = 772133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Exchange(ref long location1, long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 772133, RefRangeEnd = 772149, XrefRangeStart = 772133, XrefRangeEnd = 772149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Exchange(ref System.IntPtr location1, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772149, XrefRangeEnd = 772150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Exchange(ref double location1, double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static T Exchange<T>(ref T location1, T value) where T : class
	{
		//IL_005d->IL0060: Incompatible stack types: I vs Ref
		//IL_0050->IL0060: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location1);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		location1 = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 772151, RefRangeEnd = 772169, XrefRangeStart = 772150, XrefRangeEnd = 772151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Read(ref long location)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref location);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 772170, RefRangeEnd = 772186, XrefRangeStart = 772169, XrefRangeEnd = 772170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Add(ref int location1, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref location1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770921, RefRangeEnd = 770923, XrefRangeStart = 770921, XrefRangeEnd = 770923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemoryBarrier()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Interlocked(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
