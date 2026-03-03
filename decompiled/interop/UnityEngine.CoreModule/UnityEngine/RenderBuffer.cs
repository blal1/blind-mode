using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RenderBuffer
{
	private delegate void SetLoadActionDelegate(System.IntPtr @this, RenderBufferLoadAction action);

	private delegate void SetStoreActionDelegate(System.IntPtr @this, RenderBufferStoreAction action);

	private delegate RenderBufferLoadAction GetLoadActionDelegate(System.IntPtr @this);

	private delegate RenderBufferStoreAction GetStoreActionDelegate(System.IntPtr @this);

	private delegate System.IntPtr GetNativeRenderBufferPtrDelegate(System.IntPtr @this);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderTextureInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferPtr;

	[FieldOffset(0)]
	public int m_RenderTextureInstanceID;

	[FieldOffset(8)]
	public System.IntPtr m_BufferPtr;

	private static readonly SetLoadActionDelegate SetLoadActionDelegateField;

	private static readonly SetStoreActionDelegate SetStoreActionDelegateField;

	private static readonly GetLoadActionDelegate GetLoadActionDelegateField;

	private static readonly GetStoreActionDelegate GetStoreActionDelegateField;

	private static readonly GetNativeRenderBufferPtrDelegate GetNativeRenderBufferPtrDelegateField;

	public RenderBufferLoadAction loadAction
	{
		get
		{
			return GetLoadAction();
		}
		set
		{
			SetLoadAction(value);
		}
	}

	public RenderBufferStoreAction storeAction
	{
		get
		{
			return GetStoreAction();
		}
		set
		{
			SetStoreAction(value);
		}
	}

	static RenderBuffer()
	{
		Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderBuffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr);
		NativeFieldInfoPtr_m_RenderTextureInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_RenderTextureInstanceID");
		NativeFieldInfoPtr_m_BufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_BufferPtr");
		SetLoadActionDelegateField = IL2CPP.ResolveICall<SetLoadActionDelegate>("UnityEngine.RenderBuffer::SetLoadAction");
		SetStoreActionDelegateField = IL2CPP.ResolveICall<SetStoreActionDelegate>("UnityEngine.RenderBuffer::SetStoreAction");
		GetLoadActionDelegateField = IL2CPP.ResolveICall<GetLoadActionDelegate>("UnityEngine.RenderBuffer::GetLoadAction");
		GetStoreActionDelegateField = IL2CPP.ResolveICall<GetStoreActionDelegate>("UnityEngine.RenderBuffer::GetStoreAction");
		GetNativeRenderBufferPtrDelegateField = IL2CPP.ResolveICall<GetNativeRenderBufferPtrDelegate>("UnityEngine.RenderBuffer::GetNativeRenderBufferPtr");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe void SetLoadAction(RenderBufferLoadAction action)
	{
		//IL_000b: Expected O, but got Ref
		SetLoadActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), action);
	}

	public unsafe void SetStoreAction(RenderBufferStoreAction action)
	{
		//IL_000b: Expected O, but got Ref
		SetStoreActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), action);
	}

	public unsafe RenderBufferLoadAction GetLoadAction()
	{
		//IL_000b: Expected O, but got Ref
		return GetLoadActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe RenderBufferStoreAction GetStoreAction()
	{
		//IL_000b: Expected O, but got Ref
		return GetStoreActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe System.IntPtr GetNativeRenderBufferPtr()
	{
		//IL_000b: Expected O, but got Ref
		return GetNativeRenderBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}
}
