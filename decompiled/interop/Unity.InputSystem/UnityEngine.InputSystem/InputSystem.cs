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
using Il2CppSystem.Reflection;
using Unity.Profiling;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputSystem : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct StateEventBuffer
	{
		[StructLayout(LayoutKind.Explicit)]
		[ObfuscatedName("UnityEngine.InputSystem.InputSystem+StateEventBuffer+<data>e__FixedBuffer")]
		public struct _data_e__FixedBuffer
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

			[FieldOffset(0)]
			public byte FixedElementField;

			static _data_e__FixedBuffer()
			{
				Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateEventBuffer>.NativeClassPtr, "<data>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr);
				NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_stateEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_kMaxSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		[FieldOffset(0)]
		public StateEvent stateEvent;

		[FieldOffset(25)]
		public _data_e__FixedBuffer data;

		public unsafe static int kMaxSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxSize, (void*)(&value));
			}
		}

		static StateEventBuffer()
		{
			Il2CppClassPointerStore<StateEventBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "StateEventBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateEventBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_stateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEventBuffer>.NativeClassPtr, "stateEvent");
			NativeFieldInfoPtr_kMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEventBuffer>.NativeClassPtr, "kMaxSize");
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEventBuffer>.NativeClassPtr, "data");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StateEventBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DeltaStateEventBuffer
	{
		[StructLayout(LayoutKind.Explicit)]
		[ObfuscatedName("UnityEngine.InputSystem.InputSystem+DeltaStateEventBuffer+<data>e__FixedBuffer")]
		public struct _data_e__FixedBuffer
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

			[FieldOffset(0)]
			public byte FixedElementField;

			static _data_e__FixedBuffer()
			{
				Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeltaStateEventBuffer>.NativeClassPtr, "<data>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr);
				NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_data_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_stateEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_kMaxSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		[FieldOffset(0)]
		public DeltaStateEvent stateEvent;

		[FieldOffset(29)]
		public _data_e__FixedBuffer data;

		public unsafe static int kMaxSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxSize, (void*)(&value));
			}
		}

		static DeltaStateEventBuffer()
		{
			Il2CppClassPointerStore<DeltaStateEventBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "DeltaStateEventBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeltaStateEventBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_stateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEventBuffer>.NativeClassPtr, "stateEvent");
			NativeFieldInfoPtr_kMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEventBuffer>.NativeClassPtr, "kMaxSize");
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEventBuffer>.NativeClassPtr, "data");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeltaStateEventBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.InputSystem.InputSystem+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__80_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__80_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__get_onAnyButtonPress_b__80_0_Internal_InputControl_InputEventPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__get_onAnyButtonPress_b__80_1_Internal_Boolean_InputControl_0;

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

		public unsafe static Il2CppSystem.Func<InputEventPtr, InputControl> __9__80_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__80_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InputEventPtr, InputControl>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__80_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<InputControl, bool> __9__80_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__80_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InputControl, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__80_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__80_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__80_0");
			NativeFieldInfoPtr___9__80_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__80_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664587);
			NativeMethodInfoPtr__get_onAnyButtonPress_b__80_0_Internal_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664588);
			NativeMethodInfoPtr__get_onAnyButtonPress_b__80_1_Internal_Boolean_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664589);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971030, XrefRangeEnd = 971031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl _get_onAnyButtonPress_b__80_0(InputEventPtr e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&e);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_onAnyButtonPress_b__80_0_Internal_InputControl_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe bool _get_onAnyButtonPress_b__80_1(InputControl c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_onAnyButtonPress_b__80_1_Internal_Boolean_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_RegisterLayout_Public_Static_Void_String_Nullable_1_InputDeviceMatcher_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_String_Nullable_1_InputDeviceMatcher_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RegisterLayoutMatcher_Public_Static_Void_InputDeviceMatcher_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RegisterLayoutMatcher_Public_Static_Void_InputDeviceMatcher_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RegisterPrecompiledLayout_Public_Static_Void_String_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RegisterPrecompiledLayout_Public_Static_Void_String_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LoadLayout_Public_Static_InputControlLayout_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LoadLayout_Public_Static_InputControlLayout_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RegisterProcessor_Public_Static_Void_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RegisterProcessor_Public_Static_Void_String_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddDevice_Public_Static_TDevice_String_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddDevice_Public_Static_TDevice_String_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetDevice_Public_Static_TDevice_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetDevice_Public_Static_TDevice_InternedString_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_InternedString_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetDevice_Public_Static_TDevice_String_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_String_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindControls_Public_Static_InputControlList_1_TControl_String_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindControls_Public_Static_InputControlList_1_TControl_String_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindControls_Public_Static_Int32_String_byref_InputControlList_1_TControl_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindControls_Public_Static_Int32_String_byref_InputControlList_1_TControl_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_QueueEvent_Public_Static_Void_byref_TEvent_0<TEvent>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QueueEvent_Public_Static_Void_byref_TEvent_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEvent>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_QueueStateEvent_Public_Static_Void_InputDevice_TState_Double_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QueueStateEvent_Public_Static_Void_InputDevice_TState_Double_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_QueueDeltaStateEvent_Public_Static_Void_InputControl_TDelta_Double_0<TDelta>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QueueDeltaStateEvent_Public_Static_Void_InputControl_TDelta_Double_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelta>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RegisterInteraction_Public_Static_Void_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RegisterInteraction_Public_Static_Void_String_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RegisterBindingComposite_Public_Static_Void_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RegisterBindingComposite_Public_Static_Void_String_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kAssemblyVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDocUrl;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputResetMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Manager;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Remote;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onLayoutChange_Public_Static_add_Void_Action_2_String_InputControlLayoutChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onLayoutChange_Public_Static_rem_Void_Action_2_String_InputControlLayoutChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_Type_String_Nullable_1_InputDeviceMatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_String_Nullable_1_InputDeviceMatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_String_String_Nullable_1_InputDeviceMatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterLayoutOverride_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterLayoutMatcher_Public_Static_Void_String_InputDeviceMatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterLayoutMatcher_Public_Static_Void_InputDeviceMatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterLayoutBuilder_Public_Static_Void_Func_1_InputControlLayout_String_String_Nullable_1_InputDeviceMatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPrecompiledLayout_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLayout_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindMatchingLayout_Public_Static_String_InputDeviceDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListLayouts_Public_Static_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListLayoutsBasedOn_Public_Static_IEnumerable_1_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadLayout_Public_Static_InputControlLayout_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadLayout_Public_Static_InputControlLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNameOfBaseLayout_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFirstLayoutBasedOnSecond_Public_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterProcessor_Public_Static_Void_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterProcessor_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetProcessor_Public_Static_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListProcessors_Public_Static_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_devices_Public_Static_get_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_disconnectedDevices_Public_Static_get_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onDeviceChange_Public_Static_add_Void_Action_2_InputDevice_InputDeviceChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onDeviceChange_Public_Static_rem_Void_Action_2_InputDevice_InputDeviceChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onDeviceCommand_Public_Static_add_Void_InputDeviceCommandDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onDeviceCommand_Public_Static_rem_Void_InputDeviceCommandDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onFindLayoutForDevice_Public_Static_add_Void_InputDeviceFindControlLayoutDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onFindLayoutForDevice_Public_Static_rem_Void_InputDeviceFindControlLayoutDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pollingFrequency_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_pollingFrequency_Public_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDevice_Public_Static_InputDevice_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDevice_Public_Static_TDevice_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDevice_Public_Static_InputDevice_InputDeviceDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDevice_Public_Static_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDevice_Public_Static_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushDisconnectedDevices_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDevice_Public_Static_InputDevice_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDevice_Public_Static_InputDevice_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceById_Public_Static_InputDevice_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnsupportedDevices_Public_Static_List_1_InputDeviceDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnsupportedDevices_Public_Static_Int32_List_1_InputDeviceDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDevice_Public_Static_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableDevice_Public_Static_Void_InputDevice_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySyncDevice_Public_Static_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDevice_Public_Static_Void_InputDevice_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryResetDevice_Public_Static_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PauseHaptics_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResumeHaptics_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetHaptics_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeviceUsage_Public_Static_Void_InputDevice_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeviceUsage_Public_Static_Void_InputDevice_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDeviceUsage_Public_Static_Void_InputDevice_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDeviceUsage_Public_Static_Void_InputDevice_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDeviceUsage_Public_Static_Void_InputDevice_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDeviceUsage_Public_Static_Void_InputDevice_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControl_Public_Static_InputControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControls_Public_Static_InputControlList_1_InputControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControls_Public_Static_InputControlList_1_TControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControls_Public_Static_Int32_String_byref_InputControlList_1_TControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isProcessingEvents_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onEvent_Public_Static_get_InputEventListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onEvent_Public_Static_set_Void_InputEventListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onAnyButtonPress_Public_Static_get_IObservable_1_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueEvent_Public_Static_Void_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueEvent_Public_Static_Void_byref_TEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueStateEvent_Public_Static_Void_InputDevice_TState_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueDeltaStateEvent_Public_Static_Void_InputControl_TDelta_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueConfigChangeEvent_Public_Static_Void_InputDevice_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueTextEvent_Public_Static_Void_InputDevice_Char_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Static_Void_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onBeforeUpdate_Public_Static_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onBeforeUpdate_Public_Static_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onAfterUpdate_Public_Static_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onAfterUpdate_Public_Static_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_settings_Public_Static_get_InputSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_settings_Public_Static_set_Void_InputSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onSettingsChange_Public_Static_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onSettingsChange_Public_Static_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableActions_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableActions_Private_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actions_Public_Static_get_InputActionAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_actions_Public_Static_set_Void_InputActionAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onActionsChange_Public_Static_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onActionsChange_Public_Static_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onActionChange_Public_Static_add_Void_Action_2_Object_InputActionChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onActionChange_Public_Static_rem_Void_Action_2_Object_InputActionChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterInteraction_Public_Static_Void_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterInteraction_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInteraction_Public_Static_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListInteractions_Public_Static_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBindingComposite_Public_Static_Void_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBindingComposite_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBindingComposite_Public_Static_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableAllEnabledActions_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListEnabledActions_Public_Static_List_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListEnabledActions_Public_Static_Int32_List_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_remoting_Public_Static_get_InputRemoting_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_Version_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_runInBackground_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scrollWheelDeltaPerTick_Internal_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_metrics_Public_Static_get_InputMetrics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunInitializeInPlayer_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureInitialized_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInPlayer_Private_Static_Void_IInputRuntime_InputSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunInitialUpdate_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformDefaultPluginInitialization_Private_Static_Void_0;

	public unsafe static string kAssemblyVersion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kAssemblyVersion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kAssemblyVersion, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string kDocUrl
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDocUrl, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDocUrl, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static ProfilerMarker k_InputResetMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputResetMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputResetMarker, (void*)(&value));
		}
	}

	public unsafe static InputManager s_Manager
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Manager, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Manager, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static InputRemoting s_Remote
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Remote, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputRemoting>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Remote, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ReadOnlyArray<InputDevice> devices
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 971345, RefRangeEnd = 971354, XrefRangeStart = 971340, XrefRangeEnd = 971345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_devices_Public_Static_get_ReadOnlyArray_1_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputDevice>(pointer);
		}
	}

	public unsafe static ReadOnlyArray<InputDevice> disconnectedDevices
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971354, XrefRangeEnd = 971361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disconnectedDevices_Public_Static_get_ReadOnlyArray_1_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputDevice>(pointer);
		}
	}

	public unsafe static float pollingFrequency
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971447, XrefRangeEnd = 971451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pollingFrequency_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971451, XrefRangeEnd = 971457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pollingFrequency_Public_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool isProcessingEvents
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 971787, RefRangeEnd = 971788, XrefRangeStart = 971781, XrefRangeEnd = 971787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isProcessingEvents_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static InputEventListener onEvent
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onEvent_Public_Static_get_InputEventListener_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InputEventListener*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onEvent_Public_Static_set_Void_InputEventListener_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Il2CppSystem.IObservable<InputControl> onAnyButtonPress
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971788, XrefRangeEnd = 971829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onAnyButtonPress_Public_Static_get_IObservable_1_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObservable<InputControl>>(intPtr2) : null;
		}
	}

	public unsafe static InputSettings settings
	{
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 972050, RefRangeEnd = 972085, XrefRangeStart = 972046, XrefRangeEnd = 972050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settings_Public_Static_get_InputSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputSettings>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972085, XrefRangeEnd = 972100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_settings_Public_Static_set_Void_InputSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static InputActionAsset actions
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 972146, RefRangeEnd = 972151, XrefRangeStart = 972142, XrefRangeEnd = 972146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actions_Public_Static_get_InputActionAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972151, XrefRangeEnd = 972167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actions_Public_Static_set_Void_InputActionAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static InputRemoting remoting
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972306, XrefRangeEnd = 972310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_remoting_Public_Static_get_InputRemoting_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputRemoting>(intPtr2) : null;
		}
	}

	public unsafe static Il2CppSystem.Version version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972310, XrefRangeEnd = 972316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_version_Public_Static_get_Version_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Version>(intPtr2) : null;
		}
	}

	public unsafe static bool runInBackground
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972316, XrefRangeEnd = 972324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972324, XrefRangeEnd = 972333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_runInBackground_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static float scrollWheelDeltaPerTick
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 972339, RefRangeEnd = 972341, XrefRangeStart = 972333, XrefRangeEnd = 972339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scrollWheelDeltaPerTick_Internal_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static InputMetrics metrics
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972341, XrefRangeEnd = 972346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_metrics_Public_Static_get_InputMetrics_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InputMetrics*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputSystem()
	{
		Il2CppClassPointerStore<InputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputSystem");
		NativeFieldInfoPtr_kAssemblyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "kAssemblyVersion");
		NativeFieldInfoPtr_kDocUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "kDocUrl");
		NativeFieldInfoPtr_k_InputResetMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "k_InputResetMarker");
		NativeFieldInfoPtr_s_Manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "s_Manager");
		NativeFieldInfoPtr_s_Remote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "s_Remote");
		NativeMethodInfoPtr_add_onLayoutChange_Public_Static_add_Void_Action_2_String_InputControlLayoutChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664472);
		NativeMethodInfoPtr_remove_onLayoutChange_Public_Static_rem_Void_Action_2_String_InputControlLayoutChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664473);
		NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_Type_String_Nullable_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664474);
		NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_String_Nullable_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664475);
		NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_String_String_Nullable_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664476);
		NativeMethodInfoPtr_RegisterLayoutOverride_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664477);
		NativeMethodInfoPtr_RegisterLayoutMatcher_Public_Static_Void_String_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664478);
		NativeMethodInfoPtr_RegisterLayoutMatcher_Public_Static_Void_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664479);
		NativeMethodInfoPtr_RegisterLayoutBuilder_Public_Static_Void_Func_1_InputControlLayout_String_String_Nullable_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664480);
		NativeMethodInfoPtr_RegisterPrecompiledLayout_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664481);
		NativeMethodInfoPtr_RemoveLayout_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664482);
		NativeMethodInfoPtr_TryFindMatchingLayout_Public_Static_String_InputDeviceDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664483);
		NativeMethodInfoPtr_ListLayouts_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664484);
		NativeMethodInfoPtr_ListLayoutsBasedOn_Public_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664485);
		NativeMethodInfoPtr_LoadLayout_Public_Static_InputControlLayout_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664486);
		NativeMethodInfoPtr_LoadLayout_Public_Static_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664487);
		NativeMethodInfoPtr_GetNameOfBaseLayout_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664488);
		NativeMethodInfoPtr_IsFirstLayoutBasedOnSecond_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664489);
		NativeMethodInfoPtr_RegisterProcessor_Public_Static_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664490);
		NativeMethodInfoPtr_RegisterProcessor_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664491);
		NativeMethodInfoPtr_TryGetProcessor_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664492);
		NativeMethodInfoPtr_ListProcessors_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664493);
		NativeMethodInfoPtr_get_devices_Public_Static_get_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664494);
		NativeMethodInfoPtr_get_disconnectedDevices_Public_Static_get_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664495);
		NativeMethodInfoPtr_add_onDeviceChange_Public_Static_add_Void_Action_2_InputDevice_InputDeviceChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664496);
		NativeMethodInfoPtr_remove_onDeviceChange_Public_Static_rem_Void_Action_2_InputDevice_InputDeviceChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664497);
		NativeMethodInfoPtr_add_onDeviceCommand_Public_Static_add_Void_InputDeviceCommandDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664498);
		NativeMethodInfoPtr_remove_onDeviceCommand_Public_Static_rem_Void_InputDeviceCommandDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664499);
		NativeMethodInfoPtr_add_onFindLayoutForDevice_Public_Static_add_Void_InputDeviceFindControlLayoutDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664500);
		NativeMethodInfoPtr_remove_onFindLayoutForDevice_Public_Static_rem_Void_InputDeviceFindControlLayoutDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_get_pollingFrequency_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_set_pollingFrequency_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664503);
		NativeMethodInfoPtr_AddDevice_Public_Static_InputDevice_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664504);
		NativeMethodInfoPtr_AddDevice_Public_Static_TDevice_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664505);
		NativeMethodInfoPtr_AddDevice_Public_Static_InputDevice_InputDeviceDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664506);
		NativeMethodInfoPtr_AddDevice_Public_Static_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664507);
		NativeMethodInfoPtr_RemoveDevice_Public_Static_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664508);
		NativeMethodInfoPtr_FlushDisconnectedDevices_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664509);
		NativeMethodInfoPtr_GetDevice_Public_Static_InputDevice_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664510);
		NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664511);
		NativeMethodInfoPtr_GetDevice_Public_Static_InputDevice_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664512);
		NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664513);
		NativeMethodInfoPtr_GetDevice_Public_Static_TDevice_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664514);
		NativeMethodInfoPtr_GetDeviceById_Public_Static_InputDevice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664515);
		NativeMethodInfoPtr_GetUnsupportedDevices_Public_Static_List_1_InputDeviceDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664516);
		NativeMethodInfoPtr_GetUnsupportedDevices_Public_Static_Int32_List_1_InputDeviceDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_EnableDevice_Public_Static_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_DisableDevice_Public_Static_Void_InputDevice_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_TrySyncDevice_Public_Static_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_ResetDevice_Public_Static_Void_InputDevice_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr_TryResetDevice_Public_Static_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664522);
		NativeMethodInfoPtr_PauseHaptics_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_ResumeHaptics_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_ResetHaptics_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664525);
		NativeMethodInfoPtr_SetDeviceUsage_Public_Static_Void_InputDevice_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664526);
		NativeMethodInfoPtr_SetDeviceUsage_Public_Static_Void_InputDevice_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664527);
		NativeMethodInfoPtr_AddDeviceUsage_Public_Static_Void_InputDevice_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664528);
		NativeMethodInfoPtr_AddDeviceUsage_Public_Static_Void_InputDevice_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664529);
		NativeMethodInfoPtr_RemoveDeviceUsage_Public_Static_Void_InputDevice_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664530);
		NativeMethodInfoPtr_RemoveDeviceUsage_Public_Static_Void_InputDevice_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664531);
		NativeMethodInfoPtr_FindControl_Public_Static_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664532);
		NativeMethodInfoPtr_FindControls_Public_Static_InputControlList_1_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_FindControls_Public_Static_InputControlList_1_TControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_FindControls_Public_Static_Int32_String_byref_InputControlList_1_TControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_get_isProcessingEvents_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_get_onEvent_Public_Static_get_InputEventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_set_onEvent_Public_Static_set_Void_InputEventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_get_onAnyButtonPress_Public_Static_get_IObservable_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_QueueEvent_Public_Static_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_QueueEvent_Public_Static_Void_byref_TEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_QueueStateEvent_Public_Static_Void_InputDevice_TState_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_QueueDeltaStateEvent_Public_Static_Void_InputControl_TDelta_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_QueueConfigChangeEvent_Public_Static_Void_InputDevice_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_QueueTextEvent_Public_Static_Void_InputDevice_Char_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664546);
		NativeMethodInfoPtr_Update_Internal_Static_Void_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr_add_onBeforeUpdate_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_remove_onBeforeUpdate_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_add_onAfterUpdate_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_remove_onAfterUpdate_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr_get_settings_Public_Static_get_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_set_settings_Public_Static_set_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr_add_onSettingsChange_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664554);
		NativeMethodInfoPtr_remove_onSettingsChange_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr_EnableActions_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664556);
		NativeMethodInfoPtr_DisableActions_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_get_actions_Public_Static_get_InputActionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_set_actions_Public_Static_set_Void_InputActionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664559);
		NativeMethodInfoPtr_add_onActionsChange_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664560);
		NativeMethodInfoPtr_remove_onActionsChange_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_add_onActionChange_Public_Static_add_Void_Action_2_Object_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_remove_onActionChange_Public_Static_rem_Void_Action_2_Object_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664563);
		NativeMethodInfoPtr_RegisterInteraction_Public_Static_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664564);
		NativeMethodInfoPtr_RegisterInteraction_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664565);
		NativeMethodInfoPtr_TryGetInteraction_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664566);
		NativeMethodInfoPtr_ListInteractions_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664567);
		NativeMethodInfoPtr_RegisterBindingComposite_Public_Static_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664568);
		NativeMethodInfoPtr_RegisterBindingComposite_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664569);
		NativeMethodInfoPtr_TryGetBindingComposite_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664570);
		NativeMethodInfoPtr_DisableAllEnabledActions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664571);
		NativeMethodInfoPtr_ListEnabledActions_Public_Static_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664572);
		NativeMethodInfoPtr_ListEnabledActions_Public_Static_Int32_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664573);
		NativeMethodInfoPtr_get_remoting_Public_Static_get_InputRemoting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664574);
		NativeMethodInfoPtr_get_version_Public_Static_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664575);
		NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664576);
		NativeMethodInfoPtr_set_runInBackground_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664577);
		NativeMethodInfoPtr_get_scrollWheelDeltaPerTick_Internal_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664578);
		NativeMethodInfoPtr_get_metrics_Public_Static_get_InputMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664579);
		NativeMethodInfoPtr_RunInitializeInPlayer_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664581);
		NativeMethodInfoPtr_EnsureInitialized_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664582);
		NativeMethodInfoPtr_InitializeInPlayer_Private_Static_Void_IInputRuntime_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr_RunInitialUpdate_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664584);
		NativeMethodInfoPtr_PerformDefaultPluginInitialization_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100664585);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971031, XrefRangeEnd = 971043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onLayoutChange(Il2CppSystem.Action<string, InputControlLayoutChange> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onLayoutChange_Public_Static_add_Void_Action_2_String_InputControlLayoutChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971043, XrefRangeEnd = 971055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onLayoutChange(Il2CppSystem.Action<string, InputControlLayoutChange> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onLayoutChange_Public_Static_rem_Void_Action_2_String_InputControlLayoutChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971072, RefRangeEnd = 971073, XrefRangeStart = 971055, XrefRangeEnd = 971072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterLayout(Il2CppSystem.Type type, string name = null, Il2CppSystem.Nullable<InputDeviceMatcher> matches = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_Type_String_Nullable_1_InputDeviceMatcher_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 971081, RefRangeEnd = 971113, XrefRangeStart = 971073, XrefRangeEnd = 971081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterLayout<T>(string name = null, Il2CppSystem.Nullable<InputDeviceMatcher> matches = null) where T : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RegisterLayout_Public_Static_Void_String_Nullable_1_InputDeviceMatcher_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971126, RefRangeEnd = 971128, XrefRangeStart = 971113, XrefRangeEnd = 971126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterLayout(string json, string name = null, Il2CppSystem.Nullable<InputDeviceMatcher> matches = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterLayout_Public_Static_Void_String_String_Nullable_1_InputDeviceMatcher_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971128, XrefRangeEnd = 971133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterLayoutOverride(string json, string name = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterLayoutOverride_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971133, XrefRangeEnd = 971139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matcher));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterLayoutMatcher_Public_Static_Void_String_InputDeviceMatcher_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 971149, RefRangeEnd = 971168, XrefRangeStart = 971139, XrefRangeEnd = 971149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher) where TDevice : InputDevice
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matcher));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RegisterLayoutMatcher_Public_Static_Void_InputDeviceMatcher_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971182, RefRangeEnd = 971184, XrefRangeStart = 971168, XrefRangeEnd = 971182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterLayoutBuilder(Il2CppSystem.Func<InputControlLayout> buildMethod, string name, string baseLayout = null, Il2CppSystem.Nullable<InputDeviceMatcher> matches = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(baseLayout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterLayoutBuilder_Public_Static_Void_Func_1_InputControlLayout_String_String_Nullable_1_InputDeviceMatcher_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971184, XrefRangeEnd = 971191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterPrecompiledLayout<TDevice>(string metadata) where TDevice : InputDevice, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(metadata);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RegisterPrecompiledLayout_Public_Static_Void_String_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971197, RefRangeEnd = 971198, XrefRangeStart = 971191, XrefRangeEnd = 971197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveLayout(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveLayout_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971198, XrefRangeEnd = 971204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TryFindMatchingLayout(InputDeviceDescription deviceDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deviceDescription));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindMatchingLayout_Public_Static_String_InputDeviceDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971204, XrefRangeEnd = 971210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<string> ListLayouts()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListLayouts_Public_Static_IEnumerable_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971210, XrefRangeEnd = 971223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<string> ListLayoutsBasedOn(string baseLayout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(baseLayout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListLayoutsBasedOn_Public_Static_IEnumerable_1_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971230, RefRangeEnd = 971232, XrefRangeStart = 971223, XrefRangeEnd = 971230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlLayout LoadLayout(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadLayout_Public_Static_InputControlLayout_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971232, XrefRangeEnd = 971242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlLayout LoadLayout<TControl>() where TControl : InputControl
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LoadLayout_Public_Static_InputControlLayout_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971242, XrefRangeEnd = 971251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNameOfBaseLayout(string layoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNameOfBaseLayout_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971251, XrefRangeEnd = 971261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(firstLayoutName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(secondLayoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFirstLayoutBasedOnSecond_Public_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971311, RefRangeEnd = 971313, XrefRangeStart = 971261, XrefRangeEnd = 971311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterProcessor(Il2CppSystem.Type type, string name = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterProcessor_Public_Static_Void_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971313, XrefRangeEnd = 971328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterProcessor<T>(string name = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RegisterProcessor_Public_Static_Void_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971334, RefRangeEnd = 971335, XrefRangeStart = 971328, XrefRangeEnd = 971334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type TryGetProcessor(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetProcessor_Public_Static_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971335, XrefRangeEnd = 971340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<string> ListProcessors()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListProcessors_Public_Static_IEnumerable_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
	}

	[SpecialName]
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 971373, RefRangeEnd = 971379, XrefRangeStart = 971361, XrefRangeEnd = 971373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onDeviceChange(Il2CppSystem.Action<InputDevice, InputDeviceChange> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onDeviceChange_Public_Static_add_Void_Action_2_InputDevice_InputDeviceChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 971391, RefRangeEnd = 971397, XrefRangeStart = 971379, XrefRangeEnd = 971391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onDeviceChange(Il2CppSystem.Action<InputDevice, InputDeviceChange> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onDeviceChange_Public_Static_rem_Void_Action_2_InputDevice_InputDeviceChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971397, XrefRangeEnd = 971409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onDeviceCommand(InputDeviceCommandDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onDeviceCommand_Public_Static_add_Void_InputDeviceCommandDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971409, XrefRangeEnd = 971421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onDeviceCommand(InputDeviceCommandDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onDeviceCommand_Public_Static_rem_Void_InputDeviceCommandDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971433, RefRangeEnd = 971435, XrefRangeStart = 971421, XrefRangeEnd = 971433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onFindLayoutForDevice_Public_Static_add_Void_InputDeviceFindControlLayoutDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971435, XrefRangeEnd = 971447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onFindLayoutForDevice_Public_Static_rem_Void_InputDeviceFindControlLayoutDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971464, RefRangeEnd = 971466, XrefRangeStart = 971457, XrefRangeEnd = 971464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputDevice AddDevice(string layout, string name = null, string variants = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(layout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(variants);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDevice_Public_Static_InputDevice_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971477, RefRangeEnd = 971478, XrefRangeStart = 971466, XrefRangeEnd = 971477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TDevice AddDevice<TDevice>(string name = null) where TDevice : InputDevice
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddDevice_Public_Static_TDevice_String_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TDevice>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971478, XrefRangeEnd = 971484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputDevice AddDevice(InputDeviceDescription description)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)description));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDevice_Public_Static_InputDevice_InputDeviceDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971496, RefRangeEnd = 971498, XrefRangeStart = 971484, XrefRangeEnd = 971496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDevice_Public_Static_Void_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 971504, RefRangeEnd = 971508, XrefRangeStart = 971498, XrefRangeEnd = 971504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDevice_Public_Static_Void_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971508, XrefRangeEnd = 971514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlushDisconnectedDevices()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushDisconnectedDevices_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971520, RefRangeEnd = 971521, XrefRangeStart = 971514, XrefRangeEnd = 971520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputDevice GetDevice(string nameOrLayout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(nameOrLayout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDevice_Public_Static_InputDevice_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971521, XrefRangeEnd = 971530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TDevice GetDevice<TDevice>() where TDevice : InputDevice
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetDevice_Public_Static_TDevice_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TDevice>(intPtr2, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971555, RefRangeEnd = 971557, XrefRangeStart = 971530, XrefRangeEnd = 971555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputDevice GetDevice(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDevice_Public_Static_InputDevice_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 971584, RefRangeEnd = 971587, XrefRangeStart = 971557, XrefRangeEnd = 971584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TDevice GetDevice<TDevice>(InternedString usage) where TDevice : InputDevice
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usage));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetDevice_Public_Static_TDevice_InternedString_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TDevice>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971587, XrefRangeEnd = 971593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TDevice GetDevice<TDevice>(string usage) where TDevice : InputDevice
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(usage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetDevice_Public_Static_TDevice_String_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TDevice>(intPtr2, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 971599, RefRangeEnd = 971601, XrefRangeStart = 971593, XrefRangeEnd = 971599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputDevice GetDeviceById(int deviceId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deviceId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeviceById_Public_Static_InputDevice_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971601, XrefRangeEnd = 971615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<InputDeviceDescription> GetUnsupportedDevices()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnsupportedDevices_Public_Static_List_1_InputDeviceDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputDeviceDescription>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971615, XrefRangeEnd = 971621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)descriptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnsupportedDevices_Public_Static_Int32_List_1_InputDeviceDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 971626, RefRangeEnd = 971630, XrefRangeStart = 971621, XrefRangeEnd = 971626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDevice_Public_Static_Void_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 971635, RefRangeEnd = 971638, XrefRangeStart = 971630, XrefRangeEnd = 971635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableDevice(InputDevice device, bool keepSendingEvents = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepSendingEvents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableDevice_Public_Static_Void_InputDevice_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971638, XrefRangeEnd = 971643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TrySyncDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrySyncDevice_Public_Static_Boolean_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971643, XrefRangeEnd = 971648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alsoResetDontResetControls;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDevice_Public_Static_Void_InputDevice_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971648, XrefRangeEnd = 971653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryResetDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryResetDevice_Public_Static_Boolean_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971653, XrefRangeEnd = 971670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PauseHaptics()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PauseHaptics_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971670, XrefRangeEnd = 971687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResumeHaptics()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResumeHaptics_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971687, XrefRangeEnd = 971704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetHaptics()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetHaptics_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971704, XrefRangeEnd = 971713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDeviceUsage(InputDevice device, string usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(usage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeviceUsage_Public_Static_Void_InputDevice_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971718, RefRangeEnd = 971719, XrefRangeStart = 971713, XrefRangeEnd = 971718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDeviceUsage(InputDevice device, InternedString usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usage));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeviceUsage_Public_Static_Void_InputDevice_InternedString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971725, RefRangeEnd = 971726, XrefRangeStart = 971719, XrefRangeEnd = 971725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddDeviceUsage(InputDevice device, string usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(usage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDeviceUsage_Public_Static_Void_InputDevice_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971726, XrefRangeEnd = 971731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddDeviceUsage(InputDevice device, InternedString usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usage));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDeviceUsage_Public_Static_Void_InputDevice_InternedString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971731, XrefRangeEnd = 971737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDeviceUsage(InputDevice device, string usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(usage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDeviceUsage_Public_Static_Void_InputDevice_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971737, XrefRangeEnd = 971742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDeviceUsage(InputDevice device, InternedString usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usage));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDeviceUsage_Public_Static_Void_InputDevice_InternedString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971742, XrefRangeEnd = 971755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControl FindControl(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControl_Public_Static_InputControl_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971761, RefRangeEnd = 971762, XrefRangeStart = 971755, XrefRangeEnd = 971761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlList<InputControl> FindControls(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControls_Public_Static_InputControlList_1_InputControl_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlList<InputControl>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971772, RefRangeEnd = 971773, XrefRangeStart = 971762, XrefRangeEnd = 971772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlList<TControl> FindControls<TControl>(string path) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindControls_Public_Static_InputControlList_1_TControl_String_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlList<TControl>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971780, RefRangeEnd = 971781, XrefRangeStart = 971773, XrefRangeEnd = 971780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindControls<TControl>(string path, ref InputControlList<TControl> controls) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controls);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindControls_Public_Static_Int32_String_byref_InputControlList_1_TControl_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 971835, RefRangeEnd = 971839, XrefRangeStart = 971829, XrefRangeEnd = 971835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueEvent(InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueEvent_Public_Static_Void_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971839, XrefRangeEnd = 971868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueEvent<TEvent>(ref TEvent inputEvent) where TEvent : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TEvent, object>(ref inputEvent));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QueueEvent_Public_Static_Void_byref_TEvent_0<TEvent>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TEvent, object>(ref inputEvent) = ((intPtr4 == (System.IntPtr)0) ? ((TEvent)null) : IL2CPP.PointerToValueGeneric<TEvent>(intPtr4, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 971887, RefRangeEnd = 971888, XrefRangeStart = 971868, XrefRangeEnd = 971887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueStateEvent<TState>(InputDevice device, TState state, double time = -1.0) where TState : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TState reference;
		if (!typeof(TState).IsValueType)
		{
			object obj = state;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref state;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QueueStateEvent_Public_Static_Void_InputDevice_TState_Double_0<TState>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971888, XrefRangeEnd = 971914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1.0) where TDelta : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TDelta reference;
		if (!typeof(TDelta).IsValueType)
		{
			object obj = delta;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref delta;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QueueDeltaStateEvent_Public_Static_Void_InputControl_TDelta_Double_0<TDelta>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971914, XrefRangeEnd = 971928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueConfigChangeEvent(InputDevice device, double time = -1.0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueConfigChangeEvent_Public_Static_Void_InputDevice_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971928, XrefRangeEnd = 971942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueTextEvent(InputDevice device, char character, double time = -1.0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &character;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueTextEvent_Public_Static_Void_InputDevice_Char_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971942, XrefRangeEnd = 971954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971954, XrefRangeEnd = 971978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update(InputUpdateType updateType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Static_Void_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 971990, RefRangeEnd = 971995, XrefRangeStart = 971978, XrefRangeEnd = 971990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onBeforeUpdate(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onBeforeUpdate_Public_Static_add_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 972007, RefRangeEnd = 972012, XrefRangeStart = 971995, XrefRangeEnd = 972007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onBeforeUpdate(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onBeforeUpdate_Public_Static_rem_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 972024, RefRangeEnd = 972028, XrefRangeStart = 972012, XrefRangeEnd = 972024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onAfterUpdate(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onAfterUpdate_Public_Static_add_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 972040, RefRangeEnd = 972046, XrefRangeStart = 972028, XrefRangeEnd = 972040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onAfterUpdate(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onAfterUpdate_Public_Static_rem_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972106, RefRangeEnd = 972107, XrefRangeStart = 972100, XrefRangeEnd = 972106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onSettingsChange(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onSettingsChange_Public_Static_add_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972113, RefRangeEnd = 972114, XrefRangeStart = 972107, XrefRangeEnd = 972113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onSettingsChange(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onSettingsChange_Public_Static_rem_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972114, XrefRangeEnd = 972129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableActions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableActions_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972129, XrefRangeEnd = 972142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableActions(bool triggerSetupChanged = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&triggerSetupChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableActions_Private_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972173, RefRangeEnd = 972174, XrefRangeStart = 972167, XrefRangeEnd = 972173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onActionsChange(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onActionsChange_Public_Static_add_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972180, RefRangeEnd = 972181, XrefRangeStart = 972174, XrefRangeEnd = 972180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onActionsChange(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onActionsChange_Public_Static_rem_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 972194, RefRangeEnd = 972197, XrefRangeStart = 972181, XrefRangeEnd = 972194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onActionChange(Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onActionChange_Public_Static_add_Void_Action_2_Object_InputActionChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 972210, RefRangeEnd = 972214, XrefRangeStart = 972197, XrefRangeEnd = 972210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onActionChange(Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onActionChange_Public_Static_rem_Void_Action_2_Object_InputActionChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 972228, RefRangeEnd = 972230, XrefRangeStart = 972214, XrefRangeEnd = 972228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterInteraction(Il2CppSystem.Type type, string name = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterInteraction_Public_Static_Void_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972230, XrefRangeEnd = 972238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterInteraction<T>(string name = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RegisterInteraction_Public_Static_Void_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972238, XrefRangeEnd = 972244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type TryGetInteraction(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetInteraction_Public_Static_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972244, XrefRangeEnd = 972249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<string> ListInteractions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListInteractions_Public_Static_IEnumerable_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 972263, RefRangeEnd = 972265, XrefRangeStart = 972249, XrefRangeEnd = 972263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterBindingComposite(Il2CppSystem.Type type, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterBindingComposite_Public_Static_Void_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972265, XrefRangeEnd = 972273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterBindingComposite<T>(string name = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RegisterBindingComposite_Public_Static_Void_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972273, XrefRangeEnd = 972279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type TryGetBindingComposite(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetBindingComposite_Public_Static_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972279, XrefRangeEnd = 972283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableAllEnabledActions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableAllEnabledActions_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972283, XrefRangeEnd = 972296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<InputAction> ListEnabledActions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListEnabledActions_Public_Static_List_1_InputAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputAction>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972296, XrefRangeEnd = 972306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ListEnabledActions(List<InputAction> actions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListEnabledActions_Public_Static_Int32_List_1_InputAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972346, XrefRangeEnd = 972352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunInitializeInPlayer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunInitializeInPlayer_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureInitialized()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureInitialized_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 972404, RefRangeEnd = 972406, XrefRangeStart = 972352, XrefRangeEnd = 972404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)runtime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInPlayer_Private_Static_Void_IInputRuntime_InputSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972406, XrefRangeEnd = 972415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunInitialUpdate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunInitialUpdate_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972415, XrefRangeEnd = 972421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PerformDefaultPluginInitialization()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformDefaultPluginInitialization_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
