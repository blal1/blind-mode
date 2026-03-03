using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public class SendMouseEvents : Il2CppSystem.Object
{
	public sealed class HitInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_target;

		private static readonly System.IntPtr NativeFieldInfoPtr_camera;

		private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0;

		public unsafe GameObject target
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Camera camera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static HitInfo()
		{
			Il2CppClassPointerStore<HitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "HitInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitInfo>.NativeClassPtr);
			NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitInfo>.NativeClassPtr, "target");
			NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitInfo>.NativeClassPtr, "camera");
			NativeMethodInfoPtr_SendMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitInfo>.NativeClassPtr, 100663362);
			NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitInfo>.NativeClassPtr, 100663363);
			NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitInfo>.NativeClassPtr, 100663364);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252798, XrefRangeEnd = 1252799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessage_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252799, XrefRangeEnd = 1252803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(HitInfo exists)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)exists));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252803, XrefRangeEnd = 1252807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(HitInfo lhs, HitInfo rhs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lhs));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rhs));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public HitInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public HitInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitInfo>.NativeClassPtr))
		{
		}
	}

	public enum LeftMouseButtonState
	{
		NotPressed,
		Pressed,
		PressedThisFrame
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MouseUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastHit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseDownHit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentHit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Cameras;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GetMouseState;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MousePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MouseButtonPressedThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MouseButtonIsPressed;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMouse_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0;

	public const int m_HitIndexGUI = 0;

	public const int m_HitIndexPhysics3D = 1;

	public const int m_HitIndexPhysics2D = 2;

	public unsafe static bool s_MouseUsed
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MouseUsed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MouseUsed, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<HitInfo> m_LastHit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_LastHit, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HitInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_LastHit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<HitInfo> m_MouseDownHit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MouseDownHit, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HitInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MouseDownHit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<HitInfo> m_CurrentHit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CurrentHit, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HitInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CurrentHit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Camera> m_Cameras
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Cameras, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Cameras, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<KeyValuePair<int, Vector2>> s_GetMouseState
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GetMouseState, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<int, Vector2>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GetMouseState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Vector2 s_MousePosition
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MousePosition, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MousePosition, (void*)(&value));
		}
	}

	public unsafe static bool s_MouseButtonPressedThisFrame
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MouseButtonPressedThisFrame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MouseButtonPressedThisFrame, (void*)(&value));
		}
	}

	public unsafe static bool s_MouseButtonIsPressed
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MouseButtonIsPressed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MouseButtonIsPressed, (void*)(&value));
		}
	}

	static SendMouseEvents()
	{
		Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "SendMouseEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr);
		NativeFieldInfoPtr_s_MouseUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseUsed");
		NativeFieldInfoPtr_m_LastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_LastHit");
		NativeFieldInfoPtr_m_MouseDownHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_MouseDownHit");
		NativeFieldInfoPtr_m_CurrentHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_CurrentHit");
		NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_Cameras");
		NativeFieldInfoPtr_s_GetMouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_GetMouseState");
		NativeFieldInfoPtr_s_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MousePosition");
		NativeFieldInfoPtr_s_MouseButtonPressedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseButtonPressedThisFrame");
		NativeFieldInfoPtr_s_MouseButtonIsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseButtonIsPressed");
		NativeMethodInfoPtr_UpdateMouse_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663360);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252820, RefRangeEnd = 1252821, XrefRangeStart = 1252807, XrefRangeEnd = 1252820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateMouse()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMouse_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252821, XrefRangeEnd = 1252825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMouseMoved()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252825, XrefRangeEnd = 1252954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoSendMouseEvents(int skipRTCameras)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skipRTCameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253074, RefRangeEnd = 1253075, XrefRangeStart = 1252954, XrefRangeEnd = 1253074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvents(int i, HitInfo hit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)hit));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SendMouseEvents(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
