using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct TexturePlayableOutput
{
	private delegate System.IntPtr InternalGetTarget_InjectedDelegate(System.IntPtr output);

	private delegate void InternalSetTarget_InjectedDelegate(System.IntPtr output, System.IntPtr target);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

	[FieldOffset(0)]
	public PlayableOutputHandle m_Handle;

	private static readonly InternalGetTarget_InjectedDelegate InternalGetTarget_InjectedDelegateField;

	private static readonly InternalSetTarget_InjectedDelegate InternalSetTarget_InjectedDelegateField;

	public static TexturePlayableOutput Null => new TexturePlayableOutput(PlayableOutputHandle.Null);

	static TexturePlayableOutput()
	{
		Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TexturePlayableOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, 100668937);
		InternalGetTarget_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetTarget_InjectedDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalGetTarget_Injected");
		InternalSetTarget_InjectedDelegateField = IL2CPP.ResolveICall<InternalSetTarget_InjectedDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalSetTarget_Injected");
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

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static TexturePlayableOutput Create(PlayableGraph graph, string name, RenderTexture target)
	{
		if (!TexturePlayableGraphExtensions.InternalCreateTextureOutput(ref graph, name, out var handle))
		{
			return Null;
		}
		TexturePlayableOutput result = new TexturePlayableOutput(handle);
		result.SetTarget(target);
		return result;
	}

	public static implicit operator PlayableOutput(TexturePlayableOutput output)
	{
		return new PlayableOutput(output.GetHandle());
	}

	public static explicit operator TexturePlayableOutput(PlayableOutput output)
	{
		return new TexturePlayableOutput(output.GetHandle());
	}

	public RenderTexture GetTarget()
	{
		return InternalGetTarget(ref m_Handle);
	}

	public void SetTarget(RenderTexture value)
	{
		InternalSetTarget(ref m_Handle, value);
	}

	public static RenderTexture InternalGetTarget(ref PlayableOutputHandle output)
	{
		return Unmarshal.UnmarshalUnityObject<RenderTexture>(InternalGetTarget_Injected(ref output));
	}

	public static void InternalSetTarget(ref PlayableOutputHandle output, RenderTexture target)
	{
		InternalSetTarget_Injected(ref output, Object.MarshalledUnityObject.Marshal(target));
	}

	public unsafe static System.IntPtr InternalGetTarget_Injected(ref PlayableOutputHandle output)
	{
		return InternalGetTarget_InjectedDelegateField((nint)Unsafe.AsPointer(ref output));
	}

	public unsafe static void InternalSetTarget_Injected(ref PlayableOutputHandle output, System.IntPtr target)
	{
		InternalSetTarget_InjectedDelegateField((nint)Unsafe.AsPointer(ref output), target);
	}
}
