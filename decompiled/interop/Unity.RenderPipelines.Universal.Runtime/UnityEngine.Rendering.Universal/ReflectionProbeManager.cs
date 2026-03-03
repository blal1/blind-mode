using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

public sealed class ReflectionProbeManager : Il2CppSystem.ValueType
{
	public sealed class CachedProbe : Il2CppSystem.ValueType
	{
		[StructLayout(LayoutKind.Explicit)]
		[ObfuscatedName("UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe+<dataIndices>e__FixedBuffer")]
		public struct _dataIndices_e__FixedBuffer
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

			[FieldOffset(0)]
			public int FixedElementField;

			static _dataIndices_e__FixedBuffer()
			{
				Il2CppClassPointerStore<_dataIndices_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "<dataIndices>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_dataIndices_e__FixedBuffer>.NativeClassPtr);
				NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_dataIndices_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_dataIndices_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		[ObfuscatedName("UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe+<levels>e__FixedBuffer")]
		public struct _levels_e__FixedBuffer
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

			[FieldOffset(0)]
			public int FixedElementField;

			static _levels_e__FixedBuffer()
			{
				Il2CppClassPointerStore<_levels_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "<levels>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_levels_e__FixedBuffer>.NativeClassPtr);
				NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_levels_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_levels_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_updateCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_imageContentsHash;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_mipCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_dataIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_levels;

		private static readonly System.IntPtr NativeFieldInfoPtr_texture;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUsed;

		private static readonly System.IntPtr NativeFieldInfoPtr_hdrData;

		public unsafe uint updateCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateCount);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateCount)) = value;
			}
		}

		public unsafe Hash128 imageContentsHash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageContentsHash);
				return *(Hash128*)num;
			}
			set
			{
				*(Hash128*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageContentsHash)) = value;
			}
		}

		public unsafe int size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = value;
			}
		}

		public unsafe int mipCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mipCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mipCount)) = value;
			}
		}

		public unsafe _dataIndices_e__FixedBuffer dataIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataIndices);
				return *(_dataIndices_e__FixedBuffer*)num;
			}
			set
			{
				*(_dataIndices_e__FixedBuffer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataIndices)) = value;
			}
		}

		public unsafe _levels_e__FixedBuffer levels
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levels);
				return *(_levels_e__FixedBuffer*)num;
			}
			set
			{
				*(_levels_e__FixedBuffer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levels)) = value;
			}
		}

		public unsafe Texture texture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int lastUsed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsed);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsed)) = value;
			}
		}

		public unsafe Vector4 hdrData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdrData);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdrData)) = value;
			}
		}

		static CachedProbe()
		{
			Il2CppClassPointerStore<CachedProbe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "CachedProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr);
			NativeFieldInfoPtr_updateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "updateCount");
			NativeFieldInfoPtr_imageContentsHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "imageContentsHash");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "size");
			NativeFieldInfoPtr_mipCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "mipCount");
			NativeFieldInfoPtr_dataIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "dataIndices");
			NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "levels");
			NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "texture");
			NativeFieldInfoPtr_lastUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "lastUsed");
			NativeFieldInfoPtr_hdrData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr, "hdrData");
		}

		public CachedProbe(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CachedProbe()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedProbe>.NativeClassPtr))
		{
		}
	}

	public static class ShaderProperties : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_BoxMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_BoxMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_ProbePosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_MipScaleOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_Count;

		private static readonly System.IntPtr NativeFieldInfoPtr_Atlas;

		public unsafe static int BoxMin
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BoxMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BoxMin, (void*)(&value));
			}
		}

		public unsafe static int BoxMax
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BoxMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BoxMax, (void*)(&value));
			}
		}

		public unsafe static int ProbePosition
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProbePosition, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProbePosition, (void*)(&value));
			}
		}

		public unsafe static int MipScaleOffset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MipScaleOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MipScaleOffset, (void*)(&value));
			}
		}

		public unsafe static int Count
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Count, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Count, (void*)(&value));
			}
		}

		public unsafe static int Atlas
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Atlas, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Atlas, (void*)(&value));
			}
		}

		static ShaderProperties()
		{
			Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "ShaderProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr);
			NativeFieldInfoPtr_BoxMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BoxMin");
			NativeFieldInfoPtr_BoxMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BoxMax");
			NativeFieldInfoPtr_ProbePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ProbePosition");
			NativeFieldInfoPtr_MipScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "MipScaleOffset");
			NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "Count");
			NativeFieldInfoPtr_Atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "Atlas");
		}

		public ShaderProperties(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Resolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasTexture0;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasTexture1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasTexture0Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasAllocator;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Cache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WarningCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedsUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedsRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MipScaleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxMipCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ReflectionProbeAtlasName;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasRT_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasRTHandle_Public_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ReflectionProbeManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGpuData_Public_Void_CommandBuffer_byref_CullingResults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleOffset_Private_float4_Int32_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe int2 m_Resolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Resolution);
			return *(int2*)num;
		}
		set
		{
			*(int2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Resolution)) = value;
		}
	}

	public unsafe RenderTexture m_AtlasTexture0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTexture m_AtlasTexture1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_AtlasTexture0Handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture0Handle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture0Handle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BuddyAllocator m_AtlasAllocator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasAllocator);
			return new BuddyAllocator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Dictionary<int, CachedProbe> m_Cache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CachedProbe>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, int> m_WarningCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WarningCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WarningCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> m_NeedsUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsUpdate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsUpdate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> m_NeedsRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsRemove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsRemove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_BoxMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoxMax);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoxMax)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_BoxMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoxMin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoxMin)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_ProbePosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbePosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbePosition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_MipScaleOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MipScaleOffset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MipScaleOffset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_MaxMipCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxMipCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxMipCount, (void*)(&value));
		}
	}

	public unsafe static string k_ReflectionProbeAtlasName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ReflectionProbeAtlasName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ReflectionProbeAtlasName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe RenderTexture atlasRT
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasRT_Public_get_RenderTexture_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}
	}

	public unsafe RTHandle atlasRTHandle
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasRTHandle_Public_get_RTHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	static ReflectionProbeManager()
	{
		Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ReflectionProbeManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr);
		NativeFieldInfoPtr_m_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_Resolution");
		NativeFieldInfoPtr_m_AtlasTexture0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_AtlasTexture0");
		NativeFieldInfoPtr_m_AtlasTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_AtlasTexture1");
		NativeFieldInfoPtr_m_AtlasTexture0Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_AtlasTexture0Handle");
		NativeFieldInfoPtr_m_AtlasAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_AtlasAllocator");
		NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_Cache");
		NativeFieldInfoPtr_m_WarningCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_WarningCache");
		NativeFieldInfoPtr_m_NeedsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_NeedsUpdate");
		NativeFieldInfoPtr_m_NeedsRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_NeedsRemove");
		NativeFieldInfoPtr_m_BoxMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_BoxMax");
		NativeFieldInfoPtr_m_BoxMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_BoxMin");
		NativeFieldInfoPtr_m_ProbePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_ProbePosition");
		NativeFieldInfoPtr_m_MipScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_MipScaleOffset");
		NativeFieldInfoPtr_k_MaxMipCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "k_MaxMipCount");
		NativeFieldInfoPtr_k_ReflectionProbeAtlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "k_ReflectionProbeAtlasName");
		NativeMethodInfoPtr_get_atlasRT_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665174);
		NativeMethodInfoPtr_get_atlasRTHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665175);
		NativeMethodInfoPtr_Create_Public_Static_ReflectionProbeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665176);
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665177);
		NativeMethodInfoPtr_UpdateGpuData_Public_Void_CommandBuffer_byref_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665178);
		NativeMethodInfoPtr_GetScaleOffset_Private_float4_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665179);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665180);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1096161, RefRangeEnd = 1096162, XrefRangeStart = 1096160, XrefRangeEnd = 1096161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReflectionProbeManager Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ReflectionProbeManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReflectionProbeManager(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1096236, RefRangeEnd = 1096237, XrefRangeStart = 1096162, XrefRangeEnd = 1096236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1096459, RefRangeEnd = 1096460, XrefRangeStart = 1096237, XrefRangeEnd = 1096459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGpuData(CommandBuffer cmd, ref CullingResults cullResults)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGpuData_Public_Void_CommandBuffer_byref_CullingResults_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1096462, RefRangeEnd = 1096465, XrefRangeStart = 1096460, XrefRangeEnd = 1096462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataIndex;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includePadding;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &yflip;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleOffset_Private_float4_Int32_Int32_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1096476, RefRangeEnd = 1096477, XrefRangeStart = 1096465, XrefRangeEnd = 1096476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ReflectionProbeManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ReflectionProbeManager()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr))
	{
	}
}
