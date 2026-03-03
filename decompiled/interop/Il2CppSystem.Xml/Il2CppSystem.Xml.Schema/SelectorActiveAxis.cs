using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public class SelectorActiveAxis : ActiveAxis
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cs;

	private static readonly System.IntPtr NativeFieldInfoPtr_KSs;

	private static readonly System.IntPtr NativeFieldInfoPtr_KSpointer;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopKS_Public_KeySequence_0;

	public unsafe ConstraintStruct cs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstraintStruct>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ArrayList KSs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KSs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KSs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int KSpointer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KSpointer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KSpointer)) = value;
		}
	}

	public unsafe int lastDepth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921170, XrefRangeEnd = 921171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SelectorActiveAxis()
	{
		Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SelectorActiveAxis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr);
		NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "cs");
		NativeFieldInfoPtr_KSs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "KSs");
		NativeFieldInfoPtr_KSpointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "KSpointer");
		NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100665978);
		NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100665979);
		NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100665980);
		NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100665981);
		NativeMethodInfoPtr_PopKS_Public_KeySequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100665982);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921171, XrefRangeEnd = 921178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axisTree);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921178, XrefRangeEnd = 921186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool EndElement(string localname, string URN)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(URN);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 921211, RefRangeEnd = 921213, XrefRangeStart = 921186, XrefRangeEnd = 921211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int PushKS(int errline, int errcol)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&errline);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &errcol;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 921215, RefRangeEnd = 921217, XrefRangeStart = 921213, XrefRangeEnd = 921215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeySequence PopKS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopKS_Public_KeySequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeySequence>(intPtr2) : null;
	}

	public SelectorActiveAxis(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
