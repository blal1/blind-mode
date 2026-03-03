using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x200040C")]
public class TaskManager
{
	[Token(Token = "0x200040D")]
	public delegate bool Task(ID tThis, int fExecNum, float fExecSec, object tParam);

	[Token(Token = "0x200040E")]
	public class ID
	{
		[Token(Token = "0x4001414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected object m_tId;

		[Token(Token = "0x4001415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int m_nCategory;

		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		protected ID()
		{
		}

		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		public int GetCategory()
		{
			return default(int);
		}

		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x5C7C70", Offset = "0x5C6E70", VA = "0x1805C7C70")]
		public bool IsRemoved()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200040F")]
	private class HighLevelID : ID
	{
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public HighLevelID()
		{
		}

		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x5C7390", Offset = "0x5C6590", VA = "0x1805C7390")]
		public void Reset(int nCategory, TaskData tTaskData)
		{
		}

		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x5C7360", Offset = "0x5C6560", VA = "0x1805C7360")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000410")]
	private class TaskData
	{
		[Token(Token = "0x4001416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Task m_tTask;

		[Token(Token = "0x4001417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object m_tParam;

		[Token(Token = "0x4001418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object m_tLocalData;

		[Token(Token = "0x4001419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HighLevelID m_tId;

		[Token(Token = "0x400141A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_nExecNum;

		[Token(Token = "0x400141B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_pause;

		[Token(Token = "0x400141C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_nowSec;

		[Token(Token = "0x400141D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_prevSec;

		[Token(Token = "0x400141E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_timeSpeed;

		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x5DC460", Offset = "0x5DB660", VA = "0x1805DC460")]
		public TaskData()
		{
		}

		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x5DC4E0", Offset = "0x5DB6E0", VA = "0x1805DC4E0")]
		public TaskData(int nCategory, Task tTaskVal, object tParamVal)
		{
		}

		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x5DC3E0", Offset = "0x5DB5E0", VA = "0x1805DC3E0")]
		public void Terminate()
		{
		}

		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x5DC330", Offset = "0x5DB530", VA = "0x1805DC330")]
		public void Reset(int nCategory, Task tTaskVal, object tParamVal)
		{
		}

		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x5DC160", Offset = "0x5DB360", VA = "0x1805DC160")]
		public bool ExecuteTask()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x5DC310", Offset = "0x5DB510", VA = "0x1805DC310")]
		public void Start()
		{
		}

		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x5DC280", Offset = "0x5DB480", VA = "0x1805DC280")]
		public void Pause(bool enable)
		{
		}

		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x5DC310", Offset = "0x5DB510", VA = "0x1805DC310")]
		public void ResetDeltaTimer()
		{
		}

		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x5DC3D0", Offset = "0x5DB5D0", VA = "0x1805DC3D0")]
		public void SetTimeSpeed(float speedRatio)
		{
		}

		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x5DC2D0", Offset = "0x5DB4D0", VA = "0x1805DC2D0")]
		public void Remove()
		{
		}

		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		public void SetLocalData(object data)
		{
		}

		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		public object GetLocalData()
		{
			return null;
		}

		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		public object GetParam()
		{
			return null;
		}

		[Token(Token = "0x6001A1A")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		public ID GetId()
		{
			return null;
		}

		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x5DC220", Offset = "0x5DB420", VA = "0x1805DC220")]
		public string GetTaskName()
		{
			return null;
		}

		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x5DC210", Offset = "0x5DB410", VA = "0x1805DC210")]
		public float GetNowTime()
		{
			return default(float);
		}

		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		public int GetExecNum()
		{
			return default(int);
		}

		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x5DC130", Offset = "0x5DB330", VA = "0x1805DC130")]
		public bool CheckId(ID tID)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x5DC150", Offset = "0x5DB350", VA = "0x1805DC150")]
		public bool CheckTask(Task tTask)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x5C7C70", Offset = "0x5C6E70", VA = "0x1805C7C70")]
		public bool IsTerminate()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x5DC260", Offset = "0x5DB460", VA = "0x1805DC260")]
		public bool IsRemoved()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x4166A0", Offset = "0x4158A0", VA = "0x1804166A0")]
		public bool IsPause()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000411")]
	private class TaskCategoryData
	{
		[Token(Token = "0x400141F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<TaskData> m_lstTaskQue;

		[Token(Token = "0x4001420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<TaskData> m_lstNextTaskQue;

		[Token(Token = "0x4001421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_nCategoryId;

		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x5DC070", Offset = "0x5DB270", VA = "0x1805DC070")]
		public TaskCategoryData(int categoryId)
		{
		}

		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x5DBBD0", Offset = "0x5DADD0", VA = "0x1805DBBD0")]
		public bool Remove(ID tId, bool isReserve = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x5DB840", Offset = "0x5DAA40", VA = "0x1805DB840")]
		public bool RemoveAt(int nIndex, bool isReserve = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x5DB950", Offset = "0x5DAB50", VA = "0x1805DB950")]
		public void RemoveTask(Task tTask, bool isReserve = false)
		{
		}

		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x5DB580", Offset = "0x5DA780", VA = "0x1805DB580")]
		public void RemoveAll(bool isReserve = false)
		{
		}

		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x5DAFA0", Offset = "0x5DA1A0", VA = "0x1805DAFA0")]
		public void ImportNextTask()
		{
		}

		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x5DA360", Offset = "0x5D9560", VA = "0x1805DA360")]
		public void ClearRemoveTask()
		{
		}

		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x5DBE80", Offset = "0x5DB080", VA = "0x1805DBE80")]
		public void SetTaskTimeSpeed(float speedRatio)
		{
		}

		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x5DB370", Offset = "0x5DA570", VA = "0x1805DB370")]
		public void Pause(bool enable)
		{
		}

		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x5DBCA0", Offset = "0x5DAEA0", VA = "0x1805DBCA0")]
		public void ResetDeltaTimer()
		{
		}

		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		public List<TaskData> GetTaskQue()
		{
			return null;
		}

		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		public List<TaskData> GetNextTaskQue()
		{
			return null;
		}

		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x5DAA80", Offset = "0x5D9C80", VA = "0x1805DAA80")]
		public int GetTaskIndex(ID tId)
		{
			return default(int);
		}

		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x5DA850", Offset = "0x5D9A50", VA = "0x1805DA850")]
		public TaskData GetTaskData(ID tId)
		{
			return null;
		}

		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x5DACD0", Offset = "0x5D9ED0", VA = "0x1805DACD0")]
		public List<TaskData> GetTaskTypeDataList(Task tTask)
		{
			return null;
		}

		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		public int GetCategoryId()
		{
			return default(int);
		}

		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x5DA800", Offset = "0x5D9A00", VA = "0x1805DA800")]
		public int GetTaskCount()
		{
			return default(int);
		}

		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x5DB130", Offset = "0x5DA330", VA = "0x1805DB130")]
		public bool IsTaskType(Task tTask)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x5DB030", Offset = "0x5DA230", VA = "0x1805DB030")]
		public bool IsTaskType(Task tTask, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x5DA550", Offset = "0x5D9750", VA = "0x1805DA550")]
		public string GetDebugString(List<TaskData> tTaskQue)
		{
			return null;
		}

		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x5DA300", Offset = "0x5D9500", VA = "0x1805DA300")]
		public bool CheckQueIndexEnable(int nIndex)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000413")]
	private class TaskPool
	{
		[Token(Token = "0x4001425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<TaskData> m_pool;

		[Token(Token = "0x4001426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_nowIndex;

		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x5DF290", Offset = "0x5DE490", VA = "0x1805DF290")]
		public TaskPool(int capacity)
		{
		}

		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x5DF1A0", Offset = "0x5DE3A0", VA = "0x1805DF1A0")]
		public TaskData New()
		{
			return null;
		}

		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x5DEFE0", Offset = "0x5DE1E0", VA = "0x1805DEFE0")]
		private void AddReserve(int num)
		{
		}
	}

	[Token(Token = "0x400140D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool m_globalPause;

	[Token(Token = "0x400140E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<int, TaskCategoryData> m_tblTaskContainer;

	[Token(Token = "0x400140F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TaskPool m_taskPool;

	[Token(Token = "0x4001410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, bool> m_pauseCategoryList;

	[Token(Token = "0x4001411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, float> m_timeSpeedCategoryList;

	[Token(Token = "0x4001412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_executeTaskLimit;

	[Token(Token = "0x4001413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool m_executeTaskQueIndexReset;

	[Token(Token = "0x60019DB")]
	[Address(RVA = "0x5DD8A0", Offset = "0x5DCAA0", VA = "0x1805DD8A0")]
	public static void GlobalPause(bool enable)
	{
	}

	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x5DEE60", Offset = "0x5DE060", VA = "0x1805DEE60")]
	public TaskManager(int reserveCategoryNum = 10, int reserveTaskNum = 50, int executeTaskLimit = 1000)
	{
	}

	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x5DC880", Offset = "0x5DBA80", VA = "0x1805DC880")]
	public bool Execute(int nCategory, bool bClear, float limitTime = -1f)
	{
		return default(bool);
	}

	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x5DE950", Offset = "0x5DDB50", VA = "0x1805DE950")]
	public void ResetExecuteIndex()
	{
	}

	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x5DE1A0", Offset = "0x5DD3A0", VA = "0x1805DE1A0")]
	public void Pause(ID tId, bool enable)
	{
	}

	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x5DE0D0", Offset = "0x5DD2D0", VA = "0x1805DE0D0")]
	public void PauseCategory(int nCategory, bool enable)
	{
	}

	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x5DDED0", Offset = "0x5DD0D0", VA = "0x1805DDED0")]
	public void PauseAll(bool enable)
	{
	}

	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x5DC850", Offset = "0x5DBA50", VA = "0x1805DC850")]
	public ID Add(int nCategory, Task tTask, [Optional] object tParam, bool startTimer = false)
	{
		return null;
	}

	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x5DC5A0", Offset = "0x5DB7A0", VA = "0x1805DC5A0")]
	public ID AddNext(int nCategory, Task tTask, [Optional] object tParam, bool startTimer = false)
	{
		return null;
	}

	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x5DD8E0", Offset = "0x5DCAE0", VA = "0x1805DD8E0")]
	public ID Insert(int nCategory, int nIndex, Task tTask, [Optional] object tParam, bool startTimer = false)
	{
		return null;
	}

	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x5DD8E0", Offset = "0x5DCAE0", VA = "0x1805DD8E0")]
	public ID InsertNext(int nCategory, int nIndex, Task tTask, [Optional] object tParam, bool startTimer = false)
	{
		return null;
	}

	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x5DE810", Offset = "0x5DDA10", VA = "0x1805DE810")]
	public bool Remove(ID tId)
	{
		return default(bool);
	}

	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x5DE500", Offset = "0x5DD700", VA = "0x1805DE500")]
	public bool RemoveAt(int nCategory, int nIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x5DE700", Offset = "0x5DD900", VA = "0x1805DE700")]
	public bool RemoveCategory(int nCategory)
	{
		return default(bool);
	}

	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x5DE5D0", Offset = "0x5DD7D0", VA = "0x1805DE5D0")]
	public bool RemoveCategoryTask(int nCategory, Task tTask)
	{
		return default(bool);
	}

	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x5DE2B0", Offset = "0x5DD4B0", VA = "0x1805DE2B0")]
	public bool RemoveAll()
	{
		return default(bool);
	}

	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x5DEAD0", Offset = "0x5DDCD0", VA = "0x1805DEAD0")]
	public bool SetLocalData(ID tId, object data)
	{
		return default(bool);
	}

	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x5DEBE0", Offset = "0x5DDDE0", VA = "0x1805DEBE0")]
	public bool SetTimeSpeed(ID tId, float speedRatio)
	{
		return default(bool);
	}

	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x5DECF0", Offset = "0x5DDEF0", VA = "0x1805DECF0")]
	public bool SetTimeSpeed(int nCategory, float speedRatio)
	{
		return default(bool);
	}

	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x5DD060", Offset = "0x5DC260", VA = "0x1805DD060")]
	public object GetParam(ID tId)
	{
		return null;
	}

	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x5DCFB0", Offset = "0x5DC1B0", VA = "0x1805DCFB0")]
	public object GetLocalData(ID tId)
	{
		return null;
	}

	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x5DD850", Offset = "0x5DCA50", VA = "0x1805DD850")]
	public float GetTaskTime(ID tId)
	{
		return default(float);
	}

	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x5DD2D0", Offset = "0x5DC4D0", VA = "0x1805DD2D0")]
	public int GetTaskExecuteNum(ID tId)
	{
		return default(int);
	}

	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x5DD320", Offset = "0x5DC520", VA = "0x1805DD320")]
	public ID GetTaskId(int nCategory, Task tTask, int nNum)
	{
		return null;
	}

	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x5DD500", Offset = "0x5DC700", VA = "0x1805DD500")]
	public ID GetTaskIndexId(int nCategory, int nIndex)
	{
		return null;
	}

	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x5DD5C0", Offset = "0x5DC7C0", VA = "0x1805DD5C0")]
	public int GetTaskIndex(ID tId)
	{
		return default(int);
	}

	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x5DD740", Offset = "0x5DC940", VA = "0x1805DD740")]
	public string GetTaskName(ID tId)
	{
		return null;
	}

	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x5DD600", Offset = "0x5DC800", VA = "0x1805DD600")]
	public string GetTaskName(int nCategory, int nIndex = 1)
	{
		return null;
	}

	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x5DCEF0", Offset = "0x5DC0F0", VA = "0x1805DCEF0")]
	public string GetDebugInfo(int nCategory)
	{
		return null;
	}

	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x5DD7F0", Offset = "0x5DC9F0", VA = "0x1805DD7F0")]
	public int GetTaskNum(int nCategory)
	{
		return default(int);
	}

	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x5DD000", Offset = "0x5DC200", VA = "0x1805DD000")]
	public int GetNextTaskNum(int nCategory)
	{
		return default(int);
	}

	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x5DDBE0", Offset = "0x5DCDE0", VA = "0x1805DDBE0")]
	public bool IsEmpty(int nCategory)
	{
		return default(bool);
	}

	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x5DDC60", Offset = "0x5DCE60", VA = "0x1805DDC60")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x5DDEA0", Offset = "0x5DD0A0", VA = "0x1805DDEA0")]
	public bool IsTaskType(int nCategory, Task tTask)
	{
		return default(bool);
	}

	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x5DDDD0", Offset = "0x5DCFD0", VA = "0x1805DDDD0")]
	public bool IsTaskType(int nCategory, int index, Task tTask)
	{
		return default(bool);
	}

	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x5DE960", Offset = "0x5DDB60", VA = "0x1805DE960")]
	private void SetCategoryPauseFlag(int nCategory, bool enable)
	{
	}

	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x5DEA20", Offset = "0x5DDC20", VA = "0x1805DEA20")]
	private void SetCategoryTimeSpeed(int nCategory, float speedRatio)
	{
	}

	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x5DD0B0", Offset = "0x5DC2B0", VA = "0x1805DD0B0")]
	private TaskCategoryData GetTaskCategoryData(int nCategory)
	{
		return null;
	}

	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x5DC5D0", Offset = "0x5DB7D0", VA = "0x1805DC5D0")]
	private ID AddTaskData(bool bAddNextTaskQue, int nCategory, Task tTask, object tParam, bool startTimer)
	{
		return null;
	}

	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x5DD920", Offset = "0x5DCB20", VA = "0x1805DD920")]
	private ID InsertTaskData(bool bAddNextTaskQue, int nCategory, int nIndex, Task tTask, object tParam, bool startTimer)
	{
		return null;
	}
}
