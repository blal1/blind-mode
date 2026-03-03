using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem;

namespace UnityEngine.Rendering;

public class FreeCamera : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_k_MouseSensitivityMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_m_LookSpeedController;

	private static readonly IntPtr NativeFieldInfoPtr_m_LookSpeedMouse;

	private static readonly IntPtr NativeFieldInfoPtr_m_MoveSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_m_MoveSpeedIncrement;

	private static readonly IntPtr NativeFieldInfoPtr_m_Turbo;

	private static readonly IntPtr NativeFieldInfoPtr_lookAction;

	private static readonly IntPtr NativeFieldInfoPtr_moveAction;

	private static readonly IntPtr NativeFieldInfoPtr_speedAction;

	private static readonly IntPtr NativeFieldInfoPtr_yMoveAction;

	private static readonly IntPtr NativeFieldInfoPtr_inputRotateAxisX;

	private static readonly IntPtr NativeFieldInfoPtr_inputRotateAxisY;

	private static readonly IntPtr NativeFieldInfoPtr_inputChangeSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_inputVertical;

	private static readonly IntPtr NativeFieldInfoPtr_inputHorizontal;

	private static readonly IntPtr NativeFieldInfoPtr_inputYAxis;

	private static readonly IntPtr NativeFieldInfoPtr_leftShiftBoost;

	private static readonly IntPtr NativeFieldInfoPtr_leftShift;

	private static readonly IntPtr NativeFieldInfoPtr_fire1;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterInputs_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateInputs_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float k_MouseSensitivityMultiplier
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MouseSensitivityMultiplier, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MouseSensitivityMultiplier, (void*)(&value));
		}
	}

	public unsafe float m_LookSpeedController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LookSpeedController);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LookSpeedController)) = value;
		}
	}

	public unsafe float m_LookSpeedMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LookSpeedMouse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LookSpeedMouse)) = value;
		}
	}

	public unsafe float m_MoveSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveSpeed)) = value;
		}
	}

	public unsafe float m_MoveSpeedIncrement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveSpeedIncrement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveSpeedIncrement)) = value;
		}
	}

	public unsafe float m_Turbo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Turbo);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Turbo)) = value;
		}
	}

	public unsafe InputAction lookAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputAction moveAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputAction speedAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputAction yMoveAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMoveAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMoveAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float inputRotateAxisX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputRotateAxisX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputRotateAxisX)) = value;
		}
	}

	public unsafe float inputRotateAxisY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputRotateAxisY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputRotateAxisY)) = value;
		}
	}

	public unsafe float inputChangeSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputChangeSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputChangeSpeed)) = value;
		}
	}

	public unsafe float inputVertical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputVertical);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputVertical)) = value;
		}
	}

	public unsafe float inputHorizontal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputHorizontal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputHorizontal)) = value;
		}
	}

	public unsafe float inputYAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputYAxis);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputYAxis)) = value;
		}
	}

	public unsafe bool leftShiftBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftShiftBoost);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftShiftBoost)) = value;
		}
	}

	public unsafe bool leftShift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftShift);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftShift)) = value;
		}
	}

	public unsafe bool fire1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fire1);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fire1)) = value;
		}
	}

	static FreeCamera()
	{
		Il2CppClassPointerStore<FreeCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FreeCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr);
		NativeFieldInfoPtr_k_MouseSensitivityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "k_MouseSensitivityMultiplier");
		NativeFieldInfoPtr_m_LookSpeedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_LookSpeedController");
		NativeFieldInfoPtr_m_LookSpeedMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_LookSpeedMouse");
		NativeFieldInfoPtr_m_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_MoveSpeed");
		NativeFieldInfoPtr_m_MoveSpeedIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_MoveSpeedIncrement");
		NativeFieldInfoPtr_m_Turbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_Turbo");
		NativeFieldInfoPtr_lookAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "lookAction");
		NativeFieldInfoPtr_moveAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "moveAction");
		NativeFieldInfoPtr_speedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "speedAction");
		NativeFieldInfoPtr_yMoveAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "yMoveAction");
		NativeFieldInfoPtr_inputRotateAxisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputRotateAxisX");
		NativeFieldInfoPtr_inputRotateAxisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputRotateAxisY");
		NativeFieldInfoPtr_inputChangeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputChangeSpeed");
		NativeFieldInfoPtr_inputVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputVertical");
		NativeFieldInfoPtr_inputHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputHorizontal");
		NativeFieldInfoPtr_inputYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputYAxis");
		NativeFieldInfoPtr_leftShiftBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "leftShiftBoost");
		NativeFieldInfoPtr_leftShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "leftShift");
		NativeFieldInfoPtr_fire1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "fire1");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_RegisterInputs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_UpdateInputs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663488);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026478, XrefRangeEnd = 1026479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1026592, RefRangeEnd = 1026593, XrefRangeStart = 1026479, XrefRangeEnd = 1026592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterInputs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterInputs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1026627, RefRangeEnd = 1026628, XrefRangeStart = 1026593, XrefRangeEnd = 1026627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInputs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInputs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026628, XrefRangeEnd = 1026661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026661, XrefRangeEnd = 1026662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FreeCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FreeCamera(IntPtr pointer)
		: base(pointer)
	{
	}
}
