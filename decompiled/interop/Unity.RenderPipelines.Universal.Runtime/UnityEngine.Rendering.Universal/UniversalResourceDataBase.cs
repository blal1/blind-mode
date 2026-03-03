using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class UniversalResourceDataBase : ContextItem
{
	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "ActiveID")]
	public enum ActiveID
	{
		Camera,
		BackBuffer
	}

	private static readonly IntPtr NativeFieldInfoPtr__isAccessible_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_isAccessible_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isAccessible_Internal_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitFrame_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_EndFrame_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAndSetTextureHandle_Protected_Void_byref_TextureHandle_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAndGetTextureHandle_Protected_TextureHandle_byref_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAndSetTextureHandle_Protected_Void_byref_Il2CppStructArray_1_TextureHandle_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAndGetTextureHandle_Protected_Il2CppStructArray_1_TextureHandle_byref_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAndWarnAboutAccessibility_Protected_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe bool _isAccessible_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isAccessible_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isAccessible_k__BackingField)) = value;
		}
	}

	public unsafe bool isAccessible
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isAccessible_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86557, RefRangeEnd = 86558, XrefRangeStart = 86557, XrefRangeEnd = 86558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isAccessible_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static UniversalResourceDataBase()
	{
		Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalResourceDataBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr);
		NativeFieldInfoPtr__isAccessible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, "<isAccessible>k__BackingField");
		NativeMethodInfoPtr_get_isAccessible_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664566);
		NativeMethodInfoPtr_set_isAccessible_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664567);
		NativeMethodInfoPtr_InitFrame_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664568);
		NativeMethodInfoPtr_EndFrame_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664569);
		NativeMethodInfoPtr_CheckAndSetTextureHandle_Protected_Void_byref_TextureHandle_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664570);
		NativeMethodInfoPtr_CheckAndGetTextureHandle_Protected_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664571);
		NativeMethodInfoPtr_CheckAndSetTextureHandle_Protected_Void_byref_Il2CppStructArray_1_TextureHandle_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664572);
		NativeMethodInfoPtr_CheckAndGetTextureHandle_Protected_Il2CppStructArray_1_TextureHandle_byref_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664573);
		NativeMethodInfoPtr_CheckAndWarnAboutAccessibility_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664574);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr, 100664575);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82714, RefRangeEnd = 82717, XrefRangeStart = 82714, XrefRangeEnd = 82717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitFrame_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 216196, RefRangeEnd = 216200, XrefRangeStart = 216196, XrefRangeEnd = 216200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndFrame_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087043, XrefRangeEnd = 1087049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAndSetTextureHandle(ref TextureHandle handle, TextureHandle newHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &newHandle;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndSetTextureHandle_Protected_Void_byref_TextureHandle_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 1087063, RefRangeEnd = 1087091, XrefRangeStart = 1087049, XrefRangeEnd = 1087063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle CheckAndGetTextureHandle(ref TextureHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndGetTextureHandle_Protected_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1087103, RefRangeEnd = 1087106, XrefRangeStart = 1087091, XrefRangeEnd = 1087103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAndSetTextureHandle(ref Il2CppStructArray<TextureHandle> handle, Il2CppStructArray<TextureHandle> newHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHandle);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndSetTextureHandle_Protected_Void_byref_Il2CppStructArray_1_TextureHandle_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (IntPtr)0) ? null : new Il2CppStructArray<TextureHandle>(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1087114, RefRangeEnd = 1087117, XrefRangeStart = 1087106, XrefRangeEnd = 1087114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<TextureHandle> CheckAndGetTextureHandle(ref Il2CppStructArray<TextureHandle> handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndGetTextureHandle_Protected_Il2CppStructArray_1_TextureHandle_byref_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (IntPtr)0) ? null : new Il2CppStructArray<TextureHandle>(intPtr4));
		return (intPtr3 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr3) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087117, XrefRangeEnd = 1087123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckAndWarnAboutAccessibility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndWarnAboutAccessibility_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalResourceDataBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalResourceDataBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalResourceDataBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
