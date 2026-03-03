using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class RenderRequestBatcherContext : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;

	public unsafe CommandBuffer commandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RenderRequestBatcherContext()
	{
		Il2CppClassPointerStore<RenderRequestBatcherContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "RenderRequestBatcherContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderRequestBatcherContext>.NativeClassPtr);
		NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderRequestBatcherContext>.NativeClassPtr, "commandBuffer");
	}

	public RenderRequestBatcherContext(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RenderRequestBatcherContext()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderRequestBatcherContext>.NativeClassPtr))
	{
	}
}
