using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection;

public static class SignatureTypeExtensions : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesParameterTypeExactly_Public_Static_Boolean_Type_ParameterInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesExactly_Internal_Static_Boolean_SignatureType_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryResolveAgainstGenericMethod_Internal_Static_Type_SignatureType_MethodInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryResolve_Private_Static_Type_SignatureType_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMakeByRefType_Private_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMakePointerType_Private_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0;

	static SignatureTypeExtensions()
	{
		Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "SignatureTypeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_MatchesParameterTypeExactly_Public_Static_Boolean_Type_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672010);
		NativeMethodInfoPtr_MatchesExactly_Internal_Static_Boolean_SignatureType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672011);
		NativeMethodInfoPtr_TryResolveAgainstGenericMethod_Internal_Static_Type_SignatureType_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672012);
		NativeMethodInfoPtr_TryResolve_Private_Static_Type_SignatureType_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672013);
		NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672014);
		NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672015);
		NativeMethodInfoPtr_TryMakeByRefType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672016);
		NativeMethodInfoPtr_TryMakePointerType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672017);
		NativeMethodInfoPtr_TryMakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureTypeExtensions>.NativeClassPtr, 100672018);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 809457, RefRangeEnd = 809459, XrefRangeStart = 809454, XrefRangeEnd = 809457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchesParameterTypeExactly(this Type pattern, ParameterInfo parameter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesParameterTypeExactly_Public_Static_Boolean_Type_ParameterInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 809474, RefRangeEnd = 809476, XrefRangeStart = 809459, XrefRangeEnd = 809474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchesExactly(this SignatureType pattern, Type actual)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actual);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesExactly_Internal_Static_Boolean_SignatureType_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 809478, RefRangeEnd = 809479, XrefRangeStart = 809476, XrefRangeEnd = 809478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)signatureType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genericMethod);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryResolveAgainstGenericMethod_Internal_Static_Type_SignatureType_MethodInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 809483, RefRangeEnd = 809484, XrefRangeStart = 809479, XrefRangeEnd = 809483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type TryResolve(this SignatureType signatureType, Il2CppReferenceArray<Type> genericMethodParameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)signatureType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genericMethodParameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryResolve_Private_Static_Type_SignatureType_Il2CppReferenceArray_1_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 809484, XrefRangeEnd = 809485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type TryMakeArrayType(this Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 809485, XrefRangeEnd = 809486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type TryMakeArrayType(this Type type, int rank)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rank;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMakeArrayType_Private_Static_Type_Type_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 809486, XrefRangeEnd = 809487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type TryMakeByRefType(this Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMakeByRefType_Private_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 809487, XrefRangeEnd = 809488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type TryMakePointerType(this Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMakePointerType_Private_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 809488, XrefRangeEnd = 809489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type TryMakeGenericType(this Type type, Il2CppReferenceArray<Type> instantiation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instantiation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	public SignatureTypeExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
