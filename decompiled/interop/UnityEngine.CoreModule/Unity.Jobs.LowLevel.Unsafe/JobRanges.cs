using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct JobRanges
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BatchSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_NumJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalIterationCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartEndIndex;

	[FieldOffset(0)]
	public int BatchSize;

	[FieldOffset(4)]
	public int NumJobs;

	[FieldOffset(8)]
	public int TotalIterationCount;

	[FieldOffset(16)]
	public System.IntPtr StartEndIndex;

	static JobRanges()
	{
		Il2CppClassPointerStore<JobRanges>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobRanges");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobRanges>.NativeClassPtr);
		NativeFieldInfoPtr_BatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "BatchSize");
		NativeFieldInfoPtr_NumJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "NumJobs");
		NativeFieldInfoPtr_TotalIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "TotalIterationCount");
		NativeFieldInfoPtr_StartEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "StartEndIndex");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
