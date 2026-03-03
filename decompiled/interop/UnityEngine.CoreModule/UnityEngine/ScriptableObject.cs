using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ScriptableObject : Object
{
	private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate void SetDirty_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr CreateScriptableObjectInstanceFromName_InjectedDelegate(System.IntPtr className);

	private delegate void ResetAndApplyDefaultInstances_InjectedDelegate(System.IntPtr obj);

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Injected_Private_Static_IntPtr_Type_Boolean_0;

	private static readonly SetDirty_InjectedDelegate SetDirty_InjectedDelegateField;

	private static readonly CreateScriptableObjectInstanceFromName_InjectedDelegate CreateScriptableObjectInstanceFromName_InjectedDelegateField;

	private static readonly ResetAndApplyDefaultInstances_InjectedDelegate ResetAndApplyDefaultInstances_InjectedDelegateField;

	static ScriptableObject()
	{
		Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptableObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666460);
		NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666461);
		NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666462);
		NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666463);
		NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666464);
		NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Injected_Private_Static_IntPtr_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666465);
		SetDirty_InjectedDelegateField = IL2CPP.ResolveICall<SetDirty_InjectedDelegate>("UnityEngine.ScriptableObject::SetDirty_Injected");
		CreateScriptableObjectInstanceFromName_InjectedDelegateField = IL2CPP.ResolveICall<CreateScriptableObjectInstanceFromName_InjectedDelegate>("UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromName_Injected");
		ResetAndApplyDefaultInstances_InjectedDelegateField = IL2CPP.ResolveICall<ResetAndApplyDefaultInstances_InjectedDelegate>("UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances_Injected");
	}

	[CallerCount(168)]
	[CachedScanResults(RefRangeStart = 1203841, RefRangeEnd = 1204009, XrefRangeStart = 1203835, XrefRangeEnd = 1203841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScriptableObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1204014, RefRangeEnd = 1204023, XrefRangeStart = 1204009, XrefRangeEnd = 1204014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptableObject CreateInstance(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1204029, RefRangeEnd = 1204053, XrefRangeStart = 1204023, XrefRangeEnd = 1204029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T CreateInstance<T>() where T : ScriptableObject
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204053, XrefRangeEnd = 1204055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateScriptableObject(ScriptableObject self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204055, XrefRangeEnd = 1204060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptableObject CreateScriptableObjectInstanceFromType(Il2CppSystem.Type type, bool applyDefaultsAndReset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyDefaultsAndReset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204060, XrefRangeEnd = 1204062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateScriptableObjectInstanceFromType_Injected(Il2CppSystem.Type type, bool applyDefaultsAndReset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyDefaultsAndReset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Injected_Private_Static_IntPtr_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ScriptableObject(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetDirty()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDirty_Injected(intPtr);
	}

	public static ScriptableObject CreateInstance(string className)
	{
		return CreateScriptableObjectInstanceFromName(className);
	}

	public static ScriptableObject CreateInstance(Il2CppSystem.Type type, Il2CppSystem.Action<ScriptableObject> initialize)
	{
		if (!Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ScriptableObject>()).IsAssignableFrom(type))
		{
			throw new Il2CppSystem.ArgumentException("Type must inherit ScriptableObject.", "type");
		}
		ScriptableObject scriptableObject = CreateScriptableObjectInstanceFromType(type, applyDefaultsAndReset: false);
		try
		{
			initialize.Invoke(scriptableObject);
		}
		finally
		{
			ResetAndApplyDefaultInstances(scriptableObject);
		}
		return scriptableObject;
	}

	public unsafe static ScriptableObject CreateScriptableObjectInstanceFromName(string className)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr gcHandlePtr);
		ScriptableObject result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(className, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(className);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					gcHandlePtr = CreateScriptableObjectInstanceFromName_Injected(ref managedSpanWrapper);
				}
			}
			else
			{
				gcHandlePtr = CreateScriptableObjectInstanceFromName_Injected(ref managedSpanWrapper);
			}
		}
		finally
		{
			result = Unmarshal.UnmarshalUnityObject<ScriptableObject>(gcHandlePtr);
		}
		return result;
	}

	public static void ResetAndApplyDefaultInstances(Object obj)
	{
		if ((object)obj == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(obj);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		ResetAndApplyDefaultInstances_Injected(intPtr);
	}

	public static void SetDirty_Injected(System.IntPtr _unity_self)
	{
		SetDirty_InjectedDelegateField(_unity_self);
	}

	public unsafe static System.IntPtr CreateScriptableObjectInstanceFromName_Injected(ref ManagedSpanWrapper className)
	{
		return CreateScriptableObjectInstanceFromName_InjectedDelegateField((nint)Unsafe.AsPointer(ref className));
	}

	public static void ResetAndApplyDefaultInstances_Injected(System.IntPtr obj)
	{
		ResetAndApplyDefaultInstances_InjectedDelegateField(obj);
	}
}
