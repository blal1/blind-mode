using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX;

public sealed class VFXBatchedEffectInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vfxAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeBatchCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_inactiveBatchCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInstanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_unbatchedInstanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalInstanceCapacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxInstancePerBatchCapacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalGPUSizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCPUSizeInBytes;

	public unsafe VisualEffectAsset vfxAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vfxAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VisualEffectAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vfxAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint activeBatchCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeBatchCount);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeBatchCount)) = value;
		}
	}

	public unsafe uint inactiveBatchCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inactiveBatchCount);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inactiveBatchCount)) = value;
		}
	}

	public unsafe uint activeInstanceCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInstanceCount);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInstanceCount)) = value;
		}
	}

	public unsafe uint unbatchedInstanceCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unbatchedInstanceCount);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unbatchedInstanceCount)) = value;
		}
	}

	public unsafe uint totalInstanceCapacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalInstanceCapacity);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalInstanceCapacity)) = value;
		}
	}

	public unsafe uint maxInstancePerBatchCapacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxInstancePerBatchCapacity);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxInstancePerBatchCapacity)) = value;
		}
	}

	public unsafe ulong totalGPUSizeInBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalGPUSizeInBytes);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalGPUSizeInBytes)) = value;
		}
	}

	public unsafe ulong totalCPUSizeInBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCPUSizeInBytes);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCPUSizeInBytes)) = value;
		}
	}

	static VFXBatchedEffectInfo()
	{
		Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXBatchedEffectInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr);
		NativeFieldInfoPtr_vfxAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "vfxAsset");
		NativeFieldInfoPtr_activeBatchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "activeBatchCount");
		NativeFieldInfoPtr_inactiveBatchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "inactiveBatchCount");
		NativeFieldInfoPtr_activeInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "activeInstanceCount");
		NativeFieldInfoPtr_unbatchedInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "unbatchedInstanceCount");
		NativeFieldInfoPtr_totalInstanceCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "totalInstanceCapacity");
		NativeFieldInfoPtr_maxInstancePerBatchCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "maxInstancePerBatchCapacity");
		NativeFieldInfoPtr_totalGPUSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "totalGPUSizeInBytes");
		NativeFieldInfoPtr_totalCPUSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr, "totalCPUSizeInBytes");
	}

	public VFXBatchedEffectInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public VFXBatchedEffectInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXBatchedEffectInfo>.NativeClassPtr))
	{
	}
}
