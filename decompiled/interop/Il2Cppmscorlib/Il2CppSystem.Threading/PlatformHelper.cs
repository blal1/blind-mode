using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

public static class PlatformHelper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_processorCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSingleProcessor;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0;

	public unsafe static int s_processorCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_processorCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_processorCount, (void*)(&value));
		}
	}

	public unsafe static int s_lastProcessorCountRefreshTicks
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&value));
		}
	}

	public unsafe static bool IsSingleProcessor
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsSingleProcessor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsSingleProcessor, (void*)(&value));
		}
	}

	public unsafe static int ProcessorCount
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 767365, RefRangeEnd = 767373, XrefRangeStart = 767355, XrefRangeEnd = 767365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PlatformHelper()
	{
		Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "PlatformHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr);
		NativeFieldInfoPtr_s_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_processorCount");
		NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_lastProcessorCountRefreshTicks");
		NativeFieldInfoPtr_IsSingleProcessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "IsSingleProcessor");
		NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100667632);
	}

	public PlatformHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
