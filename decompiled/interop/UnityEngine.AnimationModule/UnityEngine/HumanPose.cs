using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public sealed class HumanPose : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bodyPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_muscles;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

	public unsafe Vector3 bodyPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyPosition)) = value;
		}
	}

	public unsafe Quaternion bodyRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyRotation)) = value;
		}
	}

	public unsafe Il2CppStructArray<float> muscles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muscles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muscles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static HumanPose()
	{
		Il2CppClassPointerStore<HumanPose>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanPose");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanPose>.NativeClassPtr);
		NativeFieldInfoPtr_bodyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanPose>.NativeClassPtr, "bodyPosition");
		NativeFieldInfoPtr_bodyRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanPose>.NativeClassPtr, "bodyRotation");
		NativeFieldInfoPtr_muscles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanPose>.NativeClassPtr, "muscles");
		NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanPose>.NativeClassPtr, 100664151);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1157290, RefRangeEnd = 1157294, XrefRangeStart = 1157282, XrefRangeEnd = 1157290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HumanPose(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HumanPose()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanPose>.NativeClassPtr))
	{
	}
}
