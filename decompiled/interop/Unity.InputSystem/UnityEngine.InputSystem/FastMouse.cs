using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class FastMouse : Mouse
{
	private static readonly IntPtr NativeFieldInfoPtr_metadata;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouseposition_Private_Vector2Control_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedelta_Private_DeltaControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousescroll_Private_DeltaControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousepress_Private_ButtonControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouseleftButton_Private_ButtonControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouserightButton_Private_ButtonControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousemiddleButton_Private_ButtonControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouseforwardButton_Private_ButtonControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousebackButton_Private_ButtonControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousepressure_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouseradius_Private_Vector2Control_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousepointerId_Private_IntegerControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedisplayIndex_Private_IntegerControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouseclickCount_Private_IntegerControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousepositionx_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousepositiony_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedeltaup_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedeltadown_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedeltaleft_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedeltaright_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedeltax_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousedeltay_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousescrollup_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousescrolldown_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousescrollleft_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousescrollright_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousescrollx_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMousescrolly_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouseradiusx_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_ctrlMouseradiusy_Private_AxisControl_InternedString_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_MergeForward_Internal_Static_Boolean_InputEventPtr_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0;

	public unsafe static string metadata
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_metadata, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_metadata, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static FastMouse()
	{
		Il2CppClassPointerStore<FastMouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "FastMouse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastMouse>.NativeClassPtr);
		NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, "metadata");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665385);
		NativeMethodInfoPtr_Initialize_ctrlMouseposition_Private_Vector2Control_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665386);
		NativeMethodInfoPtr_Initialize_ctrlMousedelta_Private_DeltaControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665387);
		NativeMethodInfoPtr_Initialize_ctrlMousescroll_Private_DeltaControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665388);
		NativeMethodInfoPtr_Initialize_ctrlMousepress_Private_ButtonControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665389);
		NativeMethodInfoPtr_Initialize_ctrlMouseleftButton_Private_ButtonControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665390);
		NativeMethodInfoPtr_Initialize_ctrlMouserightButton_Private_ButtonControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665391);
		NativeMethodInfoPtr_Initialize_ctrlMousemiddleButton_Private_ButtonControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665392);
		NativeMethodInfoPtr_Initialize_ctrlMouseforwardButton_Private_ButtonControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665393);
		NativeMethodInfoPtr_Initialize_ctrlMousebackButton_Private_ButtonControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665394);
		NativeMethodInfoPtr_Initialize_ctrlMousepressure_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665395);
		NativeMethodInfoPtr_Initialize_ctrlMouseradius_Private_Vector2Control_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665396);
		NativeMethodInfoPtr_Initialize_ctrlMousepointerId_Private_IntegerControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665397);
		NativeMethodInfoPtr_Initialize_ctrlMousedisplayIndex_Private_IntegerControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665398);
		NativeMethodInfoPtr_Initialize_ctrlMouseclickCount_Private_IntegerControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665399);
		NativeMethodInfoPtr_Initialize_ctrlMousepositionx_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665400);
		NativeMethodInfoPtr_Initialize_ctrlMousepositiony_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665401);
		NativeMethodInfoPtr_Initialize_ctrlMousedeltaup_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665402);
		NativeMethodInfoPtr_Initialize_ctrlMousedeltadown_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665403);
		NativeMethodInfoPtr_Initialize_ctrlMousedeltaleft_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665404);
		NativeMethodInfoPtr_Initialize_ctrlMousedeltaright_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665405);
		NativeMethodInfoPtr_Initialize_ctrlMousedeltax_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665406);
		NativeMethodInfoPtr_Initialize_ctrlMousedeltay_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665407);
		NativeMethodInfoPtr_Initialize_ctrlMousescrollup_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665408);
		NativeMethodInfoPtr_Initialize_ctrlMousescrolldown_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665409);
		NativeMethodInfoPtr_Initialize_ctrlMousescrollleft_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665410);
		NativeMethodInfoPtr_Initialize_ctrlMousescrollright_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665411);
		NativeMethodInfoPtr_Initialize_ctrlMousescrollx_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665412);
		NativeMethodInfoPtr_Initialize_ctrlMousescrolly_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665413);
		NativeMethodInfoPtr_Initialize_ctrlMouseradiusx_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665414);
		NativeMethodInfoPtr_Initialize_ctrlMouseradiusy_Private_AxisControl_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665415);
		NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665416);
		NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665417);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665418);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665419);
		NativeMethodInfoPtr_MergeForward_Internal_Static_Boolean_InputEventPtr_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665420);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastMouse>.NativeClassPtr, 100665421);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981832, XrefRangeEnd = 982020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FastMouse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastMouse>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982045, RefRangeEnd = 982046, XrefRangeStart = 982020, XrefRangeEnd = 982045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kVector2Layout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouseposition_Private_Vector2Control_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Vector2Control>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982069, RefRangeEnd = 982070, XrefRangeStart = 982046, XrefRangeEnd = 982069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kDeltaLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedelta_Private_DeltaControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DeltaControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982093, RefRangeEnd = 982094, XrefRangeStart = 982070, XrefRangeEnd = 982093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kDeltaLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousescroll_Private_DeltaControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DeltaControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982121, RefRangeEnd = 982122, XrefRangeStart = 982094, XrefRangeEnd = 982121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kButtonLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousepress_Private_ButtonControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982153, RefRangeEnd = 982154, XrefRangeStart = 982122, XrefRangeEnd = 982153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kButtonLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouseleftButton_Private_ButtonControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982185, RefRangeEnd = 982186, XrefRangeStart = 982154, XrefRangeEnd = 982185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kButtonLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouserightButton_Private_ButtonControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982217, RefRangeEnd = 982218, XrefRangeStart = 982186, XrefRangeEnd = 982217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kButtonLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousemiddleButton_Private_ButtonControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982244, RefRangeEnd = 982245, XrefRangeStart = 982218, XrefRangeEnd = 982244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kButtonLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouseforwardButton_Private_ButtonControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982271, RefRangeEnd = 982272, XrefRangeStart = 982245, XrefRangeEnd = 982271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kButtonLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousebackButton_Private_ButtonControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982297, RefRangeEnd = 982298, XrefRangeStart = 982272, XrefRangeEnd = 982297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousepressure_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982321, RefRangeEnd = 982322, XrefRangeStart = 982298, XrefRangeEnd = 982321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kVector2Layout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouseradius_Private_Vector2Control_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Vector2Control>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982344, RefRangeEnd = 982345, XrefRangeStart = 982322, XrefRangeEnd = 982344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kDigitalLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousepointerId_Private_IntegerControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IntegerControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982368, RefRangeEnd = 982369, XrefRangeStart = 982345, XrefRangeEnd = 982368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kIntegerLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedisplayIndex_Private_IntegerControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IntegerControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982393, RefRangeEnd = 982394, XrefRangeStart = 982369, XrefRangeEnd = 982393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kIntegerLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouseclickCount_Private_IntegerControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IntegerControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982423, RefRangeEnd = 982424, XrefRangeStart = 982394, XrefRangeEnd = 982423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousepositionx_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982453, RefRangeEnd = 982454, XrefRangeStart = 982424, XrefRangeEnd = 982453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousepositiony_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982482, RefRangeEnd = 982483, XrefRangeStart = 982454, XrefRangeEnd = 982482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedeltaup_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982511, RefRangeEnd = 982512, XrefRangeStart = 982483, XrefRangeEnd = 982511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedeltadown_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982540, RefRangeEnd = 982541, XrefRangeStart = 982512, XrefRangeEnd = 982540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedeltaleft_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982569, RefRangeEnd = 982570, XrefRangeStart = 982541, XrefRangeEnd = 982569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedeltaright_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982597, RefRangeEnd = 982598, XrefRangeStart = 982570, XrefRangeEnd = 982597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedeltax_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982625, RefRangeEnd = 982626, XrefRangeStart = 982598, XrefRangeEnd = 982625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousedeltay_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982654, RefRangeEnd = 982655, XrefRangeStart = 982626, XrefRangeEnd = 982654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousescrollup_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982683, RefRangeEnd = 982684, XrefRangeStart = 982655, XrefRangeEnd = 982683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousescrolldown_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982712, RefRangeEnd = 982713, XrefRangeStart = 982684, XrefRangeEnd = 982712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousescrollleft_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982741, RefRangeEnd = 982742, XrefRangeStart = 982713, XrefRangeEnd = 982741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousescrollright_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982769, RefRangeEnd = 982770, XrefRangeStart = 982742, XrefRangeEnd = 982769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousescrollx_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982798, RefRangeEnd = 982799, XrefRangeStart = 982770, XrefRangeEnd = 982798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMousescrolly_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982826, RefRangeEnd = 982827, XrefRangeStart = 982799, XrefRangeEnd = 982826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouseradiusx_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982854, RefRangeEnd = 982855, XrefRangeStart = 982827, XrefRangeEnd = 982854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kAxisLayout));
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_ctrlMouseradiusy_Private_AxisControl_InternedString_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AxisControl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982855, XrefRangeEnd = 982868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982868, XrefRangeEnd = 982881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnStateEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982881, XrefRangeEnd = 982894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982894, XrefRangeEnd = 982902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&currentEventPtr);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nextEventPtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeForward_Internal_Static_Boolean_InputEventPtr_InputEventPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982902, XrefRangeEnd = 982910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&currentEventPtr);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nextEventPtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FastMouse(IntPtr pointer)
		: base(pointer)
	{
	}
}
