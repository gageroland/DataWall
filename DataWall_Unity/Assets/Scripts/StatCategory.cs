using StreamReader = System.IO.StreamReader;

public static class StatCategory
{
	private static StreamReader IOReader;

	//String paths to Legal Immigration DataFiles
	private static string Path_LegalPopulationNominal
		= "";
	private static string Path_LegalPopulationPercentage
		= "";
	private static string Path_LegalAgeBySexNominal
		= "";
	private static string Path_LegalAgeBySexPercentage
		= "";

	//String paths to Unauthorized Immigration DataFiles
	private static string Path_UnauthorizedPopulationNominal
		= "";
	private static string Path_UnauthorizedPopulationPercentage
		= "";
	private static string Path_UnauthorizedAgeBySexNominal
		= "";
	private static string Path_UnauthorizedAgeBySexPercentage
		= "";

	public static float GetData(StateName stateName, DataYear dataYear,
		ImmigrationType immigrationType, FormatType formatType)
	{
		switch (immigrationType)
		{
			case ImmigrationType.Legal:
				//
				switch (formatType)
				{
					//
					case FormatType.PopulationNominal:
						IOReader = new StreamReader(Path_LegalPopulationNominal);
						return GetPopulationNominal(stateName, dataYear);
					//
					case FormatType.PopulationPercentage:
						IOReader = new StreamReader(Path_LegalPopulationPercentage);
						return GetPopulationPercentage(stateName, dataYear);
					//
					case FormatType.AgeBySexNominal:
						IOReader = new StreamReader(Path_LegalAgeBySexNominal);
						return GetAgeBySexNominal(stateName, dataYear);
					//
					case FormatType.AgeBySexPercentage:
						IOReader = new StreamReader(Path_LegalAgeBySexPercentage);
						return GetAgeBySexPercentage(stateName, dataYear);
					//
					default:
						return 0;
				}
			case ImmigrationType.Unauthorized:
				//
				switch (formatType)
				{
					//
					case FormatType.PopulationNominal:
						IOReader = new StreamReader(Path_UnauthorizedPopulationNominal);
						return GetPopulationNominal(stateName, dataYear);
					//
					case FormatType.PopulationPercentage:
						IOReader = new StreamReader(Path_UnauthorizedPopulationPercentage);
						return GetPopulationPercentage(stateName, dataYear);
					//
					case FormatType.AgeBySexNominal:
						IOReader = new StreamReader(Path_UnauthorizedAgeBySexNominal);
						return GetAgeBySexNominal(stateName, dataYear);
					//
					case FormatType.AgeBySexPercentage:
						IOReader = new StreamReader(Path_UnauthorizedAgeBySexPercentage);
						return GetAgeBySexPercentage(stateName, dataYear);
					//
					default:
						return 0;
				}
			default:
				return 0;
		}
	}

	private static float GetPopulationNominal(StateName stateName, DataYear dataYear)
	{

		return 0;
	}

	private static float GetPopulationPercentage(StateName stateName, DataYear dataYear)
	{
		return 0;
	}

	private static float GetAgeBySexNominal(StateName stateName, DataYear dataYear)
	{
		return 0;
	}

	private static float GetAgeBySexPercentage(StateName stateName, DataYear dataYear)
	{
		return 0;
	}
}
