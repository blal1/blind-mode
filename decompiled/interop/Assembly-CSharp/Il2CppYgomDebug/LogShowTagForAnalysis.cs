using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppYgomSystem.ElementSystem;

namespace Il2CppYgomDebug;

public class LogShowTagForAnalysis : LogItemBaseForAnalysis
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Label_TagName;

	private static readonly IntPtr NativeFieldInfoPtr_m_EOManager_Origin;

	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShowTagTypeForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTargetTag_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCostTag_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string m_Label_TagName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_TagName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_TagName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ElementObjectManager m_EOManager_Origin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EOManager_Origin);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EOManager_Origin)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ElementObjectManager m_EOManager
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 53772, RefRangeEnd = 53777, XrefRangeStart = 53764, XrefRangeEnd = 53772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr2) : null;
		}
	}

	static LogShowTagForAnalysis()
	{
		Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogShowTagForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_m_Label_TagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr, "m_Label_TagName");
		NativeFieldInfoPtr_m_EOManager_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr, "m_EOManager_Origin");
		NativeMethodInfoPtr_SetData_Public_Void_ShowTagTypeForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr, 100665316);
		NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr, 100665317);
		NativeMethodInfoPtr_SetTargetTag_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr, 100665318);
		NativeMethodInfoPtr_SetCostTag_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr, 100665319);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr, 100665320);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53745, XrefRangeEnd = 53764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(ShowTagTypeForAnalysis type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_ShowTagTypeForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53777, XrefRangeEnd = 53788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTargetTag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTargetTag_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53788, XrefRangeEnd = 53799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCostTag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCostTag_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogShowTagForAnalysis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogShowTagForAnalysis>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LogShowTagForAnalysis(IntPtr pointer)
		: base(pointer)
	{
	}
}
