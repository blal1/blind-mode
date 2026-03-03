using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering;

public static class RenderPipelineGraphicsSettingsExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0, Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0;

	static RenderPipelineGraphicsSettingsExtensions()
	{
		Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineGraphicsSettingsExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr, 100668277);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 1237080, RefRangeEnd = 1237129, XrefRangeStart = 1237071, XrefRangeEnd = 1237080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetValueAndNotify<T>(this IRenderPipelineGraphicsSettings settings, ref T currentPropertyValue, T newValue, string propertyName = null)
	{
		//IL_006e->IL0071: Incompatible stack types: I vs Ref
		//IL_0061->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref currentPropertyValue));
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = newValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref newValue;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref currentPropertyValue) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	public RenderPipelineGraphicsSettingsExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void NotifyValueChanged(IRenderPipelineGraphicsSettings settings, [Optional] string propertyName)
	{
		throw new Il2CppSystem.Exception("Notifying change of a property in standalone builds is forbidden.");
	}
}
