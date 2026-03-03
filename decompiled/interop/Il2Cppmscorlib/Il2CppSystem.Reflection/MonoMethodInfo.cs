using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Reflection;

public sealed class MonoMethodInfo : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_parent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ret;

	private static readonly System.IntPtr NativeFieldInfoPtr_attrs;

	private static readonly System.IntPtr NativeFieldInfoPtr_iattrs;

	private static readonly System.IntPtr NativeFieldInfoPtr_callconv;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_retval_marshal_Private_Static_MarshalAsAttribute_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReturnParameterInfo_Internal_Static_ParameterInfo_RuntimeMethodInfo_0;

	public unsafe Type parent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Type ret
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ret);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ret)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MethodAttributes attrs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attrs);
			return *(MethodAttributes*)num;
		}
		set
		{
			*(MethodAttributes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attrs)) = value;
		}
	}

	public unsafe MethodImplAttributes iattrs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iattrs);
			return *(MethodImplAttributes*)num;
		}
		set
		{
			*(MethodImplAttributes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iattrs)) = value;
		}
	}

	public unsafe CallingConventions callconv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callconv);
			return *(CallingConventions*)num;
		}
		set
		{
			*(CallingConventions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callconv)) = value;
		}
	}

	static MonoMethodInfo()
	{
		Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoMethodInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr);
		NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "parent");
		NativeFieldInfoPtr_ret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "ret");
		NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "attrs");
		NativeFieldInfoPtr_iattrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "iattrs");
		NativeFieldInfoPtr_callconv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "callconv");
		NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672242);
		NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672243);
		NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672244);
		NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672245);
		NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672246);
		NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672247);
		NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672248);
		NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672249);
		NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672250);
		NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672251);
		NativeMethodInfoPtr_get_retval_marshal_Private_Static_MarshalAsAttribute_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672252);
		NativeMethodInfoPtr_GetReturnParameterInfo_Internal_Static_ParameterInfo_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672253);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811033, XrefRangeEnd = 811034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_method_info(System.IntPtr handle, out MonoMethodInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		info = ((num3 == 0) ? null : new MonoMethodInfo(num3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811035, RefRangeEnd = 811036, XrefRangeStart = 811034, XrefRangeEnd = 811035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_method_attributes(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811036, XrefRangeEnd = 811037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoMethodInfo GetMethodInfo(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new MonoMethodInfo(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811038, RefRangeEnd = 811039, XrefRangeStart = 811037, XrefRangeEnd = 811038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type GetDeclaringType(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811039, XrefRangeEnd = 811040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type GetReturnType(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811035, RefRangeEnd = 811036, XrefRangeStart = 811035, XrefRangeEnd = 811036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MethodAttributes GetAttributes(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MethodAttributes*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811041, RefRangeEnd = 811042, XrefRangeStart = 811040, XrefRangeEnd = 811041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CallingConventions GetCallingConvention(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CallingConventions*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 811043, RefRangeEnd = 811044, XrefRangeStart = 811042, XrefRangeEnd = 811043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MethodImplAttributes GetMethodImplementationFlags(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MethodImplAttributes*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 811045, RefRangeEnd = 811049, XrefRangeStart = 811044, XrefRangeEnd = 811045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<ParameterInfo> get_parameter_info(System.IntPtr handle, MemberInfo member)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 811045, RefRangeEnd = 811049, XrefRangeStart = 811045, XrefRangeEnd = 811049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<ParameterInfo> GetParametersInfo(System.IntPtr handle, MemberInfo member)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MarshalAsAttribute get_retval_marshal(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_retval_marshal_Private_Static_MarshalAsAttribute_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811049, XrefRangeEnd = 811052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReturnParameterInfo_Internal_Static_ParameterInfo_RuntimeMethodInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParameterInfo>(intPtr2) : null;
	}

	public MonoMethodInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MonoMethodInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr))
	{
	}
}
