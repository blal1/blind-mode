using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

public class LightCookieManager : Il2CppSystem.Object
{
	public static class ShaderProperty : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mainLightTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_mainLightWorldToLight;

		private static readonly System.IntPtr NativeFieldInfoPtr_mainLightCookieTextureFormat;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsCookieEnableBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsWorldToLightBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsLightTypeBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsWorldToLights;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalLightsLightTypes;

		public unsafe static int mainLightTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainLightTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainLightTexture, (void*)(&value));
			}
		}

		public unsafe static int mainLightWorldToLight
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainLightWorldToLight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainLightWorldToLight, (void*)(&value));
			}
		}

		public unsafe static int mainLightCookieTextureFormat
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainLightCookieTextureFormat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainLightCookieTextureFormat, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsCookieAtlasTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsCookieAtlasTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsCookieAtlasTexture, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsCookieAtlasTextureFormat
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsCookieEnableBits
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsCookieEnableBits, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsCookieEnableBits, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsCookieAtlasUVRectBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsCookieAtlasUVRects
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsWorldToLightBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsWorldToLightBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsWorldToLightBuffer, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsLightTypeBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsLightTypeBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsLightTypeBuffer, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsWorldToLights
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsWorldToLights, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsWorldToLights, (void*)(&value));
			}
		}

		public unsafe static int additionalLightsLightTypes
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_additionalLightsLightTypes, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_additionalLightsLightTypes, (void*)(&value));
			}
		}

		static ShaderProperty()
		{
			Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "ShaderProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr);
			NativeFieldInfoPtr_mainLightTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "mainLightTexture");
			NativeFieldInfoPtr_mainLightWorldToLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "mainLightWorldToLight");
			NativeFieldInfoPtr_mainLightCookieTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "mainLightCookieTextureFormat");
			NativeFieldInfoPtr_additionalLightsCookieAtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasTexture");
			NativeFieldInfoPtr_additionalLightsCookieAtlasTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasTextureFormat");
			NativeFieldInfoPtr_additionalLightsCookieEnableBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsCookieEnableBits");
			NativeFieldInfoPtr_additionalLightsCookieAtlasUVRectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasUVRectBuffer");
			NativeFieldInfoPtr_additionalLightsCookieAtlasUVRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsCookieAtlasUVRects");
			NativeFieldInfoPtr_additionalLightsWorldToLightBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsWorldToLightBuffer");
			NativeFieldInfoPtr_additionalLightsLightTypeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsLightTypeBuffer");
			NativeFieldInfoPtr_additionalLightsWorldToLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsWorldToLights");
			NativeFieldInfoPtr_additionalLightsLightTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty>.NativeClassPtr, "additionalLightsLightTypes");
		}

		public ShaderProperty(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "LightCookieShaderFormat")]
	public enum LightCookieShaderFormat
	{
		None = -1,
		RGB,
		Alpha,
		Red
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Settings
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct AtlasSettings
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_resolution;

			private static readonly System.IntPtr NativeFieldInfoPtr_format;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_isPow2_Public_get_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_isSquare_Public_get_Boolean_0;

			[FieldOffset(0)]
			public Vector2Int resolution;

			[FieldOffset(8)]
			public GraphicsFormat format;

			public unsafe bool isPow2
			{
				[CallerCount(0)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPow2_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			public unsafe bool isSquare
			{
				[CallerCount(0)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSquare_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			static AtlasSettings()
			{
				Il2CppClassPointerStore<AtlasSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Settings>.NativeClassPtr, "AtlasSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasSettings>.NativeClassPtr);
				NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasSettings>.NativeClassPtr, "resolution");
				NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasSettings>.NativeClassPtr, "format");
				NativeMethodInfoPtr_get_isPow2_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasSettings>.NativeClassPtr, 100664709);
				NativeMethodInfoPtr_get_isSquare_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasSettings>.NativeClassPtr, 100664710);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AtlasSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_atlas;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxAdditionalLights;

		private static readonly System.IntPtr NativeFieldInfoPtr_cubeOctahedralSizeScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_useStructuredBuffer;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Settings_0;

		[FieldOffset(0)]
		public AtlasSettings atlas;

		[FieldOffset(12)]
		public int maxAdditionalLights;

		[FieldOffset(16)]
		public float cubeOctahedralSizeScale;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.U1)]
		public bool useStructuredBuffer;

		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "atlas");
			NativeFieldInfoPtr_maxAdditionalLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxAdditionalLights");
			NativeFieldInfoPtr_cubeOctahedralSizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "cubeOctahedralSizeScale");
			NativeFieldInfoPtr_useStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "useStructuredBuffer");
			NativeMethodInfoPtr_Create_Public_Static_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100664708);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1087811, RefRangeEnd = 1087814, XrefRangeStart = 1087803, XrefRangeEnd = 1087811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Settings Create()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Settings*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Settings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class LightCookieMapping : Il2CppSystem.ValueType
	{
		[System.Serializable]
		[ObfuscatedName("UnityEngine.Rendering.Universal.LightCookieManager+LightCookieMapping+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__6_0_Internal_Int32_LightCookieMapping_LightCookieMapping_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__6_1_Internal_Int32_LightCookieMapping_LightCookieMapping_0;

			public unsafe static __c __9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664713);
				NativeMethodInfoPtr___cctor_b__6_0_Internal_Int32_LightCookieMapping_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664714);
				NativeMethodInfoPtr___cctor_b__6_1_Internal_Int32_LightCookieMapping_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664715);
			}

			[CallerCount(1950)]
			[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087814, XrefRangeEnd = 1087818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __cctor_b__6_0(LightCookieMapping a, LightCookieMapping b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__6_0_Internal_Int32_LightCookieMapping_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			public unsafe int __cctor_b__6_1(LightCookieMapping a, LightCookieMapping b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__6_1_Internal_Int32_LightCookieMapping_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightBufferIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_light;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_CompareByCookieSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_CompareByBufferIndex;

		public unsafe ushort visibleLightIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLightIndex);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLightIndex)) = value;
			}
		}

		public unsafe ushort lightBufferIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightBufferIndex);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightBufferIndex)) = value;
			}
		}

		public unsafe Light light
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_light);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_light)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<LightCookieMapping, LightCookieMapping, int> s_CompareByCookieSize
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CompareByCookieSize, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LightCookieMapping, LightCookieMapping, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CompareByCookieSize, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<LightCookieMapping, LightCookieMapping, int> s_CompareByBufferIndex
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CompareByBufferIndex, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LightCookieMapping, LightCookieMapping, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CompareByBufferIndex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static LightCookieMapping()
		{
			Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "LightCookieMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr);
			NativeFieldInfoPtr_visibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr, "visibleLightIndex");
			NativeFieldInfoPtr_lightBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr, "lightBufferIndex");
			NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr, "light");
			NativeFieldInfoPtr_s_CompareByCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr, "s_CompareByCookieSize");
			NativeFieldInfoPtr_s_CompareByBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr, "s_CompareByBufferIndex");
		}

		public LightCookieMapping(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public LightCookieMapping()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieMapping>.NativeClassPtr))
		{
		}
	}

	public sealed class WorkSlice<T> : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Start;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Length;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_capacity_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_Func_3_T_T_Int32_0;

		public unsafe Il2CppArrayBase<T> m_Data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_Start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Start);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Start)) = value;
			}
		}

		public unsafe int m_Length
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Length);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		public unsafe T this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1087827, RefRangeEnd = 1087833, XrefRangeStart = 1087827, XrefRangeEnd = 1087827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&index);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
			[CallerCount(0)]
			set
			{
				//IL_005a->IL005d: Incompatible stack types: I vs Ref
				//IL_004d->IL005d: Incompatible stack types: I vs Ref
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&index);
				byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
				ref T reference;
				if (!typeof(T).IsValueType)
				{
					object obj = value;
					reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
				}
				else
				{
					reference = ref value;
				}
				*(void**)num = Unsafe.AsPointer(ref reference);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int capacity
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1087833, RefRangeEnd = 1087854, XrefRangeStart = 1087833, XrefRangeEnd = 1087833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static WorkSlice()
		{
			Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "WorkSlice`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr);
			NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, "m_Data");
			NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, "m_Start");
			NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, "m_Length");
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, 100664716);
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, 100664717);
			NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, 100664718);
			NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, 100664719);
			NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, 100664720);
			NativeMethodInfoPtr_get_capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, 100664721);
			NativeMethodInfoPtr_Sort_Public_Void_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr, 100664722);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087820, RefRangeEnd = 1087821, XrefRangeStart = 1087818, XrefRangeEnd = 1087820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSlice(Il2CppArrayBase<T> src, int srcLen = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcLen;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087821, XrefRangeEnd = 1087827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSlice(Il2CppArrayBase<T> src, int srcStart, int srcLen = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcStart;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcLen;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087854, XrefRangeEnd = 1087859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(Il2CppSystem.Func<T, T, int> compare)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compare);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sort_Public_Void_Func_3_T_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public WorkSlice(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public WorkSlice()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSlice<T>>.NativeClassPtr))
		{
		}
	}

	public class WorkMemory : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lightMappings;

		private static readonly System.IntPtr NativeFieldInfoPtr_uvRects;

		private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppReferenceArray<LightCookieMapping> lightMappings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightMappings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightCookieMapping>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightMappings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<Vector4> uvRects
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvRects);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvRects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static WorkMemory()
		{
			Il2CppClassPointerStore<WorkMemory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "WorkMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkMemory>.NativeClassPtr);
			NativeFieldInfoPtr_lightMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkMemory>.NativeClassPtr, "lightMappings");
			NativeFieldInfoPtr_uvRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkMemory>.NativeClassPtr, "uvRects");
			NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkMemory>.NativeClassPtr, 100664723);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkMemory>.NativeClassPtr, 100664724);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087859, XrefRangeEnd = 1087877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&size);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkMemory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkMemory>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public WorkMemory(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class LightCookieShaderData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Size;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_UseStructuredBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldToLightCpuData;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasUVRectCpuData;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LightTypeCpuData;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CookieEnableBitsCpuData;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldToLightBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasUVRectBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LightTypeBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__isUploaded_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_worldToLights_Public_get_Il2CppStructArray_1_Matrix4x4_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_cookieEnableBits_Public_get_ShaderBitArray_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasUVRects_Public_get_Il2CppStructArray_1_Vector4_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_lightTypes_Public_get_Il2CppStructArray_1_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isUploaded_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isUploaded_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Upload_Public_Void_CommandBuffer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_CommandBuffer_0;

		public unsafe int m_Size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Size);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Size)) = value;
			}
		}

		public unsafe bool m_UseStructuredBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStructuredBuffer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStructuredBuffer)) = value;
			}
		}

		public unsafe Il2CppStructArray<Matrix4x4> m_WorldToLightCpuData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToLightCpuData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToLightCpuData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<Vector4> m_AtlasUVRectCpuData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasUVRectCpuData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasUVRectCpuData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<float> m_LightTypeCpuData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightTypeCpuData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightTypeCpuData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ShaderBitArray m_CookieEnableBitsCpuData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CookieEnableBitsCpuData);
				return new ShaderBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CookieEnableBitsCpuData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ComputeBuffer m_WorldToLightBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToLightBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToLightBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer m_AtlasUVRectBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasUVRectBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasUVRectBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer m_LightTypeBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightTypeBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightTypeBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool _isUploaded_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isUploaded_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isUploaded_k__BackingField)) = value;
			}
		}

		public unsafe Il2CppStructArray<Matrix4x4> worldToLights
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldToLights_Public_get_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
		}

		public unsafe ShaderBitArray cookieEnableBits
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cookieEnableBits_Public_get_ShaderBitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ShaderBitArray(pointer);
			}
		}

		public unsafe Il2CppStructArray<Vector4> atlasUVRects
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasUVRects_Public_get_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
		}

		public unsafe Il2CppStructArray<float> lightTypes
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightTypes_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
		}

		public unsafe bool isUploaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isUploaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isUploaded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static LightCookieShaderData()
		{
			Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "LightCookieShaderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr);
			NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_Size");
			NativeFieldInfoPtr_m_UseStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_UseStructuredBuffer");
			NativeFieldInfoPtr_m_WorldToLightCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_WorldToLightCpuData");
			NativeFieldInfoPtr_m_AtlasUVRectCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_AtlasUVRectCpuData");
			NativeFieldInfoPtr_m_LightTypeCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_LightTypeCpuData");
			NativeFieldInfoPtr_m_CookieEnableBitsCpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_CookieEnableBitsCpuData");
			NativeFieldInfoPtr_m_WorldToLightBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_WorldToLightBuffer");
			NativeFieldInfoPtr_m_AtlasUVRectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_AtlasUVRectBuffer");
			NativeFieldInfoPtr_m_LightTypeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "m_LightTypeBuffer");
			NativeFieldInfoPtr__isUploaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, "<isUploaded>k__BackingField");
			NativeMethodInfoPtr_get_worldToLights_Public_get_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664725);
			NativeMethodInfoPtr_get_cookieEnableBits_Public_get_ShaderBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664726);
			NativeMethodInfoPtr_get_atlasUVRects_Public_get_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664727);
			NativeMethodInfoPtr_get_lightTypes_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664728);
			NativeMethodInfoPtr_get_isUploaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664729);
			NativeMethodInfoPtr_set_isUploaded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664730);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664731);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664732);
			NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664733);
			NativeMethodInfoPtr_Upload_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664734);
			NativeMethodInfoPtr_Clear_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr, 100664735);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087877, XrefRangeEnd = 1087879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightCookieShaderData(int size, bool useStructuredBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieShaderData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&size);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useStructuredBuffer;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087879, XrefRangeEnd = 1087882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1087923, RefRangeEnd = 1087927, XrefRangeStart = 1087882, XrefRangeEnd = 1087923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&size);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087927, XrefRangeEnd = 1087952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Upload(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Upload_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087952, XrefRangeEnd = 1087958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LightCookieShaderData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DirLightProj;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WorkMem;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxCookieSizeDivisor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CookieSizeDivisor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevCookieRequestPixelCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevWarnFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsKeywordLightCookieEnabled_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsKeywordLightCookieEnabled_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AdditionalLightsCookieAtlasTexture_Internal_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAdditionalLights_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInitialized_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightCookieShaderDataIndex_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_CommandBuffer_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupMainLight_Private_Boolean_CommandBuffer_byref_VisibleLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightCookieShaderFormat_Private_LightCookieShaderFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightUVScaleOffset_Private_Void_byref_UniversalAdditionalLightData_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAdditionalLights_Private_Boolean_CommandBuffer_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterAndValidateAdditionalLights_Private_Int32_UniversalLightData_Il2CppReferenceArray_1_LightCookieMapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAdditionalLightsAtlas_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchUVRects_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCookieRequestPixelCount_Private_UInt32_byref_WorkSlice_1_LightCookieMapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApproximateCookieSizeDivisor_Private_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fetch2D_Private_Vector4_CommandBuffer_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchCube_Private_Vector4_CommandBuffer_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeOctahedralCookieSize_Private_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustUVRect_Private_Void_byref_Vector4_Texture_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShrinkUVRect_Private_Void_byref_Vector4_Single_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UploadAdditionalLights_Private_Void_CommandBuffer_UniversalLightData_byref_WorkSlice_1_LightCookieMapping_byref_WorkSlice_1_Vector4_0;

	public unsafe static Matrix4x4 s_DirLightProj
	{
		get
		{
			Unsafe.SkipInit(out Matrix4x4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DirLightProj, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DirLightProj, (void*)(&value));
		}
	}

	public unsafe Texture2DAtlas m_AdditionalLightsCookieAtlas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2DAtlas>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LightCookieShaderData m_AdditionalLightsCookieShaderData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightCookieShaderData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Settings m_Settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings);
			return *(Settings*)num;
		}
		set
		{
			*(Settings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings)) = value;
		}
	}

	public unsafe WorkMemory m_WorkMem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorkMem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorkMemory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorkMem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> m_VisibleLightIndexToShaderDataIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_MaxCookieSizeDivisor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxCookieSizeDivisor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxCookieSizeDivisor, (void*)(&value));
		}
	}

	public unsafe int m_CookieSizeDivisor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CookieSizeDivisor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CookieSizeDivisor)) = value;
		}
	}

	public unsafe uint m_PrevCookieRequestPixelCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevCookieRequestPixelCount);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevCookieRequestPixelCount)) = value;
		}
	}

	public unsafe int m_PrevWarnFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevWarnFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevWarnFrame)) = value;
		}
	}

	public unsafe bool _IsKeywordLightCookieEnabled_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField)) = value;
		}
	}

	public unsafe bool IsKeywordLightCookieEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsKeywordLightCookieEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsKeywordLightCookieEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RTHandle AdditionalLightsCookieAtlasTexture
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1087958, RefRangeEnd = 1087962, XrefRangeStart = 1087958, XrefRangeEnd = 1087958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AdditionalLightsCookieAtlasTexture_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	static LightCookieManager()
	{
		Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightCookieManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_DirLightProj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "s_DirLightProj");
		NativeFieldInfoPtr_m_AdditionalLightsCookieAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_AdditionalLightsCookieAtlas");
		NativeFieldInfoPtr_m_AdditionalLightsCookieShaderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_AdditionalLightsCookieShaderData");
		NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_Settings");
		NativeFieldInfoPtr_m_WorkMem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_WorkMem");
		NativeFieldInfoPtr_m_VisibleLightIndexToShaderDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_VisibleLightIndexToShaderDataIndex");
		NativeFieldInfoPtr_k_MaxCookieSizeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "k_MaxCookieSizeDivisor");
		NativeFieldInfoPtr_m_CookieSizeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_CookieSizeDivisor");
		NativeFieldInfoPtr_m_PrevCookieRequestPixelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_PrevCookieRequestPixelCount");
		NativeFieldInfoPtr_m_PrevWarnFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "m_PrevWarnFrame");
		NativeFieldInfoPtr__IsKeywordLightCookieEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, "<IsKeywordLightCookieEnabled>k__BackingField");
		NativeMethodInfoPtr_get_IsKeywordLightCookieEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664682);
		NativeMethodInfoPtr_set_IsKeywordLightCookieEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664683);
		NativeMethodInfoPtr_get_AdditionalLightsCookieAtlasTexture_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr__ctor_Public_Void_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664685);
		NativeMethodInfoPtr_InitAdditionalLights_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr_isInitialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr_GetLightCookieShaderDataIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664689);
		NativeMethodInfoPtr_Setup_Public_Void_CommandBuffer_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664690);
		NativeMethodInfoPtr_SetupMainLight_Private_Boolean_CommandBuffer_byref_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664691);
		NativeMethodInfoPtr_GetLightCookieShaderFormat_Private_LightCookieShaderFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664692);
		NativeMethodInfoPtr_GetLightUVScaleOffset_Private_Void_byref_UniversalAdditionalLightData_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664693);
		NativeMethodInfoPtr_SetupAdditionalLights_Private_Boolean_CommandBuffer_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664694);
		NativeMethodInfoPtr_FilterAndValidateAdditionalLights_Private_Int32_UniversalLightData_Il2CppReferenceArray_1_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664695);
		NativeMethodInfoPtr_UpdateAdditionalLightsAtlas_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664696);
		NativeMethodInfoPtr_FetchUVRects_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664697);
		NativeMethodInfoPtr_ComputeCookieRequestPixelCount_Private_UInt32_byref_WorkSlice_1_LightCookieMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664698);
		NativeMethodInfoPtr_ApproximateCookieSizeDivisor_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr_Fetch2D_Private_Vector4_CommandBuffer_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr_FetchCube_Private_Vector4_CommandBuffer_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr_ComputeOctahedralCookieSize_Private_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664702);
		NativeMethodInfoPtr_AdjustUVRect_Private_Void_byref_Vector4_Texture_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr_ShrinkUVRect_Private_Void_byref_Vector4_Single_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr_UploadAdditionalLights_Private_Void_CommandBuffer_UniversalLightData_byref_WorkSlice_1_LightCookieMapping_byref_WorkSlice_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr, 100664705);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1087968, RefRangeEnd = 1087971, XrefRangeStart = 1087962, XrefRangeEnd = 1087968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LightCookieManager(ref Settings settings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCookieManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087971, XrefRangeEnd = 1087988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitAdditionalLights(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAdditionalLights_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isInitialized()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInitialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1087992, RefRangeEnd = 1087993, XrefRangeStart = 1087988, XrefRangeEnd = 1087992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1087993, RefRangeEnd = 1087997, XrefRangeStart = 1087993, XrefRangeEnd = 1087993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLightCookieShaderDataIndex(int visibleLightIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&visibleLightIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightCookieShaderDataIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088016, RefRangeEnd = 1088017, XrefRangeStart = 1087997, XrefRangeEnd = 1088016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(CommandBuffer cmd, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_CommandBuffer_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088038, RefRangeEnd = 1088039, XrefRangeStart = 1088017, XrefRangeEnd = 1088038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref visibleMainLight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupMainLight_Private_Boolean_CommandBuffer_byref_VisibleLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088039, RefRangeEnd = 1088040, XrefRangeStart = 1088039, XrefRangeEnd = 1088039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cookieFormat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightCookieShaderFormat_Private_LightCookieShaderFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LightCookieShaderFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088040, XrefRangeEnd = 1088049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalLightData);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref uvTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightUVScaleOffset_Private_Void_byref_UniversalAdditionalLightData_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		additionalLightData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalAdditionalLightData(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088098, RefRangeEnd = 1088099, XrefRangeStart = 1088049, XrefRangeEnd = 1088098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetupAdditionalLights(CommandBuffer cmd, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupAdditionalLights_Private_Boolean_CommandBuffer_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088135, RefRangeEnd = 1088136, XrefRangeStart = 1088099, XrefRangeEnd = 1088135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FilterAndValidateAdditionalLights(UniversalLightData lightData, Il2CppReferenceArray<LightCookieMapping> validLightMappings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validLightMappings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterAndValidateAdditionalLights_Private_Int32_UniversalLightData_Il2CppReferenceArray_1_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088156, RefRangeEnd = 1088157, XrefRangeStart = 1088136, XrefRangeEnd = 1088156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref WorkSlice<LightCookieMapping> validLightMappings, Il2CppStructArray<Vector4> textureAtlasUVRects)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)validLightMappings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureAtlasUVRects);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAdditionalLightsAtlas_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088171, RefRangeEnd = 1088172, XrefRangeStart = 1088157, XrefRangeEnd = 1088171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FetchUVRects(CommandBuffer cmd, ref WorkSlice<LightCookieMapping> validLightMappings, Il2CppStructArray<Vector4> textureAtlasUVRects, int cookieSizeDivisor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)validLightMappings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureAtlasUVRects);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cookieSizeDivisor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchUVRects_Private_Int32_CommandBuffer_byref_WorkSlice_1_LightCookieMapping_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088172, XrefRangeEnd = 1088178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint ComputeCookieRequestPixelCount(ref WorkSlice<LightCookieMapping> validLightMappings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)validLightMappings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCookieRequestPixelCount_Private_UInt32_byref_WorkSlice_1_LightCookieMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088178, XrefRangeEnd = 1088181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ApproximateCookieSizeDivisor(float requestAtlasRatio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&requestAtlasRatio);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApproximateCookieSizeDivisor_Private_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088186, RefRangeEnd = 1088187, XrefRangeStart = 1088181, XrefRangeEnd = 1088186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookie);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cookieSizeDivisor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fetch2D_Private_Vector4_CommandBuffer_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088199, RefRangeEnd = 1088200, XrefRangeStart = 1088187, XrefRangeEnd = 1088199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookie);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cookieSizeDivisor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchCube_Private_Vector4_CommandBuffer_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088200, XrefRangeEnd = 1088204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ComputeOctahedralCookieSize(Texture cookie)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeOctahedralCookieSize_Private_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1088210, RefRangeEnd = 1088212, XrefRangeStart = 1088204, XrefRangeEnd = 1088210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref uvScaleOffset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookie);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookieSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustUVRect_Private_Void_byref_Vector4_Texture_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088212, XrefRangeEnd = 1088216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref uvScaleOffset);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amountPixels;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookieSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShrinkUVRect_Private_Void_byref_Vector4_Single_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088309, RefRangeEnd = 1088310, XrefRangeStart = 1088216, XrefRangeEnd = 1088309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UploadAdditionalLights(CommandBuffer cmd, UniversalLightData lightData, ref WorkSlice<LightCookieMapping> validLightMappings, ref WorkSlice<Vector4> validUvRects)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)validLightMappings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)validUvRects);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UploadAdditionalLights_Private_Void_CommandBuffer_UniversalLightData_byref_WorkSlice_1_LightCookieMapping_byref_WorkSlice_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LightCookieManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
