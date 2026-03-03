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
using UnityEngine;

public class UnityApplilinkPlugin : Il2CppSystem.Object
{
	public class Emulator : Il2CppSystem.Object
	{
		[System.Serializable]
		public class Context : Il2CppSystem.Object
		{
			public class SettingInfo : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_apiName;

				private static readonly System.IntPtr NativeFieldInfoPtr_response;

				private static readonly System.IntPtr NativeFieldInfoPtr_adModel;

				private static readonly System.IntPtr NativeFieldInfoPtr_adLocation;

				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				public unsafe string apiName
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apiName);
						return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apiName)), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				public unsafe string response
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_response);
						return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_response)), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				public unsafe string adModel
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModel);
						return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModel)), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				public unsafe string adLocation
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adLocation);
						return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adLocation)), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				static SettingInfo()
				{
					Il2CppClassPointerStore<SettingInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Context>.NativeClassPtr, "SettingInfo");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingInfo>.NativeClassPtr);
					NativeFieldInfoPtr_apiName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingInfo>.NativeClassPtr, "apiName");
					NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingInfo>.NativeClassPtr, "response");
					NativeFieldInfoPtr_adModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingInfo>.NativeClassPtr, "adModel");
					NativeFieldInfoPtr_adLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingInfo>.NativeClassPtr, "adLocation");
					NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingInfo>.NativeClassPtr, 100663471);
				}

				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229246, XrefRangeEnd = 1229251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SettingInfo()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingInfo>.NativeClassPtr))
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
				}

				public SettingInfo(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_settingList;

			private static readonly System.IntPtr NativeFieldInfoPtr_viewPortRect;

			private static readonly System.IntPtr NativeFieldInfoPtr_viewConvertSizeAndroid;

			private static readonly System.IntPtr NativeFieldInfoPtr_viewConvertSizeIPhone;

			private static readonly System.IntPtr NativeFieldInfoPtr_isInitialized;

			private static readonly System.IntPtr NativeFieldInfoPtr_instance;

			private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_KEY;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_ViewPortRect_Public_get_Rect_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_ViewConvertSize_Public_get_Vector2_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Context_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Context_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetEmulateResponse_Public_String_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe List<SettingInfo> settingList
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingList);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SettingInfo>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe Rect viewPortRect
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewPortRect);
					return *(Rect*)num;
				}
				set
				{
					*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewPortRect)) = value;
				}
			}

			public unsafe Vector2 viewConvertSizeAndroid
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewConvertSizeAndroid);
					return *(Vector2*)num;
				}
				set
				{
					*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewConvertSizeAndroid)) = value;
				}
			}

			public unsafe Vector2 viewConvertSizeIPhone
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewConvertSizeIPhone);
					return *(Vector2*)num;
				}
				set
				{
					*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewConvertSizeIPhone)) = value;
				}
			}

			public unsafe bool isInitialized
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized)) = value;
				}
			}

			public unsafe static Context instance
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static string PREFS_KEY
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PREFS_KEY, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PREFS_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe Rect ViewPortRect
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229251, XrefRangeEnd = 1229253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ViewPortRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			public unsafe Vector2 ViewConvertSize
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229253, XrefRangeEnd = 1229261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ViewConvertSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			public unsafe static Context Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229261, XrefRangeEnd = 1229273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_Context_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
			}

			static Context()
			{
				Il2CppClassPointerStore<Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "Context");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context>.NativeClassPtr);
				NativeFieldInfoPtr_settingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "settingList");
				NativeFieldInfoPtr_viewPortRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "viewPortRect");
				NativeFieldInfoPtr_viewConvertSizeAndroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "viewConvertSizeAndroid");
				NativeFieldInfoPtr_viewConvertSizeIPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "viewConvertSizeIPhone");
				NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "isInitialized");
				NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "instance");
				NativeFieldInfoPtr_PREFS_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "PREFS_KEY");
				NativeMethodInfoPtr_get_ViewPortRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663462);
				NativeMethodInfoPtr_get_ViewConvertSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663463);
				NativeMethodInfoPtr_get_Instance_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663464);
				NativeMethodInfoPtr_Load_Public_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663465);
				NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663466);
				NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663467);
				NativeMethodInfoPtr_GetEmulateResponse_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663468);
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663469);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1229302, RefRangeEnd = 1229304, XrefRangeStart = 1229273, XrefRangeEnd = 1229302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Context Load()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Context_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229304, XrefRangeEnd = 1229335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Save()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229335, XrefRangeEnd = 1229344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Clear()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1229359, RefRangeEnd = 1229360, XrefRangeStart = 1229344, XrefRangeEnd = 1229359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetEmulateResponse(string key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEmulateResponse_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229360, XrefRangeEnd = 1229368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Context()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public Context(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[System.Serializable]
		[ObfuscatedName("UnityApplilinkPlugin+Emulator+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__initialize_b__3_0_Internal_Void_String_0;

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

			public unsafe static Il2CppSystem.Action<string> __9__3_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__3_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__3_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663473);
				NativeMethodInfoPtr__initialize_b__3_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663474);
			}

			[CallerCount(1830)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229368, XrefRangeEnd = 1229375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__3_0(string result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(result);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__initialize_b__3_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("UnityApplilinkPlugin+Emulator+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectName;

			private static readonly System.IntPtr NativeFieldInfoPtr_functionName;

			private static readonly System.IntPtr NativeFieldInfoPtr_location;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__openRewardList_b__0_Internal_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__openRewardList_b__1_Internal_Void_0;

			public unsafe string gameObjectName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string functionName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_functionName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_functionName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string location
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr);
				NativeFieldInfoPtr_gameObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "gameObjectName");
				NativeFieldInfoPtr_functionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "functionName");
				NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "location");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, 100663475);
				NativeMethodInfoPtr__openRewardList_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, 100663476);
				NativeMethodInfoPtr__openRewardList_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, 100663477);
			}

			[CallerCount(1830)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229375, XrefRangeEnd = 1229392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _openRewardList_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__openRewardList_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229392, XrefRangeEnd = 1229405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _openRewardList_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__openRewardList_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public __c__DisplayClass19_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("UnityApplilinkPlugin+Emulator+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectName;

			private static readonly System.IntPtr NativeFieldInfoPtr_functionName;

			private static readonly System.IntPtr NativeFieldInfoPtr_adModelName;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__openRecommendList_b__0_Internal_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__openRecommendList_b__1_Internal_Void_0;

			public unsafe string gameObjectName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string functionName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_functionName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_functionName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string adModelName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModelName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModelName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr);
				NativeFieldInfoPtr_gameObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "gameObjectName");
				NativeFieldInfoPtr_functionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "functionName");
				NativeFieldInfoPtr_adModelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "adModelName");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100663478);
				NativeMethodInfoPtr__openRecommendList_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100663479);
				NativeMethodInfoPtr__openRecommendList_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100663480);
			}

			[CallerCount(1830)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229405, XrefRangeEnd = 1229422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _openRecommendList_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__openRecommendList_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229422, XrefRangeEnd = 1229435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _openRecommendList_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__openRecommendList_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public __c__DisplayClass6_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("UnityApplilinkPlugin+Emulator+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectName;

			private static readonly System.IntPtr NativeFieldInfoPtr_functionName;

			private static readonly System.IntPtr NativeFieldInfoPtr_adModelName;

			private static readonly System.IntPtr NativeFieldInfoPtr_location;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__openRecommendAdArea_b__0_Internal_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__openRecommendAdArea_b__1_Internal_Void_0;

			public unsafe string gameObjectName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string functionName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_functionName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_functionName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string adModelName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModelName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModelName)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string location
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr);
				NativeFieldInfoPtr_gameObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "gameObjectName");
				NativeFieldInfoPtr_functionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "functionName");
				NativeFieldInfoPtr_adModelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "adModelName");
				NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "location");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100663481);
				NativeMethodInfoPtr__openRecommendAdArea_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100663482);
				NativeMethodInfoPtr__openRecommendAdArea_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100663483);
			}

			[CallerCount(1830)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229435, XrefRangeEnd = 1229453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _openRecommendAdArea_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__openRecommendAdArea_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229453, XrefRangeEnd = 1229467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _openRecommendAdArea_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__openRecommendAdArea_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public __c__DisplayClass9_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_isInitialized;

		private static readonly System.IntPtr NativeFieldInfoPtr_verbose;

		private static readonly System.IntPtr NativeFieldInfoPtr_userId;

		private static readonly System.IntPtr NativeMethodInfoPtr_initialize_Public_Static_Void_String_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_setUserId_Public_Static_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_openRecommendList_Public_Static_Void_String_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_isEnableRecommendBanner_Public_Static_Void_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getRecommendUnreadCount_Public_Static_Void_String_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_openRecommendAdArea_Public_Static_Void_String_String_Int32_Int32_Int32_Int32_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_closeRecommendAdArea_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_setRecommendAdAreaVisible_Public_Static_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_openRecommendInterstitial_Public_Static_Void_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_openRecommendPosInterstitial_Public_Static_Void_String_Int32_Int32_Int32_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_openRecommendInterstitialMovie_Public_Static_Void_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_closeRecommendInterstitial_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getExternalAdStatus_Public_Static_Void_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_showOwnAd_Public_Static_Void_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_touchOwnAd_Public_Static_Void_String_String_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_openRewardList_Public_Static_Void_String_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_isEnableRewardBanner_Public_Static_Void_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getRewardInstallableFlag_Public_Static_Void_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_setVerbose_Public_Static_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LogD_Public_Static_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LogE_Public_Static_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LogMessage_Private_Static_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UnitySendMessage_Public_Static_String_String_String_String_Il2CppStringArray_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UnitySendMessage_Public_Static_String_String_String_String_Action_1_String_Il2CppStringArray_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe static bool isInitialized
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isInitialized, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isInitialized, (void*)(&value));
			}
		}

		public unsafe static int verbose
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_verbose, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_verbose, (void*)(&value));
			}
		}

		public unsafe static string userId
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_userId, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_userId, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static Emulator()
		{
			Il2CppClassPointerStore<Emulator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, "Emulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Emulator>.NativeClassPtr);
			NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "isInitialized");
			NativeFieldInfoPtr_verbose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "verbose");
			NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Emulator>.NativeClassPtr, "userId");
			NativeMethodInfoPtr_initialize_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663435);
			NativeMethodInfoPtr_resume_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663436);
			NativeMethodInfoPtr_setUserId_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663437);
			NativeMethodInfoPtr_openRecommendList_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663438);
			NativeMethodInfoPtr_isEnableRecommendBanner_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663439);
			NativeMethodInfoPtr_getRecommendUnreadCount_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663440);
			NativeMethodInfoPtr_openRecommendAdArea_Public_Static_Void_String_String_Int32_Int32_Int32_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663441);
			NativeMethodInfoPtr_closeRecommendAdArea_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663442);
			NativeMethodInfoPtr_setRecommendAdAreaVisible_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663443);
			NativeMethodInfoPtr_openRecommendInterstitial_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663444);
			NativeMethodInfoPtr_openRecommendPosInterstitial_Public_Static_Void_String_Int32_Int32_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663445);
			NativeMethodInfoPtr_openRecommendInterstitialMovie_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663446);
			NativeMethodInfoPtr_closeRecommendInterstitial_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663447);
			NativeMethodInfoPtr_getExternalAdStatus_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663448);
			NativeMethodInfoPtr_showOwnAd_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663449);
			NativeMethodInfoPtr_touchOwnAd_Public_Static_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663450);
			NativeMethodInfoPtr_openRewardList_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663451);
			NativeMethodInfoPtr_isEnableRewardBanner_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663452);
			NativeMethodInfoPtr_getRewardInstallableFlag_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663453);
			NativeMethodInfoPtr_setVerbose_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663454);
			NativeMethodInfoPtr_LogD_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663455);
			NativeMethodInfoPtr_LogE_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663456);
			NativeMethodInfoPtr_LogMessage_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663457);
			NativeMethodInfoPtr_UnitySendMessage_Public_Static_String_String_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663458);
			NativeMethodInfoPtr_UnitySendMessage_Public_Static_String_String_String_String_Action_1_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663459);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Emulator>.NativeClassPtr, 100663460);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229518, RefRangeEnd = 1229521, XrefRangeStart = 1229467, XrefRangeEnd = 1229518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void initialize(string appliId, string env, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appliId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(env);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initialize_Public_Static_Void_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229521, XrefRangeEnd = 1229528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void resume()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resume_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229528, XrefRangeEnd = 1229549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setUserId(string id)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUserId_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229602, RefRangeEnd = 1229605, XrefRangeStart = 1229549, XrefRangeEnd = 1229602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void openRecommendList(string adModelName, string location, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(adModelName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(location);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openRecommendList_Public_Static_Void_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229636, RefRangeEnd = 1229639, XrefRangeStart = 1229605, XrefRangeEnd = 1229636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void isEnableRecommendBanner(string adModelName, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(adModelName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isEnableRecommendBanner_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229677, RefRangeEnd = 1229680, XrefRangeStart = 1229639, XrefRangeEnd = 1229677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void getRecommendUnreadCount(string adModelName, string location, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(adModelName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(location);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRecommendUnreadCount_Public_Static_Void_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229760, RefRangeEnd = 1229761, XrefRangeStart = 1229680, XrefRangeEnd = 1229760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void openRecommendAdArea(string adModelName, string location, int ml, int mt, int mr, int mb, string valign, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(adModelName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(location);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ml;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mt;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mr;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mb;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(valign);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openRecommendAdArea_Public_Static_Void_String_String_Int32_Int32_Int32_Int32_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229761, XrefRangeEnd = 1229772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void closeRecommendAdArea()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_closeRecommendAdArea_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229772, XrefRangeEnd = 1229796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setRecommendAdAreaVisible(int status)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&status);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRecommendAdAreaVisible_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229796, XrefRangeEnd = 1229806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void openRecommendInterstitial(string location, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openRecommendInterstitial_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19002)]
		[CachedScanResults(RefRangeStart = 210, RefRangeEnd = 19212, XrefRangeStart = 210, XrefRangeEnd = 19212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void openRecommendPosInterstitial(string location, int posX, int posY, int length, string valign, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posX;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(valign);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openRecommendPosInterstitial_Public_Static_Void_String_Int32_Int32_Int32_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229806, XrefRangeEnd = 1229816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void openRecommendInterstitialMovie(string location, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openRecommendInterstitialMovie_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229816, XrefRangeEnd = 1229827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void closeRecommendInterstitial()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_closeRecommendInterstitial_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19002)]
		[CachedScanResults(RefRangeStart = 210, RefRangeEnd = 19212, XrefRangeStart = 210, XrefRangeEnd = 19212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void getExternalAdStatus(string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getExternalAdStatus_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19002)]
		[CachedScanResults(RefRangeStart = 210, RefRangeEnd = 19212, XrefRangeStart = 210, XrefRangeEnd = 19212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void showOwnAd(string adLocation, string appli_id_to, string creativeId)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(adLocation);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appli_id_to);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(creativeId);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showOwnAd_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19002)]
		[CachedScanResults(RefRangeStart = 210, RefRangeEnd = 19212, XrefRangeStart = 210, XrefRangeEnd = 19212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void touchOwnAd(string adLocation, string appli_id_to, string creativeId, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(adLocation);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appli_id_to);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(creativeId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_touchOwnAd_Public_Static_Void_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229878, RefRangeEnd = 1229880, XrefRangeStart = 1229827, XrefRangeEnd = 1229878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void openRewardList(string location, string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openRewardList_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229880, XrefRangeEnd = 1229906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void isEnableRewardBanner(string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isEnableRewardBanner_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229906, XrefRangeEnd = 1229932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void getRewardInstallableFlag(string gameObjectName, string functionName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRewardInstallableFlag_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229932, XrefRangeEnd = 1229944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setVerbose(int v)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&v);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setVerbose_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229944, XrefRangeEnd = 1229947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogD(string message)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogD_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229947, XrefRangeEnd = 1229950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogE(string message)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogE_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229950, XrefRangeEnd = 1229971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LogMessage(string message)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogMessage_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1229975, RefRangeEnd = 1229991, XrefRangeStart = 1229971, XrefRangeEnd = 1229975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnitySendMessage(string gameObjectName, string functionName, string defaultValue, [Optional] Il2CppStringArray keys)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			if (keys == null)
			{
				keys = new Il2CppStringArray(0L);
			}
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnitySendMessage_Public_Static_String_String_String_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230051, RefRangeEnd = 1230053, XrefRangeStart = 1229991, XrefRangeEnd = 1230051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnitySendMessage(string gameObjectName, string functionName, string defaultValue, Il2CppSystem.Action<string> action, [Optional] Il2CppStringArray keys)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			if (keys == null)
			{
				keys = new Il2CppStringArray(0L);
			}
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnitySendMessage_Public_Static_String_String_String_String_Action_1_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1830)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Emulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Emulator>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public static string UnitySendMessage(string gameObjectName, string functionName, string defaultValue, params string[] keys)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			return UnitySendMessage(gameObjectName, functionName, defaultValue, new Il2CppStringArray(keys));
		}

		public static string UnitySendMessage(string gameObjectName, string functionName, string defaultValue, Il2CppSystem.Action<string> action, params string[] keys)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			return UnitySendMessage(gameObjectName, functionName, defaultValue, action, new Il2CppStringArray(keys));
		}

		public Emulator(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum Env
	{
		RELEASE,
		STAGING,
		DEVELOP,
		SANDBOX
	}

	public enum AdModel
	{
		RECTANGLE,
		SQUARE,
		LIST,
		INTERSTITIAL
	}

	public enum AdVerticalAlign
	{
		TOP,
		MIDDLE,
		BOTTOM
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_String_Env_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenRecommendList_Public_Static_Void_AdModel_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnableRecommendBanner_Public_Static_Void_AdModel_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecommendUnreadCount_Public_Static_Void_AdModel_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenRecommendAdArea_Public_Static_Void_AdModel_String_Int32_Int32_Int32_Int32_AdVerticalAlign_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseRecommendAdArea_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRecommendAdAreaVisible_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenRecommendInterstitial_Public_Static_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenRecommendInterstitial_Public_Static_Void_String_Int32_Int32_Int32_AdVerticalAlign_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenRecommendInterstitialMovie_Public_Static_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseRecommendInterstitial_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getExternalAdStatus_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenRewardList_Public_Static_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnableRewardBanner_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRewardInstallableFlag_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnusedInStore_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowOwnAd_Public_Static_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TouchOwnAd_Public_Static_Void_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOptIn_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConversionValue_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVerbose_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static UnityApplilinkPlugin()
	{
		Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UnityApplilinkPlugin");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_String_Env_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_Resume_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_OpenRecommendList_Public_Static_Void_AdModel_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_IsEnableRecommendBanner_Public_Static_Void_AdModel_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_GetRecommendUnreadCount_Public_Static_Void_AdModel_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_OpenRecommendAdArea_Public_Static_Void_AdModel_String_Int32_Int32_Int32_Int32_AdVerticalAlign_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_CloseRecommendAdArea_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_SetRecommendAdAreaVisible_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_OpenRecommendInterstitial_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_OpenRecommendInterstitial_Public_Static_Void_String_Int32_Int32_Int32_AdVerticalAlign_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_OpenRecommendInterstitialMovie_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_CloseRecommendInterstitial_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_getExternalAdStatus_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_OpenRewardList_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_IsEnableRewardBanner_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_GetRewardInstallableFlag_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_UnusedInStore_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_ShowOwnAd_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_TouchOwnAd_Public_Static_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_IsOptIn_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_UpdateConversionValue_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_SetVerbose_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr, 100663434);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230053, XrefRangeEnd = 1230067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(string appliId, Env env, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(appliId);
		*(Env**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &env;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_String_Env_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Resume()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resume_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230067, XrefRangeEnd = 1230091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUserId(string userId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUserId_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230091, XrefRangeEnd = 1230098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenRecommendList(AdModel adModel, string location, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&adModel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(location);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenRecommendList_Public_Static_Void_AdModel_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230098, XrefRangeEnd = 1230105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsEnableRecommendBanner(AdModel adModel, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&adModel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnableRecommendBanner_Public_Static_Void_AdModel_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230105, XrefRangeEnd = 1230112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRecommendUnreadCount(AdModel adModel, string location, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&adModel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(location);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecommendUnreadCount_Public_Static_Void_AdModel_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230112, XrefRangeEnd = 1230122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenRecommendAdArea(AdModel adModel, string location, int ml, int mt, int mr, int mb, AdVerticalAlign valign, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&adModel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(location);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ml;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mt;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mr;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mb;
		*(AdVerticalAlign**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &valign;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenRecommendAdArea_Public_Static_Void_AdModel_String_Int32_Int32_Int32_Int32_AdVerticalAlign_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230122, XrefRangeEnd = 1230136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CloseRecommendAdArea()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseRecommendAdArea_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230136, XrefRangeEnd = 1230163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRecommendAdAreaVisible(int status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRecommendAdAreaVisible_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230163, XrefRangeEnd = 1230176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenRecommendInterstitial(string location, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenRecommendInterstitial_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230176, XrefRangeEnd = 1230182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenRecommendInterstitial(string location, int posX, int posY, int length, AdVerticalAlign valign, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(AdVerticalAlign**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &valign;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenRecommendInterstitial_Public_Static_Void_String_Int32_Int32_Int32_AdVerticalAlign_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230182, XrefRangeEnd = 1230195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenRecommendInterstitialMovie(string location, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenRecommendInterstitialMovie_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230195, XrefRangeEnd = 1230209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CloseRecommendInterstitial()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseRecommendInterstitial_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230209, XrefRangeEnd = 1230212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getExternalAdStatus(string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getExternalAdStatus_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230212, XrefRangeEnd = 1230216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenRewardList(string location, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenRewardList_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230245, RefRangeEnd = 1230246, XrefRangeStart = 1230216, XrefRangeEnd = 1230245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsEnableRewardBanner(string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnableRewardBanner_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1230275, RefRangeEnd = 1230278, XrefRangeStart = 1230246, XrefRangeEnd = 1230275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRewardInstallableFlag(string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRewardInstallableFlag_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19002)]
	[CachedScanResults(RefRangeStart = 210, RefRangeEnd = 19212, XrefRangeStart = 210, XrefRangeEnd = 19212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnusedInStore()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnusedInStore_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230278, XrefRangeEnd = 1230281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowOwnAd(string adLocation, string appli_id_to, string creativeId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(adLocation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appli_id_to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(creativeId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowOwnAd_Public_Static_Void_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230281, XrefRangeEnd = 1230284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TouchOwnAd(string adLocation, string appli_id_to, string creativeId, string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(adLocation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appli_id_to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(creativeId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TouchOwnAd_Public_Static_Void_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19002)]
	[CachedScanResults(RefRangeStart = 210, RefRangeEnd = 19212, XrefRangeStart = 210, XrefRangeEnd = 19212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsOptIn(string gameObjectName, string functionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOptIn_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19002)]
	[CachedScanResults(RefRangeStart = 210, RefRangeEnd = 19212, XrefRangeStart = 210, XrefRangeEnd = 19212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateConversionValue(int conversionValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&conversionValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateConversionValue_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1230299, RefRangeEnd = 1230302, XrefRangeStart = 1230284, XrefRangeEnd = 1230299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVerbose(int v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVerbose_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1830)]
	[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityApplilinkPlugin()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityApplilinkPlugin>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnityApplilinkPlugin(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
