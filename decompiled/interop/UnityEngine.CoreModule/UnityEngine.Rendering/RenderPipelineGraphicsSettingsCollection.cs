using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

[System.Serializable]
public class RenderPipelineGraphicsSettingsCollection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_List;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsList_Public_get_List_1_IRenderPipelineGraphicsSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<IRenderPipelineGraphicsSettings> m_List
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_List);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IRenderPipelineGraphicsSettings>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_List)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<IRenderPipelineGraphicsSettings> settingsList
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settingsList_Public_get_List_1_IRenderPipelineGraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IRenderPipelineGraphicsSettings>>(intPtr2) : null;
		}
	}

	static RenderPipelineGraphicsSettingsCollection()
	{
		Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineGraphicsSettingsCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr);
		NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr, "m_List");
		NativeMethodInfoPtr_get_settingsList_Public_get_List_1_IRenderPipelineGraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr, 100668275);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr, 100668276);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237070, RefRangeEnd = 1237071, XrefRangeStart = 1237062, XrefRangeEnd = 1237070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderPipelineGraphicsSettingsCollection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderPipelineGraphicsSettingsCollection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
