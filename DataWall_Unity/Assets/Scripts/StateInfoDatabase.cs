using UnityEngine;

public class StateInfoDatabase : MonoBehaviour
{
	[System.Serializable]
	public struct StateInfo
	{
		public StateName stateName;
		public YearlyData[] timelineData;
	}

	[System.Serializable]
	public struct YearlyData
	{
		public DataYear year;
		[Header("Manually-Entered Stats")]
		public int popNetNominal;
		//TODO: more stats
		[Header("Runtime-Calculated Stats")]
		public RuntimeStats runtimeStats;
	}

	[System.Serializable]
	public struct RuntimeStats
	{
		public int popRelativePercent;
	}

	public StateInfo[] stateInfo;
	public YearlyData[] countryTotals;

	private void Start()
	{
		this.CalculateSubStats();
	}

	[ContextMenu("Populate Presets")]
	public void PopulatePresets()
	{
		this.stateInfo = new StateInfo[System.Enum.GetNames(typeof(StateName)).Length];

		for (int i = 0; i < System.Enum.GetNames(typeof(StateName)).Length; i++) {
			this.stateInfo[i].stateName = (StateName)System.Enum.Parse(
				typeof(StateName),
				System.Enum.GetNames(typeof(StateName))[i]);

			this.stateInfo[i].timelineData = new YearlyData[System.Enum.GetNames(typeof(DataYear)).Length];

			for (int j = 0; j < System.Enum.GetNames(typeof(DataYear)).Length; j++) {
				this.stateInfo[i].timelineData[j].year = (DataYear)System.Enum.Parse(
					typeof(DataYear),
					System.Enum.GetNames(typeof(DataYear))[j]);
			}
		}

		this.countryTotals = new YearlyData[System.Enum.GetNames(typeof(DataYear)).Length];

		for (int i = 0; i < System.Enum.GetNames(typeof(DataYear)).Length; i++) {
			this.countryTotals[i].year = (DataYear)System.Enum.Parse(
				typeof(DataYear),
				System.Enum.GetNames(typeof(DataYear))[i]);

			this.countryTotals[i].runtimeStats.popRelativePercent = 100;
		}
	}

	[ContextMenu("Calculate Sub-Statistics")]
	private void CalculateSubStats()
	{
		if (this.countryTotals[0].popNetNominal == 0) {
			return;
		}

		foreach (var state in this.stateInfo) {
			for (int i = 0; i < state.timelineData.Length; i++) {
				state.timelineData[i].runtimeStats.popRelativePercent =
					state.timelineData[i].popNetNominal / this.countryTotals[i].popNetNominal;
			}
		}
	}
}
