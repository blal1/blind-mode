using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Audio;

public class AudioResource : Object
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

	static AudioResource()
	{
		Il2CppClassPointerStore<AudioResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioResource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioResource>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioResource>.NativeClassPtr, 100663410);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163297, XrefRangeEnd = 1163301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioResource()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioResource>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AudioResource(IntPtr pointer)
		: base(pointer)
	{
	}
}
