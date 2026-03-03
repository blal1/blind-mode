using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class TestAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_param;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTestAnalytic_Public_Static_TestAnalytic_0;

	public unsafe int param
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param)) = value;
		}
	}

	static TestAnalytic()
	{
		Il2CppClassPointerStore<TestAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "TestAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestAnalytic>.NativeClassPtr, "param");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestAnalytic>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_CreateTestAnalytic_Public_Static_TestAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestAnalytic>.NativeClassPtr, 100663359);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407952, XrefRangeEnd = 1407957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TestAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407957, XrefRangeEnd = 1407965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TestAnalytic CreateTestAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTestAnalytic_Public_Static_TestAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TestAnalytic>(intPtr2) : null;
	}

	public TestAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
