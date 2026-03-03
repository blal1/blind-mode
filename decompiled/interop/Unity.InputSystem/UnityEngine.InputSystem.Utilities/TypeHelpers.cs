using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.InputSystem.Utilities;

public static class TypeHelpers : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_As_Public_Static_TObject_Object_0<TObject>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_As_Public_Static_TObject_Object_0, Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_As_Public_Static_TObject_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInt_Public_Static_Boolean_TypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueType_Public_Static_Type_MemberInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNiceTypeName_Public_Static_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericTypeArgumentFromHierarchy_Public_Static_Type_Type_Type_Int32_0;

	static TypeHelpers()
	{
		Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "TypeHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_As_Public_Static_TObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr, 100669092);
		NativeMethodInfoPtr_IsInt_Public_Static_Boolean_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr, 100669093);
		NativeMethodInfoPtr_GetValueType_Public_Static_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr, 100669094);
		NativeMethodInfoPtr_GetNiceTypeName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr, 100669095);
		NativeMethodInfoPtr_GetGenericTypeArgumentFromHierarchy_Public_Static_Type_Type_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHelpers>.NativeClassPtr, 100669096);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021929, XrefRangeEnd = 1021939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TObject As<TObject>(this Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_As_Public_Static_TObject_Object_0<TObject>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TObject>(intPtr2, false, true);
	}

	[CallerCount(0)]
	public unsafe static bool IsInt(this Il2CppSystem.TypeCode type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInt_Public_Static_Boolean_TypeCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1021952, RefRangeEnd = 1021955, XrefRangeStart = 1021939, XrefRangeEnd = 1021952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetValueType(MemberInfo member)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueType_Public_Static_Type_MemberInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021955, XrefRangeEnd = 1022023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNiceTypeName(this Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNiceTypeName_Public_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1022038, RefRangeEnd = 1022043, XrefRangeStart = 1022023, XrefRangeEnd = 1022038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetGenericTypeArgumentFromHierarchy(Il2CppSystem.Type type, Il2CppSystem.Type genericTypeDefinition, int argumentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genericTypeDefinition);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &argumentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericTypeArgumentFromHierarchy_Public_Static_Type_Type_Type_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	public TypeHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
