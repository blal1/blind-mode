using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorderSample
{
	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_refValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int64_0;

	[FieldOffset(0)]
	public long value;

	[FieldOffset(8)]
	public long count;

	[FieldOffset(16)]
	public long refValue;

	public unsafe long Count
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public long Value => value;

	static ProfilerRecorderSample()
	{
		Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorderSample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr);
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "value");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "count");
		NativeFieldInfoPtr_refValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "refValue");
		NativeMethodInfoPtr_get_Count_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, 100663414);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
