using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct DecalSubDrawCall
{
	private static readonly System.IntPtr NativeFieldInfoPtr_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_end;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

	[FieldOffset(0)]
	public int start;

	[FieldOffset(4)]
	public int end;

	public unsafe int count
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_count_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DecalSubDrawCall()
	{
		Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalSubDrawCall");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr);
		NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, "start");
		NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, "end");
		NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, 100664069);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
