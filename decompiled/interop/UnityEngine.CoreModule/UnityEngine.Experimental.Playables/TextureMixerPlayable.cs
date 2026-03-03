using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct TextureMixerPlayable
{
	private delegate bool CreateTextureMixerPlayableInternalDelegate(System.IntPtr graph, System.IntPtr handle);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	private static readonly CreateTextureMixerPlayableInternalDelegate CreateTextureMixerPlayableInternalDelegateField;

	static TextureMixerPlayable()
	{
		Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TextureMixerPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100668935);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100668936);
		CreateTextureMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<CreateTextureMixerPlayableInternalDelegate>("UnityEngine.Experimental.Playables.TextureMixerPlayable::CreateTextureMixerPlayableInternal");
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241062, XrefRangeEnd = 1241066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(TextureMixerPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static TextureMixerPlayable Create(PlayableGraph graph)
	{
		PlayableHandle playableHandle = CreateHandle(graph);
		return new TextureMixerPlayable(playableHandle);
	}

	public static PlayableHandle CreateHandle(PlayableGraph graph)
	{
		PlayableHandle handle = PlayableHandle.Null;
		if (!CreateTextureMixerPlayableInternal(ref graph, ref handle))
		{
			return PlayableHandle.Null;
		}
		return handle;
	}

	public static implicit operator Playable(TextureMixerPlayable playable)
	{
		return new Playable(playable.GetHandle());
	}

	public static explicit operator TextureMixerPlayable(Playable playable)
	{
		return new TextureMixerPlayable(playable.GetHandle());
	}

	public unsafe static bool CreateTextureMixerPlayableInternal(ref PlayableGraph graph, ref PlayableHandle handle)
	{
		return CreateTextureMixerPlayableInternalDelegateField((nint)Unsafe.AsPointer(ref graph), (nint)Unsafe.AsPointer(ref handle));
	}
}
