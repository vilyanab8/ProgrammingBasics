int period = int.Parse(Console.ReadLine());
int treatedPatients = 0;
int untreatedPatients = 0;
int doctors = 7;

for (int i = 1; i <= period; i++)
{
    int patients = int.Parse(Console.ReadLine());
	if (i % 3 == 0 && untreatedPatients > treatedPatients)
	{
		doctors++;
	}
	if (patients > doctors)
	{
        untreatedPatients += patients - doctors;
        treatedPatients += doctors;
    }
	else
	{
        treatedPatients += patients;
    }
}

Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
