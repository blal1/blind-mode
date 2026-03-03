using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public sealed class SerializedDictionaryDebugView<K, V> : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dict;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Items_Public_get_Il2CppReferenceArray_1_KeyValuePair_2_K_V_0;

	public unsafe IDictionary<K, V> dict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<K, V>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<KeyValuePair<K, V>> Items
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030187, XrefRangeEnd = 1030193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Items_Public_get_Il2CppReferenceArray_1_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<K, V>>>(intPtr2) : null;
		}
	}

	static SerializedDictionaryDebugView()
	{
		Il2CppClassPointerStore<SerializedDictionaryDebugView<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SerializedDictionaryDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedDictionaryDebugView<K, V>>.NativeClassPtr);
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDictionaryDebugView<K, V>>.NativeClassPtr, "dict");
		NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionaryDebugView<K, V>>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_get_Items_Public_get_Il2CppReferenceArray_1_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionaryDebugView<K, V>>.NativeClassPtr, 100664551);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030179, XrefRangeEnd = 1030187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializedDictionaryDebugView(IDictionary<K, V> dictionary)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedDictionaryDebugView<K, V>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SerializedDictionaryDebugView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
