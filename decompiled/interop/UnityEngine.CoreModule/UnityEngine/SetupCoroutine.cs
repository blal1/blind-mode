using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine;

public class SetupCoroutine : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0;

	static SetupCoroutine()
	{
		Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SetupCoroutine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr);
		NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100666284);
		NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100666285);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195841, XrefRangeEnd = 1195845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMoveNext(IEnumerator enumerator, System.IntPtr returnValueAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumerator);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnValueAddress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195845, XrefRangeEnd = 1195851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object InvokeMember(Il2CppSystem.Object behaviour, string name, Il2CppSystem.Object variable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)behaviour);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)variable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	public SetupCoroutine(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Il2CppSystem.Object InvokeStatic(Il2CppSystem.Type klass, string name, Il2CppSystem.Object variable)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
