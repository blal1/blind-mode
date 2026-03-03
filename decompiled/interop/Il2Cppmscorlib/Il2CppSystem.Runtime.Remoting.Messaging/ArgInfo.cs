using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

public class ArgInfo : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__paramMap;

	private static readonly System.IntPtr NativeFieldInfoPtr__inoutArgCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__method;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;

	public unsafe Il2CppStructArray<int> _paramMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__paramMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__paramMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _inoutArgCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inoutArgCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inoutArgCount)) = value;
		}
	}

	public unsafe MethodBase _method
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__method);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__method)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ArgInfo()
	{
		Il2CppClassPointerStore<ArgInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ArgInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr);
		NativeFieldInfoPtr__paramMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_paramMap");
		NativeFieldInfoPtr__inoutArgCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_inoutArgCount");
		NativeFieldInfoPtr__method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, "_method");
		NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100670274);
		NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr, 100670275);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795285, RefRangeEnd = 795287, XrefRangeStart = 795274, XrefRangeEnd = 795285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArgInfo(MethodBase method, ArgInfoType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method);
		*(ArgInfoType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_MethodBase_ArgInfoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 795292, RefRangeEnd = 795294, XrefRangeStart = 795287, XrefRangeEnd = 795292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Object> GetInOutArgs(Il2CppReferenceArray<Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInOutArgs_Public_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	public ArgInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
