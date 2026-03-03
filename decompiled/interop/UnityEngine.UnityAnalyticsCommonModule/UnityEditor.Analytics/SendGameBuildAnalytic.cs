using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class SendGameBuildAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_navmesh_count;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateSendGameBuildAnalytic_Internal_Static_SendGameBuildAnalytic_0;

	public unsafe int navmesh_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navmesh_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navmesh_count)) = value;
		}
	}

	static SendGameBuildAnalytic()
	{
		Il2CppClassPointerStore<SendGameBuildAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "SendGameBuildAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendGameBuildAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_navmesh_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendGameBuildAnalytic>.NativeClassPtr, "navmesh_count");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendGameBuildAnalytic>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_CreateSendGameBuildAnalytic_Internal_Static_SendGameBuildAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendGameBuildAnalytic>.NativeClassPtr, 100663330);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407767, XrefRangeEnd = 1407772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SendGameBuildAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendGameBuildAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407772, XrefRangeEnd = 1407780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SendGameBuildAnalytic CreateSendGameBuildAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSendGameBuildAnalytic_Internal_Static_SendGameBuildAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SendGameBuildAnalytic>(intPtr2) : null;
	}

	public SendGameBuildAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
