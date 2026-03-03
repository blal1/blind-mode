using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine;

public class AttributeHelperEngine : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0, Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__disallowMultipleComponentArray;

	private static readonly System.IntPtr NativeFieldInfoPtr__executeInEditModeArray;

	private static readonly System.IntPtr NativeFieldInfoPtr__requireComponentArray;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0;

	public unsafe static Il2CppReferenceArray<DisallowMultipleComponent> _disallowMultipleComponentArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__disallowMultipleComponentArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DisallowMultipleComponent>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__disallowMultipleComponentArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<ExecuteInEditMode> _executeInEditModeArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__executeInEditModeArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExecuteInEditMode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__executeInEditModeArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<RequireComponent> _requireComponentArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__requireComponentArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RequireComponent>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__requireComponentArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AttributeHelperEngine()
	{
		Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AttributeHelperEngine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr);
		NativeFieldInfoPtr__disallowMultipleComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_disallowMultipleComponentArray");
		NativeFieldInfoPtr__executeInEditModeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_executeInEditModeArray");
		NativeFieldInfoPtr__requireComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, "_requireComponentArray");
		NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666162);
		NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666163);
		NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666164);
		NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666165);
		NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666166);
		NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100666167);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185896, XrefRangeEnd = 1185912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetParentTypeDisallowingMultipleInclusion(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185912, XrefRangeEnd = 1185971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> GetRequiredComponents(Il2CppSystem.Type klass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)klass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185971, XrefRangeEnd = 1185981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetExecuteMode(Il2CppSystem.Type klass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)klass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185981, XrefRangeEnd = 1186004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CheckIsEditorScript(Il2CppSystem.Type klass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)klass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186004, XrefRangeEnd = 1186010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDefaultExecutionOrderFor(Il2CppSystem.Type klass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)klass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1186017, RefRangeEnd = 1186018, XrefRangeStart = 1186010, XrefRangeEnd = 1186017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetCustomAttributeOfType<T>(Il2CppSystem.Type klass) where T : Il2CppSystem.Attribute
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)klass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	public AttributeHelperEngine(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
