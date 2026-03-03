using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BinningConfig
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportsCrossFade;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportsMotionCheck;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibilityConfigCount_Public_get_Int32_0;

	[FieldOffset(0)]
	public int viewCount;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool supportsCrossFade;

	[FieldOffset(5)]
	[MarshalAs(UnmanagedType.U1)]
	public bool supportsMotionCheck;

	public unsafe int visibilityConfigCount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibilityConfigCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BinningConfig()
	{
		Il2CppClassPointerStore<BinningConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "BinningConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinningConfig>.NativeClassPtr);
		NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinningConfig>.NativeClassPtr, "viewCount");
		NativeFieldInfoPtr_supportsCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinningConfig>.NativeClassPtr, "supportsCrossFade");
		NativeFieldInfoPtr_supportsMotionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinningConfig>.NativeClassPtr, "supportsMotionCheck");
		NativeMethodInfoPtr_get_visibilityConfigCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinningConfig>.NativeClassPtr, 100663545);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BinningConfig>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
