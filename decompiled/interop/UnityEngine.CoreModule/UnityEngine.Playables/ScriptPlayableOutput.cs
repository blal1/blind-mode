using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct ScriptPlayableOutput
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0;

	[FieldOffset(0)]
	public PlayableOutputHandle m_Handle;

	public unsafe static ScriptPlayableOutput Null
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231156, XrefRangeEnd = 1231164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ScriptPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ScriptPlayableOutput()
	{
		Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667596);
		NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667597);
		NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667598);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667599);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667600);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231133, XrefRangeEnd = 1231143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayableOutput Create(PlayableGraph graph, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ScriptPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1231153, RefRangeEnd = 1231156, XrefRangeStart = 1231143, XrefRangeEnd = 1231153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScriptPlayableOutput(PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableOutputHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutputHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PlayableOutput(ScriptPlayableOutput output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static explicit operator ScriptPlayableOutput(PlayableOutput output)
	{
		return new ScriptPlayableOutput(output.GetHandle());
	}
}
