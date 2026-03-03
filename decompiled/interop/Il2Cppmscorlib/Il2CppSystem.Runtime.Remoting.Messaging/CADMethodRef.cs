using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging;

[System.Serializable]
public class CADMethodRef : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ctor;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_methodName;

	private static readonly System.IntPtr NativeFieldInfoPtr_param_names;

	private static readonly System.IntPtr NativeFieldInfoPtr_generic_arg_names;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_MethodBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

	public unsafe bool ctor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctor)) = value;
		}
	}

	public unsafe string typeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string methodName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStringArray param_names
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param_names);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param_names)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray generic_arg_names
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generic_arg_names);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generic_arg_names)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CADMethodRef()
	{
		Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodRef");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr);
		NativeFieldInfoPtr_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "ctor");
		NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "typeName");
		NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "methodName");
		NativeFieldInfoPtr_param_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "param_names");
		NativeFieldInfoPtr_generic_arg_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "generic_arg_names");
		NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100670298);
		NativeMethodInfoPtr_Resolve_Public_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100670299);
		NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100670300);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 795341, RefRangeEnd = 795344, XrefRangeStart = 795328, XrefRangeEnd = 795341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Type> GetTypes(Il2CppStringArray typeArray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795369, RefRangeEnd = 795370, XrefRangeStart = 795344, XrefRangeEnd = 795369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MethodBase Resolve()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resolve_Public_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 795388, RefRangeEnd = 795389, XrefRangeStart = 795370, XrefRangeEnd = 795388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CADMethodRef(IMethodMessage msg)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CADMethodRef(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
