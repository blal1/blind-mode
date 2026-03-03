using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppYgomGame.Duel;
using Il2CppYgomSystem.ElementSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppYgomDebug;

public class DuelLogForAnalysis : MonoBehaviour
{
	[System.Serializable]
	public class SerializableList<T> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_list;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<T> list
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static SerializableList()
		{
			Il2CppClassPointerStore<SerializableList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "SerializableList`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableList<T>>.NativeClassPtr);
			NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableList<T>>.NativeClassPtr, "list");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableList<T>>.NativeClassPtr, 100665168);
		}

		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 50795, RefRangeEnd = 50809, XrefRangeStart = 50786, XrefRangeEnd = 50795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableList<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SerializableList(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DuelLogData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_LogBaseItemList;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataList_ShowTurn;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataList_ShowAction;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataList_ShowChain;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataList_ShowCardName;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataList_ShowText;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataList_ShowPhase;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataList_ShowTag;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLabelList;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TextTable;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromJson_Public_Static_DuelLogData_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromDuelLogControllerData_Public_Static_DuelLogData_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetDataFromDuelLogData_Public_Void_List_1_LogBaseData_List_1_ShowTurnData_List_1_ShowActionData_List_1_ShowChainData_List_1_ShowCardNameData_List_1_ShowTextData_List_1_ShowPhaseData_List_1_ShowTagData_List_1_String_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SerializableList<LogBaseDataForAnalysis> m_LogBaseItemList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LogBaseItemList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<LogBaseDataForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LogBaseItemList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<ShowTurnDataForAnalysis> m_DataList_ShowTurn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowTurn);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<ShowTurnDataForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowTurn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<ShowActionDataForAnalysis> m_DataList_ShowAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowAction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<ShowActionDataForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<ShowChainDataForAnalysis> m_DataList_ShowChain
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowChain);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<ShowChainDataForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowChain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<ShowCardNameDataForAnalysis> m_DataList_ShowCardName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowCardName);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<ShowCardNameDataForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowCardName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<ShowTextDataForAnalysis> m_DataList_ShowText
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowText);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<ShowTextDataForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<ShowPhaseDataForAnalysis> m_DataList_ShowPhase
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowPhase);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<ShowPhaseDataForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowPhase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<ShowTagTypeForAnalysis> m_DataList_ShowTag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowTag);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<ShowTagTypeForAnalysis>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataList_ShowTag)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<string> m_DataLabelList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataLabelList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataLabelList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SerializableList<string> m_TextTable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextTable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableList<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static DuelLogData()
		{
			Il2CppClassPointerStore<DuelLogData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "DuelLogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr);
			NativeFieldInfoPtr_m_LogBaseItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_LogBaseItemList");
			NativeFieldInfoPtr_m_DataList_ShowTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataList_ShowTurn");
			NativeFieldInfoPtr_m_DataList_ShowAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataList_ShowAction");
			NativeFieldInfoPtr_m_DataList_ShowChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataList_ShowChain");
			NativeFieldInfoPtr_m_DataList_ShowCardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataList_ShowCardName");
			NativeFieldInfoPtr_m_DataList_ShowText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataList_ShowText");
			NativeFieldInfoPtr_m_DataList_ShowPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataList_ShowPhase");
			NativeFieldInfoPtr_m_DataList_ShowTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataList_ShowTag");
			NativeFieldInfoPtr_m_DataLabelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_DataLabelList");
			NativeFieldInfoPtr_m_TextTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, "m_TextTable");
			NativeMethodInfoPtr_CreateFromJson_Public_Static_DuelLogData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, 100665169);
			NativeMethodInfoPtr_CreateFromDuelLogControllerData_Public_Static_DuelLogData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, 100665170);
			NativeMethodInfoPtr_SetDataFromDuelLogData_Public_Void_List_1_LogBaseData_List_1_ShowTurnData_List_1_ShowActionData_List_1_ShowChainData_List_1_ShowCardNameData_List_1_ShowTextData_List_1_ShowPhaseData_List_1_ShowTagData_List_1_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, 100665171);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr, 100665172);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50809, XrefRangeEnd = 50812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DuelLogData CreateFromJson(string json)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFromJson_Public_Static_DuelLogData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DuelLogData>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50812, XrefRangeEnd = 50815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DuelLogData CreateFromDuelLogControllerData(string json)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFromDuelLogControllerData_Public_Static_DuelLogData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DuelLogData>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50815, XrefRangeEnd = 51006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDataFromDuelLogData(List<LogBaseData> logBaseDatas, List<ShowTurnData> showTurnDatas, List<ShowActionData> showActionDatas, List<ShowChainData> showChainDatas, List<ShowCardNameData> showCardNameDatas, List<ShowTextData> showTextDatas, List<ShowPhaseData> showPhaseDatas, List<ShowTagData> showTagTypes, List<string> dataLabelList, List<string> textTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[10];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)logBaseDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showTurnDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showActionDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showChainDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showCardNameDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showTextDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showPhaseDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showTagTypes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataLabelList);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textTable);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDataFromDuelLogData_Public_Void_List_1_LogBaseData_List_1_ShowTurnData_List_1_ShowActionData_List_1_ShowChainData_List_1_ShowCardNameData_List_1_ShowTextData_List_1_ShowPhaseData_List_1_ShowTagData_List_1_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51075, RefRangeEnd = 51076, XrefRangeStart = 51006, XrefRangeEnd = 51075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuelLogData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuelLogData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DuelLogData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("YgomDebug.DuelLogForAnalysis+<>c__DisplayClass88_0")]
	public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_label;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__InitializeDict_b__1_Internal_Int32_0;

		public unsafe string label
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe DuelLogForAnalysis __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DuelLogForAnalysis>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass88_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "<>c__DisplayClass88_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr);
			NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, "label");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, 100665173);
			NativeMethodInfoPtr__InitializeDict_b__1_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, 100665174);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass88_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51076, XrefRangeEnd = 51101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _InitializeDict_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitializeDict_b__1_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass88_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_INVALIDCARDID;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SHOWTURN;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SHOWACTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SHOWCHAIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SHOWTAG;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SHOWCARDNAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SHOWTEXT;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SHOWPHASE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SAPERATELINE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_ROOT;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SCROLLUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SCROLLDOWN;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_SCROLLVIEW;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_BG;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_TWEEN_SHOWLOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_TWEEN_HIDELOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_TWEEN_READY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SE_LOG_OPEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_SE_LOG_CLOSE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PREFAB_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr__onChangeOpenClose_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsReady_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DuelLogData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EOManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScrollView;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DataTypeNumDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LogHandlerDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateItemDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TemplateLabelList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerIconTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerFrameTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CloseTemprary;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bgObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpSummonFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpSummonFlagCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChainCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onChangeOpenClose_Public_get_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onChangeOpenClose_Public_set_Void_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsReady_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_IsIndent_Protected_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_LogBaseItemList_Private_get_List_1_LogBaseDataForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_DataList_ShowTurn_Private_get_List_1_ShowTurnDataForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_DataList_ShowAction_Private_get_List_1_ShowActionDataForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_DataList_ShowChain_Private_get_List_1_ShowChainDataForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_DataList_ShowCardName_Private_get_List_1_ShowCardNameDataForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_DataList_ShowText_Private_get_List_1_ShowTextDataForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_DataList_ShowPhase_Private_get_List_1_ShowPhaseDataForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_DataList_ShowTag_Private_get_List_1_ShowTagTypeForAnalysis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DuelLogForAnalysis_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseTemprary_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAutoScroll_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShortkeyIconVisible_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLogData_Public_Void_ViewType_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLogText_Public_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLogData_Public_Void_DuelLogData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateListItemBase_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateShowTurn_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateShowAction_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateShowChain_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateShowTag_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateShowCardName_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateShowText_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateShowPhase_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateSeparateLine_Protected_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnScrollViewReady_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeComponent_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDict_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionType_Private_LOGACTIONTYPE_CardMoveType_CardStatus_CardStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSpSummon_Private_Void_byref_LOGACTIONTYPE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectorPriority_Public_Void_DuelSelectorPriority_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerIcon_Public_Boolean_Image_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCardidValid_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__initializeComponent_b__87_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitializeDict_b__88_0_Private_Void_Vector2_0;

	public unsafe static int INVALIDCARDID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INVALIDCARDID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INVALIDCARDID, (void*)(&value));
		}
	}

	public unsafe static string LABEL_SHOWTURN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SHOWTURN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SHOWTURN, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SHOWACTION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SHOWACTION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SHOWACTION, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SHOWCHAIN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SHOWCHAIN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SHOWCHAIN, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SHOWTAG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SHOWTAG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SHOWTAG, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SHOWCARDNAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SHOWCARDNAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SHOWCARDNAME, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SHOWTEXT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SHOWTEXT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SHOWTEXT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SHOWPHASE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SHOWPHASE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SHOWPHASE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SAPERATELINE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SAPERATELINE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SAPERATELINE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_ROOT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_ROOT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_ROOT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SCROLLUP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SCROLLUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SCROLLUP, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SCROLLDOWN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SCROLLDOWN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SCROLLDOWN, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_SCROLLVIEW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_SCROLLVIEW, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_SCROLLVIEW, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_BG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_BG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_BG, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_TWEEN_SHOWLOG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_TWEEN_SHOWLOG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_TWEEN_SHOWLOG, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_TWEEN_HIDELOG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_TWEEN_HIDELOG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_TWEEN_HIDELOG, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LABEL_TWEEN_READY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LABEL_TWEEN_READY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LABEL_TWEEN_READY, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SE_LOG_OPEN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SE_LOG_OPEN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SE_LOG_OPEN, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SE_LOG_CLOSE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SE_LOG_CLOSE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SE_LOG_CLOSE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PREFAB_NAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PREFAB_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PREFAB_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppSystem.Action<bool> _onChangeOpenClose_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onChangeOpenClose_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onChangeOpenClose_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _IsReady_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsReady_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsReady_k__BackingField)) = value;
		}
	}

	public unsafe DuelLogData m_DuelLogData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelLogData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DuelLogData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelLogData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ElementObjectManager m_EOManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EOManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EOManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DuelLogScrollViewForAnalysis m_ScrollView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScrollView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DuelLogScrollViewForAnalysis>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScrollView)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<string, int> m_DataTypeNumDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataTypeNumDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataTypeNumDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<Engine.ViewType, LogHandler> m_LogHandlerDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LogHandlerDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Engine.ViewType, LogHandler>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LogHandlerDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<string, LogItemHandler> m_UpdateItemDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateItemDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, LogItemHandler>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateItemDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<string> m_TemplateLabelList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemplateLabelList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemplateLabelList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, Sprite> m_PlayerIconTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerIconTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Sprite>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerIconTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, Material> m_PlayerFrameTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerFrameTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerFrameTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_CloseTemprary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CloseTemprary);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CloseTemprary)) = value;
		}
	}

	public unsafe GameObject m_bgObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bgObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bgObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_IsOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsOpen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsOpen)) = value;
		}
	}

	public unsafe SPSUMMONTYPE m_SpSummonFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpSummonFlag);
			return *(SPSUMMONTYPE*)num;
		}
		set
		{
			*(SPSUMMONTYPE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpSummonFlag)) = value;
		}
	}

	public unsafe int m_SpSummonFlagCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpSummonFlagCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpSummonFlagCount)) = value;
		}
	}

	public unsafe int m_ChainCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChainCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChainCount)) = value;
		}
	}

	public unsafe bool isOpen
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51101, RefRangeEnd = 51102, XrefRangeStart = 51101, XrefRangeEnd = 51101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Action<bool> onChangeOpenClose
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onChangeOpenClose_Public_get_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onChangeOpenClose_Public_set_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool IsReady
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsReady_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool m_IsIndent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_IsIndent_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe List<LogBaseDataForAnalysis> m_LogBaseItemList
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_LogBaseItemList_Private_get_List_1_LogBaseDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LogBaseDataForAnalysis>>(intPtr2) : null;
		}
	}

	public unsafe List<ShowTurnDataForAnalysis> m_DataList_ShowTurn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_DataList_ShowTurn_Private_get_List_1_ShowTurnDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShowTurnDataForAnalysis>>(intPtr2) : null;
		}
	}

	public unsafe List<ShowActionDataForAnalysis> m_DataList_ShowAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_DataList_ShowAction_Private_get_List_1_ShowActionDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShowActionDataForAnalysis>>(intPtr2) : null;
		}
	}

	public unsafe List<ShowChainDataForAnalysis> m_DataList_ShowChain
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_DataList_ShowChain_Private_get_List_1_ShowChainDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShowChainDataForAnalysis>>(intPtr2) : null;
		}
	}

	public unsafe List<ShowCardNameDataForAnalysis> m_DataList_ShowCardName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_DataList_ShowCardName_Private_get_List_1_ShowCardNameDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShowCardNameDataForAnalysis>>(intPtr2) : null;
		}
	}

	public unsafe List<ShowTextDataForAnalysis> m_DataList_ShowText
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_DataList_ShowText_Private_get_List_1_ShowTextDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShowTextDataForAnalysis>>(intPtr2) : null;
		}
	}

	public unsafe List<ShowPhaseDataForAnalysis> m_DataList_ShowPhase
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_DataList_ShowPhase_Private_get_List_1_ShowPhaseDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShowPhaseDataForAnalysis>>(intPtr2) : null;
		}
	}

	public unsafe List<ShowTagTypeForAnalysis> m_DataList_ShowTag
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_DataList_ShowTag_Private_get_List_1_ShowTagTypeForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShowTagTypeForAnalysis>>(intPtr2) : null;
		}
	}

	static DuelLogForAnalysis()
	{
		Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "DuelLogForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_INVALIDCARDID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "INVALIDCARDID");
		NativeFieldInfoPtr_LABEL_SHOWTURN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SHOWTURN");
		NativeFieldInfoPtr_LABEL_SHOWACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SHOWACTION");
		NativeFieldInfoPtr_LABEL_SHOWCHAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SHOWCHAIN");
		NativeFieldInfoPtr_LABEL_SHOWTAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SHOWTAG");
		NativeFieldInfoPtr_LABEL_SHOWCARDNAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SHOWCARDNAME");
		NativeFieldInfoPtr_LABEL_SHOWTEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SHOWTEXT");
		NativeFieldInfoPtr_LABEL_SHOWPHASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SHOWPHASE");
		NativeFieldInfoPtr_LABEL_SAPERATELINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SAPERATELINE");
		NativeFieldInfoPtr_LABEL_ROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_ROOT");
		NativeFieldInfoPtr_LABEL_SCROLLUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SCROLLUP");
		NativeFieldInfoPtr_LABEL_SCROLLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SCROLLDOWN");
		NativeFieldInfoPtr_LABEL_SCROLLVIEW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_SCROLLVIEW");
		NativeFieldInfoPtr_LABEL_BG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_BG");
		NativeFieldInfoPtr_LABEL_TWEEN_SHOWLOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_TWEEN_SHOWLOG");
		NativeFieldInfoPtr_LABEL_TWEEN_HIDELOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_TWEEN_HIDELOG");
		NativeFieldInfoPtr_LABEL_TWEEN_READY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "LABEL_TWEEN_READY");
		NativeFieldInfoPtr_SE_LOG_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "SE_LOG_OPEN");
		NativeFieldInfoPtr_SE_LOG_CLOSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "SE_LOG_CLOSE");
		NativeFieldInfoPtr_PREFAB_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "PREFAB_NAME");
		NativeFieldInfoPtr__onChangeOpenClose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "<onChangeOpenClose>k__BackingField");
		NativeFieldInfoPtr__IsReady_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "<IsReady>k__BackingField");
		NativeFieldInfoPtr_m_DuelLogData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_DuelLogData");
		NativeFieldInfoPtr_m_EOManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_EOManager");
		NativeFieldInfoPtr_m_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_ScrollView");
		NativeFieldInfoPtr_m_DataTypeNumDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_DataTypeNumDict");
		NativeFieldInfoPtr_m_LogHandlerDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_LogHandlerDict");
		NativeFieldInfoPtr_m_UpdateItemDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_UpdateItemDict");
		NativeFieldInfoPtr_m_TemplateLabelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_TemplateLabelList");
		NativeFieldInfoPtr_m_PlayerIconTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_PlayerIconTable");
		NativeFieldInfoPtr_m_PlayerFrameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_PlayerFrameTable");
		NativeFieldInfoPtr_m_CloseTemprary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_CloseTemprary");
		NativeFieldInfoPtr_m_bgObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_bgObj");
		NativeFieldInfoPtr_m_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_IsOpen");
		NativeFieldInfoPtr_m_SpSummonFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_SpSummonFlag");
		NativeFieldInfoPtr_m_SpSummonFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_SpSummonFlagCount");
		NativeFieldInfoPtr_m_ChainCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, "m_ChainCount");
		NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665122);
		NativeMethodInfoPtr_get_onChangeOpenClose_Public_get_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665123);
		NativeMethodInfoPtr_set_onChangeOpenClose_Public_set_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665124);
		NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665125);
		NativeMethodInfoPtr_set_IsReady_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665126);
		NativeMethodInfoPtr_get_m_IsIndent_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665127);
		NativeMethodInfoPtr_get_m_LogBaseItemList_Private_get_List_1_LogBaseDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665128);
		NativeMethodInfoPtr_get_m_DataList_ShowTurn_Private_get_List_1_ShowTurnDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665129);
		NativeMethodInfoPtr_get_m_DataList_ShowAction_Private_get_List_1_ShowActionDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665130);
		NativeMethodInfoPtr_get_m_DataList_ShowChain_Private_get_List_1_ShowChainDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr_get_m_DataList_ShowCardName_Private_get_List_1_ShowCardNameDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665132);
		NativeMethodInfoPtr_get_m_DataList_ShowText_Private_get_List_1_ShowTextDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665133);
		NativeMethodInfoPtr_get_m_DataList_ShowPhase_Private_get_List_1_ShowPhaseDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665134);
		NativeMethodInfoPtr_get_m_DataList_ShowTag_Private_get_List_1_ShowTagTypeForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665135);
		NativeMethodInfoPtr_Create_Public_Static_DuelLogForAnalysis_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665136);
		NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665137);
		NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665138);
		NativeMethodInfoPtr_CloseTemprary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665139);
		NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665140);
		NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665141);
		NativeMethodInfoPtr_SetAutoScroll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665142);
		NativeMethodInfoPtr_SetShortkeyIconVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665143);
		NativeMethodInfoPtr_AddLogData_Public_Void_ViewType_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665144);
		NativeMethodInfoPtr_AddLogText_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665145);
		NativeMethodInfoPtr_UpdateLogData_Public_Void_DuelLogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665146);
		NativeMethodInfoPtr_OnUpdateListItemBase_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665147);
		NativeMethodInfoPtr_OnUpdateShowTurn_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665148);
		NativeMethodInfoPtr_OnUpdateShowAction_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665149);
		NativeMethodInfoPtr_OnUpdateShowChain_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665150);
		NativeMethodInfoPtr_OnUpdateShowTag_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665151);
		NativeMethodInfoPtr_OnUpdateShowCardName_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665152);
		NativeMethodInfoPtr_OnUpdateShowText_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665153);
		NativeMethodInfoPtr_OnUpdateShowPhase_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665154);
		NativeMethodInfoPtr_OnUpdateSeparateLine_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665155);
		NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665156);
		NativeMethodInfoPtr_OnScrollViewReady_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665157);
		NativeMethodInfoPtr_initializeComponent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665158);
		NativeMethodInfoPtr_InitializeDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665159);
		NativeMethodInfoPtr_GetActionType_Private_LOGACTIONTYPE_CardMoveType_CardStatus_CardStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665160);
		NativeMethodInfoPtr_CheckSpSummon_Private_Void_byref_LOGACTIONTYPE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665161);
		NativeMethodInfoPtr_SetSelectorPriority_Public_Void_DuelSelectorPriority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665162);
		NativeMethodInfoPtr_SetPlayerIcon_Public_Boolean_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665163);
		NativeMethodInfoPtr_CheckCardidValid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665164);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665165);
		NativeMethodInfoPtr__initializeComponent_b__87_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665166);
		NativeMethodInfoPtr__InitializeDict_b__88_0_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr, 100665167);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51102, XrefRangeEnd = 51122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DuelLogForAnalysis Create(Transform parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_DuelLogForAnalysis_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DuelLogForAnalysis>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51122, XrefRangeEnd = 51138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Open()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51159, RefRangeEnd = 51161, XrefRangeStart = 51138, XrefRangeEnd = 51159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51161, XrefRangeEnd = 51162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseTemprary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseTemprary_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51162, XrefRangeEnd = 51178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51178, XrefRangeEnd = 51185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAlpha(float alpha)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&alpha);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51185, RefRangeEnd = 51186, XrefRangeStart = 51185, XrefRangeEnd = 51185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAutoScroll(bool auto)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&auto);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAutoScroll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51186, XrefRangeEnd = 51194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShortkeyIconVisible(bool visible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&visible);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShortkeyIconVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51194, XrefRangeEnd = 51200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLogData(Engine.ViewType viewType, int param1, int param2, int param3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&viewType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &param1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &param2;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &param3;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLogData_Public_Void_ViewType_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLogText(int player, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLogText_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51200, XrefRangeEnd = 51233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLogData(DuelLogData duelLogData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)duelLogData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLogData_Public_Void_DuelLogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51233, XrefRangeEnd = 51240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateListItemBase(GameObject gob, int baseitemindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gob);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseitemindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateListItemBase_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51240, XrefRangeEnd = 51260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateShowTurn(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateShowTurn_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51260, XrefRangeEnd = 51267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateShowAction(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateShowAction_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51267, XrefRangeEnd = 51274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateShowChain(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateShowChain_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51274, XrefRangeEnd = 51290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateShowTag(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateShowTag_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51290, XrefRangeEnd = 51298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateShowCardName(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateShowCardName_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51298, XrefRangeEnd = 51321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateShowText(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateShowText_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51321, XrefRangeEnd = 51329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateShowPhase(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateShowPhase_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateSeparateLine(GameObject eom, int dataindex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataindex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateSeparateLine_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51329, XrefRangeEnd = 51331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51331, XrefRangeEnd = 51337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScrollViewReady()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScrollViewReady_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51382, RefRangeEnd = 51384, XrefRangeStart = 51337, XrefRangeEnd = 51382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeComponent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51587, RefRangeEnd = 51589, XrefRangeStart = 51384, XrefRangeEnd = 51587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeDict()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51589, XrefRangeEnd = 51591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LOGACTIONTYPE GetActionType(Engine.CardMoveType moveType, Engine.CardStatus stFrom, Engine.CardStatus stTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&moveType);
		*(Engine.CardStatus**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stFrom;
		*(Engine.CardStatus**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stTo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionType_Private_LOGACTIONTYPE_CardMoveType_CardStatus_CardStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LOGACTIONTYPE*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51591, XrefRangeEnd = 51596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckSpSummon(ref LOGACTIONTYPE actiontype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref actiontype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSpSummon_Private_Void_byref_LOGACTIONTYPE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51596, XrefRangeEnd = 51605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&priority);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectorPriority_Public_Void_DuelSelectorPriority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51605, XrefRangeEnd = 51618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetPlayerIcon(Image img, int playerid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerid;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerIcon_Public_Boolean_Image_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool CheckCardidValid(int cardid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cardid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCardidValid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51618, XrefRangeEnd = 51666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DuelLogForAnalysis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuelLogForAnalysis>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51666, XrefRangeEnd = 51667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _initializeComponent_b__87_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__initializeComponent_b__87_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51667, XrefRangeEnd = 51669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitializeDict_b__88_0(Vector2 scroll)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scroll);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitializeDict_b__88_0_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DuelLogForAnalysis(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
