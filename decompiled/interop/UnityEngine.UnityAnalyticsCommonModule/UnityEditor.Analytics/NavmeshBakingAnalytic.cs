using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class NavmeshBakingAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_new_nav_api;

	private static readonly IntPtr NativeFieldInfoPtr_bake_at_runtime;

	private static readonly IntPtr NativeFieldInfoPtr_height_meshes_count;

	private static readonly IntPtr NativeFieldInfoPtr_offmesh_links_count;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateNavmeshBakingAnalytic_Internal_Static_NavmeshBakingAnalytic_0;

	public unsafe bool new_nav_api
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_new_nav_api);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_new_nav_api)) = value;
		}
	}

	public unsafe bool bake_at_runtime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bake_at_runtime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bake_at_runtime)) = value;
		}
	}

	public unsafe int height_meshes_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height_meshes_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height_meshes_count)) = value;
		}
	}

	public unsafe int offmesh_links_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offmesh_links_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offmesh_links_count)) = value;
		}
	}

	static NavmeshBakingAnalytic()
	{
		Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "NavmeshBakingAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_new_nav_api = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr, "new_nav_api");
		NativeFieldInfoPtr_bake_at_runtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr, "bake_at_runtime");
		NativeFieldInfoPtr_height_meshes_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr, "height_meshes_count");
		NativeFieldInfoPtr_offmesh_links_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr, "offmesh_links_count");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_CreateNavmeshBakingAnalytic_Internal_Static_NavmeshBakingAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr, 100663326);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407741, XrefRangeEnd = 1407746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NavmeshBakingAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavmeshBakingAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407746, XrefRangeEnd = 1407754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNavmeshBakingAnalytic_Internal_Static_NavmeshBakingAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<NavmeshBakingAnalytic>(intPtr2) : null;
	}

	public NavmeshBakingAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
