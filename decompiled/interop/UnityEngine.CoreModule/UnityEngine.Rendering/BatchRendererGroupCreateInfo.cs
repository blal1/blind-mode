using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class BatchRendererGroupCreateInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cullingCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishedCullingCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_userContext;

	public unsafe BatchRendererGroup.OnPerformCulling cullingCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BatchRendererGroup.OnPerformCulling>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BatchRendererGroup.OnFinishedCulling finishedCullingCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishedCullingCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BatchRendererGroup.OnFinishedCulling>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishedCullingCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe System.IntPtr userContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userContext);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userContext)) = value;
		}
	}

	static BatchRendererGroupCreateInfo()
	{
		Il2CppClassPointerStore<BatchRendererGroupCreateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererGroupCreateInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroupCreateInfo>.NativeClassPtr);
		NativeFieldInfoPtr_cullingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupCreateInfo>.NativeClassPtr, "cullingCallback");
		NativeFieldInfoPtr_finishedCullingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupCreateInfo>.NativeClassPtr, "finishedCullingCallback");
		NativeFieldInfoPtr_userContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupCreateInfo>.NativeClassPtr, "userContext");
	}

	public BatchRendererGroupCreateInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BatchRendererGroupCreateInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroupCreateInfo>.NativeClassPtr))
	{
	}
}
