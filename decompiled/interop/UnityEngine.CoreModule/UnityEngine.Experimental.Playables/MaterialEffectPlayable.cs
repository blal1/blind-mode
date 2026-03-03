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
public struct MaterialEffectPlayable
{
	private delegate int GetPassInternalDelegate(System.IntPtr hdl);

	private delegate void SetPassInternalDelegate(System.IntPtr hdl, int pass);

	private delegate bool ValidateTypeDelegate(System.IntPtr hdl);

	private delegate System.IntPtr GetMaterialInternal_InjectedDelegate(System.IntPtr hdl);

	private delegate void SetMaterialInternal_InjectedDelegate(System.IntPtr hdl, System.IntPtr material);

	private delegate bool InternalCreateMaterialEffectPlayable_InjectedDelegate(System.IntPtr graph, System.IntPtr material, int pass, System.IntPtr handle);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	private static readonly GetPassInternalDelegate GetPassInternalDelegateField;

	private static readonly SetPassInternalDelegate SetPassInternalDelegateField;

	private static readonly ValidateTypeDelegate ValidateTypeDelegateField;

	private static readonly GetMaterialInternal_InjectedDelegate GetMaterialInternal_InjectedDelegateField;

	private static readonly SetMaterialInternal_InjectedDelegate SetMaterialInternal_InjectedDelegateField;

	private static readonly InternalCreateMaterialEffectPlayable_InjectedDelegate InternalCreateMaterialEffectPlayable_InjectedDelegateField;

	static MaterialEffectPlayable()
	{
		Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "MaterialEffectPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100668933);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100668934);
		GetPassInternalDelegateField = IL2CPP.ResolveICall<GetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetPassInternal");
		SetPassInternalDelegateField = IL2CPP.ResolveICall<SetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetPassInternal");
		ValidateTypeDelegateField = IL2CPP.ResolveICall<ValidateTypeDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::ValidateType");
		GetMaterialInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetMaterialInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetMaterialInternal_Injected");
		SetMaterialInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetMaterialInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetMaterialInternal_Injected");
		InternalCreateMaterialEffectPlayable_InjectedDelegateField = IL2CPP.ResolveICall<InternalCreateMaterialEffectPlayable_InjectedDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::InternalCreateMaterialEffectPlayable_Injected");
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241058, XrefRangeEnd = 1241062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(MaterialEffectPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static MaterialEffectPlayable Create(PlayableGraph graph, Material material, [Optional] int pass)
	{
		PlayableHandle playableHandle = CreateHandle(graph, material, pass);
		return new MaterialEffectPlayable(playableHandle);
	}

	public static PlayableHandle CreateHandle(PlayableGraph graph, Material material, int pass)
	{
		PlayableHandle handle = PlayableHandle.Null;
		if (!InternalCreateMaterialEffectPlayable(ref graph, material, pass, ref handle))
		{
			return PlayableHandle.Null;
		}
		return handle;
	}

	public static implicit operator Playable(MaterialEffectPlayable playable)
	{
		return new Playable(playable.GetHandle());
	}

	public static explicit operator MaterialEffectPlayable(Playable playable)
	{
		return new MaterialEffectPlayable(playable.GetHandle());
	}

	public Material GetMaterial()
	{
		return GetMaterialInternal(ref m_Handle);
	}

	public void SetMaterial(Material value)
	{
		SetMaterialInternal(ref m_Handle, value);
	}

	public int GetPass()
	{
		return GetPassInternal(ref m_Handle);
	}

	public void SetPass(int value)
	{
		SetPassInternal(ref m_Handle, value);
	}

	public static Material GetMaterialInternal(ref PlayableHandle hdl)
	{
		return Unmarshal.UnmarshalUnityObject<Material>(GetMaterialInternal_Injected(ref hdl));
	}

	public static void SetMaterialInternal(ref PlayableHandle hdl, Material material)
	{
		SetMaterialInternal_Injected(ref hdl, Object.MarshalledUnityObject.Marshal(material));
	}

	public unsafe static int GetPassInternal(ref PlayableHandle hdl)
	{
		return GetPassInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static void SetPassInternal(ref PlayableHandle hdl, int pass)
	{
		SetPassInternalDelegateField((nint)Unsafe.AsPointer(ref hdl), pass);
	}

	public static bool InternalCreateMaterialEffectPlayable(ref PlayableGraph graph, Material material, int pass, ref PlayableHandle handle)
	{
		return InternalCreateMaterialEffectPlayable_Injected(ref graph, Object.MarshalledUnityObject.Marshal(material), pass, ref handle);
	}

	public unsafe static bool ValidateType(ref PlayableHandle hdl)
	{
		return ValidateTypeDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static System.IntPtr GetMaterialInternal_Injected(ref PlayableHandle hdl)
	{
		return GetMaterialInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static void SetMaterialInternal_Injected(ref PlayableHandle hdl, System.IntPtr material)
	{
		SetMaterialInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref hdl), material);
	}

	public unsafe static bool InternalCreateMaterialEffectPlayable_Injected(ref PlayableGraph graph, System.IntPtr material, int pass, ref PlayableHandle handle)
	{
		return InternalCreateMaterialEffectPlayable_InjectedDelegateField((nint)Unsafe.AsPointer(ref graph), material, pass, (nint)Unsafe.AsPointer(ref handle));
	}
}
