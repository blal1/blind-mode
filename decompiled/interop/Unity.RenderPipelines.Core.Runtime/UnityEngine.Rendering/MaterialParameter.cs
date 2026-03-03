using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class MaterialParameter : VolumeParameter<Material>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_Boolean_0;

	static MaterialParameter()
	{
		Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MaterialParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr, 100667026);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1055004, RefRangeEnd = 1055005, XrefRangeStart = 1055001, XrefRangeEnd = 1055004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialParameter(Material value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MaterialParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
