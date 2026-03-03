using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public sealed class Activator : Object
{
	private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<Activator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Internal_Static_Object_Type_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

	static Activator()
	{
		Il2CppClassPointerStore<Activator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Activator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Activator>.NativeClassPtr);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666607);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666608);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666609);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666610);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666611);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666612);
		NativeMethodInfoPtr_CreateInstance_Internal_Static_Object_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666613);
		NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666614);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753611, RefRangeEnd = 753613, XrefRangeStart = 753610, XrefRangeEnd = 753611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(BindingFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingAttr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 753619, RefRangeEnd = 753622, XrefRangeStart = 753613, XrefRangeEnd = 753619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture, Il2CppReferenceArray<Object> activationAttributes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(BindingFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingAttr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activationAttributes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 753623, RefRangeEnd = 753627, XrefRangeStart = 753622, XrefRangeEnd = 753623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateInstance(Type type, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753628, RefRangeEnd = 753629, XrefRangeStart = 753627, XrefRangeEnd = 753628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateInstance(Type type, Il2CppReferenceArray<Object> args, Il2CppReferenceArray<Object> activationAttributes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activationAttributes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 753630, RefRangeEnd = 753644, XrefRangeStart = 753629, XrefRangeEnd = 753630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateInstance(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 753645, RefRangeEnd = 753652, XrefRangeStart = 753644, XrefRangeEnd = 753645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateInstance(Type type, bool nonPublic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nonPublic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 753658, RefRangeEnd = 753661, XrefRangeStart = 753652, XrefRangeEnd = 753658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateInstance(Type type, bool nonPublic, bool wrapExceptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nonPublic;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapExceptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Internal_Static_Object_Type_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 753671, RefRangeEnd = 753675, XrefRangeStart = 753661, XrefRangeEnd = 753671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T CreateInstance<T>()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	public static Object CreateInstance(Type type, params Object[] args)
	{
		return CreateInstance(type, new Il2CppReferenceArray<Object>(args));
	}

	public Activator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
