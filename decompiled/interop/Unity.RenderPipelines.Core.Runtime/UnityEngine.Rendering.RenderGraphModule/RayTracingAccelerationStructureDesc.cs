using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

public sealed class RayTracingAccelerationStructureDesc : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static RayTracingAccelerationStructureDesc()
	{
		Il2CppClassPointerStore<RayTracingAccelerationStructureDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RayTracingAccelerationStructureDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingAccelerationStructureDesc>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracingAccelerationStructureDesc>.NativeClassPtr, "name");
	}

	public RayTracingAccelerationStructureDesc(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RayTracingAccelerationStructureDesc()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RayTracingAccelerationStructureDesc>.NativeClassPtr))
	{
	}
}
