using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering;

public static class DocumentationUtils : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetHelpURL_Public_Static_String_TEnum_0<TEnum>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetHelpURL_Public_Static_String_TEnum_0, Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHelpURL_Public_Static_String_TEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHelpURL_Public_Static_Boolean_Type_byref_String_0;

	static DocumentationUtils()
	{
		Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DocumentationUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr);
		NativeMethodInfoPtr_GetHelpURL_Public_Static_String_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr, 100665263);
		NativeMethodInfoPtr_TryGetHelpURL_Public_Static_Boolean_Type_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr, 100665264);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037597, XrefRangeEnd = 1037618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetHelpURL<TEnum>(TEnum mask = default(TEnum)) where TEnum : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TEnum reference;
		if (!typeof(TEnum).IsValueType)
		{
			object obj = mask;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref mask;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetHelpURL_Public_Static_String_TEnum_0<TEnum>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037618, XrefRangeEnd = 1037622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetHelpURL(Il2CppSystem.Type type, out string url)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetHelpURL_Public_Static_Boolean_Type_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		url = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DocumentationUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
