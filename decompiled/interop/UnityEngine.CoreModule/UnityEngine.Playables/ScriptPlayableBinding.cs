using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Playables;

public static class ScriptPlayableBinding : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;

	static ScriptPlayableBinding()
	{
		Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100667594);
		NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100667595);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1231121, RefRangeEnd = 1231123, XrefRangeStart = 1231106, XrefRangeEnd = 1231121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableBinding Create(string name, Object key, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PlayableBinding(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231123, XrefRangeEnd = 1231133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ScriptPlayableBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
