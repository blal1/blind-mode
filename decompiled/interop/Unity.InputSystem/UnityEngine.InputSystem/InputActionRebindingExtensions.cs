using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputActionRebindingExtensions : Il2CppSystem.Object
{
	public sealed class Parameter : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instance;

		private static readonly System.IntPtr NativeFieldInfoPtr_field;

		private static readonly System.IntPtr NativeFieldInfoPtr_bindingIndex;

		public unsafe Il2CppSystem.Object instance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instance);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe FieldInfo field
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int bindingIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindingIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindingIndex)) = value;
			}
		}

		static Parameter()
		{
			Il2CppClassPointerStore<Parameter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parameter>.NativeClassPtr);
			NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "instance");
			NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "field");
			NativeFieldInfoPtr_bindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "bindingIndex");
		}

		public Parameter(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Parameter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parameter>.NativeClassPtr))
		{
		}
	}

	public sealed class ParameterEnumerable : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_State;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Parameter;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MapIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputActionState_ParameterOverride_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_ParameterEnumerator_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputActionRebindingExtensions_Parameter__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Parameter_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		public unsafe InputActionState m_State
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionState>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ParameterOverride m_Parameter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Parameter);
				return new ParameterOverride(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Parameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int m_MapIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MapIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MapIndex)) = value;
			}
		}

		static ParameterEnumerable()
		{
			Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "ParameterEnumerable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr);
			NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr, "m_State");
			NativeFieldInfoPtr_m_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr, "m_Parameter");
			NativeFieldInfoPtr_m_MapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr, "m_MapIndex");
			NativeMethodInfoPtr__ctor_Public_Void_InputActionState_ParameterOverride_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr, 100663862);
			NativeMethodInfoPtr_GetEnumerator_Public_ParameterEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr, 100663863);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputActionRebindingExtensions_Parameter__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr, 100663864);
			NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr, 100663865);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965932, XrefRangeEnd = 965934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterEnumerable(InputActionState state, ParameterOverride parameter, int mapIndex = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parameter));
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputActionState_ParameterOverride_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 965936, RefRangeEnd = 965940, XrefRangeStart = 965934, XrefRangeEnd = 965936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_ParameterEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParameterEnumerator(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965940, XrefRangeEnd = 965944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<Parameter> System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputActionRebindingExtensions_Parameter__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputActionRebindingExtensions_Parameter__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Parameter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<Parameter>>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965944, XrefRangeEnd = 965948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		public ParameterEnumerable(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ParameterEnumerable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterEnumerable>.NativeClassPtr))
		{
		}
	}

	public sealed class ParameterEnumerator : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_State;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MapIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingCurrentIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingEndIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InteractionCurrentIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InteractionEndIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ProcessorCurrentIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ProcessorEndIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectType;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ParameterName;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MayBeInteraction;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MayBeProcessor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MayBeComposite;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentBindingIsComposite;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentParameter;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputActionState_ParameterOverride_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveToNextBinding_Private_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveToNextInteraction_Private_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveToNextProcessor_Private_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindParameter_Private_Boolean_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Parameter_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		public unsafe InputActionState m_State
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionState>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_MapIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MapIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MapIndex)) = value;
			}
		}

		public unsafe int m_BindingCurrentIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingCurrentIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingCurrentIndex)) = value;
			}
		}

		public unsafe int m_BindingEndIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingEndIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingEndIndex)) = value;
			}
		}

		public unsafe int m_InteractionCurrentIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InteractionCurrentIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InteractionCurrentIndex)) = value;
			}
		}

		public unsafe int m_InteractionEndIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InteractionEndIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InteractionEndIndex)) = value;
			}
		}

		public unsafe int m_ProcessorCurrentIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessorCurrentIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessorCurrentIndex)) = value;
			}
		}

		public unsafe int m_ProcessorEndIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessorEndIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessorEndIndex)) = value;
			}
		}

		public unsafe InputBinding m_BindingMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingMask);
				return new InputBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingMask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Type m_ObjectType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectType);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string m_ParameterName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParameterName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParameterName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe bool m_MayBeInteraction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MayBeInteraction);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MayBeInteraction)) = value;
			}
		}

		public unsafe bool m_MayBeProcessor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MayBeProcessor);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MayBeProcessor)) = value;
			}
		}

		public unsafe bool m_MayBeComposite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MayBeComposite);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MayBeComposite)) = value;
			}
		}

		public unsafe bool m_CurrentBindingIsComposite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBindingIsComposite);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBindingIsComposite)) = value;
			}
		}

		public unsafe Il2CppSystem.Object m_CurrentObject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentObject);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe FieldInfo m_CurrentParameter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentParameter);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentParameter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe virtual Parameter Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966014, XrefRangeEnd = 966016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Parameter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Parameter(pointer);
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966016, XrefRangeEnd = 966021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
		}

		static ParameterEnumerator()
		{
			Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "ParameterEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr);
			NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_State");
			NativeFieldInfoPtr_m_MapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_MapIndex");
			NativeFieldInfoPtr_m_BindingCurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_BindingCurrentIndex");
			NativeFieldInfoPtr_m_BindingEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_BindingEndIndex");
			NativeFieldInfoPtr_m_InteractionCurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_InteractionCurrentIndex");
			NativeFieldInfoPtr_m_InteractionEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_InteractionEndIndex");
			NativeFieldInfoPtr_m_ProcessorCurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_ProcessorCurrentIndex");
			NativeFieldInfoPtr_m_ProcessorEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_ProcessorEndIndex");
			NativeFieldInfoPtr_m_BindingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_BindingMask");
			NativeFieldInfoPtr_m_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_ObjectType");
			NativeFieldInfoPtr_m_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_ParameterName");
			NativeFieldInfoPtr_m_MayBeInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_MayBeInteraction");
			NativeFieldInfoPtr_m_MayBeProcessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_MayBeProcessor");
			NativeFieldInfoPtr_m_MayBeComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_MayBeComposite");
			NativeFieldInfoPtr_m_CurrentBindingIsComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_CurrentBindingIsComposite");
			NativeFieldInfoPtr_m_CurrentObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_CurrentObject");
			NativeFieldInfoPtr_m_CurrentParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, "m_CurrentParameter");
			NativeMethodInfoPtr__ctor_Public_Void_InputActionState_ParameterOverride_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663866);
			NativeMethodInfoPtr_MoveToNextBinding_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663867);
			NativeMethodInfoPtr_MoveToNextInteraction_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663868);
			NativeMethodInfoPtr_MoveToNextProcessor_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663869);
			NativeMethodInfoPtr_FindParameter_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663870);
			NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663871);
			NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663872);
			NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Parameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663873);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663874);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr, 100663875);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 965982, RefRangeEnd = 965983, XrefRangeStart = 965948, XrefRangeEnd = 965982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterEnumerator(InputActionState state, ParameterOverride parameter, int mapIndex = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parameter));
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputActionState_ParameterOverride_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965983, XrefRangeEnd = 965993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextBinding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToNextBinding_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965993, XrefRangeEnd = 965994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToNextInteraction_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965994, XrefRangeEnd = 965995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextProcessor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToNextProcessor_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 966002, RefRangeEnd = 966005, XrefRangeStart = 965995, XrefRangeEnd = 966002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FindParameter(Il2CppSystem.Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindParameter_Private_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966006, RefRangeEnd = 966008, XrefRangeStart = 966005, XrefRangeEnd = 966006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966013, RefRangeEnd = 966014, XrefRangeStart = 966008, XrefRangeEnd = 966013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ParameterEnumerator(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ParameterEnumerator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterEnumerator>.NativeClassPtr))
		{
		}
	}

	public sealed class ParameterOverride : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_objectRegistrationName;

		private static readonly System.IntPtr NativeFieldInfoPtr_parameter;

		private static readonly System.IntPtr NativeFieldInfoPtr_bindingMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_objectType_Public_get_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputBinding_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_InputBinding_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Static_Nullable_1_ParameterOverride_InputActionMap_byref_InputBinding_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Find_Private_Static_Nullable_1_ParameterOverride_Il2CppReferenceArray_1_ParameterOverride_Int32_byref_InputBinding_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PickMoreSpecificOne_Private_Static_Nullable_1_ParameterOverride_Nullable_1_ParameterOverride_Nullable_1_ParameterOverride_0;

		public unsafe string objectRegistrationName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectRegistrationName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectRegistrationName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string parameter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameter);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameter)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe InputBinding bindingMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindingMask);
				return new InputBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindingMask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe PrimitiveValue value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
				return *(PrimitiveValue*)num;
			}
			set
			{
				*(PrimitiveValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = value;
			}
		}

		public unsafe Il2CppSystem.Type objectType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 966030, RefRangeEnd = 966031, XrefRangeStart = 966021, XrefRangeEnd = 966030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_objectType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
			}
		}

		static ParameterOverride()
		{
			Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "ParameterOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr);
			NativeFieldInfoPtr_objectRegistrationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, "objectRegistrationName");
			NativeFieldInfoPtr_parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, "parameter");
			NativeFieldInfoPtr_bindingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, "bindingMask");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, "value");
			NativeMethodInfoPtr_get_objectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663876);
			NativeMethodInfoPtr__ctor_Public_Void_String_InputBinding_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663877);
			NativeMethodInfoPtr__ctor_Public_Void_String_String_InputBinding_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663878);
			NativeMethodInfoPtr_Find_Public_Static_Nullable_1_ParameterOverride_InputActionMap_byref_InputBinding_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663879);
			NativeMethodInfoPtr_Find_Private_Static_Nullable_1_ParameterOverride_Il2CppReferenceArray_1_ParameterOverride_Int32_byref_InputBinding_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663880);
			NativeMethodInfoPtr_PickMoreSpecificOne_Private_Static_Nullable_1_ParameterOverride_Nullable_1_ParameterOverride_Nullable_1_ParameterOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr, 100663881);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966031, XrefRangeEnd = 966039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterOverride(string parameterName, InputBinding bindingMask, PrimitiveValue value = default(PrimitiveValue))
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
			*(PrimitiveValue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_InputBinding_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966042, RefRangeEnd = 966043, XrefRangeStart = 966039, XrefRangeEnd = 966042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterOverride(string objectRegistrationName, string parameterName, InputBinding bindingMask, PrimitiveValue value = default(PrimitiveValue))
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectRegistrationName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
			*(PrimitiveValue**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_InputBinding_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966051, RefRangeEnd = 966052, XrefRangeStart = 966043, XrefRangeEnd = 966051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppSystem.Nullable<ParameterOverride> Find(InputActionMap actionMap, ref InputBinding binding, string parameterName, string objectRegistrationName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)binding);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectRegistrationName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Find_Public_Static_Nullable_1_ParameterOverride_InputActionMap_byref_InputBinding_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<ParameterOverride>(pointer);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 966063, RefRangeEnd = 966067, XrefRangeStart = 966052, XrefRangeEnd = 966063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppSystem.Nullable<ParameterOverride> Find(Il2CppReferenceArray<ParameterOverride> overrides, int overrideCount, ref InputBinding binding, string parameterName, string objectRegistrationName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrides);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &overrideCount;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)binding);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectRegistrationName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Find_Private_Static_Nullable_1_ParameterOverride_Il2CppReferenceArray_1_ParameterOverride_Int32_byref_InputBinding_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<ParameterOverride>(pointer);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 966098, RefRangeEnd = 966101, XrefRangeStart = 966067, XrefRangeEnd = 966098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppSystem.Nullable<ParameterOverride> PickMoreSpecificOne(Il2CppSystem.Nullable<ParameterOverride> first, Il2CppSystem.Nullable<ParameterOverride> second)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)first));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)second));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickMoreSpecificOne_Private_Static_Nullable_1_ParameterOverride_Nullable_1_ParameterOverride_Nullable_1_ParameterOverride_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<ParameterOverride>(pointer);
		}

		public ParameterOverride(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ParameterOverride()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterOverride>.NativeClassPtr))
		{
		}
	}

	public sealed class RebindingOperation : Il2CppSystem.Object
	{
		[OriginalName("Unity.InputSystem.dll", "", "Flags")]
		[System.Flags]
		public enum Flags
		{
			Started = 1,
			Completed = 2,
			Canceled = 4,
			OnEventHooked = 8,
			OnAfterUpdateHooked = 0x10,
			DontIgnoreNoisyControls = 0x40,
			DontGeneralizePathOfSelectedControl = 0x80,
			AddNewBinding = 0x100,
			SuppressMatchingEvents = 0x200
		}

		[ObfuscatedName("UnityEngine.InputSystem.InputActionRebindingExtensions+RebindingOperation+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_group;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__WithTargetBinding_b__0_Internal_Boolean_InputControlScheme_0;

			public unsafe string group
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr);
				NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "group");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, 100663940);
				NativeMethodInfoPtr__WithTargetBinding_b__0_Internal_Boolean_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, 100663941);
			}

			[CallerCount(1950)]
			[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966101, XrefRangeEnd = 966103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _WithTargetBinding_b__0(InputControlScheme x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WithTargetBinding_b__0_Internal_Boolean_InputControlScheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public __c__DisplayClass32_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private sealed class MethodInfoStoreGeneric_WithExpectedControlType_Public_RebindingOperation_0<TControl>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_0, Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultMagnitudeThreshold;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionToRebind;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlType;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpectedLayout;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_IncludePathCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_IncludePaths;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ExcludePathCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ExcludePaths;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetBindingIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingGroupForNewBinding;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CancelBinding;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MagnitudeThreshold;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Scores;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Magnitudes;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LastMatchTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Timeout;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_WaitSecondsAfterMatch;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Candidates;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnComplete;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnCancel;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnPotentialMatch;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnGeneratePath;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnComputeScore;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnApplyBinding;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnEventDelegate;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OnAfterUpdateDelegate;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LayoutCache;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PathBuilder;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_StartingActuations;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_action_Public_get_InputAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingMask_Public_get_Nullable_1_InputBinding_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_candidates_Public_get_InputControlList_1_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_scores_Public_get_ReadOnlyArray_1_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitudes_Public_get_ReadOnlyArray_1_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedControl_Public_get_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_started_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_completed_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_canceled_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_startTime_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_timeout_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_expectedControlType_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithAction_Public_RebindingOperation_InputAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithMatchingEventsBeingSuppressed_Public_RebindingOperation_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithCancelingThrough_Public_RebindingOperation_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithCancelingThrough_Public_RebindingOperation_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithTargetBinding_Public_RebindingOperation_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithBindingMask_Public_RebindingOperation_Nullable_1_InputBinding_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithBindingGroup_Public_RebindingOperation_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithoutGeneralizingPathOfSelectedControl_Public_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithRebindAddingNewBinding_Public_RebindingOperation_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithMagnitudeHavingToBeGreaterThan_Public_RebindingOperation_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithoutIgnoringNoisyControls_Public_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithControlsHavingToMatchPath_Public_RebindingOperation_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithControlsExcluding_Public_RebindingOperation_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithTimeout_Public_RebindingOperation_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnComplete_Public_RebindingOperation_Action_1_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnCancel_Public_RebindingOperation_Action_1_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnPotentialMatch_Public_RebindingOperation_Action_1_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnGeneratePath_Public_RebindingOperation_Func_2_InputControl_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnComputeScore_Public_RebindingOperation_Func_3_InputControl_InputEventPtr_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnApplyBinding_Public_RebindingOperation_Action_2_RebindingOperation_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnMatchWaitForAnother_Public_RebindingOperation_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddCandidate_Public_Void_InputControl_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCandidate_Public_Void_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_RebindingOperation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HookOnEvent_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UnhookOnEvent_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnEvent_Private_Void_InputEventPtr_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SortCandidatesByScore_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HavePathMatch_Private_Static_Boolean_InputControl_Il2CppStringArray_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HookOnAfterUpdate_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UnhookOnAfterUpdate_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterUpdate_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnComplete_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnCancel_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ResetAfterMatchCompleted_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfRebindInProgress_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GeneratePathForControl_Private_String_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe static float kDefaultMagnitudeThreshold
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultMagnitudeThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultMagnitudeThreshold, (void*)(&value));
			}
		}

		public unsafe InputAction m_ActionToRebind
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionToRebind);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionToRebind)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Nullable<InputBinding> m_BindingMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingMask);
				return new Il2CppSystem.Nullable<InputBinding>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputBinding>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingMask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputBinding>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Type m_ControlType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlType);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InternedString m_ExpectedLayout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExpectedLayout);
				return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExpectedLayout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int m_IncludePathCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IncludePathCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IncludePathCount)) = value;
			}
		}

		public unsafe Il2CppStringArray m_IncludePaths
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IncludePaths);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IncludePaths)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_ExcludePathCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExcludePathCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExcludePathCount)) = value;
			}
		}

		public unsafe Il2CppStringArray m_ExcludePaths
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExcludePaths);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExcludePaths)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_TargetBindingIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetBindingIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetBindingIndex)) = value;
			}
		}

		public unsafe string m_BindingGroupForNewBinding
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingGroupForNewBinding);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BindingGroupForNewBinding)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string m_CancelBinding
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CancelBinding);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CancelBinding)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe float m_MagnitudeThreshold
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MagnitudeThreshold);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MagnitudeThreshold)) = value;
			}
		}

		public unsafe Il2CppStructArray<float> m_Scores
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scores);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scores)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<float> m_Magnitudes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Magnitudes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Magnitudes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe double m_LastMatchTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastMatchTime);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastMatchTime)) = value;
			}
		}

		public unsafe double m_StartTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartTime);
				return *(double*)num;
			}
			set
			{
				*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartTime)) = value;
			}
		}

		public unsafe float m_Timeout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Timeout);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Timeout)) = value;
			}
		}

		public unsafe float m_WaitSecondsAfterMatch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WaitSecondsAfterMatch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WaitSecondsAfterMatch)) = value;
			}
		}

		public unsafe InputControlList<InputControl> m_Candidates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Candidates);
				return new InputControlList<InputControl>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputControlList<InputControl>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Candidates), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputControlList<InputControl>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Action<RebindingOperation> m_OnComplete
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnComplete);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RebindingOperation>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action<RebindingOperation> m_OnCancel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnCancel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RebindingOperation>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnCancel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action<RebindingOperation> m_OnPotentialMatch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnPotentialMatch);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RebindingOperation>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnPotentialMatch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Func<InputControl, string> m_OnGeneratePath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnGeneratePath);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InputControl, string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnGeneratePath)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Func<InputControl, InputEventPtr, float> m_OnComputeScore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnComputeScore);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InputControl, InputEventPtr, float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnComputeScore)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action<RebindingOperation, string> m_OnApplyBinding
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnApplyBinding);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RebindingOperation, string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnApplyBinding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action<InputEventPtr, InputDevice> m_OnEventDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnEventDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputEventPtr, InputDevice>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnEventDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action m_OnAfterUpdateDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnAfterUpdateDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnAfterUpdateDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputControlLayout.Cache m_LayoutCache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutCache);
				return new InputControlLayout.Cache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputControlLayout.Cache>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputControlLayout.Cache>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe StringBuilder m_PathBuilder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PathBuilder);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PathBuilder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Flags m_Flags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
				return *(Flags*)num;
			}
			set
			{
				*(Flags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		public unsafe Dictionary<InputControl, float> m_StartingActuations
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartingActuations);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputControl, float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartingActuations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputAction action
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_action_Public_get_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
			}
		}

		public unsafe Il2CppSystem.Nullable<InputBinding> bindingMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindingMask_Public_get_Nullable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Il2CppSystem.Nullable<InputBinding>(pointer);
			}
		}

		public unsafe InputControlList<InputControl> candidates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_candidates_Public_get_InputControlList_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InputControlList<InputControl>(pointer);
			}
		}

		public unsafe ReadOnlyArray<float> scores
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966103, XrefRangeEnd = 966107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scores_Public_get_ReadOnlyArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<float>(pointer);
			}
		}

		public unsafe ReadOnlyArray<float> magnitudes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966107, XrefRangeEnd = 966111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_magnitudes_Public_get_ReadOnlyArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<float>(pointer);
			}
		}

		public unsafe InputControl selectedControl
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966111, XrefRangeEnd = 966115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectedControl_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
		}

		public unsafe bool started
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_started_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_completed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool canceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe double startTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe float timeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe string expectedControlType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966115, XrefRangeEnd = 966116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_expectedControlType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		static RebindingOperation()
		{
			Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "RebindingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr);
			NativeFieldInfoPtr_kDefaultMagnitudeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "kDefaultMagnitudeThreshold");
			NativeFieldInfoPtr_m_ActionToRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_ActionToRebind");
			NativeFieldInfoPtr_m_BindingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_BindingMask");
			NativeFieldInfoPtr_m_ControlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_ControlType");
			NativeFieldInfoPtr_m_ExpectedLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_ExpectedLayout");
			NativeFieldInfoPtr_m_IncludePathCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_IncludePathCount");
			NativeFieldInfoPtr_m_IncludePaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_IncludePaths");
			NativeFieldInfoPtr_m_ExcludePathCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_ExcludePathCount");
			NativeFieldInfoPtr_m_ExcludePaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_ExcludePaths");
			NativeFieldInfoPtr_m_TargetBindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_TargetBindingIndex");
			NativeFieldInfoPtr_m_BindingGroupForNewBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_BindingGroupForNewBinding");
			NativeFieldInfoPtr_m_CancelBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_CancelBinding");
			NativeFieldInfoPtr_m_MagnitudeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_MagnitudeThreshold");
			NativeFieldInfoPtr_m_Scores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_Scores");
			NativeFieldInfoPtr_m_Magnitudes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_Magnitudes");
			NativeFieldInfoPtr_m_LastMatchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_LastMatchTime");
			NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_StartTime");
			NativeFieldInfoPtr_m_Timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_Timeout");
			NativeFieldInfoPtr_m_WaitSecondsAfterMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_WaitSecondsAfterMatch");
			NativeFieldInfoPtr_m_Candidates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_Candidates");
			NativeFieldInfoPtr_m_OnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnComplete");
			NativeFieldInfoPtr_m_OnCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnCancel");
			NativeFieldInfoPtr_m_OnPotentialMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnPotentialMatch");
			NativeFieldInfoPtr_m_OnGeneratePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnGeneratePath");
			NativeFieldInfoPtr_m_OnComputeScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnComputeScore");
			NativeFieldInfoPtr_m_OnApplyBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnApplyBinding");
			NativeFieldInfoPtr_m_OnEventDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnEventDelegate");
			NativeFieldInfoPtr_m_OnAfterUpdateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_OnAfterUpdateDelegate");
			NativeFieldInfoPtr_m_LayoutCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_LayoutCache");
			NativeFieldInfoPtr_m_PathBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_PathBuilder");
			NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_Flags");
			NativeFieldInfoPtr_m_StartingActuations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, "m_StartingActuations");
			NativeMethodInfoPtr_get_action_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663882);
			NativeMethodInfoPtr_get_bindingMask_Public_get_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663883);
			NativeMethodInfoPtr_get_candidates_Public_get_InputControlList_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663884);
			NativeMethodInfoPtr_get_scores_Public_get_ReadOnlyArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663885);
			NativeMethodInfoPtr_get_magnitudes_Public_get_ReadOnlyArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663886);
			NativeMethodInfoPtr_get_selectedControl_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663887);
			NativeMethodInfoPtr_get_started_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663888);
			NativeMethodInfoPtr_get_completed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663889);
			NativeMethodInfoPtr_get_canceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663890);
			NativeMethodInfoPtr_get_startTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663891);
			NativeMethodInfoPtr_get_timeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663892);
			NativeMethodInfoPtr_get_expectedControlType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663893);
			NativeMethodInfoPtr_WithAction_Public_RebindingOperation_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663894);
			NativeMethodInfoPtr_WithMatchingEventsBeingSuppressed_Public_RebindingOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663895);
			NativeMethodInfoPtr_WithCancelingThrough_Public_RebindingOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663896);
			NativeMethodInfoPtr_WithCancelingThrough_Public_RebindingOperation_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663897);
			NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663898);
			NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663899);
			NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663900);
			NativeMethodInfoPtr_WithTargetBinding_Public_RebindingOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663901);
			NativeMethodInfoPtr_WithBindingMask_Public_RebindingOperation_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663902);
			NativeMethodInfoPtr_WithBindingGroup_Public_RebindingOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663903);
			NativeMethodInfoPtr_WithoutGeneralizingPathOfSelectedControl_Public_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663904);
			NativeMethodInfoPtr_WithRebindAddingNewBinding_Public_RebindingOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663905);
			NativeMethodInfoPtr_WithMagnitudeHavingToBeGreaterThan_Public_RebindingOperation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663906);
			NativeMethodInfoPtr_WithoutIgnoringNoisyControls_Public_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663907);
			NativeMethodInfoPtr_WithControlsHavingToMatchPath_Public_RebindingOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663908);
			NativeMethodInfoPtr_WithControlsExcluding_Public_RebindingOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663909);
			NativeMethodInfoPtr_WithTimeout_Public_RebindingOperation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663910);
			NativeMethodInfoPtr_OnComplete_Public_RebindingOperation_Action_1_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663911);
			NativeMethodInfoPtr_OnCancel_Public_RebindingOperation_Action_1_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663912);
			NativeMethodInfoPtr_OnPotentialMatch_Public_RebindingOperation_Action_1_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663913);
			NativeMethodInfoPtr_OnGeneratePath_Public_RebindingOperation_Func_2_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663914);
			NativeMethodInfoPtr_OnComputeScore_Public_RebindingOperation_Func_3_InputControl_InputEventPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663915);
			NativeMethodInfoPtr_OnApplyBinding_Public_RebindingOperation_Action_2_RebindingOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663916);
			NativeMethodInfoPtr_OnMatchWaitForAnother_Public_RebindingOperation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663917);
			NativeMethodInfoPtr_Start_Public_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663918);
			NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663919);
			NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663920);
			NativeMethodInfoPtr_AddCandidate_Public_Void_InputControl_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663921);
			NativeMethodInfoPtr_RemoveCandidate_Public_Void_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663922);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663923);
			NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663924);
			NativeMethodInfoPtr_Reset_Public_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663925);
			NativeMethodInfoPtr_HookOnEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663926);
			NativeMethodInfoPtr_UnhookOnEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663927);
			NativeMethodInfoPtr_OnEvent_Private_Void_InputEventPtr_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663928);
			NativeMethodInfoPtr_SortCandidatesByScore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663929);
			NativeMethodInfoPtr_HavePathMatch_Private_Static_Boolean_InputControl_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663930);
			NativeMethodInfoPtr_HookOnAfterUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663931);
			NativeMethodInfoPtr_UnhookOnAfterUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663932);
			NativeMethodInfoPtr_OnAfterUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663933);
			NativeMethodInfoPtr_OnComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663934);
			NativeMethodInfoPtr_OnCancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663935);
			NativeMethodInfoPtr_ResetAfterMatchCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663936);
			NativeMethodInfoPtr_ThrowIfRebindInProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663937);
			NativeMethodInfoPtr_GeneratePathForControl_Private_String_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663938);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr, 100663939);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966124, RefRangeEnd = 966125, XrefRangeStart = 966116, XrefRangeEnd = 966124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithAction(InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithAction_Public_RebindingOperation_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithMatchingEventsBeingSuppressed_Public_RebindingOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966126, RefRangeEnd = 966128, XrefRangeStart = 966125, XrefRangeEnd = 966126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithCancelingThrough(string binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(binding);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithCancelingThrough_Public_RebindingOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966128, XrefRangeEnd = 966142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithCancelingThrough(InputControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithCancelingThrough_Public_RebindingOperation_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966144, RefRangeEnd = 966146, XrefRangeStart = 966142, XrefRangeEnd = 966144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithExpectedControlType(string layoutName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(layoutName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966155, RefRangeEnd = 966156, XrefRangeStart = 966146, XrefRangeEnd = 966155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithExpectedControlType(Il2CppSystem.Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithExpectedControlType_Public_RebindingOperation_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966156, XrefRangeEnd = 966162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithExpectedControlType<TControl>() where TControl : InputControl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WithExpectedControlType_Public_RebindingOperation_0<TControl>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966233, RefRangeEnd = 966234, XrefRangeStart = 966162, XrefRangeEnd = 966233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithTargetBinding(int bindingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&bindingIndex);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithTargetBinding_Public_RebindingOperation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966234, XrefRangeEnd = 966235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithBindingMask(Il2CppSystem.Nullable<InputBinding> bindingMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithBindingMask_Public_RebindingOperation_Nullable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966235, XrefRangeEnd = 966240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithBindingGroup(string group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(group);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithBindingGroup_Public_RebindingOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe RebindingOperation WithoutGeneralizingPathOfSelectedControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithoutGeneralizingPathOfSelectedControl_Public_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966240, XrefRangeEnd = 966241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithRebindAddingNewBinding(string group = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(group);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithRebindAddingNewBinding_Public_RebindingOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&magnitude);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithMagnitudeHavingToBeGreaterThan_Public_RebindingOperation_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe RebindingOperation WithoutIgnoringNoisyControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithoutIgnoringNoisyControls_Public_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966246, RefRangeEnd = 966247, XrefRangeStart = 966241, XrefRangeEnd = 966246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithControlsHavingToMatchPath(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithControlsHavingToMatchPath_Public_RebindingOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 966252, RefRangeEnd = 966257, XrefRangeStart = 966247, XrefRangeEnd = 966252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation WithControlsExcluding(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithControlsExcluding_Public_RebindingOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe RebindingOperation WithTimeout(float timeInSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&timeInSeconds);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithTimeout_Public_RebindingOperation_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966257, XrefRangeEnd = 966258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation OnComplete(Il2CppSystem.Action<RebindingOperation> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnComplete_Public_RebindingOperation_Action_1_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966258, XrefRangeEnd = 966259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation OnCancel(Il2CppSystem.Action<RebindingOperation> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCancel_Public_RebindingOperation_Action_1_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966259, XrefRangeEnd = 966260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation OnPotentialMatch(Il2CppSystem.Action<RebindingOperation> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPotentialMatch_Public_RebindingOperation_Action_1_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966260, XrefRangeEnd = 966261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation OnGeneratePath(Il2CppSystem.Func<InputControl, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGeneratePath_Public_RebindingOperation_Func_2_InputControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966261, XrefRangeEnd = 966262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation OnComputeScore(Il2CppSystem.Func<InputControl, InputEventPtr, float> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnComputeScore_Public_RebindingOperation_Func_3_InputControl_InputEventPtr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966262, XrefRangeEnd = 966263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation OnApplyBinding(Il2CppSystem.Action<RebindingOperation, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplyBinding_Public_RebindingOperation_Action_2_RebindingOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe RebindingOperation OnMatchWaitForAnother(float seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&seconds);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMatchWaitForAnother_Public_RebindingOperation_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966263, XrefRangeEnd = 966294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966295, RefRangeEnd = 966296, XrefRangeStart = 966294, XrefRangeEnd = 966295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966296, XrefRangeEnd = 966297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966297, XrefRangeEnd = 966311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCandidate(InputControl control, float score, float magnitude = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &score;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &magnitude;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCandidate_Public_Void_InputControl_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966311, XrefRangeEnd = 966321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCandidate(InputControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCandidate_Public_Void_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966321, XrefRangeEnd = 966330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966330, XrefRangeEnd = 966342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966342, XrefRangeEnd = 966350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966350, XrefRangeEnd = 966363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HookOnEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HookOnEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 966369, RefRangeEnd = 966372, XrefRangeStart = 966363, XrefRangeEnd = 966369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnhookOnEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnhookOnEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966372, XrefRangeEnd = 966434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEvent(InputEventPtr eventPtr, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&eventPtr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEvent_Private_Void_InputEventPtr_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 966443, RefRangeEnd = 966446, XrefRangeStart = 966434, XrefRangeEnd = 966443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCandidatesByScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortCandidatesByScore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966447, RefRangeEnd = 966449, XrefRangeStart = 966446, XrefRangeEnd = 966447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HavePathMatch(InputControl control, Il2CppStringArray paths, int pathCount)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paths);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pathCount;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HavePathMatch_Private_Static_Boolean_InputControl_Il2CppStringArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966449, XrefRangeEnd = 966460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HookOnAfterUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HookOnAfterUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966460, XrefRangeEnd = 966464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnhookOnAfterUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnhookOnAfterUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966464, XrefRangeEnd = 966468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAfterUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966485, RefRangeEnd = 966487, XrefRangeStart = 966468, XrefRangeEnd = 966485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966488, RefRangeEnd = 966489, XrefRangeStart = 966487, XrefRangeEnd = 966488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 966503, RefRangeEnd = 966507, XrefRangeStart = 966489, XrefRangeEnd = 966503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAfterMatchCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAfterMatchCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966507, RefRangeEnd = 966508, XrefRangeStart = 966507, XrefRangeEnd = 966507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfRebindInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfRebindInProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966523, RefRangeEnd = 966524, XrefRangeStart = 966508, XrefRangeEnd = 966523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GeneratePathForControl(InputControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GeneratePathForControl_Private_String_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966524, XrefRangeEnd = 966532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindingOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindingOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public RebindingOperation(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DeferBindingResolutionWrapper : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Acquire_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DeferBindingResolutionWrapper()
		{
			Il2CppClassPointerStore<DeferBindingResolutionWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "DeferBindingResolutionWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferBindingResolutionWrapper>.NativeClassPtr);
			NativeMethodInfoPtr_Acquire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferBindingResolutionWrapper>.NativeClassPtr, 100663942);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferBindingResolutionWrapper>.NativeClassPtr, 100663943);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferBindingResolutionWrapper>.NativeClassPtr, 100663944);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966536, RefRangeEnd = 966537, XrefRangeStart = 966532, XrefRangeEnd = 966536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Acquire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966537, XrefRangeEnd = 966550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeferBindingResolutionWrapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeferBindingResolutionWrapper>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DeferBindingResolutionWrapper(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.InputSystem.InputActionRebindingExtensions+<>c__DisplayClass25_0")]
	public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_bindings;

		private static readonly System.IntPtr NativeFieldInfoPtr_firstPartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_partStrings;

		private static readonly System.IntPtr NativeFieldInfoPtr_partCount;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBindingDisplayString_b__0_Internal_String_String_0;

		public unsafe ReadOnlyArray<InputBinding> bindings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindings);
				return new ReadOnlyArray<InputBinding>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyArray<InputBinding>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyArray<InputBinding>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int firstPartIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPartIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPartIndex)) = value;
			}
		}

		public unsafe Il2CppStringArray partStrings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partStrings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partStrings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int partCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partCount)) = value;
			}
		}

		static __c__DisplayClass25_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "<>c__DisplayClass25_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr);
			NativeFieldInfoPtr_bindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, "bindings");
			NativeFieldInfoPtr_firstPartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, "firstPartIndex");
			NativeFieldInfoPtr_partStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, "partStrings");
			NativeFieldInfoPtr_partCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, "partCount");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, 100663945);
			NativeMethodInfoPtr__GetBindingDisplayString_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, 100663946);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass25_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966550, XrefRangeEnd = 966563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _GetBindingDisplayString_b__0(string fragment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fragment);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBindingDisplayString_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public __c__DisplayClass25_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetParameterValue_Public_Static_Nullable_1_TValue_InputAction_Expression_1_Func_2_TObject_TValue_InputBinding_0<TObject, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_TValue_InputAction_Expression_1_Func_2_TObject_TValue_InputBinding_0, Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_ApplyParameterOverride_Public_Static_Void_InputAction_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0<TObject, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0, Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_ApplyParameterOverride_Public_Static_Void_InputActionMap_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0<TObject, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionMap_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0, Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_ApplyParameterOverride_Public_Static_Void_InputActionAsset_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0<TObject, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionAsset_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0, Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_ExtractParameterOverride_Private_Static_ParameterOverride_Expression_1_Func_2_TObject_TValue_InputBinding_PrimitiveValue_0<TObject, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ExtractParameterOverride_Private_Static_ParameterOverride_Expression_1_Func_2_TObject_TValue_InputBinding_PrimitiveValue_0, Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DeferBindingResolutionWrapper;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_PrimitiveValue_InputAction_String_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParameterValue_Private_Static_Nullable_1_PrimitiveValue_InputAction_ParameterOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_PrimitiveValue_InputAction_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_TValue_InputAction_Expression_1_Func_2_TObject_TValue_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionMap_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionAsset_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractParameterOverride_Private_Static_ParameterOverride_Expression_1_Func_2_TObject_TValue_InputBinding_PrimitiveValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionMap_String_PrimitiveValue_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionAsset_String_PrimitiveValue_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_String_PrimitiveValue_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_String_PrimitiveValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterOverride_Private_Static_Void_InputActionState_Int32_byref_Il2CppReferenceArray_1_ParameterOverride_byref_Int32_ParameterOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputAction_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputActionMap_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputAction_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingForControl_Public_Static_Nullable_1_InputBinding_InputAction_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingIndexForControl_Public_Static_Int32_InputAction_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_DisplayStringOptions_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_InputBinding_DisplayStringOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_Int32_DisplayStringOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_Int32_byref_String_byref_String_DisplayStringOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_Int32_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Int32_InputActionMap_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputActionMap_Int32_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBindingOverride_Public_Static_Void_InputAction_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBindingOverride_Public_Static_Void_InputAction_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBindingOverride_Private_Static_Void_InputActionMap_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllBindingOverrides_Public_Static_Void_IInputActionCollection2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllBindingOverrides_Public_Static_Void_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverrides_Public_Static_Void_InputActionMap_IEnumerable_1_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBindingOverrides_Public_Static_Void_InputActionMap_IEnumerable_1_InputBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverridesOnMatchingControls_Public_Static_Int32_InputAction_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindingOverridesOnMatchingControls_Public_Static_Int32_InputActionMap_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveBindingOverridesAsJson_Public_Static_String_IInputActionCollection2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveBindingOverridesAsJson_Public_Static_String_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBindingOverrideJsonTo_Private_Static_Void_IInputActionCollection2_InputBinding_List_1_BindingOverrideJson_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBindingOverridesFromJson_Public_Static_Void_IInputActionCollection2_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBindingOverridesFromJson_Public_Static_Void_InputAction_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBindingOverridesFromJsonInternal_Private_Static_Void_IInputActionCollection2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformInteractiveRebinding_Public_Static_RebindingOperation_InputAction_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeferBindingResolution_Internal_Static_DeferBindingResolutionWrapper_0;

	public unsafe static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DeferBindingResolutionWrapper, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeferBindingResolutionWrapper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DeferBindingResolutionWrapper, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InputActionRebindingExtensions()
	{
		Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputActionRebindingExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr);
		NativeFieldInfoPtr_s_DeferBindingResolutionWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, "s_DeferBindingResolutionWrapper");
		NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_PrimitiveValue_InputAction_String_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663817);
		NativeMethodInfoPtr_GetParameterValue_Private_Static_Nullable_1_PrimitiveValue_InputAction_ParameterOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_PrimitiveValue_InputAction_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663819);
		NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_TValue_InputAction_Expression_1_Func_2_TObject_TValue_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663820);
		NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663821);
		NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionMap_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionAsset_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_ExtractParameterOverride_Private_Static_ParameterOverride_Expression_1_Func_2_TObject_TValue_InputBinding_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionMap_String_PrimitiveValue_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionAsset_String_PrimitiveValue_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_String_PrimitiveValue_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_String_PrimitiveValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_ApplyParameterOverride_Private_Static_Void_InputActionState_Int32_byref_Il2CppReferenceArray_1_ParameterOverride_byref_Int32_ParameterOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputAction_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputActionMap_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputAction_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_GetBindingForControl_Public_Static_Nullable_1_InputBinding_InputAction_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_GetBindingIndexForControl_Public_Static_Int32_InputAction_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_DisplayStringOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_InputBinding_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_Int32_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_Int32_byref_String_byref_String_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_Int32_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Int32_InputActionMap_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputActionMap_Int32_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_RemoveBindingOverride_Public_Static_Void_InputAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_RemoveBindingOverride_Public_Static_Void_InputAction_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_RemoveBindingOverride_Private_Static_Void_InputActionMap_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_RemoveAllBindingOverrides_Public_Static_Void_IInputActionCollection2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_RemoveAllBindingOverrides_Public_Static_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_ApplyBindingOverrides_Public_Static_Void_InputActionMap_IEnumerable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_RemoveBindingOverrides_Public_Static_Void_InputActionMap_IEnumerable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_ApplyBindingOverridesOnMatchingControls_Public_Static_Int32_InputAction_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_ApplyBindingOverridesOnMatchingControls_Public_Static_Int32_InputActionMap_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_SaveBindingOverridesAsJson_Public_Static_String_IInputActionCollection2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_SaveBindingOverridesAsJson_Public_Static_String_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_AddBindingOverrideJsonTo_Private_Static_Void_IInputActionCollection2_InputBinding_List_1_BindingOverrideJson_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663856);
		NativeMethodInfoPtr_LoadBindingOverridesFromJson_Public_Static_Void_IInputActionCollection2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_LoadBindingOverridesFromJson_Public_Static_Void_InputAction_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663858);
		NativeMethodInfoPtr_LoadBindingOverridesFromJsonInternal_Private_Static_Void_IInputActionCollection2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_PerformInteractiveRebinding_Public_Static_RebindingOperation_InputAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_DeferBindingResolution_Internal_Static_DeferBindingResolutionWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionRebindingExtensions>.NativeClassPtr, 100663861);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 966573, RefRangeEnd = 966574, XrefRangeStart = 966563, XrefRangeEnd = 966573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<PrimitiveValue> GetParameterValue(this InputAction action, string name, InputBinding bindingMask = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_PrimitiveValue_InputAction_String_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<PrimitiveValue>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 966588, RefRangeEnd = 966590, XrefRangeStart = 966574, XrefRangeEnd = 966588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<PrimitiveValue> GetParameterValue(this InputAction action, ParameterOverride parameterOverride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parameterOverride));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParameterValue_Private_Static_Nullable_1_PrimitiveValue_InputAction_ParameterOverride_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<PrimitiveValue>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966590, XrefRangeEnd = 966602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<PrimitiveValue> GetParameterValue(this InputAction action, string name, int bindingIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParameterValue_Public_Static_Nullable_1_PrimitiveValue_InputAction_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<PrimitiveValue>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966602, XrefRangeEnd = 966635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<TValue> GetParameterValue<TObject, TValue>(this InputAction action, Expression<Il2CppSystem.Func<TObject, TValue>> expr, InputBinding bindingMask = null) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetParameterValue_Public_Static_Nullable_1_TValue_InputAction_Expression_1_Func_2_TObject_TValue_InputBinding_0<TObject, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<TValue>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966635, XrefRangeEnd = 966642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride<TObject, TValue>(this InputAction action, Expression<Il2CppSystem.Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) where TValue : new()
	{
		//IL_0069->IL006c: Incompatible stack types: I vs Ref
		//IL_005c->IL006c: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expr);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ApplyParameterOverride_Public_Static_Void_InputAction_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0<TObject, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966642, XrefRangeEnd = 966647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride<TObject, TValue>(this InputActionMap actionMap, Expression<Il2CppSystem.Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) where TValue : new()
	{
		//IL_0069->IL006c: Incompatible stack types: I vs Ref
		//IL_005c->IL006c: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expr);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ApplyParameterOverride_Public_Static_Void_InputActionMap_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0<TObject, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966647, XrefRangeEnd = 966656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride<TObject, TValue>(this InputActionAsset asset, Expression<Il2CppSystem.Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask = null) where TValue : new()
	{
		//IL_0069->IL006c: Incompatible stack types: I vs Ref
		//IL_005c->IL006c: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expr);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ApplyParameterOverride_Public_Static_Void_InputActionAsset_Expression_1_Func_2_TObject_TValue_TValue_InputBinding_0<TObject, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966656, XrefRangeEnd = 966699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Il2CppSystem.Func<TObject, TValue>> expr, InputBinding bindingMask = null, PrimitiveValue value = default(PrimitiveValue))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ExtractParameterOverride_Private_Static_ParameterOverride_Expression_1_Func_2_TObject_TValue_InputBinding_PrimitiveValue_0<TObject, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ParameterOverride(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966699, XrefRangeEnd = 966710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride(this InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionMap_String_PrimitiveValue_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966710, XrefRangeEnd = 966729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride(this InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputActionAsset_String_PrimitiveValue_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 966741, RefRangeEnd = 966742, XrefRangeStart = 966729, XrefRangeEnd = 966741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, InputBinding bindingMask = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_String_PrimitiveValue_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966742, XrefRangeEnd = 966754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride(this InputAction action, string name, PrimitiveValue value, int bindingIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParameterOverride_Public_Static_Void_InputAction_String_PrimitiveValue_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 966791, RefRangeEnd = 966797, XrefRangeStart = 966754, XrefRangeEnd = 966791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyParameterOverride(InputActionState state, int mapIndex, ref Il2CppReferenceArray<ParameterOverride> parameterOverrides, ref int parameterOverridesCount, ParameterOverride parameterOverride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapIndex;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameterOverrides);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parameterOverridesCount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parameterOverride));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParameterOverride_Private_Static_Void_InputActionState_Int32_byref_Il2CppReferenceArray_1_ParameterOverride_byref_Int32_ParameterOverride_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		parameterOverrides = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<ParameterOverride>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966797, XrefRangeEnd = 966807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetBindingIndex(this InputAction action, InputBinding bindingMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputAction_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966807, XrefRangeEnd = 966815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetBindingIndex(this InputActionMap actionMap, InputBinding bindingMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputActionMap_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966815, XrefRangeEnd = 966826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetBindingIndex(this InputAction action, string group = null, string path = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(group);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingIndex_Public_Static_Int32_InputAction_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966826, XrefRangeEnd = 966838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<InputBinding> GetBindingForControl(this InputAction action, InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingForControl_Public_Static_Nullable_1_InputBinding_InputAction_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<InputBinding>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 966844, RefRangeEnd = 966845, XrefRangeStart = 966838, XrefRangeEnd = 966844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetBindingIndexForControl(this InputAction action, InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingIndexForControl_Public_Static_Int32_InputAction_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966845, XrefRangeEnd = 966858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBindingDisplayString(this InputAction action, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0, string group = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(InputBinding.DisplayStringOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(group);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_DisplayStringOptions_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 966880, RefRangeEnd = 966881, XrefRangeStart = 966858, XrefRangeEnd = 966880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBindingDisplayString(this InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		*(InputBinding.DisplayStringOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_InputBinding_DisplayStringOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966881, XrefRangeEnd = 966882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBindingDisplayString(this InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		*(InputBinding.DisplayStringOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_Int32_DisplayStringOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 966923, RefRangeEnd = 966925, XrefRangeStart = 966882, XrefRangeEnd = 966923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBindingDisplayString(this InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(InputBinding.DisplayStringOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingDisplayString_Public_Static_String_InputAction_Int32_byref_String_byref_String_DisplayStringOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		deviceLayoutName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		controlPath = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 966929, RefRangeEnd = 966932, XrefRangeStart = 966925, XrefRangeEnd = 966929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyBindingOverride(this InputAction action, string newPath, string group = null, string path = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(group);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 966941, RefRangeEnd = 966944, XrefRangeStart = 966932, XrefRangeEnd = 966941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyBindingOverride(this InputAction action, InputBinding bindingOverride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingOverride));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966944, XrefRangeEnd = 966948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyBindingOverride(this InputAction action, int bindingIndex, InputBinding bindingOverride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingOverride));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_Int32_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 966953, RefRangeEnd = 966954, XrefRangeStart = 966948, XrefRangeEnd = 966953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyBindingOverride(this InputAction action, int bindingIndex, string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputAction_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 966962, RefRangeEnd = 966966, XrefRangeStart = 966954, XrefRangeEnd = 966962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ApplyBindingOverride(this InputActionMap actionMap, InputBinding bindingOverride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingOverride));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Int32_InputActionMap_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 966990, RefRangeEnd = 966995, XrefRangeStart = 966966, XrefRangeEnd = 966990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyBindingOverride(this InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingOverride));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverride_Public_Static_Void_InputActionMap_Int32_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966995, XrefRangeEnd = 966999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveBindingOverride(this InputAction action, int bindingIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBindingOverride_Public_Static_Void_InputAction_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966999, XrefRangeEnd = 967003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveBindingOverride(this InputAction action, InputBinding bindingMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBindingOverride_Public_Static_Void_InputAction_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967003, XrefRangeEnd = 967007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveBindingOverride(this InputActionMap actionMap, InputBinding bindingMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindingMask));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBindingOverride_Private_Static_Void_InputActionMap_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 967038, RefRangeEnd = 967039, XrefRangeStart = 967007, XrefRangeEnd = 967038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveAllBindingOverrides(this IInputActionCollection2 actions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllBindingOverrides_Public_Static_Void_IInputActionCollection2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 967048, RefRangeEnd = 967049, XrefRangeStart = 967039, XrefRangeEnd = 967048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveAllBindingOverrides(this InputAction action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllBindingOverrides_Public_Static_Void_InputAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967049, XrefRangeEnd = 967067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrides);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverrides_Public_Static_Void_InputActionMap_IEnumerable_1_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967067, XrefRangeEnd = 967088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveBindingOverrides(this InputActionMap actionMap, IEnumerable<InputBinding> overrides)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrides);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBindingOverrides_Public_Static_Void_InputActionMap_IEnumerable_1_InputBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 967100, RefRangeEnd = 967101, XrefRangeStart = 967088, XrefRangeEnd = 967100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ApplyBindingOverridesOnMatchingControls(this InputAction action, InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverridesOnMatchingControls_Public_Static_Int32_InputAction_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967101, XrefRangeEnd = 967109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ApplyBindingOverridesOnMatchingControls(this InputActionMap actionMap, InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindingOverridesOnMatchingControls_Public_Static_Int32_InputActionMap_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967109, XrefRangeEnd = 967142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SaveBindingOverridesAsJson(this IInputActionCollection2 actions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveBindingOverridesAsJson_Public_Static_String_IInputActionCollection2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967142, XrefRangeEnd = 967179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SaveBindingOverridesAsJson(this InputAction action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveBindingOverridesAsJson_Public_Static_String_InputAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 967194, RefRangeEnd = 967196, XrefRangeStart = 967179, XrefRangeEnd = 967194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddBindingOverrideJsonTo(this IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, InputAction action = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)binding));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBindingOverrideJsonTo_Private_Static_Void_IInputActionCollection2_InputBinding_List_1_BindingOverrideJson_InputAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967196, XrefRangeEnd = 967205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadBindingOverridesFromJson(this IInputActionCollection2 actions, string json, bool removeExisting = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(json);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeExisting;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBindingOverridesFromJson_Public_Static_Void_IInputActionCollection2_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967205, XrefRangeEnd = 967215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadBindingOverridesFromJson(this InputAction action, string json, bool removeExisting = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(json);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeExisting;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBindingOverridesFromJson_Public_Static_Void_InputAction_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 967251, RefRangeEnd = 967253, XrefRangeStart = 967215, XrefRangeEnd = 967251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadBindingOverridesFromJsonInternal(this IInputActionCollection2 actions, string json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(json);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBindingOverridesFromJsonInternal_Private_Static_Void_IInputActionCollection2_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967253, XrefRangeEnd = 967298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RebindingOperation PerformInteractiveRebinding(this InputAction action, int bindingIndex = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformInteractiveRebinding_Public_Static_RebindingOperation_InputAction_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RebindingOperation>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 967310, RefRangeEnd = 967322, XrefRangeStart = 967298, XrefRangeEnd = 967310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DeferBindingResolutionWrapper DeferBindingResolution()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeferBindingResolution_Internal_Static_DeferBindingResolutionWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeferBindingResolutionWrapper>(intPtr2) : null;
	}

	public InputActionRebindingExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
