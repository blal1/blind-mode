using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public class IVolumeDebugSettings2 : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Abstract_Virtual_New_get_List_1_ValueTuple_2_String_Type_0;

	public unsafe virtual Il2CppSystem.Type targetRenderPipeline
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
	}

	public unsafe virtual List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Type>> volumeComponentsPathAndType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Abstract_Virtual_New_get_List_1_ValueTuple_2_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Type>>>(intPtr2) : null;
		}
	}

	static IVolumeDebugSettings2()
	{
		Il2CppClassPointerStore<IVolumeDebugSettings2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IVolumeDebugSettings2");
		NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings2>.NativeClassPtr, 100665078);
		NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Abstract_Virtual_New_get_List_1_ValueTuple_2_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings2>.NativeClassPtr, 100665079);
	}

	public IVolumeDebugSettings2(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
