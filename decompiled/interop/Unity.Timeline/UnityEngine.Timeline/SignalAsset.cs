using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public class SignalAsset : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OnEnableCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnEnableCallback_Internal_Static_add_Void_Action_1_SignalAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnEnableCallback_Internal_Static_rem_Void_Action_1_SignalAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppSystem.Action<SignalAsset> OnEnableCallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnEnableCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<SignalAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnEnableCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SignalAsset()
	{
		Il2CppClassPointerStore<SignalAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SignalAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr);
		NativeFieldInfoPtr_OnEnableCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, "OnEnableCallback");
		NativeMethodInfoPtr_add_OnEnableCallback_Internal_Static_add_Void_Action_1_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663957);
		NativeMethodInfoPtr_remove_OnEnableCallback_Internal_Static_rem_Void_Action_1_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663958);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663959);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr, 100663960);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140334, XrefRangeEnd = 1140342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEnableCallback(Il2CppSystem.Action<SignalAsset> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnEnableCallback_Internal_Static_add_Void_Action_1_SignalAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140342, XrefRangeEnd = 1140350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEnableCallback(Il2CppSystem.Action<SignalAsset> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnEnableCallback_Internal_Static_rem_Void_Action_1_SignalAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140350, XrefRangeEnd = 1140352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 26528, RefRangeEnd = 26564, XrefRangeStart = 26528, XrefRangeEnd = 26564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SignalAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalAsset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SignalAsset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
