using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text;

public static class StringBuilderCache : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_t_cachedInstance;

	private static readonly System.IntPtr NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0;

	public unsafe static StringBuilder t_cachedInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_t_cachedInstance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_t_cachedInstance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static StringBuilderCache()
	{
		Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "StringBuilderCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr);
		NativeFieldInfoPtr_t_cachedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, "t_cachedInstance");
		NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100668756);
		NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100668757);
		NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100668758);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 780463, RefRangeEnd = 780496, XrefRangeStart = 780452, XrefRangeEnd = 780463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StringBuilder Acquire(int capacity = 16)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 780503, RefRangeEnd = 780514, XrefRangeStart = 780496, XrefRangeEnd = 780503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release(StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 780521, RefRangeEnd = 780553, XrefRangeStart = 780514, XrefRangeEnd = 780521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStringAndRelease(StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public StringBuilderCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
