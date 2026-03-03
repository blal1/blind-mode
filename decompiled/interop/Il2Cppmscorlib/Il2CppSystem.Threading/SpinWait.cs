using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

[StructLayout(LayoutKind.Explicit)]
public struct SpinWait
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SpinCountforSpinBeforeWait;

	private static readonly System.IntPtr NativeFieldInfoPtr__count;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpinOnce_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpinOnce_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpinOnceCore_Private_Void_Int32_0;

	[FieldOffset(0)]
	public int _count;

	public unsafe static int SpinCountforSpinBeforeWait
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpinCountforSpinBeforeWait, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpinCountforSpinBeforeWait, (void*)(&value));
		}
	}

	public unsafe int Count
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool NextSpinWillYield
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767289, XrefRangeEnd = 767290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SpinWait()
	{
		Il2CppClassPointerStore<SpinWait>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinWait");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinWait>.NativeClassPtr);
		NativeFieldInfoPtr_SpinCountforSpinBeforeWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, "SpinCountforSpinBeforeWait");
		NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, "_count");
		NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667626);
		NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667627);
		NativeMethodInfoPtr_SpinOnce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667628);
		NativeMethodInfoPtr_SpinOnce_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667629);
		NativeMethodInfoPtr_SpinOnceCore_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667630);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 767294, RefRangeEnd = 767304, XrefRangeStart = 767290, XrefRangeEnd = 767294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpinOnce()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpinOnce_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 767323, RefRangeEnd = 767325, XrefRangeStart = 767304, XrefRangeEnd = 767323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpinOnce(int sleep1Threshold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sleep1Threshold);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpinOnce_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 767345, RefRangeEnd = 767355, XrefRangeStart = 767325, XrefRangeEnd = 767345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpinOnceCore(int sleep1Threshold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sleep1Threshold);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpinOnceCore_Private_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
