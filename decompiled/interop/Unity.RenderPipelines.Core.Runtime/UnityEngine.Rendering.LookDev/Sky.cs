using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.LookDev;

public sealed class Sky : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cubemap;

	private static readonly System.IntPtr NativeFieldInfoPtr_longitudeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_exposure;

	public unsafe Cubemap cubemap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Cubemap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float longitudeOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longitudeOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longitudeOffset)) = value;
		}
	}

	public unsafe float exposure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposure);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposure)) = value;
		}
	}

	static Sky()
	{
		Il2CppClassPointerStore<Sky>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.LookDev", "Sky");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sky>.NativeClassPtr);
		NativeFieldInfoPtr_cubemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sky>.NativeClassPtr, "cubemap");
		NativeFieldInfoPtr_longitudeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sky>.NativeClassPtr, "longitudeOffset");
		NativeFieldInfoPtr_exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sky>.NativeClassPtr, "exposure");
	}

	public Sky(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Sky()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sky>.NativeClassPtr))
	{
	}
}
