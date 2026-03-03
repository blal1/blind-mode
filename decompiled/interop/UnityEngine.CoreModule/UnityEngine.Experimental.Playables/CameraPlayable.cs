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
public struct CameraPlayable
{
	private delegate bool ValidateTypeDelegate(System.IntPtr hdl);

	private delegate System.IntPtr GetCameraInternal_InjectedDelegate(System.IntPtr hdl);

	private delegate void SetCameraInternal_InjectedDelegate(System.IntPtr hdl, System.IntPtr camera);

	private delegate bool InternalCreateCameraPlayable_InjectedDelegate(System.IntPtr graph, System.IntPtr camera, System.IntPtr handle);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	private static readonly ValidateTypeDelegate ValidateTypeDelegateField;

	private static readonly GetCameraInternal_InjectedDelegate GetCameraInternal_InjectedDelegateField;

	private static readonly SetCameraInternal_InjectedDelegate SetCameraInternal_InjectedDelegateField;

	private static readonly InternalCreateCameraPlayable_InjectedDelegate InternalCreateCameraPlayable_InjectedDelegateField;

	static CameraPlayable()
	{
		Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "CameraPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100668931);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100668932);
		ValidateTypeDelegateField = IL2CPP.ResolveICall<ValidateTypeDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::ValidateType");
		GetCameraInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetCameraInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::GetCameraInternal_Injected");
		SetCameraInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetCameraInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::SetCameraInternal_Injected");
		InternalCreateCameraPlayable_InjectedDelegateField = IL2CPP.ResolveICall<InternalCreateCameraPlayable_InjectedDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::InternalCreateCameraPlayable_Injected");
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241054, XrefRangeEnd = 1241058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(CameraPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static CameraPlayable Create(PlayableGraph graph, Camera camera)
	{
		PlayableHandle playableHandle = CreateHandle(graph, camera);
		return new CameraPlayable(playableHandle);
	}

	public static PlayableHandle CreateHandle(PlayableGraph graph, Camera camera)
	{
		PlayableHandle handle = PlayableHandle.Null;
		if (!InternalCreateCameraPlayable(ref graph, camera, ref handle))
		{
			return PlayableHandle.Null;
		}
		return handle;
	}

	public static implicit operator Playable(CameraPlayable playable)
	{
		return new Playable(playable.GetHandle());
	}

	public static explicit operator CameraPlayable(Playable playable)
	{
		return new CameraPlayable(playable.GetHandle());
	}

	public Camera GetCamera()
	{
		return GetCameraInternal(ref m_Handle);
	}

	public void SetCamera(Camera value)
	{
		SetCameraInternal(ref m_Handle, value);
	}

	public static Camera GetCameraInternal(ref PlayableHandle hdl)
	{
		return Unmarshal.UnmarshalUnityObject<Camera>(GetCameraInternal_Injected(ref hdl));
	}

	public static void SetCameraInternal(ref PlayableHandle hdl, Camera camera)
	{
		SetCameraInternal_Injected(ref hdl, Object.MarshalledUnityObject.Marshal(camera));
	}

	public static bool InternalCreateCameraPlayable(ref PlayableGraph graph, Camera camera, ref PlayableHandle handle)
	{
		return InternalCreateCameraPlayable_Injected(ref graph, Object.MarshalledUnityObject.Marshal(camera), ref handle);
	}

	public unsafe static bool ValidateType(ref PlayableHandle hdl)
	{
		return ValidateTypeDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static System.IntPtr GetCameraInternal_Injected(ref PlayableHandle hdl)
	{
		return GetCameraInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static void SetCameraInternal_Injected(ref PlayableHandle hdl, System.IntPtr camera)
	{
		SetCameraInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref hdl), camera);
	}

	public unsafe static bool InternalCreateCameraPlayable_Injected(ref PlayableGraph graph, System.IntPtr camera, ref PlayableHandle handle)
	{
		return InternalCreateCameraPlayable_InjectedDelegateField((nint)Unsafe.AsPointer(ref graph), camera, (nint)Unsafe.AsPointer(ref handle));
	}
}
