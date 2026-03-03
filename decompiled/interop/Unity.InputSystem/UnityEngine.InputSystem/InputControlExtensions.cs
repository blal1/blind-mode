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
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputControlExtensions : Il2CppSystem.Object
{
	[OriginalName("Unity.InputSystem.dll", "", "Enumerate")]
	[System.Flags]
	public enum Enumerate
	{
		IgnoreControlsInDefaultState = 1,
		IgnoreControlsInCurrentState = 2,
		IncludeSyntheticControls = 4,
		IncludeNoisyControls = 8,
		IncludeNonLeafControls = 0x10
	}

	public sealed class InputEventControlCollection : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Device;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_EventPtr;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MagnitudeThreshold;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_eventPtr_Public_get_InputEventPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_InputEventControlEnumerator_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		public unsafe InputDevice m_Device
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Device);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Device)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputEventPtr m_EventPtr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventPtr);
				return *(InputEventPtr*)num;
			}
			set
			{
				*(InputEventPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventPtr)) = value;
			}
		}

		public unsafe Enumerate m_Flags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
				return *(Enumerate*)num;
			}
			set
			{
				*(Enumerate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
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

		public unsafe InputEventPtr eventPtr
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventPtr_Public_get_InputEventPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(InputEventPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static InputEventControlCollection()
		{
			Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, "InputEventControlCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr);
			NativeFieldInfoPtr_m_Device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, "m_Device");
			NativeFieldInfoPtr_m_EventPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, "m_EventPtr");
			NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, "m_Flags");
			NativeFieldInfoPtr_m_MagnitudeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, "m_MagnitudeThreshold");
			NativeMethodInfoPtr_get_eventPtr_Public_get_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, 100664733);
			NativeMethodInfoPtr_GetEnumerator_Public_InputEventControlEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, 100664734);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, 100664735);
			NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr, 100664736);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 974036, RefRangeEnd = 974039, XrefRangeStart = 974035, XrefRangeEnd = 974036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputEventControlEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_InputEventControlEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputEventControlEnumerator(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974039, XrefRangeEnd = 974043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<InputControl> System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<InputControl>>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974043, XrefRangeEnd = 974047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		public InputEventControlCollection(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public InputEventControlCollection()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEventControlCollection>.NativeClassPtr))
		{
		}
	}

	public sealed class InputEventControlEnumerator : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Device;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_StateOffsetToControlIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_StateOffsetToControlIndexLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_AllControls;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultState;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentState;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_NoiseMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_EventPtr;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentIndexInStateOffsetToControlIndexMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentControlStateBitOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_EventState;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentBitOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_EndBitOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MagnitudeThreshold;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputEventPtr_InputDevice_Enumerate_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckDefault_Private_Boolean_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckCurrent_Private_Boolean_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe Enumerate m_Flags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
				return *(Enumerate*)num;
			}
			set
			{
				*(Enumerate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		public unsafe InputDevice m_Device
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Device);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Device)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<uint> m_StateOffsetToControlIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlIndex);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_StateOffsetToControlIndexLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlIndexLength);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlIndexLength)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<InputControl> m_AllControls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllControls);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControl>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllControls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe byte* m_DefaultState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultState);
				return *(byte**)num;
			}
			set
			{
				*(byte**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultState)) = value;
			}
		}

		public unsafe byte* m_CurrentState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentState);
				return *(byte**)num;
			}
			set
			{
				*(byte**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentState)) = value;
			}
		}

		public unsafe byte* m_NoiseMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NoiseMask);
				return *(byte**)num;
			}
			set
			{
				*(byte**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NoiseMask)) = value;
			}
		}

		public unsafe InputEventPtr m_EventPtr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventPtr);
				return *(InputEventPtr*)num;
			}
			set
			{
				*(InputEventPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventPtr)) = value;
			}
		}

		public unsafe InputControl m_CurrentControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentControl);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentControl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_CurrentIndexInStateOffsetToControlIndexMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentIndexInStateOffsetToControlIndexMap);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentIndexInStateOffsetToControlIndexMap)) = value;
			}
		}

		public unsafe uint m_CurrentControlStateBitOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentControlStateBitOffset);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentControlStateBitOffset)) = value;
			}
		}

		public unsafe byte* m_EventState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventState);
				return *(byte**)num;
			}
			set
			{
				*(byte**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventState)) = value;
			}
		}

		public unsafe uint m_CurrentBitOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBitOffset);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBitOffset)) = value;
			}
		}

		public unsafe uint m_EndBitOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndBitOffset);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndBitOffset)) = value;
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

		public unsafe virtual InputControl Current
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		static InputEventControlEnumerator()
		{
			Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, "InputEventControlEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr);
			NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_Flags");
			NativeFieldInfoPtr_m_Device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_Device");
			NativeFieldInfoPtr_m_StateOffsetToControlIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_StateOffsetToControlIndex");
			NativeFieldInfoPtr_m_StateOffsetToControlIndexLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_StateOffsetToControlIndexLength");
			NativeFieldInfoPtr_m_AllControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_AllControls");
			NativeFieldInfoPtr_m_DefaultState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_DefaultState");
			NativeFieldInfoPtr_m_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_CurrentState");
			NativeFieldInfoPtr_m_NoiseMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_NoiseMask");
			NativeFieldInfoPtr_m_EventPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_EventPtr");
			NativeFieldInfoPtr_m_CurrentControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_CurrentControl");
			NativeFieldInfoPtr_m_CurrentIndexInStateOffsetToControlIndexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_CurrentIndexInStateOffsetToControlIndexMap");
			NativeFieldInfoPtr_m_CurrentControlStateBitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_CurrentControlStateBitOffset");
			NativeFieldInfoPtr_m_EventState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_EventState");
			NativeFieldInfoPtr_m_CurrentBitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_CurrentBitOffset");
			NativeFieldInfoPtr_m_EndBitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_EndBitOffset");
			NativeFieldInfoPtr_m_MagnitudeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, "m_MagnitudeThreshold");
			NativeMethodInfoPtr__ctor_Internal_Void_InputEventPtr_InputDevice_Enumerate_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664737);
			NativeMethodInfoPtr_CheckDefault_Private_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664738);
			NativeMethodInfoPtr_CheckCurrent_Private_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664739);
			NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664740);
			NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664741);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664742);
			NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664743);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, 100664744);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 974071, RefRangeEnd = 974076, XrefRangeStart = 974047, XrefRangeEnd = 974071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputEventControlEnumerator(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold = 0f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&eventPtr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			*(Enumerate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &magnitudeThreshold;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_InputEventPtr_InputDevice_Enumerate_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974076, XrefRangeEnd = 974077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckDefault(uint numBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&numBits);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDefault_Private_Boolean_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974077, XrefRangeEnd = 974078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCurrent(uint numBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&numBits);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCurrent_Private_Boolean_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 974081, RefRangeEnd = 974086, XrefRangeStart = 974078, XrefRangeEnd = 974081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 974108, RefRangeEnd = 974109, XrefRangeStart = 974086, XrefRangeEnd = 974108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 974109, RefRangeEnd = 974117, XrefRangeStart = 974109, XrefRangeEnd = 974109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public InputEventControlEnumerator(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public InputEventControlEnumerator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr))
		{
		}
	}

	public sealed class ControlBuilder : Il2CppSystem.ValueType
	{
		private sealed class MethodInfoStoreGeneric_WithProcessor_Public_ControlBuilder_TProcessor_0<TProcessor, TValue>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WithProcessor_Public_ControlBuilder_TProcessor_0, Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TProcessor>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__control_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_control_Public_get_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_control_Internal_set_Void_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_At_Public_ControlBuilder_InputDevice_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithParent_Public_ControlBuilder_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithName_Public_ControlBuilder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithDisplayName_Public_ControlBuilder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithShortDisplayName_Public_ControlBuilder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithLayout_Public_ControlBuilder_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithAliases_Public_ControlBuilder_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithChildren_Public_ControlBuilder_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithStateBlock_Public_ControlBuilder_InputStateBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithDefaultState_Public_ControlBuilder_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithMinAndMax_Public_ControlBuilder_PrimitiveValue_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithProcessor_Public_ControlBuilder_TProcessor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsNoisy_Public_ControlBuilder_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsSynthetic_Public_ControlBuilder_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DontReset_Public_ControlBuilder_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsButton_Public_ControlBuilder_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Finish_Public_Void_0;

		public unsafe InputControl _control_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__control_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__control_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputControl control
		{
			[CallerCount(98)]
			[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_control_Public_get_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_control_Internal_set_Void_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static ControlBuilder()
		{
			Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, "ControlBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr);
			NativeFieldInfoPtr__control_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, "<control>k__BackingField");
			NativeMethodInfoPtr_get_control_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664745);
			NativeMethodInfoPtr_set_control_Internal_set_Void_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664746);
			NativeMethodInfoPtr_At_Public_ControlBuilder_InputDevice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664747);
			NativeMethodInfoPtr_WithParent_Public_ControlBuilder_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664748);
			NativeMethodInfoPtr_WithName_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664749);
			NativeMethodInfoPtr_WithDisplayName_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664750);
			NativeMethodInfoPtr_WithShortDisplayName_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664751);
			NativeMethodInfoPtr_WithLayout_Public_ControlBuilder_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664752);
			NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664753);
			NativeMethodInfoPtr_WithAliases_Public_ControlBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664754);
			NativeMethodInfoPtr_WithChildren_Public_ControlBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664755);
			NativeMethodInfoPtr_WithStateBlock_Public_ControlBuilder_InputStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664756);
			NativeMethodInfoPtr_WithDefaultState_Public_ControlBuilder_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664757);
			NativeMethodInfoPtr_WithMinAndMax_Public_ControlBuilder_PrimitiveValue_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664758);
			NativeMethodInfoPtr_WithProcessor_Public_ControlBuilder_TProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664759);
			NativeMethodInfoPtr_IsNoisy_Public_ControlBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664760);
			NativeMethodInfoPtr_IsSynthetic_Public_ControlBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664761);
			NativeMethodInfoPtr_DontReset_Public_ControlBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664762);
			NativeMethodInfoPtr_IsButton_Public_ControlBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664763);
			NativeMethodInfoPtr_Finish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100664764);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974117, XrefRangeEnd = 974120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder At(InputDevice device, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_At_Public_ControlBuilder_InputDevice_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974120, XrefRangeEnd = 974121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder WithParent(InputControl parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithParent_Public_ControlBuilder_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974121, XrefRangeEnd = 974123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder WithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithName_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974123, XrefRangeEnd = 974126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder WithDisplayName(string displayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDisplayName_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974126, XrefRangeEnd = 974129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder WithShortDisplayName(string shortDisplayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shortDisplayName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithShortDisplayName_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974129, XrefRangeEnd = 974130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder WithLayout(InternedString layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layout));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithLayout_Public_ControlBuilder_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder WithUsages(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&startIndex);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder WithAliases(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&startIndex);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithAliases_Public_ControlBuilder_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder WithChildren(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&startIndex);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithChildren_Public_ControlBuilder_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder WithStateBlock(InputStateBlock stateBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&stateBlock);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithStateBlock_Public_ControlBuilder_InputStateBlock_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder WithDefaultState(PrimitiveValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDefaultState_Public_ControlBuilder_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&min);
			*(PrimitiveValue**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithMinAndMax_Public_ControlBuilder_PrimitiveValue_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974130, XrefRangeEnd = 974133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor) where TProcessor : InputProcessor<TValue> where TValue : new()
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TProcessor reference;
			if (!typeof(TProcessor).IsValueType)
			{
				TProcessor val = processor;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref processor;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WithProcessor_Public_ControlBuilder_TProcessor_0<TProcessor, TValue>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974133, XrefRangeEnd = 974134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder IsNoisy(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNoisy_Public_ControlBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder IsSynthetic(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSynthetic_Public_ControlBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder DontReset(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DontReset_Public_ControlBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe ControlBuilder IsButton(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsButton_Public_ControlBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finish_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ControlBuilder(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ControlBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr))
		{
		}
	}

	public sealed class DeviceBuilder : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__device_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_device_Public_get_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_device_Internal_set_Void_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithName_Public_DeviceBuilder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithDisplayName_Public_DeviceBuilder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithShortDisplayName_Public_DeviceBuilder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithLayout_Public_DeviceBuilder_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithChildren_Public_DeviceBuilder_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithStateBlock_Public_DeviceBuilder_InputStateBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsNoisy_Public_DeviceBuilder_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithControlUsage_Public_DeviceBuilder_Int32_InternedString_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithControlAlias_Public_DeviceBuilder_Int32_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithStateOffsetToControlIndexMap_Public_DeviceBuilder_Il2CppStructArray_1_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithControlTree_Public_DeviceBuilder_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Finish_Public_Void_0;

		public unsafe InputDevice _device_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputDevice device
		{
			[CallerCount(98)]
			[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_device_Public_get_InputDevice_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_device_Internal_set_Void_InputDevice_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static DeviceBuilder()
		{
			Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, "DeviceBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr);
			NativeFieldInfoPtr__device_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, "<device>k__BackingField");
			NativeMethodInfoPtr_get_device_Public_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664765);
			NativeMethodInfoPtr_set_device_Internal_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664766);
			NativeMethodInfoPtr_WithName_Public_DeviceBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664767);
			NativeMethodInfoPtr_WithDisplayName_Public_DeviceBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664768);
			NativeMethodInfoPtr_WithShortDisplayName_Public_DeviceBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664769);
			NativeMethodInfoPtr_WithLayout_Public_DeviceBuilder_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664770);
			NativeMethodInfoPtr_WithChildren_Public_DeviceBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664771);
			NativeMethodInfoPtr_WithStateBlock_Public_DeviceBuilder_InputStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664772);
			NativeMethodInfoPtr_IsNoisy_Public_DeviceBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664773);
			NativeMethodInfoPtr_WithControlUsage_Public_DeviceBuilder_Int32_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664774);
			NativeMethodInfoPtr_WithControlAlias_Public_DeviceBuilder_Int32_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664775);
			NativeMethodInfoPtr_WithStateOffsetToControlIndexMap_Public_DeviceBuilder_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664776);
			NativeMethodInfoPtr_WithControlTree_Public_DeviceBuilder_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664777);
			NativeMethodInfoPtr_Finish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr, 100664778);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithName_Public_DeviceBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithDisplayName(string displayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDisplayName_Public_DeviceBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithShortDisplayName(string shortDisplayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shortDisplayName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithShortDisplayName_Public_DeviceBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithLayout(InternedString layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layout));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithLayout_Public_DeviceBuilder_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe DeviceBuilder WithChildren(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&startIndex);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithChildren_Public_DeviceBuilder_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		public unsafe DeviceBuilder WithStateBlock(InputStateBlock stateBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&stateBlock);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithStateBlock_Public_DeviceBuilder_InputStateBlock_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder IsNoisy(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNoisy_Public_DeviceBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974134, XrefRangeEnd = 974137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&controlIndex);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usage));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithControlUsage_Public_DeviceBuilder_Int32_InternedString_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974137, XrefRangeEnd = 974138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithControlAlias(int controlIndex, InternedString alias)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&controlIndex);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)alias));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithControlAlias_Public_DeviceBuilder_Int32_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974138, XrefRangeEnd = 974139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithStateOffsetToControlIndexMap(Il2CppStructArray<uint> map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithStateOffsetToControlIndexMap_Public_DeviceBuilder_Il2CppStructArray_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974139, XrefRangeEnd = 974146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBuilder WithControlTree(Il2CppStructArray<byte> controlTreeNodes, Il2CppStructArray<ushort> controlTreeIndicies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlTreeNodes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlTreeIndicies);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithControlTree_Public_DeviceBuilder_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DeviceBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974146, XrefRangeEnd = 974181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finish_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DeviceBuilder(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public DeviceBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceBuilder>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("UnityEngine.InputSystem.InputControlExtensions+<GetAllButtonPresses>d__43")]
	public sealed class _GetAllButtonPresses_d__43 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;

		private static readonly System.IntPtr NativeFieldInfoPtr_eventPtr;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__eventPtr;

		private static readonly System.IntPtr NativeFieldInfoPtr_magnitude;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__magnitude;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttonControlsOnly;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__buttonControlsOnly;

		private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_InputControl__get_Current_Private_Virtual_Final_New_get_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = value;
			}
		}

		public unsafe InputControl __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int __l__initialThreadId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId)) = value;
			}
		}

		public unsafe InputEventPtr eventPtr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPtr);
				return *(InputEventPtr*)num;
			}
			set
			{
				*(InputEventPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPtr)) = value;
			}
		}

		public unsafe InputEventPtr __3__eventPtr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__eventPtr);
				return *(InputEventPtr*)num;
			}
			set
			{
				*(InputEventPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__eventPtr)) = value;
			}
		}

		public unsafe float magnitude
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_magnitude);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_magnitude)) = value;
			}
		}

		public unsafe float __3__magnitude
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__magnitude);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__magnitude)) = value;
			}
		}

		public unsafe bool buttonControlsOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonControlsOnly);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonControlsOnly)) = value;
			}
		}

		public unsafe bool __3__buttonControlsOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__buttonControlsOnly);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__buttonControlsOnly)) = value;
			}
		}

		public unsafe InputEventControlEnumerator __7__wrap1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap1);
				return new InputEventControlEnumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputEventControlEnumerator>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe virtual InputControl System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EInputSystem_002EInputControl_003E_002ECurrent
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_InputControl__get_Current_Private_Virtual_Final_New_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
		}

		static _GetAllButtonPresses_d__43()
		{
			Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, "<GetAllButtonPresses>d__43");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "<>l__initialThreadId");
			NativeFieldInfoPtr_eventPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "eventPtr");
			NativeFieldInfoPtr___3__eventPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "<>3__eventPtr");
			NativeFieldInfoPtr_magnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "magnitude");
			NativeFieldInfoPtr___3__magnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "<>3__magnitude");
			NativeFieldInfoPtr_buttonControlsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "buttonControlsOnly");
			NativeFieldInfoPtr___3__buttonControlsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "<>3__buttonControlsOnly");
			NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, "<>7__wrap1");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664779);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664780);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664781);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664782);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_InputControl__get_Current_Private_Virtual_Final_New_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664783);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664784);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664785);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664786);
			NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr, 100664787);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 682723, RefRangeEnd = 682733, XrefRangeStart = 682723, XrefRangeEnd = 682733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _GetAllButtonPresses_d__43(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GetAllButtonPresses_d__43>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 974182, RefRangeEnd = 974183, XrefRangeStart = 974181, XrefRangeEnd = 974182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974183, XrefRangeEnd = 974199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974199, XrefRangeEnd = 974204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974204, XrefRangeEnd = 974211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<InputControl> System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControl__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<InputControl>>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		public _GetAllButtonPresses_d__43(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_FindInParentChain_Public_Static_TControl_InputControl_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindInParentChain_Public_Static_TControl_InputControl_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadUnprocessedValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadUnprocessedValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadUnprocessedValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadUnprocessedValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_TValue_ptr_Void_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_TValue_ptr_Void_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_ptr_Void_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_ptr_Void_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_ptr_Void_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_ptr_Void_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_byref_TState_0<TValue, TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_byref_TState_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_WriteValueIntoEvent_Public_Static_Void_InputControl_TValue_InputEventPtr_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteValueIntoEvent_Public_Static_Void_InputControl_TValue_InputEventPtr_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteValueIntoEvent_Public_Static_Void_InputControl_1_TValue_TValue_InputEventPtr_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteValueIntoEvent_Public_Static_Void_InputControl_1_TValue_TValue_InputEventPtr_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CopyState_Public_Static_Void_InputDevice_byref_TState_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyState_Public_Static_Void_InputDevice_byref_TState_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_QueueValueChange_Public_Static_Void_InputControl_1_TValue_TValue_Double_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QueueValueChange_Public_Static_Void_InputControl_1_TValue_TValue_Double_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_FindControlsRecursive_Public_Static_Void_InputControl_IList_1_TControl_Func_2_TControl_Boolean_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindControlsRecursive_Public_Static_Void_InputControl_IList_1_TControl_Func_2_TControl_Boolean_0, Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_FindInParentChain_Public_Static_TControl_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPressed_Public_Static_Boolean_InputControl_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActuated_Public_Static_Boolean_InputControl_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueAsObject_Public_Static_Object_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueIntoBuffer_Public_Static_Void_InputControl_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadDefaultValueAsObject_Public_Static_Object_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromEventAsObject_Public_Static_Object_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUnprocessedValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUnprocessedValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueFromObjectIntoEvent_Public_Static_Void_InputControl_InputEventPtr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_byref_TState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoEvent_Public_Static_Void_InputControl_TValue_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoEvent_Public_Static_Void_InputControl_1_TValue_TValue_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyState_Public_Static_Void_InputDevice_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyState_Public_Static_Void_InputDevice_byref_TState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckStateIsAtDefault_Public_Static_Boolean_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckStateIsAtDefault_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckStateIsAtDefaultIgnoringNoise_Public_Static_Boolean_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckStateIsAtDefaultIgnoringNoise_Public_Static_Boolean_InputControl_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareStateIgnoringNoise_Public_Static_Boolean_InputControl_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareState_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareState_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasValueChangeInState_Public_Static_Boolean_InputControl_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasValueChangeInEvent_Public_Static_Boolean_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStatePtrFromStateEvent_Public_Static_ptr_Void_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStatePtrFromStateEventUnchecked_Internal_Static_ptr_Void_InputControl_InputEventPtr_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetToDefaultStateInEvent_Public_Static_Boolean_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueValueChange_Public_Static_Void_InputControl_1_TValue_TValue_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AccumulateValueInEvent_Public_Static_Void_InputControl_1_Single_ptr_Void_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AccumulateValueInEvent_Internal_Static_Void_InputControl_1_Vector2_ptr_Void_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControlsRecursive_Public_Static_Void_InputControl_IList_1_TControl_Func_2_TControl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildPath_Internal_Static_String_InputControl_String_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateControls_Public_Static_InputEventControlCollection_InputEventPtr_Enumerate_InputDevice_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateChangedControls_Public_Static_InputEventControlCollection_InputEventPtr_InputDevice_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasButtonPress_Public_Static_Boolean_InputEventPtr_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstButtonPressOrNull_Public_Static_InputControl_InputEventPtr_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllButtonPresses_Public_Static_IEnumerable_1_InputControl_InputEventPtr_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Static_ControlBuilder_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Static_DeviceBuilder_InputDevice_Int32_Int32_Int32_0;

	static InputControlExtensions()
	{
		Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputControlExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_FindInParentChain_Public_Static_TControl_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr_IsPressed_Public_Static_Boolean_InputControl_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664689);
		NativeMethodInfoPtr_IsActuated_Public_Static_Boolean_InputControl_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664690);
		NativeMethodInfoPtr_ReadValueAsObject_Public_Static_Object_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664691);
		NativeMethodInfoPtr_ReadValueIntoBuffer_Public_Static_Void_InputControl_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664692);
		NativeMethodInfoPtr_ReadDefaultValueAsObject_Public_Static_Object_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664693);
		NativeMethodInfoPtr_ReadValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664694);
		NativeMethodInfoPtr_ReadValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664695);
		NativeMethodInfoPtr_ReadValueFromEventAsObject_Public_Static_Object_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664696);
		NativeMethodInfoPtr_ReadUnprocessedValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664697);
		NativeMethodInfoPtr_ReadUnprocessedValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664698);
		NativeMethodInfoPtr_WriteValueFromObjectIntoEvent_Public_Static_Void_InputControl_InputEventPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664702);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_byref_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr_WriteValueIntoEvent_Public_Static_Void_InputControl_TValue_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664705);
		NativeMethodInfoPtr_WriteValueIntoEvent_Public_Static_Void_InputControl_1_TValue_TValue_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664706);
		NativeMethodInfoPtr_CopyState_Public_Static_Void_InputDevice_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664707);
		NativeMethodInfoPtr_CopyState_Public_Static_Void_InputDevice_byref_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664708);
		NativeMethodInfoPtr_CheckStateIsAtDefault_Public_Static_Boolean_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664709);
		NativeMethodInfoPtr_CheckStateIsAtDefault_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664710);
		NativeMethodInfoPtr_CheckStateIsAtDefaultIgnoringNoise_Public_Static_Boolean_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664711);
		NativeMethodInfoPtr_CheckStateIsAtDefaultIgnoringNoise_Public_Static_Boolean_InputControl_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664712);
		NativeMethodInfoPtr_CompareStateIgnoringNoise_Public_Static_Boolean_InputControl_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664713);
		NativeMethodInfoPtr_CompareState_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664714);
		NativeMethodInfoPtr_CompareState_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664715);
		NativeMethodInfoPtr_HasValueChangeInState_Public_Static_Boolean_InputControl_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664716);
		NativeMethodInfoPtr_HasValueChangeInEvent_Public_Static_Boolean_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664717);
		NativeMethodInfoPtr_GetStatePtrFromStateEvent_Public_Static_ptr_Void_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664718);
		NativeMethodInfoPtr_GetStatePtrFromStateEventUnchecked_Internal_Static_ptr_Void_InputControl_InputEventPtr_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664719);
		NativeMethodInfoPtr_ResetToDefaultStateInEvent_Public_Static_Boolean_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664720);
		NativeMethodInfoPtr_QueueValueChange_Public_Static_Void_InputControl_1_TValue_TValue_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664721);
		NativeMethodInfoPtr_AccumulateValueInEvent_Public_Static_Void_InputControl_1_Single_ptr_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664722);
		NativeMethodInfoPtr_AccumulateValueInEvent_Internal_Static_Void_InputControl_1_Vector2_ptr_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664723);
		NativeMethodInfoPtr_FindControlsRecursive_Public_Static_Void_InputControl_IList_1_TControl_Func_2_TControl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664724);
		NativeMethodInfoPtr_BuildPath_Internal_Static_String_InputControl_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664725);
		NativeMethodInfoPtr_EnumerateControls_Public_Static_InputEventControlCollection_InputEventPtr_Enumerate_InputDevice_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664726);
		NativeMethodInfoPtr_EnumerateChangedControls_Public_Static_InputEventControlCollection_InputEventPtr_InputDevice_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664727);
		NativeMethodInfoPtr_HasButtonPress_Public_Static_Boolean_InputEventPtr_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664728);
		NativeMethodInfoPtr_GetFirstButtonPressOrNull_Public_Static_InputControl_InputEventPtr_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664729);
		NativeMethodInfoPtr_GetAllButtonPresses_Public_Static_IEnumerable_1_InputControl_InputEventPtr_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664730);
		NativeMethodInfoPtr_Setup_Public_Static_ControlBuilder_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664731);
		NativeMethodInfoPtr_Setup_Public_Static_DeviceBuilder_InputDevice_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlExtensions>.NativeClassPtr, 100664732);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974214, RefRangeEnd = 974215, XrefRangeStart = 974211, XrefRangeEnd = 974214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TControl FindInParentChain<TControl>(this InputControl control) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindInParentChain_Public_Static_TControl_InputControl_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 974231, RefRangeEnd = 974234, XrefRangeStart = 974215, XrefRangeEnd = 974231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPressed(this InputControl control, float buttonPressPoint = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonPressPoint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPressed_Public_Static_Boolean_InputControl_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974234, XrefRangeEnd = 974242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsActuated(this InputControl control, float threshold = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActuated_Public_Static_Boolean_InputControl_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974250, RefRangeEnd = 974251, XrefRangeStart = 974242, XrefRangeEnd = 974250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object ReadValueAsObject(this InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueAsObject_Public_Static_Object_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974253, RefRangeEnd = 974254, XrefRangeStart = 974251, XrefRangeEnd = 974253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValueIntoBuffer(this InputControl control, void* buffer, int bufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueIntoBuffer_Public_Static_Void_InputControl_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974254, XrefRangeEnd = 974262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object ReadDefaultValueAsObject(this InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadDefaultValueAsObject_Public_Static_Object_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974262, XrefRangeEnd = 974272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TValue ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputEvent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974272, XrefRangeEnd = 974278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) where TValue : new()
	{
		//IL_0046->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputEvent;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(TValue).IsValueType)
		{
			nint num3 = num2;
			Unsafe.As<TValue, object>(ref value) = ((num3 == 0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num3, false, false));
		}
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974278, XrefRangeEnd = 974287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object ReadValueFromEventAsObject(this InputControl control, InputEventPtr inputEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputEvent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueFromEventAsObject_Public_Static_Object_InputControl_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974287, XrefRangeEnd = 974294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TValue ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr eventPtr) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadUnprocessedValueFromEvent_Public_Static_TValue_InputControl_1_TValue_InputEventPtr_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974296, RefRangeEnd = 974297, XrefRangeStart = 974294, XrefRangeEnd = 974296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) where TValue : new()
	{
		//IL_0046->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputEvent;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadUnprocessedValueFromEvent_Public_Static_Boolean_InputControl_1_TValue_InputEventPtr_byref_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(TValue).IsValueType)
		{
			nint num3 = num2;
			Unsafe.As<TValue, object>(ref value) = ((num3 == 0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num3, false, false));
		}
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974297, XrefRangeEnd = 974298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueFromObjectIntoEvent(this InputControl control, InputEventPtr eventPtr, Il2CppSystem.Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueFromObjectIntoEvent_Public_Static_Void_InputControl_InputEventPtr_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974298, XrefRangeEnd = 974304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueIntoState(this InputControl control, void* statePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueIntoState_Public_Static_Void_InputControl_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974341, RefRangeEnd = 974342, XrefRangeStart = 974304, XrefRangeEnd = 974341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueIntoState<TValue>(this InputControl control, TValue value, void* statePtr) where TValue : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
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
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_TValue_ptr_Void_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974342, XrefRangeEnd = 974343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueIntoState<TValue>(this InputControl<TValue> control, TValue value, void* statePtr) where TValue : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
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
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_ptr_Void_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974343, XrefRangeEnd = 974345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueIntoState<TValue>(this InputControl<TValue> control, void* statePtr) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_ptr_Void_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974345, XrefRangeEnd = 974353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueIntoState<TValue, TState>(this InputControl<TValue> control, TValue value, ref TState state) where TValue : new() where TState : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
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
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TState, object>(ref state));
		*(System.IntPtr**)num2 = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteValueIntoState_Public_Static_Void_InputControl_1_TValue_TValue_byref_TState_0<TValue, TState>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TState, object>(ref state) = ((intPtr4 == (System.IntPtr)0) ? ((TState)null) : IL2CPP.PointerToValueGeneric<TState>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974353, XrefRangeEnd = 974358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueIntoEvent<TValue>(this InputControl control, TValue value, InputEventPtr eventPtr) where TValue : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
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
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteValueIntoEvent_Public_Static_Void_InputControl_TValue_InputEventPtr_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 974360, RefRangeEnd = 974362, XrefRangeStart = 974358, XrefRangeEnd = 974360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueIntoEvent<TValue>(this InputControl<TValue> control, TValue value, InputEventPtr eventPtr) where TValue : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
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
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteValueIntoEvent_Public_Static_Void_InputControl_1_TValue_TValue_InputEventPtr_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974373, RefRangeEnd = 974374, XrefRangeStart = 974362, XrefRangeEnd = 974373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyState(this InputDevice device, void* buffer, int bufferSizeInBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSizeInBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyState_Public_Static_Void_InputDevice_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974423, RefRangeEnd = 974424, XrefRangeStart = 974374, XrefRangeEnd = 974423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyState<TState>(this InputDevice device, out TState state) where TState : new()
	{
		//IL_0037->IL0039: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref TState reference;
		if (!typeof(TState).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref state;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyState_Public_Static_Void_InputDevice_byref_TState_0<TState>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(TState).IsValueType)
		{
			nint num3 = num2;
			Unsafe.As<TState, object>(ref state) = ((num3 == 0) ? ((TState)null) : IL2CPP.PointerToValueGeneric<TState>((System.IntPtr)num3, false, false));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 974429, RefRangeEnd = 974432, XrefRangeStart = 974424, XrefRangeEnd = 974429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckStateIsAtDefault(this InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckStateIsAtDefault_Public_Static_Boolean_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 974435, RefRangeEnd = 974437, XrefRangeStart = 974432, XrefRangeEnd = 974435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckStateIsAtDefault(this InputControl control, void* statePtr, void* maskPtr = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = maskPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckStateIsAtDefault_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974437, XrefRangeEnd = 974444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckStateIsAtDefaultIgnoringNoise_Public_Static_Boolean_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974444, XrefRangeEnd = 974449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control, void* statePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckStateIsAtDefaultIgnoringNoise_Public_Static_Boolean_InputControl_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974449, XrefRangeEnd = 974454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareStateIgnoringNoise(this InputControl control, void* statePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareStateIgnoringNoise_Public_Static_Boolean_InputControl_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 974465, RefRangeEnd = 974475, XrefRangeStart = 974454, XrefRangeEnd = 974465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareState(this InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = firstStatePtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = secondStatePtr;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = maskPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareState_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974475, XrefRangeEnd = 974478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareState(this InputControl control, void* statePtr, void* maskPtr = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = maskPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareState_Public_Static_Boolean_InputControl_ptr_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974492, RefRangeEnd = 974493, XrefRangeStart = 974478, XrefRangeEnd = 974492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasValueChangeInState(this InputControl control, void* statePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValueChangeInState_Public_Static_Boolean_InputControl_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974493, XrefRangeEnd = 974497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasValueChangeInEvent(this InputControl control, InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValueChangeInEvent_Public_Static_Boolean_InputControl_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 974500, RefRangeEnd = 974507, XrefRangeStart = 974497, XrefRangeEnd = 974500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetStatePtrFromStateEvent(this InputControl control, InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStatePtrFromStateEvent_Public_Static_ptr_Void_InputControl_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 974530, RefRangeEnd = 974536, XrefRangeStart = 974507, XrefRangeEnd = 974530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetStatePtrFromStateEventUnchecked(this InputControl control, InputEventPtr eventPtr, FourCC eventType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		*(FourCC**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStatePtrFromStateEventUnchecked_Internal_Static_ptr_Void_InputControl_InputEventPtr_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974545, RefRangeEnd = 974546, XrefRangeStart = 974536, XrefRangeEnd = 974545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ResetToDefaultStateInEvent(this InputControl control, InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetToDefaultStateInEvent_Public_Static_Boolean_InputControl_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974546, XrefRangeEnd = 974561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueValueChange<TValue>(this InputControl<TValue> control, TValue value, double time = -1.0) where TValue : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
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
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QueueValueChange_Public_Static_Void_InputControl_1_TValue_TValue_Double_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974561, XrefRangeEnd = 974567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AccumulateValueInEvent(this InputControl<float> control, void* currentStatePtr, InputEventPtr newState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = currentStatePtr;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AccumulateValueInEvent_Public_Static_Void_InputControl_1_Single_ptr_Void_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 974573, RefRangeEnd = 974579, XrefRangeStart = 974567, XrefRangeEnd = 974573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AccumulateValueInEvent(this InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = currentStatePtr;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AccumulateValueInEvent_Internal_Static_Void_InputControl_1_Vector2_ptr_Void_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974591, RefRangeEnd = 974592, XrefRangeStart = 974579, XrefRangeEnd = 974591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FindControlsRecursive<TControl>(this InputControl parent, IList<TControl> controls, Il2CppSystem.Func<TControl, bool> predicate) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controls);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindControlsRecursive_Public_Static_Void_InputControl_IList_1_TControl_Func_2_TControl_Boolean_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974629, RefRangeEnd = 974630, XrefRangeStart = 974592, XrefRangeEnd = 974629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string BuildPath(this InputControl control, string deviceLayout, StringBuilder builder = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(deviceLayout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildPath_Internal_Static_String_InputControl_String_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 974642, RefRangeEnd = 974647, XrefRangeStart = 974630, XrefRangeEnd = 974642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputEventControlCollection EnumerateControls(this InputEventPtr eventPtr, Enumerate flags, InputDevice device = null, float magnitudeThreshold = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&eventPtr);
		*(Enumerate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &magnitudeThreshold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumerateControls_Public_Static_InputEventControlCollection_InputEventPtr_Enumerate_InputDevice_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputEventControlCollection(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974648, RefRangeEnd = 974649, XrefRangeStart = 974647, XrefRangeEnd = 974648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputEventControlCollection EnumerateChangedControls(this InputEventPtr eventPtr, InputDevice device = null, float magnitudeThreshold = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&eventPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &magnitudeThreshold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumerateChangedControls_Public_Static_InputEventControlCollection_InputEventPtr_InputDevice_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputEventControlCollection(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974649, XrefRangeEnd = 974650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasButtonPress(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&eventPtr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &magnitude;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonControlsOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasButtonPress_Public_Static_Boolean_InputEventPtr_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 974661, RefRangeEnd = 974663, XrefRangeStart = 974650, XrefRangeEnd = 974661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControl GetFirstButtonPressOrNull(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&eventPtr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &magnitude;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonControlsOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstButtonPressOrNull_Public_Static_InputControl_InputEventPtr_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974663, XrefRangeEnd = 974668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<InputControl> GetAllButtonPresses(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&eventPtr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &magnitude;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonControlsOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllButtonPresses_Public_Static_IEnumerable_1_InputControl_InputEventPtr_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InputControl>>(intPtr2) : null;
	}

	[CallerCount(459)]
	[CachedScanResults(RefRangeStart = 974669, RefRangeEnd = 975128, XrefRangeStart = 974668, XrefRangeEnd = 974669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ControlBuilder Setup(this InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Static_ControlBuilder_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ControlBuilder(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 975144, RefRangeEnd = 975147, XrefRangeStart = 975128, XrefRangeEnd = 975144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DeviceBuilder Setup(this InputDevice device, int controlCount, int usageCount, int aliasCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlCount;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &usageCount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &aliasCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Static_DeviceBuilder_InputDevice_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DeviceBuilder(pointer);
	}

	public InputControlExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
