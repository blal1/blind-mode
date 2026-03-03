using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public class TrackMediaType : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_MediaType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_MediaType_0;

	public unsafe TimelineAsset.MediaType m_MediaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MediaType);
			return *(TimelineAsset.MediaType*)num;
		}
		set
		{
			*(TimelineAsset.MediaType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MediaType)) = value;
		}
	}

	static TrackMediaType()
	{
		Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackMediaType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr);
		NativeFieldInfoPtr_m_MediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr, "m_MediaType");
		NativeMethodInfoPtr__ctor_Public_Void_MediaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr, 100664079);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrackMediaType(TimelineAsset.MediaType mt)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_MediaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TrackMediaType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
