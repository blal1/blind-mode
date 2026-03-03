using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppYgomGame.Duel;

namespace Il2CppYgomDebug;

[System.Serializable]
public sealed class LogBaseDataForAnalysis : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_loglabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataindex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogBaseData_0;

	public unsafe string loglabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loglabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loglabel)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int dataindex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataindex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataindex)) = value;
		}
	}

	static LogBaseDataForAnalysis()
	{
		Il2CppClassPointerStore<LogBaseDataForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogBaseDataForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogBaseDataForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_loglabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogBaseDataForAnalysis>.NativeClassPtr, "loglabel");
		NativeFieldInfoPtr_dataindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogBaseDataForAnalysis>.NativeClassPtr, "dataindex");
		NativeMethodInfoPtr__ctor_Public_Void_LogBaseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogBaseDataForAnalysis>.NativeClassPtr, 100665223);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52375, XrefRangeEnd = 52376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogBaseDataForAnalysis(LogBaseData logBaseData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogBaseDataForAnalysis>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)logBaseData));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LogBaseData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LogBaseDataForAnalysis(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LogBaseDataForAnalysis()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogBaseDataForAnalysis>.NativeClassPtr))
	{
	}
}
