using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

public class InputManagerProvider : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ButtonEventsIterator
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__mask;

		private static readonly System.IntPtr NativeFieldInfoPtr__bit;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FromState_Public_Static_ButtonEventsIterator_Boolean_Boolean_Boolean_Boolean_0;

		[FieldOffset(0)]
		public uint _mask;

		[FieldOffset(4)]
		public int _bit;

		public unsafe bool Current
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251866, XrefRangeEnd = 1251868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
		}

		static ButtonEventsIterator()
		{
			Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "ButtonEventsIterator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr);
			NativeFieldInfoPtr__mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, "_mask");
			NativeFieldInfoPtr__bit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, "_bit");
			NativeMethodInfoPtr_get_Current_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, 100663469);
			NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, 100663470);
			NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, 100663471);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, 100663472);
			NativeMethodInfoPtr_FromState_Public_Static_ButtonEventsIterator_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, 100663473);
		}

		[CallerCount(0)]
		public unsafe virtual bool MoveNext()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe static ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&previous);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &down;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &up;
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &current;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromState_Public_Static_ButtonEventsIterator_Boolean_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ButtonEventsIterator*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ButtonEventsIterator>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class Configuration : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalAxis;

		private static readonly System.IntPtr NativeFieldInfoPtr_VerticalAxis;

		private static readonly System.IntPtr NativeFieldInfoPtr_SubmitButton;

		private static readonly System.IntPtr NativeFieldInfoPtr_CancelButton;

		private static readonly System.IntPtr NativeFieldInfoPtr_NavigateNextButton;

		private static readonly System.IntPtr NativeFieldInfoPtr_NavigatePreviousButton;

		private static readonly System.IntPtr NativeFieldInfoPtr_InputActionsPerSecond;

		private static readonly System.IntPtr NativeFieldInfoPtr_RepeatDelay;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultConfiguration_Public_Static_Configuration_0;

		public unsafe string HorizontalAxis
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalAxis);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalAxis)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string VerticalAxis
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalAxis);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalAxis)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string SubmitButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubmitButton);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubmitButton)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string CancelButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CancelButton);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CancelButton)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string NavigateNextButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NavigateNextButton);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NavigateNextButton)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string NavigatePreviousButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NavigatePreviousButton);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NavigatePreviousButton)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe float InputActionsPerSecond
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputActionsPerSecond);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputActionsPerSecond)) = value;
			}
		}

		public unsafe float RepeatDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepeatDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepeatDelay)) = value;
			}
		}

		static Configuration()
		{
			Il2CppClassPointerStore<Configuration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "Configuration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Configuration>.NativeClassPtr);
			NativeFieldInfoPtr_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "HorizontalAxis");
			NativeFieldInfoPtr_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "VerticalAxis");
			NativeFieldInfoPtr_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "SubmitButton");
			NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "CancelButton");
			NativeFieldInfoPtr_NavigateNextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "NavigateNextButton");
			NativeFieldInfoPtr_NavigatePreviousButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "NavigatePreviousButton");
			NativeFieldInfoPtr_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "InputActionsPerSecond");
			NativeFieldInfoPtr_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Configuration>.NativeClassPtr, "RepeatDelay");
			NativeMethodInfoPtr_GetDefaultConfiguration_Public_Static_Configuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Configuration>.NativeClassPtr, 100663474);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251868, XrefRangeEnd = 1251886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Configuration GetDefaultConfiguration()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultConfiguration_Public_Static_Configuration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Configuration(pointer);
		}

		public Configuration(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Configuration()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Configuration>.NativeClassPtr))
		{
		}
	}

	public class IInput : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionString_Public_Abstract_Virtual_New_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Public_Abstract_Virtual_New_Boolean_KeyCode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Public_Abstract_Virtual_New_PenData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Abstract_Virtual_New_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Abstract_Virtual_New_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Abstract_Virtual_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Public_Abstract_Virtual_New_get_Vector2_0;

		public unsafe virtual string compositionString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_compositionString_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe virtual bool touchSupported
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_touchSupported_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual int touchCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual bool mousePresent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_mousePresent_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual Vector3 mousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual Vector2 mouseScrollDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_mouseScrollDelta_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static IInput()
		{
			Il2CppClassPointerStore<IInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "IInput");
			NativeMethodInfoPtr_get_compositionString_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663475);
			NativeMethodInfoPtr_GetKey_Public_Abstract_Virtual_New_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663476);
			NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663477);
			NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663478);
			NativeMethodInfoPtr_GetLastPenContactEvent_Public_Abstract_Virtual_New_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663479);
			NativeMethodInfoPtr_get_touchSupported_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663480);
			NativeMethodInfoPtr_get_touchCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663481);
			NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663482);
			NativeMethodInfoPtr_get_mousePresent_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663483);
			NativeMethodInfoPtr_GetMouseButton_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663484);
			NativeMethodInfoPtr_GetMouseButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663485);
			NativeMethodInfoPtr_GetMouseButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663486);
			NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663487);
			NativeMethodInfoPtr_get_mouseScrollDelta_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInput>.NativeClassPtr, 100663488);
		}

		[CallerCount(0)]
		public unsafe virtual bool GetKey(KeyCode keyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&keyCode);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetKey_Public_Abstract_Virtual_New_Boolean_KeyCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual bool GetButtonDown(string button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetButtonDown_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual float GetAxisRaw(string axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(axis);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAxisRaw_Public_Abstract_Virtual_New_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual PenData GetLastPenContactEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLastPenContactEvent_Public_Abstract_Virtual_New_PenData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PenData*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual Touch GetTouch(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Touch*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual bool GetMouseButton(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMouseButton_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual bool GetMouseButtonDown(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMouseButtonDown_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual bool GetMouseButtonUp(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMouseButtonUp_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public IInput(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Input : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionString_Public_Virtual_Final_New_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_Boolean_KeyCode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Virtual_Final_New_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Virtual_Final_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Public_Virtual_Final_New_get_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe virtual string compositionString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251886, XrefRangeEnd = 1251887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositionString_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe virtual bool touchSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251891, XrefRangeEnd = 1251892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchSupported_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual int touchCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 135644, RefRangeEnd = 135648, XrefRangeStart = 135644, XrefRangeEnd = 135648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual bool mousePresent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251893, XrefRangeEnd = 1251894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual Vector3 mousePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251897, XrefRangeEnd = 1251898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual Vector2 mouseScrollDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251898, XrefRangeEnd = 1251899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseScrollDelta_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static Input()
		{
			Il2CppClassPointerStore<Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "Input");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Input>.NativeClassPtr);
			NativeMethodInfoPtr_get_compositionString_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663489);
			NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663490);
			NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663491);
			NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663492);
			NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663493);
			NativeMethodInfoPtr_get_touchSupported_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663494);
			NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663495);
			NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663496);
			NativeMethodInfoPtr_get_mousePresent_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663497);
			NativeMethodInfoPtr_GetMouseButton_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663498);
			NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663499);
			NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663500);
			NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663501);
			NativeMethodInfoPtr_get_mouseScrollDelta_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663502);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663503);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251887, XrefRangeEnd = 1251888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetKey(KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&key);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKey_Public_Virtual_Final_New_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251888, XrefRangeEnd = 1251889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDown(string button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251889, XrefRangeEnd = 1251890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAxisRaw(string axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(axis);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251890, XrefRangeEnd = 1251891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PenData GetLastPenContactEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastPenContactEvent_Public_Virtual_Final_New_PenData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PenData*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251892, XrefRangeEnd = 1251893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Touch GetTouch(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouch_Public_Virtual_Final_New_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Touch*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251894, XrefRangeEnd = 1251895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMouseButton(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseButton_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251895, XrefRangeEnd = 1251896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMouseButtonDown(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseButtonDown_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251896, XrefRangeEnd = 1251897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMouseButtonUp(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseButtonUp_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Input()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Input>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Input(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ITime : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsRational_Public_Abstract_Virtual_New_get_RationalTime_0;

		public unsafe virtual RationalTime timeAsRational
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_timeAsRational_Public_Abstract_Virtual_New_get_RationalTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(RationalTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static ITime()
		{
			Il2CppClassPointerStore<ITime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "ITime");
			NativeMethodInfoPtr_get_timeAsRational_Public_Abstract_Virtual_New_get_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITime>.NativeClassPtr, 100663504);
		}

		public ITime(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Time : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsRational_Public_Virtual_Final_New_get_RationalTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe virtual RationalTime timeAsRational
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251899, XrefRangeEnd = 1251900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeAsRational_Public_Virtual_Final_New_get_RationalTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(RationalTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static Time()
		{
			Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
			NativeMethodInfoPtr_get_timeAsRational_Public_Virtual_Final_New_get_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100663505);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100663506);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Time()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Time>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Time(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__inputEventPartialProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr__compositionString;

	private static readonly System.IntPtr NativeFieldInfoPtr__configuration;

	private static readonly System.IntPtr NativeFieldInfoPtr__input;

	private static readonly System.IntPtr NativeFieldInfoPtr__time;

	private static readonly System.IntPtr NativeFieldInfoPtr__navigationEventRepeatHelper;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseState;

	private static readonly System.IntPtr NativeFieldInfoPtr__isPenPresent;

	private static readonly System.IntPtr NativeFieldInfoPtr__seenAtLeastOnePenPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastSeenPenPositionForDetection;

	private static readonly System.IntPtr NativeFieldInfoPtr__penState;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastPenData;

	private static readonly System.IntPtr NativeFieldInfoPtr__touchFingerIdToFingerIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__touchNextFingerIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__touchState;

	private static readonly System.IntPtr NativeMethodInfoPtr_get__eventModifiers_Private_get_EventModifiers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTouchEvents_Private_Boolean_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetectPen_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PenStatusToButton_Private_Static_Button_PenStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPenEvent_Private_Boolean_DiscreteTime_byref_PenData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMouseEvents_Private_Void_DiscreteTime_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMouseScroll_Private_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextPreviousNavigation_Private_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitCancelNavigation_Private_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectionNavigation_Private_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfIMEChanged_Private_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFocusChanged_Public_Virtual_Final_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventSourceFromPressedKey_Private_EventSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InputManagerJoystickWasPressed_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InputManagerKeyboardWasPressed_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InputManagerGetAxisRawOrDefault_Private_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InputManagerGetButtonDownOrDefault_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCurrentNavigationMoveVector_Private_ValueTuple_2_Vector2_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToIMECompositionEvent_Private_IMECompositionEvent_DiscreteTime_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TiltToAzimuth_Internal_Static_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AzimuthAndAlitutudeToTilt_Internal_Static_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TiltToAltitude_Internal_Static_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiDisplayBottomLeftToPanelPosition_Private_Static_Vector2_Vector2_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiDisplayToLocalScreenPosition_Private_Static_Vector2_Vector2_byref_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenBottomLeftToPanelPosition_Private_Static_Vector2_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenBottomLeftToPanelDelta_Private_Static_Vector2_Vector2_0;

	public const int kDefaultPlayerId = 0;

	public const int kMaxMouseButtons = 5;

	public const float kSmallestReportedMovementSqrDist = 0.01f;

	public const float kScrollUGUIScaleFactor = 3f;

	public unsafe InputEventPartialProvider _inputEventPartialProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputEventPartialProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputEventPartialProvider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputEventPartialProvider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _compositionString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compositionString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compositionString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Configuration _configuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__configuration);
			return new Configuration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Configuration>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__configuration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Configuration>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe IInput _input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__input);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInput>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__input)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ITime _time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__time);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITime>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__time)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NavigationEventRepeatHelper _navigationEventRepeatHelper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigationEventRepeatHelper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavigationEventRepeatHelper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigationEventRepeatHelper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PointerState _mouseState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseState);
			return *(PointerState*)num;
		}
		set
		{
			*(PointerState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseState)) = value;
		}
	}

	public unsafe bool _isPenPresent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isPenPresent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isPenPresent)) = value;
		}
	}

	public unsafe bool _seenAtLeastOnePenPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__seenAtLeastOnePenPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__seenAtLeastOnePenPosition)) = value;
		}
	}

	public unsafe Vector2 _lastSeenPenPositionForDetection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastSeenPenPositionForDetection);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastSeenPenPositionForDetection)) = value;
		}
	}

	public unsafe PointerState _penState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__penState);
			return *(PointerState*)num;
		}
		set
		{
			*(PointerState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__penState)) = value;
		}
	}

	public unsafe PenData _lastPenData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPenData);
			return *(PenData*)num;
		}
		set
		{
			*(PenData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPenData)) = value;
		}
	}

	public unsafe Dictionary<int, int> _touchFingerIdToFingerIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchFingerIdToFingerIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchFingerIdToFingerIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _touchNextFingerIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchNextFingerIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchNextFingerIndex)) = value;
		}
	}

	public unsafe PointerState _touchState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchState);
			return *(PointerState*)num;
		}
		set
		{
			*(PointerState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchState)) = value;
		}
	}

	public unsafe EventModifiers _eventModifiers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__eventModifiers_Private_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public uint playerCount => 1u;

	static InputManagerProvider()
	{
		Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "InputManagerProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr);
		NativeFieldInfoPtr__inputEventPartialProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_inputEventPartialProvider");
		NativeFieldInfoPtr__compositionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_compositionString");
		NativeFieldInfoPtr__configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_configuration");
		NativeFieldInfoPtr__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_input");
		NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_time");
		NativeFieldInfoPtr__navigationEventRepeatHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_navigationEventRepeatHelper");
		NativeFieldInfoPtr__mouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_mouseState");
		NativeFieldInfoPtr__isPenPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_isPenPresent");
		NativeFieldInfoPtr__seenAtLeastOnePenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_seenAtLeastOnePenPosition");
		NativeFieldInfoPtr__lastSeenPenPositionForDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_lastSeenPenPositionForDetection");
		NativeFieldInfoPtr__penState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_penState");
		NativeFieldInfoPtr__lastPenData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_lastPenData");
		NativeFieldInfoPtr__touchFingerIdToFingerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_touchFingerIdToFingerIndex");
		NativeFieldInfoPtr__touchNextFingerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_touchNextFingerIndex");
		NativeFieldInfoPtr__touchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, "_touchState");
		NativeMethodInfoPtr_get__eventModifiers_Private_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_Shutdown_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_CheckTouchEvents_Private_Boolean_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_DetectPen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_PenStatusToButton_Private_Static_Button_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_CheckPenEvent_Private_Boolean_DiscreteTime_byref_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_CheckMouseEvents_Private_Void_DiscreteTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_CheckMouseScroll_Private_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_NextPreviousNavigation_Private_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_SubmitCancelNavigation_Private_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_DirectionNavigation_Private_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_CheckIfIMEChanged_Private_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_OnFocusChanged_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_GetEventSourceFromPressedKey_Private_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_InputManagerJoystickWasPressed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_InputManagerKeyboardWasPressed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_InputManagerGetAxisRawOrDefault_Private_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_InputManagerGetButtonDownOrDefault_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_ReadCurrentNavigationMoveVector_Private_ValueTuple_2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_ToIMECompositionEvent_Private_IMECompositionEvent_DiscreteTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_TiltToAzimuth_Internal_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_AzimuthAndAlitutudeToTilt_Internal_Static_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_TiltToAltitude_Internal_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_MultiDisplayBottomLeftToPanelPosition_Private_Static_Vector2_Vector2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_MultiDisplayToLocalScreenPosition_Private_Static_Vector2_Vector2_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_ScreenBottomLeftToPanelPosition_Private_Static_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_ScreenBottomLeftToPanelDelta_Private_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr, 100663468);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251952, RefRangeEnd = 1251953, XrefRangeStart = 1251900, XrefRangeEnd = 1251952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputManagerProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManagerProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251953, XrefRangeEnd = 1251969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Shutdown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251969, XrefRangeEnd = 1252014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252068, RefRangeEnd = 1252069, XrefRangeStart = 1252014, XrefRangeEnd = 1252068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckTouchEvents(DiscreteTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTouchEvents_Private_Boolean_DiscreteTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252069, XrefRangeEnd = 1252072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DetectPen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetectPen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static PointerEvent.Button PenStatusToButton(PenStatus status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PenStatusToButton_Private_Static_Button_PenStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PointerEvent.Button*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252109, RefRangeEnd = 1252110, XrefRangeStart = 1252072, XrefRangeEnd = 1252109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckPenEvent(DiscreteTime currentTime, [In] ref PenData currentPenData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currentTime);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref currentPenData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPenEvent_Private_Boolean_DiscreteTime_byref_PenData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1252164, RefRangeEnd = 1252166, XrefRangeStart = 1252110, XrefRangeEnd = 1252164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckMouseEvents(DiscreteTime currentTime, bool muted = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currentTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &muted;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMouseEvents_Private_Void_DiscreteTime_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252192, RefRangeEnd = 1252193, XrefRangeStart = 1252166, XrefRangeEnd = 1252192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckMouseScroll(DiscreteTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMouseScroll_Private_Void_DiscreteTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252193, XrefRangeEnd = 1252203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextPreviousNavigation(DiscreteTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextPreviousNavigation_Private_Void_DiscreteTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252219, RefRangeEnd = 1252220, XrefRangeStart = 1252203, XrefRangeEnd = 1252219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitCancelNavigation(DiscreteTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitCancelNavigation_Private_Void_DiscreteTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252245, RefRangeEnd = 1252246, XrefRangeStart = 1252220, XrefRangeEnd = 1252245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DirectionNavigation(DiscreteTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectionNavigation_Private_Void_DiscreteTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252263, RefRangeEnd = 1252264, XrefRangeStart = 1252246, XrefRangeEnd = 1252263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIfIMEChanged(DiscreteTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfIMEChanged_Private_Void_DiscreteTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void OnFocusChanged(bool focus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&focus);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFocusChanged_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1252270, RefRangeEnd = 1252275, XrefRangeStart = 1252264, XrefRangeEnd = 1252270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventSource GetEventSourceFromPressedKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEventSourceFromPressedKey_Private_EventSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252275, XrefRangeEnd = 1252278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InputManagerJoystickWasPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InputManagerJoystickWasPressed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252278, XrefRangeEnd = 1252281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InputManagerKeyboardWasPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InputManagerKeyboardWasPressed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1252288, RefRangeEnd = 1252292, XrefRangeStart = 1252281, XrefRangeEnd = 1252288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float InputManagerGetAxisRawOrDefault(string axisName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InputManagerGetAxisRawOrDefault_Private_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1252299, RefRangeEnd = 1252309, XrefRangeStart = 1252292, XrefRangeEnd = 1252299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InputManagerGetButtonDownOrDefault(string axisName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InputManagerGetButtonDownOrDefault_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252309, XrefRangeEnd = 1252318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<Vector2, bool> ReadCurrentNavigationMoveVector()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadCurrentNavigationMoveVector_Private_ValueTuple_2_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<Vector2, bool>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252318, XrefRangeEnd = 1252319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currentTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(compositionString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToIMECompositionEvent_Private_IMECompositionEvent_DiscreteTime_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new IMECompositionEvent(pointer);
	}

	[CallerCount(0)]
	public unsafe static float TiltToAzimuth(Vector2 tilt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tilt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TiltToAzimuth_Internal_Static_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252327, RefRangeEnd = 1252328, XrefRangeStart = 1252319, XrefRangeEnd = 1252327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&altitude);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &azimuth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AzimuthAndAlitutudeToTilt_Internal_Static_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252328, XrefRangeEnd = 1252331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float TiltToAltitude(Vector2 tilt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tilt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TiltToAltitude_Internal_Static_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1252350, RefRangeEnd = 1252353, XrefRangeStart = 1252331, XrefRangeEnd = 1252350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int targetDisplay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref targetDisplay);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiDisplayBottomLeftToPanelPosition_Private_Static_Vector2_Vector2_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252353, XrefRangeEnd = 1252363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Il2CppSystem.Nullable<int> targetDisplay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiDisplayToLocalScreenPosition_Private_Static_Vector2_Vector2_byref_Nullable_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		targetDisplay = ((num3 == 0) ? null : new Il2CppSystem.Nullable<int>(num3));
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252363, XrefRangeEnd = 1252371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetDisplay;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenBottomLeftToPanelPosition_Private_Static_Vector2_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenBottomLeftToPanelDelta_Private_Static_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InputManagerProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PointerEvent ToPointerStateEvent(DiscreteTime currentTime, [In] ref PointerState state, EventSource eventSource)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool RequestCurrentState(Event.Type type)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
