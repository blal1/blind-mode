using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public class WindowsConsoleDriver : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inputHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultAttribute;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0;

	public unsafe System.IntPtr inputHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputHandle);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputHandle)) = value;
		}
	}

	public unsafe System.IntPtr outputHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputHandle);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputHandle)) = value;
		}
	}

	public unsafe short defaultAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultAttribute);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultAttribute)) = value;
		}
	}

	static WindowsConsoleDriver()
	{
		Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "WindowsConsoleDriver");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr);
		NativeFieldInfoPtr_inputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "inputHandle");
		NativeFieldInfoPtr_outputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "outputHandle");
		NativeFieldInfoPtr_defaultAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "defaultAttribute");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667413);
		NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667414);
		NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667415);
		NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667416);
		NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667417);
		NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667418);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 765783, RefRangeEnd = 765784, XrefRangeStart = 765777, XrefRangeEnd = 765783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WindowsConsoleDriver()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765784, XrefRangeEnd = 765788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intercept);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ConsoleKeyInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsModifierKey(short virtualKeyCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&virtualKeyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 765791, RefRangeEnd = 765793, XrefRangeStart = 765788, XrefRangeEnd = 765791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetStdHandle(Handles handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765793, XrefRangeEnd = 765796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetConsoleScreenBufferInfo(System.IntPtr handle, out ConsoleScreenBufferInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765796, XrefRangeEnd = 765799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReadConsoleInput(System.IntPtr handle, out InputRecord record, int length, out int nread)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref record);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nread);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public WindowsConsoleDriver(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
