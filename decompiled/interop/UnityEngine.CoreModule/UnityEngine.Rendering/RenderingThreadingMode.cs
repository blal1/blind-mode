namespace UnityEngine.Rendering;

public enum RenderingThreadingMode
{
	Direct,
	SingleThreaded,
	MultiThreaded,
	LegacyJobified,
	NativeGraphicsJobs,
	NativeGraphicsJobsWithoutRenderThread,
	NativeGraphicsJobsSplitThreading
}
