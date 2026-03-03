using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace Il2Cpp;

[Serializable]
public class SpineSkeletonFlipBehaviour : PlayableBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_flipX;

	private static readonly IntPtr NativeFieldInfoPtr_flipY;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool flipX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipX)) = value;
		}
	}

	public unsafe bool flipY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipY)) = value;
		}
	}

	static SpineSkeletonFlipBehaviour()
	{
		Il2CppClassPointerStore<SpineSkeletonFlipBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-timeline.dll", "", "SpineSkeletonFlipBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineSkeletonFlipBehaviour>.NativeClassPtr);
		NativeFieldInfoPtr_flipX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineSkeletonFlipBehaviour>.NativeClassPtr, "flipX");
		NativeFieldInfoPtr_flipY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineSkeletonFlipBehaviour>.NativeClassPtr, "flipY");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineSkeletonFlipBehaviour>.NativeClassPtr, 100663297);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpineSkeletonFlipBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpineSkeletonFlipBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpineSkeletonFlipBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}
}
