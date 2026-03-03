using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Skybox : Behaviour
{
	private delegate void set_material_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_material_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly set_material_InjectedDelegate set_material_InjectedDelegateField;

	public unsafe Material material
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178054, RefRangeEnd = 1178055, XrefRangeStart = 1178046, XrefRangeEnd = 1178054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_material_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	static Skybox()
	{
		Il2CppClassPointerStore<Skybox>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Skybox");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skybox>.NativeClassPtr);
		NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skybox>.NativeClassPtr, 100664920);
		NativeMethodInfoPtr_get_material_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skybox>.NativeClassPtr, 100664921);
		set_material_InjectedDelegateField = IL2CPP.ResolveICall<set_material_InjectedDelegate>("UnityEngine.Skybox::set_material_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178055, XrefRangeEnd = 1178057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr get_material_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_material_Injected_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Skybox(IntPtr pointer)
		: base(pointer)
	{
	}

	public static void set_material_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_material_InjectedDelegateField(_unity_self, value);
	}
}
