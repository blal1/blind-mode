using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text;

public class TextLib : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TextLib_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextLib>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TextLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663876);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(TextLib textLib)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textLib);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TextLib_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetICUAssetEditorDelegate;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateText_Public_NativeTextInfo_NativeTextGenerationSettings_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMeshInfos_Public_Void_NativeTextInfo_NativeTextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTextInternal_Private_NativeTextInfo_NativeTextGenerationSettings_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MeasureText_Public_Vector2_NativeTextGenerationSettings_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_Vector2_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTextInternal_Injected_Private_Static_Void_IntPtr_byref_NativeTextGenerationSettings_IntPtr_byref_NativeTextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MeasureText_Injected_Private_Static_Void_IntPtr_byref_NativeTextGenerationSettings_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindIntersectingLink_Injected_Private_Static_Int32_byref_Vector2_IntPtr_0;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe static Il2CppSystem.Func<UnityEngine.TextAsset> GetICUAssetEditorDelegate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetICUAssetEditorDelegate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<UnityEngine.TextAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetICUAssetEditorDelegate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TextLib()
	{
		Il2CppClassPointerStore<TextLib>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextLib");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextLib>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLib>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_GetICUAssetEditorDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLib>.NativeClassPtr, "GetICUAssetEditorDelegate");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr_GetInstance_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_GenerateText_Public_NativeTextInfo_NativeTextGenerationSettings_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663867);
		NativeMethodInfoPtr_ProcessMeshInfos_Public_Void_NativeTextInfo_NativeTextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663868);
		NativeMethodInfoPtr_GenerateTextInternal_Private_NativeTextInfo_NativeTextGenerationSettings_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663869);
		NativeMethodInfoPtr_MeasureText_Public_Vector2_NativeTextGenerationSettings_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_Vector2_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_GetInstance_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_GenerateTextInternal_Injected_Private_Static_Void_IntPtr_byref_NativeTextGenerationSettings_IntPtr_byref_NativeTextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_MeasureText_Injected_Private_Static_Void_IntPtr_byref_NativeTextGenerationSettings_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663874);
		NativeMethodInfoPtr_FindIntersectingLink_Injected_Private_Static_Int32_byref_Vector2_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLib>.NativeClassPtr, 100663875);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282953, RefRangeEnd = 1282954, XrefRangeStart = 1282943, XrefRangeEnd = 1282953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextLib(Il2CppStructArray<byte> icuData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextLib>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icuData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282954, XrefRangeEnd = 1282963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetInstance(Il2CppStructArray<byte> icuData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icuData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstance_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282970, RefRangeEnd = 1282971, XrefRangeStart = 1282963, XrefRangeEnd = 1282970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeTextInfo GenerateText(NativeTextGenerationSettings settings, System.IntPtr textGenerationInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textGenerationInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateText_Public_NativeTextInfo_NativeTextGenerationSettings_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeTextInfo(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1283047, RefRangeEnd = 1283048, XrefRangeStart = 1282971, XrefRangeEnd = 1283047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessMeshInfos(NativeTextInfo textInfo, NativeTextGenerationSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)textInfo));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessMeshInfos_Public_Void_NativeTextInfo_NativeTextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283048, XrefRangeEnd = 1283051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeTextInfo GenerateTextInternal(NativeTextGenerationSettings settings, System.IntPtr textGenerationInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textGenerationInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTextInternal_Private_NativeTextInfo_NativeTextGenerationSettings_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeTextInfo(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1283054, RefRangeEnd = 1283055, XrefRangeStart = 1283051, XrefRangeEnd = 1283054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 MeasureText(NativeTextGenerationSettings settings, System.IntPtr textGenerationInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textGenerationInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MeasureText_Public_Vector2_NativeTextGenerationSettings_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1283057, RefRangeEnd = 1283058, XrefRangeStart = 1283055, XrefRangeEnd = 1283057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindIntersectingLink(Vector2 point, System.IntPtr textGenerationInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&point);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textGenerationInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_Vector2_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283058, XrefRangeEnd = 1283060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetInstance_Injected(ref ManagedSpanWrapper icuData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref icuData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstance_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283060, XrefRangeEnd = 1283062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GenerateTextInternal_Injected(System.IntPtr _unity_self, [In] ref NativeTextGenerationSettings settings, System.IntPtr textGenerationInfo, out NativeTextInfo ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textGenerationInfo;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTextInternal_Injected_Private_Static_Void_IntPtr_byref_NativeTextGenerationSettings_IntPtr_byref_NativeTextInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		ret = ((num3 == 0) ? null : new NativeTextInfo(num3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283062, XrefRangeEnd = 1283064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MeasureText_Injected(System.IntPtr _unity_self, [In] ref NativeTextGenerationSettings settings, System.IntPtr textGenerationInfo, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textGenerationInfo;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MeasureText_Injected_Private_Static_Void_IntPtr_byref_NativeTextGenerationSettings_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283064, XrefRangeEnd = 1283066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindIntersectingLink_Injected([In] ref Vector2 point, System.IntPtr textGenerationInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref point);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textGenerationInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindIntersectingLink_Injected_Private_Static_Int32_byref_Vector2_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TextLib(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
